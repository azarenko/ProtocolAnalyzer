using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FTD2XX_NET;
using ProtocolAnalyzer.Properties;
using System.Globalization;
using System.Diagnostics;

namespace ProtocolAnalyzer
{
    public partial class Form1 : Form
    {
        private FTDI ftdi = new FTDI();
        private FTDI.FT_DEVICE_INFO_NODE[] deviceList;        

        public Form1()
        {
            InitializeComponent();
            lin_raw_receive_Func_handler = new DoWorkEventHandler(lin_raw_receive_Func);
            lin_raw_repeat_handler = new EventHandler(lin_raw_repeat_func);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _statusInfo.Text = "Disconnected";

            uint ftdiDeviceCount = 0;

            if (ftdi.GetNumberOfDevices(ref ftdiDeviceCount) != FTDI.FT_STATUS.FT_OK)
            {
                ShowError("Failed to get number of devices");
                return;
            }

            if (ftdiDeviceCount == 0)
            {
                ShowError("Failed to get number of devices");
                return;
            }

            deviceList = new FTDI.FT_DEVICE_INFO_NODE[ftdiDeviceCount];

            if (ftdi.GetDeviceList(deviceList) != FTDI.FT_STATUS.FT_OK)
            {
                ShowError("Cannot enumerate devices");
            }

            foreach (FTDI.FT_DEVICE_INFO_NODE device in deviceList)
            {
                if (device != null)
                {
                    _device.Items.Add(device.SerialNumber);
                }
            }

            if (_device.Items.Count > 0)
            {
                _device.SelectedIndex = 0;
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _connect_Click(object sender, EventArgs e)
        {
            if (deviceList == null)
            {
                ShowError("No device to open");
                return;
            }

            if (deviceList.Length == 0)
            {
                ShowError("No device to open");
                return;
            }

            if (ftdi.IsOpen)
            {
                ShowWarning("Device is connected");
                return;
            }

            var ftStatus = ftdi.OpenBySerialNumber(deviceList[_device.SelectedIndex].SerialNumber);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {                
                ShowError("Failed to open device (error " + ftStatus.ToString() + ")");
                return;
            }

            _statusInfo.Text = string.Format("Connected to {0}", deviceList[_device.SelectedIndex].SerialNumber);
        }

        private void _disconnect_Click(object sender, EventArgs e)
        {
            if (!ftdi.IsOpen)
            {
                ShowWarning("Device is disconnected");
                return;
            }

            var ftStatus = ftdi.Close();
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                ShowError("Failed to close device (error " + ftStatus.ToString() + ")");
                return;
            }
            
            _statusInfo.Text = "Disconnected";
        }

        private DoWorkEventHandler lin_raw_receive_Func_handler;
        private void lin_raw_receive_Func(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            byte[] readbuffer = new byte[128];
            byte[] pipebuffer = new byte[1024];
            int pipepointer = 0;
            uint availableBytes = 0;
            uint readedBytes = 0;

            do
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                if (ftdi.IsOpen)
                {
                    availableBytes = 0;
                    FTDI.FT_STATUS ftStatus = ftdi.GetRxBytesAvailable(ref availableBytes);
                    if (ftStatus == FTDI.FT_STATUS.FT_OK)
                    {
                        if (availableBytes > 0)
                        {
                            ftStatus = ftdi.Read(readbuffer, availableBytes, ref readedBytes);
                            if (ftStatus == FTDI.FT_STATUS.FT_OK)
                            {
                                //Utilites.CopyToByteArray(pipebuffer, readbuffer, pipepointer, 0, (int)readedBytes);
                                //pipepointer += (int)readedBytes;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
                Thread.Sleep(1);
            }
            while (true);
        }

        private void _lin_raw_attachtodevice_CheckedChanged(object sender, EventArgs e)
        {
            if (!ftdi.IsOpen)
            {
                if ((sender as CheckBox).Checked)
                {
                    ShowError("Device is not open");
                    (sender as CheckBox).Checked = false;
                }
                return;
            }

            if (!(sender as CheckBox).Checked)
            {
                backgroundWorker1.CancelAsync();
                backgroundWorker1.DoWork -= lin_raw_receive_Func_handler;                
            }
            else
            {
                if (backgroundWorker1.IsBusy != true)
                {
                    var ftStatus = SetDeviceProperty(Convert.ToUInt32(_lin_raw_baudrate.Value)
                        ,FTDI.FT_DATA_BITS.FT_BITS_8
                        ,FTDI.FT_STOP_BITS.FT_STOP_BITS_1
                        ,FTDI.FT_PARITY.FT_PARITY_NONE
                        ,FTDI.FT_FLOW_CONTROL.FT_FLOW_NONE
                        ,0
                        ,0
                        ,1000
                        ,0
                        ,false
                        ,false);

                    if (ftStatus != FTDI.FT_STATUS.FT_OK)
                    {
                        ShowError("Failed to set data characteristics (error " + ftStatus.ToString() + ")");
                        (sender as CheckBox).Checked = false;
                        return;
                    }

                    backgroundWorker1.DoWork += lin_raw_receive_Func_handler;
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    ShowWarning("Device is busy");
                    (sender as CheckBox).Checked = false;
                    return;
                }
            }
        }

        private FTDI.FT_STATUS SetDeviceProperty(uint baudrate
            ,byte databits
            ,byte stopbits
            ,byte parity
            ,ushort flowcontrol
            ,byte Xon
            ,byte Xoff
            ,uint readtimeout
            ,uint writetimeout
            ,bool dtr
            ,bool rts)
        {
            FTDI.FT_STATUS ftStatus = ftdi.SetBaudRate(baudrate);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {                
                return ftStatus;
            }

            ftStatus = ftdi.SetDataCharacteristics(databits, stopbits, parity);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                return ftStatus;
            }

            ftStatus = ftdi.SetFlowControl(flowcontrol, Xon, Xoff);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                return ftStatus;
            }
            
            ftStatus = ftdi.SetTimeouts(readtimeout, writetimeout);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                return ftStatus;
            }

            ftStatus = ftdi.SetDTR(dtr);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                return ftStatus;
            }

            ftStatus = ftdi.SetRTS(rts);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                return ftStatus;
            }

            return FTDI.FT_STATUS.FT_OK;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void _lin_raw_send_data_Click(object sender, EventArgs e)
        {
            if (!ftdi.IsOpen)
            {
                ShowError("Device is not open");
                return;
            }

            if (!backgroundWorker1.IsBusy)
            {
                ShowError("Device is attached");
                return;
            }

            byte identifier, data, checksum;

            if (!byte.TryParse(_lin_raw_identifier.Text, NumberStyles.HexNumber, null, out identifier))
            {
                ShowError("Identifier have invalid format");
                return;
            }

            if(!byte.TryParse(_lin_raw_data.Text, NumberStyles.HexNumber, null, out data))
            {
                ShowError("Identifier have data format");
                return;
            }

            if (!byte.TryParse(_lin_raw_checksum.Text, NumberStyles.HexNumber, null, out checksum))
            {
                ShowError("Identifier have checksum format");
                return;
            }
            
            FTDI.FT_STATUS status = lin_raw_send_data(Convert.ToUInt32(_lin_raw_baudrate.Value), identifier, data, checksum);
            if (status != FTDI.FT_STATUS.FT_OK)
            {
                ShowError("Failed to set data characteristics (error " + status.ToString() + ")");
            }
        }

        private FTDI.FT_STATUS lin_raw_send_data(uint baudrate, byte identifier, byte data, byte checksum)
        {
            Stopwatch sw = new Stopwatch();

            FTDI.FT_STATUS status = FTDI.FT_STATUS.FT_OK;

            if (!ftdi.IsOpen)
            {
                status = FTDI.FT_STATUS.FT_INVALID_HANDLE;
                return status;
            }

            uint syncbreakBaudRate = (uint)(baudrate / 1.3);
            long ticks = Stopwatch.Frequency / (syncbreakBaudRate / 13);

            status = ftdi.SetBaudRate(syncbreakBaudRate);
            if (status != FTDI.FT_STATUS.FT_OK)
            {
                return status;
            }

            sw.Start();

            uint writtenbytes = 0;
            status = ftdi.Write(new byte[1] { 0x00 }, 1, ref writtenbytes);

            if (status != FTDI.FT_STATUS.FT_OK)
            {
                return status;
            }

            while(sw.ElapsedTicks < ticks) { };

            sw.Stop();

            status = ftdi.SetBaudRate(baudrate);
            if (status != FTDI.FT_STATUS.FT_OK)
            {
                return status;
            }

            byte[] buffer = new byte[4] { 0x55, identifier, data, checksum };
            status = ftdi.Write(buffer, 4, ref writtenbytes);

            if (status != FTDI.FT_STATUS.FT_OK)
            {
                return status;
            }

            if(writtenbytes != buffer.Length)
            {
                return FTDI.FT_STATUS.FT_FAILED_TO_WRITE_DEVICE;
            }

            return status;
        }

        private void _lin_raw_repeat_CheckedChanged(object sender, EventArgs e)
        {
            if (!ftdi.IsOpen)
            {
                ShowError("Device is not open");
                return;
            }

            if (!backgroundWorker1.IsBusy)
            {
                ShowError("Device is attached");
                return;
            }

            CheckBox cb = (CheckBox)sender;

            if (cb.Checked)
            {
                if (!timer1.Enabled)
                {
                    timer1.Interval = (int)_lin_raw_repeat_value.Value;
                    timer1.Tick += lin_raw_repeat_handler;
                    timer1.Start();
                }
            }
            else
            {
                timer1.Stop();
                timer1.Tick -= lin_raw_repeat_handler;
            }
        }

        private EventHandler lin_raw_repeat_handler;
        private void lin_raw_repeat_func(object sender, EventArgs e)
        {
            byte identifier, data, checksum;

            if (!byte.TryParse(_lin_raw_identifier.Text, NumberStyles.HexNumber, null, out identifier))
            {
                ShowError("Identifier have invalid format");
                return;
            }

            if (!byte.TryParse(_lin_raw_data.Text, NumberStyles.HexNumber, null, out data))
            {
                ShowError("Identifier have data format");
                return;
            }

            if (!byte.TryParse(_lin_raw_checksum.Text, NumberStyles.HexNumber, null, out checksum))
            {
                ShowError("Identifier have checksum format");
                return;
            }

            FTDI.FT_STATUS status = lin_raw_send_data(Convert.ToUInt32(_lin_raw_baudrate.Value), identifier, data, checksum);
            if (status != FTDI.FT_STATUS.FT_OK)
            {
                ShowError("Failed to set data characteristics (error " + status.ToString() + ")");
            }
        }
    }
}
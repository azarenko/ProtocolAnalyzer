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
            byte[] buffer = new byte[128];
            int pointer = 0;

            do
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                if (ftdi.IsOpen)
                {
                    
                }
                else
                {
                    break;
                }
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
            var ftStatus = ftdi.SetBaudRate(baudrate);
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
    }
}
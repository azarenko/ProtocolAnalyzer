using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FTD2XX_NET;

namespace ProtocolAnalyzer
{
    public partial class Form1 : Form
    {
        private FTDI ftdi = new FTDI();
        private FTDI.FT_DEVICE_INFO_NODE[] deviceList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
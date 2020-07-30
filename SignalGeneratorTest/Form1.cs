using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeysightFindDevicesApi;
using static KeysightFindDevicesApi.KeysightFindDevices;

namespace SignalGeneratorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (KeysightFindDevices.FindDevices(INTERFACE_TYPE.TCPIP_LAN, out List<KeysightDevice> deviceList, out string outMessage) == false)
            {
                MessageBox.Show("Failed to find devices: " + Environment.NewLine + outMessage);
                return;
            } else
            {
                if (deviceList.Count > 0)
                {
                    foreach (KeysightDevice d in deviceList)
                    {
                        cmbLanVisaAddress.Items.Add(d.VisaAddress + " - " + d.Alias);
                    }
                    cmbLanVisaAddress.SelectedIndex = 0;
                }
            }
        }
    }
}

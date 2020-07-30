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
using N5181ASignalGeneatorApi;
using System.Threading;

namespace SignalGeneratorTest
{
    public partial class Form1 : Form
    {
        List<KeysightDevice> m_deviceList;
        N5181ASignalGeneator m_signal = new N5181ASignalGeneator();
        public Form1()
        {
            
            InitializeComponent();
            groupBox1.Enabled = false;
            if (KeysightFindDevices.FindDevices(INTERFACE_TYPE.TCPIP_LAN, out m_deviceList, out string outMessage) == false)
            {
                MessageBox.Show("Failed to find devices: " + Environment.NewLine + outMessage);
                return;
            } else
            {
                if (m_deviceList.Count > 0)
                {
                    foreach (KeysightDevice d in m_deviceList)
                    {
                        cmbLanVisaAddress.Items.Add(d.VisaAddress + " - " + d.Alias);
                    }
                    cmbLanVisaAddress.SelectedIndex = 0;
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbLanVisaAddress.SelectedIndex == -1)
                return;
            
            if (m_signal.Initialize(m_deviceList[cmbLanVisaAddress.SelectedIndex].VisaAddress, chkReset.Checked , out N5181ASignalGeneator.DriverIdentity di, out string outMessage) == false)
            {
                MessageBox.Show("Failed to connect: " + outMessage);
                return;
            }
            txtFrequency.Text = m_signal.Frequency.ToString();
            txtPower.Text = m_signal.Power.ToString();
            chkOnOff.Checked = m_signal.OutputEnable;
            groupBox1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_signal.Close();
        }

        private void btnSetFreq_Click(object sender, EventArgs e)
        {
            try
            {
                bool b = double.TryParse(txtFrequency.Text, out double value);
                if (b == true)
                {
                    m_signal.Frequency = value;
                    Thread.Sleep(10);
                    txtFrequency.Text = m_signal.Frequency.ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSetPower_Click(object sender, EventArgs e)
        {
            try
            {
                bool b = double.TryParse(txtPower.Text, out double value);
                if (b == true)
                {
                    m_signal.Power = value;
                    Thread.Sleep(10);
                    txtPower.Text = m_signal.Power.ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void chkOnOff_CheckedChanged(object sender, EventArgs e)
        {
            m_signal.OutputEnable = chkOnOff.Checked;
        }
    }
}

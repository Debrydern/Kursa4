using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.ServiceModel;
using HostService;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class MainForm : Form
    {
        ServiceHost host;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                host = new ServiceHost(typeof(HostService.HostService1));
                host.Open();
                consoleBox.Text = $"{DateTime.Now} -> Service started!\n";

            }
            catch (Exception err)
            {
                consoleBox.Text = err.Message;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (host != null)
            {
                host.Close();
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Hide();
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}


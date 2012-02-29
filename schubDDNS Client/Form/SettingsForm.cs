using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using schubDDNS_Client.Properties;

namespace schubDDNS_Client
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        private void Settings_Shown(object sender, EventArgs e)
        {
            //Hide Settings Window after Start
            this.Visible = false;
        }
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Ask before Close!
        }

        private void ToggleVisible()
        {
            if (this.Visible)
                this.Visible = false;
            else
                this.Visible = true;
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            ToggleVisible();
        }
        private void TrayContextMenu_Settings_Click(object sender, EventArgs e)
        {
            ToggleVisible();
        }
        private void TrayContextMenu_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

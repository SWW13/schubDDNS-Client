using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using schubDDNS_Client.Properties;
using System.Collections;

namespace schubDDNS_Client
{
    public partial class SettingsForm : Form
    {
        Timer UpdateTimer = new Timer();

        public SettingsForm()
        {
            InitializeComponent();

            UpdateTimer.Tick += new EventHandler(UpdateTimer_Tick);
            UpdateTimer.Interval = (int)Settings.Default.Interval * 60 * 1000;
            UpdateTimer.Start();
        }
        private void Settings_Shown(object sender, EventArgs e)
        {
            //Hide Settings Window after Start
            this.Visible = false;
        }
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult reslut = 
                MessageBox.Show("If you close the schubDDNS Client it will no longer update your IP.\nAre you sure? Click No Abort.", "schubDDNS Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (reslut == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }

        private void UpdateNow_Click(object sender, EventArgs e)
        {
            object response = DDNS.Update(UpdateURL.Text, Token.Text);

            if (response.GetType() == typeof(Hashtable))
            {
                Hashtable response_hashtable = response as Hashtable;
                String msg = String.Format("status: {0}\nnew ip: {1}", response_hashtable["status"], response_hashtable["new_ip"]);

                MessageBox.Show(msg, "schubDDNS Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            //Set UpdateTimer Interval
            UpdateTimer.Stop();
            UpdateTimer.Interval = (int)Settings.Default.Interval * 60 * 1000;
            UpdateTimer.Start();

            //Save Settings
            Settings.Default.Save();

            //Info Msg
            MessageBox.Show("Settings saved successfully! :)", "schubDDNS Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            DDNS.Update(Settings.Default.UpdateURL, Settings.Default.Token);
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

        private void ToggleVisible()
        {
            if (!this.Visible || !this.Focused)
            {
                this.Visible = true;
                this.BringToFront();
            }
            else
                this.Visible = false;
        }
    }
}

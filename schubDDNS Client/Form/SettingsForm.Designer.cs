namespace schubDDNS_Client
{
    partial class SettingsForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayContextMenu_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayContextMenu_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.label_UpdateURL = new System.Windows.Forms.Label();
            this.label_Token = new System.Windows.Forms.Label();
            this.label_Interval = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Token = new System.Windows.Forms.TextBox();
            this.UpdateURL = new System.Windows.Forms.TextBox();
            this.TrayContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayContextMenu;
            resources.ApplyResources(this.TrayIcon, "TrayIcon");
            this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            // 
            // TrayContextMenu
            // 
            this.TrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayContextMenu_Settings,
            this.TrayContextMenu_Close});
            this.TrayContextMenu.Name = "TrayContextMenu";
            this.TrayContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            resources.ApplyResources(this.TrayContextMenu, "TrayContextMenu");
            // 
            // TrayContextMenu_Settings
            // 
            this.TrayContextMenu_Settings.Name = "TrayContextMenu_Settings";
            resources.ApplyResources(this.TrayContextMenu_Settings, "TrayContextMenu_Settings");
            this.TrayContextMenu_Settings.Click += new System.EventHandler(this.TrayContextMenu_Settings_Click);
            // 
            // TrayContextMenu_Close
            // 
            this.TrayContextMenu_Close.Name = "TrayContextMenu_Close";
            resources.ApplyResources(this.TrayContextMenu_Close, "TrayContextMenu_Close");
            this.TrayContextMenu_Close.Click += new System.EventHandler(this.TrayContextMenu_Close_Click);
            // 
            // label_UpdateURL
            // 
            resources.ApplyResources(this.label_UpdateURL, "label_UpdateURL");
            this.label_UpdateURL.Name = "label_UpdateURL";
            // 
            // label_Token
            // 
            resources.ApplyResources(this.label_Token, "label_Token");
            this.label_Token.Name = "label_Token";
            // 
            // label_Interval
            // 
            resources.ApplyResources(this.label_Interval, "label_Interval");
            this.label_Interval.Name = "label_Interval";
            // 
            // Interval
            // 
            this.Interval.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::schubDDNS_Client.Properties.Settings.Default, "Interval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.Interval, "Interval");
            this.Interval.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Interval.Name = "Interval";
            this.Interval.Value = global::schubDDNS_Client.Properties.Settings.Default.Interval;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Close
            // 
            resources.ApplyResources(this.Close, "Close");
            this.Close.Name = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Token
            // 
            this.Token.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::schubDDNS_Client.Properties.Settings.Default, "Token", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.Token, "Token");
            this.Token.Name = "Token";
            this.Token.Text = global::schubDDNS_Client.Properties.Settings.Default.Token;
            // 
            // UpdateURL
            // 
            this.UpdateURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::schubDDNS_Client.Properties.Settings.Default, "UpdateURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.UpdateURL, "UpdateURL");
            this.UpdateURL.Name = "UpdateURL";
            this.UpdateURL.Text = global::schubDDNS_Client.Properties.Settings.Default.UpdateURL;
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label_Interval);
            this.Controls.Add(this.Token);
            this.Controls.Add(this.label_Token);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.UpdateURL);
            this.Controls.Add(this.label_UpdateURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.TrayContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayContextMenu_Settings;
        private System.Windows.Forms.ToolStripMenuItem TrayContextMenu_Close;
        private System.Windows.Forms.Label label_UpdateURL;
        private System.Windows.Forms.TextBox UpdateURL;
        private System.Windows.Forms.TextBox Token;
        private System.Windows.Forms.Label label_Token;
        private System.Windows.Forms.Label label_Interval;
        private System.Windows.Forms.NumericUpDown Interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Close;
    }
}


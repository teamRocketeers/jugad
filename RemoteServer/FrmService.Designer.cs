namespace RemoteServer
{
    partial class FrmService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmService));
            this.CmdClear = new System.Windows.Forms.Button();
            this.TxtDubug = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CmdHide = new System.Windows.Forms.Button();
            this.CmdSettings = new System.Windows.Forms.Button();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassWord = new System.Windows.Forms.TextBox();
            this.CmdSaveSettings = new System.Windows.Forms.Button();
            this.CmdCancelSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdFirewall = new System.Windows.Forms.Button();
            this.CmdTaskman = new System.Windows.Forms.Button();
            this.CmdHelp = new System.Windows.Forms.Button();
            this.CmdHelpSettings = new System.Windows.Forms.Button();
            this.ImgWinbackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWinbackground)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(141, 369);
            this.CmdClear.Margin = new System.Windows.Forms.Padding(2);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(56, 23);
            this.CmdClear.TabIndex = 0;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            this.CmdClear.MouseHover += new System.EventHandler(this.CmdClear_MouseHover);
            // 
            // TxtDubug
            // 
            this.TxtDubug.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtDubug.ForeColor = System.Drawing.Color.LimeGreen;
            this.TxtDubug.Location = new System.Drawing.Point(2, 6);
            this.TxtDubug.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDubug.Multiline = true;
            this.TxtDubug.Name = "TxtDubug";
            this.TxtDubug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDubug.Size = new System.Drawing.Size(324, 344);
            this.TxtDubug.TabIndex = 1;
            this.TxtDubug.TextChanged += new System.EventHandler(this.TxtDubug_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CmdHide
            // 
            this.CmdHide.Location = new System.Drawing.Point(33, 368);
            this.CmdHide.Margin = new System.Windows.Forms.Padding(2);
            this.CmdHide.Name = "CmdHide";
            this.CmdHide.Size = new System.Drawing.Size(56, 24);
            this.CmdHide.TabIndex = 2;
            this.CmdHide.Text = "Hide";
            this.CmdHide.UseVisualStyleBackColor = true;
            this.CmdHide.Visible = false;
            this.CmdHide.Click += new System.EventHandler(this.CmdHide_Click);
            // 
            // CmdSettings
            // 
            this.CmdSettings.Location = new System.Drawing.Point(239, 369);
            this.CmdSettings.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSettings.Name = "CmdSettings";
            this.CmdSettings.Size = new System.Drawing.Size(56, 24);
            this.CmdSettings.TabIndex = 3;
            this.CmdSettings.Text = "Settings";
            this.CmdSettings.UseVisualStyleBackColor = true;
            this.CmdSettings.Click += new System.EventHandler(this.CmdSettings_Click);
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(156, 6);
            this.TxtPort.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(82, 20);
            this.TxtPort.TabIndex = 4;
            this.TxtPort.Text = "4000";
            this.TxtPort.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TCP Listen port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // TxtPassWord
            // 
            this.TxtPassWord.Location = new System.Drawing.Point(156, 33);
            this.TxtPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassWord.Name = "TxtPassWord";
            this.TxtPassWord.Size = new System.Drawing.Size(82, 20);
            this.TxtPassWord.TabIndex = 6;
            this.TxtPassWord.Text = "ghusneDo";
            this.TxtPassWord.Visible = false;
            this.TxtPassWord.TextChanged += new System.EventHandler(this.TxtPassWord_TextChanged);
            // 
            // CmdSaveSettings
            // 
            this.CmdSaveSettings.Location = new System.Drawing.Point(22, 63);
            this.CmdSaveSettings.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSaveSettings.Name = "CmdSaveSettings";
            this.CmdSaveSettings.Size = new System.Drawing.Size(104, 26);
            this.CmdSaveSettings.TabIndex = 8;
            this.CmdSaveSettings.Text = "Save Settings";
            this.CmdSaveSettings.UseVisualStyleBackColor = true;
            this.CmdSaveSettings.Visible = false;
            this.CmdSaveSettings.Click += new System.EventHandler(this.CmdSaveSettings_Click);
            this.CmdSaveSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdSaveSettings_MouseClick);
            // 
            // CmdCancelSettings
            // 
            this.CmdCancelSettings.Location = new System.Drawing.Point(141, 63);
            this.CmdCancelSettings.Margin = new System.Windows.Forms.Padding(2);
            this.CmdCancelSettings.Name = "CmdCancelSettings";
            this.CmdCancelSettings.Size = new System.Drawing.Size(99, 26);
            this.CmdCancelSettings.TabIndex = 9;
            this.CmdCancelSettings.Text = "Cancel";
            this.CmdCancelSettings.UseVisualStyleBackColor = true;
            this.CmdCancelSettings.Visible = false;
            this.CmdCancelSettings.Click += new System.EventHandler(this.CmdCancelSettings_Click);
            this.CmdCancelSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CmdCancelSettings_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter the correct credntials. Copyright Team Rocketeers";
            // 
            // CmdFirewall
            // 
            this.CmdFirewall.Location = new System.Drawing.Point(22, 284);
            this.CmdFirewall.Margin = new System.Windows.Forms.Padding(2);
            this.CmdFirewall.Name = "CmdFirewall";
            this.CmdFirewall.Size = new System.Drawing.Size(92, 24);
            this.CmdFirewall.TabIndex = 14;
            this.CmdFirewall.Text = "Add firewall rule";
            this.CmdFirewall.UseVisualStyleBackColor = true;
            this.CmdFirewall.Click += new System.EventHandler(this.CmdFirewall_Click);
            this.CmdFirewall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdFirewall_MouseClick);
            // 
            // CmdTaskman
            // 
            this.CmdTaskman.Location = new System.Drawing.Point(118, 284);
            this.CmdTaskman.Margin = new System.Windows.Forms.Padding(2);
            this.CmdTaskman.Name = "CmdTaskman";
            this.CmdTaskman.Size = new System.Drawing.Size(118, 24);
            this.CmdTaskman.TabIndex = 15;
            this.CmdTaskman.Text = "Auto Start at logon";
            this.CmdTaskman.UseVisualStyleBackColor = true;
            this.CmdTaskman.Click += new System.EventHandler(this.CmdTaskman_Click);
            this.CmdTaskman.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdTaskman_MouseClick);
            // 
            // CmdHelp
            // 
            this.CmdHelp.Location = new System.Drawing.Point(33, 369);
            this.CmdHelp.Margin = new System.Windows.Forms.Padding(2);
            this.CmdHelp.Name = "CmdHelp";
            this.CmdHelp.Size = new System.Drawing.Size(56, 23);
            this.CmdHelp.TabIndex = 16;
            this.CmdHelp.Text = "Help";
            this.CmdHelp.UseVisualStyleBackColor = true;
            this.CmdHelp.Click += new System.EventHandler(this.CmdHelp_Click);
            this.CmdHelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdHelp_MouseClick);
            // 
            // CmdHelpSettings
            // 
            this.CmdHelpSettings.Location = new System.Drawing.Point(181, 254);
            this.CmdHelpSettings.Margin = new System.Windows.Forms.Padding(2);
            this.CmdHelpSettings.Name = "CmdHelpSettings";
            this.CmdHelpSettings.Size = new System.Drawing.Size(56, 23);
            this.CmdHelpSettings.TabIndex = 17;
            this.CmdHelpSettings.Text = "Help";
            this.CmdHelpSettings.UseVisualStyleBackColor = true;
            this.CmdHelpSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdHelpSettings_MouseClick);
            // 
            // ImgWinbackground
            // 
            this.ImgWinbackground.Image = ((System.Drawing.Image)(resources.GetObject("ImgWinbackground.Image")));
            this.ImgWinbackground.Location = new System.Drawing.Point(344, 175);
            this.ImgWinbackground.Margin = new System.Windows.Forms.Padding(2);
            this.ImgWinbackground.Name = "ImgWinbackground";
            this.ImgWinbackground.Size = new System.Drawing.Size(46, 102);
            this.ImgWinbackground.TabIndex = 12;
            this.ImgWinbackground.TabStop = false;
            this.ImgWinbackground.Visible = false;
            this.ImgWinbackground.Click += new System.EventHandler(this.ImgWinbackground_Click);
            // 
            // FrmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(329, 405);
            this.Controls.Add(this.CmdHelp);
            this.Controls.Add(this.ImgWinbackground);
            this.Controls.Add(this.TxtDubug);
            this.Controls.Add(this.CmdCancelSettings);
            this.Controls.Add(this.CmdSaveSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.CmdSettings);
            this.Controls.Add(this.CmdHide);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdTaskman);
            this.Controls.Add(this.CmdFirewall);
            this.Controls.Add(this.CmdHelpSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmService";
            this.Text = "Team Viewer Jugaad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgWinbackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.TextBox TxtDubug;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CmdHide;
        private System.Windows.Forms.Button CmdSettings;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassWord;
        private System.Windows.Forms.Button CmdSaveSettings;
        private System.Windows.Forms.Button CmdCancelSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ImgWinbackground;
        private System.Windows.Forms.Button CmdFirewall;
        private System.Windows.Forms.Button CmdTaskman;
        private System.Windows.Forms.Button CmdHelp;
        private System.Windows.Forms.Button CmdHelpSettings;
    }
}


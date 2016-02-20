namespace RemoteClient
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TaskBar = new System.Windows.Forms.GroupBox();
            this.CmdMenu = new System.Windows.Forms.PictureBox();
            this.CmdMinimize = new System.Windows.Forms.PictureBox();
            this.CmdRestore = new System.Windows.Forms.PictureBox();
            this.CmdClose = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TrackWidth = new System.Windows.Forms.HScrollBar();
            this.TrackHeight = new System.Windows.Forms.VScrollBar();
            this.CmdHelp = new System.Windows.Forms.Button();
            this.ChkLeftMenu = new System.Windows.Forms.CheckBox();
            this.CmdShutDown = new System.Windows.Forms.Button();
            this.CmdDisconect = new System.Windows.Forms.Button();
            this.TrackSpeed = new System.Windows.Forms.TrackBar();
            this.CmdMetro = new System.Windows.Forms.Button();
            this.CmdSendCtrlAltDel = new System.Windows.Forms.Button();
            this.CmdSendStart = new System.Windows.Forms.Button();
            this.ChkEncrypted = new System.Windows.Forms.CheckBox();
            this.ChkSendKeyboardAndMouse = new System.Windows.Forms.CheckBox();
            this.ChkDebug = new System.Windows.Forms.CheckBox();
            this.ChkResoloution = new System.Windows.Forms.CheckBox();
            this.ChkScale = new System.Windows.Forms.CheckBox();
            this.CmdHelp2 = new System.Windows.Forms.Button();
            this.ChkLeftMenuConnect = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.CmdConnect = new System.Windows.Forms.Button();
            this.ChkBlackWallpaper = new System.Windows.Forms.CheckBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.TxtIPAddress = new System.Windows.Forms.TextBox();
            this.CmdMenuSmall = new System.Windows.Forms.Button();
            this.GroupConected = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupConnect = new System.Windows.Forms.GroupBox();
            this.CmdFirewall = new System.Windows.Forms.Button();
            this.ImgDefaultBackground = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.theImage = new System.Windows.Forms.PictureBox();
            this.TaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmdMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSpeed)).BeginInit();
            this.GroupConected.SuspendLayout();
            this.GroupConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDefaultBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskBar
            // 
            this.TaskBar.BackColor = System.Drawing.Color.Navy;
            this.TaskBar.Controls.Add(this.CmdMenu);
            this.TaskBar.Controls.Add(this.CmdMinimize);
            this.TaskBar.Controls.Add(this.CmdRestore);
            this.TaskBar.Controls.Add(this.CmdClose);
            this.TaskBar.Controls.Add(this.LblTitle);
            this.TaskBar.Location = new System.Drawing.Point(327, 11);
            this.TaskBar.Margin = new System.Windows.Forms.Padding(2);
            this.TaskBar.Name = "TaskBar";
            this.TaskBar.Padding = new System.Windows.Forms.Padding(2);
            this.TaskBar.Size = new System.Drawing.Size(284, 31);
            this.TaskBar.TabIndex = 1;
            this.TaskBar.TabStop = false;
            this.TaskBar.Visible = false;
            this.TaskBar.MouseHover += new System.EventHandler(this.TaskBar_MouseHover);
            // 
            // CmdMenu
            // 
            this.CmdMenu.Image = global::RemoteClient.Properties.Resources.Menu;
            this.CmdMenu.Location = new System.Drawing.Point(4, 10);
            this.CmdMenu.Margin = new System.Windows.Forms.Padding(2);
            this.CmdMenu.Name = "CmdMenu";
            this.CmdMenu.Size = new System.Drawing.Size(23, 16);
            this.CmdMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CmdMenu.TabIndex = 52;
            this.CmdMenu.TabStop = false;
            this.CmdMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdMenu_MouseClick);
            // 
            // CmdMinimize
            // 
            this.CmdMinimize.Location = new System.Drawing.Point(0, 0);
            this.CmdMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.CmdMinimize.Name = "CmdMinimize";
            this.CmdMinimize.Size = new System.Drawing.Size(23, 16);
            this.CmdMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CmdMinimize.TabIndex = 51;
            this.CmdMinimize.TabStop = false;
            this.toolTip1.SetToolTip(this.CmdMinimize, "Minimize window");
            this.CmdMinimize.Click += new System.EventHandler(this.CmdMinimize_Click);
            this.CmdMinimize.MouseHover += new System.EventHandler(this.CmdMinimize_MouseHover);
            // 
            // CmdRestore
            // 
            this.CmdRestore.Image = global::RemoteClient.Properties.Resources.Restore;
            this.CmdRestore.Location = new System.Drawing.Point(229, 8);
            this.CmdRestore.Margin = new System.Windows.Forms.Padding(2);
            this.CmdRestore.Name = "CmdRestore";
            this.CmdRestore.Size = new System.Drawing.Size(23, 16);
            this.CmdRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CmdRestore.TabIndex = 50;
            this.CmdRestore.TabStop = false;
            this.toolTip1.SetToolTip(this.CmdRestore, "Restore window");
            this.CmdRestore.Click += new System.EventHandler(this.CmdRestore_Click);
            this.CmdRestore.MouseHover += new System.EventHandler(this.CmdRestore_MouseHover);
            // 
            // CmdClose
            // 
            this.CmdClose.Image = global::RemoteClient.Properties.Resources.Max;
            this.CmdClose.Location = new System.Drawing.Point(256, 8);
            this.CmdClose.Margin = new System.Windows.Forms.Padding(2);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(23, 16);
            this.CmdClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CmdClose.TabIndex = 49;
            this.CmdClose.TabStop = false;
            this.toolTip1.SetToolTip(this.CmdClose, "Close window");
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            this.CmdClose.MouseHover += new System.EventHandler(this.CmdClose_MouseHover);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(95, 13);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(93, 13);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "127.0.0.1:4000";
            // 
            // TrackWidth
            // 
            this.TrackWidth.Location = new System.Drawing.Point(41, 188);
            this.TrackWidth.Maximum = 2570;
            this.TrackWidth.Minimum = 800;
            this.TrackWidth.Name = "TrackWidth";
            this.TrackWidth.Size = new System.Drawing.Size(214, 21);
            this.TrackWidth.TabIndex = 57;
            this.toolTip1.SetToolTip(this.TrackWidth, "Desktop width");
            this.TrackWidth.Value = 800;
            this.TrackWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackWidth_Scroll);
            // 
            // TrackHeight
            // 
            this.TrackHeight.Location = new System.Drawing.Point(22, 47);
            this.TrackHeight.Maximum = 2000;
            this.TrackHeight.Minimum = 600;
            this.TrackHeight.Name = "TrackHeight";
            this.TrackHeight.Size = new System.Drawing.Size(21, 159);
            this.TrackHeight.TabIndex = 56;
            this.toolTip1.SetToolTip(this.TrackHeight, "Desktop Height");
            this.TrackHeight.Value = 690;
            this.TrackHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackHeight_Scroll);
            // 
            // CmdHelp
            // 
            this.CmdHelp.Location = new System.Drawing.Point(118, 211);
            this.CmdHelp.Margin = new System.Windows.Forms.Padding(2);
            this.CmdHelp.Name = "CmdHelp";
            this.CmdHelp.Size = new System.Drawing.Size(64, 27);
            this.CmdHelp.TabIndex = 55;
            this.CmdHelp.Text = "Help";
            this.toolTip1.SetToolTip(this.CmdHelp, "Help");
            this.CmdHelp.UseVisualStyleBackColor = true;
            this.CmdHelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdHelp_MouseClick);
            // 
            // ChkLeftMenu
            // 
            this.ChkLeftMenu.AutoSize = true;
            this.ChkLeftMenu.BackColor = System.Drawing.Color.Transparent;
            this.ChkLeftMenu.Location = new System.Drawing.Point(59, 94);
            this.ChkLeftMenu.Margin = new System.Windows.Forms.Padding(2);
            this.ChkLeftMenu.Name = "ChkLeftMenu";
            this.ChkLeftMenu.Size = new System.Drawing.Size(74, 17);
            this.ChkLeftMenu.TabIndex = 54;
            this.ChkLeftMenu.Text = "Left Menu";
            this.toolTip1.SetToolTip(this.ChkLeftMenu, "Move menu to the left");
            this.ChkLeftMenu.UseVisualStyleBackColor = false;
            this.ChkLeftMenu.Visible = false;
            this.ChkLeftMenu.CheckedChanged += new System.EventHandler(this.ChkLeftMenu_CheckedChanged);
            // 
            // CmdShutDown
            // 
            this.CmdShutDown.Location = new System.Drawing.Point(186, 211);
            this.CmdShutDown.Margin = new System.Windows.Forms.Padding(2);
            this.CmdShutDown.Name = "CmdShutDown";
            this.CmdShutDown.Size = new System.Drawing.Size(69, 27);
            this.CmdShutDown.TabIndex = 48;
            this.CmdShutDown.Text = "Shut down";
            this.toolTip1.SetToolTip(this.CmdShutDown, "Shut down remote server");
            this.CmdShutDown.UseVisualStyleBackColor = true;
            this.CmdShutDown.Click += new System.EventHandler(this.CmdShutDown_Click);
            // 
            // CmdDisconect
            // 
            this.CmdDisconect.Location = new System.Drawing.Point(41, 211);
            this.CmdDisconect.Margin = new System.Windows.Forms.Padding(2);
            this.CmdDisconect.Name = "CmdDisconect";
            this.CmdDisconect.Size = new System.Drawing.Size(72, 27);
            this.CmdDisconect.TabIndex = 46;
            this.CmdDisconect.Text = "Disconect";
            this.toolTip1.SetToolTip(this.CmdDisconect, "Disconnect desktop");
            this.CmdDisconect.UseVisualStyleBackColor = true;
            this.CmdDisconect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdDisconect_MouseClick);
            // 
            // TrackSpeed
            // 
            this.TrackSpeed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TrackSpeed.Location = new System.Drawing.Point(61, 130);
            this.TrackSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.TrackSpeed.Maximum = 10000;
            this.TrackSpeed.Minimum = 2;
            this.TrackSpeed.Name = "TrackSpeed";
            this.TrackSpeed.Size = new System.Drawing.Size(106, 45);
            this.TrackSpeed.TabIndex = 47;
            this.toolTip1.SetToolTip(this.TrackSpeed, "Refresh Speed");
            this.TrackSpeed.Value = 2000;
            this.TrackSpeed.Visible = false;
            this.TrackSpeed.Scroll += new System.EventHandler(this.TrackSpeed_Scroll);
            // 
            // CmdMetro
            // 
            this.CmdMetro.Location = new System.Drawing.Point(184, 18);
            this.CmdMetro.Margin = new System.Windows.Forms.Padding(2);
            this.CmdMetro.Name = "CmdMetro";
            this.CmdMetro.Size = new System.Drawing.Size(69, 24);
            this.CmdMetro.TabIndex = 51;
            this.CmdMetro.Text = "Metro";
            this.toolTip1.SetToolTip(this.CmdMetro, "Show Metro menu button on remote machine");
            this.CmdMetro.UseVisualStyleBackColor = true;
            this.CmdMetro.Visible = false;
            this.CmdMetro.Click += new System.EventHandler(this.CmdMetro_Click);
            // 
            // CmdSendCtrlAltDel
            // 
            this.CmdSendCtrlAltDel.Location = new System.Drawing.Point(116, 18);
            this.CmdSendCtrlAltDel.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSendCtrlAltDel.Name = "CmdSendCtrlAltDel";
            this.CmdSendCtrlAltDel.Size = new System.Drawing.Size(64, 24);
            this.CmdSendCtrlAltDel.TabIndex = 50;
            this.CmdSendCtrlAltDel.Text = "Task man";
            this.toolTip1.SetToolTip(this.CmdSendCtrlAltDel, "Show task-manger button on remote machine");
            this.CmdSendCtrlAltDel.UseVisualStyleBackColor = true;
            this.CmdSendCtrlAltDel.Click += new System.EventHandler(this.CmdSendCtrlAltDel_Click);
            // 
            // CmdSendStart
            // 
            this.CmdSendStart.Location = new System.Drawing.Point(40, 18);
            this.CmdSendStart.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSendStart.Name = "CmdSendStart";
            this.CmdSendStart.Size = new System.Drawing.Size(72, 24);
            this.CmdSendStart.TabIndex = 49;
            this.CmdSendStart.Text = "Start button";
            this.toolTip1.SetToolTip(this.CmdSendStart, "Press start button on remote machine");
            this.CmdSendStart.UseVisualStyleBackColor = true;
            this.CmdSendStart.Click += new System.EventHandler(this.CmdSendStart_Click);
            // 
            // ChkEncrypted
            // 
            this.ChkEncrypted.AutoSize = true;
            this.ChkEncrypted.BackColor = System.Drawing.Color.Transparent;
            this.ChkEncrypted.Location = new System.Drawing.Point(151, 94);
            this.ChkEncrypted.Margin = new System.Windows.Forms.Padding(2);
            this.ChkEncrypted.Name = "ChkEncrypted";
            this.ChkEncrypted.Size = new System.Drawing.Size(74, 17);
            this.ChkEncrypted.TabIndex = 45;
            this.ChkEncrypted.Text = "Encrypted";
            this.toolTip1.SetToolTip(this.ChkEncrypted, "Encrypt remote desktop connection");
            this.ChkEncrypted.UseVisualStyleBackColor = false;
            this.ChkEncrypted.Visible = false;
            this.ChkEncrypted.CheckedChanged += new System.EventHandler(this.ChkEncrypted_CheckedChanged);
            // 
            // ChkSendKeyboardAndMouse
            // 
            this.ChkSendKeyboardAndMouse.AutoSize = true;
            this.ChkSendKeyboardAndMouse.BackColor = System.Drawing.Color.Transparent;
            this.ChkSendKeyboardAndMouse.Checked = true;
            this.ChkSendKeyboardAndMouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSendKeyboardAndMouse.Location = new System.Drawing.Point(151, 50);
            this.ChkSendKeyboardAndMouse.Margin = new System.Windows.Forms.Padding(2);
            this.ChkSendKeyboardAndMouse.Name = "ChkSendKeyboardAndMouse";
            this.ChkSendKeyboardAndMouse.Size = new System.Drawing.Size(107, 17);
            this.ChkSendKeyboardAndMouse.TabIndex = 41;
            this.ChkSendKeyboardAndMouse.Text = "Control Keyboard";
            this.toolTip1.SetToolTip(this.ChkSendKeyboardAndMouse, "Control the remote desktop");
            this.ChkSendKeyboardAndMouse.UseVisualStyleBackColor = false;
            this.ChkSendKeyboardAndMouse.Visible = false;
            this.ChkSendKeyboardAndMouse.CheckedChanged += new System.EventHandler(this.ChkSendKeyboardAndMouse_CheckedChanged);
            // 
            // ChkDebug
            // 
            this.ChkDebug.AutoSize = true;
            this.ChkDebug.BackColor = System.Drawing.Color.Transparent;
            this.ChkDebug.Location = new System.Drawing.Point(59, 50);
            this.ChkDebug.Margin = new System.Windows.Forms.Padding(2);
            this.ChkDebug.Name = "ChkDebug";
            this.ChkDebug.Size = new System.Drawing.Size(58, 17);
            this.ChkDebug.TabIndex = 40;
            this.ChkDebug.Text = "Debug";
            this.toolTip1.SetToolTip(this.ChkDebug, "SShow debug on remote desktop");
            this.ChkDebug.UseVisualStyleBackColor = false;
            this.ChkDebug.Visible = false;
            this.ChkDebug.CheckedChanged += new System.EventHandler(this.ChkDebug_CheckedChanged);
            // 
            // ChkResoloution
            // 
            this.ChkResoloution.AutoSize = true;
            this.ChkResoloution.BackColor = System.Drawing.Color.Transparent;
            this.ChkResoloution.Location = new System.Drawing.Point(151, 72);
            this.ChkResoloution.Margin = new System.Windows.Forms.Padding(2);
            this.ChkResoloution.Name = "ChkResoloution";
            this.ChkResoloution.Size = new System.Drawing.Size(94, 17);
            this.ChkResoloution.TabIndex = 39;
            this.ChkResoloution.Text = "32 Bit desktop";
            this.toolTip1.SetToolTip(this.ChkResoloution, "Show 32bit desktop");
            this.ChkResoloution.UseVisualStyleBackColor = false;
            this.ChkResoloution.Visible = false;
            this.ChkResoloution.CheckedChanged += new System.EventHandler(this.ChkResoloution_CheckedChanged);
            // 
            // ChkScale
            // 
            this.ChkScale.AutoSize = true;
            this.ChkScale.BackColor = System.Drawing.Color.Transparent;
            this.ChkScale.Location = new System.Drawing.Point(59, 72);
            this.ChkScale.Margin = new System.Windows.Forms.Padding(2);
            this.ChkScale.Name = "ChkScale";
            this.ChkScale.Size = new System.Drawing.Size(72, 17);
            this.ChkScale.TabIndex = 38;
            this.ChkScale.Text = "Compress";
            this.toolTip1.SetToolTip(this.ChkScale, "Compress data to speed up");
            this.ChkScale.UseVisualStyleBackColor = false;
            this.ChkScale.Visible = false;
            this.ChkScale.CheckedChanged += new System.EventHandler(this.ChkScale_CheckedChanged);
            // 
            // CmdHelp2
            // 
            this.CmdHelp2.Location = new System.Drawing.Point(104, 145);
            this.CmdHelp2.Margin = new System.Windows.Forms.Padding(2);
            this.CmdHelp2.Name = "CmdHelp2";
            this.CmdHelp2.Size = new System.Drawing.Size(68, 24);
            this.CmdHelp2.TabIndex = 58;
            this.CmdHelp2.Text = "Help";
            this.toolTip1.SetToolTip(this.CmdHelp2, "Shut down remote server");
            this.CmdHelp2.UseVisualStyleBackColor = true;
            this.CmdHelp2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdHelp_MouseClick);
            // 
            // ChkLeftMenuConnect
            // 
            this.ChkLeftMenuConnect.AutoSize = true;
            this.ChkLeftMenuConnect.BackColor = System.Drawing.Color.Transparent;
            this.ChkLeftMenuConnect.Location = new System.Drawing.Point(33, 107);
            this.ChkLeftMenuConnect.Margin = new System.Windows.Forms.Padding(2);
            this.ChkLeftMenuConnect.Name = "ChkLeftMenuConnect";
            this.ChkLeftMenuConnect.Size = new System.Drawing.Size(74, 17);
            this.ChkLeftMenuConnect.TabIndex = 57;
            this.ChkLeftMenuConnect.Text = "Left Menu";
            this.toolTip1.SetToolTip(this.ChkLeftMenuConnect, "Scale the remote desktop image down");
            this.ChkLeftMenuConnect.UseVisualStyleBackColor = false;
            this.ChkLeftMenuConnect.Visible = false;
            this.ChkLeftMenuConnect.CheckedChanged += new System.EventHandler(this.ChkLeftMenuConnect_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(112, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(131, 23);
            this.txtPassword.TabIndex = 48;
            this.txtPassword.Text = "letmein";
            this.toolTip1.SetToolTip(this.txtPassword, "Remote desktop IP-Address");
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // CmdConnect
            // 
            this.CmdConnect.Location = new System.Drawing.Point(27, 145);
            this.CmdConnect.Margin = new System.Windows.Forms.Padding(2);
            this.CmdConnect.Name = "CmdConnect";
            this.CmdConnect.Size = new System.Drawing.Size(72, 24);
            this.CmdConnect.TabIndex = 46;
            this.CmdConnect.Text = "Connect";
            this.toolTip1.SetToolTip(this.CmdConnect, "Connect to the remote desktop");
            this.CmdConnect.UseVisualStyleBackColor = true;
            this.CmdConnect.Click += new System.EventHandler(this.CmdConnect_Click);
            this.CmdConnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdConnect_MouseClick);
            // 
            // ChkBlackWallpaper
            // 
            this.ChkBlackWallpaper.AutoSize = true;
            this.ChkBlackWallpaper.BackColor = System.Drawing.Color.Transparent;
            this.ChkBlackWallpaper.Checked = true;
            this.ChkBlackWallpaper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBlackWallpaper.Location = new System.Drawing.Point(112, 107);
            this.ChkBlackWallpaper.Margin = new System.Windows.Forms.Padding(2);
            this.ChkBlackWallpaper.Name = "ChkBlackWallpaper";
            this.ChkBlackWallpaper.Size = new System.Drawing.Size(104, 17);
            this.ChkBlackWallpaper.TabIndex = 45;
            this.ChkBlackWallpaper.Text = "Black Wallpaper";
            this.toolTip1.SetToolTip(this.ChkBlackWallpaper, "Use black remote desktop");
            this.ChkBlackWallpaper.UseVisualStyleBackColor = false;
            this.ChkBlackWallpaper.Visible = false;
            this.ChkBlackWallpaper.CheckedChanged += new System.EventHandler(this.ChkBlackWallpaper_CheckedChanged_1);
            // 
            // TxtPort
            // 
            this.TxtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPort.ForeColor = System.Drawing.Color.Red;
            this.TxtPort.Location = new System.Drawing.Point(112, 45);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(131, 23);
            this.TxtPort.TabIndex = 7;
            this.TxtPort.Text = "4000";
            this.toolTip1.SetToolTip(this.TxtPort, "Remote desktop port");
            this.TxtPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPort_KeyDown);
            // 
            // TxtIPAddress
            // 
            this.TxtIPAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIPAddress.ForeColor = System.Drawing.Color.Red;
            this.TxtIPAddress.Location = new System.Drawing.Point(112, 20);
            this.TxtIPAddress.Name = "TxtIPAddress";
            this.TxtIPAddress.Size = new System.Drawing.Size(131, 23);
            this.TxtIPAddress.TabIndex = 6;
            this.TxtIPAddress.Text = "10.10.10.25";
            this.toolTip1.SetToolTip(this.TxtIPAddress, "Remote desktop IP-Address");
            this.TxtIPAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIPAddress_KeyDown);
            // 
            // CmdMenuSmall
            // 
            this.CmdMenuSmall.BackgroundImage = global::RemoteClient.Properties.Resources.Menu;
            this.CmdMenuSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdMenuSmall.Location = new System.Drawing.Point(0, 5);
            this.CmdMenuSmall.Margin = new System.Windows.Forms.Padding(2);
            this.CmdMenuSmall.Name = "CmdMenuSmall";
            this.CmdMenuSmall.Size = new System.Drawing.Size(23, 17);
            this.CmdMenuSmall.TabIndex = 53;
            this.toolTip1.SetToolTip(this.CmdMenuSmall, "Show/Hide Menu");
            this.CmdMenuSmall.UseVisualStyleBackColor = true;
            this.CmdMenuSmall.Visible = false;
            this.CmdMenuSmall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CmdMenuSmall_MouseDown);
            this.CmdMenuSmall.MouseHover += new System.EventHandler(this.CmdMenuSmall_MouseHover);
            // 
            // GroupConected
            // 
            this.GroupConected.BackgroundImage = global::RemoteClient.Properties.Resources.GroupBackground;
            this.GroupConected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroupConected.Controls.Add(this.label6);
            this.GroupConected.Controls.Add(this.TrackWidth);
            this.GroupConected.Controls.Add(this.TrackHeight);
            this.GroupConected.Controls.Add(this.CmdHelp);
            this.GroupConected.Controls.Add(this.ChkLeftMenu);
            this.GroupConected.Controls.Add(this.CmdShutDown);
            this.GroupConected.Controls.Add(this.CmdDisconect);
            this.GroupConected.Controls.Add(this.label4);
            this.GroupConected.Controls.Add(this.label5);
            this.GroupConected.Controls.Add(this.TrackSpeed);
            this.GroupConected.Controls.Add(this.CmdMetro);
            this.GroupConected.Controls.Add(this.CmdSendCtrlAltDel);
            this.GroupConected.Controls.Add(this.CmdSendStart);
            this.GroupConected.Controls.Add(this.ChkEncrypted);
            this.GroupConected.Controls.Add(this.ChkSendKeyboardAndMouse);
            this.GroupConected.Controls.Add(this.ChkDebug);
            this.GroupConected.Controls.Add(this.ChkResoloution);
            this.GroupConected.Controls.Add(this.ChkScale);
            this.GroupConected.Location = new System.Drawing.Point(476, 141);
            this.GroupConected.Margin = new System.Windows.Forms.Padding(2);
            this.GroupConected.Name = "GroupConected";
            this.GroupConected.Padding = new System.Windows.Forms.Padding(2);
            this.GroupConected.Size = new System.Drawing.Size(284, 255);
            this.GroupConected.TabIndex = 2;
            this.GroupConected.TabStop = false;
            this.GroupConected.Visible = false;
            this.GroupConected.MouseHover += new System.EventHandler(this.GroupConected_MouseHover);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(57, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "       Refresh Speed";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(58, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "-";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(153, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "+";
            this.label5.Visible = false;
            // 
            // GroupConnect
            // 
            this.GroupConnect.BackgroundImage = global::RemoteClient.Properties.Resources.GroupBackground;
            this.GroupConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroupConnect.Controls.Add(this.CmdHelp2);
            this.GroupConnect.Controls.Add(this.ChkLeftMenuConnect);
            this.GroupConnect.Controls.Add(this.CmdFirewall);
            this.GroupConnect.Controls.Add(this.ImgDefaultBackground);
            this.GroupConnect.Controls.Add(this.txtPassword);
            this.GroupConnect.Controls.Add(this.label3);
            this.GroupConnect.Controls.Add(this.CmdConnect);
            this.GroupConnect.Controls.Add(this.ChkBlackWallpaper);
            this.GroupConnect.Controls.Add(this.TxtPort);
            this.GroupConnect.Controls.Add(this.TxtIPAddress);
            this.GroupConnect.Controls.Add(this.label2);
            this.GroupConnect.Controls.Add(this.label1);
            this.GroupConnect.Location = new System.Drawing.Point(323, 42);
            this.GroupConnect.Margin = new System.Windows.Forms.Padding(2);
            this.GroupConnect.Name = "GroupConnect";
            this.GroupConnect.Padding = new System.Windows.Forms.Padding(2);
            this.GroupConnect.Size = new System.Drawing.Size(284, 188);
            this.GroupConnect.TabIndex = 3;
            this.GroupConnect.TabStop = false;
            // 
            // CmdFirewall
            // 
            this.CmdFirewall.Location = new System.Drawing.Point(176, 145);
            this.CmdFirewall.Margin = new System.Windows.Forms.Padding(2);
            this.CmdFirewall.Name = "CmdFirewall";
            this.CmdFirewall.Size = new System.Drawing.Size(72, 24);
            this.CmdFirewall.TabIndex = 56;
            this.CmdFirewall.Text = "Firewall";
            this.CmdFirewall.UseVisualStyleBackColor = true;
            this.CmdFirewall.Click += new System.EventHandler(this.CmdFirewall_Click);
            // 
            // ImgDefaultBackground
            // 
            this.ImgDefaultBackground.Image = global::RemoteClient.Properties.Resources.DefaultBackground;
            this.ImgDefaultBackground.Location = new System.Drawing.Point(247, 22);
            this.ImgDefaultBackground.Margin = new System.Windows.Forms.Padding(2);
            this.ImgDefaultBackground.Name = "ImgDefaultBackground";
            this.ImgDefaultBackground.Size = new System.Drawing.Size(22, 102);
            this.ImgDefaultBackground.TabIndex = 55;
            this.ImgDefaultBackground.TabStop = false;
            this.ImgDefaultBackground.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address:";
            // 
            // theImage
            // 
            this.theImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.theImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theImage.Image = global::RemoteClient.Properties.Resources.DefaultBackground;
            this.theImage.Location = new System.Drawing.Point(0, 0);
            this.theImage.Margin = new System.Windows.Forms.Padding(0);
            this.theImage.Name = "theImage";
            this.theImage.Size = new System.Drawing.Size(942, 407);
            this.theImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theImage.TabIndex = 54;
            this.theImage.TabStop = false;
            this.theImage.Click += new System.EventHandler(this.theImage_Click);
            this.theImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseClick);
            this.theImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseDown);
            this.theImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseMove);
            this.theImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseUp);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 407);
            this.Controls.Add(this.GroupConected);
            this.Controls.Add(this.GroupConnect);
            this.Controls.Add(this.TaskBar);
            this.Controls.Add(this.CmdMenuSmall);
            this.Controls.Add(this.theImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "Jugaad team viwer client";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.TaskBar.ResumeLayout(false);
            this.TaskBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmdMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSpeed)).EndInit();
            this.GroupConected.ResumeLayout(false);
            this.GroupConected.PerformLayout();
            this.GroupConnect.ResumeLayout(false);
            this.GroupConnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDefaultBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TaskBar;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox GroupConected;
        private System.Windows.Forms.CheckBox ChkEncrypted;
        private System.Windows.Forms.CheckBox ChkSendKeyboardAndMouse;
        private System.Windows.Forms.CheckBox ChkDebug;
        private System.Windows.Forms.CheckBox ChkResoloution;
        private System.Windows.Forms.CheckBox ChkScale;
        private System.Windows.Forms.GroupBox GroupConnect;
        private System.Windows.Forms.Button CmdDisconect;
        private System.Windows.Forms.Button CmdConnect;
        private System.Windows.Forms.CheckBox ChkBlackWallpaper;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.TextBox TxtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TrackSpeed;
        private System.Windows.Forms.Button CmdShutDown;
        private System.Windows.Forms.PictureBox CmdClose;
        private System.Windows.Forms.PictureBox CmdRestore;
        private System.Windows.Forms.PictureBox CmdMinimize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button CmdMenuSmall;
        private System.Windows.Forms.Button CmdSendCtrlAltDel;
        private System.Windows.Forms.Button CmdSendStart;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdMetro;
        private System.Windows.Forms.PictureBox ImgDefaultBackground;
        private System.Windows.Forms.Button CmdFirewall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox theImage;
        private System.Windows.Forms.CheckBox ChkLeftMenu;
        private System.Windows.Forms.CheckBox ChkLeftMenuConnect;
        private System.Windows.Forms.PictureBox CmdMenu;
        private System.Windows.Forms.Button CmdHelp;
        private System.Windows.Forms.Button CmdHelp2;
        private System.Windows.Forms.VScrollBar TrackHeight;
        private System.Windows.Forms.HScrollBar TrackWidth;
        private System.Windows.Forms.Label label6;
    }
}
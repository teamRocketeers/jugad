

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;
using System.Diagnostics;

namespace RemoteServer
{
    public partial class FrmService : Form
    {
        public static FrmHelp frmHelp = null;
        public FrmService()
        {
            InitializeComponent();

        }

       

        
        public void printDebug(string Msg,bool Force)
        {
            if (Settings.Debug || Force)
            {
                TxtDubug.Text = Msg + Environment.NewLine + TxtDubug.Text;
                if (TxtDubug.Text.Length > 20000) TxtDubug.Text = TxtDubug.Text.Substring(10000);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Settings.MainProgramName;
            bool B=Control.IsKeyLocked(Keys.CapsLock);
            this.WindowState = FormWindowState.Normal;
            Server.ImgWinbackground = ImgWinbackground.Image;
            Wallpaper.SaveWallpaper();
            Settings.LoadSettings();
            Settings.FormService = this;
            if (!Helper.IsUserAdministrator())
                printDebug("This program should be started with administrator rights to allow control of windows system forms and settings." + Environment.NewLine , true);
            if (Settings.FirstTime)
            {
                ShowSettings(true);
                TxtPassWord.Text = Settings.Pass;
                TxtPort.Text = Settings.Port.ToString();
            }
            else
                Server.ListenStart();
            //this.Hide();
        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmHelp !=null) try {frmHelp.Close();} catch {;}
            Settings.SaveSettings();
            Server.ListenStop(true);
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            TxtDubug.Text = "";
        }

        private void CmdClear_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.SizeAll;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // this.TxtDubug.Text = Cursor.Current.ToString() + " " + System.Windows.Forms.Cursor.Position.X;
          
        }

        private void CmdHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmdSettings_Click(object sender, EventArgs e)
        {
            if (Server.IsClientsConnected())
            {
               DialogResult  Answer= MessageBox.Show("Remote connections will all be closed before any settings can be changed", "Change Settings", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               if (Answer == DialogResult.Cancel) return;
            }
            try{Helper.AddDesktopShortcut();}catch { ;}
            Server.ListenStop(false);
            ShowSettings(true);
            TxtPassWord.Text  = Settings.Pass;
            TxtPort.Text = Settings.Port.ToString();
        }

        private void CmdCancelSettings_Click(object sender, EventArgs e)
        {
            
        }

        private void CmdCancelSettings_MouseDown(object sender, MouseEventArgs e)
        {
            ShowSettings(false);
            if (!Settings.FirstTime)
                Server.ListenStart();
            else
                printDebug("Service not started",true);
        }

        private void ShowSettings(bool Vis)
        {
            if (Settings.FirstTime)
                CmdSaveSettings.Text = "Allow connections";
            else
            CmdSaveSettings.Text = "Save setting";
            CmdCancelSettings.Visible = Vis;
            CmdSaveSettings.Visible = Vis;
            CmdFirewall.Visible = !Vis;
            CmdTaskman.Visible = !Vis;
            CmdHelpSettings.Visible = Vis;
            TxtPort.Visible = Vis;
            TxtPassWord.Visible = Vis;
            TxtDubug.Visible = !Vis;
            CmdClear.Visible = !Vis;
            CmdSettings.Visible = !Vis;
            CmdHide.Visible = false;
            CmdHelp.Visible = !Vis;
        }

        private void CmdSaveSettings_Click(object sender, EventArgs e)
        {
            //Settings.PassWord = TxtPassWord.Text.Trim();
            //try { Settings.Port = int.Parse(TxtPort.Text.Trim()); } catch { ;}
            //Settings.FirstTime = false;
            //Settings.SaveSettings();
            //ShowSettings(false);
            //Server.ListenStart();
            //TxtDubug.Visible = true;
            //printDebug("Settings saved", true);
            //TxtDubug.Focus();
        }

       

        private void CmdFirewall_Click(object sender, EventArgs e)
        {
          
        }

        private void CmdTaskman_Click(object sender, EventArgs e)
        {

        }


        private void CmdFirewall_MouseClick(object sender, MouseEventArgs e)
        {
            if (Helper.IsUserAdministrator())
            {
                FireWall.ProgramName = Settings.MainProgramName;
                if (FireWall.AllowThisProgram("TCP", Settings.Port.ToString(), "", "IN"))
                {
                    MessageBox.Show("New firewall rule added for TCP port " + Settings.Port, Settings.MainProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowSettings(false); Server.ListenStart(); return;
                }
            }
            MessageBox.Show("Sorry but you need to run this program as an administrator to add new firewall rules", Settings.MainProgramName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            ShowSettings(false); Server.ListenStart();
        }

        private void CmdTaskman_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Helper.AddDesktopShortcut();
            }
            catch { ;}
            if (Helper.IsUserAdministrator())
            {
                if (ScheduleTask.AddNewTask(Settings.MainProgramName, "Service for remote desktop"))
                {
                    MessageBox.Show("Schedule task added for " + Settings.MainProgramName, Settings.MainProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowSettings(false); Server.ListenStart(); return;
                }
            }
            MessageBox.Show("Sorry but you need to run this program as an administrator to add the Schedule task to auto start the program", Settings.MainProgramName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            ShowSettings(false); Server.ListenStart();
        }

        private void CmdSaveSettings_MouseClick(object sender, MouseEventArgs e)
        {
            Settings.Pass = TxtPassWord.Text.Trim();
            try { Settings.Port = int.Parse(TxtPort.Text.Trim()); Helper.AddDesktopShortcut(); }
            catch { ;}
            Settings.FirstTime = false;
            Settings.SaveSettings();
            ShowSettings(false);
            Server.ListenStart();
            TxtDubug.Visible = true;
            printDebug("Settings saved", true);
            TxtDubug.Focus();
        }

        private void CmdHelp_MouseClick(object sender, MouseEventArgs e)
        {
            if (frmHelp == null)
                frmHelp = new FrmHelp();
            frmHelp.Show();
        }

        private void CmdHelpSettings_MouseClick(object sender, MouseEventArgs e)
        {
            CmdHelp_MouseClick(null, null);
        }

        private void CmdHelp_Click(object sender, EventArgs e)
        {

        }

        private void TxtDubug_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImgWinbackground_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }     
}
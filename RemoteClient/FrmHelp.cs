using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Dr Gadgit RNCDesktop@Safe-mail.net http://www.codeproject.com/Articles/897746/Windows-remote-desktop-application
namespace RemoteClient
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        private void FrmHelp_Load(object sender, EventArgs e)
        {
            this.Text = Settings.MainProgramName + " help";
            TxtHelp.Select(0, 0);
        }

        private void FrmHelp_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.FrmHelping = null;
        }
    }
}

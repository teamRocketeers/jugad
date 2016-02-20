using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteServer
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

        private void FrmHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmService.frmHelp = null;
        }
    }
}

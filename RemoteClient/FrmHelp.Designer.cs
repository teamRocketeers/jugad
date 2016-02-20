namespace RemoteClient
{
    partial class FrmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.TxtHelp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtHelp
            // 
            this.TxtHelp.Location = new System.Drawing.Point(0, 1);
            this.TxtHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtHelp.Multiline = true;
            this.TxtHelp.Name = "TxtHelp";
            this.TxtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHelp.Size = new System.Drawing.Size(443, 314);
            this.TxtHelp.TabIndex = 0;
            this.TxtHelp.Text = resources.GetString("TxtHelp.Text");
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 314);
            this.Controls.Add(this.TxtHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHelp";
            this.Text = "Jugaad team viwer client help";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHelp_FormClosed);
            this.Load += new System.EventHandler(this.FrmHelp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHelp;
    }
}
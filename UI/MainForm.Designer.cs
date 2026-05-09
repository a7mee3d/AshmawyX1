namespace AshmawyX.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // MainForm
            this.ClientSize = new System.Drawing.Size(360, 160);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "AshmawyX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);

            // btnStart
            this.btnStart.Text = "Start (F7)";
            this.btnStart.Location = new System.Drawing.Point(20, 20);
            this.btnStart.Size = new System.Drawing.Size(140, 35);
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // btnStop
            this.btnStop.Text = "Stop (F8)";
            this.btnStop.Location = new System.Drawing.Point(190, 20);
            this.btnStop.Size = new System.Drawing.Size(140, 35);
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // lblStatus
            this.lblStatus.Text = "Status: Idle";
            this.lblStatus.Location = new System.Drawing.Point(20, 70);
            this.lblStatus.Size = new System.Drawing.Size(320, 25);
            this.lblStatus.ForeColor = System.Drawing.Color.White;

            // btnSettings
            this.btnSettings.Text = "Settings";
            this.btnSettings.Location = new System.Drawing.Point(20, 105);
            this.btnSettings.Size = new System.Drawing.Size(140, 35);
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);

            // btnAbout
            this.btnAbout.Text = "About";
            this.btnAbout.Location = new System.Drawing.Point(190, 105);
            this.btnAbout.Size = new System.Drawing.Size(140, 35);
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);

            // Add controls
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAbout);

            this.ResumeLayout(false);
        }
    }
}

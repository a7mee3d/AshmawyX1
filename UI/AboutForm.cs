using System;
using System.Drawing;
using System.Windows.Forms;

namespace AshmawyX.UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            ApplyModernTheme();
        }

        private void ApplyModernTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Font = new Font("Segoe UI", 10F);
            this.ForeColor = Color.FromArgb(220, 220, 220);

            Color accent = Color.FromArgb(0, 229, 255);

            lblTitle.ForeColor = accent;
            lblVersion.ForeColor = Color.FromArgb(200, 200, 200);
            lblDeveloper.ForeColor = Color.FromArgb(200, 200, 200);

            txtDescription.BackColor = Color.FromArgb(37, 37, 38);
            txtDescription.ForeColor = Color.FromArgb(220, 220, 220);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;

            btnClose.BackColor = accent;
            btnClose.ForeColor = Color.Black;
            btnClose.FlatStyle = FlatStyle.Flat;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System.Windows.Forms;

namespace AshmawyX.UI
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpWindows;
        private ComboBox cmbMain;
        private ComboBox cmbSecond;
        private Label lblMain;
        private Label lblSecond;
        private Button btnRefreshWindows;

        private GroupBox grpDelay;
        private CheckBox chkDelayEnabled;
        private Label lblDelayMin;
        private Label lblDelayMax;
        private NumericUpDown numDelayMin;
        private NumericUpDown numDelayMax;

        private GroupBox grpChat;
        private CheckBox chkBlockChat;

        private GroupBox grpKeys;
        private ListBox lstKeys;
        private TextBox txtKey;
        private Button btnAddKey;
        private Button btnRemoveKey;

        private Button btnSave;
        private Button btnCancel;

        private ToolTip toolTip1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpWindows = new GroupBox();
            this.cmbMain = new ComboBox();
            this.cmbSecond = new ComboBox();
            this.lblMain = new Label();
            this.lblSecond = new Label();
            this.btnRefreshWindows = new Button();

            this.grpDelay = new GroupBox();
            this.chkDelayEnabled = new CheckBox();
            this.lblDelayMin = new Label();
            this.lblDelayMax = new Label();
            this.numDelayMin = new NumericUpDown();
            this.numDelayMax = new NumericUpDown();

            this.grpChat = new GroupBox();
            this.chkBlockChat = new CheckBox();

            this.grpKeys = new GroupBox();
            this.lstKeys = new ListBox();
            this.txtKey = new TextBox();
            this.btnAddKey = new Button();
            this.btnRemoveKey = new Button();

            this.btnSave = new Button();
            this.btnCancel = new Button();

            this.toolTip1 = new ToolTip(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.numDelayMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayMax)).BeginInit();
            this.SuspendLayout();

            // SettingsForm
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Text = "AshmawyX Settings";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ForeColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // grpWindows
            this.grpWindows.Text = "Windows";
            this.grpWindows.Location = new System.Drawing.Point(12, 12);
            this.grpWindows.Size = new System.Drawing.Size(300, 150);
            this.grpWindows.ForeColor = System.Drawing.Color.White;

            // lblMain
            this.lblMain.Text = "Main:";
            this.lblMain.Location = new System.Drawing.Point(10, 30);
            this.lblMain.Size = new System.Drawing.Size(60, 20);

            // cmbMain
            this.cmbMain.Location = new System.Drawing.Point(80, 27);
            this.cmbMain.Size = new System.Drawing.Size(200, 23);
            this.cmbMain.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblSecond
            this.lblSecond.Text = "Second:";
            this.lblSecond.Location = new System.Drawing.Point(10, 65);
            this.lblSecond.Size = new System.Drawing.Size(60, 20);

            // cmbSecond
            this.cmbSecond.Location = new System.Drawing.Point(80, 62);
            this.cmbSecond.Size = new System.Drawing.Size(200, 23);
            this.cmbSecond.DropDownStyle = ComboBoxStyle.DropDownList;

            // btnRefreshWindows
            this.btnRefreshWindows.Text = "Refresh";
            this.btnRefreshWindows.Location = new System.Drawing.Point(80, 100);
            this.btnRefreshWindows.Size = new System.Drawing.Size(200, 30);
            this.btnRefreshWindows.BackColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.btnRefreshWindows.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshWindows.FlatStyle = FlatStyle.Flat;
            this.btnRefreshWindows.Click += new System.EventHandler(this.btnRefreshWindows_Click);

            this.grpWindows.Controls.Add(this.lblMain);
            this.grpWindows.Controls.Add(this.cmbMain);
            this.grpWindows.Controls.Add(this.lblSecond);
            this.grpWindows.Controls.Add(this.cmbSecond);
            this.grpWindows.Controls.Add(this.btnRefreshWindows);

            // grpDelay
            this.grpDelay.Text = "Delay (Random)";
            this.grpDelay.Location = new System.Drawing.Point(12, 180);
            this.grpDelay.Size = new System.Drawing.Size(300, 150);
            this.grpDelay.ForeColor = System.Drawing.Color.White;

            // chkDelayEnabled
            this.chkDelayEnabled.Text = "Enable Random Delay";
            this.chkDelayEnabled.Location = new System.Drawing.Point(10, 25);
            this.chkDelayEnabled.Size = new System.Drawing.Size(200, 20);

            // lblDelayMin
            this.lblDelayMin.Text = "Min (sec):";
            this.lblDelayMin.Location = new System.Drawing.Point(10, 60);
            this.lblDelayMin.Size = new System.Drawing.Size(70, 20);

            // numDelayMin
            this.numDelayMin.Location = new System.Drawing.Point(100, 58);
            this.numDelayMin.DecimalPlaces = 1;
            this.numDelayMin.Maximum = 10;
            this.numDelayMin.Minimum = 0;
            this.numDelayMin.Increment = 0.1M;
            this.numDelayMin.Size = new System.Drawing.Size(80, 23);

            // lblDelayMax
            this.lblDelayMax.Text = "Max (sec):";
            this.lblDelayMax.Location = new System.Drawing.Point(10, 95);
            this.lblDelayMax.Size = new System.Drawing.Size(70, 20);

            // numDelayMax
            this.numDelayMax.Location = new System.Drawing.Point(100, 93);
            this.numDelayMax.DecimalPlaces = 1;
            this.numDelayMax.Maximum = 10;
            this.numDelayMax.Minimum = 0;
            this.numDelayMax.Increment = 0.1M;
            this.numDelayMax.Size = new System.Drawing.Size(80, 23);

            this.grpDelay.Controls.Add(this.chkDelayEnabled);
            this.grpDelay.Controls.Add(this.lblDelayMin);
            this.grpDelay.Controls.Add(this.numDelayMin);
            this.grpDelay.Controls.Add(this.lblDelayMax);
            this.grpDelay.Controls.Add(this.numDelayMax);

            // grpChat
            this.grpChat.Text = "Chat";
            this.grpChat.Location = new System.Drawing.Point(12, 340);
            this.grpChat.Size = new System.Drawing.Size(300, 60);
            this.grpChat.ForeColor = System.Drawing.Color.White;

            // chkBlockChat
            this.chkBlockChat.Text = "Block mirroring when chat is open (Enter toggles)";
            this.chkBlockChat.Location = new System.Drawing.Point(10, 25);
            this.chkBlockChat.Size = new System.Drawing.Size(280, 20);

            this.grpChat.Controls.Add(this.chkBlockChat);

            // grpKeys
            this.grpKeys.Text = "Custom Mirror Keys";
            this.grpKeys.Location = new System.Drawing.Point(330, 12);
            this.grpKeys.Size = new System.Drawing.Size(300, 300);
            this.grpKeys.ForeColor = System.Drawing.Color.White;

            // lstKeys
            this.lstKeys.Location = new System.Drawing.Point(10, 25);
            this.lstKeys.Size = new System.Drawing.Size(280, 180);
            this.lstKeys.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.lstKeys.ForeColor = System.Drawing.Color.White;

            // txtKey
            this.txtKey.Location = new System.Drawing.Point(10, 215);
            this.txtKey.Size = new System.Drawing.Size(180, 23);
            this.txtKey.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.txtKey.ForeColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.txtKey, "e.g. F7, A, NumPad1");

            // btnAddKey
            this.btnAddKey.Text = "Add";
            this.btnAddKey.Location = new System.Drawing.Point(200, 213);
            this.btnAddKey.Size = new System.Drawing.Size(90, 25);
            this.btnAddKey.BackColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.btnAddKey.ForeColor = System.Drawing.Color.Black;
            this.btnAddKey.FlatStyle = FlatStyle.Flat;
            this.btnAddKey.Click += new System.EventHandler(this.btnAddKey_Click);

            // btnRemoveKey
            this.btnRemoveKey.Text = "Remove";
            this.btnRemoveKey.Location = new System.Drawing.Point(200, 245);
            this.btnRemoveKey.Size = new System.Drawing.Size(90, 25);
            this.btnRemoveKey.BackColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.btnRemoveKey.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveKey.FlatStyle = FlatStyle.Flat;
            this.btnRemoveKey.Click += new System.EventHandler(this.btnRemoveKey_Click);

            this.grpKeys.Controls.Add(this.lstKeys);
            this.grpKeys.Controls.Add(this.txtKey);
            this.grpKeys.Controls.Add(this.btnAddKey);
            this.grpKeys.Controls.Add(this.btnRemoveKey);

            // btnSave
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(430, 340);
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(530, 340);
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.DialogResult = DialogResult.Cancel;

            // Add controls to form
            this.Controls.Add(this.grpWindows);
            this.Controls.Add(this.grpDelay);
            this.Controls.Add(this.grpChat);
            this.Controls.Add(this.grpKeys);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.numDelayMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayMax)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

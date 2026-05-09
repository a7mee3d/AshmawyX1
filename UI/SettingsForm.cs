using System;
using System.Linq;
using System.Windows.Forms;
using AshmawyX.Core;
using AshmawyX.Models;

namespace AshmawyX.UI
{
    public partial class SettingsForm : Form
    {
        private readonly MirrorEngineConfig _cfg;
        private readonly MirrorKeyService _keys;
        private readonly WindowManager _wm;

        public SettingsForm(MirrorEngineConfig cfg, MirrorKeyService keys, WindowManager wm)
        {
            _cfg = cfg;
            _keys = keys;
            _wm = wm;

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Windows
            var windows = _wm.GetWindows();
            cmbMain.Items.Clear();
            cmbSecond.Items.Clear();

            foreach (var w in windows)
            {
                cmbMain.Items.Add(w);
                cmbSecond.Items.Add(w);
            }

            if (_wm.MainHandle != IntPtr.Zero)
            {
                var main = windows.FirstOrDefault(w => w.Handle == _wm.MainHandle);
                if (main != null) cmbMain.SelectedItem = main;
            }

            if (_wm.SecondHandle != IntPtr.Zero)
            {
                var second = windows.FirstOrDefault(w => w.Handle == _wm.SecondHandle);
                if (second != null) cmbSecond.SelectedItem = second;
            }

            // Delay
            chkDelayEnabled.Checked = _cfg.DelayEnabled;
            numDelayMin.Value = _cfg.MinDelayMs / 1000m;
            numDelayMax.Value = _cfg.MaxDelayMs / 1000m;

            // Block chat
            chkBlockChat.Checked = _cfg.BlockChat;

            // User keys
            lstKeys.Items.Clear();
            foreach (var k in _keys.ExportUserKeys())
                lstKeys.Items.Add(k);
        }

        private void btnRefreshWindows_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Windows
            if (cmbMain.SelectedItem is AOWindow main)
                _wm.MainHandle = _cfg.MainWindow = main.Handle;

            if (cmbSecond.SelectedItem is AOWindow second)
                _wm.SecondHandle = _cfg.SecondWindow = second.Handle;

            // Delay
            _cfg.DelayEnabled = chkDelayEnabled.Checked;
            _cfg.MinDelayMs = (int)(numDelayMin.Value * 1000);
            _cfg.MaxDelayMs = (int)(numDelayMax.Value * 1000);

            // Block chat
            _cfg.BlockChat = chkBlockChat.Checked;

            // User keys
            _keys.ImportUserKeys(lstKeys.Items.Cast<Keys>());

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAddKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKey.Text))
                return;

            if (Enum.TryParse(txtKey.Text, true, out Keys key))
            {
                if (_keys.AddUserKey(key))
                {
                    lstKeys.Items.Add(key);
                }
                else
                {
                    MessageBox.Show("Key is already included (default or user).", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid key name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveKey_Click(object sender, EventArgs e)
        {
            if (lstKeys.SelectedItem is Keys key)
            {
                _keys.RemoveUserKey(key);
                lstKeys.Items.Remove(key);
            }
        }
    }
}

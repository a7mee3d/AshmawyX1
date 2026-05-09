using System;
using System.Drawing;
using System.Windows.Forms;
using AshmawyX.Core;
using AshmawyX.Settings;

namespace AshmawyX.UI
{
    public partial class MainForm : Form
    {
        private readonly MirrorEngineConfig _cfg;
        private readonly MirrorKeyService _keys;
        private readonly WindowManager _wm;

        private readonly KeyboardHook _hook;
        private readonly MirrorEngine _engine;

        public MainForm(MirrorEngineConfig cfg, MirrorKeyService keys, WindowManager wm)
        {
            _cfg = cfg;
            _keys = keys;
            _wm = wm;

            InitializeComponent();

            _engine = new MirrorEngine(_cfg, _keys);
            _hook = new KeyboardHook();
            _hook.KeyPressed += Hook_KeyPressed;

            UpdateStatus();
        }

        private void Hook_KeyPressed(Keys key)
        {
            // Hotkeys
            if (key == Keys.F7)
            {
                StartMirroring();
                return;
            }

            if (key == Keys.F8)
            {
                StopMirroring();
                return;
            }

            // Chat toggle
            if (_cfg.BlockChat && key == Keys.Enter)
            {
                _cfg.ChatOpen = !_cfg.ChatOpen;
                UpdateStatus();
                return;
            }

            _engine.HandleKey(key);
        }

        private void StartMirroring()
        {
            if (_cfg.MainWindow == IntPtr.Zero || _cfg.SecondWindow == IntPtr.Zero)
            {
                MessageBox.Show("Please select main and second windows in Settings.",
                    "Missing Windows", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _cfg.Enabled = true;
            _hook.Install();
            UpdateStatus();
        }

        private void StopMirroring()
        {
            _cfg.Enabled = false;
            _hook.Uninstall();
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            if (!_cfg.Enabled)
            {
                lblStatus.Text = "Status: Stopped";
                lblStatus.ForeColor = Color.OrangeRed;
                return;
            }

            if (_cfg.BlockChat && _cfg.ChatOpen)
            {
                lblStatus.Text = "Status: Chat Open (Paused)";
                lblStatus.ForeColor = Color.Yellow;
                return;
            }

            lblStatus.Text = "Status: Running";
            lblStatus.ForeColor = Color.Lime;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartMirroring();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopMirroring();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var dlg = new SettingsForm(_cfg, _keys, _wm))
            {
                dlg.ShowDialog(this);
                SettingsManager.Save(_cfg, _keys, _wm);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingsManager.Save(_cfg, _keys, _wm);
            _hook.Uninstall();
        }
    }
}

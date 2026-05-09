using System;
using System.Windows.Forms;
using AshmawyX.Core;

namespace AshmawyX
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var config = new MirrorEngineConfig();
            var keyService = new MirrorKeyService();
            var windowManager = new WindowManager();

            Settings.SettingsManager.Load(config, keyService, windowManager);

            Application.Run(new UI.MainForm(config, keyService, windowManager));
        }
    }
}

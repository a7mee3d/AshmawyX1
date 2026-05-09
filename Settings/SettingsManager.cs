using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using AshmawyX.Core;
using Newtonsoft.Json;

namespace AshmawyX.Settings
{
    public static class SettingsManager
    {
        private static readonly string FilePath = "ashmawyx.settings.json";

        private class SettingsDto
        {
            public bool Enabled { get; set; }
            public bool BlockChat { get; set; }
            public bool DelayEnabled { get; set; }
            public int MinDelayMs { get; set; }
            public int MaxDelayMs { get; set; }
            public long MainHandle { get; set; }
            public long SecondHandle { get; set; }
            public List<Keys> UserMirrorKeys { get; set; }
        }

        public static void Save(MirrorEngineConfig cfg, MirrorKeyService keys, WindowManager wm)
        {
            SettingsDto dto = new SettingsDto
            {
                Enabled = cfg.Enabled,
                BlockChat = cfg.BlockChat,
                DelayEnabled = cfg.DelayEnabled,
                MinDelayMs = cfg.MinDelayMs,
                MaxDelayMs = cfg.MaxDelayMs,
                MainHandle = wm.MainHandle.ToInt64(),
                SecondHandle = wm.SecondHandle.ToInt64(),
                UserMirrorKeys = new List<Keys>(keys.ExportUserKeys())
            };

            string json = JsonConvert.SerializeObject(dto, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static void Load(MirrorEngineConfig cfg, MirrorKeyService keys, WindowManager wm)
        {
            if (!File.Exists(FilePath))
                return;

            string json = File.ReadAllText(FilePath);
            SettingsDto dto = JsonConvert.DeserializeObject<SettingsDto>(json);
            if (dto == null)
                return;

            cfg.Enabled = dto.Enabled;
            cfg.BlockChat = dto.BlockChat;
            cfg.DelayEnabled = dto.DelayEnabled;
            cfg.MinDelayMs = dto.MinDelayMs;
            cfg.MaxDelayMs = dto.MaxDelayMs;

            wm.MainHandle = new IntPtr(dto.MainHandle);
            wm.SecondHandle = new IntPtr(dto.SecondHandle);

            keys.ImportUserKeys(dto.UserMirrorKeys ?? new List<Keys>());
        }
    }
}

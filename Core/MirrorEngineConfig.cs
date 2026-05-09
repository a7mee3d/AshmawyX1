using System;

namespace AshmawyX.Core
{
    public class MirrorEngineConfig
    {
        public bool Enabled { get; set; }
        public bool BlockChat { get; set; }
        public bool ChatOpen { get; set; }

        public IntPtr MainWindow { get; set; }
        public IntPtr SecondWindow { get; set; }

        public bool DelayEnabled { get; set; }
        public int MinDelayMs { get; set; }
        public int MaxDelayMs { get; set; }
    }
}

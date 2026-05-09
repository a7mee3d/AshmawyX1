using System;
using System.Threading;
using System.Windows.Forms;
using AshmawyX.Utilities;

namespace AshmawyX.Core
{
    public class MirrorEngine
    {
        private readonly MirrorEngineConfig _cfg;
        private readonly MirrorKeyService _keys;
        private readonly Sender _sender = new Sender();
        private readonly Random _rng = new Random();

        public MirrorEngine(MirrorEngineConfig cfg, MirrorKeyService keys)
        {
            _cfg = cfg;
            _keys = keys;
        }

        public void HandleKey(Keys key)
        {
            if (!_cfg.Enabled) return;
            if (_cfg.SecondWindow == IntPtr.Zero) return;
            if (_cfg.BlockChat && _cfg.ChatOpen) return;
            if (!_keys.IsMirrorKey(key)) return;

            if (_cfg.DelayEnabled && _cfg.MinDelayMs >= 0 && _cfg.MaxDelayMs >= _cfg.MinDelayMs)
            {
                int delay = _rng.Next(_cfg.MinDelayMs, _cfg.MaxDelayMs + 1);
                ThreadPool.QueueUserWorkItem(delegate
                {
                    Thread.Sleep(delay);
                    _sender.SendKey(_cfg.SecondWindow, (int)key);
                });
            }
            else
            {
                _sender.SendKey(_cfg.SecondWindow, (int)key);
            }
        }
    }
}

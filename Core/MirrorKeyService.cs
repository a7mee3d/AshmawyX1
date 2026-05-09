using System.Collections.Generic;
using System.Windows.Forms;

namespace AshmawyX.Core
{
    public class MirrorKeyService
    {
        // Default mirror keys: 0–9, F1–F6, Shift keys
        private readonly HashSet<Keys> _defaultKeys = new HashSet<Keys>
        {
            Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4,
            Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9,
            Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6,
            Keys.LShiftKey, Keys.RShiftKey
        };

        // User‑added mirror keys
        private readonly HashSet<Keys> _userKeys = new HashSet<Keys>();

        public bool IsMirrorKey(Keys key)
        {
            return _defaultKeys.Contains(key) || _userKeys.Contains(key);
        }

        public bool AddUserKey(Keys key)
        {
            if (_defaultKeys.Contains(key))
                return false; // already included by default

            return _userKeys.Add(key);
        }

        public bool RemoveUserKey(Keys key)
        {
            return _userKeys.Remove(key);
        }

        public IEnumerable<Keys> ExportUserKeys()
        {
            return _userKeys;
        }

        public void ImportUserKeys(IEnumerable<Keys> keys)
        {
            _userKeys.Clear();
            foreach (Keys k in keys)
            {
                if (!_defaultKeys.Contains(k))
                    _userKeys.Add(k);
            }
        }
    }
}

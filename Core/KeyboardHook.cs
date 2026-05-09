using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AshmawyX.Utilities;

namespace AshmawyX.Core
{
    public class KeyboardHook
    {
        private IntPtr _hookId = IntPtr.Zero;
        private WinApi.LowLevelKeyboardProc _proc;

        public event Action<Keys> KeyPressed;

        public KeyboardHook()
        {
            _proc = HookCallback;
        }

        public void Install()
        {
            IntPtr hInstance = WinApi.GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName);
            _hookId = WinApi.SetWindowsHookEx(WinApi.WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public void Uninstall()
        {
            if (_hookId != IntPtr.Zero)
            {
                WinApi.UnhookWindowsHookEx(_hookId);
                _hookId = IntPtr.Zero;
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 &&
                (wParam == (IntPtr)WinApi.WM_KEYDOWN || wParam == (IntPtr)WinApi.WM_SYSKEYDOWN))
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;
                KeyPressed?.Invoke(key);
            }

            return WinApi.CallNextHookEx(_hookId, nCode, wParam, lParam);
        }
    }
}

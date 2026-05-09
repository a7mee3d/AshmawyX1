using System;
using System.Collections.Generic;
using System.Text;
using AshmawyX.Models;
using AshmawyX.Utilities;

namespace AshmawyX.Core
{
    public class WindowManager
    {
        public IntPtr MainHandle { get; set; }
        public IntPtr SecondHandle { get; set; }

        public List<AOWindow> GetWindows()
        {
            List<AOWindow> list = new List<AOWindow>();

            WinApi.EnumWindows(delegate (IntPtr hWnd, IntPtr lParam)
            {
                if (!WinApi.IsWindowVisible(hWnd))
                    return true;

                int length = WinApi.GetWindowTextLength(hWnd);
                if (length == 0)
                    return true;

                StringBuilder sb = new StringBuilder(length + 1);
                WinApi.GetWindowText(hWnd, sb, sb.Capacity);

                string title = sb.ToString();

                if (title.Contains("Anarchy Online"))
                {
                    list.Add(new AOWindow
                    {
                        Title = title,
                        Handle = hWnd
                    });
                }

                return true;

            }, IntPtr.Zero);

            return list;
        }
    }
}

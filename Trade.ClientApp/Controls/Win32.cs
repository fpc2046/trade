using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Trade.ClientApp.Controls
{
    public class Win32
    {
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hwnd, IntPtr hregion, Boolean round);

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);

        [DllImport("gdi32.dll")]
        public static extern int DeleteObject(IntPtr objh);

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}

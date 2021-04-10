using System;
using System.Runtime.InteropServices;

namespace FullScreenMode
{
    // TODO: DON'T DO THIS
    internal class HandleTaskBar
    {
        [DllImport("User32.dll")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern int SetWindowPos(int hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        public static void ShowTaskBar()
            => SetWindowPos(FindWindow("Shell_TrayWnd", ""), 0, 0, 0, 0, 0, 64);

        public static void HideTaskBar()
            => SetWindowPos(FindWindow("Shell_TrayWnd", ""), 0, 0, 0, 0, 0, 128);
    }
}

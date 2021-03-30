using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuickTranslator
{
    public class ScrollingRichTextBox : RichTextBox
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        public void ScrollToBottom()
        {
            SendMessage(Handle, 277U, new IntPtr(7), new IntPtr(0));
        }

        public void ScrollToTop()
        {
            SendMessage(Handle, 277U, new IntPtr(6), new IntPtr(0));
        }

        public void ScrollLineDown()
        {
            SendMessage(Handle, 277U, new IntPtr(1), new IntPtr(0));
        }

        public void ScrollLineUp()
        {
            SendMessage(Handle, 277U, new IntPtr(0), new IntPtr(0));
        }
    }
}

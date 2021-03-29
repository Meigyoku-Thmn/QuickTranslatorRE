using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuickTranslator
{
	// Token: 0x02000017 RID: 23
	public class ScrollingRichTextBox : RichTextBox
	{
		// Token: 0x0600013B RID: 315
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600013C RID: 316 RVA: 0x0001173B File Offset: 0x0001073B
		public void ScrollToBottom()
		{
			ScrollingRichTextBox.SendMessage(base.Handle, 277U, new IntPtr(7), new IntPtr(0));
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001175A File Offset: 0x0001075A
		public void ScrollToTop()
		{
			ScrollingRichTextBox.SendMessage(base.Handle, 277U, new IntPtr(6), new IntPtr(0));
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00011779 File Offset: 0x00010779
		public void ScrollLineDown()
		{
			ScrollingRichTextBox.SendMessage(base.Handle, 277U, new IntPtr(1), new IntPtr(0));
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00011798 File Offset: 0x00010798
		public void ScrollLineUp()
		{
			ScrollingRichTextBox.SendMessage(base.Handle, 277U, new IntPtr(0), new IntPtr(0));
		}

		// Token: 0x04000155 RID: 341
		private const int WM_VSCROLL = 277;

		// Token: 0x04000156 RID: 342
		private const int SB_LINEUP = 0;

		// Token: 0x04000157 RID: 343
		private const int SB_LINEDOWN = 1;

		// Token: 0x04000158 RID: 344
		private const int SB_TOP = 6;

		// Token: 0x04000159 RID: 345
		private const int SB_BOTTOM = 7;
	}
}

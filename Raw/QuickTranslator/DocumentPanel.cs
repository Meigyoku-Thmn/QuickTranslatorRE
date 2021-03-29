using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace QuickTranslator
{
	// Token: 0x02000004 RID: 4
	public partial class DocumentPanel : DockContent
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00006DD9 File Offset: 0x00005DD9
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00006DE1 File Offset: 0x00005DE1
		public int CurrentHighlightedTextStartIndex
		{
			get
			{
				return this.currentHighlightedTextStartIndex;
			}
			set
			{
				this.currentHighlightedTextStartIndex = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00006DEA File Offset: 0x00005DEA
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00006DF2 File Offset: 0x00005DF2
		public int CurrentHighlightedTextLength
		{
			get
			{
				return this.currentHighlightedTextLength;
			}
			set
			{
				this.currentHighlightedTextLength = value;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00006DFB File Offset: 0x00005DFB
		public DocumentPanel()
		{
			this.InitializeComponent();
			base.DockHandler.GetPersistStringCallback = new GetPersistStringCallback(this.GetPersistStringFromText);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00006E27 File Offset: 0x00005E27
		public DocumentPanel(bool textReadOnly)
		{
			this.InitializeComponent();
			this.contentRichTextBox.ReadOnly = textReadOnly;
			base.DockHandler.GetPersistStringCallback = new GetPersistStringCallback(this.GetPersistStringFromText);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00006E5F File Offset: 0x00005E5F
		public string GetPersistStringFromText()
		{
			return this.Text;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00006E67 File Offset: 0x00005E67
		public string GetSelectedText()
		{
			return this.contentRichTextBox.SelectedText;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00006E74 File Offset: 0x00005E74
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00006E81 File Offset: 0x00005E81
		public bool TextReadOnly
		{
			get
			{
				return this.contentRichTextBox.ReadOnly;
			}
			set
			{
				this.contentRichTextBox.ReadOnly = value;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00006E8F File Offset: 0x00005E8F
		public string GetTextContent()
		{
			return this.contentRichTextBox.Text;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006E9C File Offset: 0x00005E9C
		public void SetTextContent(string text)
		{
			this.contentRichTextBox.Text = text;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00006EAA File Offset: 0x00005EAA
		public string GetRtfContent()
		{
			return this.contentRichTextBox.Rtf;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006EB7 File Offset: 0x00005EB7
		public void SetRftContent(string rft)
		{
			this.contentRichTextBox.Rtf = rft;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00006EC5 File Offset: 0x00005EC5
		public void AppendText(string text)
		{
			this.contentRichTextBox.AppendText(text);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00006ED3 File Offset: 0x00005ED3
		public void AppendTextToCurrentCursor(string text)
		{
			this.contentRichTextBox.SelectedText = text;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006EE4 File Offset: 0x00005EE4
		public string GetTwoCharsBeforeSelectedText()
		{
			if (this.contentRichTextBox.SelectionStart == 0)
			{
				return "";
			}
			if (this.contentRichTextBox.SelectionStart == 1)
			{
				return this.contentRichTextBox.Text[0].ToString();
			}
			return this.contentRichTextBox.Text.Substring(this.contentRichTextBox.SelectionStart - 2, 2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006F4C File Offset: 0x00005F4C
		public string GetTwoCharsAfterSelectedText()
		{
			int num = this.contentRichTextBox.SelectionStart;
			if (1 < this.contentRichTextBox.SelectionLength)
			{
				num += this.contentRichTextBox.SelectionLength - 1;
			}
			if (this.contentRichTextBox.TextLength - 1 <= num)
			{
				return "";
			}
			if (this.contentRichTextBox.TextLength - 2 == num)
			{
				return this.contentRichTextBox.Text[num + 1].ToString();
			}
			return this.contentRichTextBox.Text.Substring(num + 1, 2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006FDC File Offset: 0x00005FDC
		public int getPreviousWordIndex()
		{
			int num = this.contentRichTextBox.SelectionStart;
			bool flag = false;
			while (1 <= num)
			{
				num--;
				if (this.contentRichTextBox.Text[num] == ' ' || this.contentRichTextBox.Text[num] == '.' || this.contentRichTextBox.Text[num] == ',' || this.contentRichTextBox.Text[num] == ':' || this.contentRichTextBox.Text[num] == ';' || this.contentRichTextBox.Text[num] == '?' || this.contentRichTextBox.Text[num] == '!' || this.contentRichTextBox.Text[num] == '\'' || this.contentRichTextBox.Text[num] == '\n' || this.contentRichTextBox.Text[num] == '"')
				{
					flag = true;
				}
				else if (flag)
				{
					break;
				}
			}
			return num;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000070EC File Offset: 0x000060EC
		public int getNextWordIndex()
		{
			int i = this.contentRichTextBox.SelectionStart;
			bool flag = false;
			while (i <= this.contentRichTextBox.TextLength - 2)
			{
				i++;
				if (this.contentRichTextBox.Text[i] == ' ' || this.contentRichTextBox.Text[i] == '.' || this.contentRichTextBox.Text[i] == ',' || this.contentRichTextBox.Text[i] == ':' || this.contentRichTextBox.Text[i] == ';' || this.contentRichTextBox.Text[i] == '?' || this.contentRichTextBox.Text[i] == '!' || this.contentRichTextBox.Text[i] == '\'' || this.contentRichTextBox.Text[i] == '\t' || this.contentRichTextBox.Text[i] == '\n' || this.contentRichTextBox.Text[i] == '"')
				{
					flag = true;
				}
				else if (flag)
				{
					break;
				}
			}
			return i;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00007220 File Offset: 0x00006220
		public int getNextLineIndex()
		{
			int lineFromCharIndex = this.contentRichTextBox.GetLineFromCharIndex(this.contentRichTextBox.SelectionStart);
			int lineFromCharIndex2 = this.contentRichTextBox.GetLineFromCharIndex(this.contentRichTextBox.TextLength - 1);
			int num = this.contentRichTextBox.GetFirstCharIndexFromLine((lineFromCharIndex <= lineFromCharIndex2 - 1) ? (lineFromCharIndex + 1) : lineFromCharIndex);
			while (this.contentRichTextBox.Text[num] == ' ' || this.contentRichTextBox.Text[num] == '.' || this.contentRichTextBox.Text[num] == ',' || this.contentRichTextBox.Text[num] == ':' || this.contentRichTextBox.Text[num] == ';' || this.contentRichTextBox.Text[num] == '?' || this.contentRichTextBox.Text[num] == '!' || this.contentRichTextBox.Text[num] == '\'' || this.contentRichTextBox.Text[num] == '\t' || this.contentRichTextBox.Text[num] == '\n' || this.contentRichTextBox.Text[num] == '"')
			{
				num++;
				if (num == this.contentRichTextBox.TextLength)
				{
					break;
				}
			}
			return num;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00007388 File Offset: 0x00006388
		public int getPreviousLineIndex()
		{
			int num = this.contentRichTextBox.GetLineFromCharIndex(this.contentRichTextBox.SelectionStart);
			int num2 = this.contentRichTextBox.GetFirstCharIndexFromLine((num <= 0) ? 0 : (num - 1));
			while (this.contentRichTextBox.Text[num2] == '\n')
			{
				num--;
				num2 = this.contentRichTextBox.GetFirstCharIndexFromLine((num <= 0) ? 0 : (num - 1));
				if (num2 <= 0)
				{
					IL_79:
					while (this.contentRichTextBox.Text[num2] == ' ' || this.contentRichTextBox.Text[num2] == '.' || this.contentRichTextBox.Text[num2] == ',' || this.contentRichTextBox.Text[num2] == ':' || this.contentRichTextBox.Text[num2] == ';' || this.contentRichTextBox.Text[num2] == '?' || this.contentRichTextBox.Text[num2] == '!' || this.contentRichTextBox.Text[num2] == '\'' || this.contentRichTextBox.Text[num2] == '\t' || this.contentRichTextBox.Text[num2] == '\n' || this.contentRichTextBox.Text[num2] == '"')
					{
						num2++;
						if (this.contentRichTextBox.TextLength <= num2)
						{
							break;
						}
					}
					return num2;
				}
			}
			goto IL_79;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00007508 File Offset: 0x00006508
		public int getCurrentLineIndex()
		{
			return this.contentRichTextBox.GetLineFromCharIndex(this.contentRichTextBox.SelectionStart);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00007520 File Offset: 0x00006520
		public int getNextPhysicalLineIndex()
		{
			int num = this.contentRichTextBox.SelectionStart;
			while (this.contentRichTextBox.Text[num] != '\n')
			{
				num++;
				if (this.contentRichTextBox.TextLength - 1 <= num)
				{
					IL_4E:
					while (this.contentRichTextBox.Text[num] == ' ' || this.contentRichTextBox.Text[num] == '.' || this.contentRichTextBox.Text[num] == ',' || this.contentRichTextBox.Text[num] == ':' || this.contentRichTextBox.Text[num] == ';' || this.contentRichTextBox.Text[num] == '?' || this.contentRichTextBox.Text[num] == '!' || this.contentRichTextBox.Text[num] == '\'' || this.contentRichTextBox.Text[num] == '\t' || this.contentRichTextBox.Text[num] == '\n' || this.contentRichTextBox.Text[num] == '"')
					{
						num++;
						if (num == this.contentRichTextBox.TextLength)
						{
							break;
						}
					}
					return num;
				}
			}
			goto IL_4E;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00007678 File Offset: 0x00006678
		public int getPreviousPhysicalLineIndex()
		{
			int num = this.contentRichTextBox.SelectionStart;
			bool flag = false;
			for (;;)
			{
				num--;
				if (num == 0)
				{
					break;
				}
				if (this.contentRichTextBox.Text[num] == '\n' && this.contentRichTextBox.Text[num - 1] == '\n')
				{
					num--;
					if (num <= 0 || flag)
					{
						break;
					}
					flag = true;
				}
			}
			while (this.contentRichTextBox.Text[num] == ' ' || this.contentRichTextBox.Text[num] == '.' || this.contentRichTextBox.Text[num] == ',' || this.contentRichTextBox.Text[num] == ':' || this.contentRichTextBox.Text[num] == ';' || this.contentRichTextBox.Text[num] == '?' || this.contentRichTextBox.Text[num] == '!' || this.contentRichTextBox.Text[num] == '\'' || this.contentRichTextBox.Text[num] == '\t' || this.contentRichTextBox.Text[num] == '\n' || this.contentRichTextBox.Text[num] == '"')
			{
				num++;
				if (num == this.contentRichTextBox.TextLength)
				{
					break;
				}
			}
			return num;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000077E4 File Offset: 0x000067E4
		public string GetHighlightText()
		{
			return this.contentRichTextBox.Text.Substring(this.currentHighlightedTextStartIndex, this.currentHighlightedTextLength);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00007802 File Offset: 0x00006802
		public void HighlightText(int startIndex, int length)
		{
			this.HighlightText(startIndex, length, false, true);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00007810 File Offset: 0x00006810
		public void HighlightText(int startIndex, int length, bool clearTextSelection, bool scrollToCaret)
		{
			if (base.IsHidden)
			{
				return;
			}
			base.SuspendLayout();
			this.contentRichTextBox.Select(this.currentHighlightedTextStartIndex, this.currentHighlightedTextLength);
			this.contentRichTextBox.SelectionColor = this.contentRichTextBox.ForeColor;
			this.contentRichTextBox.Select(startIndex, length);
			this.contentRichTextBox.SelectionColor = Color.Red;
			this.currentHighlightedTextStartIndex = startIndex;
			this.currentHighlightedTextLength = length;
			if (clearTextSelection)
			{
				this.contentRichTextBox.Select(startIndex, 0);
			}
			if (this.contentRichTextBox.Height <= this.contentRichTextBox.GetPositionFromCharIndex(this.currentHighlightedTextStartIndex).Y + 50 || this.contentRichTextBox.GetPositionFromCharIndex(this.currentHighlightedTextStartIndex).Y <= 30)
			{
				this.contentRichTextBox.ScrollToCaret();
				this.contentRichTextBox.ScrollLineUp();
				this.contentRichTextBox.ScrollLineUp();
			}
			base.ResumeLayout();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00007904 File Offset: 0x00006904
		public void SelectText(int startIndex, int length)
		{
			base.SuspendLayout();
			this.contentRichTextBox.Select(startIndex, length);
			if (this.contentRichTextBox.Height <= this.contentRichTextBox.GetPositionFromCharIndex(this.currentHighlightedTextStartIndex).Y + 50 || this.contentRichTextBox.GetPositionFromCharIndex(this.currentHighlightedTextStartIndex).Y <= 50)
			{
				this.contentRichTextBox.ScrollToCaret();
				this.contentRichTextBox.ScrollLineUp();
				this.contentRichTextBox.ScrollLineUp();
			}
			base.ResumeLayout();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00007991 File Offset: 0x00006991
		public int getSelectionStart()
		{
			return this.contentRichTextBox.SelectionStart;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000799E File Offset: 0x0000699E
		public int getSelectionLength()
		{
			return this.contentRichTextBox.SelectionLength;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000079AB File Offset: 0x000069AB
		public void SetFontSize(float size)
		{
			this.contentRichTextBox.SuspendLayout();
			this.contentRichTextBox.Font = new Font(this.contentRichTextBox.Font.FontFamily, size);
			this.contentRichTextBox.ResumeLayout();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000079E4 File Offset: 0x000069E4
		public void ScrollToTop()
		{
			this.contentRichTextBox.SelectionStart = 0;
			this.contentRichTextBox.ScrollToCaret();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000079FD File Offset: 0x000069FD
		public void ScrollToBottom()
		{
			this.contentRichTextBox.SelectionStart = this.contentRichTextBox.TextLength;
			this.contentRichTextBox.ScrollToCaret();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00007A20 File Offset: 0x00006A20
		public void FocusInRichTextBox()
		{
			this.contentRichTextBox.Focus();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00007A30 File Offset: 0x00006A30
		private void ContentRichTextBoxMouseUp(object sender, MouseEventArgs e)
		{
			int num = this.contentRichTextBox.GetCharIndexFromPosition(e.Location);
			char c = this.contentRichTextBox.GetCharFromPosition(e.Location);
			int num2 = 1000;
			int num3 = 0;
			while (0 <= num)
			{
				if (num2 <= num3)
				{
					return;
				}
				if (0 < num && c == ' ')
				{
					num--;
					c = this.contentRichTextBox.Text[num];
				}
				else
				{
					if (num > this.contentRichTextBox.TextLength - 1 || c != '\t')
					{
						break;
					}
					num++;
					c = this.contentRichTextBox.Text[num];
				}
				num3++;
			}
			if (0 < this.contentRichTextBox.SelectionLength)
			{
				if (this.SelectTextHandler != null)
				{
					this.SelectTextHandler();
				}
				return;
			}
			if (e.Button == MouseButtons.Left)
			{
				if (this.ClickHandler != null)
				{
					this.ClickHandler(num);
					return;
				}
			}
			else if (this.RightClickHandler != null)
			{
				this.RightClickHandler(num);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00007B1C File Offset: 0x00006B1C
		public void ScrollToASpecificLogicalLine(int logicalLine)
		{
			this.contentRichTextBox.SelectionStart = Math.Max(this.contentRichTextBox.GetFirstCharIndexFromLine(logicalLine), 0);
			this.contentRichTextBox.SelectionLength = 0;
			this.contentRichTextBox.ScrollToCaret();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00007B54 File Offset: 0x00006B54
		public void ScrollToASpecificPhysicalLine(int physicalLine)
		{
			int num = -1;
			string text = this.contentRichTextBox.Text;
			int num2 = 0;
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == '\n')
				{
					num2++;
					num = i;
					if (physicalLine - 1 <= num2)
					{
						num = i + 1;
						break;
					}
				}
			}
			if (this.contentRichTextBox.TextLength - 1 < num)
			{
				num = ((this.contentRichTextBox.TextLength == 0) ? 0 : (this.contentRichTextBox.TextLength - 1));
			}
			this.contentRichTextBox.SelectionStart = num;
			this.contentRichTextBox.SelectionLength = 0;
			this.contentRichTextBox.ScrollToCaret();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007BF0 File Offset: 0x00006BF0
		private void MarkForReviewToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.contentRichTextBox.SelectionColor = Color.Red;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007C02 File Offset: 0x00006C02
		public void EnableCommentContextMenuStrip()
		{
			this.contentRichTextBox.ContextMenuStrip = this.commentContextMenuStrip;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007C15 File Offset: 0x00006C15
		public void EnableAddToVietPhraseContextMenuStrip()
		{
			this.contentRichTextBox.ContextMenuStrip = this.addToVietPhraseContextMenuStrip;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007C28 File Offset: 0x00006C28
		private void ClearNoteToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.contentRichTextBox.SelectionColor = Color.Black;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007C3A File Offset: 0x00006C3A
		private void AddToVietPhraseToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.AddToVietPhraseHandler != null)
			{
				this.AddToVietPhraseHandler(0);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00007C50 File Offset: 0x00006C50
		private void AddToNameToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.AddToVietPhraseHandler != null)
			{
				this.AddToVietPhraseHandler(1);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007C66 File Offset: 0x00006C66
		private void AddToVietPhraseContextMenuStripOpening(object sender, CancelEventArgs e)
		{
			if (this.contentRichTextBox.SelectionLength == 0)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007C7C File Offset: 0x00006C7C
		private void BaikeingToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.BaikeingHandler != null)
			{
				this.BaikeingHandler();
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007C91 File Offset: 0x00006C91
		private void CopyToVietToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.CopyToVietHandler != null)
			{
				this.CopyToVietHandler(this.contentRichTextBox.SelectedText);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007CB4 File Offset: 0x00006CB4
		private void contentRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.contentRichTextBox.ReadOnly)
			{
				return;
			}
			if (('A' <= e.KeyChar && e.KeyChar <= 'Z') || ('a' <= e.KeyChar && e.KeyChar <= 'z'))
			{
				return;
			}
			int selectionStart = this.contentRichTextBox.SelectionStart;
			if (selectionStart == 0)
			{
				return;
			}
			int num = selectionStart - 1;
			while (0 <= num && this.contentRichTextBox.Text[num] != '\n' && this.contentRichTextBox.Text[num] != ' ' && this.contentRichTextBox.Text[num] != '\'' && this.contentRichTextBox.Text[num] != '[' && this.contentRichTextBox.Text[num] != ']' && this.contentRichTextBox.Text[num] != '(' && this.contentRichTextBox.Text[num] != ')' && this.contentRichTextBox.Text[num] != '*' && this.contentRichTextBox.Text[num] != '"')
			{
				num--;
			}
			num++;
			int num2 = selectionStart - 1;
			if (num2 <= num)
			{
				return;
			}
			string text = this.contentRichTextBox.Text.Substring(num, num2 - num + 1);
			string textToReplace = this.getTextToReplace(text);
			if (string.IsNullOrEmpty(textToReplace))
			{
				return;
			}
			this.contentRichTextBox.Select(num, num2 - num + 1);
			this.contentRichTextBox.SelectedText = textToReplace;
			this.contentRichTextBox.Select(selectionStart + textToReplace.Length - text.Length, 0);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007E53 File Offset: 0x00006E53
		private string getTextToReplace(string textToLookup)
		{
			return Shortcuts.GetValueFromKey(textToLookup);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007E5C File Offset: 0x00006E5C
		private void InsertBlankLinesToolStripMenuItemClick(object sender, EventArgs e)
		{
			string text = this.contentRichTextBox.Rtf;
			string text2 = "";
			for (int i = 0; i < 100; i++)
			{
				text2 = text.Replace("\\par\r\n\\par\r\n", "\\par\r\n");
				if (text.Equals(text2))
				{
					break;
				}
				text = text2;
			}
			this.contentRichTextBox.Rtf = text2.Replace("\\par\r\n", "\\par\r\n\\par\r\n");
			this.ScrollToBottom();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007EC5 File Offset: 0x00006EC5
		public void SetBackColor(Color color)
		{
			this.contentRichTextBox.BackColor = color;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007ED3 File Offset: 0x00006ED3
		public void SetForeColor(Color color)
		{
			this.contentRichTextBox.ForeColor = color;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007EE1 File Offset: 0x00006EE1
		public void SetFont(Font font)
		{
			this.contentRichTextBox.Font = font;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007EEF File Offset: 0x00006EEF
		public void AllowDeletingSelectedText()
		{
			this.deleteSelectedTextToolStripMenuItem.Enabled = true;
			this.deleteSelectedTextToolStripMenuItem.Visible = true;
			this.deleteRememberToolStripMenuItem.Enabled = true;
			this.deleteRememberToolStripMenuItem.Visible = true;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00007F21 File Offset: 0x00006F21
		private void DeleteSelectedTextToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.DeleteSelectedTextHandler != null)
			{
				this.DeleteSelectedTextHandler(false);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00007F38 File Offset: 0x00006F38
		public void DeleteSelectedText()
		{
			bool readOnly = this.contentRichTextBox.ReadOnly;
			this.contentRichTextBox.ReadOnly = false;
			this.contentRichTextBox.SelectedText = "";
			this.contentRichTextBox.ReadOnly = readOnly;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007F7C File Offset: 0x00006F7C
		private void CopyToClipboardToolStripMenuItemClick(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(string.IsNullOrEmpty(this.contentRichTextBox.SelectedText) ? string.Empty : this.contentRichTextBox.SelectedText);
			}
			catch
			{
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007FC8 File Offset: 0x00006FC8
		private void UpdatePhienAmToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.AddToPhienAmHandler != null)
			{
				this.AddToPhienAmHandler();
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007FDD File Offset: 0x00006FDD
		private void NcikuToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.NcikuingHandler != null)
			{
				this.NcikuingHandler();
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007FF4 File Offset: 0x00006FF4
		private void DocumentPanelKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				switch (e.KeyData)
				{
				case Keys.F:
					e.Handled = true;
					return;
				case Keys.G:
					e.Handled = true;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00008031 File Offset: 0x00007031
		public void ReplaceHighlightedText(string text)
		{
			this.contentRichTextBox.SelectionStart = this.currentHighlightedTextStartIndex;
			this.contentRichTextBox.SelectionLength = this.currentHighlightedTextLength;
			this.contentRichTextBox.SelectedText = text;
			this.currentHighlightedTextLength = text.Length;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000806D File Offset: 0x0000706D
		private void UpdateNamePhuToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.AddToVietPhraseHandler != null)
			{
				this.AddToVietPhraseHandler(2);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00008084 File Offset: 0x00007084
		protected override bool ProcessKeyPreview(ref Message message)
		{
			if (!"VietPhrase một nghĩa".Equals(this.Text))
			{
				return base.ProcessKeyPreview(ref message);
			}
			Keys keys = (Keys)((int)message.WParam);
			if (message.Msg == 256 && keys == Keys.Tab)
			{
				if (this.tabIsDown)
				{
					return base.ProcessKeyPreview(ref message);
				}
				if (this.currentHighlightedTextStartIndex < 0 || this.currentHighlightedTextLength <= 0 || this.contentRichTextBox.Text[this.currentHighlightedTextStartIndex] == '\n')
				{
					return base.ProcessKeyPreview(ref message);
				}
				this.contentRichTextBox.Cursor = Cursors.SizeAll;
				this.tabIsDown = true;
			}
			else if (message.Msg == 257 && keys == Keys.Tab)
			{
				if (this.tabIsDown)
				{
					this.tabIsDown = false;
					if (this.ShiftUpHandler != null && this.contentRichTextBox.SelectionLength == 0)
					{
						this.ShiftUpHandler();
					}
				}
				this.contentRichTextBox.Cursor = Cursors.IBeam;
				this.lastCharIndexUnderMouseMove = -1;
			}
			return base.ProcessKeyPreview(ref message);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00008188 File Offset: 0x00007188
		private void ContentRichTextBoxMouseMove(object sender, MouseEventArgs e)
		{
			if (this.tabIsDown)
			{
				int charIndexFromPosition = this.contentRichTextBox.GetCharIndexFromPosition(e.Location);
				if (this.lastCharIndexUnderMouseMove == charIndexFromPosition)
				{
					return;
				}
				this.lastCharIndexUnderMouseMove = charIndexFromPosition;
				if (this.currentHighlightedTextStartIndex <= charIndexFromPosition && charIndexFromPosition <= this.currentHighlightedTextStartIndex + this.currentHighlightedTextLength - 1)
				{
					this.contentRichTextBox.SelectionStart = this.currentHighlightedTextStartIndex;
					this.contentRichTextBox.SelectionLength = 0;
					return;
				}
				if (charIndexFromPosition < this.GetCurrentBlockStartIndex() || this.GetCurrentBlockEndIndex() < charIndexFromPosition)
				{
					this.contentRichTextBox.SelectionStart = this.currentHighlightedTextStartIndex;
					this.contentRichTextBox.SelectionLength = 0;
					return;
				}
				if (this.ShiftAndMouseMoveHandler != null)
				{
					this.ShiftAndMouseMoveHandler(charIndexFromPosition);
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00008244 File Offset: 0x00007244
		public int GetCurrentBlockStartIndex()
		{
			int num = this.currentHighlightedTextStartIndex;
			while (num != 0 && this.contentRichTextBox.Text[num - 1] != '\t' && this.contentRichTextBox.Text[num - 1] != '\n' && (this.contentRichTextBox.Text[num - 1] != ' ' || !".,:;!?\"".Contains(this.contentRichTextBox.Text[num - 2].ToString())))
			{
				num--;
			}
			return num;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000082D0 File Offset: 0x000072D0
		public int GetCurrentBlockEndIndex()
		{
			int num = this.currentHighlightedTextStartIndex + this.currentHighlightedTextLength - 1;
			int num2 = this.contentRichTextBox.Text.Length - 1;
			while (num2 != num && !"\n\t.,:;!?".Contains(this.contentRichTextBox.Text[num].ToString()))
			{
				num++;
			}
			return num;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00008330 File Offset: 0x00007330
		private void DeleteRememberToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.DeleteSelectedTextHandler != null)
			{
				this.DeleteSelectedTextHandler(true);
			}
		}

		// Token: 0x0400009F RID: 159
		private const int WM_KEYDOWN = 256;

		// Token: 0x040000A0 RID: 160
		private const int WM_KEYUP = 257;

		// Token: 0x040000A1 RID: 161
		private const int WM_SYSKEYDOWN = 260;

		// Token: 0x040000A2 RID: 162
		private const int WM_SYSKEYUP = 261;

		// Token: 0x040000A3 RID: 163
		public DocumentPanel.ClickDelegate ClickHandler;

		// Token: 0x040000A4 RID: 164
		public DocumentPanel.RightClickDelegate RightClickHandler;

		// Token: 0x040000A5 RID: 165
		public DocumentPanel.AddToVietPhraseDelegate AddToVietPhraseHandler;

		// Token: 0x040000A6 RID: 166
		public DocumentPanel.SelectTextDelegate SelectTextHandler;

		// Token: 0x040000A7 RID: 167
		public DocumentPanel.ShiftAndMouseMoveDelegate ShiftAndMouseMoveHandler;

		// Token: 0x040000A8 RID: 168
		public DocumentPanel.ShiftUpDelegate ShiftUpHandler;

		// Token: 0x040000A9 RID: 169
		public DocumentPanel.BaikeingDelegate BaikeingHandler;

		// Token: 0x040000AA RID: 170
		public DocumentPanel.NcikuingDelegate NcikuingHandler;

		// Token: 0x040000AB RID: 171
		public DocumentPanel.CopyToVietDelegate CopyToVietHandler;

		// Token: 0x040000AC RID: 172
		public DocumentPanel.DeleteSelectedTextDelegate DeleteSelectedTextHandler;

		// Token: 0x040000AD RID: 173
		public DocumentPanel.AddToPhienAmDelegate AddToPhienAmHandler;

		// Token: 0x040000AE RID: 174
		private int currentHighlightedTextStartIndex;

		// Token: 0x040000AF RID: 175
		private int currentHighlightedTextLength;

		// Token: 0x040000B0 RID: 176
		private bool tabIsDown;

		// Token: 0x040000B1 RID: 177
		private int lastCharIndexUnderMouseMove = -1;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600006D RID: 109
		public delegate void ClickDelegate(int currentCharIndex);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000071 RID: 113
		public delegate void RightClickDelegate(int currentCharIndex);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000075 RID: 117
		public delegate void AddToVietPhraseDelegate(int type);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000079 RID: 121
		public delegate void SelectTextDelegate();

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600007D RID: 125
		public delegate void ShiftAndMouseMoveDelegate(int charIndexUnderMouse);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000081 RID: 129
		public delegate void ShiftUpDelegate();

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000085 RID: 133
		public delegate void BaikeingDelegate();

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000089 RID: 137
		public delegate void NcikuingDelegate();

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600008D RID: 141
		public delegate void CopyToVietDelegate(string textToCopy);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000091 RID: 145
		public delegate void DeleteSelectedTextDelegate(bool remembered);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000095 RID: 149
		public delegate void AddToPhienAmDelegate();
	}
}

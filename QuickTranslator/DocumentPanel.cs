using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace QuickTranslator
{
    public partial class DocumentPanel : DockContent
    {
        public int CurrentHighlightedTextStartIndex {
            get {
                return currentHighlightedTextStartIndex;
            }
            set {
                currentHighlightedTextStartIndex = value;
            }
        }

        public int CurrentHighlightedTextLength {
            get {
                return currentHighlightedTextLength;
            }
            set {
                currentHighlightedTextLength = value;
            }
        }

        public DocumentPanel()
        {
            InitializeComponent();
            DockHandler.GetPersistStringCallback = new GetPersistStringCallback(GetPersistStringFromText);
        }

        public DocumentPanel(bool textReadOnly)
        {
            InitializeComponent();
            contentRichTextBox.ReadOnly = textReadOnly;
            DockHandler.GetPersistStringCallback = new GetPersistStringCallback(GetPersistStringFromText);
        }

        public string GetPersistStringFromText()
        {
            return Text;
        }

        public string GetSelectedText()
        {
            return contentRichTextBox.SelectedText;
        }

        public bool TextReadOnly {
            get {
                return contentRichTextBox.ReadOnly;
            }
            set {
                contentRichTextBox.ReadOnly = value;
            }
        }

        public string GetTextContent()
        {
            return contentRichTextBox.Text;
        }

        public void SetTextContent(string text)
        {
            contentRichTextBox.Text = text;
        }

        public string GetRtfContent()
        {
            return contentRichTextBox.Rtf;
        }

        public void SetRftContent(string rft)
        {
            contentRichTextBox.Rtf = rft;
        }

        public void AppendText(string text)
        {
            contentRichTextBox.AppendText(text);
        }

        public void AppendTextToCurrentCursor(string text)
        {
            contentRichTextBox.SelectedText = text;
        }

        public string GetTwoCharsBeforeSelectedText()
        {
            if (contentRichTextBox.SelectionStart == 0)
            {
                return "";
            }
            if (contentRichTextBox.SelectionStart == 1)
            {
                return contentRichTextBox.Text[0].ToString();
            }
            return contentRichTextBox.Text.Substring(contentRichTextBox.SelectionStart - 2, 2);
        }

        public string GetTwoCharsAfterSelectedText()
        {
            int num = contentRichTextBox.SelectionStart;
            if (1 < contentRichTextBox.SelectionLength)
            {
                num += contentRichTextBox.SelectionLength - 1;
            }
            if (contentRichTextBox.TextLength - 1 <= num)
            {
                return "";
            }
            if (contentRichTextBox.TextLength - 2 == num)
            {
                return contentRichTextBox.Text[num + 1].ToString();
            }
            return contentRichTextBox.Text.Substring(num + 1, 2);
        }

        public int GetPreviousWordIndex()
        {
            int num = contentRichTextBox.SelectionStart;
            bool flag = false;
            while (1 <= num)
            {
                num--;
                if (contentRichTextBox.Text[num] == ' ' || contentRichTextBox.Text[num] == '.' || contentRichTextBox.Text[num] == ',' || contentRichTextBox.Text[num] == ':' || contentRichTextBox.Text[num] == ';' || contentRichTextBox.Text[num] == '?' || contentRichTextBox.Text[num] == '!' || contentRichTextBox.Text[num] == '\'' || contentRichTextBox.Text[num] == '\n' || contentRichTextBox.Text[num] == '"')
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

        public int GetNextWordIndex()
        {
            int i = contentRichTextBox.SelectionStart;
            bool flag = false;
            while (i <= contentRichTextBox.TextLength - 2)
            {
                i++;
                if (contentRichTextBox.Text[i] == ' ' || contentRichTextBox.Text[i] == '.' || contentRichTextBox.Text[i] == ',' || contentRichTextBox.Text[i] == ':' || contentRichTextBox.Text[i] == ';' || contentRichTextBox.Text[i] == '?' || contentRichTextBox.Text[i] == '!' || contentRichTextBox.Text[i] == '\'' || contentRichTextBox.Text[i] == '\t' || contentRichTextBox.Text[i] == '\n' || contentRichTextBox.Text[i] == '"')
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

        public int GetNextLineIndex()
        {
            int lineFromCharIndex = contentRichTextBox.GetLineFromCharIndex(contentRichTextBox.SelectionStart);
            int lineFromCharIndex2 = contentRichTextBox.GetLineFromCharIndex(contentRichTextBox.TextLength - 1);
            int num = contentRichTextBox.GetFirstCharIndexFromLine((lineFromCharIndex <= lineFromCharIndex2 - 1) ? (lineFromCharIndex + 1) : lineFromCharIndex);
            while (contentRichTextBox.Text[num] == ' ' || contentRichTextBox.Text[num] == '.' || contentRichTextBox.Text[num] == ',' || contentRichTextBox.Text[num] == ':' || contentRichTextBox.Text[num] == ';' || contentRichTextBox.Text[num] == '?' || contentRichTextBox.Text[num] == '!' || contentRichTextBox.Text[num] == '\'' || contentRichTextBox.Text[num] == '\t' || contentRichTextBox.Text[num] == '\n' || contentRichTextBox.Text[num] == '"')
            {
                num++;
                if (num == contentRichTextBox.TextLength)
                {
                    break;
                }
            }
            return num;
        }

        public int GetPreviousLineIndex()
        {
            int lineFromCharIndex = contentRichTextBox.GetLineFromCharIndex(contentRichTextBox.SelectionStart);
            int charIndexFromLine = contentRichTextBox.GetFirstCharIndexFromLine(lineFromCharIndex <= 0 ? 0 : lineFromCharIndex - 1);

            while (contentRichTextBox.Text[charIndexFromLine] == '\n')
            {
                --lineFromCharIndex;
                charIndexFromLine = contentRichTextBox.GetFirstCharIndexFromLine(lineFromCharIndex <= 0 ? 0 : lineFromCharIndex - 1);
                if (charIndexFromLine <= 0)
                    break;
            }

            while (contentRichTextBox.Text[charIndexFromLine] == ' ' || contentRichTextBox.Text[charIndexFromLine] == '.' || contentRichTextBox.Text[charIndexFromLine] == ',' || contentRichTextBox.Text[charIndexFromLine] == ':' || contentRichTextBox.Text[charIndexFromLine] == ';' || contentRichTextBox.Text[charIndexFromLine] == '?' || contentRichTextBox.Text[charIndexFromLine] == '!' || contentRichTextBox.Text[charIndexFromLine] == '\'' || contentRichTextBox.Text[charIndexFromLine] == '\t' || contentRichTextBox.Text[charIndexFromLine] == '\n' || contentRichTextBox.Text[charIndexFromLine] == '"')
            {
                ++charIndexFromLine;
                if (contentRichTextBox.TextLength <= charIndexFromLine)
                    break;
            }

            return charIndexFromLine;
        }

        public int GetCurrentLineIndex()
        {
            return contentRichTextBox.GetLineFromCharIndex(contentRichTextBox.SelectionStart);
        }

        public int GetNextPhysicalLineIndex()
        {
            int selectionStart = contentRichTextBox.SelectionStart;
            while (contentRichTextBox.Text[selectionStart] != '\n')
            {
                ++selectionStart;
                if (contentRichTextBox.TextLength - 1 <= selectionStart)
                    break;
            }
            while (contentRichTextBox.Text[selectionStart] == ' ' || contentRichTextBox.Text[selectionStart] == '.' || contentRichTextBox.Text[selectionStart] == ',' || contentRichTextBox.Text[selectionStart] == ':' || contentRichTextBox.Text[selectionStart] == ';' || contentRichTextBox.Text[selectionStart] == '?' || contentRichTextBox.Text[selectionStart] == '!' || contentRichTextBox.Text[selectionStart] == '\'' || contentRichTextBox.Text[selectionStart] == '\t' || contentRichTextBox.Text[selectionStart] == '\n' || contentRichTextBox.Text[selectionStart] == '"')
            {
                ++selectionStart;
                if (selectionStart == contentRichTextBox.TextLength)
                    break;
            }
            return selectionStart;
        }

        public int GetPreviousPhysicalLineIndex()
        {
            int num = contentRichTextBox.SelectionStart;
            bool flag = false;
            for (; ; )
            {
                num--;
                if (num == 0)
                {
                    break;
                }
                if (contentRichTextBox.Text[num] == '\n' && contentRichTextBox.Text[num - 1] == '\n')
                {
                    num--;
                    if (num <= 0 || flag)
                    {
                        break;
                    }
                    flag = true;
                }
            }
            while (contentRichTextBox.Text[num] == ' ' || contentRichTextBox.Text[num] == '.' || contentRichTextBox.Text[num] == ',' || contentRichTextBox.Text[num] == ':' || contentRichTextBox.Text[num] == ';' || contentRichTextBox.Text[num] == '?' || contentRichTextBox.Text[num] == '!' || contentRichTextBox.Text[num] == '\'' || contentRichTextBox.Text[num] == '\t' || contentRichTextBox.Text[num] == '\n' || contentRichTextBox.Text[num] == '"')
            {
                num++;
                if (num == contentRichTextBox.TextLength)
                {
                    break;
                }
            }
            return num;
        }

        public string GetHighlightText()
        {
            return contentRichTextBox.Text.Substring(currentHighlightedTextStartIndex, currentHighlightedTextLength);
        }

        public void HighlightText(int startIndex, int length)
        {
            HighlightText(startIndex, length, false, true);
        }

        public void HighlightText(int startIndex, int length, bool clearTextSelection, bool scrollToCaret)
        {
            if (IsHidden)
            {
                return;
            }
            SuspendLayout();
            contentRichTextBox.Select(currentHighlightedTextStartIndex, currentHighlightedTextLength);
            contentRichTextBox.SelectionColor = contentRichTextBox.ForeColor;
            contentRichTextBox.Select(startIndex, length);
            contentRichTextBox.SelectionColor = Color.Red;
            currentHighlightedTextStartIndex = startIndex;
            currentHighlightedTextLength = length;
            if (clearTextSelection)
            {
                contentRichTextBox.Select(startIndex, 0);
            }
            if (contentRichTextBox.Height <= contentRichTextBox.GetPositionFromCharIndex(currentHighlightedTextStartIndex).Y + 50 || contentRichTextBox.GetPositionFromCharIndex(currentHighlightedTextStartIndex).Y <= 30)
            {
                contentRichTextBox.ScrollToCaret();
                contentRichTextBox.ScrollLineUp();
                contentRichTextBox.ScrollLineUp();
            }
            ResumeLayout();
        }

        public void SelectText(int startIndex, int length)
        {
            SuspendLayout();
            contentRichTextBox.Select(startIndex, length);
            if (contentRichTextBox.Height <= contentRichTextBox.GetPositionFromCharIndex(currentHighlightedTextStartIndex).Y + 50 || contentRichTextBox.GetPositionFromCharIndex(currentHighlightedTextStartIndex).Y <= 50)
            {
                contentRichTextBox.ScrollToCaret();
                contentRichTextBox.ScrollLineUp();
                contentRichTextBox.ScrollLineUp();
            }
            ResumeLayout();
        }

        public int GetSelectionStart()
        {
            return contentRichTextBox.SelectionStart;
        }

        public int GetSelectionLength()
        {
            return contentRichTextBox.SelectionLength;
        }

        public void SetFontSize(float size)
        {
            contentRichTextBox.SuspendLayout();
            contentRichTextBox.Font = new Font(contentRichTextBox.Font.FontFamily, size);
            contentRichTextBox.ResumeLayout();
        }

        public void ScrollToTop()
        {
            contentRichTextBox.SelectionStart = 0;
            contentRichTextBox.ScrollToCaret();
        }

        public void ScrollToBottom()
        {
            contentRichTextBox.SelectionStart = contentRichTextBox.TextLength;
            contentRichTextBox.ScrollToCaret();
        }

        public void FocusInRichTextBox()
        {
            contentRichTextBox.Focus();
        }

        private void ContentRichTextBoxMouseUp(object sender, MouseEventArgs e)
        {
            int num = contentRichTextBox.GetCharIndexFromPosition(e.Location);
            char c = contentRichTextBox.GetCharFromPosition(e.Location);
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
                    c = contentRichTextBox.Text[num];
                }
                else
                {
                    if (num > contentRichTextBox.TextLength - 1 || c != '\t')
                    {
                        break;
                    }
                    num++;
                    c = contentRichTextBox.Text[num];
                }
                num3++;
            }
            if (0 < contentRichTextBox.SelectionLength)
            {
                SelectTextHandler?.Invoke();
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                if (ClickHandler != null)
                {
                    ClickHandler(num);
                    return;
                }
            }
            else
            {
                RightClickHandler?.Invoke(num);
            }
        }

        public void ScrollToASpecificLogicalLine(int logicalLine)
        {
            contentRichTextBox.SelectionStart = Math.Max(contentRichTextBox.GetFirstCharIndexFromLine(logicalLine), 0);
            contentRichTextBox.SelectionLength = 0;
            contentRichTextBox.ScrollToCaret();
        }

        public void ScrollToASpecificPhysicalLine(int physicalLine)
        {
            int num = -1;
            string text = contentRichTextBox.Text;
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
            if (contentRichTextBox.TextLength - 1 < num)
            {
                num = (contentRichTextBox.TextLength == 0) ? 0 : (contentRichTextBox.TextLength - 1);
            }
            contentRichTextBox.SelectionStart = num;
            contentRichTextBox.SelectionLength = 0;
            contentRichTextBox.ScrollToCaret();
        }

        private void MarkForReviewToolStripMenuItemClick(object sender, EventArgs e)
        {
            contentRichTextBox.SelectionColor = Color.Red;
        }

        public void EnableCommentContextMenuStrip()
        {
            contentRichTextBox.ContextMenuStrip = commentContextMenuStrip;
        }

        public void EnableAddToVietPhraseContextMenuStrip()
        {
            contentRichTextBox.ContextMenuStrip = addToVietPhraseContextMenuStrip;
        }

        private void ClearNoteToolStripMenuItemClick(object sender, EventArgs e)
        {
            contentRichTextBox.SelectionColor = Color.Black;
        }

        private void AddToVietPhraseToolStripMenuItemClick(object sender, EventArgs e)
        {
            AddToVietPhraseHandler?.Invoke(0);
        }

        private void AddToNameToolStripMenuItemClick(object sender, EventArgs e)
        {
            AddToVietPhraseHandler?.Invoke(1);
        }

        private void AddToVietPhraseContextMenuStripOpening(object sender, CancelEventArgs e)
        {
            if (contentRichTextBox.SelectionLength == 0)
            {
                e.Cancel = true;
            }
        }

        private void BaikeingToolStripMenuItemClick(object sender, EventArgs e)
        {
            BaikeingHandler?.Invoke();
        }

        private void CopyToVietToolStripMenuItemClick(object sender, EventArgs e)
        {
            CopyToVietHandler?.Invoke(contentRichTextBox.SelectedText);
        }

        private void ContentRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (contentRichTextBox.ReadOnly)
            {
                return;
            }
            if (('A' <= e.KeyChar && e.KeyChar <= 'Z') || ('a' <= e.KeyChar && e.KeyChar <= 'z'))
            {
                return;
            }
            int selectionStart = contentRichTextBox.SelectionStart;
            if (selectionStart == 0)
            {
                return;
            }
            int num = selectionStart - 1;
            while (0 <= num && contentRichTextBox.Text[num] != '\n' && contentRichTextBox.Text[num] != ' ' && contentRichTextBox.Text[num] != '\'' && contentRichTextBox.Text[num] != '[' && contentRichTextBox.Text[num] != ']' && contentRichTextBox.Text[num] != '(' && contentRichTextBox.Text[num] != ')' && contentRichTextBox.Text[num] != '*' && contentRichTextBox.Text[num] != '"')
            {
                num--;
            }
            num++;
            int num2 = selectionStart - 1;
            if (num2 <= num)
            {
                return;
            }
            string text = contentRichTextBox.Text.Substring(num, num2 - num + 1);
            string textToReplace = GetTextToReplace(text);
            if (string.IsNullOrEmpty(textToReplace))
            {
                return;
            }
            contentRichTextBox.Select(num, num2 - num + 1);
            contentRichTextBox.SelectedText = textToReplace;
            contentRichTextBox.Select(selectionStart + textToReplace.Length - text.Length, 0);
        }

        private string GetTextToReplace(string textToLookup)
        {
            return Shortcuts.GetValueFromKey(textToLookup);
        }

        private void InsertBlankLinesToolStripMenuItemClick(object sender, EventArgs e)
        {
            string text = contentRichTextBox.Rtf;
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
            contentRichTextBox.Rtf = text2.Replace("\\par\r\n", "\\par\r\n\\par\r\n");
            ScrollToBottom();
        }

        public void SetBackColor(Color color)
        {
            contentRichTextBox.BackColor = color;
        }

        public void SetForeColor(Color color)
        {
            contentRichTextBox.ForeColor = color;
        }

        public void SetFont(Font font)
        {
            contentRichTextBox.Font = font;
        }

        public void AllowDeletingSelectedText()
        {
            deleteSelectedTextToolStripMenuItem.Enabled = true;
            deleteSelectedTextToolStripMenuItem.Visible = true;
            deleteRememberToolStripMenuItem.Enabled = true;
            deleteRememberToolStripMenuItem.Visible = true;
        }

        private void DeleteSelectedTextToolStripMenuItemClick(object sender, EventArgs e)
        {
            DeleteSelectedTextHandler?.Invoke(false);
        }

        public void DeleteSelectedText()
        {
            bool readOnly = contentRichTextBox.ReadOnly;
            contentRichTextBox.ReadOnly = false;
            contentRichTextBox.SelectedText = "";
            contentRichTextBox.ReadOnly = readOnly;
        }

        private void CopyToClipboardToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(string.IsNullOrEmpty(contentRichTextBox.SelectedText) ? string.Empty : contentRichTextBox.SelectedText);
            }
            catch
            {
            }
        }

        private void UpdatePhienAmToolStripMenuItemClick(object sender, EventArgs e)
        {
            AddToPhienAmHandler?.Invoke();
        }

        private void NcikuToolStripMenuItemClick(object sender, EventArgs e)
        {
            NcikuingHandler?.Invoke();
        }

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

        public void ReplaceHighlightedText(string text)
        {
            contentRichTextBox.SelectionStart = currentHighlightedTextStartIndex;
            contentRichTextBox.SelectionLength = currentHighlightedTextLength;
            contentRichTextBox.SelectedText = text;
            currentHighlightedTextLength = text.Length;
        }

        private void UpdateNamePhuToolStripMenuItemClick(object sender, EventArgs e)
        {
            AddToVietPhraseHandler?.Invoke(2);
        }

        protected override bool ProcessKeyPreview(ref Message message)
        {
            if (!"VietPhrase một nghĩa".Equals(Text))
            {
                return base.ProcessKeyPreview(ref message);
            }
            Keys keys = (Keys)(int)message.WParam;
            if (message.Msg == 256 && keys == Keys.Tab)
            {
                if (tabIsDown)
                {
                    return base.ProcessKeyPreview(ref message);
                }
                if (currentHighlightedTextStartIndex < 0 || currentHighlightedTextLength <= 0 || contentRichTextBox.Text[currentHighlightedTextStartIndex] == '\n')
                {
                    return base.ProcessKeyPreview(ref message);
                }
                contentRichTextBox.Cursor = Cursors.SizeAll;
                tabIsDown = true;
            }
            else if (message.Msg == 257 && keys == Keys.Tab)
            {
                if (tabIsDown)
                {
                    tabIsDown = false;
                    if (ShiftUpHandler != null && contentRichTextBox.SelectionLength == 0)
                    {
                        ShiftUpHandler();
                    }
                }
                contentRichTextBox.Cursor = Cursors.IBeam;
                lastCharIndexUnderMouseMove = -1;
            }
            return base.ProcessKeyPreview(ref message);
        }

        private void ContentRichTextBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (tabIsDown)
            {
                int charIndexFromPosition = contentRichTextBox.GetCharIndexFromPosition(e.Location);
                if (lastCharIndexUnderMouseMove == charIndexFromPosition)
                {
                    return;
                }
                lastCharIndexUnderMouseMove = charIndexFromPosition;
                if (currentHighlightedTextStartIndex <= charIndexFromPosition && charIndexFromPosition <= currentHighlightedTextStartIndex + currentHighlightedTextLength - 1)
                {
                    contentRichTextBox.SelectionStart = currentHighlightedTextStartIndex;
                    contentRichTextBox.SelectionLength = 0;
                    return;
                }
                if (charIndexFromPosition < GetCurrentBlockStartIndex() || GetCurrentBlockEndIndex() < charIndexFromPosition)
                {
                    contentRichTextBox.SelectionStart = currentHighlightedTextStartIndex;
                    contentRichTextBox.SelectionLength = 0;
                    return;
                }
                ShiftAndMouseMoveHandler?.Invoke(charIndexFromPosition);
            }
        }

        public int GetCurrentBlockStartIndex()
        {
            int num = currentHighlightedTextStartIndex;
            while (num != 0 && contentRichTextBox.Text[num - 1] != '\t' && contentRichTextBox.Text[num - 1] != '\n' && (contentRichTextBox.Text[num - 1] != ' ' || !".,:;!?\"".Contains(contentRichTextBox.Text[num - 2].ToString())))
            {
                num--;
            }
            return num;
        }

        public int GetCurrentBlockEndIndex()
        {
            int num = currentHighlightedTextStartIndex + currentHighlightedTextLength - 1;
            int num2 = contentRichTextBox.Text.Length - 1;
            while (num2 != num && !"\n\t.,:;!?".Contains(contentRichTextBox.Text[num].ToString()))
            {
                num++;
            }
            return num;
        }

        private void DeleteRememberToolStripMenuItemClick(object sender, EventArgs e)
        {
            DeleteSelectedTextHandler?.Invoke(true);
        }

        public ClickDelegate ClickHandler;

        public RightClickDelegate RightClickHandler;

        public AddToVietPhraseDelegate AddToVietPhraseHandler;

        public SelectTextDelegate SelectTextHandler;

        public ShiftAndMouseMoveDelegate ShiftAndMouseMoveHandler;

        public ShiftUpDelegate ShiftUpHandler;

        public BaikeingDelegate BaikeingHandler;

        public NcikuingDelegate NcikuingHandler;

        public CopyToVietDelegate CopyToVietHandler;

        public DeleteSelectedTextDelegate DeleteSelectedTextHandler;

        public AddToPhienAmDelegate AddToPhienAmHandler;

        private int currentHighlightedTextStartIndex;

        private int currentHighlightedTextLength;

        private bool tabIsDown;

        private int lastCharIndexUnderMouseMove = -1;

        public delegate void ClickDelegate(int currentCharIndex);

        public delegate void RightClickDelegate(int currentCharIndex);

        public delegate void AddToVietPhraseDelegate(int type);

        public delegate void SelectTextDelegate();

        public delegate void ShiftAndMouseMoveDelegate(int charIndexUnderMouse);

        public delegate void ShiftUpDelegate();

        public delegate void BaikeingDelegate();

        public delegate void NcikuingDelegate();

        public delegate void CopyToVietDelegate(string textToCopy);

        public delegate void DeleteSelectedTextDelegate(bool remembered);

        public delegate void AddToPhienAmDelegate();
    }
}

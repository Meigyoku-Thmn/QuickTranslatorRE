using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuickTranslator
{
    public partial class FindAndReplaceForm : Form
    {
        public FindAndReplaceForm(RichTextBox richTextBox)
        {
            InitializeComponent();
            this.richTextBox = richTextBox;
            findTextBox.Text = richTextBox.SelectedText;
        }

        private void FindTextBoxTextChanged(object sender, EventArgs e)
        {
            bool enabled = 0 < findTextBox.Text.Length;
            findNextButton.Enabled = enabled;
            replaceButton.Enabled = enabled;
            replaceAllButton.Enabled = enabled;
            lastFoundIndex = -1;
        }

        private void FindNextButtonClick(object sender, EventArgs e)
        {
            Find();
        }

        private void Find()
        {
            RichTextBoxFinds richTextBoxFinds = RichTextBoxFinds.None;
            if (matchCaseCheckBox.Checked)
            {
                richTextBoxFinds |= RichTextBoxFinds.MatchCase;
            }
            if (matchWholeWordCheckBox.Checked)
            {
                richTextBoxFinds |= RichTextBoxFinds.WholeWord;
            }
            if (upRadioButton.Checked)
            {
                richTextBoxFinds |= RichTextBoxFinds.Reverse;
            }
            if (upRadioButton.Checked)
            {
                lastFoundIndex = richTextBox.Find(findTextBox.Text, 0, richTextBox.SelectionStart, richTextBoxFinds);
            }
            else
            {
                lastFoundIndex = richTextBox.Find(findTextBox.Text, richTextBox.SelectionStart + richTextBox.SelectionLength, richTextBoxFinds);
            }
            if (0 <= lastFoundIndex)
            {
                richTextBox.SelectionStart = lastFoundIndex;
                richTextBox.SelectionLength = findTextBox.Text.Length;
            }
            replaceButton.Enabled = (0 <= lastFoundIndex);
        }

        private void ReplaceButtonClick(object sender, EventArgs e)
        {
            if (richTextBox.SelectionStart == lastFoundIndex)
            {
                richTextBox.SelectedText = replaceWithTextBox.Text;
            }
            Find();
        }

        private void ReplaceAllButtonClick(object sender, EventArgs e)
        {
            richTextBox.Text = richTextBox.Text.Replace(findTextBox.Text, replaceWithTextBox.Text);
            lastFoundIndex = -1;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private RichTextBox richTextBox;

        private int lastFoundIndex = -1;
    }
}

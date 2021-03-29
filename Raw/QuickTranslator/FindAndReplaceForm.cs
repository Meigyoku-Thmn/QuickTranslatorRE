using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuickTranslator
{
	// Token: 0x02000011 RID: 17
	public partial class FindAndReplaceForm : Form
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00009846 File Offset: 0x00008846
		public FindAndReplaceForm(RichTextBox richTextBox)
		{
			this.InitializeComponent();
			this.richTextBox = richTextBox;
			this.findTextBox.Text = richTextBox.SelectedText;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009874 File Offset: 0x00008874
		private void FindTextBoxTextChanged(object sender, EventArgs e)
		{
			bool enabled = 0 < this.findTextBox.Text.Length;
			this.findNextButton.Enabled = enabled;
			this.replaceButton.Enabled = enabled;
			this.replaceAllButton.Enabled = enabled;
			this.lastFoundIndex = -1;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000098C0 File Offset: 0x000088C0
		private void FindNextButtonClick(object sender, EventArgs e)
		{
			this.Find();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000098C8 File Offset: 0x000088C8
		private void Find()
		{
			RichTextBoxFinds richTextBoxFinds = RichTextBoxFinds.None;
			if (this.matchCaseCheckBox.Checked)
			{
				richTextBoxFinds |= RichTextBoxFinds.MatchCase;
			}
			if (this.matchWholeWordCheckBox.Checked)
			{
				richTextBoxFinds |= RichTextBoxFinds.WholeWord;
			}
			if (this.upRadioButton.Checked)
			{
				richTextBoxFinds |= RichTextBoxFinds.Reverse;
			}
			if (this.upRadioButton.Checked)
			{
				this.lastFoundIndex = this.richTextBox.Find(this.findTextBox.Text, 0, this.richTextBox.SelectionStart, richTextBoxFinds);
			}
			else
			{
				this.lastFoundIndex = this.richTextBox.Find(this.findTextBox.Text, this.richTextBox.SelectionStart + this.richTextBox.SelectionLength, richTextBoxFinds);
			}
			if (0 <= this.lastFoundIndex)
			{
				this.richTextBox.SelectionStart = this.lastFoundIndex;
				this.richTextBox.SelectionLength = this.findTextBox.Text.Length;
			}
			this.replaceButton.Enabled = (0 <= this.lastFoundIndex);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000099C3 File Offset: 0x000089C3
		private void ReplaceButtonClick(object sender, EventArgs e)
		{
			if (this.richTextBox.SelectionStart == this.lastFoundIndex)
			{
				this.richTextBox.SelectedText = this.replaceWithTextBox.Text;
			}
			this.Find();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000099F4 File Offset: 0x000089F4
		private void ReplaceAllButtonClick(object sender, EventArgs e)
		{
			this.richTextBox.Text = this.richTextBox.Text.Replace(this.findTextBox.Text, this.replaceWithTextBox.Text);
			this.lastFoundIndex = -1;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00009A2E File Offset: 0x00008A2E
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		// Token: 0x040000DB RID: 219
		private RichTextBox richTextBox;

		// Token: 0x040000DC RID: 220
		private int lastFoundIndex = -1;
	}
}

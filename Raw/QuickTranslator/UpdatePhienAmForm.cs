using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TranslatorEngine;

namespace QuickTranslator
{
	// Token: 0x02000019 RID: 25
	public partial class UpdatePhienAmForm : Form
	{
		// Token: 0x06000148 RID: 328 RVA: 0x000119A2 File Offset: 0x000109A2
		public UpdatePhienAmForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000119C8 File Offset: 0x000109C8
		public UpdatePhienAmForm(string chineseToLookup)
		{
			this.InitializeComponent();
			this.chineseTextBox.Text = chineseToLookup.Trim(new char[]
			{
				' ',
				'.',
				':',
				';',
				'?',
				'!',
				'"',
				'\'',
				',',
				'\n',
				'\t'
			});
			this.entryCountLabel.Text = TranslatorEngine.GetPhienAmDictionaryCount().ToString();
			base.ActiveControl = this.phienAmTextBox;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00011A28 File Offset: 0x00010A28
		private void ChineseTextBoxTextChanged(object sender, EventArgs e)
		{
			this.updateButton.Enabled = !string.IsNullOrEmpty(this.chineseTextBox.Text.Trim());
			this.deleteButton.Enabled = !string.IsNullOrEmpty(this.chineseTextBox.Text.Trim());
			if (string.IsNullOrEmpty(this.chineseTextBox.Text.Trim()))
			{
				this.phienAmTextBox.Text = "";
				return;
			}
			CharRange[] array;
			this.phienAmTextBox.Text = TranslatorEngine.ChineseToHanViet(this.chineseTextBox.Text, out array).Trim();
			if (1 != this.chineseTextBox.Text.Length)
			{
				this.deleteButton.Enabled = false;
				this.updateButton.Enabled = false;
				return;
			}
			bool flag = TranslatorEngine.ExistInPhienAmDictionary(this.chineseTextBox.Text);
			this.deleteButton.Enabled = flag;
			this.updateButton.Enabled = true;
			this.updateButton.Text = (flag ? "Update" : "Add");
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00011B34 File Offset: 0x00010B34
		private void UpdateButtonClick(object sender, EventArgs e)
		{
			if (this.chineseTextBox.Text.Length != 1)
			{
				return;
			}
			if (string.IsNullOrEmpty(this.phienAmTextBox.Text))
			{
				return;
			}
			TranslatorEngine.UpdatePhienAmDictionary(this.chineseTextBox.Text, this.phienAmTextBox.Text, this.sortingCheckBox.Checked);
			base.Close();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00011B94 File Offset: 0x00010B94
		private void DeleteButtonClick(object sender, EventArgs e)
		{
			TranslatorEngine.DeleteKeyFromPhienAmDictionary(this.chineseTextBox.Text, this.sortingCheckBox.Checked);
			base.Close();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00011BB7 File Offset: 0x00010BB7
		private void CancelButtonClick(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}

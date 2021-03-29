using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QuickTranslator
{
	// Token: 0x02000014 RID: 20
	public partial class PostTTVForm : Form
	{
		// Token: 0x06000119 RID: 281 RVA: 0x000100C0 File Offset: 0x0000F0C0
		public PostTTVForm(string viet, string hanViet, string vietPhrase, string trung, DateTime editingStartDateTime)
		{
			this.InitializeComponent();
			this.postToTTVTemplate = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "PostToTTV.config")).Trim();
			this.loadSettings();
			this.viet = viet;
			this.hanViet = hanViet;
			this.vietPhrase = vietPhrase;
			this.trung = trung;
			this.editingStartDateTime = editingStartDateTime;
			string text = trung.Substring(0, (trung.IndexOf('\n') < 0) ? 0 : trung.IndexOf('\n')).Trim();
			if (text.StartsWith("第") && (text.Contains("章") || text.Contains("节")))
			{
				string text2 = vietPhrase.Substring(0, (vietPhrase.IndexOf('\n') < 0) ? 0 : vietPhrase.IndexOf('\n'));
				int num = text2.IndexOfAny(":-".ToCharArray());
				if (0 < num)
				{
					int num2 = num;
					while (num2 < text2.Length && (text2[num2] == ' ' || text2[num2] == ':' || text2[num2] == '-'))
					{
						num2++;
					}
					if (num < num2)
					{
						this.vietPhrase = vietPhrase.Substring(0, num2) + vietPhrase[num2].ToString().ToUpper() + vietPhrase.Substring(num2 + 1, vietPhrase.Length - num2 - 1);
						this.lineTwoTextBox.Text = this.vietPhrase.Substring(0, vietPhrase.IndexOf('\n')).Trim();
					}
				}
			}
			this.LineOneTextBoxTextChanged(null, null);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00010253 File Offset: 0x0000F253
		private void HuyButtonClick(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0001025C File Offset: 0x0000F25C
		private void LineOneTextBoxTextChanged(object sender, EventArgs e)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("[FONT=\"Palatino Linotype\"]");
			string text = this.postToTTVTemplate;
			text = text.Replace("$dong1$", this.lineOneTextBox.Text);
			text = text.Replace("$dong2$", this.lineTwoTextBox.Text);
			text = text.Replace("$dong3$", string.IsNullOrEmpty(this.lineThreeTextBox.Text) ? "" : ("Tác giả: " + this.lineThreeTextBox.Text));
			text = text.Replace("$dong4$", this.lineFourTextBox.Text);
			string text2 = DateTime.Now.Subtract(this.editingStartDateTime).ToString().Replace(":", " : ");
			if (8 < text2.Length)
			{
				text2 = text2.Substring(0, text2.Length - 8);
			}
			text = text.Replace("$thoiGian$", text2);
			stringBuilder.AppendLine(text).AppendLine("");
			if (this.vietCheckBox.Checked)
			{
				stringBuilder.Append("[SPOILER=\"              Việt             \"]").AppendLine(this.viet).AppendLine("[/SPOILER]");
			}
			if (this.vietPhraseOneMeaningCheckBox.Checked)
			{
				stringBuilder.Append("[SPOILER=\"       VietPhrase       \"]").AppendLine(this.vietPhrase).AppendLine("[/SPOILER]");
			}
			if (this.hanVietCheckBox.Checked)
			{
				stringBuilder.Append("[SPOILER=\"          Hán Việt        \"]").AppendLine(this.hanViet).AppendLine("[/SPOILER]");
			}
			if (this.trungCheckBox.Checked)
			{
				stringBuilder.Append("[SPOILER=\"            Trung           \"][CODE]").AppendLine(this.trung).AppendLine("[/CODE][/SPOILER]");
			}
			if (!string.IsNullOrEmpty(this.thaoLuanTextBox.Text))
			{
				stringBuilder.Append("[COLOR=\"#F5F5FF\"]...[/COLOR]Thảo luận: [URL=\"").Append(this.thaoLuanTextBox.Text).AppendLine("\"]tại đây![/URL]");
			}
			stringBuilder.Append("[/FONT]");
			this.postContentRichTextBox.Text = stringBuilder.ToString();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00010478 File Offset: 0x0000F478
		private void CopyToClipboardButtonClick(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetDataObject(this.postContentRichTextBox.Text, true, 50, 100);
			}
			catch (ExternalException)
			{
			}
			this.saveSettings();
			base.Close();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000104BC File Offset: 0x0000F4BC
		private void loadSettings()
		{
			this.lineOneTextBox.Text = PostTTVFormSettings.Default.line1;
			this.lineTwoTextBox.Text = PostTTVFormSettings.Default.line2;
			this.lineThreeTextBox.Text = PostTTVFormSettings.Default.line3;
			this.lineFourTextBox.Text = PostTTVFormSettings.Default.line4;
			this.vietCheckBox.Checked = PostTTVFormSettings.Default.spoilerViet;
			this.vietPhraseOneMeaningCheckBox.Checked = PostTTVFormSettings.Default.spoilerVietPhraseOneMeaning;
			this.hanVietCheckBox.Checked = PostTTVFormSettings.Default.spoilerHanViet;
			this.trungCheckBox.Checked = PostTTVFormSettings.Default.spoilerTrung;
			this.thaoLuanTextBox.Text = PostTTVFormSettings.Default.discussionUrl;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00010588 File Offset: 0x0000F588
		private void saveSettings()
		{
			PostTTVFormSettings.Default.line1 = this.lineOneTextBox.Text;
			PostTTVFormSettings.Default.line2 = this.lineTwoTextBox.Text;
			PostTTVFormSettings.Default.line3 = this.lineThreeTextBox.Text;
			PostTTVFormSettings.Default.line4 = this.lineFourTextBox.Text;
			PostTTVFormSettings.Default.spoilerViet = this.vietCheckBox.Checked;
			PostTTVFormSettings.Default.spoilerVietPhraseOneMeaning = this.vietPhraseOneMeaningCheckBox.Checked;
			PostTTVFormSettings.Default.spoilerHanViet = this.hanVietCheckBox.Checked;
			PostTTVFormSettings.Default.spoilerTrung = this.trungCheckBox.Checked;
			PostTTVFormSettings.Default.discussionUrl = this.thaoLuanTextBox.Text;
			PostTTVFormSettings.Default.Save();
		}

		// Token: 0x04000135 RID: 309
		private string viet;

		// Token: 0x04000136 RID: 310
		private string hanViet;

		// Token: 0x04000137 RID: 311
		private string vietPhrase;

		// Token: 0x04000138 RID: 312
		private string trung;

		// Token: 0x04000139 RID: 313
		private string postToTTVTemplate;

		// Token: 0x0400013A RID: 314
		private DateTime editingStartDateTime;
	}
}

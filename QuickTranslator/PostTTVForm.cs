using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TranslatorEngine;

namespace QuickTranslator
{
    public partial class PostTTVForm : Form
    {
        public PostTTVForm(string viet, string hanViet, string vietPhrase, string trung, DateTime editingStartDateTime)
        {
            InitializeComponent();
            postToTTVTemplate = File.ReadAllText(Path.Combine(Constants.ConfigsDir, "PostToTTV.config")).Trim();
            LoadSettings();
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
                        lineTwoTextBox.Text = this.vietPhrase.Substring(0, vietPhrase.IndexOf('\n')).Trim();
                    }
                }
            }
            LineOneTextBoxTextChanged(null, null);
        }

        private void HuyButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void LineOneTextBoxTextChanged(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[FONT=\"Palatino Linotype\"]");
            string text = postToTTVTemplate;
            text = text.Replace("$dong1$", lineOneTextBox.Text);
            text = text.Replace("$dong2$", lineTwoTextBox.Text);
            text = text.Replace("$dong3$", string.IsNullOrEmpty(lineThreeTextBox.Text) ? "" : ("Tác giả: " + lineThreeTextBox.Text));
            text = text.Replace("$dong4$", lineFourTextBox.Text);
            string text2 = DateTime.Now.Subtract(editingStartDateTime).ToString().Replace(":", " : ");
            if (8 < text2.Length)
            {
                text2 = text2.Substring(0, text2.Length - 8);
            }
            text = text.Replace("$thoiGian$", text2);
            stringBuilder.AppendLine(text).AppendLine("");
            if (vietCheckBox.Checked)
            {
                stringBuilder.Append("[SPOILER=\"              Việt             \"]").AppendLine(viet).AppendLine("[/SPOILER]");
            }
            if (vietPhraseOneMeaningCheckBox.Checked)
            {
                stringBuilder.Append("[SPOILER=\"       VietPhrase       \"]").AppendLine(vietPhrase).AppendLine("[/SPOILER]");
            }
            if (hanVietCheckBox.Checked)
            {
                stringBuilder.Append("[SPOILER=\"          Hán Việt        \"]").AppendLine(hanViet).AppendLine("[/SPOILER]");
            }
            if (trungCheckBox.Checked)
            {
                stringBuilder.Append("[SPOILER=\"            Trung           \"][CODE]").AppendLine(trung).AppendLine("[/CODE][/SPOILER]");
            }
            if (!string.IsNullOrEmpty(thaoLuanTextBox.Text))
            {
                stringBuilder.Append("[COLOR=\"#F5F5FF\"]...[/COLOR]Thảo luận: [URL=\"").Append(thaoLuanTextBox.Text).AppendLine("\"]tại đây![/URL]");
            }
            stringBuilder.Append("[/FONT]");
            postContentRichTextBox.Text = stringBuilder.ToString();
        }

        private void CopyToClipboardButtonClick(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(postContentRichTextBox.Text, true, 50, 100);
            }
            catch (ExternalException)
            {
            }
            SaveSettings();
            Close();
        }

        private void LoadSettings()
        {
            lineOneTextBox.Text = PostTTVFormSettings.Default.line1;
            lineTwoTextBox.Text = PostTTVFormSettings.Default.line2;
            lineThreeTextBox.Text = PostTTVFormSettings.Default.line3;
            lineFourTextBox.Text = PostTTVFormSettings.Default.line4;
            vietCheckBox.Checked = PostTTVFormSettings.Default.spoilerViet;
            vietPhraseOneMeaningCheckBox.Checked = PostTTVFormSettings.Default.spoilerVietPhraseOneMeaning;
            hanVietCheckBox.Checked = PostTTVFormSettings.Default.spoilerHanViet;
            trungCheckBox.Checked = PostTTVFormSettings.Default.spoilerTrung;
            thaoLuanTextBox.Text = PostTTVFormSettings.Default.discussionUrl;
        }

        private void SaveSettings()
        {
            PostTTVFormSettings.Default.line1 = lineOneTextBox.Text;
            PostTTVFormSettings.Default.line2 = lineTwoTextBox.Text;
            PostTTVFormSettings.Default.line3 = lineThreeTextBox.Text;
            PostTTVFormSettings.Default.line4 = lineFourTextBox.Text;
            PostTTVFormSettings.Default.spoilerViet = vietCheckBox.Checked;
            PostTTVFormSettings.Default.spoilerVietPhraseOneMeaning = vietPhraseOneMeaningCheckBox.Checked;
            PostTTVFormSettings.Default.spoilerHanViet = hanVietCheckBox.Checked;
            PostTTVFormSettings.Default.spoilerTrung = trungCheckBox.Checked;
            PostTTVFormSettings.Default.discussionUrl = thaoLuanTextBox.Text;
            PostTTVFormSettings.Default.Save();
        }

        private string viet;

        private string hanViet;

        private string vietPhrase;

        private string trung;

        private string postToTTVTemplate;

        private DateTime editingStartDateTime;
    }
}

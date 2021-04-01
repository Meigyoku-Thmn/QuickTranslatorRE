using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using QuickTranslatorCore;

using static QuickTranslatorCore.TranslationEngine;

namespace QuickTranslator
{
    public partial class UpdateVietPhraseForm : Form
    {
        public UpdateVietPhraseForm()
        {
            InitializeComponent();
        }

        public UpdateVietPhraseForm(string chineseToLookup, int type)
        {
            InitializeComponent();
            chineseTextBox.Text = chineseToLookup.Trim(new char[]
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
            this.type = type;
            vietPhraseLabel.Text = (type == 0) ? "VietPhrase:" : "Name:";
            Text = (type == 0) ? "Update VietPhrase" : ((type == 1) ? "Update Name (chính)" : "Update Name (phụ)");
            entryCountLabel.Text = ((type == 0) ? GetVietPhraseDictCount() : GetNameDictCount(type == 1)).ToString("0,0") ?? "";
        }

        private void ChineseTextBoxTextChanged(object sender, EventArgs e)
        {
            updateButton.Enabled = chineseTextBox.Text.Trim() != "";
            deleteButton.Enabled = chineseTextBox.Text.Trim() != "";
            existInBaikeLabel.Text = "Đang kiểm tra...";
            existInBaikeLabel.ForeColor = SystemColors.ControlText;
            surfBaikeLinkLabel.Visible = false;
            if (chineseTextBox.Text.Trim() == "")
            {
                hanVietRichTextBox.Text = "";
                vietPhraseRichTextBox.Text = "";
                CheckBaikeInNewThread(chineseTextBox.Text.Trim());
                return;
            }

            hanVietRichTextBox.Text = ChineseToHanViet(chineseTextBox.Text, out _).Trim();
            string text = (type == 0) ? GetVietPhrase(chineseTextBox.Text) : GetName(chineseTextBox.Text, type == 1);
            vietPhraseRichTextBox.Text = text ?? ((type == 0) ? hanVietRichTextBox.Text : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(hanVietRichTextBox.Text));
            deleteButton.Enabled = text != null;
            updateButton.Text = (text != null) ? "Update" : "Add";
            updatedByLabel.Text = (type == 0) ? GetVietPhraseLogRecord(chineseTextBox.Text) : GetNameLogRecord(chineseTextBox.Text, type == 1);
            CheckBaikeInNewThread(chineseTextBox.Text.Trim());
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (type == 0)
            {
                DeleteVietPhrase(chineseTextBox.Text, sortingCheckBox.Checked);
            }
            else
            {
                DeleteKeyFromNameDict(chineseTextBox.Text, sortingCheckBox.Checked, type == 1);
            }
            CompressDictionaryHistory();
            Close();
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            if (chineseTextBox.Text.Trim() == "")
            {
                return;
            }
            if (type == 0)
            {
                UpdateVietPhraseDict(chineseTextBox.Text, vietPhraseRichTextBox.Text, sortingCheckBox.Checked);
            }
            else
            {
                UpdateNameDict(chineseTextBox.Text, vietPhraseRichTextBox.Text, sortingCheckBox.Checked, type == 1);
            }
            CompressDictionaryHistory();
            Close();
        }

        private void CompressDictionaryHistory()
        {
            if (compressDictionaryHistoryCheckBox.Checked)
            {
                if (type == 0)
                {
                    CompressVietPhraseOnlyLog();
                    return;
                }
                CompressNameOnlyDictLog(type == 1);
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void VietPhraseRichTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
            }
        }

        private void UpdateVietPhraseFormLoad(object sender, EventArgs e)
        {
            ChineseTextBoxTextChanged(null, null);
            vietPhraseRichTextBox.SelectAll();
            ActiveControl = vietPhraseRichTextBox;
        }

        private void CapitalizeAllLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vietPhraseRichTextBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vietPhraseRichTextBox.Text);
            vietPhraseRichTextBox.SelectAll();
            vietPhraseRichTextBox.Focus();
        }

        private void Capitalize1WordLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vietPhraseRichTextBox.Text = CapitalizeWords(vietPhraseRichTextBox.Text, 1);
            vietPhraseRichTextBox.SelectAll();
            vietPhraseRichTextBox.Focus();
        }

        private string CapitalizeWords(string originalText, int numberOfWordsToBeCapitalized)
        {
            if (string.IsNullOrEmpty(originalText))
            {
                return string.Empty;
            }
            string[] array = originalText.Split(" ".ToCharArray(), numberOfWordsToBeCapitalized + 1);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (i < numberOfWordsToBeCapitalized)
                {
                    stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(array[i]));
                }
                else
                {
                    stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ToLower(array[i]));
                }
                stringBuilder.Append(" ");
            }
            return stringBuilder.ToString().Trim();
        }

        private void Capitalize2WordsLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vietPhraseRichTextBox.Text = CapitalizeWords(vietPhraseRichTextBox.Text, 2);
            vietPhraseRichTextBox.SelectAll();
            vietPhraseRichTextBox.Focus();
        }

        private void Capitalize3WordsLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vietPhraseRichTextBox.Text = CapitalizeWords(vietPhraseRichTextBox.Text, 3);
            vietPhraseRichTextBox.SelectAll();
            vietPhraseRichTextBox.Focus();
        }

        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            int millisecondsTimeout = (int)e.Argument;
            string b = "";
            bool phraseExistsInBaike = false;
            while (0 <= baikeCheckingLoopLimit)
            {
                string text = chineseTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(text) && text != b)
                {
                    try
                    {
                        phraseExistsInBaike = ExistsInBaike(text);
                    }
                    catch
                    {
                        phraseExistsInBaike = false;
                    }
                    finally
                    {
                        b = text;
                    }
                    UpdateBaikeCheckingResultToGui(phraseExistsInBaike);
                }
                Thread.Sleep(millisecondsTimeout);
                baikeCheckingLoopLimit--;
            }
        }

        private void CheckBaikeInNewThread(string chinese)
        {
            bool phraseExistsInBaike = false;
            ThreadPool.QueueUserWorkItem(delegate (object param0) {
                try
                {
                    phraseExistsInBaike = ExistsInBaike(chinese);
                }
                catch
                {
                    phraseExistsInBaike = false;
                }
                UpdateBaikeCheckingResultToGui(phraseExistsInBaike);
            });
        }

        private void UpdateBaikeCheckingResultToGui(bool phraseExistsInBaike)
        {
            string result = phraseExistsInBaike ? "Tồn tại." : "Không tồn tại.";
            Color foreColor = phraseExistsInBaike ? Color.Blue : Color.Red;
            GenericDelegate method = delegate () {
                existInBaikeLabel.Text = result;
                existInBaikeLabel.ForeColor = foreColor;
                surfBaikeLinkLabel.Visible = phraseExistsInBaike;
            };
            try
            {
                BeginInvoke(method);
            }
            catch
            {
            }
        }

        private bool ExistsInBaike(string chinesePhrase)
        {
            if (string.IsNullOrEmpty(chinesePhrase))
            {
                return false;
            }
            string requestUriString = "http://baike.baidu.com/list-php/dispose/searchword.php?word=" + HttpUtility.UrlEncode(chinesePhrase, Encoding.GetEncoding("gb2312")) + "&pic=1";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
            bool result;
            using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    streamReader.ReadLine();
                    string text = streamReader.ReadLine();
                    if (string.IsNullOrEmpty(text))
                    {
                        result = false;
                    }
                    else if (text.Contains("error"))
                    {
                        result = false;
                    }
                    else if (text.Contains("notexists"))
                    {
                        result = false;
                    }
                    else if (text.Contains("URL=/view/"))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void SurfBaikeLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chinesePhraseToSurfBaike = chineseTextBox.Text.Trim();
            needSurfBaike = true;
            Close();
        }

        public bool NeedSurfBaike {
            get {
                return needSurfBaike;
            }
        }

        public string ChinesePhraseToSurfBaike {
            get {
                return chinesePhraseToSurfBaike;
            }
        }

        private int type;

        private int baikeCheckingLoopLimit;

        private bool needSurfBaike;

        private string chinesePhraseToSurfBaike = "";

        private delegate void GenericDelegate();
    }
}

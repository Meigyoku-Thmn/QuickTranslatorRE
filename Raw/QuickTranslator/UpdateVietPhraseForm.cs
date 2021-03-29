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
using TranslatorEngine;

namespace QuickTranslator
{
	// Token: 0x0200001A RID: 26
	public partial class UpdateVietPhraseForm : Form
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00012219 File Offset: 0x00011219
		public UpdateVietPhraseForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00012250 File Offset: 0x00011250
		public UpdateVietPhraseForm(string chineseToLookup, int type)
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
			this.type = type;
			this.vietPhraseLabel.Text = ((type == 0) ? "VietPhrase:" : "Name:");
			this.Text = ((type == 0) ? "Update VietPhrase" : ((type == 1) ? "Update Name (chính)" : "Update Name (phụ)"));
			this.entryCountLabel.Text = (((type == 0) ? TranslatorEngine.GetVietPhraseDictionaryCount() : TranslatorEngine.GetNameDictionaryCount(type == 1)).ToString("0,0") ?? "");
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0001230C File Offset: 0x0001130C
		private void ChineseTextBoxTextChanged(object sender, EventArgs e)
		{
			this.updateButton.Enabled = (this.chineseTextBox.Text.Trim() != "");
			this.deleteButton.Enabled = (this.chineseTextBox.Text.Trim() != "");
			this.existInBaikeLabel.Text = "Đang kiểm tra...";
			this.existInBaikeLabel.ForeColor = SystemColors.ControlText;
			this.surfBaikeLinkLabel.Visible = false;
			if (this.chineseTextBox.Text.Trim() == "")
			{
				this.hanVietRichTextBox.Text = "";
				this.vietPhraseRichTextBox.Text = "";
				this.checkBaikeInNewThread(this.chineseTextBox.Text.Trim());
				return;
			}
			CharRange[] array;
			this.hanVietRichTextBox.Text = TranslatorEngine.ChineseToHanViet(this.chineseTextBox.Text, out array).Trim();
			string text = (this.type == 0) ? TranslatorEngine.GetVietPhraseValueFromKey(this.chineseTextBox.Text) : TranslatorEngine.GetNameValueFromKey(this.chineseTextBox.Text, this.type == 1);
			this.vietPhraseRichTextBox.Text = ((text == null) ? ((this.type == 0) ? this.hanVietRichTextBox.Text : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.hanVietRichTextBox.Text)) : text);
			this.deleteButton.Enabled = (text != null);
			this.updateButton.Text = ((text != null) ? "Update" : "Add");
			this.updatedByLabel.Text = ((this.type == 0) ? TranslatorEngine.GetVietPhraseHistoryLogRecord(this.chineseTextBox.Text) : TranslatorEngine.GetNameHistoryLogRecord(this.chineseTextBox.Text, this.type == 1));
			this.checkBaikeInNewThread(this.chineseTextBox.Text.Trim());
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000124F8 File Offset: 0x000114F8
		private void DeleteButtonClick(object sender, EventArgs e)
		{
			if (this.type == 0)
			{
				TranslatorEngine.DeleteKeyFromVietPhraseDictionary(this.chineseTextBox.Text, this.sortingCheckBox.Checked);
			}
			else
			{
				TranslatorEngine.DeleteKeyFromNameDictionary(this.chineseTextBox.Text, this.sortingCheckBox.Checked, this.type == 1);
			}
			this.CompressDictionaryHistory();
			base.Close();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0001255C File Offset: 0x0001155C
		private void UpdateButtonClick(object sender, EventArgs e)
		{
			if (this.chineseTextBox.Text.Trim() == "")
			{
				return;
			}
			if (this.type == 0)
			{
				TranslatorEngine.UpdateVietPhraseDictionary(this.chineseTextBox.Text, this.vietPhraseRichTextBox.Text, this.sortingCheckBox.Checked);
			}
			else
			{
				TranslatorEngine.UpdateNameDictionary(this.chineseTextBox.Text, this.vietPhraseRichTextBox.Text, this.sortingCheckBox.Checked, this.type == 1);
			}
			this.CompressDictionaryHistory();
			base.Close();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000125F1 File Offset: 0x000115F1
		private void CompressDictionaryHistory()
		{
			if (this.compressDictionaryHistoryCheckBox.Checked)
			{
				if (this.type == 0)
				{
					TranslatorEngine.CompressOnlyVietPhraseDictionaryHistory();
					return;
				}
				TranslatorEngine.CompressOnlyNameDictionaryHistory(this.type == 1);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0001261C File Offset: 0x0001161C
		private void CancelButtonClick(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00012624 File Offset: 0x00011624
		private void VietPhraseRichTextBoxKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00012637 File Offset: 0x00011637
		private void UpdateVietPhraseFormLoad(object sender, EventArgs e)
		{
			this.ChineseTextBoxTextChanged(null, null);
			this.vietPhraseRichTextBox.SelectAll();
			base.ActiveControl = this.vietPhraseRichTextBox;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00012658 File Offset: 0x00011658
		private void CapitalizeAllLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.vietPhraseRichTextBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.vietPhraseRichTextBox.Text);
			this.vietPhraseRichTextBox.SelectAll();
			this.vietPhraseRichTextBox.Focus();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00012696 File Offset: 0x00011696
		private void Capitalize1WordLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.vietPhraseRichTextBox.Text = this.capitalizeWords(this.vietPhraseRichTextBox.Text, 1);
			this.vietPhraseRichTextBox.SelectAll();
			this.vietPhraseRichTextBox.Focus();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000126CC File Offset: 0x000116CC
		private string capitalizeWords(string originalText, int numberOfWordsToBeCapitalized)
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

		// Token: 0x0600015C RID: 348 RVA: 0x0001275E File Offset: 0x0001175E
		private void Capitalize2WordsLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.vietPhraseRichTextBox.Text = this.capitalizeWords(this.vietPhraseRichTextBox.Text, 2);
			this.vietPhraseRichTextBox.SelectAll();
			this.vietPhraseRichTextBox.Focus();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00012794 File Offset: 0x00011794
		private void Capitalize3WordsLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.vietPhraseRichTextBox.Text = this.capitalizeWords(this.vietPhraseRichTextBox.Text, 3);
			this.vietPhraseRichTextBox.SelectAll();
			this.vietPhraseRichTextBox.Focus();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000127CC File Offset: 0x000117CC
		private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
		{
			int millisecondsTimeout = (int)e.Argument;
			string b = "";
			bool phraseExistsInBaike = false;
			string text = null;
			while (0 <= this.baikeCheckingLoopLimit)
			{
				text = this.chineseTextBox.Text.Trim();
				if (!string.IsNullOrEmpty(text) && text != b)
				{
					try
					{
						phraseExistsInBaike = this.existsInBaike(text);
					}
					catch
					{
						phraseExistsInBaike = false;
					}
					finally
					{
						b = text;
					}
					this.updateBaikeCheckingResultToGui(phraseExistsInBaike);
				}
				Thread.Sleep(millisecondsTimeout);
				this.baikeCheckingLoopLimit--;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000128C4 File Offset: 0x000118C4
		private void checkBaikeInNewThread(string chinese)
		{
			bool phraseExistsInBaike = false;
			ThreadPool.QueueUserWorkItem(delegate(object param0)
			{
				try
				{
					phraseExistsInBaike = this.existsInBaike(chinese);
				}
				catch
				{
					phraseExistsInBaike = false;
				}
				this.updateBaikeCheckingResultToGui(phraseExistsInBaike);
			});
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00012958 File Offset: 0x00011958
		private void updateBaikeCheckingResultToGui(bool phraseExistsInBaike)
		{
			string result = phraseExistsInBaike ? "Tồn tại." : "Không tồn tại.";
			Color foreColor = phraseExistsInBaike ? Color.Blue : Color.Red;
			UpdateVietPhraseForm.GenericDelegate method = delegate()
			{
				this.existInBaikeLabel.Text = result;
				this.existInBaikeLabel.ForeColor = foreColor;
				this.surfBaikeLinkLabel.Visible = phraseExistsInBaike;
			};
			try
			{
				base.BeginInvoke(method);
			}
			catch
			{
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000129D8 File Offset: 0x000119D8
		private bool existsInBaike(string chinesePhrase)
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

		// Token: 0x06000162 RID: 354 RVA: 0x00012AC0 File Offset: 0x00011AC0
		private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00012AC2 File Offset: 0x00011AC2
		private void SurfBaikeLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.chinesePhraseToSurfBaike = this.chineseTextBox.Text.Trim();
			this.needSurfBaike = true;
			base.Close();
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00012AE7 File Offset: 0x00011AE7
		public bool NeedSurfBaike
		{
			get
			{
				return this.needSurfBaike;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00012AEF File Offset: 0x00011AEF
		public string ChinesePhraseToSurfBaike
		{
			get
			{
				return this.chinesePhraseToSurfBaike;
			}
		}

		// Token: 0x04000168 RID: 360
		private const string BAIKE_CHECKING = "Đang kiểm tra...";

		// Token: 0x04000169 RID: 361
		private const string BAIKE_EXIST = "Tồn tại.";

		// Token: 0x0400016A RID: 362
		private const string BAIKE_NOT_EXIST = "Không tồn tại.";

		// Token: 0x0400016B RID: 363
		private int type;

		// Token: 0x0400016C RID: 364
		private int baikeCheckingLoopLimit;

		// Token: 0x0400016D RID: 365
		private bool needSurfBaike;

		// Token: 0x0400016E RID: 366
		private string chinesePhraseToSurfBaike = "";

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000169 RID: 361
		private delegate void GenericDelegate();
	}
}

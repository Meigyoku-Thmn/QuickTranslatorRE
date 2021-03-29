using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using ExtendedWebBrowser2;
using QuickConverter;
using TranslatorEngine;
using WeifenLuo.WinFormsUI.Docking;

namespace QuickTranslator
{
	// Token: 0x02000012 RID: 18
	public partial class MainForm : Form
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000A164 File Offset: 0x00009164
		public MainForm()
		{
			this.InitializeComponent();
			this.deserializeDockContent = new DeserializeDockContent(this.GetContentFromPersistString);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000A1FC File Offset: 0x000091FC
		private void MainFormLoad(object sender, EventArgs e)
		{
			this.hanVietDocumentPanel.Text = "Hán Việt";
			this.hanVietDocumentPanel.CloseButton = false;
			this.hanVietDocumentPanel.SetFontSize(12f);
			this.chineseDocumentPanel.Text = "Trung";
			this.chineseDocumentPanel.CloseButton = false;
			this.chineseDocumentPanel.SetFontSize(14f);
			this.vietPhraseDocumentPanel.Text = "VietPhrase";
			this.vietPhraseDocumentPanel.CloseButton = false;
			this.vietPhraseDocumentPanel.SetFontSize(12f);
			this.vietPhraseOneMeaningDocumentPanel.Text = "VietPhrase một nghĩa";
			this.vietPhraseOneMeaningDocumentPanel.CloseButton = false;
			this.vietPhraseOneMeaningDocumentPanel.SetFontSize(12f);
			this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.AcceptsTab = true;
			this.meaningDocumentPanel.Text = "Nghĩa";
			this.meaningDocumentPanel.CloseButton = false;
			this.meaningDocumentPanel.SetFontSize(10f);
			this.vietDocumentPanel.Text = "Việt";
			this.vietDocumentPanel.CloseButton = false;
			this.vietDocumentPanel.SetFontSize(12f);
			this.SetPanelStyle();
			this.configurationPanel.Text = "Configuration";
			this.configurationPanel.CloseButton = false;
			this.extendedBrowserPanel.Text = "Quick Web Browser";
			this.extendedBrowserPanel.CloseButton = false;
			this.hanVietDocumentPanel.EnableAddToVietPhraseContextMenuStrip();
			this.chineseDocumentPanel.EnableAddToVietPhraseContextMenuStrip();
			this.vietPhraseDocumentPanel.EnableAddToVietPhraseContextMenuStrip();
			this.vietPhraseOneMeaningDocumentPanel.EnableAddToVietPhraseContextMenuStrip();
			this.vietDocumentPanel.EnableCommentContextMenuStrip();
			this.meaningDocumentPanel.EnableAddToVietPhraseContextMenuStrip();
			this.extendedBrowserPanel.fullScreenToolStripButton.Enabled = false;
			this.extendedBrowserPanel.fullScreenToolStripButton.Visible = false;
			this.hanVietDocumentPanel.AllowDeletingSelectedText();
			this.chineseDocumentPanel.AllowDeletingSelectedText();
			if (File.Exists(MainForm.dockPanelConfigFilePath))
			{
				this.dockPanel.LoadFromXml(MainForm.dockPanelConfigFilePath, this.deserializeDockContent);
			}
			else
			{
				this.configurationPanel.Show(this.dockPanel, DockState.DockLeftAutoHide);
				this.extendedBrowserPanel.Show(this.dockPanel, DockState.Document);
				this.vietDocumentPanel.Show(this.dockPanel, DockState.Document);
				this.meaningDocumentPanel.Show(this.dockPanel, DockState.Document);
				this.vietPhraseOneMeaningDocumentPanel.Show(this.dockPanel, DockState.Document);
				this.vietPhraseDocumentPanel.Show(this.dockPanel, DockState.Document);
				this.chineseDocumentPanel.Show(this.dockPanel, DockState.Document);
				this.hanVietDocumentPanel.Show(this.dockPanel, DockState.Document);
			}
			this.isNewTranslationWork = true;
			this.setFormTitle();
			this.chineseDocumentPanel.ClickHandler = new DocumentPanel.ClickDelegate(this.ChineseClick);
			this.chineseDocumentPanel.AddToVietPhraseHandler = new DocumentPanel.AddToVietPhraseDelegate(this.Chinese_AddToVietPhraseHandler);
			this.chineseDocumentPanel.SelectTextHandler = new DocumentPanel.SelectTextDelegate(this.Chinese_SelectTextHandler);
			this.chineseDocumentPanel.BaikeingHandler = new DocumentPanel.BaikeingDelegate(this.BaikeingHandler);
			this.chineseDocumentPanel.NcikuingHandler = new DocumentPanel.NcikuingDelegate(this.NcikuingHandler);
			this.chineseDocumentPanel.CopyToVietHandler = new DocumentPanel.CopyToVietDelegate(this.CopyToVietHandler);
			this.chineseDocumentPanel.DeleteSelectedTextHandler = new DocumentPanel.DeleteSelectedTextDelegate(this.DeleteSelectedTextHandler);
			this.chineseDocumentPanel.AddToPhienAmHandler = new DocumentPanel.AddToPhienAmDelegate(this.AddToPhienAmHandler);
			this.hanVietDocumentPanel.ClickHandler = new DocumentPanel.ClickDelegate(this.HanVietClick);
			this.hanVietDocumentPanel.RightClickHandler = new DocumentPanel.RightClickDelegate(this.HanVietRightClick);
			this.hanVietDocumentPanel.AddToVietPhraseHandler = new DocumentPanel.AddToVietPhraseDelegate(this.HanViet_AddToVietPhraseHandler);
			this.hanVietDocumentPanel.SelectTextHandler = new DocumentPanel.SelectTextDelegate(this.HanViet_SelectTextHandler);
			this.hanVietDocumentPanel.BaikeingHandler = new DocumentPanel.BaikeingDelegate(this.BaikeingHandler);
			this.hanVietDocumentPanel.NcikuingHandler = new DocumentPanel.NcikuingDelegate(this.NcikuingHandler);
			this.hanVietDocumentPanel.CopyToVietHandler = new DocumentPanel.CopyToVietDelegate(this.CopyToVietHandler);
			this.hanVietDocumentPanel.DeleteSelectedTextHandler = new DocumentPanel.DeleteSelectedTextDelegate(this.DeleteSelectedTextHandler);
			this.hanVietDocumentPanel.AddToPhienAmHandler = new DocumentPanel.AddToPhienAmDelegate(this.AddToPhienAmHandler);
			this.vietPhraseDocumentPanel.ClickHandler = new DocumentPanel.ClickDelegate(this.VietPhraseClick);
			this.vietPhraseDocumentPanel.RightClickHandler = new DocumentPanel.RightClickDelegate(this.VietPhraseRightClick);
			this.vietPhraseDocumentPanel.AddToVietPhraseHandler = new DocumentPanel.AddToVietPhraseDelegate(this.VietPhrase_AddToVietPhraseHandler);
			this.vietPhraseDocumentPanel.SelectTextHandler = new DocumentPanel.SelectTextDelegate(this.VietPhrase_SelectTextHandler);
			this.vietPhraseDocumentPanel.BaikeingHandler = new DocumentPanel.BaikeingDelegate(this.BaikeingHandler);
			this.vietPhraseDocumentPanel.NcikuingHandler = new DocumentPanel.NcikuingDelegate(this.NcikuingHandler);
			this.vietPhraseDocumentPanel.CopyToVietHandler = new DocumentPanel.CopyToVietDelegate(this.CopyToVietHandler);
			this.vietPhraseDocumentPanel.AddToPhienAmHandler = new DocumentPanel.AddToPhienAmDelegate(this.AddToPhienAmHandler);
			this.vietPhraseOneMeaningDocumentPanel.ClickHandler = new DocumentPanel.ClickDelegate(this.VietPhraseOneMeaningClick);
			this.vietPhraseOneMeaningDocumentPanel.RightClickHandler = new DocumentPanel.RightClickDelegate(this.VietPhraseOneMeaningRightClick);
			this.vietPhraseOneMeaningDocumentPanel.AddToVietPhraseHandler = new DocumentPanel.AddToVietPhraseDelegate(this.VietPhraseOneMeaning_AddToVietPhraseHandler);
			this.vietPhraseOneMeaningDocumentPanel.SelectTextHandler = new DocumentPanel.SelectTextDelegate(this.VietPhraseOneMeaning_SelectTextHandler);
			this.vietPhraseOneMeaningDocumentPanel.BaikeingHandler = new DocumentPanel.BaikeingDelegate(this.BaikeingHandler);
			this.vietPhraseOneMeaningDocumentPanel.NcikuingHandler = new DocumentPanel.NcikuingDelegate(this.NcikuingHandler);
			this.vietPhraseOneMeaningDocumentPanel.CopyToVietHandler = new DocumentPanel.CopyToVietDelegate(this.CopyToVietHandler);
			this.vietPhraseOneMeaningDocumentPanel.AddToPhienAmHandler = new DocumentPanel.AddToPhienAmDelegate(this.AddToPhienAmHandler);
			this.vietPhraseOneMeaningDocumentPanel.ShiftAndMouseMoveHandler = new DocumentPanel.ShiftAndMouseMoveDelegate(this.ShiftAndMouseMoveHandler);
			this.vietPhraseOneMeaningDocumentPanel.ShiftUpHandler = new DocumentPanel.ShiftUpDelegate(this.ShiftUpHandler);
			this.meaningDocumentPanel.AddToVietPhraseHandler = new DocumentPanel.AddToVietPhraseDelegate(this.Meaning_AddToVietPhraseHandler);
			this.meaningDocumentPanel.BaikeingHandler = new DocumentPanel.BaikeingDelegate(this.BaikeingHandler);
			this.meaningDocumentPanel.NcikuingHandler = new DocumentPanel.NcikuingDelegate(this.NcikuingHandler);
			this.meaningDocumentPanel.CopyToVietHandler = new DocumentPanel.CopyToVietDelegate(this.CopyToVietHandler);
			this.meaningDocumentPanel.AddToPhienAmHandler = new DocumentPanel.AddToPhienAmDelegate(this.AddToPhienAmHandler);
			TranslatorEngine.LoadDictionaries();
			Shortcuts.LoadFromFile(MainForm.shortcutDictionaryFilePath);
			this.vietPhraseToolStripMenuItem.Checked = MainForm.ActiveConfiguration.Layout_VietPhrase;
			this.vietPhraseOneMeaningToolStripMenuItem.Checked = MainForm.ActiveConfiguration.Layout_VietPhraseOneMeaning;
			this.hanVietDocumentPanel.Activate();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000A87C File Offset: 0x0000987C
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (msg.Msg == 256 || msg.Msg == 260)
			{
				if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_MoveRightOneWord)))
				{
					this.nextHanVietWord();
				}
				else if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_MoveLeftOneWord)))
				{
					this.previousHanVietWord();
				}
				else if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_MoveDownOneLine)))
				{
					this.HanVietClick(this.hanVietDocumentPanel.getNextLineIndex());
				}
				else if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_MoveUpOneLine)))
				{
					this.HanVietClick(this.hanVietDocumentPanel.getPreviousLineIndex());
				}
				else if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_MoveDownOneParagraph)))
				{
					this.HanVietClick(this.hanVietDocumentPanel.getNextPhysicalLineIndex());
				}
				else if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_MoveUpOneParagraph)))
				{
					this.HanVietClick(this.hanVietDocumentPanel.getPreviousPhysicalLineIndex());
				}
				else if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_CopyHighlightedHanViet)))
				{
					this.CopyToVietHandler(this.hanVietDocumentPanel.GetHighlightText());
				}
				else if (keyData == (Keys)131142)
				{
					Form form = new FindAndReplaceForm(this.chineseDocumentPanel.contentRichTextBox);
					form.Show(this);
				}
				else if (keyData == (Keys.LButton | Keys.RButton | Keys.MButton | Keys.Space | Keys.Alt))
				{
					if (this.nextToolStripButton.Enabled)
					{
						this.OpenFile(this.nextFilePath);
					}
				}
				else if (keyData == (Keys.LButton | Keys.MButton | Keys.Space | Keys.Alt))
				{
					if (this.backToolStripButton.Enabled)
					{
						this.OpenFile(this.backFilePath);
					}
				}
				else
				{
					if (!MainForm.ActiveConfiguration.Layout_VietPhrase)
					{
						return base.ProcessCmdKey(ref msg, keyData);
					}
					if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_CopyMeaning1)))
					{
						this.copyMeaning(1);
					}
					else if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_CopyMeaning2)))
					{
						this.copyMeaning(2);
					}
					else if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_CopyMeaning3)))
					{
						this.copyMeaning(3);
					}
					else if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_CopyMeaning4)))
					{
						this.copyMeaning(4);
					}
					else if (keyData == (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_CopyMeaning5)))
					{
						this.copyMeaning(5);
					}
					else
					{
						if (keyData != (Keys.Control | (Keys)((byte)MainForm.ActiveConfiguration.HotKeys_CopyMeaning6)))
						{
							return base.ProcessCmdKey(ref msg, keyData);
						}
						this.copyMeaning(6);
					}
				}
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000AB0C File Offset: 0x00009B0C
		private void TranslateFromClipboardToolStripButtonClick(object sender, EventArgs e)
		{
			this.isNewTranslationWork = true;
			string original = "";
			try
			{
				original = Clipboard.GetText();
			}
			catch
			{
			}
			this.chineseDocumentPanel.SetTextContent(TranslatorEngine.StandardizeInput(original));
			this.Translate(-2, -2, -2);
			this.Text = "Quick Translator - Untitled";
			this.workingFilePath = "";
			this.toggleNextBackButtons();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000AB7C File Offset: 0x00009B7C
		public void Translate(int currentHanVietDisplayedLine, int currentVietPhraseDisplayedLine, int currentVietPhraseOneMeaningDisplayedLine)
		{
			this.chineseContent = this.chineseDocumentPanel.GetTextContent();
			if (string.IsNullOrEmpty(this.chineseContent) || string.IsNullOrEmpty(this.chineseContent.Trim()))
			{
				return;
			}
			this.translateHanViet(currentHanVietDisplayedLine);
			this.translateVietPhraseOneMeaning(currentVietPhraseOneMeaningDisplayedLine);
			this.translateVietPhrase(currentVietPhraseDisplayedLine);
			this.calculateChineseWordCount();
			this.vietPhraseOneMeaningChanged = false;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000AC64 File Offset: 0x00009C64
		private void translateHanViet(int currentDisplayedLine)
		{
			new Thread(delegate()
			{
				lock (TranslatorEngine.LastTranslatedWord_HanViet)
				{
					if (!string.IsNullOrEmpty(this.chineseContent))
					{
						string text = TranslatorEngine.ChineseToHanViet(this.chineseContent, out this.chineseHanVietMappingArray);
						this.updateDocumentPanel(this.hanVietDocumentPanel, text, currentDisplayedLine);
					}
				}
			})
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000ADA4 File Offset: 0x00009DA4
		private void translateVietPhraseOneMeaning(int currentDisplayedLine)
		{
			if (!this.vietPhraseOneMeaningDocumentPanel.IsHidden)
			{
				new Thread(delegate()
				{
					lock (TranslatorEngine.LastTranslatedWord_VietPhraseOneMeaning)
					{
						if (!string.IsNullOrEmpty(this.chineseContent))
						{
							string text;
							if (MainForm.ActiveConfiguration.Layout_VietPhrase)
							{
								CharRange[] array;
								text = TranslatorEngine.ChineseToVietPhraseOneMeaning(this.chineseContent, MainForm.ActiveConfiguration.VietPhraseOneMeaning_Wrap, MainForm.ActiveConfiguration.TranslationAlgorithm, MainForm.ActiveConfiguration.PrioritizedName, out array, out this.vietPhraseOneMeaningRanges);
							}
							else
							{
								text = TranslatorEngine.ChineseToVietPhraseOneMeaning(this.chineseContent, MainForm.ActiveConfiguration.VietPhraseOneMeaning_Wrap, MainForm.ActiveConfiguration.TranslationAlgorithm, MainForm.ActiveConfiguration.PrioritizedName, out this.chinesePhraseRanges, out this.vietPhraseOneMeaningRanges);
							}
							this.updateDocumentPanel(this.vietPhraseOneMeaningDocumentPanel, text, currentDisplayedLine);
						}
					}
				})
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000AEA8 File Offset: 0x00009EA8
		private void translateVietPhrase(int currentDisplayedLine)
		{
			if (!this.vietPhraseDocumentPanel.IsHidden)
			{
				new Thread(delegate()
				{
					lock (TranslatorEngine.LastTranslatedWord_VietPhrase)
					{
						if (!string.IsNullOrEmpty(this.chineseContent))
						{
							string text = TranslatorEngine.ChineseToVietPhrase(this.chineseContent, MainForm.ActiveConfiguration.VietPhrase_Wrap, MainForm.ActiveConfiguration.TranslationAlgorithm, MainForm.ActiveConfiguration.PrioritizedName, out this.chinesePhraseRanges, out this.vietPhraseRanges);
							this.updateDocumentPanel(this.vietPhraseDocumentPanel, text, currentDisplayedLine);
						}
					}
				})
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000AF7C File Offset: 0x00009F7C
		private void updateDocumentPanel(DocumentPanel panel, string text, int currentDisplayedLine)
		{
			MainForm.GenericDelegate genericDelegate = delegate()
			{
				panel.SetTextContent(text);
				if (currentDisplayedLine <= -2)
				{
					panel.ScrollToTop();
					return;
				}
				if (currentDisplayedLine == -1)
				{
					int physicalLine = this.countPhysicalLines(this.vietDocumentPanel.GetTextContent());
					panel.ScrollToASpecificPhysicalLine(physicalLine);
					return;
				}
				panel.ScrollToASpecificLogicalLine(currentDisplayedLine);
			};
			if (!panel.IsHandleCreated)
			{
				this.CreateHandle();
			}
			if (panel.InvokeRequired)
			{
				panel.BeginInvoke(genericDelegate);
				return;
			}
			genericDelegate();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000AFEC File Offset: 0x00009FEC
		public void SetPanelStyle()
		{
			this.chineseDocumentPanel.SetFont(MainForm.ActiveConfiguration.Style_TrungFont);
			this.chineseDocumentPanel.SetForeColor(MainForm.ActiveConfiguration.Style_TrungForeColor);
			this.chineseDocumentPanel.SetBackColor(MainForm.ActiveConfiguration.Style_TrungBackColor);
			this.hanVietDocumentPanel.SetFont(MainForm.ActiveConfiguration.Style_HanVietFont);
			this.hanVietDocumentPanel.SetForeColor(MainForm.ActiveConfiguration.Style_HanVietForeColor);
			this.hanVietDocumentPanel.SetBackColor(MainForm.ActiveConfiguration.Style_HanVietBackColor);
			this.vietPhraseDocumentPanel.SetFont(MainForm.ActiveConfiguration.Style_VietPhraseFont);
			this.vietPhraseDocumentPanel.SetForeColor(MainForm.ActiveConfiguration.Style_VietPhraseForeColor);
			this.vietPhraseDocumentPanel.SetBackColor(MainForm.ActiveConfiguration.Style_VietPhraseBackColor);
			this.vietPhraseOneMeaningDocumentPanel.SetFont(MainForm.ActiveConfiguration.Style_VietPhraseOneMeaningFont);
			this.vietPhraseOneMeaningDocumentPanel.SetForeColor(MainForm.ActiveConfiguration.Style_VietPhraseOneMeaningForeColor);
			this.vietPhraseOneMeaningDocumentPanel.SetBackColor(MainForm.ActiveConfiguration.Style_VietPhraseOneMeaningBackColor);
			this.vietDocumentPanel.SetFont(MainForm.ActiveConfiguration.Style_VietFont);
			this.vietDocumentPanel.SetForeColor(MainForm.ActiveConfiguration.Style_VietForeColor);
			this.vietDocumentPanel.SetBackColor(MainForm.ActiveConfiguration.Style_VietBackColor);
			this.meaningDocumentPanel.SetFont(MainForm.ActiveConfiguration.Style_NghiaFont);
			this.meaningDocumentPanel.SetForeColor(MainForm.ActiveConfiguration.Style_NghiaForeColor);
			this.meaningDocumentPanel.SetBackColor(MainForm.ActiveConfiguration.Style_NghiaBackColor);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000B174 File Offset: 0x0000A174
		private void chineseToHanVietWithNewThread(object stateInfo)
		{
			object[] array = (object[])stateInfo;
			this.hanVietContent = TranslatorEngine.ChineseToHanViet((string)array[0], out this.chineseHanVietMappingArray);
			((ManualResetEvent)array[1]).Set();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000B1B0 File Offset: 0x0000A1B0
		private void chineseToVietPhraseWithNewThread(object stateInfo)
		{
			object[] array = (object[])stateInfo;
			this.vietPhraseContent = TranslatorEngine.ChineseToVietPhrase((string)array[0], MainForm.ActiveConfiguration.VietPhrase_Wrap, MainForm.ActiveConfiguration.TranslationAlgorithm, MainForm.ActiveConfiguration.PrioritizedName, out this.chinesePhraseRanges, out this.vietPhraseRanges);
			((ManualResetEvent)array[1]).Set();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000B210 File Offset: 0x0000A210
		private void chineseToVietPhraseOneMeaningWithNewThread(object stateInfo)
		{
			object[] array = (object[])stateInfo;
			CharRange[] array2;
			this.vietPhraseOneMeaningContent = TranslatorEngine.ChineseToVietPhraseOneMeaning((string)array[0], MainForm.ActiveConfiguration.VietPhraseOneMeaning_Wrap, MainForm.ActiveConfiguration.TranslationAlgorithm, MainForm.ActiveConfiguration.PrioritizedName, out array2, out this.vietPhraseOneMeaningRanges);
			((ManualResetEvent)array[1]).Set();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000B26B File Offset: 0x0000A26B
		private void previousHanVietWord()
		{
			this.HanVietClick(this.hanVietDocumentPanel.getPreviousWordIndex());
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B27E File Offset: 0x0000A27E
		private void nextHanVietWord()
		{
			this.HanVietClick(this.hanVietDocumentPanel.getNextWordIndex());
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000B291 File Offset: 0x0000A291
		private void setFormTitle()
		{
			this.Text = "Quick Translator";
			this.Text += (this.isNewTranslationWork ? " - Untitled" : this.workingFilePath);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000B2C4 File Offset: 0x0000A2C4
		private void HanVietClick(int currentCharIndex)
		{
			try
			{
				this.HanVietClickWithoutHandlingException(currentCharIndex);
			}
			catch (Exception exception)
			{
				ApplicationLog.Log(Path.GetDirectoryName(Application.ExecutablePath), "QuickTranslator", exception);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000B304 File Offset: 0x0000A304
		private void HanVietClickWithoutHandlingException(int currentCharIndex)
		{
			if (this.hanVietDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
			{
				return;
			}
			int num = this.findChineseCharIndexFromHanVietIndex(currentCharIndex);
			if (num < 0)
			{
				return;
			}
			int num2;
			string text = TranslatorEngine.ChineseToMeanings(this.chineseDocumentPanel.GetTextContent().Substring(num), out num2);
			this.meaningDocumentPanel.SetTextContent(text.Replace("\\n", "\n").Replace("\\t", "\t"));
			this.meaningDocumentPanel.ScrollToTop();
			this.chineseDocumentPanel.HighlightText(num, num2, true, true);
			CharRange hanVietCharRangeFromChineseRange = this.getHanVietCharRangeFromChineseRange(num, num2);
			this.hanVietDocumentPanel.HighlightText(hanVietCharRangeFromChineseRange.StartIndex, hanVietCharRangeFromChineseRange.Length, true, false);
			if (MainForm.ActiveConfiguration.Layout_VietPhrase)
			{
				CharRange vietPhraseCharRangeFromChineseIndex = this.getVietPhraseCharRangeFromChineseIndex(num);
				this.vietPhraseDocumentPanel.HighlightText(vietPhraseCharRangeFromChineseIndex.StartIndex, vietPhraseCharRangeFromChineseIndex.Length, true, true);
			}
			if (MainForm.ActiveConfiguration.Layout_VietPhraseOneMeaning)
			{
				CharRange vietPhraseOneMeaningCharRangeFromChineseIndex = this.getVietPhraseOneMeaningCharRangeFromChineseIndex(num);
				this.vietPhraseOneMeaningDocumentPanel.HighlightText(vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex, vietPhraseOneMeaningCharRangeFromChineseIndex.Length, true, true);
			}
			if (MainForm.ActiveConfiguration.AlwaysFocusInViet)
			{
				this.vietDocumentPanel.FocusInRichTextBox();
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000B42C File Offset: 0x0000A42C
		private void ChineseClick(int chineseCharIndex)
		{
			try
			{
				this.ChineseClickWithoutHandlingException(chineseCharIndex);
			}
			catch (Exception exception)
			{
				ApplicationLog.Log(Path.GetDirectoryName(Application.ExecutablePath), "QuickTranslator", exception);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000B46C File Offset: 0x0000A46C
		private void ChineseClickWithoutHandlingException(int chineseCharIndex)
		{
			if (this.chineseDocumentPanel.GetTextContent().Length - 1 < chineseCharIndex)
			{
				return;
			}
			int num;
			string text = TranslatorEngine.ChineseToMeanings(this.chineseDocumentPanel.GetTextContent().Substring(chineseCharIndex), out num);
			this.meaningDocumentPanel.SetTextContent(text.Replace("\\n", "\n").Replace("\\t", "\t"));
			this.meaningDocumentPanel.ScrollToTop();
			this.chineseDocumentPanel.HighlightText(chineseCharIndex, num, true, false);
			CharRange hanVietCharRangeFromChineseRange = this.getHanVietCharRangeFromChineseRange(chineseCharIndex, num);
			this.hanVietDocumentPanel.HighlightText(hanVietCharRangeFromChineseRange.StartIndex, hanVietCharRangeFromChineseRange.Length, true, true);
			if (MainForm.ActiveConfiguration.Layout_VietPhrase)
			{
				CharRange vietPhraseCharRangeFromChineseIndex = this.getVietPhraseCharRangeFromChineseIndex(chineseCharIndex);
				this.vietPhraseDocumentPanel.HighlightText(vietPhraseCharRangeFromChineseIndex.StartIndex, vietPhraseCharRangeFromChineseIndex.Length, true, true);
			}
			if (MainForm.ActiveConfiguration.Layout_VietPhraseOneMeaning)
			{
				CharRange vietPhraseOneMeaningCharRangeFromChineseIndex = this.getVietPhraseOneMeaningCharRangeFromChineseIndex(chineseCharIndex);
				this.vietPhraseOneMeaningDocumentPanel.HighlightText(vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex, vietPhraseOneMeaningCharRangeFromChineseIndex.Length, true, true);
			}
			if (MainForm.ActiveConfiguration.AlwaysFocusInViet)
			{
				this.vietDocumentPanel.FocusInRichTextBox();
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000B584 File Offset: 0x0000A584
		private int findChineseCharIndexFromHanVietIndex(int hanVietCharIndex)
		{
			int result = -1;
			for (int i = 0; i < this.chineseHanVietMappingArray.Length; i++)
			{
				if (this.chineseHanVietMappingArray[i].StartIndex <= hanVietCharIndex && hanVietCharIndex <= this.chineseHanVietMappingArray[i].GetEndIndex())
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000B5CC File Offset: 0x0000A5CC
		private void VietPhraseClick(int currentCharIndex)
		{
			try
			{
				this.VietPhraseClickWithoutHandlingException(currentCharIndex);
			}
			catch (Exception exception)
			{
				ApplicationLog.Log(Path.GetDirectoryName(Application.ExecutablePath), "QuickTranslator", exception);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000B60C File Offset: 0x0000A60C
		private void VietPhraseClickWithoutHandlingException(int currentCharIndex)
		{
			if (this.vietPhraseDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
			{
				return;
			}
			if (this.getChineseCharRangeFromVietPhraseIndex(currentCharIndex) == null)
			{
				return;
			}
			int startIndex = this.getChineseCharRangeFromVietPhraseIndex(currentCharIndex).StartIndex;
			int num;
			string text = TranslatorEngine.ChineseToMeanings(this.chineseDocumentPanel.GetTextContent().Substring(startIndex), out num);
			this.meaningDocumentPanel.SetTextContent(text.Replace("\\n", "\n").Replace("\\t", "\t"));
			this.meaningDocumentPanel.ScrollToTop();
			this.chineseDocumentPanel.HighlightText(startIndex, num, true, true);
			CharRange hanVietCharRangeFromChineseRange = this.getHanVietCharRangeFromChineseRange(startIndex, num);
			this.hanVietDocumentPanel.HighlightText(hanVietCharRangeFromChineseRange.StartIndex, hanVietCharRangeFromChineseRange.Length, true, true);
			CharRange vietPhraseCharRangeFromChineseIndex = this.getVietPhraseCharRangeFromChineseIndex(startIndex);
			this.vietPhraseDocumentPanel.HighlightText(vietPhraseCharRangeFromChineseIndex.StartIndex, vietPhraseCharRangeFromChineseIndex.Length, true, false);
			if (MainForm.ActiveConfiguration.Layout_VietPhraseOneMeaning)
			{
				CharRange vietPhraseOneMeaningCharRangeFromChineseIndex = this.getVietPhraseOneMeaningCharRangeFromChineseIndex(startIndex);
				this.vietPhraseOneMeaningDocumentPanel.HighlightText(vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex, vietPhraseOneMeaningCharRangeFromChineseIndex.Length, true, true);
			}
			if (MainForm.ActiveConfiguration.AlwaysFocusInViet)
			{
				this.vietDocumentPanel.FocusInRichTextBox();
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000B730 File Offset: 0x0000A730
		private void VietPhraseOneMeaningClick(int currentCharIndex)
		{
			try
			{
				this.VietPhraseOneMeaningClickWithoutHandlingException(currentCharIndex);
			}
			catch (Exception exception)
			{
				ApplicationLog.Log(Path.GetDirectoryName(Application.ExecutablePath), "QuickTranslator", exception);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000B770 File Offset: 0x0000A770
		private void VietPhraseOneMeaningClickWithoutHandlingException(int currentCharIndex)
		{
			if (this.vietPhraseOneMeaningDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
			{
				return;
			}
			CharRange chineseCharRangeFromVietPhraseOneMeaningIndex = this.getChineseCharRangeFromVietPhraseOneMeaningIndex(currentCharIndex);
			if (chineseCharRangeFromVietPhraseOneMeaningIndex == null)
			{
				return;
			}
			int startIndex = chineseCharRangeFromVietPhraseOneMeaningIndex.StartIndex;
			int num;
			string text = TranslatorEngine.ChineseToMeanings(this.chineseDocumentPanel.GetTextContent().Substring(startIndex), out num);
			this.meaningDocumentPanel.SetTextContent(text.Replace("\\n", "\n").Replace("\\t", "\t"));
			this.meaningDocumentPanel.ScrollToTop();
			this.chineseDocumentPanel.HighlightText(startIndex, num, true, true);
			CharRange hanVietCharRangeFromChineseRange = this.getHanVietCharRangeFromChineseRange(startIndex, num);
			this.hanVietDocumentPanel.HighlightText(hanVietCharRangeFromChineseRange.StartIndex, hanVietCharRangeFromChineseRange.Length, true, true);
			if (MainForm.ActiveConfiguration.Layout_VietPhrase)
			{
				CharRange vietPhraseCharRangeFromChineseIndex = this.getVietPhraseCharRangeFromChineseIndex(startIndex);
				this.vietPhraseDocumentPanel.HighlightText(vietPhraseCharRangeFromChineseIndex.StartIndex, vietPhraseCharRangeFromChineseIndex.Length, true, true);
			}
			CharRange vietPhraseOneMeaningCharRangeFromChineseIndex = this.getVietPhraseOneMeaningCharRangeFromChineseIndex(startIndex);
			string text2 = TranslatorEngine.GetVietPhraseOrNameValueFromKey(this.chineseContent.Substring(startIndex, num));
			if (this.vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextStartIndex == vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex && this.vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextLength == vietPhraseOneMeaningCharRangeFromChineseIndex.Length && !"\n".Equals(this.vietPhraseOneMeaningDocumentPanel.GetHighlightText()))
			{
				if (string.IsNullOrEmpty(text2))
				{
					text2 = string.Empty;
				}
				string[] array = text2.Split("/|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				string value = this.vietPhraseOneMeaningDocumentPanel.GetTextContent().Substring(this.vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextStartIndex, this.vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextLength);
				this.vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Items.Clear();
				if (1 < array.Length)
				{
					foreach (string text3 in array)
					{
						if (!text3.Equals(value, StringComparison.InvariantCultureIgnoreCase))
						{
							StringBuilder stringBuilder = new StringBuilder();
							stringBuilder.AppendLine(this.findChineseMappingId(startIndex).ToString());
							stringBuilder.AppendLine(value);
							stringBuilder.AppendLine(this.chineseDocumentPanel.GetTextContent().Substring(startIndex, num));
							stringBuilder.AppendLine(text3);
							ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text3);
							toolStripMenuItem.Tag = stringBuilder.ToString();
							toolStripMenuItem.Click += this.chooseAMeaningMenuItem_Click;
							ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem("Update VietPhrase");
							toolStripMenuItem2.Tag = stringBuilder.ToString();
							toolStripMenuItem2.Click += this.chooseAMeaningMenuItem_Click;
							toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
							this.vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Items.Add(toolStripMenuItem);
						}
					}
					this.vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Items.Add(new ToolStripSeparator());
				}
				ToolStripTextBox toolStripTextBox = new ToolStripTextBox();
				toolStripTextBox.BorderStyle = BorderStyle.FixedSingle;
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.AppendLine(this.findChineseMappingId(startIndex).ToString());
				stringBuilder2.AppendLine(value);
				stringBuilder2.AppendLine(this.chineseDocumentPanel.GetTextContent().Substring(startIndex, num));
				toolStripTextBox.Tag = stringBuilder2.ToString();
				toolStripTextBox.KeyPress += this.newMeaningTextBox_KeyPress;
				this.vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Items.Add(toolStripTextBox);
				this.vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Show(Cursor.Position);
				if (this.vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Items.Count < 2)
				{
					toolStripTextBox.Focus();
				}
			}
			this.vietPhraseOneMeaningDocumentPanel.HighlightText(vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex, vietPhraseOneMeaningCharRangeFromChineseIndex.Length, true, false);
			if (MainForm.ActiveConfiguration.AlwaysFocusInViet)
			{
				this.vietDocumentPanel.FocusInRichTextBox();
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000BB34 File Offset: 0x0000AB34
		private void chooseAMeaningMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			string[] array = ((string)toolStripMenuItem.Tag).Replace("\r", "").Split(new char[]
			{
				'\n'
			});
			string text = array[3];
			int num = int.Parse(array[0].Trim());
			string text2 = array[1].Trim();
			int num2 = text.Length - text2.Length;
			this.vietPhraseOneMeaningRanges[num].Length += num2;
			for (int i = 0; i < this.vietPhraseOneMeaningRanges.Length; i++)
			{
				if (this.vietPhraseOneMeaningRanges[num].StartIndex < this.vietPhraseOneMeaningRanges[i].StartIndex)
				{
					this.vietPhraseOneMeaningRanges[i].StartIndex += num2;
				}
			}
			string text3 = text;
			if (char.IsUpper(text2[0]))
			{
				text3 = char.ToUpper(text[0]) + ((text.Length <= 1) ? "" : text.Substring(1));
			}
			this.vietPhraseOneMeaningDocumentPanel.ReplaceHighlightedText(text3);
			if ("Update VietPhrase".Equals(toolStripMenuItem.Text))
			{
				string[] array2 = TranslatorEngine.GetVietPhraseValueFromKey(array[2].Trim()).Split("/|".ToCharArray());
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(text);
				foreach (string text4 in array2)
				{
					if (!text4.Equals(text))
					{
						stringBuilder.Append("/");
						stringBuilder.Append(text4);
					}
				}
				TranslatorEngine.UpdateVietPhraseDictionary(array[2], stringBuilder.ToString(), false);
			}
			this.vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Hide();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000BCF4 File Offset: 0x0000ACF4
		private void newMeaningTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\r')
			{
				return;
			}
			ToolStripTextBox toolStripTextBox = (ToolStripTextBox)sender;
			string[] array = ((string)toolStripTextBox.Tag).Replace("\r", "").Split(new char[]
			{
				'\n'
			});
			string text = toolStripTextBox.Text;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			int num = int.Parse(array[0].Trim());
			string text2 = array[1].Trim();
			int num2 = text.Length - text2.Length;
			this.vietPhraseOneMeaningRanges[num].Length += num2;
			for (int i = 0; i < this.vietPhraseOneMeaningRanges.Length; i++)
			{
				if (this.vietPhraseOneMeaningRanges[num].StartIndex < this.vietPhraseOneMeaningRanges[i].StartIndex)
				{
					this.vietPhraseOneMeaningRanges[i].StartIndex += num2;
				}
			}
			string text3 = text;
			if (char.IsUpper(text2[0]) && 0 < text.Length)
			{
				text3 = char.ToUpper(text[0]) + ((text.Length <= 1) ? "" : text.Substring(1));
			}
			this.vietPhraseOneMeaningDocumentPanel.ReplaceHighlightedText(text3);
			string vietPhraseValueFromKey = TranslatorEngine.GetVietPhraseValueFromKey(array[2].Trim());
			string[] array2 = ((vietPhraseValueFromKey == null) ? string.Empty : vietPhraseValueFromKey).Split("/|".ToCharArray());
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(text);
			foreach (string text4 in array2)
			{
				if (!text4.Equals(text))
				{
					stringBuilder.Append("/");
					stringBuilder.Append(text4);
				}
			}
			TranslatorEngine.UpdateVietPhraseDictionary(array[2], stringBuilder.ToString().TrimEnd("/".ToCharArray()), false);
			this.vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Hide();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000BEE0 File Offset: 0x0000AEE0
		private CharRange getHanVietCharRangeFromChineseRange(int chineseStartIndex, int chineseLength)
		{
			int startIndex = this.chineseHanVietMappingArray[chineseStartIndex].StartIndex;
			int length = this.chineseHanVietMappingArray[chineseStartIndex + chineseLength - 1].GetEndIndex() - startIndex + 1;
			return new CharRange(startIndex, length);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000BF18 File Offset: 0x0000AF18
		private CharRange getChineseCharRangeFromVietPhraseIndex(int vietPhraseStartIndex)
		{
			int num = this.findVietPhraseMappingId(vietPhraseStartIndex);
			if (num < 0 || this.chinesePhraseRanges == null || this.chinesePhraseRanges.Length <= num)
			{
				return null;
			}
			return this.chinesePhraseRanges[num];
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000BF50 File Offset: 0x0000AF50
		private CharRange getVietPhraseCharRangeFromChineseIndex(int chineseStartIndex)
		{
			if (this.vietPhraseDocumentPanel.IsHidden)
			{
				return null;
			}
			int num = this.findChineseMappingId(chineseStartIndex);
			if (num < 0 || this.vietPhraseRanges == null || this.vietPhraseRanges.Length <= num)
			{
				return null;
			}
			return this.vietPhraseRanges[num];
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000BF98 File Offset: 0x0000AF98
		private CharRange getChineseCharRangeFromVietPhraseOneMeaningIndex(int vietPhraseStartIndex)
		{
			int num = this.findVietPhraseOneMeaningMappingId(vietPhraseStartIndex);
			if (num < 0 || this.chinesePhraseRanges == null || this.chinesePhraseRanges.Length <= num)
			{
				return null;
			}
			return this.chinesePhraseRanges[num];
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000BFD0 File Offset: 0x0000AFD0
		private CharRange getVietPhraseOneMeaningCharRangeFromChineseIndex(int chineseStartIndex)
		{
			if (this.vietPhraseOneMeaningDocumentPanel.IsHidden)
			{
				return null;
			}
			int num = this.findChineseMappingId(chineseStartIndex);
			if (num < 0 || this.vietPhraseOneMeaningRanges == null || this.vietPhraseOneMeaningRanges.Length <= num)
			{
				return null;
			}
			return this.vietPhraseOneMeaningRanges[num];
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000C018 File Offset: 0x0000B018
		private int findVietPhraseMappingId(int currentCharIndex)
		{
			int result = -1;
			for (int i = 0; i < this.vietPhraseRanges.Length; i++)
			{
				CharRange charRange = this.vietPhraseRanges[i];
				if (charRange.StartIndex <= currentCharIndex && currentCharIndex <= charRange.GetEndIndex())
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000C05C File Offset: 0x0000B05C
		private int findVietPhraseOneMeaningMappingId(int currentCharIndex)
		{
			int result = -1;
			for (int i = 0; i < this.vietPhraseOneMeaningRanges.Length; i++)
			{
				CharRange charRange = this.vietPhraseOneMeaningRanges[i];
				if (charRange.StartIndex <= currentCharIndex && currentCharIndex <= charRange.GetEndIndex())
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000C0A0 File Offset: 0x0000B0A0
		private int findChineseMappingId(int currentCharIndex)
		{
			int result = -1;
			for (int i = 0; i < this.chinesePhraseRanges.Length; i++)
			{
				CharRange charRange = this.chinesePhraseRanges[i];
				if (charRange.StartIndex <= currentCharIndex && currentCharIndex <= charRange.GetEndIndex())
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000C0E4 File Offset: 0x0000B0E4
		private void VietPhraseRightClick(int currentCharIndex)
		{
			if (this.vietPhraseDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
			{
				return;
			}
			int num = this.findVietPhraseMappingId(currentCharIndex);
			if (num < 0)
			{
				return;
			}
			string textContent = this.vietPhraseDocumentPanel.GetTextContent();
			textContent.Substring(this.vietPhraseRanges[num].StartIndex, this.vietPhraseRanges[num].Length);
			int num2 = currentCharIndex;
			int num3 = this.vietPhraseRanges[num].GetEndIndex();
			int num4 = currentCharIndex;
			while (this.vietPhraseRanges[num].StartIndex <= num4)
			{
				if (textContent[num4] == '[' || textContent[num4] == '/' || textContent[num4] == '|')
				{
					num2 = num4 + 1;
					break;
				}
				num2 = num4;
				num4--;
			}
			for (int i = currentCharIndex + 1; i <= this.vietPhraseRanges[num].GetEndIndex(); i++)
			{
				if (textContent[i] == ']' || textContent[i] == '/' || textContent[i] == '|')
				{
					num3 = i - 1;
					break;
				}
				num3 = i;
			}
			string text = textContent.Substring(num2, num3 - num2 + 1);
			if (!text.Contains("[") && !text.Contains("]") && !text.Contains("/") && !text.Contains("|"))
			{
				this.appendToVietToCurrentCursor(text);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000C238 File Offset: 0x0000B238
		private void VietPhraseOneMeaningRightClick(int currentCharIndex)
		{
			if (this.vietPhraseOneMeaningDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
			{
				return;
			}
			int num = this.findVietPhraseOneMeaningMappingId(currentCharIndex);
			if (num < 0)
			{
				return;
			}
			string textContent = this.vietPhraseOneMeaningDocumentPanel.GetTextContent();
			string text = textContent.Substring(this.vietPhraseOneMeaningRanges[num].StartIndex, this.vietPhraseOneMeaningRanges[num].Length);
			this.appendToVietToCurrentCursor(text.Trim(new char[]
			{
				'[',
				']'
			}));
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000C2B4 File Offset: 0x0000B2B4
		private void HanVietRightClick(int currentCharIndex)
		{
			if (this.hanVietDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
			{
				return;
			}
			int num = currentCharIndex;
			int num2 = currentCharIndex;
			string textContent = this.hanVietDocumentPanel.GetTextContent();
			int num3 = currentCharIndex;
			while (0 <= num3)
			{
				if (textContent[num3] == ' ' || textContent[num3] == '\n')
				{
					num = num3 + 1;
					break;
				}
				num3--;
			}
			for (int i = currentCharIndex + 1; i < textContent.Length; i++)
			{
				if (textContent[i] == ' ' || textContent[i] == ';' || textContent[i] == '?' || textContent[i] == '!' || textContent[i] == ',' || textContent[i] == '.')
				{
					num2 = i - 1;
					break;
				}
			}
			string text = textContent.Substring(num, num2 - num + 1);
			this.appendToVietToCurrentCursor(text);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000C38C File Offset: 0x0000B38C
		private void appendToViet(string text)
		{
			if (text.Length == 0)
			{
				return;
			}
			string textContent = this.vietDocumentPanel.GetTextContent();
			if (textContent.Length <= 1)
			{
				this.vietDocumentPanel.AppendText(this.capitalize(text));
			}
			else if (textContent.EndsWith("! ") || textContent.EndsWith(". ") || (textContent.EndsWith("? ") | textContent.EndsWith(": ")) || textContent.EndsWith("; ") || textContent.EndsWith(") ") || textContent.EndsWith("\" ") || textContent.EndsWith("\"") || textContent.EndsWith("' ") || textContent.EndsWith("\n"))
			{
				this.vietDocumentPanel.AppendText(this.capitalize(text));
			}
			else if (textContent.EndsWith("!") || textContent.EndsWith(".") || textContent.EndsWith("?"))
			{
				this.vietDocumentPanel.AppendText(" " + this.capitalize(text));
			}
			else
			{
				if (!textContent.EndsWith(" "))
				{
					this.vietDocumentPanel.AppendText(" ");
				}
				this.vietDocumentPanel.AppendText(text);
			}
			if (MainForm.ActiveConfiguration.AlwaysFocusInViet)
			{
				this.vietDocumentPanel.FocusInRichTextBox();
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000C4E8 File Offset: 0x0000B4E8
		private void appendToVietToCurrentCursor(string text)
		{
			if (text.Length == 0)
			{
				return;
			}
			string text2 = "";
			string textContent = this.vietDocumentPanel.GetTextContent();
			string twoCharsBeforeSelectedText = this.vietDocumentPanel.GetTwoCharsBeforeSelectedText();
			string twoCharsAfterSelectedText = this.vietDocumentPanel.GetTwoCharsAfterSelectedText();
			if (textContent.Length <= 1)
			{
				text2 = this.capitalize(text);
			}
			else if (twoCharsBeforeSelectedText.EndsWith("! ") || twoCharsBeforeSelectedText.EndsWith(". ") || (twoCharsBeforeSelectedText.EndsWith("? ") | twoCharsBeforeSelectedText.EndsWith(": ")) || twoCharsBeforeSelectedText.EndsWith("; ") || twoCharsBeforeSelectedText.EndsWith(") ") || twoCharsBeforeSelectedText.EndsWith("\" ") || twoCharsBeforeSelectedText.EndsWith("' ") || twoCharsBeforeSelectedText.EndsWith("\n"))
			{
				text2 = this.capitalize(text);
			}
			else if (twoCharsBeforeSelectedText.EndsWith("!") || twoCharsBeforeSelectedText.EndsWith(".") || twoCharsBeforeSelectedText.EndsWith("?") || twoCharsBeforeSelectedText.EndsWith("!\"") || twoCharsBeforeSelectedText.EndsWith(".\"") || twoCharsBeforeSelectedText.EndsWith("?\""))
			{
				text2 = " " + this.capitalize(text);
			}
			else if (twoCharsBeforeSelectedText.EndsWith("\""))
			{
				text2 = this.capitalize(text);
			}
			else if (twoCharsBeforeSelectedText.EndsWith(" "))
			{
				text2 = text.TrimStart(new char[0]);
			}
			else if (text2.TrimStart(new char[0]).StartsWith(":") || text2.TrimStart(new char[0]).StartsWith("?") || text2.TrimStart(new char[0]).StartsWith("!") || text2.TrimStart(new char[0]).StartsWith(";") || text2.TrimStart(new char[0]).StartsWith(".") || text2.TrimStart(new char[0]).StartsWith(","))
			{
				text2 = text.TrimStart(new char[0]);
			}
			else
			{
				text2 = " " + text.TrimStart(new char[0]);
			}
			if (twoCharsAfterSelectedText.StartsWith(".") || twoCharsAfterSelectedText.StartsWith("?") || twoCharsAfterSelectedText.StartsWith(" ") || twoCharsAfterSelectedText.StartsWith("!") || twoCharsAfterSelectedText.StartsWith("\n") || twoCharsAfterSelectedText.StartsWith(";") || twoCharsAfterSelectedText.StartsWith(":") || twoCharsAfterSelectedText.StartsWith("\"") || twoCharsAfterSelectedText.StartsWith(",") || twoCharsAfterSelectedText.StartsWith("'"))
			{
				text2 = text2.TrimEnd(new char[0]);
			}
			else if (twoCharsAfterSelectedText.Equals(""))
			{
				text2 = " " + text2.Trim();
			}
			else
			{
				text2 = text2.TrimEnd(new char[0]) + " ";
			}
			if (text2.Trim().StartsWith(".") || text2.Trim().StartsWith(":") || text2.Trim().StartsWith(";") || text2.Trim().StartsWith(",") || text2.Trim().StartsWith("?") || text2.Trim().StartsWith("!") || twoCharsBeforeSelectedText.EndsWith("\n") || twoCharsBeforeSelectedText.EndsWith(" ") || twoCharsBeforeSelectedText.EndsWith(" \""))
			{
				text2 = text2.TrimStart(new char[0]);
			}
			this.vietDocumentPanel.AppendTextToCurrentCursor(text2);
			if (MainForm.ActiveConfiguration.AlwaysFocusInViet)
			{
				this.vietDocumentPanel.FocusInRichTextBox();
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000C8A4 File Offset: 0x0000B8A4
		private string capitalize(string text)
		{
			if (1 >= text.Length)
			{
				return char.ToUpper(text[0]).ToString();
			}
			return char.ToUpper(text[0]) + text.Substring(1);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000C8EC File Offset: 0x0000B8EC
		private void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			string text = null;
			switch (e.KeyCode)
			{
			case Keys.F1:
				text = MainForm.ActiveConfiguration.HotKeys_F1;
				break;
			case Keys.F2:
				text = MainForm.ActiveConfiguration.HotKeys_F2;
				break;
			case Keys.F3:
				text = MainForm.ActiveConfiguration.HotKeys_F3;
				break;
			case Keys.F4:
				text = MainForm.ActiveConfiguration.HotKeys_F4;
				break;
			case Keys.F5:
				text = MainForm.ActiveConfiguration.HotKeys_F5;
				break;
			case Keys.F6:
				text = MainForm.ActiveConfiguration.HotKeys_F6;
				break;
			case Keys.F7:
				text = MainForm.ActiveConfiguration.HotKeys_F7;
				break;
			case Keys.F8:
				text = MainForm.ActiveConfiguration.HotKeys_F8;
				break;
			case Keys.F9:
				text = MainForm.ActiveConfiguration.HotKeys_F9;
				break;
			}
			if (text != null)
			{
				this.appendToVietToCurrentCursor(text);
				if (MainForm.ActiveConfiguration.AlwaysFocusInViet)
				{
					this.vietDocumentPanel.FocusInRichTextBox();
				}
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000C9D0 File Offset: 0x0000B9D0
		private void copyMeaning(int meaningIndex)
		{
			string highlightText = this.vietPhraseDocumentPanel.GetHighlightText();
			if (string.IsNullOrEmpty(highlightText))
			{
				return;
			}
			string[] array = highlightText.Split(new char[]
			{
				'[',
				'/',
				']'
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 0)
			{
				return;
			}
			int num = meaningIndex;
			if (array.Length < meaningIndex)
			{
				num = array.Length;
			}
			int currentCharIndex = this.vietPhraseDocumentPanel.CurrentHighlightedTextStartIndex + highlightText.IndexOf(array[num - 1]);
			this.VietPhraseRightClick(currentCharIndex);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000CA3C File Offset: 0x0000BA3C
		private void AutoScrollToolStripButtonClick(object sender, EventArgs e)
		{
			try
			{
				int physicalLine = this.countPhysicalLines(this.vietDocumentPanel.GetTextContent());
				this.chineseDocumentPanel.ScrollToASpecificPhysicalLine(physicalLine);
				this.hanVietDocumentPanel.ScrollToASpecificPhysicalLine(physicalLine);
				this.vietPhraseDocumentPanel.ScrollToASpecificPhysicalLine(physicalLine);
				this.vietPhraseOneMeaningDocumentPanel.ScrollToASpecificPhysicalLine(physicalLine);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000CAA0 File Offset: 0x0000BAA0
		private int countPhysicalLines(string text)
		{
			return text.Split(new char[]
			{
				'\n'
			}).Length;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000CAC4 File Offset: 0x0000BAC4
		private void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			string str = this.isNewTranslationWork ? "Untitled" : Path.GetFileName(this.workingFilePath);
			DialogResult dialogResult = MessageBox.Show("Do you want to save the changes to " + str + "?", "Quick Translator", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			if (dialogResult == DialogResult.Yes)
			{
				this.SaveToolStripMenuItemClick(null, null);
				return;
			}
			if (dialogResult == DialogResult.Cancel)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000CB23 File Offset: 0x0000BB23
		private void ReloadDictToolStripButtonClick(object sender, EventArgs e)
		{
			TranslatorEngine.DictionaryDirty = true;
			TranslatorEngine.LoadDictionaries();
			Shortcuts.LoadFromFile(MainForm.shortcutDictionaryFilePath);
			this.Retranslate();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000CB40 File Offset: 0x0000BB40
		private void PostTTVToolStripButtonClick(object sender, EventArgs e)
		{
			using (PostTTVForm postTTVForm = new PostTTVForm(this.vietDocumentPanel.GetTextContent(), this.hanVietDocumentPanel.GetTextContent(), this.vietPhraseOneMeaningDocumentPanel.GetTextContent(), this.chineseDocumentPanel.GetTextContent(), this.editingStartDateTime))
			{
				postTTVForm.ShowDialog();
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000CBA8 File Offset: 0x0000BBA8
		private void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			this.dockPanel.SaveAsXml(MainForm.dockPanelConfigFilePath);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000CBBC File Offset: 0x0000BBBC
		private IDockContent GetContentFromPersistString(string persistString)
		{
			if (persistString == "Hán Việt")
			{
				return this.hanVietDocumentPanel;
			}
			if (persistString == "Trung")
			{
				return this.chineseDocumentPanel;
			}
			if (persistString == "VietPhrase")
			{
				return this.vietPhraseDocumentPanel;
			}
			if (persistString == "VietPhrase một nghĩa")
			{
				return this.vietPhraseOneMeaningDocumentPanel;
			}
			if (persistString == "Nghĩa")
			{
				return this.meaningDocumentPanel;
			}
			if (persistString == "Việt")
			{
				return this.vietDocumentPanel;
			}
			if (persistString == "Configuration")
			{
				return this.configurationPanel;
			}
			if (persistString == "Quick Web Browser")
			{
				return this.extendedBrowserPanel;
			}
			return this.vietDocumentPanel;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000CC6F File Offset: 0x0000BC6F
		private void UpdateVietPhraseToolStripButtonClick(object sender, EventArgs e)
		{
			this.updateVietPhraseOrName(0);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000CC78 File Offset: 0x0000BC78
		private void updateVietPhraseOrName(int type)
		{
			int selectionStart = this.chineseDocumentPanel.getSelectionStart();
			string textContent = this.chineseDocumentPanel.GetTextContent();
			int num = 10;
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = 0;
			while (num2 < num && textContent.Length - 1 >= selectionStart + num2 && textContent[selectionStart + num2] != '\n')
			{
				stringBuilder.Append(textContent[selectionStart + num2]);
				num2++;
			}
			UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(stringBuilder.ToString(), type);
			updateVietPhraseForm.ShowDialog();
			if (updateVietPhraseForm.NeedSurfBaike)
			{
				string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
				this.extendedBrowserPanel.Baikeing(chinese);
				this.extendedBrowserPanel.Activate();
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000CD32 File Offset: 0x0000BD32
		private void UpdateNameToolStripButtonClick(object sender, EventArgs e)
		{
			this.updateVietPhraseOrName(1);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000CD3C File Offset: 0x0000BD3C
		private void NewWindowToolStripMenuItemClick(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ThreadStart(this.newWindow));
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000CD68 File Offset: 0x0000BD68
		private void newWindow()
		{
			Application.Run(new MainForm());
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000CD74 File Offset: 0x0000BD74
		private void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Quick Translator or Word (*.qt; *.doc)|*.qt;*.doc|All (*.*)|*.*";
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			string content;
			using (TextReader textReader = new StreamReader(openFileDialog.FileName, true))
			{
				content = textReader.ReadToEnd();
			}
			string fileName = openFileDialog.FileName;
			if (fileName.EndsWith(".qt") || fileName.EndsWith(".doc"))
			{
				this.OpenQtOrWordFile(content, fileName);
			}
			else
			{
				this.OpenOtherFile(fileName);
			}
			this.workingFilePath = fileName;
			this.toggleNextBackButtons();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000CE14 File Offset: 0x0000BE14
		private void OpenQtOrWordFile(string content, string filePath)
		{
			int currentHanVietDisplayedLine = -1;
			int currentVietPhraseDisplayedLine = -1;
			int currentVietPhraseOneMeaningDisplayedLine = -1;
			string original;
			string rftContent;
			if (filePath.EndsWith(".qt"))
			{
				if (content.Contains("[CurrentLines]\n"))
				{
					string text = content.Substring("[CurrentLines]\n".Length, content.IndexOf("[Chinese]\n") - "[CurrentLines]\n".Length);
					try
					{
						currentHanVietDisplayedLine = int.Parse(text.Split(new char[]
						{
							'\n'
						})[0]);
						currentVietPhraseDisplayedLine = int.Parse(text.Split(new char[]
						{
							'\n'
						})[1]);
						currentVietPhraseOneMeaningDisplayedLine = int.Parse(text.Split(new char[]
						{
							'\n'
						})[2]);
					}
					catch
					{
					}
				}
				original = content.Substring(content.IndexOf("[Chinese]\n") + "[Chinese]\n".Length, content.IndexOf("[Viet]\n") - content.IndexOf("[Chinese]\n") - "[Chinese]\n".Length);
				rftContent = content.Substring(content.IndexOf("[Viet]\n") + "[Viet]\n".Length);
			}
			else
			{
				try
				{
					ColumnExporter.ExtractFromWord(File.ReadAllText(filePath), out original, out rftContent);
				}
				catch (Exception exception)
				{
					MessageBox.Show("Định dạng của file không đúng!");
					string application = "QuickTranslator";
					ApplicationLog.Log(Path.GetDirectoryName(Application.ExecutablePath), application, exception);
					return;
				}
			}
			this.chineseDocumentPanel.SetTextContent(TranslatorEngine.StandardizeInput(original));
			this.vietDocumentPanel.SetRftContent(rftContent);
			this.vietDocumentPanel.AppendText("");
			this.vietDocumentPanel.ScrollToBottom();
			this.vietDocumentPanel.FocusInRichTextBox();
			if (string.IsNullOrEmpty(this.vietDocumentPanel.GetTextContent().Trim()))
			{
				this.Translate(currentHanVietDisplayedLine, currentVietPhraseDisplayedLine, currentVietPhraseOneMeaningDisplayedLine);
			}
			else
			{
				this.Translate(-1, -1, -1);
			}
			this.Text = "Quick Translator - " + filePath;
			this.workingFilePath = filePath;
			this.isNewTranslationWork = false;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000D018 File Offset: 0x0000C018
		private void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.isNewTranslationWork)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.CheckFileExists = false;
				saveFileDialog.Filter = "Quick Translator (*.qt)|*.qt|Microsoft Word (*.doc)|*.doc";
				DialogResult dialogResult = saveFileDialog.ShowDialog();
				if (dialogResult != DialogResult.OK)
				{
					return;
				}
				this.workingFilePath = saveFileDialog.FileName;
			}
			if (this.workingFilePath.EndsWith(".qt"))
			{
				using (TextWriter textWriter = new StreamWriter(this.workingFilePath, false, Encoding.UTF8))
				{
					textWriter.Write("[CurrentLines]\n");
					textWriter.Write(this.hanVietDocumentPanel.getCurrentLineIndex() + "\n");
					textWriter.Write(this.vietPhraseDocumentPanel.getCurrentLineIndex() + "\n");
					textWriter.Write(this.vietPhraseOneMeaningDocumentPanel.getCurrentLineIndex() + "\n");
					textWriter.Write("[Chinese]\n");
					textWriter.Write(this.chineseDocumentPanel.GetTextContent());
					if (!this.chineseDocumentPanel.GetTextContent().EndsWith("\n"))
					{
						textWriter.Write("\n");
					}
					textWriter.Write("[Viet]\n");
					textWriter.Write(this.vietDocumentPanel.GetRtfContent());
					goto IL_18B;
				}
			}
			using (ExportToWordForm exportToWordForm = new ExportToWordForm(this.chineseDocumentPanel.GetTextContent(), this.hanVietDocumentPanel.GetTextContent(), this.vietPhraseDocumentPanel.GetTextContent(), this.vietPhraseOneMeaningDocumentPanel.GetTextContent(), this.vietDocumentPanel.GetTextContent()))
			{
				exportToWordForm.PopulateControls();
				exportToWordForm.ExportToWord(this.workingFilePath);
			}
			IL_18B:
			this.Text = "Quick Translator - " + this.workingFilePath;
			this.isNewTranslationWork = false;
			this.toggleNextBackButtons();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000D1F0 File Offset: 0x0000C1F0
		private void ExportToWordToolStripMenuItemClick(object sender, EventArgs e)
		{
			using (ExportToWordForm exportToWordForm = new ExportToWordForm(this.chineseDocumentPanel.GetTextContent(), this.hanVietDocumentPanel.GetTextContent(), this.vietPhraseDocumentPanel.GetTextContent(), this.vietPhraseOneMeaningDocumentPanel.GetTextContent(), this.vietDocumentPanel.GetTextContent()))
			{
				exportToWordForm.ShowDialog();
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000D260 File Offset: 0x0000C260
		private void Chinese_AddToVietPhraseHandler(int type)
		{
			UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(this.chineseDocumentPanel.GetSelectedText(), type);
			updateVietPhraseForm.ShowDialog();
			if (updateVietPhraseForm.NeedSurfBaike)
			{
				string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
				this.extendedBrowserPanel.Baikeing(chinese);
				this.extendedBrowserPanel.Activate();
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000D2BC File Offset: 0x0000C2BC
		private void HanViet_AddToVietPhraseHandler(int type)
		{
			int selectionStart = this.hanVietDocumentPanel.getSelectionStart();
			int num = this.findChineseCharIndexFromHanVietIndex(selectionStart);
			if (num <= 0)
			{
				num = this.findChineseCharIndexFromHanVietIndex(selectionStart + 1);
			}
			if (num <= 0)
			{
				return;
			}
			int num2 = this.hanVietDocumentPanel.getSelectionStart() + this.hanVietDocumentPanel.getSelectionLength() - 1;
			int num3 = this.findChineseCharIndexFromHanVietIndex(num2);
			if (num3 <= 0)
			{
				num3 = this.findChineseCharIndexFromHanVietIndex(num2 - 1);
			}
			if (num3 <= 0 || num3 < num)
			{
				return;
			}
			string chineseToLookup = this.chineseDocumentPanel.GetTextContent().Substring(num, num3 - num + 1);
			UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(chineseToLookup, type);
			updateVietPhraseForm.ShowDialog();
			if (updateVietPhraseForm.NeedSurfBaike)
			{
				string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
				this.extendedBrowserPanel.Baikeing(chinese);
				this.extendedBrowserPanel.Activate();
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000D38C File Offset: 0x0000C38C
		private int getChineseStartIndexFromVietPhraseIndex(int vietPhraseIndex)
		{
			CharRange chineseCharRangeFromVietPhraseIndex = this.getChineseCharRangeFromVietPhraseIndex(vietPhraseIndex);
			if (chineseCharRangeFromVietPhraseIndex == null)
			{
				return 0;
			}
			return chineseCharRangeFromVietPhraseIndex.StartIndex;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000D3AC File Offset: 0x0000C3AC
		private int getChineseEndIndexFromVietPhraseIndex(int vietPhraseIndex)
		{
			CharRange chineseCharRangeFromVietPhraseIndex = this.getChineseCharRangeFromVietPhraseIndex(vietPhraseIndex);
			if (chineseCharRangeFromVietPhraseIndex == null)
			{
				return 0;
			}
			return chineseCharRangeFromVietPhraseIndex.GetEndIndex();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000D3CC File Offset: 0x0000C3CC
		private void VietPhrase_AddToVietPhraseHandler(int type)
		{
			int selectionStart = this.vietPhraseDocumentPanel.getSelectionStart();
			int chineseStartIndexFromVietPhraseIndex = this.getChineseStartIndexFromVietPhraseIndex(selectionStart);
			if (chineseStartIndexFromVietPhraseIndex <= 0)
			{
				chineseStartIndexFromVietPhraseIndex = this.getChineseStartIndexFromVietPhraseIndex(selectionStart + 1);
			}
			if (chineseStartIndexFromVietPhraseIndex <= 0)
			{
				return;
			}
			int num = this.vietPhraseDocumentPanel.getSelectionStart() + this.vietPhraseDocumentPanel.getSelectionLength() - 1;
			int chineseEndIndexFromVietPhraseIndex = this.getChineseEndIndexFromVietPhraseIndex(num);
			if (chineseEndIndexFromVietPhraseIndex <= 0)
			{
				chineseEndIndexFromVietPhraseIndex = this.getChineseEndIndexFromVietPhraseIndex(num - 1);
			}
			if (chineseEndIndexFromVietPhraseIndex <= 0 || chineseEndIndexFromVietPhraseIndex < chineseStartIndexFromVietPhraseIndex)
			{
				return;
			}
			string chineseToLookup = this.chineseDocumentPanel.GetTextContent().Substring(chineseStartIndexFromVietPhraseIndex, chineseEndIndexFromVietPhraseIndex - chineseStartIndexFromVietPhraseIndex + 1);
			UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(chineseToLookup, type);
			updateVietPhraseForm.ShowDialog();
			if (updateVietPhraseForm.NeedSurfBaike)
			{
				string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
				this.extendedBrowserPanel.Baikeing(chinese);
				this.extendedBrowserPanel.Activate();
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000D49C File Offset: 0x0000C49C
		private int getChineseStartIndexFromVietPhraseOneMeaningIndex(int vietPhraseOneMeaningIndex)
		{
			CharRange chineseCharRangeFromVietPhraseOneMeaningIndex = this.getChineseCharRangeFromVietPhraseOneMeaningIndex(vietPhraseOneMeaningIndex);
			if (chineseCharRangeFromVietPhraseOneMeaningIndex == null)
			{
				return 0;
			}
			return chineseCharRangeFromVietPhraseOneMeaningIndex.StartIndex;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000D4BC File Offset: 0x0000C4BC
		private int getChineseEndIndexFromVietPhraseOneMeaningIndex(int vietPhraseOneMeaningEndIndex)
		{
			CharRange chineseCharRangeFromVietPhraseOneMeaningIndex = this.getChineseCharRangeFromVietPhraseOneMeaningIndex(vietPhraseOneMeaningEndIndex);
			if (chineseCharRangeFromVietPhraseOneMeaningIndex == null)
			{
				return 0;
			}
			return chineseCharRangeFromVietPhraseOneMeaningIndex.GetEndIndex();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000D4DC File Offset: 0x0000C4DC
		private void VietPhraseOneMeaning_AddToVietPhraseHandler(int type)
		{
			int selectionStart = this.vietPhraseOneMeaningDocumentPanel.getSelectionStart();
			int chineseStartIndexFromVietPhraseOneMeaningIndex = this.getChineseStartIndexFromVietPhraseOneMeaningIndex(selectionStart);
			if (chineseStartIndexFromVietPhraseOneMeaningIndex <= 0)
			{
				chineseStartIndexFromVietPhraseOneMeaningIndex = this.getChineseStartIndexFromVietPhraseOneMeaningIndex(selectionStart + 1);
			}
			if (chineseStartIndexFromVietPhraseOneMeaningIndex <= 0)
			{
				return;
			}
			int num = this.vietPhraseOneMeaningDocumentPanel.getSelectionStart() + this.vietPhraseOneMeaningDocumentPanel.getSelectionLength() - 1;
			int chineseEndIndexFromVietPhraseOneMeaningIndex = this.getChineseEndIndexFromVietPhraseOneMeaningIndex(num);
			if (chineseEndIndexFromVietPhraseOneMeaningIndex <= 0)
			{
				chineseEndIndexFromVietPhraseOneMeaningIndex = this.getChineseEndIndexFromVietPhraseOneMeaningIndex(num - 1);
			}
			if (chineseEndIndexFromVietPhraseOneMeaningIndex <= 0 || chineseEndIndexFromVietPhraseOneMeaningIndex < chineseStartIndexFromVietPhraseOneMeaningIndex)
			{
				return;
			}
			string chineseToLookup = this.chineseDocumentPanel.GetTextContent().Substring(chineseStartIndexFromVietPhraseOneMeaningIndex, chineseEndIndexFromVietPhraseOneMeaningIndex - chineseStartIndexFromVietPhraseOneMeaningIndex + 1);
			UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(chineseToLookup, type);
			updateVietPhraseForm.ShowDialog();
			if (updateVietPhraseForm.NeedSurfBaike)
			{
				string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
				this.extendedBrowserPanel.Baikeing(chinese);
				this.extendedBrowserPanel.Activate();
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000D5AC File Offset: 0x0000C5AC
		private void Meaning_AddToVietPhraseHandler(int type)
		{
			string selectedText = this.meaningDocumentPanel.GetSelectedText();
			UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(selectedText, type);
			updateVietPhraseForm.ShowDialog();
			if (updateVietPhraseForm.NeedSurfBaike)
			{
				string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
				this.extendedBrowserPanel.Baikeing(chinese);
				this.extendedBrowserPanel.Activate();
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000D60C File Offset: 0x0000C60C
		private void Chinese_SelectTextHandler()
		{
			int selectionStart = this.chineseDocumentPanel.getSelectionStart();
			int selectionLength = this.chineseDocumentPanel.getSelectionLength();
			this.SelectTextInHanViet(selectionStart, selectionLength);
			this.SelectTextInVietPhrase(selectionStart, selectionLength);
			this.SelectTextInVietPhraseOneMeaning(selectionStart, selectionLength);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000D64C File Offset: 0x0000C64C
		private void HanViet_SelectTextHandler()
		{
			int selectionStart = this.hanVietDocumentPanel.getSelectionStart();
			int num = this.findChineseCharIndexFromHanVietIndex(selectionStart);
			if (num <= 0)
			{
				num = this.findChineseCharIndexFromHanVietIndex(selectionStart + 1);
			}
			if (num <= 0)
			{
				return;
			}
			int num2 = this.hanVietDocumentPanel.getSelectionStart() + this.hanVietDocumentPanel.getSelectionLength() - 1;
			int num3 = this.findChineseCharIndexFromHanVietIndex(num2);
			if (num3 <= 0)
			{
				num3 = this.findChineseCharIndexFromHanVietIndex(num2 - 1);
			}
			if (num3 <= 0 || num3 < num)
			{
				return;
			}
			this.SelectTextInChinese(num, num3 - num + 1);
			this.SelectTextInVietPhrase(num, num3 - num + 1);
			this.SelectTextInVietPhraseOneMeaning(num, num3 - num + 1);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000D6E0 File Offset: 0x0000C6E0
		private void VietPhrase_SelectTextHandler()
		{
			int selectionStart = this.vietPhraseDocumentPanel.getSelectionStart();
			CharRange chineseCharRangeFromVietPhraseIndex = this.getChineseCharRangeFromVietPhraseIndex(selectionStart);
			if (chineseCharRangeFromVietPhraseIndex == null)
			{
				chineseCharRangeFromVietPhraseIndex = this.getChineseCharRangeFromVietPhraseIndex(selectionStart + 1);
			}
			if (chineseCharRangeFromVietPhraseIndex == null)
			{
				return;
			}
			int startIndex = chineseCharRangeFromVietPhraseIndex.StartIndex;
			int num = this.vietPhraseDocumentPanel.getSelectionStart() + this.vietPhraseDocumentPanel.getSelectionLength() - 1;
			if (this.getChineseCharRangeFromVietPhraseIndex(num) == null)
			{
				return;
			}
			int endIndex = this.getChineseCharRangeFromVietPhraseIndex(num).GetEndIndex();
			if (endIndex <= 0)
			{
				endIndex = this.getChineseCharRangeFromVietPhraseIndex(num - 1).GetEndIndex();
				if (this.getChineseCharRangeFromVietPhraseIndex(num - 1) == null)
				{
					return;
				}
			}
			if (endIndex <= 0 || endIndex < startIndex)
			{
				return;
			}
			this.SelectTextInChinese(startIndex, endIndex - startIndex + 1);
			this.SelectTextInHanViet(startIndex, endIndex - startIndex + 1);
			this.SelectTextInVietPhraseOneMeaning(startIndex, endIndex - startIndex + 1);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000D7A0 File Offset: 0x0000C7A0
		private void VietPhraseOneMeaning_SelectTextHandler()
		{
			int selectionStart = this.vietPhraseOneMeaningDocumentPanel.getSelectionStart();
			CharRange chineseCharRangeFromVietPhraseOneMeaningIndex = this.getChineseCharRangeFromVietPhraseOneMeaningIndex(selectionStart);
			if (chineseCharRangeFromVietPhraseOneMeaningIndex == null)
			{
				chineseCharRangeFromVietPhraseOneMeaningIndex = this.getChineseCharRangeFromVietPhraseOneMeaningIndex(selectionStart + 1);
			}
			if (chineseCharRangeFromVietPhraseOneMeaningIndex == null)
			{
				return;
			}
			int startIndex = chineseCharRangeFromVietPhraseOneMeaningIndex.StartIndex;
			int num = this.vietPhraseOneMeaningDocumentPanel.getSelectionStart() + this.vietPhraseOneMeaningDocumentPanel.getSelectionLength() - 1;
			CharRange chineseCharRangeFromVietPhraseOneMeaningIndex2 = this.getChineseCharRangeFromVietPhraseOneMeaningIndex(num);
			if (chineseCharRangeFromVietPhraseOneMeaningIndex2 == null)
			{
				chineseCharRangeFromVietPhraseOneMeaningIndex2 = this.getChineseCharRangeFromVietPhraseOneMeaningIndex(num - 1);
			}
			if (chineseCharRangeFromVietPhraseOneMeaningIndex2 == null)
			{
				return;
			}
			int endIndex = chineseCharRangeFromVietPhraseOneMeaningIndex2.GetEndIndex();
			if (endIndex <= 0 || endIndex < startIndex)
			{
				return;
			}
			this.SelectTextInChinese(startIndex, endIndex - startIndex + 1);
			this.SelectTextInVietPhrase(startIndex, endIndex - startIndex + 1);
			this.SelectTextInHanViet(startIndex, endIndex - startIndex + 1);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000D84C File Offset: 0x0000C84C
		private void SelectTextInHanViet(int chineseStartIndex, int chineseLength)
		{
			CharRange hanVietCharRangeFromChineseRange = this.getHanVietCharRangeFromChineseRange(chineseStartIndex, chineseLength);
			this.hanVietDocumentPanel.SelectText(hanVietCharRangeFromChineseRange.StartIndex, hanVietCharRangeFromChineseRange.Length);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000D879 File Offset: 0x0000C879
		private void SelectTextInChinese(int chineseStartIndex, int chineseLength)
		{
			this.chineseDocumentPanel.SelectText(chineseStartIndex, chineseLength);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000D888 File Offset: 0x0000C888
		private void SelectTextInVietPhrase(int chineseStartIndex, int chineseLength)
		{
			if (this.vietPhraseDocumentPanel.IsHidden)
			{
				return;
			}
			CharRange vietPhraseCharRangeFromChineseIndex = this.getVietPhraseCharRangeFromChineseIndex(chineseStartIndex);
			CharRange vietPhraseCharRangeFromChineseIndex2 = this.getVietPhraseCharRangeFromChineseIndex(chineseStartIndex + chineseLength - 1);
			this.vietPhraseDocumentPanel.SelectText(vietPhraseCharRangeFromChineseIndex.StartIndex, vietPhraseCharRangeFromChineseIndex2.GetEndIndex() - vietPhraseCharRangeFromChineseIndex.StartIndex + 1);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000D8D8 File Offset: 0x0000C8D8
		private void SelectTextInVietPhraseOneMeaning(int chineseStartIndex, int chineseLength)
		{
			if (this.vietPhraseOneMeaningDocumentPanel.IsHidden)
			{
				return;
			}
			CharRange vietPhraseOneMeaningCharRangeFromChineseIndex = this.getVietPhraseOneMeaningCharRangeFromChineseIndex(chineseStartIndex);
			CharRange vietPhraseOneMeaningCharRangeFromChineseIndex2 = this.getVietPhraseOneMeaningCharRangeFromChineseIndex(chineseStartIndex + chineseLength - 1);
			this.vietPhraseOneMeaningDocumentPanel.SelectText(vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex, vietPhraseOneMeaningCharRangeFromChineseIndex2.GetEndIndex() - vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex + 1);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000D928 File Offset: 0x0000C928
		private void BaikeingHandler()
		{
			string chinese = HttpUtility.UrlEncode(this.chineseDocumentPanel.GetSelectedText().Trim(), Encoding.GetEncoding("gb2312"));
			this.extendedBrowserPanel.Baikeing(chinese);
			this.extendedBrowserPanel.Activate();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000D96C File Offset: 0x0000C96C
		private void NcikuingHandler()
		{
			string chinese = HttpUtility.UrlEncode(this.chineseDocumentPanel.GetSelectedText().Trim(), Encoding.GetEncoding("utf-8"));
			this.extendedBrowserPanel.Ncikuing(chinese);
			this.extendedBrowserPanel.Activate();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000D9B0 File Offset: 0x0000C9B0
		private void CopyToVietHandler(string textToCopy)
		{
			this.appendToVietToCurrentCursor(textToCopy.Trim(new char[]
			{
				'[',
				']'
			}));
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000D9DC File Offset: 0x0000C9DC
		private void AddToPhienAmHandler()
		{
			string selectedText = this.chineseDocumentPanel.GetSelectedText();
			if (string.IsNullOrEmpty(selectedText))
			{
				return;
			}
			new UpdatePhienAmForm(selectedText).ShowDialog();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000DA0C File Offset: 0x0000CA0C
		private void DeleteSelectedTextHandler(bool remembered)
		{
			if (remembered)
			{
				string selectedText = this.chineseDocumentPanel.GetSelectedText();
				TranslatorEngine.AddIgnoredChinesePhrase(selectedText);
			}
			this.chineseDocumentPanel.DeleteSelectedText();
			this.Retranslate();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000DA40 File Offset: 0x0000CA40
		private void ShiftAndMouseMoveHandler(int charIndexUnderMouse)
		{
			foreach (CharRange charRange in this.vietPhraseOneMeaningRanges)
			{
				if (charRange.IsInRange(charIndexUnderMouse))
				{
					this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectionStart = charRange.StartIndex;
					this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectionLength = 0;
					return;
				}
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000DA98 File Offset: 0x0000CA98
		private void ShiftUpHandler()
		{
			try
			{
				this.ShiftUpHandlerWithoutExceptionHandling();
			}
			catch (Exception exception)
			{
				string application = "QuickTranslator";
				ApplicationLog.Log(Path.GetDirectoryName(Application.ExecutablePath), application, exception);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000DAD8 File Offset: 0x0000CAD8
		private void ShiftUpHandlerWithoutExceptionHandling()
		{
			int selectionStart = this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectionStart;
			int currentHighlightedTextStartIndex = this.vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextStartIndex;
			int currentHighlightedTextLength = this.vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextLength;
			if (currentHighlightedTextStartIndex == selectionStart)
			{
				return;
			}
			string text = this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.Text;
			int num = Math.Min(currentHighlightedTextStartIndex, selectionStart);
			int num2 = (currentHighlightedTextStartIndex < selectionStart) ? selectionStart : (currentHighlightedTextStartIndex + currentHighlightedTextLength);
			num2--;
			string text2 = text.Substring(num, num2 - num + 1);
			string text3 = text.Substring(currentHighlightedTextStartIndex, currentHighlightedTextLength);
			string text4 = text3;
			if (currentHighlightedTextStartIndex >= selectionStart || currentHighlightedTextStartIndex + currentHighlightedTextLength + 1 == selectionStart || currentHighlightedTextStartIndex + currentHighlightedTextLength == selectionStart)
			{
				if (selectionStart < currentHighlightedTextStartIndex)
				{
					int num3 = currentHighlightedTextLength + 1;
					text4 += " ";
					text4 += text2;
					if (text4.EndsWith(" ") || text2.Length < text4.Length)
					{
						text4 = text4.Substring(0, text2.Length);
					}
					if (char.IsUpper(text2[0]) && ("\n\t\"".Contains(text[num - 1].ToString()) || (' ' == text[num - 1] && ":.\"?!".Contains(text[num - 2].ToString()))))
					{
						text4 = char.ToUpper(text4[0]) + text4.Substring(1);
						CharRange chineseCharRangeFromVietPhraseOneMeaningIndex = this.getChineseCharRangeFromVietPhraseOneMeaningIndex(selectionStart);
						if (chineseCharRangeFromVietPhraseOneMeaningIndex != null && TranslatorEngine.GetNameValueFromKey(this.chineseContent.Substring(chineseCharRangeFromVietPhraseOneMeaningIndex.StartIndex, chineseCharRangeFromVietPhraseOneMeaningIndex.Length)) == null)
						{
							text4 = text4.Substring(0, num3) + char.ToLower(text4[num3]) + text4.Substring(num3 + 1);
						}
					}
					this.vietPhraseOneMeaningDocumentPanel.SelectText(num, text2.Length);
					this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectionColor = this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.ForeColor;
					this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectedText = text4;
					this.vietPhraseOneMeaningDocumentPanel.HighlightText(num, 0);
					foreach (CharRange charRange in this.vietPhraseOneMeaningRanges)
					{
						if (currentHighlightedTextStartIndex == charRange.StartIndex)
						{
							charRange.StartIndex = num;
						}
						else if (num <= charRange.StartIndex && charRange.StartIndex < num2)
						{
							charRange.StartIndex += num3;
						}
					}
					this.vietPhraseOneMeaningChanged = true;
				}
				return;
			}
			int num4 = currentHighlightedTextLength + 1;
			if (!"\n\t.,:;!?".Contains(text[num2 + 1].ToString()))
			{
				text4 += " ";
			}
			else
			{
				text4 = " " + text4;
			}
			text4 = text2.Substring(num4) + text4;
			if (text2.Equals(text4) || text4.Length != text2.Length)
			{
				return;
			}
			if (char.IsUpper(text[currentHighlightedTextStartIndex]) && ("\n\t\"".Contains(text[currentHighlightedTextStartIndex - 1].ToString()) || (' ' == text[currentHighlightedTextStartIndex - 1] && ":.\"?!".Contains(text[currentHighlightedTextStartIndex - 2].ToString()))))
			{
				text4 = char.ToUpper(text4[0]) + text4.Substring(1);
				int num5 = text4.Length - num4 + (text4.EndsWith(" ") ? 0 : 1);
				if (TranslatorEngine.GetNameValueFromKey(this.chineseDocumentPanel.GetHighlightText()) == null)
				{
					text4 = text4.Substring(0, num5) + char.ToLower(text4[num5]) + text4.Substring(num5 + 1);
				}
			}
			this.vietPhraseOneMeaningDocumentPanel.SelectText(num, text2.Length);
			this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectionColor = this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.ForeColor;
			this.vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectedText = text4;
			this.vietPhraseOneMeaningDocumentPanel.HighlightText(num, 0);
			foreach (CharRange charRange2 in this.vietPhraseOneMeaningRanges)
			{
				if (num < charRange2.StartIndex && charRange2.StartIndex < num2)
				{
					charRange2.StartIndex -= num4;
				}
				else if (num == charRange2.StartIndex)
				{
					charRange2.StartIndex = num2 - charRange2.Length + (text4.EndsWith(" ") ? 0 : 1);
				}
			}
			this.vietPhraseOneMeaningChanged = true;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000DF8C File Offset: 0x0000CF8C
		private void RetranslateToolStripButtonClick(object sender, EventArgs e)
		{
			int currentLineIndex = this.chineseDocumentPanel.getCurrentLineIndex();
			this.updateDocumentPanel(this.chineseDocumentPanel, TranslatorEngine.StandardizeInput(this.chineseDocumentPanel.GetTextContent()), currentLineIndex);
			this.Retranslate();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000DFC8 File Offset: 0x0000CFC8
		public void Retranslate()
		{
			if (this.vietPhraseOneMeaningChanged)
			{
				DialogResult dialogResult = MessageBox.Show("Ô VietPhrase một nghĩa đã được thay đổi.\nNội dung thay đổi sẽ bị mất nếu tiếp tục.", "Re-Translate?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
				if (dialogResult == DialogResult.Cancel)
				{
					return;
				}
			}
			int currentLineIndex = this.hanVietDocumentPanel.getCurrentLineIndex();
			int currentLineIndex2 = this.vietPhraseDocumentPanel.getCurrentLineIndex();
			int currentLineIndex3 = this.vietPhraseOneMeaningDocumentPanel.getCurrentLineIndex();
			this.Translate(currentLineIndex, currentLineIndex2, currentLineIndex3);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000E028 File Offset: 0x0000D028
		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
				string fileName = array[0];
				this.OpenFile(fileName);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000E068 File Offset: 0x0000D068
		private void OpenFile(string fileName)
		{
			if (fileName.EndsWith(".qt"))
			{
				string text;
				using (TextReader textReader = new StreamReader(fileName, true))
				{
					text = textReader.ReadToEnd();
				}
				string original = text.Substring(text.IndexOf("[Chinese]\n") + "[Chinese]\n".Length, text.IndexOf("[Viet]\n") - text.IndexOf("[Chinese]\n") - "[Chinese]\n".Length);
				this.chineseDocumentPanel.SetTextContent(TranslatorEngine.StandardizeInput(original));
				string rftContent = text.Substring(text.IndexOf("[Viet]\n") + "[Viet]\n".Length);
				this.vietDocumentPanel.SetRftContent(rftContent);
				this.vietDocumentPanel.AppendText("");
				this.vietDocumentPanel.ScrollToBottom();
				this.vietDocumentPanel.FocusInRichTextBox();
				this.Text = "Quick Translator - " + fileName;
				this.workingFilePath = fileName;
				this.isNewTranslationWork = false;
				int currentHanVietDisplayedLine = -1;
				int currentVietPhraseDisplayedLine = -1;
				int currentVietPhraseOneMeaningDisplayedLine = -1;
				if (text.Contains("[CurrentLines]\n"))
				{
					string text2 = text.Substring("[CurrentLines]\n".Length, text.IndexOf("[Chinese]\n") - "[CurrentLines]\n".Length);
					try
					{
						currentHanVietDisplayedLine = int.Parse(text2.Split(new char[]
						{
							'\n'
						})[0]);
						currentVietPhraseDisplayedLine = int.Parse(text2.Split(new char[]
						{
							'\n'
						})[1]);
						currentVietPhraseOneMeaningDisplayedLine = int.Parse(text2.Split(new char[]
						{
							'\n'
						})[2]);
					}
					catch
					{
					}
				}
				if (string.IsNullOrEmpty(this.vietDocumentPanel.GetTextContent().Trim()))
				{
					this.Translate(currentHanVietDisplayedLine, currentVietPhraseDisplayedLine, currentVietPhraseOneMeaningDisplayedLine);
				}
				else
				{
					this.Translate(-1, -1, -1);
				}
			}
			else if (fileName.EndsWith(".doc"))
			{
				this.openWord(fileName);
				this.Translate(-1, -1, -1);
			}
			else
			{
				this.OpenOtherFile(fileName);
			}
			this.AutoScrollToolStripButtonClick(null, null);
			this.workingFilePath = fileName;
			this.toggleNextBackButtons();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000E28C File Offset: 0x0000D28C
		private void OpenOtherFile(string fileName)
		{
			string name = CharsetDetector.DetectChineseCharset(fileName);
			string text = File.ReadAllText(fileName, Encoding.GetEncoding(name));
			this.isNewTranslationWork = true;
			if (fileName.EndsWith("html") || fileName.EndsWith("htm") || fileName.EndsWith("asp") || fileName.EndsWith("aspx") || fileName.EndsWith("php"))
			{
				text = HtmlParser.GetChineseContent(text, false);
			}
			text = TranslatorEngine.StandardizeInput(text);
			this.chineseDocumentPanel.SetTextContent(text);
			this.Text = "Quick Translator - " + fileName;
			this.Translate(-2, -2, -2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000E330 File Offset: 0x0000D330
		private void openWord(string filePath)
		{
			string original;
			string textContent;
			try
			{
				ColumnExporter.ExtractFromWord(File.ReadAllText(filePath), out original, out textContent);
			}
			catch (Exception exception)
			{
				MessageBox.Show("Định dạng của file không đúng!");
				string application = "QuickTranslator";
				ApplicationLog.Log(Path.GetDirectoryName(Application.ExecutablePath), application, exception);
				return;
			}
			this.chineseDocumentPanel.SetTextContent(TranslatorEngine.StandardizeInput(original));
			this.vietDocumentPanel.SetTextContent(textContent);
			this.vietDocumentPanel.ScrollToBottom();
			this.vietDocumentPanel.FocusInRichTextBox();
			this.Text = "Quick Translator - " + filePath;
			this.workingFilePath = filePath;
			this.isNewTranslationWork = false;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000E3D8 File Offset: 0x0000D3D8
		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Link;
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000E3F4 File Offset: 0x0000D3F4
		private void VietPhraseToolStripMenuItemCheckStateChanged(object sender, EventArgs e)
		{
			MainForm.ActiveConfiguration.Layout_VietPhrase = this.vietPhraseToolStripMenuItem.Checked;
			MainForm.ActiveConfiguration.SaveToFile(MainForm.applicationConfigFilePath);
			this.configurationPanel.ReloadConfiguration();
			this.ToggleDocumentPanel(this.vietPhraseDocumentPanel, MainForm.ActiveConfiguration.Layout_VietPhrase);
			int currentLineIndex = this.vietPhraseDocumentPanel.getCurrentLineIndex();
			this.translateVietPhrase(currentLineIndex);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000E45C File Offset: 0x0000D45C
		private void VietPhraseOneMeaningToolStripMenuItemCheckStateChanged(object sender, EventArgs e)
		{
			MainForm.ActiveConfiguration.Layout_VietPhraseOneMeaning = this.vietPhraseOneMeaningToolStripMenuItem.Checked;
			MainForm.ActiveConfiguration.SaveToFile(MainForm.applicationConfigFilePath);
			this.configurationPanel.ReloadConfiguration();
			this.ToggleDocumentPanel(this.vietPhraseOneMeaningDocumentPanel, MainForm.ActiveConfiguration.Layout_VietPhraseOneMeaning);
			int currentLineIndex = this.vietPhraseOneMeaningDocumentPanel.getCurrentLineIndex();
			this.translateVietPhraseOneMeaning(currentLineIndex);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000E4C1 File Offset: 0x0000D4C1
		private void ToggleDocumentPanel(DocumentPanel panel, bool shown)
		{
			if (shown)
			{
				panel.Show();
				return;
			}
			panel.Hide();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000E4D3 File Offset: 0x0000D4D3
		private void VietPhraseToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.vietPhraseToolStripMenuItem.Checked = !this.vietPhraseToolStripMenuItem.Checked;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000E4EE File Offset: 0x0000D4EE
		private void VietPhraseOneMeaningToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.vietPhraseOneMeaningToolStripMenuItem.Checked = !this.vietPhraseOneMeaningToolStripMenuItem.Checked;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000E50C File Offset: 0x0000D50C
		private void ImportFromWordToolStripMenuItemClick(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Microsoft Word 2003 (*.doc)|*.doc";
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			this.openWord(openFileDialog.FileName);
			this.Translate(-1, -1, -1);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000E55C File Offset: 0x0000D55C
		private void toggleNextBackButtons()
		{
			this.editingStartDateTime = DateTime.Now;
			if (string.IsNullOrEmpty(this.workingFilePath))
			{
				this.backToolStripButton.Enabled = false;
				this.nextToolStripButton.Enabled = false;
				return;
			}
			FileInfo fileInfo = new FileInfo(this.workingFilePath);
			string[] files = Directory.GetFiles(fileInfo.Directory.FullName);
			List<string> list = new List<string>(files);
			list.Sort();
			int num = list.FindIndex((string filePath) => filePath == this.workingFilePath);
			if (num < 0)
			{
				this.backToolStripButton.Enabled = false;
				this.nextToolStripButton.Enabled = false;
				return;
			}
			this.backToolStripButton.Enabled = (0 < num);
			this.backFilePath = ((0 < num) ? list[num - 1] : "");
			this.nextToolStripButton.Enabled = (num < files.Length - 1);
			this.nextFilePath = ((num < files.Length - 1) ? list[num + 1] : "");
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000E64E File Offset: 0x0000D64E
		private void BackToolStripButtonClick(object sender, EventArgs e)
		{
			if (!File.Exists(this.backFilePath))
			{
				this.toggleNextBackButtons();
			}
			if (File.Exists(this.backFilePath))
			{
				this.OpenFile(this.backFilePath);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000E67C File Offset: 0x0000D67C
		private void NextToolStripButtonClick(object sender, EventArgs e)
		{
			if (!File.Exists(this.nextFilePath))
			{
				this.toggleNextBackButtons();
			}
			if (File.Exists(this.nextFilePath))
			{
				this.OpenFile(this.nextFilePath);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000E6AC File Offset: 0x0000D6AC
		private void calculateChineseWordCount()
		{
			int num = 0;
			string textContent = this.chineseDocumentPanel.GetTextContent();
			foreach (char character in textContent)
			{
				if (TranslatorEngine.IsChinese(character))
				{
					num++;
				}
			}
			this.wordCountToolStripStatusLabel.Text = num.ToString("N0") + " từ";
		}

		// Token: 0x040000EA RID: 234
		private DocumentPanel vietPhraseDocumentPanel = new DocumentPanel(true);

		// Token: 0x040000EB RID: 235
		private DocumentPanel hanVietDocumentPanel = new DocumentPanel(true);

		// Token: 0x040000EC RID: 236
		private DocumentPanel vietDocumentPanel = new DocumentPanel();

		// Token: 0x040000ED RID: 237
		private DocumentPanel chineseDocumentPanel = new DocumentPanel();

		// Token: 0x040000EE RID: 238
		private DocumentPanel meaningDocumentPanel = new DocumentPanel(true);

		// Token: 0x040000EF RID: 239
		private DocumentPanel vietPhraseOneMeaningDocumentPanel = new DocumentPanel(true);

		// Token: 0x040000F0 RID: 240
		private BrowserForm extendedBrowserPanel = new BrowserForm();

		// Token: 0x040000F1 RID: 241
		private ConfigurationPanel configurationPanel = new ConfigurationPanel(MainForm.applicationConfigFilePath);

		// Token: 0x040000F2 RID: 242
		private static string dockPanelConfigFilePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "QuickTranslatorDockPanel.config");

		// Token: 0x040000F3 RID: 243
		private static string applicationConfigFilePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "QuickTranslatorMain.config");

		// Token: 0x040000F4 RID: 244
		private static string shortcutDictionaryFilePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Shortcuts.txt");

		// Token: 0x040000F5 RID: 245
		private CharRange[] chineseHanVietMappingArray;

		// Token: 0x040000F6 RID: 246
		private CharRange[] chinesePhraseRanges;

		// Token: 0x040000F7 RID: 247
		private CharRange[] vietPhraseRanges;

		// Token: 0x040000F8 RID: 248
		private CharRange[] vietPhraseOneMeaningRanges;

		// Token: 0x040000F9 RID: 249
		private string workingFilePath;

		// Token: 0x040000FA RID: 250
		private bool isNewTranslationWork;

		// Token: 0x040000FB RID: 251
		private DeserializeDockContent deserializeDockContent;

		// Token: 0x040000FC RID: 252
		private string hanVietContent;

		// Token: 0x040000FD RID: 253
		private string vietPhraseContent;

		// Token: 0x040000FE RID: 254
		private string vietPhraseOneMeaningContent;

		// Token: 0x040000FF RID: 255
		private string chineseContent;

		// Token: 0x04000100 RID: 256
		public static Configuration ActiveConfiguration = Configuration.LoadFromFile(MainForm.applicationConfigFilePath);

		// Token: 0x04000101 RID: 257
		private bool vietPhraseOneMeaningChanged;

		// Token: 0x04000102 RID: 258
		private string nextFilePath;

		// Token: 0x04000103 RID: 259
		private string backFilePath;

		// Token: 0x04000104 RID: 260
		private DateTime editingStartDateTime = DateTime.Now;

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000116 RID: 278
		private delegate void GenericDelegate();
	}
}

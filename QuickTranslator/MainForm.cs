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
using QuickTranslatorCore;
using WeifenLuo.WinFormsUI.Docking;

using static QuickTranslatorCore.TranslationEngine;

namespace QuickTranslator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            hanVietDocumentPanel.Text = "Hán Việt";
            hanVietDocumentPanel.CloseButton = false;
            hanVietDocumentPanel.SetFontSize(12f);
            chineseDocumentPanel.Text = "Trung";
            chineseDocumentPanel.CloseButton = false;
            chineseDocumentPanel.SetFontSize(14f);
            vietPhraseDocumentPanel.Text = "VietPhrase";
            vietPhraseDocumentPanel.CloseButton = false;
            vietPhraseDocumentPanel.SetFontSize(12f);
            vietPhraseOneMeaningDocumentPanel.Text = "VietPhrase một nghĩa";
            vietPhraseOneMeaningDocumentPanel.CloseButton = false;
            vietPhraseOneMeaningDocumentPanel.SetFontSize(12f);
            vietPhraseOneMeaningDocumentPanel.contentRichTextBox.AcceptsTab = true;
            meaningDocumentPanel.Text = "Nghĩa";
            meaningDocumentPanel.CloseButton = false;
            meaningDocumentPanel.SetFontSize(10f);
            vietDocumentPanel.Text = "Việt";
            vietDocumentPanel.CloseButton = false;
            vietDocumentPanel.SetFontSize(12f);
            SetPanelStyle();
            configurationPanel.Text = "Configuration";
            configurationPanel.CloseButton = false;
            extendedBrowserPanel.Text = "Quick Web Browser";
            extendedBrowserPanel.CloseButton = false;
            hanVietDocumentPanel.EnableAddToVietPhraseContextMenuStrip();
            chineseDocumentPanel.EnableAddToVietPhraseContextMenuStrip();
            vietPhraseDocumentPanel.EnableAddToVietPhraseContextMenuStrip();
            vietPhraseOneMeaningDocumentPanel.EnableAddToVietPhraseContextMenuStrip();
            vietDocumentPanel.EnableCommentContextMenuStrip();
            meaningDocumentPanel.EnableAddToVietPhraseContextMenuStrip();
            extendedBrowserPanel.fullScreenToolStripButton.Enabled = false;
            extendedBrowserPanel.fullScreenToolStripButton.Visible = false;
            hanVietDocumentPanel.AllowDeletingSelectedText();
            chineseDocumentPanel.AllowDeletingSelectedText();
            if (File.Exists(dockPanelConfigFilePath))
            {
                dockPanel.LoadFromXml(dockPanelConfigFilePath, deserializeDockContent);
            }
            else
            {
                configurationPanel.Show(dockPanel, DockState.DockLeftAutoHide);
                extendedBrowserPanel.Show(dockPanel, DockState.Document);
                vietDocumentPanel.Show(dockPanel, DockState.Document);
                meaningDocumentPanel.Show(dockPanel, DockState.Document);
                vietPhraseOneMeaningDocumentPanel.Show(dockPanel, DockState.Document);
                vietPhraseDocumentPanel.Show(dockPanel, DockState.Document);
                chineseDocumentPanel.Show(dockPanel, DockState.Document);
                hanVietDocumentPanel.Show(dockPanel, DockState.Document);
            }
            isNewTranslationWork = true;
            SetFormTitle();
            chineseDocumentPanel.ClickHandler = new DocumentPanel.ClickDelegate(ChineseClick);
            chineseDocumentPanel.AddToVietPhraseHandler = new DocumentPanel.AddToVietPhraseDelegate(Chinese_AddToVietPhraseHandler);
            chineseDocumentPanel.SelectTextHandler = new DocumentPanel.SelectTextDelegate(Chinese_SelectTextHandler);
            chineseDocumentPanel.BaikeingHandler = new DocumentPanel.BaikeingDelegate(BaikeingHandler);
            chineseDocumentPanel.NcikuingHandler = new DocumentPanel.NcikuingDelegate(NcikuingHandler);
            chineseDocumentPanel.CopyToVietHandler = new DocumentPanel.CopyToVietDelegate(CopyToVietHandler);
            chineseDocumentPanel.DeleteSelectedTextHandler = new DocumentPanel.DeleteSelectedTextDelegate(DeleteSelectedTextHandler);
            chineseDocumentPanel.AddToPhienAmHandler = new DocumentPanel.AddToPhienAmDelegate(AddToPhienAmHandler);
            hanVietDocumentPanel.ClickHandler = new DocumentPanel.ClickDelegate(HanVietClick);
            hanVietDocumentPanel.RightClickHandler = new DocumentPanel.RightClickDelegate(HanVietRightClick);
            hanVietDocumentPanel.AddToVietPhraseHandler = new DocumentPanel.AddToVietPhraseDelegate(HanViet_AddToVietPhraseHandler);
            hanVietDocumentPanel.SelectTextHandler = new DocumentPanel.SelectTextDelegate(HanViet_SelectTextHandler);
            hanVietDocumentPanel.BaikeingHandler = new DocumentPanel.BaikeingDelegate(BaikeingHandler);
            hanVietDocumentPanel.NcikuingHandler = new DocumentPanel.NcikuingDelegate(NcikuingHandler);
            hanVietDocumentPanel.CopyToVietHandler = new DocumentPanel.CopyToVietDelegate(CopyToVietHandler);
            hanVietDocumentPanel.DeleteSelectedTextHandler = new DocumentPanel.DeleteSelectedTextDelegate(DeleteSelectedTextHandler);
            hanVietDocumentPanel.AddToPhienAmHandler = new DocumentPanel.AddToPhienAmDelegate(AddToPhienAmHandler);
            vietPhraseDocumentPanel.ClickHandler = new DocumentPanel.ClickDelegate(VietPhraseClick);
            vietPhraseDocumentPanel.RightClickHandler = new DocumentPanel.RightClickDelegate(VietPhraseRightClick);
            vietPhraseDocumentPanel.AddToVietPhraseHandler = new DocumentPanel.AddToVietPhraseDelegate(VietPhrase_AddToVietPhraseHandler);
            vietPhraseDocumentPanel.SelectTextHandler = new DocumentPanel.SelectTextDelegate(VietPhrase_SelectTextHandler);
            vietPhraseDocumentPanel.BaikeingHandler = new DocumentPanel.BaikeingDelegate(BaikeingHandler);
            vietPhraseDocumentPanel.NcikuingHandler = new DocumentPanel.NcikuingDelegate(NcikuingHandler);
            vietPhraseDocumentPanel.CopyToVietHandler = new DocumentPanel.CopyToVietDelegate(CopyToVietHandler);
            vietPhraseDocumentPanel.AddToPhienAmHandler = new DocumentPanel.AddToPhienAmDelegate(AddToPhienAmHandler);
            vietPhraseOneMeaningDocumentPanel.ClickHandler = new DocumentPanel.ClickDelegate(VietPhraseOneMeaningClick);
            vietPhraseOneMeaningDocumentPanel.RightClickHandler = new DocumentPanel.RightClickDelegate(VietPhraseOneMeaningRightClick);
            vietPhraseOneMeaningDocumentPanel.AddToVietPhraseHandler = new DocumentPanel.AddToVietPhraseDelegate(VietPhraseOneMeaning_AddToVietPhraseHandler);
            vietPhraseOneMeaningDocumentPanel.SelectTextHandler = new DocumentPanel.SelectTextDelegate(VietPhraseOneMeaning_SelectTextHandler);
            vietPhraseOneMeaningDocumentPanel.BaikeingHandler = new DocumentPanel.BaikeingDelegate(BaikeingHandler);
            vietPhraseOneMeaningDocumentPanel.NcikuingHandler = new DocumentPanel.NcikuingDelegate(NcikuingHandler);
            vietPhraseOneMeaningDocumentPanel.CopyToVietHandler = new DocumentPanel.CopyToVietDelegate(CopyToVietHandler);
            vietPhraseOneMeaningDocumentPanel.AddToPhienAmHandler = new DocumentPanel.AddToPhienAmDelegate(AddToPhienAmHandler);
            vietPhraseOneMeaningDocumentPanel.ShiftAndMouseMoveHandler = new DocumentPanel.ShiftAndMouseMoveDelegate(ShiftAndMouseMoveHandler);
            vietPhraseOneMeaningDocumentPanel.ShiftUpHandler = new DocumentPanel.ShiftUpDelegate(ShiftUpHandler);
            meaningDocumentPanel.AddToVietPhraseHandler = new DocumentPanel.AddToVietPhraseDelegate(Meaning_AddToVietPhraseHandler);
            meaningDocumentPanel.BaikeingHandler = new DocumentPanel.BaikeingDelegate(BaikeingHandler);
            meaningDocumentPanel.NcikuingHandler = new DocumentPanel.NcikuingDelegate(NcikuingHandler);
            meaningDocumentPanel.CopyToVietHandler = new DocumentPanel.CopyToVietDelegate(CopyToVietHandler);
            meaningDocumentPanel.AddToPhienAmHandler = new DocumentPanel.AddToPhienAmDelegate(AddToPhienAmHandler);
            LoadDictionaries();
            Shortcuts.LoadFromFile(shortcutDictionaryFilePath);
            vietPhraseToolStripMenuItem.Checked = ActiveConfiguration.Layout_VietPhrase;
            vietPhraseOneMeaningToolStripMenuItem.Checked = ActiveConfiguration.Layout_VietPhraseOneMeaning;
            hanVietDocumentPanel.Activate();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.Msg == 256 || msg.Msg == 260)
            {
                if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_MoveRightOneWord)))
                {
                    NextHanVietWord();
                }
                else if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_MoveLeftOneWord)))
                {
                    PreviousHanVietWord();
                }
                else if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_MoveDownOneLine)))
                {
                    HanVietClick(hanVietDocumentPanel.GetNextLineIndex());
                }
                else if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_MoveUpOneLine)))
                {
                    HanVietClick(hanVietDocumentPanel.GetPreviousLineIndex());
                }
                else if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_MoveDownOneParagraph)))
                {
                    HanVietClick(hanVietDocumentPanel.GetNextPhysicalLineIndex());
                }
                else if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_MoveUpOneParagraph)))
                {
                    HanVietClick(hanVietDocumentPanel.GetPreviousPhysicalLineIndex());
                }
                else if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_CopyHighlightedHanViet)))
                {
                    CopyToVietHandler(hanVietDocumentPanel.GetHighlightText());
                }
                else if (keyData == (Keys)131142)
                {
                    Form form = new FindAndReplaceForm(chineseDocumentPanel.contentRichTextBox);
                    form.Show(this);
                }
                else if (keyData == (Keys.LButton | Keys.RButton | Keys.MButton | Keys.Space | Keys.Alt))
                {
                    if (nextToolStripButton.Enabled)
                    {
                        OpenFile(nextFilePath);
                    }
                }
                else if (keyData == (Keys.LButton | Keys.MButton | Keys.Space | Keys.Alt))
                {
                    if (backToolStripButton.Enabled)
                    {
                        OpenFile(backFilePath);
                    }
                }
                else
                {
                    if (!ActiveConfiguration.Layout_VietPhrase)
                    {
                        return base.ProcessCmdKey(ref msg, keyData);
                    }
                    if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_CopyMeaning1)))
                    {
                        CopyMeaning(1);
                    }
                    else if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_CopyMeaning2)))
                    {
                        CopyMeaning(2);
                    }
                    else if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_CopyMeaning3)))
                    {
                        CopyMeaning(3);
                    }
                    else if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_CopyMeaning4)))
                    {
                        CopyMeaning(4);
                    }
                    else if (keyData == (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_CopyMeaning5)))
                    {
                        CopyMeaning(5);
                    }
                    else
                    {
                        if (keyData != (Keys.Control | (Keys)((byte)ActiveConfiguration.HotKeys_CopyMeaning6)))
                        {
                            return base.ProcessCmdKey(ref msg, keyData);
                        }
                        CopyMeaning(6);
                    }
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TranslateFromClipboardToolStripButtonClick(object sender, EventArgs e)
        {
            isNewTranslationWork = true;
            string original = "";
            try
            {
                original = Clipboard.GetText();
            }
            catch
            {
            }
            chineseDocumentPanel.SetTextContent(NormalizeTextAndRemoveIgnoredChinesePhrases(original));
            Translate(-2, -2, -2);
            Text = "Quick Translator - Untitled";
            workingFilePath = "";
            ToggleNextBackButtons();
        }

        public void Translate(int currentHanVietDisplayedLine, int currentVietPhraseDisplayedLine, int currentVietPhraseOneMeaningDisplayedLine)
        {
            chineseContent = chineseDocumentPanel.GetTextContent();
            if (string.IsNullOrEmpty(chineseContent) || string.IsNullOrEmpty(chineseContent.Trim()))
                return;
            TranslateHanViet(currentHanVietDisplayedLine);
            TranslateVietPhraseOneMeaning(currentVietPhraseOneMeaningDisplayedLine);
            TranslateVietPhrase(currentVietPhraseDisplayedLine);
            CalculateChineseWordCount();
            vietPhraseOneMeaningChanged = false;
        }

        private void TranslateHanViet(int currentDisplayedLine)
        {
            new Thread(delegate () {
                lock (LastTranslatedWord_SinoViet)
                {
                    if (!string.IsNullOrEmpty(chineseContent))
                    {
                        string text = ChineseToHanViet(chineseContent, out chineseHanVietMappingArray);
                        UpdateDocumentPanel(hanVietDocumentPanel, text, currentDisplayedLine);
                    }
                }
            }) {
                IsBackground = true
            }.Start();
        }

        private void TranslateVietPhraseOneMeaning(int currentDisplayedLine)
        {
            if (!vietPhraseOneMeaningDocumentPanel.IsHidden)
            {
                new Thread(delegate () {
                    lock (LastTranslatedWord_VietPhraseOneMeaning)
                    {
                        if (!string.IsNullOrEmpty(chineseContent))
                        {
                            string text;
                            if (ActiveConfiguration.Layout_VietPhrase)
                            {
                                text = ChineseToVietPhraseOneMeaning(chineseContent, ActiveConfiguration.VietPhraseOneMeaning_Wrap, ActiveConfiguration.TranslationAlgorithm, ActiveConfiguration.PrioritizedName, out CharRange[] array, out vietPhraseOneMeaningRanges);
                            }
                            else
                            {
                                text = ChineseToVietPhraseOneMeaning(chineseContent, ActiveConfiguration.VietPhraseOneMeaning_Wrap, ActiveConfiguration.TranslationAlgorithm, ActiveConfiguration.PrioritizedName, out chinesePhraseRanges, out vietPhraseOneMeaningRanges);
                            }
                            UpdateDocumentPanel(vietPhraseOneMeaningDocumentPanel, text, currentDisplayedLine);
                        }
                    }
                }) {
                    IsBackground = true
                }.Start();
            }
        }

        private void TranslateVietPhrase(int currentDisplayedLine)
        {
            if (!vietPhraseDocumentPanel.IsHidden)
            {
                new Thread(delegate () {
                    lock (LastTranslatedWord_VietPhrase)
                    {
                        if (!string.IsNullOrEmpty(chineseContent))
                        {
                            string text = ChineseToVietPhrase(chineseContent, ActiveConfiguration.VietPhrase_Wrap, ActiveConfiguration.TranslationAlgorithm, ActiveConfiguration.PrioritizedName, out chinesePhraseRanges, out vietPhraseRanges);
                            UpdateDocumentPanel(vietPhraseDocumentPanel, text, currentDisplayedLine);
                        }
                    }
                }) {
                    IsBackground = true
                }.Start();
            }
        }

        private void UpdateDocumentPanel(DocumentPanel panel, string text, int currentDisplayedLine)
        {
            GenericDelegate genericDelegate = delegate () {
                panel.SetTextContent(text);
                if (currentDisplayedLine <= -2)
                {
                    panel.ScrollToTop();
                    return;
                }
                if (currentDisplayedLine == -1)
                {
                    int physicalLine = CountPhysicalLines(vietDocumentPanel.GetTextContent());
                    panel.ScrollToASpecificPhysicalLine(physicalLine);
                    return;
                }
                panel.ScrollToASpecificLogicalLine(currentDisplayedLine);
            };
            if (!panel.IsHandleCreated)
            {
                CreateHandle();
            }
            if (panel.InvokeRequired)
            {
                panel.BeginInvoke(genericDelegate);
                return;
            }
            genericDelegate();
        }

        public void SetPanelStyle()
        {
            chineseDocumentPanel.SetFont(ActiveConfiguration.Style_TrungFont);
            chineseDocumentPanel.SetForeColor(ActiveConfiguration.Style_TrungForeColor);
            chineseDocumentPanel.SetBackColor(ActiveConfiguration.Style_TrungBackColor);
            hanVietDocumentPanel.SetFont(ActiveConfiguration.Style_HanVietFont);
            hanVietDocumentPanel.SetForeColor(ActiveConfiguration.Style_HanVietForeColor);
            hanVietDocumentPanel.SetBackColor(ActiveConfiguration.Style_HanVietBackColor);
            vietPhraseDocumentPanel.SetFont(ActiveConfiguration.Style_VietPhraseFont);
            vietPhraseDocumentPanel.SetForeColor(ActiveConfiguration.Style_VietPhraseForeColor);
            vietPhraseDocumentPanel.SetBackColor(ActiveConfiguration.Style_VietPhraseBackColor);
            vietPhraseOneMeaningDocumentPanel.SetFont(ActiveConfiguration.Style_VietPhraseOneMeaningFont);
            vietPhraseOneMeaningDocumentPanel.SetForeColor(ActiveConfiguration.Style_VietPhraseOneMeaningForeColor);
            vietPhraseOneMeaningDocumentPanel.SetBackColor(ActiveConfiguration.Style_VietPhraseOneMeaningBackColor);
            vietDocumentPanel.SetFont(ActiveConfiguration.Style_VietFont);
            vietDocumentPanel.SetForeColor(ActiveConfiguration.Style_VietForeColor);
            vietDocumentPanel.SetBackColor(ActiveConfiguration.Style_VietBackColor);
            meaningDocumentPanel.SetFont(ActiveConfiguration.Style_NghiaFont);
            meaningDocumentPanel.SetForeColor(ActiveConfiguration.Style_NghiaForeColor);
            meaningDocumentPanel.SetBackColor(ActiveConfiguration.Style_NghiaBackColor);
        }

        private void PreviousHanVietWord()
        {
            HanVietClick(hanVietDocumentPanel.GetPreviousWordIndex());
        }

        private void NextHanVietWord()
        {
            HanVietClick(hanVietDocumentPanel.GetNextWordIndex());
        }

        private void SetFormTitle()
        {
            Text = "Quick Translator";
            Text += (isNewTranslationWork ? " - Untitled" : workingFilePath);
        }

        private void HanVietClick(int currentCharIndex)
        {
            try
            {
                HanVietClickWithoutHandlingException(currentCharIndex);
            }
            catch (Exception exception)
            {
                Logger.Log(Path.GetDirectoryName(Application.ExecutablePath), "QuickTranslator", exception);
            }
        }

        private void HanVietClickWithoutHandlingException(int currentCharIndex)
        {
            if (hanVietDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
            {
                return;
            }
            int num = FindChineseCharIndexFromHanVietIndex(currentCharIndex);
            if (num < 0)
            {
                return;
            }
            string text = ChineseToMeanings(chineseDocumentPanel.GetTextContent().Substring(num), out int num2);
            meaningDocumentPanel.SetTextContent(text.Replace("\\n", "\n").Replace("\\t", "\t"));
            meaningDocumentPanel.ScrollToTop();
            chineseDocumentPanel.HighlightText(num, num2, true, true);
            CharRange hanVietCharRangeFromChineseRange = GetHanVietCharRangeFromChineseRange(num, num2);
            hanVietDocumentPanel.HighlightText(hanVietCharRangeFromChineseRange.StartIndex, hanVietCharRangeFromChineseRange.Length, true, false);
            if (ActiveConfiguration.Layout_VietPhrase)
            {
                CharRange vietPhraseCharRangeFromChineseIndex = GetVietPhraseCharRangeFromChineseIndex(num);
                vietPhraseDocumentPanel.HighlightText(vietPhraseCharRangeFromChineseIndex.StartIndex, vietPhraseCharRangeFromChineseIndex.Length, true, true);
            }
            if (ActiveConfiguration.Layout_VietPhraseOneMeaning)
            {
                CharRange vietPhraseOneMeaningCharRangeFromChineseIndex = GetVietPhraseOneMeaningCharRangeFromChineseIndex(num);
                vietPhraseOneMeaningDocumentPanel.HighlightText(vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex, vietPhraseOneMeaningCharRangeFromChineseIndex.Length, true, true);
            }
            if (ActiveConfiguration.AlwaysFocusInViet)
            {
                vietDocumentPanel.FocusInRichTextBox();
            }
        }

        private void ChineseClick(int chineseCharIndex)
        {
            try
            {
                ChineseClickWithoutHandlingException(chineseCharIndex);
            }
            catch (Exception exception)
            {
                Logger.Log(Path.GetDirectoryName(Application.ExecutablePath), "QuickTranslator", exception);
            }
        }

        private void ChineseClickWithoutHandlingException(int chineseCharIndex)
        {
            if (chineseDocumentPanel.GetTextContent().Length - 1 < chineseCharIndex)
            {
                return;
            }
            string text = ChineseToMeanings(chineseDocumentPanel.GetTextContent().Substring(chineseCharIndex), out int num);
            meaningDocumentPanel.SetTextContent(text.Replace("\\n", "\n").Replace("\\t", "\t"));
            meaningDocumentPanel.ScrollToTop();
            chineseDocumentPanel.HighlightText(chineseCharIndex, num, true, false);
            CharRange hanVietCharRangeFromChineseRange = GetHanVietCharRangeFromChineseRange(chineseCharIndex, num);
            hanVietDocumentPanel.HighlightText(hanVietCharRangeFromChineseRange.StartIndex, hanVietCharRangeFromChineseRange.Length, true, true);
            if (ActiveConfiguration.Layout_VietPhrase)
            {
                CharRange vietPhraseCharRangeFromChineseIndex = GetVietPhraseCharRangeFromChineseIndex(chineseCharIndex);
                vietPhraseDocumentPanel.HighlightText(vietPhraseCharRangeFromChineseIndex.StartIndex, vietPhraseCharRangeFromChineseIndex.Length, true, true);
            }
            if (ActiveConfiguration.Layout_VietPhraseOneMeaning)
            {
                CharRange vietPhraseOneMeaningCharRangeFromChineseIndex = GetVietPhraseOneMeaningCharRangeFromChineseIndex(chineseCharIndex);
                vietPhraseOneMeaningDocumentPanel.HighlightText(vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex, vietPhraseOneMeaningCharRangeFromChineseIndex.Length, true, true);
            }
            if (ActiveConfiguration.AlwaysFocusInViet)
            {
                vietDocumentPanel.FocusInRichTextBox();
            }
        }

        private int FindChineseCharIndexFromHanVietIndex(int hanVietCharIndex)
        {
            int result = -1;
            for (int i = 0; i < chineseHanVietMappingArray.Length; i++)
            {
                if (chineseHanVietMappingArray[i].StartIndex <= hanVietCharIndex && hanVietCharIndex <= chineseHanVietMappingArray[i].GetEndIndex())
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        private void VietPhraseClick(int currentCharIndex)
        {
            try
            {
                VietPhraseClickWithoutHandlingException(currentCharIndex);
            }
            catch (Exception exception)
            {
                Logger.Log(Path.GetDirectoryName(Application.ExecutablePath), "QuickTranslator", exception);
            }
        }

        private void VietPhraseClickWithoutHandlingException(int currentCharIndex)
        {
            if (vietPhraseDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
            {
                return;
            }
            if (GetChineseCharRangeFromVietPhraseIndex(currentCharIndex) == null)
            {
                return;
            }
            int startIndex = GetChineseCharRangeFromVietPhraseIndex(currentCharIndex).StartIndex;
            string text = ChineseToMeanings(chineseDocumentPanel.GetTextContent().Substring(startIndex), out int num);
            meaningDocumentPanel.SetTextContent(text.Replace("\\n", "\n").Replace("\\t", "\t"));
            meaningDocumentPanel.ScrollToTop();
            chineseDocumentPanel.HighlightText(startIndex, num, true, true);
            CharRange hanVietCharRangeFromChineseRange = GetHanVietCharRangeFromChineseRange(startIndex, num);
            hanVietDocumentPanel.HighlightText(hanVietCharRangeFromChineseRange.StartIndex, hanVietCharRangeFromChineseRange.Length, true, true);
            CharRange vietPhraseCharRangeFromChineseIndex = GetVietPhraseCharRangeFromChineseIndex(startIndex);
            vietPhraseDocumentPanel.HighlightText(vietPhraseCharRangeFromChineseIndex.StartIndex, vietPhraseCharRangeFromChineseIndex.Length, true, false);
            if (ActiveConfiguration.Layout_VietPhraseOneMeaning)
            {
                CharRange vietPhraseOneMeaningCharRangeFromChineseIndex = GetVietPhraseOneMeaningCharRangeFromChineseIndex(startIndex);
                vietPhraseOneMeaningDocumentPanel.HighlightText(vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex, vietPhraseOneMeaningCharRangeFromChineseIndex.Length, true, true);
            }
            if (ActiveConfiguration.AlwaysFocusInViet)
            {
                vietDocumentPanel.FocusInRichTextBox();
            }
        }

        private void VietPhraseOneMeaningClick(int currentCharIndex)
        {
            try
            {
                VietPhraseOneMeaningClickWithoutHandlingException(currentCharIndex);
            }
            catch (Exception exception)
            {
                Logger.Log(Path.GetDirectoryName(Application.ExecutablePath), "QuickTranslator", exception);
            }
        }

        private void VietPhraseOneMeaningClickWithoutHandlingException(int currentCharIndex)
        {
            if (vietPhraseOneMeaningDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
            {
                return;
            }
            CharRange chineseCharRangeFromVietPhraseOneMeaningIndex = GetChineseCharRangeFromVietPhraseOneMeaningIndex(currentCharIndex);
            if (chineseCharRangeFromVietPhraseOneMeaningIndex == null)
            {
                return;
            }
            int startIndex = chineseCharRangeFromVietPhraseOneMeaningIndex.StartIndex;
            string text = ChineseToMeanings(chineseDocumentPanel.GetTextContent().Substring(startIndex), out int num);
            meaningDocumentPanel.SetTextContent(text.Replace("\\n", "\n").Replace("\\t", "\t"));
            meaningDocumentPanel.ScrollToTop();
            chineseDocumentPanel.HighlightText(startIndex, num, true, true);
            CharRange hanVietCharRangeFromChineseRange = GetHanVietCharRangeFromChineseRange(startIndex, num);
            hanVietDocumentPanel.HighlightText(hanVietCharRangeFromChineseRange.StartIndex, hanVietCharRangeFromChineseRange.Length, true, true);
            if (ActiveConfiguration.Layout_VietPhrase)
            {
                CharRange vietPhraseCharRangeFromChineseIndex = GetVietPhraseCharRangeFromChineseIndex(startIndex);
                vietPhraseDocumentPanel.HighlightText(vietPhraseCharRangeFromChineseIndex.StartIndex, vietPhraseCharRangeFromChineseIndex.Length, true, true);
            }
            CharRange vietPhraseOneMeaningCharRangeFromChineseIndex = GetVietPhraseOneMeaningCharRangeFromChineseIndex(startIndex);
            string text2 = GetVietPhraseOrName(chineseContent.Substring(startIndex, num));
            if (vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextStartIndex == vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex && vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextLength == vietPhraseOneMeaningCharRangeFromChineseIndex.Length && !"\n".Equals(vietPhraseOneMeaningDocumentPanel.GetHighlightText()))
            {
                if (string.IsNullOrEmpty(text2))
                {
                    text2 = string.Empty;
                }
                string[] array = text2.Split("/|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string value = vietPhraseOneMeaningDocumentPanel.GetTextContent().Substring(vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextStartIndex, vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextLength);
                vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Items.Clear();
                if (1 < array.Length)
                {
                    foreach (string text3 in array)
                    {
                        if (!text3.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            StringBuilder stringBuilder = new StringBuilder();
                            stringBuilder.AppendLine(FindChineseMappingId(startIndex).ToString());
                            stringBuilder.AppendLine(value);
                            stringBuilder.AppendLine(chineseDocumentPanel.GetTextContent().Substring(startIndex, num));
                            stringBuilder.AppendLine(text3);
                            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text3) {
                                Tag = stringBuilder.ToString()
                            };
                            toolStripMenuItem.Click += ChooseAMeaningMenuItem_Click;
                            ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem("Update VietPhrase") {
                                Tag = stringBuilder.ToString()
                            };
                            toolStripMenuItem2.Click += ChooseAMeaningMenuItem_Click;
                            toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
                            vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Items.Add(toolStripMenuItem);
                        }
                    }
                    vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Items.Add(new ToolStripSeparator());
                }
                ToolStripTextBox toolStripTextBox = new ToolStripTextBox {
                    BorderStyle = BorderStyle.FixedSingle
                };
                StringBuilder stringBuilder2 = new StringBuilder();
                stringBuilder2.AppendLine(FindChineseMappingId(startIndex).ToString());
                stringBuilder2.AppendLine(value);
                stringBuilder2.AppendLine(chineseDocumentPanel.GetTextContent().Substring(startIndex, num));
                toolStripTextBox.Tag = stringBuilder2.ToString();
                toolStripTextBox.KeyPress += NewMeaningTextBox_KeyPress;
                vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Items.Add(toolStripTextBox);
                vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Show(Cursor.Position);
                if (vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Items.Count < 2)
                {
                    toolStripTextBox.Focus();
                }
            }
            vietPhraseOneMeaningDocumentPanel.HighlightText(vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex, vietPhraseOneMeaningCharRangeFromChineseIndex.Length, true, false);
            if (ActiveConfiguration.AlwaysFocusInViet)
            {
                vietDocumentPanel.FocusInRichTextBox();
            }
        }

        private void ChooseAMeaningMenuItem_Click(object sender, EventArgs e)
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
            vietPhraseOneMeaningRanges[num].Length += num2;
            for (int i = 0; i < vietPhraseOneMeaningRanges.Length; i++)
            {
                if (vietPhraseOneMeaningRanges[num].StartIndex < vietPhraseOneMeaningRanges[i].StartIndex)
                {
                    vietPhraseOneMeaningRanges[i].StartIndex += num2;
                }
            }
            string text3 = text;
            if (char.IsUpper(text2[0]))
            {
                text3 = char.ToUpper(text[0]) + ((text.Length <= 1) ? "" : text.Substring(1));
            }
            vietPhraseOneMeaningDocumentPanel.ReplaceHighlightedText(text3);
            if ("Update VietPhrase".Equals(toolStripMenuItem.Text))
            {
                string[] array2 = GetVietPhrase(array[2].Trim()).Split("/|".ToCharArray());
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
                UpdateVietPhraseDict(array[2], stringBuilder.ToString(), false);
            }
            vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Hide();
        }

        private void NewMeaningTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            vietPhraseOneMeaningRanges[num].Length += num2;
            for (int i = 0; i < vietPhraseOneMeaningRanges.Length; i++)
            {
                if (vietPhraseOneMeaningRanges[num].StartIndex < vietPhraseOneMeaningRanges[i].StartIndex)
                {
                    vietPhraseOneMeaningRanges[i].StartIndex += num2;
                }
            }
            string text3 = text;
            if (char.IsUpper(text2[0]) && 0 < text.Length)
            {
                text3 = char.ToUpper(text[0]) + ((text.Length <= 1) ? "" : text.Substring(1));
            }
            vietPhraseOneMeaningDocumentPanel.ReplaceHighlightedText(text3);
            string vietPhraseValueFromKey = GetVietPhrase(array[2].Trim());
            string[] array2 = (vietPhraseValueFromKey ?? "").Split("/|".ToCharArray());
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
            UpdateVietPhraseDict(array[2], stringBuilder.ToString().TrimEnd("/".ToCharArray()), false);
            vietPhraseOneMeaningDocumentPanel.chooseMeaningContextMenuStrip.Hide();
        }

        private CharRange GetHanVietCharRangeFromChineseRange(int chineseStartIndex, int chineseLength)
        {
            int startIndex = chineseHanVietMappingArray[chineseStartIndex].StartIndex;
            int length = chineseHanVietMappingArray[chineseStartIndex + chineseLength - 1].GetEndIndex() - startIndex + 1;
            return new CharRange(startIndex, length);
        }

        private CharRange GetChineseCharRangeFromVietPhraseIndex(int vietPhraseStartIndex)
        {
            int num = FindVietPhraseMappingId(vietPhraseStartIndex);
            if (num < 0 || chinesePhraseRanges == null || chinesePhraseRanges.Length <= num)
            {
                return null;
            }
            return chinesePhraseRanges[num];
        }

        private CharRange GetVietPhraseCharRangeFromChineseIndex(int chineseStartIndex)
        {
            if (vietPhraseDocumentPanel.IsHidden)
            {
                return null;
            }
            int num = FindChineseMappingId(chineseStartIndex);
            if (num < 0 || vietPhraseRanges == null || vietPhraseRanges.Length <= num)
            {
                return null;
            }
            return vietPhraseRanges[num];
        }

        private CharRange GetChineseCharRangeFromVietPhraseOneMeaningIndex(int vietPhraseStartIndex)
        {
            int num = FindVietPhraseOneMeaningMappingId(vietPhraseStartIndex);
            if (num < 0 || chinesePhraseRanges == null || chinesePhraseRanges.Length <= num)
            {
                return null;
            }
            return chinesePhraseRanges[num];
        }

        private CharRange GetVietPhraseOneMeaningCharRangeFromChineseIndex(int chineseStartIndex)
        {
            if (vietPhraseOneMeaningDocumentPanel.IsHidden)
            {
                return null;
            }
            int num = FindChineseMappingId(chineseStartIndex);
            if (num < 0 || vietPhraseOneMeaningRanges == null || vietPhraseOneMeaningRanges.Length <= num)
            {
                return null;
            }
            return vietPhraseOneMeaningRanges[num];
        }

        private int FindVietPhraseMappingId(int currentCharIndex)
        {
            int result = -1;
            for (int i = 0; i < vietPhraseRanges.Length; i++)
            {
                CharRange charRange = vietPhraseRanges[i];
                if (charRange.StartIndex <= currentCharIndex && currentCharIndex <= charRange.GetEndIndex())
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        private int FindVietPhraseOneMeaningMappingId(int currentCharIndex)
        {
            int result = -1;
            for (int i = 0; i < vietPhraseOneMeaningRanges.Length; i++)
            {
                CharRange charRange = vietPhraseOneMeaningRanges[i];
                if (charRange.StartIndex <= currentCharIndex && currentCharIndex <= charRange.GetEndIndex())
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        private int FindChineseMappingId(int currentCharIndex)
        {
            int result = -1;
            for (int i = 0; i < chinesePhraseRanges.Length; i++)
            {
                CharRange charRange = chinesePhraseRanges[i];
                if (charRange.StartIndex <= currentCharIndex && currentCharIndex <= charRange.GetEndIndex())
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        private void VietPhraseRightClick(int currentCharIndex)
        {
            if (vietPhraseDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
            {
                return;
            }
            int num = FindVietPhraseMappingId(currentCharIndex);
            if (num < 0)
            {
                return;
            }
            string textContent = vietPhraseDocumentPanel.GetTextContent();
            textContent.Substring(vietPhraseRanges[num].StartIndex, vietPhraseRanges[num].Length);
            int num2 = currentCharIndex;
            int num3 = vietPhraseRanges[num].GetEndIndex();
            int num4 = currentCharIndex;
            while (vietPhraseRanges[num].StartIndex <= num4)
            {
                if (textContent[num4] == '[' || textContent[num4] == '/' || textContent[num4] == '|')
                {
                    num2 = num4 + 1;
                    break;
                }
                num2 = num4;
                num4--;
            }
            for (int i = currentCharIndex + 1; i <= vietPhraseRanges[num].GetEndIndex(); i++)
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
                AppendToVietToCurrentCursor(text);
            }
        }

        private void VietPhraseOneMeaningRightClick(int currentCharIndex)
        {
            if (vietPhraseOneMeaningDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
            {
                return;
            }
            int num = FindVietPhraseOneMeaningMappingId(currentCharIndex);
            if (num < 0)
            {
                return;
            }
            string textContent = vietPhraseOneMeaningDocumentPanel.GetTextContent();
            string text = textContent.Substring(vietPhraseOneMeaningRanges[num].StartIndex, vietPhraseOneMeaningRanges[num].Length);
            AppendToVietToCurrentCursor(text.Trim(new char[]
            {
                '[',
                ']'
            }));
        }

        private void HanVietRightClick(int currentCharIndex)
        {
            if (hanVietDocumentPanel.GetTextContent().Length - 1 < currentCharIndex)
            {
                return;
            }
            int num = currentCharIndex;
            int num2 = currentCharIndex;
            string textContent = hanVietDocumentPanel.GetTextContent();
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
            AppendToVietToCurrentCursor(text);
        }

        private void AppendToVietToCurrentCursor(string text)
        {
            if (text.Length == 0)
            {
                return;
            }
            string text2 = "";
            string textContent = vietDocumentPanel.GetTextContent();
            string twoCharsBeforeSelectedText = vietDocumentPanel.GetTwoCharsBeforeSelectedText();
            string twoCharsAfterSelectedText = vietDocumentPanel.GetTwoCharsAfterSelectedText();
            if (textContent.Length <= 1)
            {
                text2 = Capitalize(text);
            }
            else if (twoCharsBeforeSelectedText.EndsWith("! ") || twoCharsBeforeSelectedText.EndsWith(". ") || (twoCharsBeforeSelectedText.EndsWith("? ") | twoCharsBeforeSelectedText.EndsWith(": ")) || twoCharsBeforeSelectedText.EndsWith("; ") || twoCharsBeforeSelectedText.EndsWith(") ") || twoCharsBeforeSelectedText.EndsWith("\" ") || twoCharsBeforeSelectedText.EndsWith("' ") || twoCharsBeforeSelectedText.EndsWith("\n"))
            {
                text2 = Capitalize(text);
            }
            else if (twoCharsBeforeSelectedText.EndsWith("!") || twoCharsBeforeSelectedText.EndsWith(".") || twoCharsBeforeSelectedText.EndsWith("?") || twoCharsBeforeSelectedText.EndsWith("!\"") || twoCharsBeforeSelectedText.EndsWith(".\"") || twoCharsBeforeSelectedText.EndsWith("?\""))
            {
                text2 = " " + Capitalize(text);
            }
            else if (twoCharsBeforeSelectedText.EndsWith("\""))
            {
                text2 = Capitalize(text);
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
            vietDocumentPanel.AppendTextToCurrentCursor(text2);
            if (ActiveConfiguration.AlwaysFocusInViet)
            {
                vietDocumentPanel.FocusInRichTextBox();
            }
        }

        private string Capitalize(string text)
        {
            if (1 >= text.Length)
            {
                return char.ToUpper(text[0]).ToString();
            }
            return char.ToUpper(text[0]) + text.Substring(1);
        }

        private void MainFormKeyDown(object sender, KeyEventArgs e)
        {
            string text = null;
            switch (e.KeyCode)
            {
                case Keys.F1:
                    text = ActiveConfiguration.HotKeys_F1;
                    break;
                case Keys.F2:
                    text = ActiveConfiguration.HotKeys_F2;
                    break;
                case Keys.F3:
                    text = ActiveConfiguration.HotKeys_F3;
                    break;
                case Keys.F4:
                    text = ActiveConfiguration.HotKeys_F4;
                    break;
                case Keys.F5:
                    text = ActiveConfiguration.HotKeys_F5;
                    break;
                case Keys.F6:
                    text = ActiveConfiguration.HotKeys_F6;
                    break;
                case Keys.F7:
                    text = ActiveConfiguration.HotKeys_F7;
                    break;
                case Keys.F8:
                    text = ActiveConfiguration.HotKeys_F8;
                    break;
                case Keys.F9:
                    text = ActiveConfiguration.HotKeys_F9;
                    break;
            }
            if (text != null)
            {
                AppendToVietToCurrentCursor(text);
                if (ActiveConfiguration.AlwaysFocusInViet)
                {
                    vietDocumentPanel.FocusInRichTextBox();
                }
            }
        }

        private void CopyMeaning(int meaningIndex)
        {
            string highlightText = vietPhraseDocumentPanel.GetHighlightText();
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
            int currentCharIndex = vietPhraseDocumentPanel.CurrentHighlightedTextStartIndex + highlightText.IndexOf(array[num - 1]);
            VietPhraseRightClick(currentCharIndex);
        }

        private void AutoScrollToolStripButtonClick(object sender, EventArgs e)
        {
            try
            {
                int physicalLine = CountPhysicalLines(vietDocumentPanel.GetTextContent());
                chineseDocumentPanel.ScrollToASpecificPhysicalLine(physicalLine);
                hanVietDocumentPanel.ScrollToASpecificPhysicalLine(physicalLine);
                vietPhraseDocumentPanel.ScrollToASpecificPhysicalLine(physicalLine);
                vietPhraseOneMeaningDocumentPanel.ScrollToASpecificPhysicalLine(physicalLine);
            }
            catch (Exception)
            {
            }
        }

        private int CountPhysicalLines(string text)
        {
            return text.Split(new char[]
            {
                '\n'
            }).Length;
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            string str = isNewTranslationWork ? "Untitled" : Path.GetFileName(workingFilePath);
            DialogResult dialogResult = MessageBox.Show("Do you want to save the changes to " + str + "?", "Quick Translator", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.Yes)
            {
                SaveToolStripMenuItemClick(null, null);
                return;
            }
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void ReloadDictToolStripButtonClick(object sender, EventArgs e)
        {
            FlagToLoadData = true;
            LoadDictionaries();
            Shortcuts.LoadFromFile(shortcutDictionaryFilePath);
            Retranslate();
        }

        private void PostTTVToolStripButtonClick(object sender, EventArgs e)
        {
            using (PostTTVForm postTTVForm = new PostTTVForm(vietDocumentPanel.GetTextContent(), hanVietDocumentPanel.GetTextContent(), vietPhraseOneMeaningDocumentPanel.GetTextContent(), chineseDocumentPanel.GetTextContent(), editingStartDateTime))
            {
                postTTVForm.ShowDialog();
            }
        }

        private void MainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            dockPanel.SaveAsXml(dockPanelConfigFilePath);
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == "Hán Việt")
            {
                return hanVietDocumentPanel;
            }
            if (persistString == "Trung")
            {
                return chineseDocumentPanel;
            }
            if (persistString == "VietPhrase")
            {
                return vietPhraseDocumentPanel;
            }
            if (persistString == "VietPhrase một nghĩa")
            {
                return vietPhraseOneMeaningDocumentPanel;
            }
            if (persistString == "Nghĩa")
            {
                return meaningDocumentPanel;
            }
            if (persistString == "Việt")
            {
                return vietDocumentPanel;
            }
            if (persistString == "Configuration")
            {
                return configurationPanel;
            }
            if (persistString == "Quick Web Browser")
            {
                return extendedBrowserPanel;
            }
            return vietDocumentPanel;
        }

        private void UpdateVietPhraseToolStripButtonClick(object sender, EventArgs e)
        {
            UpdateVietPhraseOrName(0);
        }

        private void UpdateVietPhraseOrName(int type)
        {
            int selectionStart = chineseDocumentPanel.GetSelectionStart();
            string textContent = chineseDocumentPanel.GetTextContent();
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
                extendedBrowserPanel.Baikeing(chinese);
                extendedBrowserPanel.Activate();
            }
        }

        private void UpdateNameToolStripButtonClick(object sender, EventArgs e)
        {
            UpdateVietPhraseOrName(1);
        }

        private void NewWindowToolStripMenuItemClick(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(NewWindow));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void NewWindow()
        {
            Application.Run(new MainForm());
        }

        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "Quick Translator or Word (*.qt; *.doc)|*.qt;*.doc|All (*.*)|*.*"
            };
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
                OpenQtOrWordFile(content, fileName);
            }
            else
            {
                OpenOtherFile(fileName);
            }
            workingFilePath = fileName;
            ToggleNextBackButtons();
        }

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
                    Logger.Log(Path.GetDirectoryName(Application.ExecutablePath), application, exception);
                    return;
                }
            }
            chineseDocumentPanel.SetTextContent(NormalizeTextAndRemoveIgnoredChinesePhrases(original));
            vietDocumentPanel.SetRftContent(rftContent);
            vietDocumentPanel.AppendText("");
            vietDocumentPanel.ScrollToBottom();
            vietDocumentPanel.FocusInRichTextBox();
            if (string.IsNullOrEmpty(vietDocumentPanel.GetTextContent().Trim()))
            {
                Translate(currentHanVietDisplayedLine, currentVietPhraseDisplayedLine, currentVietPhraseOneMeaningDisplayedLine);
            }
            else
            {
                Translate(-1, -1, -1);
            }
            Text = "Quick Translator - " + filePath;
            workingFilePath = filePath;
            isNewTranslationWork = false;
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (isNewTranslationWork)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog {
                    CheckFileExists = false,
                    Filter = "Quick Translator (*.qt)|*.qt|Microsoft Word (*.doc)|*.doc"
                };
                DialogResult dialogResult = saveFileDialog.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    return;
                }
                workingFilePath = saveFileDialog.FileName;
            }
            if (workingFilePath.EndsWith(".qt"))
            {
                using (TextWriter textWriter = new StreamWriter(workingFilePath, false, Encoding.UTF8))
                {
                    textWriter.Write("[CurrentLines]\n");
                    textWriter.Write(hanVietDocumentPanel.GetCurrentLineIndex() + "\n");
                    textWriter.Write(vietPhraseDocumentPanel.GetCurrentLineIndex() + "\n");
                    textWriter.Write(vietPhraseOneMeaningDocumentPanel.GetCurrentLineIndex() + "\n");
                    textWriter.Write("[Chinese]\n");
                    textWriter.Write(chineseDocumentPanel.GetTextContent());
                    if (!chineseDocumentPanel.GetTextContent().EndsWith("\n"))
                    {
                        textWriter.Write("\n");
                    }
                    textWriter.Write("[Viet]\n");
                    textWriter.Write(vietDocumentPanel.GetRtfContent());
                    goto IL_18B;
                }
            }
            using (ExportToWordForm exportToWordForm = new ExportToWordForm(chineseDocumentPanel.GetTextContent(), hanVietDocumentPanel.GetTextContent(), vietPhraseDocumentPanel.GetTextContent(), vietPhraseOneMeaningDocumentPanel.GetTextContent(), vietDocumentPanel.GetTextContent()))
            {
                exportToWordForm.PopulateControls();
                exportToWordForm.ExportToWord(workingFilePath);
            }
        IL_18B:
            Text = "Quick Translator - " + workingFilePath;
            isNewTranslationWork = false;
            ToggleNextBackButtons();
        }

        private void ExportToWordToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (ExportToWordForm exportToWordForm = new ExportToWordForm(chineseDocumentPanel.GetTextContent(), hanVietDocumentPanel.GetTextContent(), vietPhraseDocumentPanel.GetTextContent(), vietPhraseOneMeaningDocumentPanel.GetTextContent(), vietDocumentPanel.GetTextContent()))
            {
                exportToWordForm.ShowDialog();
            }
        }

        private void Chinese_AddToVietPhraseHandler(int type)
        {
            UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(chineseDocumentPanel.GetSelectedText(), type);
            updateVietPhraseForm.ShowDialog();
            if (updateVietPhraseForm.NeedSurfBaike)
            {
                string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
                extendedBrowserPanel.Baikeing(chinese);
                extendedBrowserPanel.Activate();
            }
        }

        private void HanViet_AddToVietPhraseHandler(int type)
        {
            int selectionStart = hanVietDocumentPanel.GetSelectionStart();
            int num = FindChineseCharIndexFromHanVietIndex(selectionStart);
            if (num <= 0)
            {
                num = FindChineseCharIndexFromHanVietIndex(selectionStart + 1);
            }
            if (num <= 0)
            {
                return;
            }
            int num2 = hanVietDocumentPanel.GetSelectionStart() + hanVietDocumentPanel.GetSelectionLength() - 1;
            int num3 = FindChineseCharIndexFromHanVietIndex(num2);
            if (num3 <= 0)
            {
                num3 = FindChineseCharIndexFromHanVietIndex(num2 - 1);
            }
            if (num3 <= 0 || num3 < num)
            {
                return;
            }
            string chineseToLookup = chineseDocumentPanel.GetTextContent().Substring(num, num3 - num + 1);
            UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(chineseToLookup, type);
            updateVietPhraseForm.ShowDialog();
            if (updateVietPhraseForm.NeedSurfBaike)
            {
                string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
                extendedBrowserPanel.Baikeing(chinese);
                extendedBrowserPanel.Activate();
            }
        }

        private int GetChineseStartIndexFromVietPhraseIndex(int vietPhraseIndex)
        {
            CharRange chineseCharRangeFromVietPhraseIndex = GetChineseCharRangeFromVietPhraseIndex(vietPhraseIndex);
            if (chineseCharRangeFromVietPhraseIndex == null)
            {
                return 0;
            }
            return chineseCharRangeFromVietPhraseIndex.StartIndex;
        }

        private int GetChineseEndIndexFromVietPhraseIndex(int vietPhraseIndex)
        {
            CharRange chineseCharRangeFromVietPhraseIndex = GetChineseCharRangeFromVietPhraseIndex(vietPhraseIndex);
            if (chineseCharRangeFromVietPhraseIndex == null)
            {
                return 0;
            }
            return chineseCharRangeFromVietPhraseIndex.GetEndIndex();
        }

        private void VietPhrase_AddToVietPhraseHandler(int type)
        {
            int selectionStart = vietPhraseDocumentPanel.GetSelectionStart();
            int chineseStartIndexFromVietPhraseIndex = GetChineseStartIndexFromVietPhraseIndex(selectionStart);
            if (chineseStartIndexFromVietPhraseIndex <= 0)
            {
                chineseStartIndexFromVietPhraseIndex = GetChineseStartIndexFromVietPhraseIndex(selectionStart + 1);
            }
            if (chineseStartIndexFromVietPhraseIndex <= 0)
            {
                return;
            }
            int num = vietPhraseDocumentPanel.GetSelectionStart() + vietPhraseDocumentPanel.GetSelectionLength() - 1;
            int chineseEndIndexFromVietPhraseIndex = GetChineseEndIndexFromVietPhraseIndex(num);
            if (chineseEndIndexFromVietPhraseIndex <= 0)
            {
                chineseEndIndexFromVietPhraseIndex = GetChineseEndIndexFromVietPhraseIndex(num - 1);
            }
            if (chineseEndIndexFromVietPhraseIndex <= 0 || chineseEndIndexFromVietPhraseIndex < chineseStartIndexFromVietPhraseIndex)
            {
                return;
            }
            string chineseToLookup = chineseDocumentPanel.GetTextContent().Substring(chineseStartIndexFromVietPhraseIndex, chineseEndIndexFromVietPhraseIndex - chineseStartIndexFromVietPhraseIndex + 1);
            UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(chineseToLookup, type);
            updateVietPhraseForm.ShowDialog();
            if (updateVietPhraseForm.NeedSurfBaike)
            {
                string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
                extendedBrowserPanel.Baikeing(chinese);
                extendedBrowserPanel.Activate();
            }
        }

        private int GetChineseStartIndexFromVietPhraseOneMeaningIndex(int vietPhraseOneMeaningIndex)
        {
            CharRange chineseCharRangeFromVietPhraseOneMeaningIndex = GetChineseCharRangeFromVietPhraseOneMeaningIndex(vietPhraseOneMeaningIndex);
            if (chineseCharRangeFromVietPhraseOneMeaningIndex == null)
            {
                return 0;
            }
            return chineseCharRangeFromVietPhraseOneMeaningIndex.StartIndex;
        }

        private int GetChineseEndIndexFromVietPhraseOneMeaningIndex(int vietPhraseOneMeaningEndIndex)
        {
            CharRange chineseCharRangeFromVietPhraseOneMeaningIndex = GetChineseCharRangeFromVietPhraseOneMeaningIndex(vietPhraseOneMeaningEndIndex);
            if (chineseCharRangeFromVietPhraseOneMeaningIndex == null)
            {
                return 0;
            }
            return chineseCharRangeFromVietPhraseOneMeaningIndex.GetEndIndex();
        }

        private void VietPhraseOneMeaning_AddToVietPhraseHandler(int type)
        {
            int selectionStart = vietPhraseOneMeaningDocumentPanel.GetSelectionStart();
            int chineseStartIndexFromVietPhraseOneMeaningIndex = GetChineseStartIndexFromVietPhraseOneMeaningIndex(selectionStart);
            if (chineseStartIndexFromVietPhraseOneMeaningIndex <= 0)
            {
                chineseStartIndexFromVietPhraseOneMeaningIndex = GetChineseStartIndexFromVietPhraseOneMeaningIndex(selectionStart + 1);
            }
            if (chineseStartIndexFromVietPhraseOneMeaningIndex <= 0)
            {
                return;
            }
            int num = vietPhraseOneMeaningDocumentPanel.GetSelectionStart() + vietPhraseOneMeaningDocumentPanel.GetSelectionLength() - 1;
            int chineseEndIndexFromVietPhraseOneMeaningIndex = GetChineseEndIndexFromVietPhraseOneMeaningIndex(num);
            if (chineseEndIndexFromVietPhraseOneMeaningIndex <= 0)
            {
                chineseEndIndexFromVietPhraseOneMeaningIndex = GetChineseEndIndexFromVietPhraseOneMeaningIndex(num - 1);
            }
            if (chineseEndIndexFromVietPhraseOneMeaningIndex <= 0 || chineseEndIndexFromVietPhraseOneMeaningIndex < chineseStartIndexFromVietPhraseOneMeaningIndex)
            {
                return;
            }
            string chineseToLookup = chineseDocumentPanel.GetTextContent().Substring(chineseStartIndexFromVietPhraseOneMeaningIndex, chineseEndIndexFromVietPhraseOneMeaningIndex - chineseStartIndexFromVietPhraseOneMeaningIndex + 1);
            UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(chineseToLookup, type);
            updateVietPhraseForm.ShowDialog();
            if (updateVietPhraseForm.NeedSurfBaike)
            {
                string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
                extendedBrowserPanel.Baikeing(chinese);
                extendedBrowserPanel.Activate();
            }
        }

        private void Meaning_AddToVietPhraseHandler(int type)
        {
            string selectedText = meaningDocumentPanel.GetSelectedText();
            UpdateVietPhraseForm updateVietPhraseForm = new UpdateVietPhraseForm(selectedText, type);
            updateVietPhraseForm.ShowDialog();
            if (updateVietPhraseForm.NeedSurfBaike)
            {
                string chinese = HttpUtility.UrlEncode(updateVietPhraseForm.ChinesePhraseToSurfBaike, Encoding.GetEncoding("gb2312"));
                extendedBrowserPanel.Baikeing(chinese);
                extendedBrowserPanel.Activate();
            }
        }

        private void Chinese_SelectTextHandler()
        {
            int selectionStart = chineseDocumentPanel.GetSelectionStart();
            int selectionLength = chineseDocumentPanel.GetSelectionLength();
            SelectTextInHanViet(selectionStart, selectionLength);
            SelectTextInVietPhrase(selectionStart, selectionLength);
            SelectTextInVietPhraseOneMeaning(selectionStart, selectionLength);
        }

        private void HanViet_SelectTextHandler()
        {
            int selectionStart = hanVietDocumentPanel.GetSelectionStart();
            int num = FindChineseCharIndexFromHanVietIndex(selectionStart);
            if (num <= 0)
            {
                num = FindChineseCharIndexFromHanVietIndex(selectionStart + 1);
            }
            if (num <= 0)
            {
                return;
            }
            int num2 = hanVietDocumentPanel.GetSelectionStart() + hanVietDocumentPanel.GetSelectionLength() - 1;
            int num3 = FindChineseCharIndexFromHanVietIndex(num2);
            if (num3 <= 0)
            {
                num3 = FindChineseCharIndexFromHanVietIndex(num2 - 1);
            }
            if (num3 <= 0 || num3 < num)
            {
                return;
            }
            SelectTextInChinese(num, num3 - num + 1);
            SelectTextInVietPhrase(num, num3 - num + 1);
            SelectTextInVietPhraseOneMeaning(num, num3 - num + 1);
        }

        private void VietPhrase_SelectTextHandler()
        {
            int selectionStart = vietPhraseDocumentPanel.GetSelectionStart();
            CharRange chineseCharRangeFromVietPhraseIndex = GetChineseCharRangeFromVietPhraseIndex(selectionStart);
            if (chineseCharRangeFromVietPhraseIndex == null)
            {
                chineseCharRangeFromVietPhraseIndex = GetChineseCharRangeFromVietPhraseIndex(selectionStart + 1);
            }
            if (chineseCharRangeFromVietPhraseIndex == null)
            {
                return;
            }
            int startIndex = chineseCharRangeFromVietPhraseIndex.StartIndex;
            int num = vietPhraseDocumentPanel.GetSelectionStart() + vietPhraseDocumentPanel.GetSelectionLength() - 1;
            if (GetChineseCharRangeFromVietPhraseIndex(num) == null)
            {
                return;
            }
            int endIndex = GetChineseCharRangeFromVietPhraseIndex(num).GetEndIndex();
            if (endIndex <= 0)
            {
                endIndex = GetChineseCharRangeFromVietPhraseIndex(num - 1).GetEndIndex();
                if (GetChineseCharRangeFromVietPhraseIndex(num - 1) == null)
                {
                    return;
                }
            }
            if (endIndex <= 0 || endIndex < startIndex)
            {
                return;
            }
            SelectTextInChinese(startIndex, endIndex - startIndex + 1);
            SelectTextInHanViet(startIndex, endIndex - startIndex + 1);
            SelectTextInVietPhraseOneMeaning(startIndex, endIndex - startIndex + 1);
        }

        private void VietPhraseOneMeaning_SelectTextHandler()
        {
            int selectionStart = vietPhraseOneMeaningDocumentPanel.GetSelectionStart();
            CharRange chineseCharRangeFromVietPhraseOneMeaningIndex = GetChineseCharRangeFromVietPhraseOneMeaningIndex(selectionStart);
            if (chineseCharRangeFromVietPhraseOneMeaningIndex == null)
            {
                chineseCharRangeFromVietPhraseOneMeaningIndex = GetChineseCharRangeFromVietPhraseOneMeaningIndex(selectionStart + 1);
            }
            if (chineseCharRangeFromVietPhraseOneMeaningIndex == null)
            {
                return;
            }
            int startIndex = chineseCharRangeFromVietPhraseOneMeaningIndex.StartIndex;
            int num = vietPhraseOneMeaningDocumentPanel.GetSelectionStart() + vietPhraseOneMeaningDocumentPanel.GetSelectionLength() - 1;
            CharRange chineseCharRangeFromVietPhraseOneMeaningIndex2 = GetChineseCharRangeFromVietPhraseOneMeaningIndex(num);
            if (chineseCharRangeFromVietPhraseOneMeaningIndex2 == null)
            {
                chineseCharRangeFromVietPhraseOneMeaningIndex2 = GetChineseCharRangeFromVietPhraseOneMeaningIndex(num - 1);
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
            SelectTextInChinese(startIndex, endIndex - startIndex + 1);
            SelectTextInVietPhrase(startIndex, endIndex - startIndex + 1);
            SelectTextInHanViet(startIndex, endIndex - startIndex + 1);
        }

        private void SelectTextInHanViet(int chineseStartIndex, int chineseLength)
        {
            CharRange hanVietCharRangeFromChineseRange = GetHanVietCharRangeFromChineseRange(chineseStartIndex, chineseLength);
            hanVietDocumentPanel.SelectText(hanVietCharRangeFromChineseRange.StartIndex, hanVietCharRangeFromChineseRange.Length);
        }

        private void SelectTextInChinese(int chineseStartIndex, int chineseLength)
        {
            chineseDocumentPanel.SelectText(chineseStartIndex, chineseLength);
        }

        private void SelectTextInVietPhrase(int chineseStartIndex, int chineseLength)
        {
            if (vietPhraseDocumentPanel.IsHidden)
            {
                return;
            }
            CharRange vietPhraseCharRangeFromChineseIndex = GetVietPhraseCharRangeFromChineseIndex(chineseStartIndex);
            CharRange vietPhraseCharRangeFromChineseIndex2 = GetVietPhraseCharRangeFromChineseIndex(chineseStartIndex + chineseLength - 1);
            vietPhraseDocumentPanel.SelectText(vietPhraseCharRangeFromChineseIndex.StartIndex, vietPhraseCharRangeFromChineseIndex2.GetEndIndex() - vietPhraseCharRangeFromChineseIndex.StartIndex + 1);
        }

        private void SelectTextInVietPhraseOneMeaning(int chineseStartIndex, int chineseLength)
        {
            if (vietPhraseOneMeaningDocumentPanel.IsHidden)
            {
                return;
            }
            CharRange vietPhraseOneMeaningCharRangeFromChineseIndex = GetVietPhraseOneMeaningCharRangeFromChineseIndex(chineseStartIndex);
            CharRange vietPhraseOneMeaningCharRangeFromChineseIndex2 = GetVietPhraseOneMeaningCharRangeFromChineseIndex(chineseStartIndex + chineseLength - 1);
            vietPhraseOneMeaningDocumentPanel.SelectText(vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex, vietPhraseOneMeaningCharRangeFromChineseIndex2.GetEndIndex() - vietPhraseOneMeaningCharRangeFromChineseIndex.StartIndex + 1);
        }

        private void BaikeingHandler()
        {
            string chinese = HttpUtility.UrlEncode(chineseDocumentPanel.GetSelectedText().Trim(), Encoding.GetEncoding("gb2312"));
            extendedBrowserPanel.Baikeing(chinese);
            extendedBrowserPanel.Activate();
        }

        private void NcikuingHandler()
        {
            string chinese = HttpUtility.UrlEncode(chineseDocumentPanel.GetSelectedText().Trim(), Encoding.GetEncoding("utf-8"));
            extendedBrowserPanel.Ncikuing(chinese);
            extendedBrowserPanel.Activate();
        }

        private void CopyToVietHandler(string textToCopy)
        {
            AppendToVietToCurrentCursor(textToCopy.Trim(new char[]
            {
                '[',
                ']'
            }));
        }

        private void AddToPhienAmHandler()
        {
            string selectedText = chineseDocumentPanel.GetSelectedText();
            if (string.IsNullOrEmpty(selectedText))
            {
                return;
            }
            new UpdatePhienAmForm(selectedText).ShowDialog();
        }

        private void DeleteSelectedTextHandler(bool remembered)
        {
            if (remembered)
            {
                string selectedText = chineseDocumentPanel.GetSelectedText();
                AddIgnoredChinesePhrase(selectedText);
            }
            chineseDocumentPanel.DeleteSelectedText();
            Retranslate();
        }

        private void ShiftAndMouseMoveHandler(int charIndexUnderMouse)
        {
            foreach (CharRange charRange in vietPhraseOneMeaningRanges)
            {
                if (charRange.IsInRange(charIndexUnderMouse))
                {
                    vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectionStart = charRange.StartIndex;
                    vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectionLength = 0;
                    return;
                }
            }
        }

        private void ShiftUpHandler()
        {
            try
            {
                ShiftUpHandlerWithoutExceptionHandling();
            }
            catch (Exception exception)
            {
                string application = "QuickTranslator";
                Logger.Log(Path.GetDirectoryName(Application.ExecutablePath), application, exception);
            }
        }

        private void ShiftUpHandlerWithoutExceptionHandling()
        {
            int selectionStart = vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectionStart;
            int currentHighlightedTextStartIndex = vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextStartIndex;
            int currentHighlightedTextLength = vietPhraseOneMeaningDocumentPanel.CurrentHighlightedTextLength;
            if (currentHighlightedTextStartIndex == selectionStart)
            {
                return;
            }
            string text = vietPhraseOneMeaningDocumentPanel.contentRichTextBox.Text;
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
                        CharRange chineseCharRangeFromVietPhraseOneMeaningIndex = GetChineseCharRangeFromVietPhraseOneMeaningIndex(selectionStart);
                        if (chineseCharRangeFromVietPhraseOneMeaningIndex != null && GetName(chineseContent.Substring(chineseCharRangeFromVietPhraseOneMeaningIndex.StartIndex, chineseCharRangeFromVietPhraseOneMeaningIndex.Length)) == null)
                        {
                            text4 = text4.Substring(0, num3) + char.ToLower(text4[num3]) + text4.Substring(num3 + 1);
                        }
                    }
                    vietPhraseOneMeaningDocumentPanel.SelectText(num, text2.Length);
                    vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectionColor = vietPhraseOneMeaningDocumentPanel.contentRichTextBox.ForeColor;
                    vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectedText = text4;
                    vietPhraseOneMeaningDocumentPanel.HighlightText(num, 0);
                    foreach (CharRange charRange in vietPhraseOneMeaningRanges)
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
                    vietPhraseOneMeaningChanged = true;
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
                if (GetName(chineseDocumentPanel.GetHighlightText()) == null)
                {
                    text4 = text4.Substring(0, num5) + char.ToLower(text4[num5]) + text4.Substring(num5 + 1);
                }
            }
            vietPhraseOneMeaningDocumentPanel.SelectText(num, text2.Length);
            vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectionColor = vietPhraseOneMeaningDocumentPanel.contentRichTextBox.ForeColor;
            vietPhraseOneMeaningDocumentPanel.contentRichTextBox.SelectedText = text4;
            vietPhraseOneMeaningDocumentPanel.HighlightText(num, 0);
            foreach (CharRange charRange2 in vietPhraseOneMeaningRanges)
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
            vietPhraseOneMeaningChanged = true;
        }

        private void RetranslateToolStripButtonClick(object sender, EventArgs e)
        {
            int currentLineIndex = chineseDocumentPanel.GetCurrentLineIndex();
            UpdateDocumentPanel(chineseDocumentPanel, NormalizeTextAndRemoveIgnoredChinesePhrases(chineseDocumentPanel.GetTextContent()), currentLineIndex);
            Retranslate();
        }

        public void Retranslate()
        {
            if (vietPhraseOneMeaningChanged)
            {
                DialogResult dialogResult = MessageBox.Show("Ô VietPhrase một nghĩa đã được thay đổi.\nNội dung thay đổi sẽ bị mất nếu tiếp tục.", "Re-Translate?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }
            int currentLineIndex = hanVietDocumentPanel.GetCurrentLineIndex();
            int currentLineIndex2 = vietPhraseDocumentPanel.GetCurrentLineIndex();
            int currentLineIndex3 = vietPhraseOneMeaningDocumentPanel.GetCurrentLineIndex();
            Translate(currentLineIndex, currentLineIndex2, currentLineIndex3);
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
                string fileName = array[0];
                OpenFile(fileName);
            }
        }

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
                chineseDocumentPanel.SetTextContent(NormalizeTextAndRemoveIgnoredChinesePhrases(original));
                string rftContent = text.Substring(text.IndexOf("[Viet]\n") + "[Viet]\n".Length);
                vietDocumentPanel.SetRftContent(rftContent);
                vietDocumentPanel.AppendText("");
                vietDocumentPanel.ScrollToBottom();
                vietDocumentPanel.FocusInRichTextBox();
                Text = "Quick Translator - " + fileName;
                workingFilePath = fileName;
                isNewTranslationWork = false;
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
                if (string.IsNullOrEmpty(vietDocumentPanel.GetTextContent().Trim()))
                {
                    Translate(currentHanVietDisplayedLine, currentVietPhraseDisplayedLine, currentVietPhraseOneMeaningDisplayedLine);
                }
                else
                {
                    Translate(-1, -1, -1);
                }
            }
            else if (fileName.EndsWith(".doc"))
            {
                OpenWord(fileName);
                Translate(-1, -1, -1);
            }
            else
            {
                OpenOtherFile(fileName);
            }
            AutoScrollToolStripButtonClick(null, null);
            workingFilePath = fileName;
            ToggleNextBackButtons();
        }

        private void OpenOtherFile(string fileName)
        {
            string name = CharsetDetector.DetectChineseCharset(fileName);
            string text = File.ReadAllText(fileName, Encoding.GetEncoding(name));
            isNewTranslationWork = true;
            if (fileName.EndsWith("html") || fileName.EndsWith("htm") || fileName.EndsWith("asp") || fileName.EndsWith("aspx") || fileName.EndsWith("php"))
            {
                text = HtmlScrapper.GetChineseContent(text, false);
            }
            text = NormalizeTextAndRemoveIgnoredChinesePhrases(text);
            chineseDocumentPanel.SetTextContent(text);
            Text = "Quick Translator - " + fileName;
            Translate(-2, -2, -2);
        }

        private void OpenWord(string filePath)
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
                Logger.Log(Path.GetDirectoryName(Application.ExecutablePath), application, exception);
                return;
            }
            chineseDocumentPanel.SetTextContent(NormalizeTextAndRemoveIgnoredChinesePhrases(original));
            vietDocumentPanel.SetTextContent(textContent);
            vietDocumentPanel.ScrollToBottom();
            vietDocumentPanel.FocusInRichTextBox();
            Text = "Quick Translator - " + filePath;
            workingFilePath = filePath;
            isNewTranslationWork = false;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void VietPhraseToolStripMenuItemCheckStateChanged(object sender, EventArgs e)
        {
            ActiveConfiguration.Layout_VietPhrase = vietPhraseToolStripMenuItem.Checked;
            ActiveConfiguration.SaveToFile(applicationConfigFilePath);
            configurationPanel.ReloadConfiguration();
            ToggleDocumentPanel(vietPhraseDocumentPanel, ActiveConfiguration.Layout_VietPhrase);
            int currentLineIndex = vietPhraseDocumentPanel.GetCurrentLineIndex();
            TranslateVietPhrase(currentLineIndex);
        }

        private void VietPhraseOneMeaningToolStripMenuItemCheckStateChanged(object sender, EventArgs e)
        {
            ActiveConfiguration.Layout_VietPhraseOneMeaning = vietPhraseOneMeaningToolStripMenuItem.Checked;
            ActiveConfiguration.SaveToFile(applicationConfigFilePath);
            configurationPanel.ReloadConfiguration();
            ToggleDocumentPanel(vietPhraseOneMeaningDocumentPanel, ActiveConfiguration.Layout_VietPhraseOneMeaning);
            int currentLineIndex = vietPhraseOneMeaningDocumentPanel.GetCurrentLineIndex();
            TranslateVietPhraseOneMeaning(currentLineIndex);
        }

        private void ToggleDocumentPanel(DocumentPanel panel, bool shown)
        {
            if (shown)
            {
                panel.Show();
                return;
            }
            panel.Hide();
        }

        private void VietPhraseToolStripMenuItemClick(object sender, EventArgs e)
        {
            vietPhraseToolStripMenuItem.Checked = !vietPhraseToolStripMenuItem.Checked;
        }

        private void VietPhraseOneMeaningToolStripMenuItemClick(object sender, EventArgs e)
        {
            vietPhraseOneMeaningToolStripMenuItem.Checked = !vietPhraseOneMeaningToolStripMenuItem.Checked;
        }

        private void ImportFromWordToolStripMenuItemClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "Microsoft Word 2003 (*.doc)|*.doc"
            };
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            OpenWord(openFileDialog.FileName);
            Translate(-1, -1, -1);
        }

        private void ToggleNextBackButtons()
        {
            editingStartDateTime = DateTime.Now;
            if (string.IsNullOrEmpty(workingFilePath))
            {
                backToolStripButton.Enabled = false;
                nextToolStripButton.Enabled = false;
                return;
            }
            FileInfo fileInfo = new FileInfo(workingFilePath);
            string[] files = Directory.GetFiles(fileInfo.Directory.FullName);
            List<string> list = new List<string>(files);
            list.Sort();
            int num = list.FindIndex((string filePath) => filePath == workingFilePath);
            if (num < 0)
            {
                backToolStripButton.Enabled = false;
                nextToolStripButton.Enabled = false;
                return;
            }
            backToolStripButton.Enabled = (0 < num);
            backFilePath = ((0 < num) ? list[num - 1] : "");
            nextToolStripButton.Enabled = (num < files.Length - 1);
            nextFilePath = ((num < files.Length - 1) ? list[num + 1] : "");
        }

        private void BackToolStripButtonClick(object sender, EventArgs e)
        {
            if (!File.Exists(backFilePath))
            {
                ToggleNextBackButtons();
            }
            if (File.Exists(backFilePath))
            {
                OpenFile(backFilePath);
            }
        }

        private void NextToolStripButtonClick(object sender, EventArgs e)
        {
            if (!File.Exists(nextFilePath))
            {
                ToggleNextBackButtons();
            }
            if (File.Exists(nextFilePath))
            {
                OpenFile(nextFilePath);
            }
        }

        private void CalculateChineseWordCount()
        {
            int num = 0;
            string textContent = chineseDocumentPanel.GetTextContent();
            foreach (char character in textContent)
            {
                if (IsChineseChar(character))
                {
                    num++;
                }
            }
            wordCountToolStripStatusLabel.Text = num.ToString("N0") + " từ";
        }

        private DocumentPanel vietPhraseDocumentPanel = new DocumentPanel(true);

        private DocumentPanel hanVietDocumentPanel = new DocumentPanel(true);

        private DocumentPanel vietDocumentPanel = new DocumentPanel();

        private DocumentPanel chineseDocumentPanel = new DocumentPanel();

        private DocumentPanel meaningDocumentPanel = new DocumentPanel(true);

        private DocumentPanel vietPhraseOneMeaningDocumentPanel = new DocumentPanel(true);

        private BrowserForm extendedBrowserPanel = new BrowserForm();

        private ConfigurationPanel configurationPanel = new ConfigurationPanel(applicationConfigFilePath);

        private static string dockPanelConfigFilePath = Path.Combine(Constants.ConfigsDir, "QuickTranslatorDockPanel.config");

        private static string applicationConfigFilePath = Path.Combine(Constants.ConfigsDir, "QuickTranslatorMain.config");

        private static string shortcutDictionaryFilePath = Path.Combine(Constants.AssetsDir, "Shortcuts.txt");

        private CharRange[] chineseHanVietMappingArray;

        private CharRange[] chinesePhraseRanges;

        private CharRange[] vietPhraseRanges;

        private CharRange[] vietPhraseOneMeaningRanges;

        private string workingFilePath;

        private bool isNewTranslationWork;

        private DeserializeDockContent deserializeDockContent;

        private string hanVietContent;

        private string vietPhraseContent;

        private string vietPhraseOneMeaningContent;

        private string chineseContent;

        public static Configuration ActiveConfiguration = Configuration.LoadFromFile(applicationConfigFilePath);

        private bool vietPhraseOneMeaningChanged;

        private string nextFilePath;

        private string backFilePath;

        private DateTime editingStartDateTime = DateTime.Now;

        private delegate void GenericDelegate();
    }
}

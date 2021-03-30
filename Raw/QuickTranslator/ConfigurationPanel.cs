using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace QuickTranslator
{
    public partial class ConfigurationPanel : DockContent
    {
        public ConfigurationPanel(string configFilePath)
        {
            InitializeComponent();
            DockHandler.GetPersistStringCallback = new GetPersistStringCallback(GetPersistStringFromText);
            this.configFilePath = configFilePath;
            configuration = Configuration.LoadFromFile(configFilePath);
        }

        public void ReloadConfiguration()
        {
            configuration = Configuration.LoadFromFile(configFilePath);
            ConfigurationToGui();
        }

        public string GetPersistStringFromText()
        {
            return Text;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            GuiToConfiguration();
            configuration.SaveToFile(configFilePath);
            MainForm.ActiveConfiguration = Configuration.LoadFromFile(configFilePath);
            if (needToRetranslate && ParentForm is MainForm form)
            {
                form.Retranslate();
                needToRetranslate = false;
            }
            if (needToResetPanelStyle && ParentForm is MainForm form1)
            {
                form1.SetPanelStyle();
                needToResetPanelStyle = false;
            }
            UndoDockState();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            ConfigurationToGui();
            UndoDockState();
        }

        private void ConfigurationToGui()
        {
            browserPanel_DisableImagesCheckBox.Checked = configuration.BrowserPanel_DisableImages;
            browserPanel_DisablePopupsCheckBox.Checked = configuration.BrowserPanel_DisablePopups;
            vietPhrase_NoWrapRadioButton.Checked = (configuration.VietPhrase_Wrap == 0);
            vietPhrase_AlwaysWrapRadioButton.Checked = (configuration.VietPhrase_Wrap == 1);
            vietPhrase_AlwaysWrapExceptHanVietRadioButton.Checked = (configuration.VietPhrase_Wrap == 11);
            vietPhrase_OnlyWrapTwoMeaningRadioButton.Checked = (configuration.VietPhrase_Wrap == 2);
            vietPhraseOneMeaning_NoWrapRadioButton.Checked = (configuration.VietPhraseOneMeaning_Wrap == 0);
            vietPhraseOneMeaning_AlwaysWrapRadioButton.Checked = (configuration.VietPhraseOneMeaning_Wrap == 1);
            vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Checked = (configuration.VietPhraseOneMeaning_Wrap == 11);
            hotKeys_CopyHighlightedHanVietTextBox.Text = configuration.HotKeys_CopyHighlightedHanViet.ToString();
            hotKeys_CopyMeaning1TextBox.Text = configuration.HotKeys_CopyMeaning1.ToString();
            hotKeys_CopyMeaning2TextBox.Text = configuration.HotKeys_CopyMeaning2.ToString();
            hotKeys_CopyMeaning3TextBox.Text = configuration.HotKeys_CopyMeaning3.ToString();
            hotKeys_CopyMeaning4TextBox.Text = configuration.HotKeys_CopyMeaning4.ToString();
            hotKeys_CopyMeaning5TextBox.Text = configuration.HotKeys_CopyMeaning5.ToString();
            hotKeys_CopyMeaning6TextBox.Text = configuration.HotKeys_CopyMeaning6.ToString();
            hotKeys_MoveDownOneLineTextBox.Text = configuration.HotKeys_MoveDownOneLine.ToString();
            hotKeys_MoveDownOneParagraphTextBox.Text = configuration.HotKeys_MoveDownOneParagraph.ToString();
            hotKeys_MoveLeftOneWordTextBox.Text = configuration.HotKeys_MoveLeftOneWord.ToString();
            hotKeys_MoveRightOneWordTextBox.Text = configuration.HotKeys_MoveRightOneWord.ToString();
            hotKeys_MoveUpOneLineTextBox.Text = configuration.HotKeys_MoveUpOneLine.ToString();
            hotKeys_MoveUpOneParagraphTextBox.Text = configuration.HotKeys_MoveUpOneParagraph.ToString();
            f1TextBox.Text = configuration.HotKeys_F1;
            f2TextBox.Text = configuration.HotKeys_F2;
            f3TextBox.Text = configuration.HotKeys_F3;
            f4TextBox.Text = configuration.HotKeys_F4;
            f5TextBox.Text = configuration.HotKeys_F5;
            f6TextBox.Text = configuration.HotKeys_F6;
            f7TextBox.Text = configuration.HotKeys_F7;
            f8TextBox.Text = configuration.HotKeys_F8;
            f9TextBox.Text = configuration.HotKeys_F9;
            trungLabel.Font = configuration.Style_TrungFont;
            trungLabel.ForeColor = configuration.Style_TrungForeColor;
            trungLabel.BackColor = configuration.Style_TrungBackColor;
            hanVietLabel.Font = configuration.Style_HanVietFont;
            hanVietLabel.ForeColor = configuration.Style_HanVietForeColor;
            hanVietLabel.BackColor = configuration.Style_HanVietBackColor;
            vietPhraseLabel.Font = configuration.Style_VietPhraseFont;
            vietPhraseLabel.ForeColor = configuration.Style_VietPhraseForeColor;
            vietPhraseLabel.BackColor = configuration.Style_VietPhraseBackColor;
            vietPhraseOneMeaningLabel.Font = configuration.Style_VietPhraseOneMeaningFont;
            vietPhraseOneMeaningLabel.ForeColor = configuration.Style_VietPhraseOneMeaningForeColor;
            vietPhraseOneMeaningLabel.BackColor = configuration.Style_VietPhraseOneMeaningBackColor;
            vietLabel.Font = configuration.Style_VietFont;
            vietLabel.ForeColor = configuration.Style_VietForeColor;
            vietLabel.BackColor = configuration.Style_VietBackColor;
            nghiaLabel.Font = configuration.Style_NghiaFont;
            nghiaLabel.ForeColor = configuration.Style_NghiaForeColor;
            nghiaLabel.BackColor = configuration.Style_NghiaBackColor;
            algorithm_LongestVietPhraseFirstRadioButton.Checked = (configuration.TranslationAlgorithm == 0);
            algorithm_LeftToRightRadioButton.Checked = (configuration.TranslationAlgorithm == 1);
            algorithm_LongestVietPhraseFirstWithConditionRadioButton.Checked = (configuration.TranslationAlgorithm == 2);
            prioritizedNameCheckBox.Checked = configuration.PrioritizedName;
            alwaysFocusInVietCheckBox.Checked = configuration.AlwaysFocusInViet;
            needToRetranslate = false;
        }

        private void GuiToConfiguration()
        {
            configuration.BrowserPanel_DisableImages = browserPanel_DisableImagesCheckBox.Checked;
            configuration.BrowserPanel_DisablePopups = browserPanel_DisablePopupsCheckBox.Checked;
            configuration.VietPhrase_Wrap = (vietPhrase_NoWrapRadioButton.Checked ? 0 : (vietPhrase_AlwaysWrapRadioButton.Checked ? 1 : (vietPhrase_AlwaysWrapExceptHanVietRadioButton.Checked ? 11 : 2)));
            configuration.VietPhraseOneMeaning_Wrap = (vietPhraseOneMeaning_NoWrapRadioButton.Checked ? 0 : (vietPhraseOneMeaning_AlwaysWrapRadioButton.Checked ? 1 : 11));
            configuration.HotKeys_CopyHighlightedHanViet = ((hotKeys_CopyHighlightedHanVietTextBox.Text.Length == 0) ? '0' : hotKeys_CopyHighlightedHanVietTextBox.Text[0]);
            configuration.HotKeys_CopyMeaning1 = ((hotKeys_CopyMeaning1TextBox.Text.Length == 0) ? '1' : hotKeys_CopyMeaning1TextBox.Text[0]);
            configuration.HotKeys_CopyMeaning2 = ((hotKeys_CopyMeaning2TextBox.Text.Length == 0) ? '2' : hotKeys_CopyMeaning2TextBox.Text[0]);
            configuration.HotKeys_CopyMeaning3 = ((hotKeys_CopyMeaning3TextBox.Text.Length == 0) ? '3' : hotKeys_CopyMeaning3TextBox.Text[0]);
            configuration.HotKeys_CopyMeaning4 = ((hotKeys_CopyMeaning4TextBox.Text.Length == 0) ? '4' : hotKeys_CopyMeaning4TextBox.Text[0]);
            configuration.HotKeys_CopyMeaning5 = ((hotKeys_CopyMeaning5TextBox.Text.Length == 0) ? '5' : hotKeys_CopyMeaning5TextBox.Text[0]);
            configuration.HotKeys_CopyMeaning6 = ((hotKeys_CopyMeaning6TextBox.Text.Length == 0) ? '6' : hotKeys_CopyMeaning6TextBox.Text[0]);
            configuration.HotKeys_MoveDownOneLine = ((hotKeys_MoveDownOneLineTextBox.Text.Length == 0) ? 'M' : hotKeys_MoveDownOneLineTextBox.Text[0]);
            configuration.HotKeys_MoveDownOneParagraph = ((hotKeys_MoveDownOneParagraphTextBox.Text.Length == 0) ? 'N' : hotKeys_MoveDownOneParagraphTextBox.Text[0]);
            configuration.HotKeys_MoveLeftOneWord = ((hotKeys_MoveLeftOneWordTextBox.Text.Length == 0) ? 'J' : hotKeys_MoveLeftOneWordTextBox.Text[0]);
            configuration.HotKeys_MoveRightOneWord = ((hotKeys_MoveRightOneWordTextBox.Text.Length == 0) ? 'K' : hotKeys_MoveRightOneWordTextBox.Text[0]);
            configuration.HotKeys_MoveUpOneLine = ((hotKeys_MoveUpOneLineTextBox.Text.Length == 0) ? 'I' : hotKeys_MoveUpOneLineTextBox.Text[0]);
            configuration.HotKeys_MoveUpOneParagraph = ((hotKeys_MoveUpOneParagraphTextBox.Text.Length == 0) ? 'U' : hotKeys_MoveUpOneParagraphTextBox.Text[0]);
            configuration.HotKeys_F1 = f1TextBox.Text;
            configuration.HotKeys_F2 = f2TextBox.Text;
            configuration.HotKeys_F3 = f3TextBox.Text;
            configuration.HotKeys_F4 = f4TextBox.Text;
            configuration.HotKeys_F5 = f5TextBox.Text;
            configuration.HotKeys_F6 = f6TextBox.Text;
            configuration.HotKeys_F7 = f7TextBox.Text;
            configuration.HotKeys_F8 = f8TextBox.Text;
            configuration.HotKeys_F9 = f9TextBox.Text;
            configuration.Style_TrungFont = trungLabel.Font;
            configuration.Style_TrungForeColor = trungLabel.ForeColor;
            configuration.Style_TrungBackColor = trungLabel.BackColor;
            configuration.Style_HanVietFont = hanVietLabel.Font;
            configuration.Style_HanVietForeColor = hanVietLabel.ForeColor;
            configuration.Style_HanVietBackColor = hanVietLabel.BackColor;
            configuration.Style_VietPhraseFont = vietPhraseLabel.Font;
            configuration.Style_VietPhraseForeColor = vietPhraseLabel.ForeColor;
            configuration.Style_VietPhraseBackColor = vietPhraseLabel.BackColor;
            configuration.Style_VietPhraseOneMeaningFont = vietPhraseOneMeaningLabel.Font;
            configuration.Style_VietPhraseOneMeaningForeColor = vietPhraseOneMeaningLabel.ForeColor;
            configuration.Style_VietPhraseOneMeaningBackColor = vietPhraseOneMeaningLabel.BackColor;
            configuration.Style_VietFont = vietLabel.Font;
            configuration.Style_VietForeColor = vietLabel.ForeColor;
            configuration.Style_VietBackColor = vietLabel.BackColor;
            configuration.Style_NghiaFont = nghiaLabel.Font;
            configuration.Style_NghiaForeColor = nghiaLabel.ForeColor;
            configuration.Style_NghiaBackColor = nghiaLabel.BackColor;
            configuration.TranslationAlgorithm = (algorithm_LongestVietPhraseFirstRadioButton.Checked ? 0 : (algorithm_LeftToRightRadioButton.Checked ? 1 : 2));
            configuration.PrioritizedName = prioritizedNameCheckBox.Checked;
            configuration.AlwaysFocusInViet = alwaysFocusInVietCheckBox.Checked;
        }

        private void ConfigurationPanelLoad(object sender, EventArgs e)
        {
            ConfigurationToGui();
        }

        private void VietPhrase_NoWrapRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            needToRetranslate = true;
        }

        private void VietPhrase_AlwaysWrapRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            needToRetranslate = true;
        }

        private void VietPhrase_OnlyWrapTwoMeaningRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            needToRetranslate = true;
        }

        private void VietPhraseOneMeaning_NoWrapRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            needToRetranslate = true;
        }

        private void VietPhraseOneMeaning_AlwaysWrapRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            needToRetranslate = true;
        }

        private void ToDockFix()
        {
            if (DockState == DockState.DockBottomAutoHide)
            {
                DockState = DockState.DockBottom;
                return;
            }
            if (DockState == DockState.DockLeftAutoHide)
            {
                DockState = DockState.DockLeft;
                return;
            }
            if (DockState == DockState.DockRightAutoHide)
            {
                DockState = DockState.DockRight;
                return;
            }
            if (DockState == DockState.DockTopAutoHide)
            {
                DockState = DockState.DockTop;
            }
        }

        private void UndoDockState()
        {
            if (DockState == DockState.DockBottom)
            {
                DockState = DockState.DockBottomAutoHide;
                return;
            }
            if (DockState == DockState.DockLeft)
            {
                DockState = DockState.DockLeftAutoHide;
                return;
            }
            if (DockState == DockState.DockRight)
            {
                DockState = DockState.DockRightAutoHide;
                return;
            }
            if (DockState == DockState.DockTop)
            {
                DockState = DockState.DockTopAutoHide;
            }
        }

        private void ChangeFont(Label testLabel)
        {
            ToDockFix();
            fontDialog.Font = testLabel.Font;
            fontDialog.Color = testLabel.ForeColor;
            DialogResult dialogResult = fontDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                testLabel.Font = fontDialog.Font;
                testLabel.ForeColor = fontDialog.Color;
                needToResetPanelStyle = true;
            }
        }

        private void ChangeBackColor(Label testLabel)
        {
            ToDockFix();
            colorDialog.Color = testLabel.BackColor;
            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                testLabel.BackColor = colorDialog.Color;
                needToResetPanelStyle = true;
            }
        }

        private void TrungFontButtonClick(object sender, EventArgs e)
        {
            ChangeFont(trungLabel);
        }

        private void TrungBackColorButtonClick(object sender, EventArgs e)
        {
            ChangeBackColor(trungLabel);
        }

        private void HanVietFontButtonClick(object sender, EventArgs e)
        {
            ChangeFont(hanVietLabel);
        }

        private void HanVietBackColorButtonClick(object sender, EventArgs e)
        {
            ChangeBackColor(hanVietLabel);
        }

        private void VietPhraseFontButtonClick(object sender, EventArgs e)
        {
            ChangeFont(vietPhraseLabel);
        }

        private void VietPhraseBackColorButtonClick(object sender, EventArgs e)
        {
            ChangeBackColor(vietPhraseLabel);
        }

        private void VietPhraseOneMeaningFontButtonClick(object sender, EventArgs e)
        {
            ChangeFont(vietPhraseOneMeaningLabel);
        }

        private void VietPhraseOneMeaningBackColorButtonClick(object sender, EventArgs e)
        {
            ChangeBackColor(vietPhraseOneMeaningLabel);
        }

        private void VietFontButtonClick(object sender, EventArgs e)
        {
            ChangeFont(vietLabel);
        }

        private void VietBackColorButtonClick(object sender, EventArgs e)
        {
            ChangeBackColor(vietLabel);
        }

        private void NghiaFontButtonClick(object sender, EventArgs e)
        {
            ChangeFont(nghiaLabel);
        }

        private void NghiaBackColorButtonClick(object sender, EventArgs e)
        {
            ChangeBackColor(nghiaLabel);
        }

        private void Algorithm_LongestVietPhraseFirstRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            needToRetranslate = true;
        }

        private void Algorithm_LeftToRightRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            needToRetranslate = true;
        }

        private void Algorithm_LongestVietPhraseFirstWithConditionRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            needToRetranslate = true;
        }

        private void PrioritizedNameCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            needToRetranslate = true;
        }

        private Configuration configuration;

        private string configFilePath;

        private bool needToRetranslate;

        private bool needToResetPanelStyle;
    }
}

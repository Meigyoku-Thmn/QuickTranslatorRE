using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace QuickTranslator
{
	// Token: 0x02000003 RID: 3
	public partial class ConfigurationPanel : DockContent
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002320 File Offset: 0x00001320
		public ConfigurationPanel(string configFilePath)
		{
			this.InitializeComponent();
			base.DockHandler.GetPersistStringCallback = new GetPersistStringCallback(this.GetPersistStringFromText);
			this.configFilePath = configFilePath;
			this.configuration = Configuration.LoadFromFile(configFilePath);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002358 File Offset: 0x00001358
		public void ReloadConfiguration()
		{
			this.configuration = Configuration.LoadFromFile(this.configFilePath);
			this.configurationToGui();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002371 File Offset: 0x00001371
		public string GetPersistStringFromText()
		{
			return this.Text;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000237C File Offset: 0x0000137C
		private void SaveButtonClick(object sender, EventArgs e)
		{
			this.guiToConfiguration();
			this.configuration.SaveToFile(this.configFilePath);
			MainForm.ActiveConfiguration = Configuration.LoadFromFile(this.configFilePath);
			if (this.needToRetranslate && base.ParentForm is MainForm)
			{
				((MainForm)base.ParentForm).Retranslate();
				this.needToRetranslate = false;
			}
			if (this.needToResetPanelStyle && base.ParentForm is MainForm)
			{
				((MainForm)base.ParentForm).SetPanelStyle();
				this.needToResetPanelStyle = false;
			}
			this.UndoDockState();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000240E File Offset: 0x0000140E
		private void CancelButtonClick(object sender, EventArgs e)
		{
			this.configurationToGui();
			this.UndoDockState();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000241C File Offset: 0x0000141C
		private void configurationToGui()
		{
			this.browserPanel_DisableImagesCheckBox.Checked = this.configuration.BrowserPanel_DisableImages;
			this.browserPanel_DisablePopupsCheckBox.Checked = this.configuration.BrowserPanel_DisablePopups;
			this.vietPhrase_NoWrapRadioButton.Checked = (this.configuration.VietPhrase_Wrap == 0);
			this.vietPhrase_AlwaysWrapRadioButton.Checked = (this.configuration.VietPhrase_Wrap == 1);
			this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Checked = (this.configuration.VietPhrase_Wrap == 11);
			this.vietPhrase_OnlyWrapTwoMeaningRadioButton.Checked = (this.configuration.VietPhrase_Wrap == 2);
			this.vietPhraseOneMeaning_NoWrapRadioButton.Checked = (this.configuration.VietPhraseOneMeaning_Wrap == 0);
			this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Checked = (this.configuration.VietPhraseOneMeaning_Wrap == 1);
			this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Checked = (this.configuration.VietPhraseOneMeaning_Wrap == 11);
			this.hotKeys_CopyHighlightedHanVietTextBox.Text = this.configuration.HotKeys_CopyHighlightedHanViet.ToString();
			this.hotKeys_CopyMeaning1TextBox.Text = this.configuration.HotKeys_CopyMeaning1.ToString();
			this.hotKeys_CopyMeaning2TextBox.Text = this.configuration.HotKeys_CopyMeaning2.ToString();
			this.hotKeys_CopyMeaning3TextBox.Text = this.configuration.HotKeys_CopyMeaning3.ToString();
			this.hotKeys_CopyMeaning4TextBox.Text = this.configuration.HotKeys_CopyMeaning4.ToString();
			this.hotKeys_CopyMeaning5TextBox.Text = this.configuration.HotKeys_CopyMeaning5.ToString();
			this.hotKeys_CopyMeaning6TextBox.Text = this.configuration.HotKeys_CopyMeaning6.ToString();
			this.hotKeys_MoveDownOneLineTextBox.Text = this.configuration.HotKeys_MoveDownOneLine.ToString();
			this.hotKeys_MoveDownOneParagraphTextBox.Text = this.configuration.HotKeys_MoveDownOneParagraph.ToString();
			this.hotKeys_MoveLeftOneWordTextBox.Text = this.configuration.HotKeys_MoveLeftOneWord.ToString();
			this.hotKeys_MoveRightOneWordTextBox.Text = this.configuration.HotKeys_MoveRightOneWord.ToString();
			this.hotKeys_MoveUpOneLineTextBox.Text = this.configuration.HotKeys_MoveUpOneLine.ToString();
			this.hotKeys_MoveUpOneParagraphTextBox.Text = this.configuration.HotKeys_MoveUpOneParagraph.ToString();
			this.f1TextBox.Text = this.configuration.HotKeys_F1;
			this.f2TextBox.Text = this.configuration.HotKeys_F2;
			this.f3TextBox.Text = this.configuration.HotKeys_F3;
			this.f4TextBox.Text = this.configuration.HotKeys_F4;
			this.f5TextBox.Text = this.configuration.HotKeys_F5;
			this.f6TextBox.Text = this.configuration.HotKeys_F6;
			this.f7TextBox.Text = this.configuration.HotKeys_F7;
			this.f8TextBox.Text = this.configuration.HotKeys_F8;
			this.f9TextBox.Text = this.configuration.HotKeys_F9;
			this.trungLabel.Font = this.configuration.Style_TrungFont;
			this.trungLabel.ForeColor = this.configuration.Style_TrungForeColor;
			this.trungLabel.BackColor = this.configuration.Style_TrungBackColor;
			this.hanVietLabel.Font = this.configuration.Style_HanVietFont;
			this.hanVietLabel.ForeColor = this.configuration.Style_HanVietForeColor;
			this.hanVietLabel.BackColor = this.configuration.Style_HanVietBackColor;
			this.vietPhraseLabel.Font = this.configuration.Style_VietPhraseFont;
			this.vietPhraseLabel.ForeColor = this.configuration.Style_VietPhraseForeColor;
			this.vietPhraseLabel.BackColor = this.configuration.Style_VietPhraseBackColor;
			this.vietPhraseOneMeaningLabel.Font = this.configuration.Style_VietPhraseOneMeaningFont;
			this.vietPhraseOneMeaningLabel.ForeColor = this.configuration.Style_VietPhraseOneMeaningForeColor;
			this.vietPhraseOneMeaningLabel.BackColor = this.configuration.Style_VietPhraseOneMeaningBackColor;
			this.vietLabel.Font = this.configuration.Style_VietFont;
			this.vietLabel.ForeColor = this.configuration.Style_VietForeColor;
			this.vietLabel.BackColor = this.configuration.Style_VietBackColor;
			this.nghiaLabel.Font = this.configuration.Style_NghiaFont;
			this.nghiaLabel.ForeColor = this.configuration.Style_NghiaForeColor;
			this.nghiaLabel.BackColor = this.configuration.Style_NghiaBackColor;
			this.algorithm_LongestVietPhraseFirstRadioButton.Checked = (this.configuration.TranslationAlgorithm == 0);
			this.algorithm_LeftToRightRadioButton.Checked = (this.configuration.TranslationAlgorithm == 1);
			this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.Checked = (this.configuration.TranslationAlgorithm == 2);
			this.prioritizedNameCheckBox.Checked = this.configuration.PrioritizedName;
			this.alwaysFocusInVietCheckBox.Checked = this.configuration.AlwaysFocusInViet;
			this.needToRetranslate = false;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002938 File Offset: 0x00001938
		private void guiToConfiguration()
		{
			this.configuration.BrowserPanel_DisableImages = this.browserPanel_DisableImagesCheckBox.Checked;
			this.configuration.BrowserPanel_DisablePopups = this.browserPanel_DisablePopupsCheckBox.Checked;
			this.configuration.VietPhrase_Wrap = (this.vietPhrase_NoWrapRadioButton.Checked ? 0 : (this.vietPhrase_AlwaysWrapRadioButton.Checked ? 1 : (this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Checked ? 11 : 2)));
			this.configuration.VietPhraseOneMeaning_Wrap = (this.vietPhraseOneMeaning_NoWrapRadioButton.Checked ? 0 : (this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Checked ? 1 : 11));
			this.configuration.HotKeys_CopyHighlightedHanViet = ((this.hotKeys_CopyHighlightedHanVietTextBox.Text.Length == 0) ? '0' : this.hotKeys_CopyHighlightedHanVietTextBox.Text[0]);
			this.configuration.HotKeys_CopyMeaning1 = ((this.hotKeys_CopyMeaning1TextBox.Text.Length == 0) ? '1' : this.hotKeys_CopyMeaning1TextBox.Text[0]);
			this.configuration.HotKeys_CopyMeaning2 = ((this.hotKeys_CopyMeaning2TextBox.Text.Length == 0) ? '2' : this.hotKeys_CopyMeaning2TextBox.Text[0]);
			this.configuration.HotKeys_CopyMeaning3 = ((this.hotKeys_CopyMeaning3TextBox.Text.Length == 0) ? '3' : this.hotKeys_CopyMeaning3TextBox.Text[0]);
			this.configuration.HotKeys_CopyMeaning4 = ((this.hotKeys_CopyMeaning4TextBox.Text.Length == 0) ? '4' : this.hotKeys_CopyMeaning4TextBox.Text[0]);
			this.configuration.HotKeys_CopyMeaning5 = ((this.hotKeys_CopyMeaning5TextBox.Text.Length == 0) ? '5' : this.hotKeys_CopyMeaning5TextBox.Text[0]);
			this.configuration.HotKeys_CopyMeaning6 = ((this.hotKeys_CopyMeaning6TextBox.Text.Length == 0) ? '6' : this.hotKeys_CopyMeaning6TextBox.Text[0]);
			this.configuration.HotKeys_MoveDownOneLine = ((this.hotKeys_MoveDownOneLineTextBox.Text.Length == 0) ? 'M' : this.hotKeys_MoveDownOneLineTextBox.Text[0]);
			this.configuration.HotKeys_MoveDownOneParagraph = ((this.hotKeys_MoveDownOneParagraphTextBox.Text.Length == 0) ? 'N' : this.hotKeys_MoveDownOneParagraphTextBox.Text[0]);
			this.configuration.HotKeys_MoveLeftOneWord = ((this.hotKeys_MoveLeftOneWordTextBox.Text.Length == 0) ? 'J' : this.hotKeys_MoveLeftOneWordTextBox.Text[0]);
			this.configuration.HotKeys_MoveRightOneWord = ((this.hotKeys_MoveRightOneWordTextBox.Text.Length == 0) ? 'K' : this.hotKeys_MoveRightOneWordTextBox.Text[0]);
			this.configuration.HotKeys_MoveUpOneLine = ((this.hotKeys_MoveUpOneLineTextBox.Text.Length == 0) ? 'I' : this.hotKeys_MoveUpOneLineTextBox.Text[0]);
			this.configuration.HotKeys_MoveUpOneParagraph = ((this.hotKeys_MoveUpOneParagraphTextBox.Text.Length == 0) ? 'U' : this.hotKeys_MoveUpOneParagraphTextBox.Text[0]);
			this.configuration.HotKeys_F1 = this.f1TextBox.Text;
			this.configuration.HotKeys_F2 = this.f2TextBox.Text;
			this.configuration.HotKeys_F3 = this.f3TextBox.Text;
			this.configuration.HotKeys_F4 = this.f4TextBox.Text;
			this.configuration.HotKeys_F5 = this.f5TextBox.Text;
			this.configuration.HotKeys_F6 = this.f6TextBox.Text;
			this.configuration.HotKeys_F7 = this.f7TextBox.Text;
			this.configuration.HotKeys_F8 = this.f8TextBox.Text;
			this.configuration.HotKeys_F9 = this.f9TextBox.Text;
			this.configuration.Style_TrungFont = this.trungLabel.Font;
			this.configuration.Style_TrungForeColor = this.trungLabel.ForeColor;
			this.configuration.Style_TrungBackColor = this.trungLabel.BackColor;
			this.configuration.Style_HanVietFont = this.hanVietLabel.Font;
			this.configuration.Style_HanVietForeColor = this.hanVietLabel.ForeColor;
			this.configuration.Style_HanVietBackColor = this.hanVietLabel.BackColor;
			this.configuration.Style_VietPhraseFont = this.vietPhraseLabel.Font;
			this.configuration.Style_VietPhraseForeColor = this.vietPhraseLabel.ForeColor;
			this.configuration.Style_VietPhraseBackColor = this.vietPhraseLabel.BackColor;
			this.configuration.Style_VietPhraseOneMeaningFont = this.vietPhraseOneMeaningLabel.Font;
			this.configuration.Style_VietPhraseOneMeaningForeColor = this.vietPhraseOneMeaningLabel.ForeColor;
			this.configuration.Style_VietPhraseOneMeaningBackColor = this.vietPhraseOneMeaningLabel.BackColor;
			this.configuration.Style_VietFont = this.vietLabel.Font;
			this.configuration.Style_VietForeColor = this.vietLabel.ForeColor;
			this.configuration.Style_VietBackColor = this.vietLabel.BackColor;
			this.configuration.Style_NghiaFont = this.nghiaLabel.Font;
			this.configuration.Style_NghiaForeColor = this.nghiaLabel.ForeColor;
			this.configuration.Style_NghiaBackColor = this.nghiaLabel.BackColor;
			this.configuration.TranslationAlgorithm = (this.algorithm_LongestVietPhraseFirstRadioButton.Checked ? 0 : (this.algorithm_LeftToRightRadioButton.Checked ? 1 : 2));
			this.configuration.PrioritizedName = this.prioritizedNameCheckBox.Checked;
			this.configuration.AlwaysFocusInViet = this.alwaysFocusInVietCheckBox.Checked;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002F0F File Offset: 0x00001F0F
		private void ConfigurationPanelLoad(object sender, EventArgs e)
		{
			this.configurationToGui();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002F17 File Offset: 0x00001F17
		private void VietPhrase_NoWrapRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.needToRetranslate = true;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002F20 File Offset: 0x00001F20
		private void VietPhrase_AlwaysWrapRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.needToRetranslate = true;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002F29 File Offset: 0x00001F29
		private void VietPhrase_OnlyWrapTwoMeaningRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.needToRetranslate = true;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002F32 File Offset: 0x00001F32
		private void VietPhraseOneMeaning_NoWrapRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.needToRetranslate = true;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002F3B File Offset: 0x00001F3B
		private void VietPhraseOneMeaning_AlwaysWrapRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.needToRetranslate = true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002F44 File Offset: 0x00001F44
		private void ToDockFix()
		{
			if (base.DockState == DockState.DockBottomAutoHide)
			{
				base.DockState = DockState.DockBottom;
				return;
			}
			if (base.DockState == DockState.DockLeftAutoHide)
			{
				base.DockState = DockState.DockLeft;
				return;
			}
			if (base.DockState == DockState.DockRightAutoHide)
			{
				base.DockState = DockState.DockRight;
				return;
			}
			if (base.DockState == DockState.DockTopAutoHide)
			{
				base.DockState = DockState.DockTop;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002F98 File Offset: 0x00001F98
		private void UndoDockState()
		{
			if (base.DockState == DockState.DockBottom)
			{
				base.DockState = DockState.DockBottomAutoHide;
				return;
			}
			if (base.DockState == DockState.DockLeft)
			{
				base.DockState = DockState.DockLeftAutoHide;
				return;
			}
			if (base.DockState == DockState.DockRight)
			{
				base.DockState = DockState.DockRightAutoHide;
				return;
			}
			if (base.DockState == DockState.DockTop)
			{
				base.DockState = DockState.DockTopAutoHide;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002FEC File Offset: 0x00001FEC
		private void ChangeFont(Label testLabel)
		{
			this.ToDockFix();
			this.fontDialog.Font = testLabel.Font;
			this.fontDialog.Color = testLabel.ForeColor;
			DialogResult dialogResult = this.fontDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				testLabel.Font = this.fontDialog.Font;
				testLabel.ForeColor = this.fontDialog.Color;
				this.needToResetPanelStyle = true;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000305C File Offset: 0x0000205C
		private void ChangeBackColor(Label testLabel)
		{
			this.ToDockFix();
			this.colorDialog.Color = testLabel.BackColor;
			DialogResult dialogResult = this.colorDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				testLabel.BackColor = this.colorDialog.Color;
				this.needToResetPanelStyle = true;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000030A8 File Offset: 0x000020A8
		private void TrungFontButtonClick(object sender, EventArgs e)
		{
			this.ChangeFont(this.trungLabel);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000030B6 File Offset: 0x000020B6
		private void TrungBackColorButtonClick(object sender, EventArgs e)
		{
			this.ChangeBackColor(this.trungLabel);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000030C4 File Offset: 0x000020C4
		private void HanVietFontButtonClick(object sender, EventArgs e)
		{
			this.ChangeFont(this.hanVietLabel);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000030D2 File Offset: 0x000020D2
		private void HanVietBackColorButtonClick(object sender, EventArgs e)
		{
			this.ChangeBackColor(this.hanVietLabel);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000030E0 File Offset: 0x000020E0
		private void VietPhraseFontButtonClick(object sender, EventArgs e)
		{
			this.ChangeFont(this.vietPhraseLabel);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000030EE File Offset: 0x000020EE
		private void VietPhraseBackColorButtonClick(object sender, EventArgs e)
		{
			this.ChangeBackColor(this.vietPhraseLabel);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000030FC File Offset: 0x000020FC
		private void VietPhraseOneMeaningFontButtonClick(object sender, EventArgs e)
		{
			this.ChangeFont(this.vietPhraseOneMeaningLabel);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000310A File Offset: 0x0000210A
		private void VietPhraseOneMeaningBackColorButtonClick(object sender, EventArgs e)
		{
			this.ChangeBackColor(this.vietPhraseOneMeaningLabel);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003118 File Offset: 0x00002118
		private void VietFontButtonClick(object sender, EventArgs e)
		{
			this.ChangeFont(this.vietLabel);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003126 File Offset: 0x00002126
		private void VietBackColorButtonClick(object sender, EventArgs e)
		{
			this.ChangeBackColor(this.vietLabel);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003134 File Offset: 0x00002134
		private void NghiaFontButtonClick(object sender, EventArgs e)
		{
			this.ChangeFont(this.nghiaLabel);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003142 File Offset: 0x00002142
		private void NghiaBackColorButtonClick(object sender, EventArgs e)
		{
			this.ChangeBackColor(this.nghiaLabel);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003150 File Offset: 0x00002150
		private void Algorithm_LongestVietPhraseFirstRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.needToRetranslate = true;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003159 File Offset: 0x00002159
		private void Algorithm_LeftToRightRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.needToRetranslate = true;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003162 File Offset: 0x00002162
		private void Algorithm_LongestVietPhraseFirstWithConditionRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.needToRetranslate = true;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000316B File Offset: 0x0000216B
		private void PrioritizedNameCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			this.needToRetranslate = true;
		}

		// Token: 0x04000033 RID: 51
		private Configuration configuration;

		// Token: 0x04000034 RID: 52
		private string configFilePath;

		// Token: 0x04000035 RID: 53
		private bool needToRetranslate;

		// Token: 0x04000036 RID: 54
		private bool needToResetPanelStyle;
	}
}

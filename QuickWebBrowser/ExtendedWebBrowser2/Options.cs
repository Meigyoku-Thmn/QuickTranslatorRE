using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtendedWebBrowser2
{
    internal partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            var settingsHelper = SettingsHelper.Current;
            switch (settingsHelper.FilterLevel)
            {
                case PopupBlockerFilterLevel.Low:
                    filterLevelLowRadioButton.Checked = true;
                    break;
                case PopupBlockerFilterLevel.Medium:
                    filterLevelMediumRadioButton.Checked = true;
                    break;
                case PopupBlockerFilterLevel.High:
                    filterLevelHighRadioButton.Checked = true;
                    break;
                default:
                    filterLevelNoneRadioButton.Checked = true;
                    break;
            }
            doNotShowScriptErrorsCheckBox.Checked = !settingsHelper.ShowScriptErrors;
            if (Environment.OSVersion.Version.Major < 5 || Environment.OSVersion.Version.Minor < 1)
                popupBlockerGroupBox.Enabled = false;
            if (settingsHelper.VietPhraseWrapType.Equals("0"))
                vietPhrase_NoWrapRadioButton.Checked = true;
            else if (settingsHelper.VietPhraseWrapType.Equals("1"))
                vietPhrase_AlwaysWrapRadioButton.Checked = true;
            else if (settingsHelper.VietPhraseWrapType.Equals("11"))
                vietPhrase_AlwaysWrapExceptHanVietRadioButton.Checked = true;
            else
                vietPhrase_OnlyWrapTwoMeaningRadioButton.Checked = true;
            if (settingsHelper.VietPhraseOneMeaningWrapType.Equals("0"))
                vietPhraseOneMeaning_NoWrapRadioButton.Checked = true;
            else if (settingsHelper.VietPhraseOneMeaningWrapType.Equals("1"))
                vietPhraseOneMeaning_AlwaysWrapRadioButton.Checked = true;
            else
                vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Checked = true;
            blockImagesCheckBox.Checked = settingsHelper.BlockImages.Equals("1");
            blockFlashesCheckBox.Checked = settingsHelper.BlockFlashes.Equals("1");
            algorithm_LongestVietPhraseFirstRadioButton.Checked = settingsHelper.TranslationAlgorithm == 0;
            algorithm_LeftToRightRadioButton.Checked = settingsHelper.TranslationAlgorithm == 1;
            algorithm_LongestVietPhraseFirstWithConditionRadioButton.Checked = settingsHelper.TranslationAlgorithm == 2;
            prioritizedNameCheckBox.Checked = settingsHelper.PrioritizedName == 1;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var settingsHelper = SettingsHelper.Current;
            if (filterLevelHighRadioButton.Checked)
                settingsHelper.FilterLevel = PopupBlockerFilterLevel.High;
            else if (filterLevelMediumRadioButton.Checked)
                settingsHelper.FilterLevel = PopupBlockerFilterLevel.Medium;
            else if (filterLevelLowRadioButton.Checked)
                settingsHelper.FilterLevel = PopupBlockerFilterLevel.Low;
            else
                settingsHelper.FilterLevel = PopupBlockerFilterLevel.None;
            settingsHelper.ShowScriptErrors = !doNotShowScriptErrorsCheckBox.Checked;
            string vietPhraseWrapType;
            if (vietPhrase_NoWrapRadioButton.Checked)
                vietPhraseWrapType = "0";
            else if (vietPhrase_AlwaysWrapRadioButton.Checked)
                vietPhraseWrapType = "1";
            else if (vietPhrase_AlwaysWrapExceptHanVietRadioButton.Checked)
                vietPhraseWrapType = "11";
            else
                vietPhraseWrapType = "2";
            settingsHelper.VietPhraseWrapType = vietPhraseWrapType;
            string vietPhraseOneMeaningWrapType;
            if (vietPhraseOneMeaning_NoWrapRadioButton.Checked)
                vietPhraseOneMeaningWrapType = "0";
            else if (vietPhraseOneMeaning_AlwaysWrapRadioButton.Checked)
                vietPhraseOneMeaningWrapType = "1";
            else
                vietPhraseOneMeaningWrapType = "11";
            settingsHelper.VietPhraseOneMeaningWrapType = vietPhraseOneMeaningWrapType;
            settingsHelper.BlockImages = blockImagesCheckBox.Checked ? "1" : "0";
            settingsHelper.BlockFlashes = blockFlashesCheckBox.Checked ? "1" : "0";
            settingsHelper.TranslationAlgorithm = algorithm_LongestVietPhraseFirstRadioButton.Checked
                ? 0
                : (algorithm_LeftToRightRadioButton.Checked ? 1 : 2);
            settingsHelper.PrioritizedName = prioritizedNameCheckBox.Checked ? 1 : 0;
            settingsHelper.Save();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

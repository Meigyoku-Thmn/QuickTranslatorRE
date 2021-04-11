using System;
using ExtendedWebBrowser2.Properties;

namespace ExtendedWebBrowser2
{
    internal class SettingsHelper
    {
        private SettingsHelper() { }

        private readonly Settings mySettings = new Settings();

        public static readonly SettingsHelper Current = new SettingsHelper();

        public PopupBlockerFilterLevel FilterLevel {
            get => mySettings.FilterLevel;
            set => mySettings.FilterLevel = value;
        }

        public bool ShowScriptErrors {
            get => mySettings.ShowScriptErrors;
            set => mySettings.ShowScriptErrors = value;
        }

        public string VietPhraseWrapType {
            get => mySettings.VietPhraseWrapType;
            set => mySettings.VietPhraseWrapType = value;
        }

        public string VietPhraseOneMeaningWrapType {
            get => mySettings.VietPhraseOneMeaningWrapType;
            set => mySettings.VietPhraseOneMeaningWrapType = value;
        }

        public string BlockImages {
            get => mySettings.BlockImages;
            set => mySettings.BlockImages = value;
        }

        public string BlockFlashes {
            get => mySettings.BlockFlashes;
            set => mySettings.BlockFlashes = value;
        }

        public string TranslationMode {
            get => mySettings.TranslationMode;
            set => mySettings.TranslationMode = value;
        }

        public string Zoom {
            get => mySettings.Zoom;
            set => mySettings.Zoom = value;
        }

        public string TextSize {
            get => mySettings.TextSize;
            set => mySettings.TextSize = value;
        }

        public string Font {
            get => mySettings.Font;
            set => mySettings.Font = value;
        }

        public int TranslationAlgorithm {
            get => mySettings.TranslationAlgorithm;
            set => mySettings.TranslationAlgorithm = value;
        }

        public int PrioritizedName {
            get => mySettings.PrioritizedName;
            set => mySettings.PrioritizedName = value;
        }

        public void Save() => mySettings.Save();
    }
}

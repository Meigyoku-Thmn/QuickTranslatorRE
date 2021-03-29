using System;
using ExtendedWebBrowser2.Properties;

namespace ExtendedWebBrowser2
{
    internal class SettingsHelper
    {
        private SettingsHelper()
        {
            _mySettings = new Settings();
        }

        public static SettingsHelper Current {
            get {
                if (_instance == null)
                {
                    lock (_lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new SettingsHelper();
                        }
                    }
                }
                return _instance;
            }
        }

        public PopupBlockerFilterLevel FilterLevel {
            get {
                return _mySettings.FilterLevel;
            }
            set {
                _mySettings.FilterLevel = value;
            }
        }

        public bool ShowScriptErrors {
            get {
                return _mySettings.ShowScriptErrors;
            }
            set {
                _mySettings.ShowScriptErrors = value;
            }
        }

        public string VietPhraseWrapType {
            get {
                return _mySettings.VietPhraseWrapType;
            }
            set {
                _mySettings.VietPhraseWrapType = value;
            }
        }

        public string VietPhraseOneMeaningWrapType {
            get {
                return _mySettings.VietPhraseOneMeaningWrapType;
            }
            set {
                _mySettings.VietPhraseOneMeaningWrapType = value;
            }
        }

        public string BlockImages {
            get {
                return _mySettings.BlockImages;
            }
            set {
                _mySettings.BlockImages = value;
            }
        }

        public string BlockFlashes {
            get {
                return _mySettings.BlockFlashes;
            }
            set {
                _mySettings.BlockFlashes = value;
            }
        }

        public string TranslationMode {
            get {
                return _mySettings.TranslationMode;
            }
            set {
                _mySettings.TranslationMode = value;
            }
        }

        public string Zoom {
            get {
                return _mySettings.Zoom;
            }
            set {
                _mySettings.Zoom = value;
            }
        }

        public string TextSize {
            get {
                return _mySettings.TextSize;
            }
            set {
                _mySettings.TextSize = value;
            }
        }

        public string Font {
            get {
                return _mySettings.Font;
            }
            set {
                _mySettings.Font = value;
            }
        }

        public int TranslationAlgorithm {
            get {
                return _mySettings.TranslationAlgorithm;
            }
            set {
                _mySettings.TranslationAlgorithm = value;
            }
        }

        public int PrioritizedName {
            get {
                return _mySettings.PrioritizedName;
            }
            set {
                _mySettings.PrioritizedName = value;
            }
        }

        public void Save()
        {
            _mySettings.Save();
        }

        private Settings _mySettings;

        private static SettingsHelper _instance;

        private static object _lockObject = new object();
    }
}

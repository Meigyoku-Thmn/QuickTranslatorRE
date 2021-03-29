using System;

namespace ExtendedWebBrowser2
{
    internal class ScriptErrorManager
    {
        private ScriptErrorManager()
        {
            _scriptErrors = new NotifyCollection<ScriptError>();
        }

        public static ScriptErrorManager Instance {
            get {
                if (_instance == null)
                {
                    lock (lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new ScriptErrorManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public NotifyCollection<ScriptError> ScriptErrors {
            get {
                return _scriptErrors;
            }
        }

        public void RegisterScriptError(Uri url, string description, int lineNumber)
        {
            _scriptErrors.Add(new ScriptError(url, description, lineNumber));
            if (SettingsHelper.Current.ShowScriptErrors)
            {
                ShowWindow();
            }
        }

        public void ShowWindow()
        {
            if (_errorWindow == null || _errorWindow.IsDisposed)
            {
                _errorWindow = new ScriptErrorWindow();
            }
            _errorWindow.Show();
        }

        private NotifyCollection<ScriptError> _scriptErrors;

        private static object lockObject = new object();

        private static ScriptErrorManager _instance;

        private ScriptErrorWindow _errorWindow;
    }
}

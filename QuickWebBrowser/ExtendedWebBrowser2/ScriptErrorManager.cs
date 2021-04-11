using System;

namespace ExtendedWebBrowser2
{
    internal class ScriptErrorManager
    {
        public readonly static ScriptErrorManager Instance = new ScriptErrorManager();

        public NotifyCollection<ScriptError> ScriptErrors { get; private set; }

        private ScriptErrorWindow errorWindow;

        private ScriptErrorManager()
            => ScriptErrors = new NotifyCollection<ScriptError>();

        public void RegisterScriptError(Uri url, string description, int lineNumber)
        {
            ScriptErrors.Add(new ScriptError(url, description, lineNumber));
            if (SettingsHelper.Current.ShowScriptErrors)
                ShowWindow();
        }

        public void ShowWindow()
        {
            if (errorWindow?.IsDisposed == true)
                errorWindow = new ScriptErrorWindow();
            errorWindow.Show();
        }
    }
}

using System;

namespace ExtendedWebBrowser2
{
    internal class TextChangedEventArgs : EventArgs
    {
        public TextChangedEventArgs(string text)
        {
            _text = text;
        }

        public string Text {
            get {
                return _text;
            }
        }

        private string _text;
    }
}

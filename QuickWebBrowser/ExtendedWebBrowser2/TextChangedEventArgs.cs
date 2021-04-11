using System;

namespace ExtendedWebBrowser2
{
    internal class TextChangedEventArgs : EventArgs
    {
        public TextChangedEventArgs(string text)
            => Text = text;

        public string Text { get; private set; }
    }
}

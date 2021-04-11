using System;

namespace ExtendedWebBrowser2
{
    internal class CommandStateEventArgs : EventArgs
    {
        public BrowserCommands BrowserCommands { get; private set; }

        public CommandStateEventArgs(BrowserCommands commands)
            => BrowserCommands = commands;
    }
}

using System;

namespace ExtendedWebBrowser2
{
    internal class CommandStateEventArgs : EventArgs
    {
        public CommandStateEventArgs(BrowserCommands commands)
        {
            _commands = commands;
        }

        public BrowserCommands BrowserCommands {
            get {
                return _commands;
            }
        }

        private BrowserCommands _commands;
    }
}

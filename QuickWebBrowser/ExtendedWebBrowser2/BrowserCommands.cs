using System;

namespace ExtendedWebBrowser2
{
    [Flags]
    internal enum BrowserCommands
    {
        None = 0,
        Home = 1,
        Search = 2,
        Back = 4,
        Forward = 8,
        Stop = 16,
        Reload = 32,
        Print = 64,
        PrintPreview = 128
    }
}

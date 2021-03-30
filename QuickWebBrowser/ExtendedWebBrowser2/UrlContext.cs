﻿using System;

namespace ExtendedWebBrowser2
{
    [Flags]
    internal enum UrlContext
    {
        None = 0,
        Unloading = 1,
        UserInited = 2,
        UserFirstInited = 4,
        OverrideKey = 8,
        ShowHelp = 16,
        HtmlDialog = 32,
        FromProxy = 64
    }
}

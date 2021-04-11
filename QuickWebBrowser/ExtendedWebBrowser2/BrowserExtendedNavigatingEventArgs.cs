using System;
using System.ComponentModel;

namespace ExtendedWebBrowser2
{
    internal class BrowserExtendedNavigatingEventArgs : CancelEventArgs
    {
        public Uri Url { get; private set; }

        public string Frame { get; private set; }

        public UrlContext NavigationContext { get; private set; }

        public object AutomationObject { get; set; }

        public BrowserExtendedNavigatingEventArgs(object automation, Uri url, string frame, UrlContext navigationContext)
        {
            Url = url;
            Frame = frame;
            NavigationContext = navigationContext;
            AutomationObject = automation;
        }
    }
}

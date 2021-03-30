using System;
using System.ComponentModel;

namespace ExtendedWebBrowser2
{
    internal class BrowserExtendedNavigatingEventArgs : CancelEventArgs
    {
        public Uri Url {
            get {
                return _Url;
            }
        }

        public string Frame {
            get {
                return _Frame;
            }
        }

        public UrlContext NavigationContext {
            get {
                return navigationContext;
            }
        }

        public object AutomationObject {
            get {
                return _pDisp;
            }
            set {
                _pDisp = value;
            }
        }

        public BrowserExtendedNavigatingEventArgs(object automation, Uri url, string frame, UrlContext navigationContext)
        {
            _Url = url;
            _Frame = frame;
            this.navigationContext = navigationContext;
            _pDisp = automation;
        }

        private Uri _Url;

        private string _Frame;

        private UrlContext navigationContext;

        private object _pDisp;
    }
}

using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace ExtendedWebBrowser2
{
    internal class ExtendedWebBrowser : WebBrowser
    {
        public event EventHandler Quit;

        private bool zoomEnabled;

        private UnsafeNativeMethods.IWebBrowser2 axIWebBrowser2;

        private AxHost.ConnectionPointCookie cookie;

        private WebBrowserExtendedEvents events;

        public void EnableZoom()
        {
            if (zoomEnabled)
                return;
            Zoom(100);
            zoomEnabled = true;
        }

        public void Zoom(int zoomFactor)
        {
            try
            {
                object obj = zoomFactor;
                axIWebBrowser2.ExecWB(NativeMethods.OLECMDID.OLECMDID_OPTICAL_ZOOM,
                    NativeMethods.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, ref obj, IntPtr.Zero);
            }
            catch { }
        }

        [PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
        protected override void AttachInterfaces(object nativeActiveXObject)
        {
            axIWebBrowser2 = (UnsafeNativeMethods.IWebBrowser2)nativeActiveXObject;
            base.AttachInterfaces(nativeActiveXObject);
        }

        [PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
        protected override void DetachInterfaces()
        {
            axIWebBrowser2 = null;
            base.DetachInterfaces();
        }

        public object Application {
            get => axIWebBrowser2.Application;
        }

        [PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
        protected override void CreateSink()
        {
            base.CreateSink();
            events = new WebBrowserExtendedEvents(this);
            cookie = new AxHost.ConnectionPointCookie(ActiveXInstance, events,
                typeof(UnsafeNativeMethods.DWebBrowserEvents2));
        }

        [PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
        protected override void DetachSink()
        {
            cookie?.Disconnect();
            cookie = null;
        }

        public event EventHandler Downloading;

        protected void OnDownloading(EventArgs e)
        {
            Downloading?.Invoke(this, e);
        }

        public event EventHandler DownloadComplete;

        protected virtual void OnDownloadComplete(EventArgs e)
        {
            DownloadComplete?.Invoke(this, e);
        }

        public event EventHandler<BrowserExtendedNavigatingEventArgs> StartNavigate;

        public event EventHandler<BrowserExtendedNavigatingEventArgs> StartNewWindow;

        protected void OnStartNewWindow(BrowserExtendedNavigatingEventArgs e)
        {
            if (e == null)
                throw new ArgumentNullException("e");
            StartNewWindow?.Invoke(this, e);
        }

        protected void OnStartNavigate(BrowserExtendedNavigatingEventArgs e)
        {
            if (e == null)
                throw new ArgumentNullException("e");
            StartNavigate?.Invoke(this, e);
        }

        [PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 528)
            {
                int num = m.WParam.ToInt32();
                int num2 = num & 65535;
                if (num2 == 2)
                    OnQuit();
            }
            base.WndProc(ref m);
        }

        protected void OnQuit()
        {
            Quit?.Invoke(this, EventArgs.Empty);
        }

        private class WebBrowserExtendedEvents : UnsafeNativeMethods.DWebBrowserEvents2
        {
            private readonly ExtendedWebBrowser browser;

            public WebBrowserExtendedEvents() { }

            public WebBrowserExtendedEvents(ExtendedWebBrowser browser)
                => this.browser = browser;

            public void BeforeNavigate2(object pDisp, ref object URL, ref object flags,
                ref object targetFrameName, ref object postData, ref object headers, ref bool cancel)
            {
                var url = new Uri(URL.ToString());
                string frame = null;
                if (targetFrameName != null)
                    frame = targetFrameName.ToString();
                var browserExtendedNavigatingEventArgs = new BrowserExtendedNavigatingEventArgs(
                    pDisp, url, frame, UrlContext.None);
                browser.OnStartNavigate(browserExtendedNavigatingEventArgs);
                cancel = browserExtendedNavigatingEventArgs.Cancel;
            }

            public void NewWindow2(ref object pDisp, ref bool cancel)
            {
                var browserExtendedNavigatingEventArgs = new BrowserExtendedNavigatingEventArgs(
                    pDisp, null, null, UrlContext.None);
                browser.OnStartNewWindow(browserExtendedNavigatingEventArgs);
                cancel = browserExtendedNavigatingEventArgs.Cancel;
                pDisp = browserExtendedNavigatingEventArgs.AutomationObject;
            }

            public void NewWindow3(ref object ppDisp, ref bool Cancel, uint dwFlags, string bstrUrlContext, string bstrUrl)
            {
                var browserExtendedNavigatingEventArgs = new BrowserExtendedNavigatingEventArgs(
                    ppDisp, new Uri(bstrUrl), null, (UrlContext)dwFlags);
                browser.OnStartNewWindow(browserExtendedNavigatingEventArgs);
                Cancel = browserExtendedNavigatingEventArgs.Cancel;
                ppDisp = browserExtendedNavigatingEventArgs.AutomationObject;
            }

            public void DownloadBegin()
            {
                browser.OnDownloading(EventArgs.Empty);
            }

            public void DownloadComplete()
            {
                browser.OnDownloadComplete(EventArgs.Empty);
            }

            [DispId(263)]
            public void WindowClosing(bool isChildWindow, ref bool cancel) { }

            public void OnQuit() { }

            public void StatusTextChange(string text) { }

            public void ProgressChange(int progress, int progressMax) { }

            public void TitleChange(string text) { }

            public void PropertyChange(string szProperty) { }

            public void NavigateComplete2(object pDisp, ref object URL) { }

            public void DocumentComplete(object pDisp, ref object URL) { }

            public void OnVisible(bool visible) { }

            public void OnToolBar(bool toolBar) { }

            public void OnMenuBar(bool menuBar) { }

            public void OnStatusBar(bool statusBar) { }

            public void OnFullScreen(bool fullScreen) { }

            public void OnTheaterMode(bool theaterMode) { }

            public void WindowSetResizable(bool resizable) { }

            public void WindowSetLeft(int left) { }

            public void WindowSetTop(int top) { }

            public void WindowSetWidth(int width) { }

            public void WindowSetHeight(int height) { }

            public void SetSecureLockIcon(int secureLockIcon) { }

            public void FileDownload(ref bool cancel) { }

            public void NavigateError(object pDisp, ref object URL, ref object frame, ref object statusCode, ref bool cancel)
            { }

            public void PrintTemplateInstantiation(object pDisp) { }

            public void PrintTemplateTeardown(object pDisp) { }

            public void UpdatePageStatus(object pDisp, ref object nPage, ref object fDone) { }

            public void PrivacyImpactedStateChange(bool bImpacted) { }

            public void CommandStateChange(int Command, bool Enable) { }

            public void ClientToHostWindow(ref int CX, ref int CY) { }
        }
    }
}

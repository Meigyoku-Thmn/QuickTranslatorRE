using System;
using System.Windows.Forms;
using ExtendedWebBrowser2.Properties;

namespace ExtendedWebBrowser2
{
    internal class WindowManager
    {
        public WindowManager(TabControl tabControl)
        {
            _tabControl = tabControl;
            _tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
        }

        public void Close()
        {
            TabPage selectedTab = _tabControl.SelectedTab;
            int selectedIndex = _tabControl.SelectedIndex;
            if (selectedTab != null)
            {
                _tabControl.TabPages.Remove(selectedTab);
                selectedTab.Dispose();
            }
            if (_tabControl.TabPages.Count == 0)
            {
                _tabControl.Visible = false;
                return;
            }
            _tabControl.SelectedIndex = ((0 <= selectedIndex - 1) ? (selectedIndex - 1) : 0);
        }

        public ExtendedWebBrowser New()
        {
            return New(true);
        }

        public ExtendedWebBrowser New(bool navigateHome)
        {
            return New(navigateHome, false);
        }

        public ExtendedWebBrowser New(bool navigateHome, bool goToNewTab)
        {
            TabPage tabPage = new TabPage {
                BorderStyle = BorderStyle.None,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };
            BrowserControl browserControl = new BrowserControl {
                Tag = tabPage,
                BorderStyle = BorderStyle.None,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };
            tabPage.Tag = browserControl;
            tabPage.Text = Resources.DefaultBrowserTitle;
            browserControl.Dock = DockStyle.Fill;
            tabPage.Controls.Add(browserControl);
            if (navigateHome)
            {
                browserControl.WebBrowser.GoHome();
            }
            browserControl.WebBrowser.StatusTextChanged += WebBrowser_StatusTextChanged;
            browserControl.WebBrowser.DocumentTitleChanged += WebBrowser_DocumentTitleChanged;
            browserControl.WebBrowser.CanGoBackChanged += WebBrowser_CanGoBackChanged;
            browserControl.WebBrowser.CanGoForwardChanged += WebBrowser_CanGoForwardChanged;
            browserControl.WebBrowser.Navigated += WebBrowser_Navigated;
            browserControl.WebBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
            browserControl.WebBrowser.Quit += WebBrowser_Quit;
            _tabControl.TabPages.Add(tabPage);
            if (goToNewTab)
            {
                _tabControl.SelectedTab = tabPage;
            }
            _tabControl.Visible = true;
            return browserControl.WebBrowser;
        }

        private void WebBrowser_Quit(object sender, EventArgs e)
        {
            ExtendedWebBrowser extendedWebBrowser = sender as ExtendedWebBrowser;
            if (extendedWebBrowser == null)
            {
                return;
            }
            BrowserControl browserControl = BrowserControlFromBrowser(extendedWebBrowser);
            if (browserControl == null)
            {
                return;
            }
            TabPage tabPage = browserControl.Tag as TabPage;
            if (tabPage == null)
            {
                return;
            }
            _tabControl.TabPages.Remove(tabPage);
            tabPage.Dispose();
            if (_tabControl.TabPages.Count == 0)
            {
                _tabControl.Visible = false;
            }
        }

        public void Open(Uri url)
        {
            ExtendedWebBrowser extendedWebBrowser = New(false);
            extendedWebBrowser.Navigate(url);
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            CheckCommandState();
        }

        private void WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            CheckCommandState();
        }

        private void WebBrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            CheckCommandState();
        }

        private void WebBrowser_CanGoBackChanged(object sender, EventArgs e)
        {
            CheckCommandState();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCommandState();
        }

        private void CheckCommandState()
        {
            BrowserCommands browserCommands = BrowserCommands.None;
            if (ActiveBrowser != null)
            {
                if (ActiveBrowser.CanGoBack)
                {
                    browserCommands |= BrowserCommands.Back;
                }
                if (ActiveBrowser.CanGoForward)
                {
                    browserCommands |= BrowserCommands.Forward;
                }
                if (ActiveBrowser.IsBusy)
                {
                    browserCommands |= BrowserCommands.Stop;
                }
                browserCommands |= BrowserCommands.Home;
                browserCommands |= BrowserCommands.Search;
                browserCommands |= BrowserCommands.Print;
                browserCommands |= BrowserCommands.PrintPreview;
                browserCommands |= BrowserCommands.Reload;
            }
            OnCommandStateChanged(new CommandStateEventArgs(browserCommands));
        }

        private void WebBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            ExtendedWebBrowser extendedWebBrowser = sender as ExtendedWebBrowser;
            if (extendedWebBrowser == null)
            {
                return;
            }
            BrowserControl browserControl = WindowManager.BrowserControlFromBrowser(extendedWebBrowser);
            if (browserControl == null)
            {
                return;
            }
            TabPage tabPage = browserControl.Tag as TabPage;
            if (tabPage == null)
            {
                return;
            }
            string text = extendedWebBrowser.DocumentTitle;
            if (string.IsNullOrEmpty(text))
            {
                text = Resources.DefaultBrowserTitle;
            }
            else if (text.Length > 30)
            {
                text = text.Substring(0, 30) + "...";
            }
            tabPage.Text = text;
            tabPage.ToolTipText = extendedWebBrowser.DocumentTitle;
        }

        private void WebBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            ExtendedWebBrowser extendedWebBrowser = sender as ExtendedWebBrowser;
            if (extendedWebBrowser == null)
            {
                return;
            }
            BrowserControl browserControl = WindowManager.BrowserControlFromBrowser(extendedWebBrowser);
            TabPage tabPage = browserControl.Tag as TabPage;
            if (tabPage == null)
            {
                return;
            }
            if (_tabControl.SelectedTab == tabPage)
            {
                OnStatusTextChanged(new TextChangedEventArgs(extendedWebBrowser.StatusText));
            }
        }

        public event EventHandler<TextChangedEventArgs> StatusTextChanged;

        protected virtual void OnStatusTextChanged(TextChangedEventArgs e)
        {
            StatusTextChanged?.Invoke(this, e);
        }

        private static BrowserControl BrowserControlFromBrowser(ExtendedWebBrowser browser)
        {
            if (browser == null)
            {
                return null;
            }
            if (browser.Parent == null)
            {
                return null;
            }
            return browser.Parent.Parent as BrowserControl;
        }

        public ExtendedWebBrowser ActiveBrowser {
            get {
                TabPage selectedTab = _tabControl.SelectedTab;
                if (selectedTab != null)
                {
                    BrowserControl browserControl = selectedTab.Tag as BrowserControl;
                    if (browserControl != null)
                    {
                        return browserControl.WebBrowser;
                    }
                }
                return null;
            }
        }

        public BrowserControl ActiveBrowserControl {
            get {
                TabPage selectedTab = _tabControl.SelectedTab;
                if (selectedTab != null)
                {
                    return selectedTab.Tag as BrowserControl;
                }
                return null;
            }
        }

        public TabPage ActiveTabPage {
            get {
                return _tabControl.SelectedTab;
            }
        }

        public event EventHandler<CommandStateEventArgs> CommandStateChanged;

        protected virtual void OnCommandStateChanged(CommandStateEventArgs e)
        {
            CommandStateChanged?.Invoke(this, e);
        }

        private TabControl _tabControl;
    }
}

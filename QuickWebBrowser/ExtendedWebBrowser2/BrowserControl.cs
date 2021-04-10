using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using static System.StringComparison;

namespace ExtendedWebBrowser2
{
    internal partial class BrowserControl : UserControl
    {
        public string OriginalHTMLSource = "";

        public BrowserControl()
        {
            InitializeComponent();
        }

        private void Browser_DownloadComplete(object sender, EventArgs e)
        {
            if (WebBrowser.Document == null)
                return;
            UpdateAddressBox();
            if (SettingsHelper.Current.BlockFlashes == "1")
                Adblock.Filter(WebBrowser.Document.DomDocument as HTMLDocument);
        }

        private string[] GetIgnoredList(bool getUrlList)
        {
            string[] lines = File.ReadAllLines(BrowserForm.IgnoredListFilePath);

            var ignoredUrls = new List<string>();
            var ignoredTags = new List<string>();

            bool flag = true;
            foreach (string line in lines.Select(line => line.Trim()))
            {
                if (string.IsNullOrEmpty(line) || string.IsNullOrEmpty(line) || line.StartsWith("#"))
                    continue;

                if (line == "[IgnoredUrl]")
                    flag = true;
                else if (line == "[IgnoredTags]")
                    flag = false;
                else if (flag)
                    ignoredUrls.Add(line);
                else
                    ignoredTags.Add(line);
            }

            if (getUrlList)
                return ignoredUrls.ToArray();
            else
                return ignoredTags.ToArray();
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            UpdateAddressBox();
            if (e.Url.ToString() == "about:blank" || e.Url.ToString() != browser.Document.Url.ToString())
                return;

            var innerHtml = browser.Document.Body.InnerHtml;
            if (e.Url.ToString().StartsWith("file"))
            {
                var ignoredTags = GetIgnoredList(getUrlList: false);
                foreach (var tag in ignoredTags)
                {
                    if (!string.IsNullOrEmpty(tag) && !string.IsNullOrEmpty(tag))
                        innerHtml = innerHtml.Replace(tag, "");
                }
            }
            if (e.Url.ToString().StartsWith("file"))
            {
                innerHtml = innerHtml.Replace(
                    "<PRE>", "<PRE style=\"word-wrap:break-word; font-family:'" +
                    ((SettingsHelper.Current.Font == "Original Font")
                        ? "Times New Roman"
                        : SettingsHelper.Current.Font) +
                    "'; font-size:20px;\">"
                );
            }
            HtmlUtilities.SetInnerHtml(browser.Document.Body, innerHtml);
            var headElm = browser.Document.GetElementsByTagName("head");
            if (0 < headElm.Count)
            {
                HtmlUtilities.SetInnerHtml(headElm[0],
                    (string.IsNullOrEmpty(headElm[0].InnerHtml)
                        ? ""
                        : headElm[0].InnerHtml) +
                    @"<script type=""text/javascript"">
                        function ignoreErrors() {
                            return true;
                        };
                        window.onerror = ignoreErrors;
                    </script>"
                );
            }

            browser.EnableZoom();

            if (browser.Document.Url.AbsoluteUri != e.Url.AbsoluteUri)
                return;

            foreach (HtmlElement htmlElement in browser.Document.All)
            {
                if (!string.IsNullOrEmpty(htmlElement.OuterHtml)
                    && htmlElement.OuterHtml.Trim(' ', '\r', '\n', '\t').StartsWith("<HTML", InvariantCultureIgnoreCase))
                {
                    OriginalHTMLSource = htmlElement.OuterHtml;
                    break;
                }
            }
            var mainForm = GetMainFormFromControl(sender as Control);
            mainForm.TranslateHandler?.Invoke(browser.Document);
        }

        private void UpdateAddressBox()
        {
            var location = WebBrowser.Document.Url.ToString().TrimEnd('#');
            if (!location.Equals(addressDropDown.Text, InvariantCultureIgnoreCase))
                addressDropDown.Text = location;
        }

        private void Browser_StartNewWindow(object sender, BrowserExtendedNavigatingEventArgs e)
        {
            var ignoredUrls = GetIgnoredList(getUrlList: true);
            foreach (string url in ignoredUrls)
            {
                if (!e.Url.AbsoluteUri.Contains(url))
                    continue;
                e.Cancel = true;
                return;
            }

            var mainFormFromControl = GetMainFormFromControl(sender as Control);
            if (mainFormFromControl == null)
                return;

            bool flag = e.NavigationContext == UrlContext.None
                || (e.NavigationContext & UrlContext.OverrideKey) == UrlContext.OverrideKey;

            if (flag == false)
            {
                switch (SettingsHelper.Current.FilterLevel)
                {
                    case PopupBlockerFilterLevel.None:
                        flag = true;
                        goto IL_B8;
                    case PopupBlockerFilterLevel.Low:
                        if (WebBrowser.EncryptionLevel != WebBrowserEncryptionLevel.Insecure)
                        {
                            flag = true;
                            goto IL_B8;
                        }
                        break;
                    case PopupBlockerFilterLevel.Medium:
                        break;
                    default:
                        goto IL_B8;
                }
                if ((e.NavigationContext & UrlContext.UserFirstInited) == UrlContext.UserFirstInited
                    && (e.NavigationContext & UrlContext.UserInited) == UrlContext.UserInited)
                    flag = true;
                goto IL_B8;
            }
        IL_B8:
            if (flag)
            {
                if ((e.NavigationContext & UrlContext.HtmlDialog) != UrlContext.HtmlDialog)
                {
                    ExtendedWebBrowser extendedWebBrowser = mainFormFromControl.WindowManager.New(false);
                    e.AutomationObject = extendedWebBrowser.Application;
                    return;
                }
            }
            else
                e.Cancel = true;
            return;
        }

        private void Browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            UpdateAddressBox();
        }

        public ExtendedWebBrowser WebBrowser {
            get => browser;
        }

        internal void Navigate()
        {
            if (addressDropDown.Text.Trim().EndsWith("wudilong.com"))
                addressDropDown.Text = addressDropDown.Text.Trim() + "/ssb/";
            WebBrowser.Navigate(addressDropDown.Text);
        }

        private static BrowserForm GetMainFormFromControl(Control control)
        {
            while (control != null && !(control is BrowserForm))
                control = control.Parent;
            return control as BrowserForm;
        }
    }
}

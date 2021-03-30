using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ExtendedWebBrowser2
{
    internal class BrowserControl : UserControl
    {
        public BrowserControl()
        {
            InitializeComponent();
            _browser.Dock = DockStyle.Fill;
            _browser.DownloadComplete += Browser_DownloadComplete;
            _browser.Navigated += Browser_Navigated;
            _browser.StartNewWindow += Browser_StartNewWindow;
            _browser.DocumentCompleted += Browser_DocumentCompleted;
            _browser.Downloading += Browser_Downloading;
            _browser.ScriptErrorsSuppressed = true;
            containerPanel.Controls.Add(_browser);
        }

        private void Browser_Downloading(object sender, EventArgs e)
        {
        }

        private void Browser_DownloadComplete(object sender, EventArgs e)
        {
            if (WebBrowser.Document != null)
            {
                UpdateAddressBox();
                if (SettingsHelper.Current.BlockFlashes == "1")
                {
                    HTMLDocument document = WebBrowser.Document.DomDocument as HTMLDocument;
                    Adblock.Filter(document);
                }
            }
        }

        private void Window_Error(object sender, HtmlElementErrorEventArgs e)
        {
            e.Handled = true;
        }

        private string[] GetIgnoredList(bool isIgnoredUrlList)
        {
            string[] array = File.ReadAllLines(BrowserForm.IgnoredListFilePath);
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            bool flag = true;
            foreach (string text in array)
            {
                if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text.Trim()) && !text.Trim().StartsWith("#"))
                {
                    if (text.Trim() == "[IgnoredUrl]")
                    {
                        flag = true;
                    }
                    else if (text.Trim() == "[IgnoredTags]")
                    {
                        flag = false;
                    }
                    else if (flag)
                    {
                        list.Add(text.Trim());
                    }
                    else
                    {
                        list2.Add(text.Trim());
                    }
                }
            }
            if (isIgnoredUrlList)
            {
                return list.ToArray();
            }
            return list2.ToArray();
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            UpdateAddressBox();
            if (e.Url.ToString() == "about:blank" || e.Url.ToString() != _browser.Document.Url.ToString())
            {
                return;
            }
            string text = _browser.Document.Body.InnerHtml;
            if (e.Url.ToString().StartsWith("file"))
            {
                string[] ignoredList = GetIgnoredList(false);
                foreach (string text2 in ignoredList)
                {
                    if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text2.Trim()))
                    {
                        text = text.Replace(text2.Trim(), "");
                    }
                }
            }
            if (e.Url.ToString().StartsWith("file"))
            {
                text = text.Replace("<PRE>", "<PRE style=\"word-wrap:break-word; font-family:'" + ((SettingsHelper.Current.Font == "Original Font") ? "Times New Roman" : SettingsHelper.Current.Font) + "'; font-size:20px;\">");
            }
            HtmlUtilities.SetInnerHtml(_browser.Document.Body, text);
            HtmlElementCollection elementsByTagName = _browser.Document.GetElementsByTagName("head");
            if (0 < elementsByTagName.Count)
            {
                HtmlUtilities.SetInnerHtml(elementsByTagName[0], (string.IsNullOrEmpty(elementsByTagName[0].InnerHtml) ? "" : elementsByTagName[0].InnerHtml) + "<script type=\"text/javascript\">function ignoreErrors() {return true;}window.onerror = ignoreErrors;</script>");
            }
            if (!zoomEnabled)
            {
                _browser.EnableZoom();
            }
            if (_browser.Document.Url.AbsoluteUri != e.Url.AbsoluteUri)
            {
                return;
            }
            foreach (object obj in _browser.Document.All)
            {
                HtmlElement htmlElement = (HtmlElement)obj;
                if (!string.IsNullOrEmpty(htmlElement.OuterHtml) && htmlElement.OuterHtml.Trim(new char[]
                {
                    ' ',
                    '\r',
                    '\n',
                    '\t'
                }).StartsWith("<HTML", StringComparison.InvariantCultureIgnoreCase))
                {
                    OriginalHTMLSource = htmlElement.OuterHtml;
                    break;
                }
            }
            BrowserForm mainFormFromControl = GetMainFormFromControl(sender as Control);
            mainFormFromControl.TranslateHandler?.Invoke(_browser.Document);
        }

        private void UpdateAddressBox()
        {
            string text = WebBrowser.Document.Url.ToString().TrimEnd(new char[]
            {
                '#'
            });
            if (!text.Equals(addressDropDown.Text, StringComparison.InvariantCultureIgnoreCase))
            {
                addressDropDown.Text = text;
            }
        }

        private void Browser_StartNavigate(object sender, BrowserExtendedNavigatingEventArgs e)
        {
            string[] ignoredList = GetIgnoredList(true);
            foreach (string value in ignoredList)
            {
                if (e.Url.AbsoluteUri.Contains(value))
                {
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void Browser_StartNewWindow(object sender, BrowserExtendedNavigatingEventArgs e)
        {
            string[] ignoredList = GetIgnoredList(true);
            foreach (string value in ignoredList)
            {
                if (e.Url.AbsoluteUri.Contains(value))
                {
                    e.Cancel = true;
                    return;
                }
            }
            BrowserForm mainFormFromControl = BrowserControl.GetMainFormFromControl(sender as Control);
            if (mainFormFromControl == null)
            {
                return;
            }
            bool flag = e.NavigationContext == UrlContext.None || (e.NavigationContext & UrlContext.OverrideKey) == UrlContext.OverrideKey;
            if (!flag)
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
                if ((e.NavigationContext & UrlContext.UserFirstInited) == UrlContext.UserFirstInited && (e.NavigationContext & UrlContext.UserInited) == UrlContext.UserInited)
                {
                    flag = true;
                }
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
            {
                e.Cancel = true;
            }
        }

        private void Browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            UpdateAddressBox();
        }

        public ExtendedWebBrowser WebBrowser {
            get {
                return _browser;
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Navigate();
        }

        internal void Navigate()
        {
            if (addressDropDown.Text.Trim().EndsWith("wudilong.com"))
            {
                addressDropDown.Text = addressDropDown.Text.Trim() + "/ssb/";
            }
            WebBrowser.Navigate(addressDropDown.Text);
        }

        private static BrowserForm GetMainFormFromControl(Control control)
        {
            while (control != null && !(control is BrowserForm))
            {
                control = control.Parent;
            }
            return control as BrowserForm;
        }

        private void AddressDropDownSelectedIndexChanged(object sender, EventArgs e)
        {
            Navigate();
        }

        private void BrowserControlLoad(object sender, EventArgs e)
        {
            addressDropDown.DataSource = GetFavourites();
            addressDropDown.Text = "";
            addressDropDown.KeyUp += AddressDropDownKeyUp;
        }

        private void AddressDropDownKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                Navigate();
            }
        }

        private List<string> GetFavourites()
        {
            List<string> list = new List<string>();
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.url"))
            {
                try
                {
                    TextReader textReader = fileInfo.OpenText();
                    textReader.ReadLine();
                    list.Add(textReader.ReadLine().Split(new char[]
                    {
                        '='
                    })[1]);
                }
                catch (Exception)
                {
                }
            }
            return list;
        }

        public void HideAddressPanel()
        {
            panel2.Hide();
        }

        public void ShowAddressPanel()
        {
            panel2.Show();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserControl));
            this.containerPanel = new System.Windows.Forms.Panel();
            this._browser = new ExtendedWebBrowser2.ExtendedWebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addressDropDown = new System.Windows.Forms.ComboBox();
            this.goButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.containerPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this._browser);
            resources.ApplyResources(this.containerPanel, "containerPanel");
            this.containerPanel.Name = "containerPanel";
            // 
            // _browser
            // 
            resources.ApplyResources(this._browser, "_browser");
            this._browser.Name = "_browser";
            this._browser.ScriptErrorsSuppressed = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addressDropDown);
            this.panel2.Controls.Add(this.goButton);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // addressDropDown
            // 
            resources.ApplyResources(this.addressDropDown, "addressDropDown");
            this.addressDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.addressDropDown.FormattingEnabled = true;
            this.addressDropDown.Name = "addressDropDown";
            // 
            // goButton
            // 
            resources.ApplyResources(this.goButton, "goButton");
            this.goButton.FlatAppearance.BorderSize = 0;
            this.goButton.Name = "goButton";
            this.goButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BrowserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.panel2);
            this.Name = "BrowserControl";
            this.containerPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private bool zoomEnabled;

        public string OriginalHTMLSource = string.Empty;

        private IContainer components;

        private ComboBox addressDropDown;

        private ExtendedWebBrowser _browser;

        private Panel containerPanel;

        private Panel panel2;

        private Button goButton;

        private Label label1;
    }
}

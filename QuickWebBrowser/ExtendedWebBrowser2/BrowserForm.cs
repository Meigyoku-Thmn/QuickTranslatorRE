using ExtendedWebBrowser2.Properties;
using FullScreenMode;
using QuickTranslatorCore;
using QuickTranslatorCore.Engine;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

using static System.StringComparison;

namespace ExtendedWebBrowser2
{
    [ComVisible(true)]
    public partial class BrowserForm : DockContent, IOleClientSite
    {
        private bool isFullScreen;

        private FullScreen fullScreen;

        private bool isTooglingFullScreen;

        private bool isLostFocusWhenFullScreen;

        public static string IgnoredListFilePath = Path.Combine(Constants.AssetsDir, "IgnoredList.txt");

        public static string BookmarksFilePath = Path.Combine(Constants.AssetsDir, "Bookmarks.txt");

        private WindowManager _windowManager;

        public int TranslationType;

        private string textSize;

        private bool resetTextSize = true;

        private bool shown;

        private void ToogleFullScreen()
        {
            isTooglingFullScreen = true;
            if (isFullScreen)
            {
                isFullScreen = false;
                fullScreen.ToggleFullScreen();
            }
            else
            {
                isFullScreen = true;
                fullScreen.ToggleFullScreen();
            }
            isTooglingFullScreen = false;
            menuStrip.Visible = !isFullScreen;
            toolStrip.Visible = !isFullScreen;
            showHideMenuPanel.Visible = isFullScreen;
            statusStrip1.Visible = !isFullScreen;
            fullScreenToolStripButton.Text = isFullScreen ? "&Exit Full Screen (F11)" : "F&ull Screen (F11)";
        }

        public BrowserForm()
        {
            InitializeComponent();
            _windowManager = new WindowManager(tabControl);
            _windowManager.CommandStateChanged += WindowManager_CommandStateChanged;
            _windowManager.StatusTextChanged += WindowManager_StatusTextChanged;
            DockHandler.GetPersistStringCallback = new GetPersistStringCallback(GetPersistStringFromText);
        }

        private void WindowManager_StatusTextChanged(object sender, TextChangedEventArgs e)
        {
            toolStripStatusLabel.Text = e.Text;
        }

        private void WindowManager_CommandStateChanged(object sender, CommandStateEventArgs e)
        {
            forwardToolStripButton.Enabled = (e.BrowserCommands & BrowserCommands.Forward) == BrowserCommands.Forward;
            backToolStripButton.Enabled = (e.BrowserCommands & BrowserCommands.Back) == BrowserCommands.Back;
            printPreviewToolStripButton.Enabled =
                (e.BrowserCommands & BrowserCommands.PrintPreview) == BrowserCommands.PrintPreview;
            printPreviewToolStripMenuItem.Enabled =
                (e.BrowserCommands & BrowserCommands.PrintPreview) == BrowserCommands.PrintPreview;
            printToolStripButton.Enabled = (e.BrowserCommands & BrowserCommands.Print) == BrowserCommands.Print;
            printToolStripMenuItem.Enabled = (e.BrowserCommands & BrowserCommands.Print) == BrowserCommands.Print;
            saveAsToolStripMenuItem.Enabled = (e.BrowserCommands & BrowserCommands.Print) == BrowserCommands.Print;
            homeToolStripButton.Enabled = (e.BrowserCommands & BrowserCommands.Home) == BrowserCommands.Home;
            searchToolStripButton.Enabled = (e.BrowserCommands & BrowserCommands.Search) == BrowserCommands.Search;
            refreshToolStripButton.Enabled = (e.BrowserCommands & BrowserCommands.Reload) == BrowserCommands.Reload;
            stopToolStripButton.Enabled = (e.BrowserCommands & BrowserCommands.Stop) == BrowserCommands.Stop;
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var options = new Options();
            options.ShowDialog(this);
        }

        private void ScriptErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScriptErrorManager.Instance.ShowWindow();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void PrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreview();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void OpenUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var openUrlForm = new OpenUrlForm();
            if (openUrlForm.ShowDialog() == DialogResult.OK)
            {
                var extendedWebBrowser = _windowManager.New(false, true);
                extendedWebBrowser.Navigate(openUrlForm.Url);
            }
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = Resources.OpenFileDialogFilter;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var url = new Uri(openFileDialog.FileName);
                WindowManager.Open(url);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About();
        }

        private void About()
        {
            using AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }

        private void TabControl_VisibleChanged(object sender, EventArgs e)
        {
            if (tabControl.Visible)
                panel1.BackColor = SystemColors.Control;
            else
                panel1.BackColor = SystemColors.AppWorkspace;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _windowManager.New(false, true);

            Initializer.LoadDictionaries();

            translateToolStripComboBox.Items.AddRange(new[] {
                "Không dịch",
                "Hán Việt",
                "VietPhrase",
                "VietPhrase một nghĩa"
            });

            translateToolStripComboBox.SelectedItem = SettingsHelper.Current.TranslationMode;
            textSizeToolStripComboBox.SelectedItem = SettingsHelper.Current.TextSize;
            zoomToolStripComboBox.SelectedItem = SettingsHelper.Current.Zoom;

            InitializeFontComboBox(fontToolStripComboBox);

            fontToolStripComboBox.SelectedItem = SettingsHelper.Current.Font;
            fullScreen = new FullScreen(this);

            LoadBookmarks();
        }

        private void InitializeFontComboBox(ToolStripComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Original Font");
            foreach (var fontFamily in FontFamily.Families)
                comboBox.Items.Add(fontFamily.Name);
        }

        public void Baikeing(string chinese)
        {
            _windowManager.New(false, true);
            _windowManager.ActiveBrowser.Navigate(
                "http://baike.baidu.com/list-php/dispose/searchword.php?word=" + chinese + "&pic=1");
        }

        public void Ncikuing(string chinese)
        {
            _windowManager.New(false, true);
            _windowManager.ActiveBrowser.Navigate("http://www.nciku.com/search/all/" + chinese);
        }

        private void Print()
        {
            _windowManager.ActiveBrowser?.ShowPrintDialog();
        }

        private void PrintPreview()
        {
            _windowManager.ActiveBrowser?.ShowPrintPreviewDialog();
        }

        private void SaveAs()
        {
            _windowManager.ActiveBrowser?.ShowSaveAsDialog();
        }

        private void CloseWindowToolStripButton_Click(object sender, EventArgs e)
        {
            _windowManager.New(false, true);
        }

        private void CloseToolStripButton_Click(object sender, EventArgs e)
        {
            _windowManager.Close();
        }

        private void PrintToolStripButton_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void PrintPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            PrintPreview();
        }

        private void BackToolStripButton_Click(object sender, EventArgs e)
        {
            if (_windowManager.ActiveBrowser?.CanGoBack == true)
                _windowManager.ActiveBrowser.GoBack();
        }

        private void ForwardToolStripButton_Click(object sender, EventArgs e)
        {
            if (_windowManager.ActiveBrowser?.CanGoForward == true)
                _windowManager.ActiveBrowser.GoForward();
        }

        private void StopToolStripButton_Click(object sender, EventArgs e)
        {
            _windowManager.ActiveBrowser?.Stop();
            stopToolStripButton.Enabled = false;
        }

        private void RefreshToolStripButton_Click(object sender, EventArgs e)
        {
            _windowManager.ActiveBrowserControl?.Navigate();
        }

        private void HomeToolStripButton_Click(object sender, EventArgs e)
        {
            _windowManager.ActiveBrowser?.GoHome();
        }

        private void SearchToolStripButton_Click(object sender, EventArgs e)
        {
            _windowManager.ActiveBrowser?.GoSearch();
        }

        internal WindowManager WindowManager {
            get => _windowManager;
        }

        public string GetPersistStringFromText()
        {
            return Text;
        }

        public void Translate(HtmlDocument htmlDocument)
        {
            var body = htmlDocument.Body;
            if (TranslationType == 0)
                return;
            if (fontToolStripComboBox.Text == "Original Font")
            {
                foreach (HtmlElement elm in htmlDocument.All)
                {
                    if (!string.IsNullOrEmpty(elm.TagName)
                        && !elm.TagName.Equals("html", OrdinalIgnoreCase)
                        && !elm.TagName.Equals("meta", OrdinalIgnoreCase)
                        && !elm.TagName.Equals("script", OrdinalIgnoreCase)
                        && !elm.TagName.Equals("head", OrdinalIgnoreCase)
                        && !elm.TagName.Equals("style", OrdinalIgnoreCase))
                    {
                        elm.Style =
                            (string.IsNullOrEmpty(elm.Style) ? "" : (elm.Style + ";")) +
                            (resetTextSize ? "" : ("font-size: " + textSize));
                    }
                }
            }
            else
            {
                foreach (HtmlElement elm in htmlDocument.All)
                {
                    if (!string.IsNullOrEmpty(elm.TagName)
                        && !elm.TagName.Equals("html", OrdinalIgnoreCase)
                        && !elm.TagName.Equals("meta", OrdinalIgnoreCase)
                        && !elm.TagName.Equals("script", OrdinalIgnoreCase)
                        && !elm.TagName.Equals("head", OrdinalIgnoreCase)
                        && !elm.TagName.Equals("style", OrdinalIgnoreCase))
                    {
                        elm.Style = string.Concat(new[] {
                            string.IsNullOrEmpty(elm.Style) ? "" : (elm.Style + ";"),
                            "font-family: '",
                            fontToolStripComboBox.Text,
                            "'; ",
                            resetTextSize ? "" : ("font-size: " + textSize)
                        });
                    }
                }
            }
            var innerHtml = body.InnerHtml;
            var flag = htmlDocument.Url.ToString().StartsWith("file");
            if (!flag)
            {
                string newInnerHtml;
                string newTitle;
                if (TranslationType == 1)
                {
                    newInnerHtml = Translator.ChineseToHanVietForBrowser(innerHtml);
                    newTitle = Translator.ChineseToHanVietForBrowser(htmlDocument.Title);
                }
                else if (TranslationType == 2)
                {
                    newInnerHtml = Translator.ChineseToVietPhraseForBrowser(innerHtml,
                        int.Parse(SettingsHelper.Current.VietPhraseWrapType),
                        SettingsHelper.Current.TranslationAlgorithm, SettingsHelper.Current.PrioritizedName == 1);
                    newTitle = Translator.ChineseToVietPhraseForBrowser(htmlDocument.Title,
                        int.Parse(SettingsHelper.Current.VietPhraseWrapType),
                        SettingsHelper.Current.TranslationAlgorithm, SettingsHelper.Current.PrioritizedName == 1);
                }
                else
                {
                    newInnerHtml = Translator.ChineseToVietPhraseOneMeaningForBrowser(innerHtml,
                        int.Parse(SettingsHelper.Current.VietPhraseOneMeaningWrapType),
                        SettingsHelper.Current.TranslationAlgorithm, SettingsHelper.Current.PrioritizedName == 1);
                    newTitle = Translator.ChineseToVietPhraseOneMeaningForBrowser(htmlDocument.Title,
                        int.Parse(SettingsHelper.Current.VietPhraseOneMeaningWrapType),
                        SettingsHelper.Current.TranslationAlgorithm, SettingsHelper.Current.PrioritizedName == 1);
                }
                HtmlUtilities.SetInnerHtml(body, HtmlUtilities.DecodeLinks(newInnerHtml));
                htmlDocument.Title = newTitle;
                return;
            }
            innerHtml = Util.NormalizeTextAndRemoveIgnoredChinesePhrases(innerHtml);
            innerHtml = innerHtml.Replace(". htm", ".htm");
            if (TranslationType == 1)
            {
                HtmlUtilities.SetInnerHtml(body, Translator.ChineseToHanVietForBatch(innerHtml));
                htmlDocument.Title = Translator.ChineseToHanViet(htmlDocument.Title, out _);
            }
            else if (TranslationType == 2)
            {
                HtmlUtilities.SetInnerHtml(body, Translator.ChineseToVietPhraseForBatch(innerHtml,
                    int.Parse(SettingsHelper.Current.VietPhraseWrapType),
                    SettingsHelper.Current.TranslationAlgorithm, SettingsHelper.Current.PrioritizedName == 1));
                htmlDocument.Title = Translator.ChineseToVietPhrase(htmlDocument.Title,
                    int.Parse(SettingsHelper.Current.VietPhraseWrapType),
                    SettingsHelper.Current.TranslationAlgorithm, SettingsHelper.Current.PrioritizedName == 1, out _, out _);
            }
            else
            {
                HtmlUtilities.SetInnerHtml(body, Translator.ChineseToVietPhraseOneMeaningForBatch(innerHtml,
                    int.Parse(SettingsHelper.Current.VietPhraseOneMeaningWrapType),
                    SettingsHelper.Current.TranslationAlgorithm, SettingsHelper.Current.PrioritizedName == 1));
                htmlDocument.Title = Translator.ChineseToVietPhraseOneMeaning(htmlDocument.Title,
                    int.Parse(SettingsHelper.Current.VietPhraseOneMeaningWrapType),
                    SettingsHelper.Current.TranslationAlgorithm, SettingsHelper.Current.PrioritizedName == 1, out _, out _);
            }
        }

        private void BaikeToolStripButtonClick(object sender, EventArgs e)
        {
            if (_windowManager.ActiveBrowser == null)
                _windowManager.New(false, true);
            _windowManager.ActiveBrowser.Navigate("http://baike.baidu.com");
        }

        private void TranslateToolStripComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (translateToolStripComboBox.Text == "Không dịch")
                TranslationType = 0;
            else if (translateToolStripComboBox.Text == "Hán Việt")
                TranslationType = 1;
            else if (translateToolStripComboBox.Text == "VietPhrase")
                TranslationType = 2;
            else if (translateToolStripComboBox.Text == "VietPhrase một nghĩa")
                TranslationType = 3;
            RefreshToolStripButton_Click(null, null);
        }

        public int SaveObject()
        {
            return 0;
        }

        public int GetMoniker(int dwAssign, int dwWhichMoniker, out object moniker)
        {
            moniker = this;
            return 0;
        }

        public int GetContainer(out object container)
        {
            container = this;
            return 0;
        }

        public int ShowObject()
        {
            return 0;
        }

        public int OnShowWindow(int fShow)
        {
            return 0;
        }

        public int RequestNewObjectLayout()
        {
            return 0;
        }

        private void ZoomToolStripComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            int zoomFactor;
            try
            {
                zoomFactor = int.Parse(zoomToolStripComboBox.Text.Replace("%", ""));
            }
            catch (Exception)
            {
                return;
            }
            _windowManager.ActiveBrowser.Zoom(zoomFactor);
        }

        private void ZoomToolStripComboBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return || !int.TryParse(zoomToolStripComboBox.Text.Replace("%", ""), out _))
                return;
            zoomToolStripComboBox.Text = zoomToolStripComboBox.Text.Replace("%", "") + "%";
            ZoomToolStripComboBoxSelectedIndexChanged(null, null);
        }

        private void TextSizeToolStripComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            resetTextSize = textSizeToolStripComboBox.Text == "Original Size";
            var num = textSizeToolStripComboBox.Text switch {
                "Largest" => 4,
                "Larger" => 3,
                "Medium" => 2,
                "Smaller" => 1,
                "Smallest" => 0,
                _ => 2,
            };
            textSize = 12 + num * 3 + "px";
            RefreshToolStripButton_Click(null, null);
        }

        private void FullScreenToolStripButtonClick(object sender, EventArgs e)
        {
            ToogleFullScreen();
        }

        private void BrowserFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFullScreen)
                ToogleFullScreen();
            SettingsHelper.Current.TranslationMode = translateToolStripComboBox.Text;
            SettingsHelper.Current.Zoom = zoomToolStripComboBox.Text;
            SettingsHelper.Current.TextSize = textSizeToolStripComboBox.Text;
            SettingsHelper.Current.Font = fontToolStripComboBox.Text;
            SettingsHelper.Current.Save();
        }

        private void FontToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsHelper.Current.Font = fontToolStripComboBox.Text;
            RefreshToolStripButton_Click(null, null);
        }

        private void ViewSourceToolStripButtonClick(object sender, EventArgs e)
        {
            if (_windowManager.ActiveBrowser?.Document?.All.Count == 0)
                return;
            if (string.IsNullOrEmpty(_windowManager.ActiveBrowserControl.OriginalHTMLSource))
                return;
            var viewSourceForm = new ViewSourceForm(_windowManager.ActiveBrowserControl.OriginalHTMLSource);
            viewSourceForm.ShowDialog(this);
        }

        private void TangthuvienToolStripButtonClick(object sender, EventArgs e)
        {
            if (_windowManager.ActiveBrowser == null)
                _windowManager.New(false, true);
            _windowManager.ActiveBrowser.Navigate("http://tangthuvien.com/forum/");
        }

        private void BrowserFormDeactivate(object sender, EventArgs e)
        {
            if (isTooglingFullScreen)
                return;
            isLostFocusWhenFullScreen = isFullScreen;
            if (!isFullScreen)
                return;
            ToogleFullScreen();
            fullScreen.ResetTaskBar();
        }

        private void BrowserFormActivated(object sender, EventArgs e)
        {
            if (isTooglingFullScreen || !isLostFocusWhenFullScreen)
                return;
            if (!isFullScreen)
                ToogleFullScreen();
            isLostFocusWhenFullScreen = false;
        }

        private void ShowHideMenuPanelMouseEnter(object sender, EventArgs e)
        {
            toolStrip.Visible = !shown;
            shown = !shown;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Parent is MdiClient)
                return base.ProcessCmdKey(ref msg, keyData);
            if (msg.Msg == 256 || msg.Msg == 260)
            {
                if (keyData == Keys.F11 && fullScreenToolStripButton.Enabled)
                {
                    ToogleFullScreen();
                    Activate();
                }
                else
                {
                    if (keyData == (Keys.Tab | Keys.Shift | Keys.Control))
                    {
                        GoToPreviousTab();
                        return true;
                    }
                    if (keyData != (Keys.Tab | Keys.Control))
                        return base.ProcessCmdKey(ref msg, keyData);
                    GoToNextTab();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void GoToNextTab()
        {
            if (tabControl.TabCount <= 1)
                return;
            if (tabControl.SelectedIndex <= tabControl.TabCount - 2)
            {
                tabControl.SelectedIndex++;
                return;
            }
            if (tabControl.SelectedIndex == tabControl.TabCount - 1)
                tabControl.SelectedIndex = 0;
        }

        public void GoToPreviousTab()
        {
            if (tabControl.TabCount == 0)
                return;
            if (tabControl.SelectedIndex == 0)
            {
                tabControl.SelectedIndex = tabControl.TabCount - 1;
                return;
            }
            if (0 < tabControl.SelectedIndex)
                tabControl.SelectedIndex--;
        }

        private void Base64DecoderToolStripMenuItemClick(object sender, EventArgs e)
        {
            var base64DecoderForm = new Base64DecoderForm();
            base64DecoderForm.ShowDialog();
        }

        private void ReloadDictsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initializer.LoadDictionaries();
            RefreshToolStripButton_Click(null, null);
        }

        private void BookmarkThisPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowManager.ActiveBrowser == null)
                return;
            var text = WindowManager.ActiveBrowser.DocumentTitle;
            if (string.IsNullOrEmpty(text))
                text = Resources.DefaultBrowserTitle;
            else if (50 < text.Length)
                text = text.Substring(0, 50) + "...";
            var absoluteUri = WindowManager.ActiveBrowser.Url.AbsoluteUri;
            AddToBookmark(text, absoluteUri);
            LoadBookmarks();
        }

        private void AddToBookmark(string title, string url)
        {
            File.AppendAllText(BookmarksFilePath, title.Trim() + "\t" + url.Trim() + "\n", Encoding.UTF8);
        }

        private void LoadBookmarks()
        {
            if (!File.Exists(BookmarksFilePath))
                return;

            bookmarksToolStripMenuItem.DropDownItems.Clear();
            bookmarksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                bookmarkThisPageToolStripMenuItem,
                toolStripSeparator8
            });

            foreach (var line in File.ReadAllLines(BookmarksFilePath))
            {
                if (!string.IsNullOrEmpty(line) && line.Contains("\t"))
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(line.Split('\t')[0]) {
                        ToolTipText = line.Split('\t')[1],
                        DisplayStyle = ToolStripItemDisplayStyle.Text
                    };
                    toolStripMenuItem.Click += ABookmarkToolStripMenuItem_Click;
                    var toolStripMenuItem2 = new ToolStripMenuItem("Delete") {
                        AutoToolTip = false,
                        ToolTipText = line,
                        DisplayStyle = ToolStripItemDisplayStyle.Text
                    };
                    toolStripMenuItem2.Click += DeleteToolStripMenuItem_Click;
                    toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
                    bookmarksToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oldValue = (sender as ToolStripMenuItem).ToolTipText + "\n";
            var lines = File.ReadAllText(BookmarksFilePath);
            File.WriteAllText(BookmarksFilePath, lines.Replace(oldValue, ""), Encoding.UTF8);
            LoadBookmarks();
        }

        private void ABookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookmarksToolStripMenuItem.HideDropDown();
            var toolTipText = (sender as ToolStripMenuItem).ToolTipText;
            if (WindowManager.ActiveBrowser == null)
                WindowManager.New(false);
            WindowManager.ActiveBrowser.Navigate(toolTipText);
        }

        private void ExtractTXTToolStripButtonClick(object sender, EventArgs e)
        {
            if (_windowManager.ActiveBrowser?.Document?.All.Count == 0)
                return;
            if (string.IsNullOrEmpty(_windowManager.ActiveBrowserControl.OriginalHTMLSource))
                return;
            var chineseContent = HtmlScrapper.GetChineseContent(
                _windowManager.ActiveBrowserControl.OriginalHTMLSource, false);
            try { Clipboard.SetDataObject(chineseContent, true, 50, 100); }
            catch (ExternalException) { }
        }
    }
}

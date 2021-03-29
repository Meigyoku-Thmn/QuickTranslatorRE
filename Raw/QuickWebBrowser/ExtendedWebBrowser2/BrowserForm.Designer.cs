namespace ExtendedWebBrowser2
{
    public partial class BrowserForm
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkThisPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.base64DecoderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadDictsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.closeWindowToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.backToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.forwardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.homeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.baikeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tangthuvienToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.translateToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.zoomToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.textSizeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fontToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.fullScreenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.viewSourceToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.extractTXTToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showHideMenuPanel = new System.Windows.Forms.Panel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bookmarksToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1197, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openUrlToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openUrlToolStripMenuItem
            // 
            this.openUrlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openUrlToolStripMenuItem.Image")));
            this.openUrlToolStripMenuItem.Name = "openUrlToolStripMenuItem";
            this.openUrlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openUrlToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.openUrlToolStripMenuItem.Text = "Open &Url...";
            this.openUrlToolStripMenuItem.Click += new System.EventHandler(this.OpenUrlToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
            this.openFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.openFileToolStripMenuItem.Text = "Open &File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItemClick);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Enabled = false;
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.P)));
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.PrintPreviewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(264, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkThisPageToolStripMenuItem,
            this.toolStripSeparator8});
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.bookmarksToolStripMenuItem.Text = "B&ookmarks";
            // 
            // bookmarkThisPageToolStripMenuItem
            // 
            this.bookmarkThisPageToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bookmarkThisPageToolStripMenuItem.Name = "bookmarkThisPageToolStripMenuItem";
            this.bookmarkThisPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.bookmarkThisPageToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.bookmarkThisPageToolStripMenuItem.Text = "Bookmark This Page";
            this.bookmarkThisPageToolStripMenuItem.Click += new System.EventHandler(this.BookmarkThisPageToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(275, 6);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptErrorToolStripMenuItem,
            this.toolStripSeparator5,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator6,
            this.base64DecoderToolStripMenuItem,
            this.reloadDictsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // scriptErrorToolStripMenuItem
            // 
            this.scriptErrorToolStripMenuItem.Enabled = false;
            this.scriptErrorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scriptErrorToolStripMenuItem.Image")));
            this.scriptErrorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.scriptErrorToolStripMenuItem.Name = "scriptErrorToolStripMenuItem";
            this.scriptErrorToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.scriptErrorToolStripMenuItem.Text = "&Script error window";
            this.scriptErrorToolStripMenuItem.Visible = false;
            this.scriptErrorToolStripMenuItem.Click += new System.EventHandler(this.ScriptErrorToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
            this.toolStripSeparator5.Visible = false;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem.Image")));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.optionsToolStripMenuItem.Text = "&Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(219, 6);
            // 
            // base64DecoderToolStripMenuItem
            // 
            this.base64DecoderToolStripMenuItem.Name = "base64DecoderToolStripMenuItem";
            this.base64DecoderToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.base64DecoderToolStripMenuItem.Text = "Base64 &Decoder";
            this.base64DecoderToolStripMenuItem.Click += new System.EventHandler(this.Base64DecoderToolStripMenuItemClick);
            // 
            // reloadDictsToolStripMenuItem
            // 
            this.reloadDictsToolStripMenuItem.Name = "reloadDictsToolStripMenuItem";
            this.reloadDictsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.reloadDictsToolStripMenuItem.Text = "&Reload Dicts";
            this.reloadDictsToolStripMenuItem.Click += new System.EventHandler(this.ReloadDictsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeWindowToolStripButton,
            this.toolStripSeparator3,
            this.backToolStripButton,
            this.forwardToolStripButton,
            this.toolStripSeparator1,
            this.stopToolStripButton,
            this.refreshToolStripButton,
            this.toolStripSeparator2,
            this.homeToolStripButton,
            this.closeToolStripButton,
            this.searchToolStripButton,
            this.toolStripSeparator4,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripButton1,
            this.baikeToolStripButton,
            this.tangthuvienToolStripButton,
            this.toolStripButton2,
            this.translateToolStripComboBox,
            this.zoomToolStripComboBox,
            this.textSizeToolStripComboBox,
            this.fontToolStripComboBox,
            this.toolStripSeparator12,
            this.fullScreenToolStripButton,
            this.viewSourceToolStripButton,
            this.toolStripSeparator7,
            this.extractTXTToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 30);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1197, 28);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // closeWindowToolStripButton
            // 
            this.closeWindowToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeWindowToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeWindowToolStripButton.Image")));
            this.closeWindowToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeWindowToolStripButton.Name = "closeWindowToolStripButton";
            this.closeWindowToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.closeWindowToolStripButton.Text = "&New Tab";
            this.closeWindowToolStripButton.Click += new System.EventHandler(this.CloseWindowToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // backToolStripButton
            // 
            this.backToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backToolStripButton.Enabled = false;
            this.backToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripButton.Image")));
            this.backToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backToolStripButton.Name = "backToolStripButton";
            this.backToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.backToolStripButton.Text = "&Back";
            this.backToolStripButton.Click += new System.EventHandler(this.BackToolStripButton_Click);
            // 
            // forwardToolStripButton
            // 
            this.forwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardToolStripButton.Enabled = false;
            this.forwardToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardToolStripButton.Image")));
            this.forwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardToolStripButton.Name = "forwardToolStripButton";
            this.forwardToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.forwardToolStripButton.Text = "For&ward";
            this.forwardToolStripButton.Click += new System.EventHandler(this.ForwardToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopToolStripButton.Enabled = false;
            this.stopToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripButton.Image")));
            this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.stopToolStripButton.Text = "&Stop";
            this.stopToolStripButton.Click += new System.EventHandler(this.StopToolStripButton_Click);
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshToolStripButton.Enabled = false;
            this.refreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton.Image")));
            this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.refreshToolStripButton.Text = "&Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.RefreshToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // homeToolStripButton
            // 
            this.homeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripButton.Image")));
            this.homeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeToolStripButton.Name = "homeToolStripButton";
            this.homeToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.homeToolStripButton.Text = "Ho&me";
            this.homeToolStripButton.Click += new System.EventHandler(this.HomeToolStripButton_Click);
            // 
            // closeToolStripButton
            // 
            this.closeToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripButton.Image")));
            this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolStripButton.Name = "closeToolStripButton";
            this.closeToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.closeToolStripButton.Text = "Close Window";
            this.closeToolStripButton.Click += new System.EventHandler(this.CloseToolStripButton_Click);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripButton.Image")));
            this.searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.searchToolStripButton.Text = "Sear&ch";
            this.searchToolStripButton.Click += new System.EventHandler(this.SearchToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            this.toolStripSeparator4.Visible = false;
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Enabled = false;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.printToolStripButton.Text = "Print";
            this.printToolStripButton.Visible = false;
            this.printToolStripButton.Click += new System.EventHandler(this.PrintToolStripButton_Click);
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Enabled = false;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.printPreviewToolStripButton.Text = "Print Preview";
            this.printPreviewToolStripButton.Visible = false;
            this.printPreviewToolStripButton.Click += new System.EventHandler(this.PrintPreviewToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 28);
            // 
            // baikeToolStripButton
            // 
            this.baikeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("baikeToolStripButton.Image")));
            this.baikeToolStripButton.Name = "baikeToolStripButton";
            this.baikeToolStripButton.Size = new System.Drawing.Size(69, 25);
            this.baikeToolStripButton.Text = "&Baike";
            this.baikeToolStripButton.ToolTipText = "http://baike.baidu.com";
            this.baikeToolStripButton.Click += new System.EventHandler(this.BaikeToolStripButtonClick);
            // 
            // tangthuvienToolStripButton
            // 
            this.tangthuvienToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tangthuvienToolStripButton.Image")));
            this.tangthuvienToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tangthuvienToolStripButton.Name = "tangthuvienToolStripButton";
            this.tangthuvienToolStripButton.Size = new System.Drawing.Size(117, 25);
            this.tangthuvienToolStripButton.Text = "TangThuVien";
            this.tangthuvienToolStripButton.ToolTipText = "http://tangthuvien.com/forum/";
            this.tangthuvienToolStripButton.Click += new System.EventHandler(this.TangthuvienToolStripButtonClick);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 28);
            // 
            // translateToolStripComboBox
            // 
            this.translateToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.translateToolStripComboBox.DropDownWidth = 150;
            this.translateToolStripComboBox.Name = "translateToolStripComboBox";
            this.translateToolStripComboBox.Size = new System.Drawing.Size(199, 28);
            this.translateToolStripComboBox.ToolTipText = "Translation Mode";
            this.translateToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.TranslateToolStripComboBoxSelectedIndexChanged);
            // 
            // zoomToolStripComboBox
            // 
            this.zoomToolStripComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.zoomToolStripComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.zoomToolStripComboBox.Items.AddRange(new object[] {
            "150%",
            "140%",
            "130%",
            "120%",
            "110%",
            "100%",
            "90%",
            "80%",
            "70%",
            "60%"});
            this.zoomToolStripComboBox.MaxDropDownItems = 10;
            this.zoomToolStripComboBox.Name = "zoomToolStripComboBox";
            this.zoomToolStripComboBox.Size = new System.Drawing.Size(99, 28);
            this.zoomToolStripComboBox.Text = "100%";
            this.zoomToolStripComboBox.ToolTipText = "Zoom";
            this.zoomToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ZoomToolStripComboBoxSelectedIndexChanged);
            this.zoomToolStripComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ZoomToolStripComboBoxKeyUp);
            // 
            // textSizeToolStripComboBox
            // 
            this.textSizeToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textSizeToolStripComboBox.Items.AddRange(new object[] {
            "Original Size",
            "Largest",
            "Larger",
            "Medium",
            "Smaller",
            "Smallest"});
            this.textSizeToolStripComboBox.Name = "textSizeToolStripComboBox";
            this.textSizeToolStripComboBox.Size = new System.Drawing.Size(132, 28);
            this.textSizeToolStripComboBox.ToolTipText = "Text Size";
            this.textSizeToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.TextSizeToolStripComboBoxSelectedIndexChanged);
            // 
            // fontToolStripComboBox
            // 
            this.fontToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontToolStripComboBox.DropDownWidth = 140;
            this.fontToolStripComboBox.Name = "fontToolStripComboBox";
            this.fontToolStripComboBox.Size = new System.Drawing.Size(140, 28);
            this.fontToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FontToolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 28);
            // 
            // fullScreenToolStripButton
            // 
            this.fullScreenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fullScreenToolStripButton.Image")));
            this.fullScreenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fullScreenToolStripButton.Name = "fullScreenToolStripButton";
            this.fullScreenToolStripButton.Size = new System.Drawing.Size(141, 24);
            this.fullScreenToolStripButton.Text = "F&ull Screen (F11)";
            this.fullScreenToolStripButton.Click += new System.EventHandler(this.FullScreenToolStripButtonClick);
            // 
            // viewSourceToolStripButton
            // 
            this.viewSourceToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("viewSourceToolStripButton.Image")));
            this.viewSourceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewSourceToolStripButton.Name = "viewSourceToolStripButton";
            this.viewSourceToolStripButton.Size = new System.Drawing.Size(121, 24);
            this.viewSourceToolStripButton.Text = "&HTML Source";
            this.viewSourceToolStripButton.Click += new System.EventHandler(this.ViewSourceToolStripButtonClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // extractTXTToolStripButton
            // 
            this.extractTXTToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.extractTXTToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("extractTXTToolStripButton.Image")));
            this.extractTXTToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.extractTXTToolStripButton.Name = "extractTXTToolStripButton";
            this.extractTXTToolStripButton.Size = new System.Drawing.Size(71, 24);
            this.extractTXTToolStripButton.Text = "&Tách TXT";
            this.extractTXTToolStripButton.ToolTipText = "Tách TXT (to Clipboard)";
            this.extractTXTToolStripButton.Click += new System.EventHandler(this.ExtractTXTToolStripButtonClick);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1197, 512);
            this.tabControl.TabIndex = 3;
            this.tabControl.Visible = false;
            this.tabControl.VisibleChanged += new System.EventHandler(this.TabControl_VisibleChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showHideMenuPanel);
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 512);
            this.panel1.TabIndex = 4;
            // 
            // showHideMenuPanel
            // 
            this.showHideMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.showHideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.showHideMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.showHideMenuPanel.Name = "showHideMenuPanel";
            this.showHideMenuPanel.Size = new System.Drawing.Size(1197, 5);
            this.showHideMenuPanel.TabIndex = 4;
            this.showHideMenuPanel.Visible = false;
            this.showHideMenuPanel.MouseEnter += new System.EventHandler(this.ShowHideMenuPanelMouseEnter);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(1177, 20);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "StatusText";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1197, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrowserForm";
            this.Text = "Quick Web Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.BrowserFormActivated);
            this.Deactivate += new System.EventHandler(this.BrowserFormDeactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrowserFormFormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private global::System.ComponentModel.IContainer components;

        private global::System.Windows.Forms.ToolStripButton extractTXTToolStripButton;

        private global::System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripMenuItem base64DecoderToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

        private global::System.Windows.Forms.Panel showHideMenuPanel;

        private global::System.Windows.Forms.ToolStripButton tangthuvienToolStripButton;

        private global::System.Windows.Forms.ToolStripSeparator toolStripButton1;

        private global::System.Windows.Forms.ToolStripButton viewSourceToolStripButton;

        private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

        public global::System.Windows.Forms.ToolStripButton fullScreenToolStripButton;

        private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator12;

        private global::System.Windows.Forms.ToolStripComboBox textSizeToolStripComboBox;

        private global::System.Windows.Forms.ToolStripComboBox zoomToolStripComboBox;

        private global::System.Windows.Forms.ToolStripComboBox translateToolStripComboBox;

        private global::System.Windows.Forms.ToolStripButton baikeToolStripButton;

        private global::System.Windows.Forms.ToolStripSeparator toolStripButton2;

        private global::System.Windows.Forms.MenuStrip menuStrip;

        private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripMenuItem openUrlToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

        private global::System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;

        private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        private global::System.Windows.Forms.ToolStrip toolStrip;

        private global::System.Windows.Forms.ToolStripButton backToolStripButton;

        private global::System.Windows.Forms.ToolStripButton forwardToolStripButton;

        private global::System.Windows.Forms.ToolStripButton stopToolStripButton;

        private global::System.Windows.Forms.ToolStripButton refreshToolStripButton;

        private global::System.Windows.Forms.ToolStripButton homeToolStripButton;

        private global::System.Windows.Forms.TabControl tabControl;

        private global::System.Windows.Forms.Panel panel1;

        private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private global::System.Windows.Forms.ToolStripButton closeToolStripButton;

        private global::System.Windows.Forms.ToolStripButton closeWindowToolStripButton;

        private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

        private global::System.Windows.Forms.ToolStripButton printToolStripButton;

        private global::System.Windows.Forms.ToolStripButton printPreviewToolStripButton;

        private global::System.Windows.Forms.ToolStripButton searchToolStripButton;

        private global::System.Windows.Forms.ToolStripMenuItem scriptErrorToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

        private global::System.Windows.Forms.ToolStripComboBox fontToolStripComboBox;

        private global::System.Windows.Forms.ToolStripMenuItem reloadDictsToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripMenuItem bookmarkThisPageToolStripMenuItem;

        private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

        private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

        private global::System.Windows.Forms.StatusStrip statusStrip1;
    }
}

namespace QuickTranslator
{
    public partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.layoutToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.chineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanVietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietPhraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietPhraseOneMeaningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.translateFromClipboardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.retranslateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.updateVietPhraseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.updateNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autoScrollToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadDictToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.postTTVToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.nextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.backToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wordCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.SystemColors.Control;
            this.dockPanel.Location = new System.Drawing.Point(0, 27);
            this.dockPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1169, 457);
            this.dockPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripButton,
            this.toolStripSeparator3,
            this.layoutToolStripDropDownButton,
            this.toolStripSeparator2,
            this.translateFromClipboardToolStripButton,
            this.toolStripSeparator9,
            this.retranslateToolStripButton,
            this.toolStripSeparator6,
            this.updateVietPhraseToolStripButton,
            this.toolStripSeparator8,
            this.updateNameToolStripButton,
            this.toolStripSeparator1,
            this.autoScrollToolStripButton,
            this.toolStripSeparator5,
            this.reloadDictToolStripButton,
            this.toolStripButton10,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripLabel1,
            this.postTTVToolStripButton,
            this.toolStripSeparator10,
            this.nextToolStripButton,
            this.backToolStripButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1169, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripButton
            // 
            this.fileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.toolStripSeparator4,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator7,
            this.exportToWordToolStripMenuItem});
            this.fileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripButton.Image")));
            this.fileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripButton.Name = "fileToolStripButton";
            this.fileToolStripButton.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripButton.Text = "&File";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newWindowToolStripMenuItem.Image")));
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.newWindowToolStripMenuItem.Text = "New &Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.NewWindowToolStripMenuItemClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(242, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.saveToolStripMenuItem.Text = "&Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(242, 6);
            // 
            // exportToWordToolStripMenuItem
            // 
            this.exportToWordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportToWordToolStripMenuItem.Image")));
            this.exportToWordToolStripMenuItem.Name = "exportToWordToolStripMenuItem";
            this.exportToWordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToWordToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.exportToWordToolStripMenuItem.Text = "&Export To Word";
            this.exportToWordToolStripMenuItem.Click += new System.EventHandler(this.ExportToWordToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // layoutToolStripDropDownButton
            // 
            this.layoutToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.layoutToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chineseToolStripMenuItem,
            this.hanVietToolStripMenuItem,
            this.vietToolStripMenuItem,
            this.vietPhraseToolStripMenuItem,
            this.vietPhraseOneMeaningToolStripMenuItem});
            this.layoutToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("layoutToolStripDropDownButton.Image")));
            this.layoutToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.layoutToolStripDropDownButton.Name = "layoutToolStripDropDownButton";
            this.layoutToolStripDropDownButton.Size = new System.Drawing.Size(67, 24);
            this.layoutToolStripDropDownButton.Text = "&Layout";
            // 
            // chineseToolStripMenuItem
            // 
            this.chineseToolStripMenuItem.Checked = true;
            this.chineseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chineseToolStripMenuItem.Enabled = false;
            this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            this.chineseToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.chineseToolStripMenuItem.Text = "Trung (required)";
            // 
            // hanVietToolStripMenuItem
            // 
            this.hanVietToolStripMenuItem.Checked = true;
            this.hanVietToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hanVietToolStripMenuItem.Enabled = false;
            this.hanVietToolStripMenuItem.Name = "hanVietToolStripMenuItem";
            this.hanVietToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.hanVietToolStripMenuItem.Text = "Hán Việt (required)";
            // 
            // vietToolStripMenuItem
            // 
            this.vietToolStripMenuItem.Checked = true;
            this.vietToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vietToolStripMenuItem.Enabled = false;
            this.vietToolStripMenuItem.Name = "vietToolStripMenuItem";
            this.vietToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.vietToolStripMenuItem.Text = "Việt (required)";
            // 
            // vietPhraseToolStripMenuItem
            // 
            this.vietPhraseToolStripMenuItem.Checked = true;
            this.vietPhraseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vietPhraseToolStripMenuItem.Name = "vietPhraseToolStripMenuItem";
            this.vietPhraseToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.vietPhraseToolStripMenuItem.Text = "&VietPhrase";
            this.vietPhraseToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.VietPhraseToolStripMenuItemCheckStateChanged);
            this.vietPhraseToolStripMenuItem.Click += new System.EventHandler(this.VietPhraseToolStripMenuItemClick);
            // 
            // vietPhraseOneMeaningToolStripMenuItem
            // 
            this.vietPhraseOneMeaningToolStripMenuItem.Checked = true;
            this.vietPhraseOneMeaningToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vietPhraseOneMeaningToolStripMenuItem.Name = "vietPhraseOneMeaningToolStripMenuItem";
            this.vietPhraseOneMeaningToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.vietPhraseOneMeaningToolStripMenuItem.Text = "VietPhrase &Một Nghĩa";
            this.vietPhraseOneMeaningToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.VietPhraseOneMeaningToolStripMenuItemCheckStateChanged);
            this.vietPhraseOneMeaningToolStripMenuItem.Click += new System.EventHandler(this.VietPhraseOneMeaningToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // translateFromClipboardToolStripButton
            // 
            this.translateFromClipboardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.translateFromClipboardToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("translateFromClipboardToolStripButton.Image")));
            this.translateFromClipboardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.translateFromClipboardToolStripButton.Name = "translateFromClipboardToolStripButton";
            this.translateFromClipboardToolStripButton.Size = new System.Drawing.Size(180, 24);
            this.translateFromClipboardToolStripButton.Text = "&Translate From Clipboard";
            this.translateFromClipboardToolStripButton.Click += new System.EventHandler(this.TranslateFromClipboardToolStripButtonClick);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // retranslateToolStripButton
            // 
            this.retranslateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.retranslateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("retranslateToolStripButton.Image")));
            this.retranslateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.retranslateToolStripButton.Name = "retranslateToolStripButton";
            this.retranslateToolStripButton.Size = new System.Drawing.Size(95, 24);
            this.retranslateToolStripButton.Text = "&Re-Translate";
            this.retranslateToolStripButton.Click += new System.EventHandler(this.RetranslateToolStripButtonClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // updateVietPhraseToolStripButton
            // 
            this.updateVietPhraseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateVietPhraseToolStripButton.Enabled = false;
            this.updateVietPhraseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("updateVietPhraseToolStripButton.Image")));
            this.updateVietPhraseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateVietPhraseToolStripButton.Name = "updateVietPhraseToolStripButton";
            this.updateVietPhraseToolStripButton.Size = new System.Drawing.Size(135, 24);
            this.updateVietPhraseToolStripButton.Text = "Update &VietPhrase";
            this.updateVietPhraseToolStripButton.Visible = false;
            this.updateVietPhraseToolStripButton.Click += new System.EventHandler(this.UpdateVietPhraseToolStripButtonClick);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            this.toolStripSeparator8.Visible = false;
            // 
            // updateNameToolStripButton
            // 
            this.updateNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateNameToolStripButton.Enabled = false;
            this.updateNameToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("updateNameToolStripButton.Image")));
            this.updateNameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateNameToolStripButton.Name = "updateNameToolStripButton";
            this.updateNameToolStripButton.Size = new System.Drawing.Size(106, 24);
            this.updateNameToolStripButton.Text = "Update &Name";
            this.updateNameToolStripButton.Visible = false;
            this.updateNameToolStripButton.Click += new System.EventHandler(this.UpdateNameToolStripButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            this.toolStripSeparator1.Visible = false;
            // 
            // autoScrollToolStripButton
            // 
            this.autoScrollToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.autoScrollToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("autoScrollToolStripButton.Image")));
            this.autoScrollToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.autoScrollToolStripButton.Name = "autoScrollToolStripButton";
            this.autoScrollToolStripButton.Size = new System.Drawing.Size(86, 24);
            this.autoScrollToolStripButton.Text = "&Auto Scroll";
            this.autoScrollToolStripButton.Click += new System.EventHandler(this.AutoScrollToolStripButtonClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // reloadDictToolStripButton
            // 
            this.reloadDictToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reloadDictToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadDictToolStripButton.Image")));
            this.reloadDictToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadDictToolStripButton.Name = "reloadDictToolStripButton";
            this.reloadDictToolStripButton.Size = new System.Drawing.Size(97, 24);
            this.reloadDictToolStripButton.Text = "Reload &Dicts";
            this.reloadDictToolStripButton.Click += new System.EventHandler(this.ReloadDictToolStripButtonClick);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(0, 24);
            this.toolStripButton1.Text = "F1 = : \"";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(0, 24);
            this.toolStripButton2.Text = "F2 = .\"";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(0, 24);
            this.toolStripButton3.Text = "F3 = ?\"";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(0, 24);
            this.toolStripButton4.Text = "F4 = !\"";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(0, 24);
            this.toolStripButton7.Text = "F5 = , ";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(0, 24);
            this.toolStripButton8.Text = "F6 = . ";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(0, 24);
            this.toolStripButton5.Text = "F7 = hay không";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(0, 24);
            this.toolStripButton6.Text = "F8 = mà";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 24);
            this.toolStripLabel1.Text = "F9 = của";
            // 
            // postTTVToolStripButton
            // 
            this.postTTVToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.postTTVToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("postTTVToolStripButton.Image")));
            this.postTTVToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.postTTVToolStripButton.Name = "postTTVToolStripButton";
            this.postTTVToolStripButton.Size = new System.Drawing.Size(69, 24);
            this.postTTVToolStripButton.Text = "&Post TTV";
            this.postTTVToolStripButton.Click += new System.EventHandler(this.PostTTVToolStripButtonClick);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 27);
            // 
            // nextToolStripButton
            // 
            this.nextToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nextToolStripButton.Enabled = false;
            this.nextToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nextToolStripButton.Image")));
            this.nextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextToolStripButton.Name = "nextToolStripButton";
            this.nextToolStripButton.Size = new System.Drawing.Size(44, 24);
            this.nextToolStripButton.Text = "Next";
            this.nextToolStripButton.ToolTipText = "Next (Alt + Right)";
            this.nextToolStripButton.Click += new System.EventHandler(this.NextToolStripButtonClick);
            // 
            // backToolStripButton
            // 
            this.backToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripButton.BackColor = System.Drawing.SystemColors.Control;
            this.backToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backToolStripButton.Enabled = false;
            this.backToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripButton.Image")));
            this.backToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backToolStripButton.Name = "backToolStripButton";
            this.backToolStripButton.Size = new System.Drawing.Size(44, 24);
            this.backToolStripButton.Text = "Back";
            this.backToolStripButton.ToolTipText = "Back (Alt + Left)";
            this.backToolStripButton.Click += new System.EventHandler(this.BackToolStripButtonClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.wordCountToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1169, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(477, 20);
            this.toolStripStatusLabel2.Text = "© 2009-2013 ngoctay@TangThuVien.com - Quick Translator 2013.07.08";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(672, 20);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // wordCountToolStripStatusLabel
            // 
            this.wordCountToolStripStatusLabel.Name = "wordCountToolStripStatusLabel";
            this.wordCountToolStripStatusLabel.Size = new System.Drawing.Size(0, 20);
            this.wordCountToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 510);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Quick Translator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripStatusLabel wordCountToolStripStatusLabel;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;

        private System.Windows.Forms.ToolStripButton backToolStripButton;

        private System.Windows.Forms.ToolStripButton nextToolStripButton;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;

        private System.Windows.Forms.ToolStripButton postTTVToolStripButton;

        private System.Windows.Forms.ToolStripMenuItem exportToWordToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem vietPhraseOneMeaningToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem vietPhraseToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem vietToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem hanVietToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem;

        private System.Windows.Forms.ToolStripDropDownButton layoutToolStripDropDownButton;

        private System.Windows.Forms.ToolStripSeparator toolStripButton10;

        private System.Windows.Forms.ToolStripButton retranslateToolStripButton;

        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;

        private System.Windows.Forms.ToolStripDropDownButton fileToolStripButton;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;

        private System.Windows.Forms.ToolStripButton updateNameToolStripButton;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

        private System.Windows.Forms.ToolStripButton updateVietPhraseToolStripButton;

        private System.Windows.Forms.ToolStripButton reloadDictToolStripButton;

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

        private System.Windows.Forms.ToolStripButton autoScrollToolStripButton;

        private System.Windows.Forms.ToolStripLabel toolStripButton8;

        private System.Windows.Forms.ToolStripLabel toolStripButton7;

        private System.Windows.Forms.ToolStripLabel toolStripButton6;

        private System.Windows.Forms.ToolStripLabel toolStripButton5;

        private System.Windows.Forms.ToolStripLabel toolStripButton4;

        private System.Windows.Forms.ToolStripLabel toolStripButton3;

        private System.Windows.Forms.ToolStripLabel toolStripButton2;

        private System.Windows.Forms.ToolStripLabel toolStripButton1;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private System.Windows.Forms.ToolStripButton translateFromClipboardToolStripButton;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
    }
}

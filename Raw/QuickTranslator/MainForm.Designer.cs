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
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickTranslator.MainForm));
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
            base.SuspendLayout();
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.SystemColors.Control;
            this.dockPanel.Location = new System.Drawing.Point(0, 25);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(877, 367);
            dockPanelGradient.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin.DockStripGradient = dockPanelGradient;
            tabGradient.EndColor = System.Drawing.SystemColors.Control;
            tabGradient.StartColor = System.Drawing.SystemColors.Control;
            tabGradient.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin.TabGradient = tabGradient;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin.DocumentGradient = dockPaneStripGradient;
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin.ToolWindowGradient = dockPaneStripToolWindowGradient;
            this.dockPanel.Theme.Skin.DockPaneStripSkin = dockPaneStripSkin;
            this.dockPanel.Theme.Skin.AutoHideStripSkin = autoHideStripSkin;
            this.dockPanel.TabIndex = 0;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
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
                this.backToolStripButton
            });
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(877, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.fileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.newWindowToolStripMenuItem,
                this.toolStripSeparator4,
                this.openToolStripMenuItem,
                this.saveToolStripMenuItem,
                this.toolStripSeparator7,
                this.exportToWordToolStripMenuItem
            });
            this.fileToolStripButton.Image = (System.Drawing.Image)resources.GetObject("fileToolStripButton.Image");
            this.fileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripButton.Name = "fileToolStripButton";
            this.fileToolStripButton.Size = new System.Drawing.Size(38, 22);
            this.fileToolStripButton.Text = "&File";
            this.newWindowToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("newWindowToolStripMenuItem.Image");
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)131159;
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.newWindowToolStripMenuItem.Text = "New &Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.NewWindowToolStripMenuItemClick);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            this.openToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("openToolStripMenuItem.Image");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)131153;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            this.saveToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("saveToolStripMenuItem.Image");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)131155;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveToolStripMenuItem.Text = "&Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(193, 6);
            this.exportToWordToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("exportToWordToolStripMenuItem.Image");
            this.exportToWordToolStripMenuItem.Name = "exportToWordToolStripMenuItem";
            this.exportToWordToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)131141;
            this.exportToWordToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportToWordToolStripMenuItem.Text = "&Export To Word";
            this.exportToWordToolStripMenuItem.Click += new System.EventHandler(this.ExportToWordToolStripMenuItemClick);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.layoutToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.layoutToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.chineseToolStripMenuItem,
                this.hanVietToolStripMenuItem,
                this.vietToolStripMenuItem,
                this.vietPhraseToolStripMenuItem,
                this.vietPhraseOneMeaningToolStripMenuItem
            });
            this.layoutToolStripDropDownButton.Image = (System.Drawing.Image)resources.GetObject("layoutToolStripDropDownButton.Image");
            this.layoutToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.layoutToolStripDropDownButton.Name = "layoutToolStripDropDownButton";
            this.layoutToolStripDropDownButton.Size = new System.Drawing.Size(56, 22);
            this.layoutToolStripDropDownButton.Text = "&Layout";
            this.chineseToolStripMenuItem.Checked = true;
            this.chineseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chineseToolStripMenuItem.Enabled = false;
            this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            this.chineseToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.chineseToolStripMenuItem.Text = "Trung (required)";
            this.hanVietToolStripMenuItem.Checked = true;
            this.hanVietToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hanVietToolStripMenuItem.Enabled = false;
            this.hanVietToolStripMenuItem.Name = "hanVietToolStripMenuItem";
            this.hanVietToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.hanVietToolStripMenuItem.Text = "Hán Việt (required)";
            this.vietToolStripMenuItem.Checked = true;
            this.vietToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vietToolStripMenuItem.Enabled = false;
            this.vietToolStripMenuItem.Name = "vietToolStripMenuItem";
            this.vietToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.vietToolStripMenuItem.Text = "Việt (required)";
            this.vietPhraseToolStripMenuItem.Checked = true;
            this.vietPhraseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vietPhraseToolStripMenuItem.Name = "vietPhraseToolStripMenuItem";
            this.vietPhraseToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.vietPhraseToolStripMenuItem.Text = "&VietPhrase";
            this.vietPhraseToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.VietPhraseToolStripMenuItemCheckStateChanged);
            this.vietPhraseToolStripMenuItem.Click += new System.EventHandler(this.VietPhraseToolStripMenuItemClick);
            this.vietPhraseOneMeaningToolStripMenuItem.Checked = true;
            this.vietPhraseOneMeaningToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vietPhraseOneMeaningToolStripMenuItem.Name = "vietPhraseOneMeaningToolStripMenuItem";
            this.vietPhraseOneMeaningToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.vietPhraseOneMeaningToolStripMenuItem.Text = "VietPhrase &Một Nghĩa";
            this.vietPhraseOneMeaningToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.VietPhraseOneMeaningToolStripMenuItemCheckStateChanged);
            this.vietPhraseOneMeaningToolStripMenuItem.Click += new System.EventHandler(this.VietPhraseOneMeaningToolStripMenuItemClick);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.translateFromClipboardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.translateFromClipboardToolStripButton.Image = (System.Drawing.Image)resources.GetObject("translateFromClipboardToolStripButton.Image");
            this.translateFromClipboardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.translateFromClipboardToolStripButton.Name = "translateFromClipboardToolStripButton";
            this.translateFromClipboardToolStripButton.Size = new System.Drawing.Size(145, 22);
            this.translateFromClipboardToolStripButton.Text = "&Translate From Clipboard";
            this.translateFromClipboardToolStripButton.Click += new System.EventHandler(this.TranslateFromClipboardToolStripButtonClick);
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            this.retranslateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.retranslateToolStripButton.Image = (System.Drawing.Image)resources.GetObject("retranslateToolStripButton.Image");
            this.retranslateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.retranslateToolStripButton.Name = "retranslateToolStripButton";
            this.retranslateToolStripButton.Size = new System.Drawing.Size(77, 22);
            this.retranslateToolStripButton.Text = "&Re-Translate";
            this.retranslateToolStripButton.Click += new System.EventHandler(this.RetranslateToolStripButtonClick);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            this.updateVietPhraseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateVietPhraseToolStripButton.Enabled = false;
            this.updateVietPhraseToolStripButton.Image = (System.Drawing.Image)resources.GetObject("updateVietPhraseToolStripButton.Image");
            this.updateVietPhraseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateVietPhraseToolStripButton.Name = "updateVietPhraseToolStripButton";
            this.updateVietPhraseToolStripButton.Size = new System.Drawing.Size(107, 22);
            this.updateVietPhraseToolStripButton.Text = "Update &VietPhrase";
            this.updateVietPhraseToolStripButton.Visible = false;
            this.updateVietPhraseToolStripButton.Click += new System.EventHandler(this.UpdateVietPhraseToolStripButtonClick);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator8.Visible = false;
            this.updateNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateNameToolStripButton.Enabled = false;
            this.updateNameToolStripButton.Image = (System.Drawing.Image)resources.GetObject("updateNameToolStripButton.Image");
            this.updateNameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateNameToolStripButton.Name = "updateNameToolStripButton";
            this.updateNameToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.updateNameToolStripButton.Text = "Update &Name";
            this.updateNameToolStripButton.Visible = false;
            this.updateNameToolStripButton.Click += new System.EventHandler(this.UpdateNameToolStripButtonClick);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            this.autoScrollToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.autoScrollToolStripButton.Image = (System.Drawing.Image)resources.GetObject("autoScrollToolStripButton.Image");
            this.autoScrollToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.autoScrollToolStripButton.Name = "autoScrollToolStripButton";
            this.autoScrollToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.autoScrollToolStripButton.Text = "&Auto Scroll";
            this.autoScrollToolStripButton.Click += new System.EventHandler(this.AutoScrollToolStripButtonClick);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            this.reloadDictToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reloadDictToolStripButton.Image = (System.Drawing.Image)resources.GetObject("reloadDictToolStripButton.Image");
            this.reloadDictToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadDictToolStripButton.Name = "reloadDictToolStripButton";
            this.reloadDictToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.reloadDictToolStripButton.Text = "Reload &Dicts";
            this.reloadDictToolStripButton.Click += new System.EventHandler(this.ReloadDictToolStripButtonClick);
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(6, 25);
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(0, 22);
            this.toolStripButton1.Text = "F1 = : \"";
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripButton2.Image");
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(0, 22);
            this.toolStripButton2.Text = "F2 = .\"";
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton3.Image = (System.Drawing.Image)resources.GetObject("toolStripButton3.Image");
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(0, 22);
            this.toolStripButton3.Text = "F3 = ?\"";
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton4.Image = (System.Drawing.Image)resources.GetObject("toolStripButton4.Image");
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(0, 22);
            this.toolStripButton4.Text = "F4 = !\"";
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton7.Image = (System.Drawing.Image)resources.GetObject("toolStripButton7.Image");
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(0, 22);
            this.toolStripButton7.Text = "F5 = , ";
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton8.Image = (System.Drawing.Image)resources.GetObject("toolStripButton8.Image");
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(0, 22);
            this.toolStripButton8.Text = "F6 = . ";
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton5.Image = (System.Drawing.Image)resources.GetObject("toolStripButton5.Image");
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(0, 22);
            this.toolStripButton5.Text = "F7 = hay không";
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton6.Image = (System.Drawing.Image)resources.GetObject("toolStripButton6.Image");
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(0, 22);
            this.toolStripButton6.Text = "F8 = mà";
            this.toolStripLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            this.toolStripLabel1.Text = "F9 = của";
            this.postTTVToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.postTTVToolStripButton.Image = (System.Drawing.Image)resources.GetObject("postTTVToolStripButton.Image");
            this.postTTVToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.postTTVToolStripButton.Name = "postTTVToolStripButton";
            this.postTTVToolStripButton.Size = new System.Drawing.Size(58, 22);
            this.postTTVToolStripButton.Text = "&Post TTV";
            this.postTTVToolStripButton.Click += new System.EventHandler(this.PostTTVToolStripButtonClick);
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            this.nextToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nextToolStripButton.Enabled = false;
            this.nextToolStripButton.Image = (System.Drawing.Image)resources.GetObject("nextToolStripButton.Image");
            this.nextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextToolStripButton.Name = "nextToolStripButton";
            this.nextToolStripButton.Size = new System.Drawing.Size(35, 22);
            this.nextToolStripButton.Text = "Next";
            this.nextToolStripButton.ToolTipText = "Next (Alt + Right)";
            this.nextToolStripButton.Click += new System.EventHandler(this.NextToolStripButtonClick);
            this.backToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripButton.BackColor = System.Drawing.SystemColors.Control;
            this.backToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backToolStripButton.Enabled = false;
            this.backToolStripButton.Image = (System.Drawing.Image)resources.GetObject("backToolStripButton.Image");
            this.backToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backToolStripButton.Name = "backToolStripButton";
            this.backToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.backToolStripButton.Text = "Back";
            this.backToolStripButton.ToolTipText = "Back (Alt + Left)";
            this.backToolStripButton.Click += new System.EventHandler(this.BackToolStripButtonClick);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.toolStripStatusLabel1,
                this.toolStripStatusLabel2,
                this.toolStripStatusLabel3,
                this.wordCountToolStripStatusLabel
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(877, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(384, 17);
            this.toolStripStatusLabel2.Text = "© 2009-2013 ngoctay@TangThuVien.com - Quick Translator 2013.07.08";
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(447, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.wordCountToolStripStatusLabel.Name = "wordCountToolStripStatusLabel";
            this.wordCountToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.wordCountToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllowDrop = true;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(877, 414);
            base.Controls.Add(this.dockPanel);
            base.Controls.Add(this.statusStrip1);
            base.Controls.Add(this.toolStrip1);
            base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            base.IsMdiContainer = true;
            base.KeyPreview = true;
            base.Name = "MainForm";
            this.Text = "Quick Translator";
            base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
            base.Load += new System.EventHandler(this.MainFormLoad);
            base.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            base.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            base.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
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

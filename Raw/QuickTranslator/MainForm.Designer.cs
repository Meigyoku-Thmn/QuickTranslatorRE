namespace QuickTranslator
{
	// Token: 0x02000012 RID: 18
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000111 RID: 273 RVA: 0x0000E714 File Offset: 0x0000D714
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000E734 File Offset: 0x0000D734
		private void InitializeComponent()
		{
			global::WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin = new global::WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
			global::WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin = new global::WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
			global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient = new global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin = new global::WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
			global::WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient = new global::WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient = new global::WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::QuickTranslator.MainForm));
			this.dockPanel = new global::WeifenLuo.WinFormsUI.Docking.DockPanel();
			this.toolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.fileToolStripButton = new global::System.Windows.Forms.ToolStripDropDownButton();
			this.newWindowToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.openToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.exportToWordToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.layoutToolStripDropDownButton = new global::System.Windows.Forms.ToolStripDropDownButton();
			this.chineseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.hanVietToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.vietToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.vietPhraseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.vietPhraseOneMeaningToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.translateFromClipboardToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator9 = new global::System.Windows.Forms.ToolStripSeparator();
			this.retranslateToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.updateVietPhraseToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new global::System.Windows.Forms.ToolStripSeparator();
			this.updateNameToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.autoScrollToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.reloadDictToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripButton10 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripButton2 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripButton3 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripButton4 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripButton7 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripButton8 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripButton5 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripButton6 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel1 = new global::System.Windows.Forms.ToolStripLabel();
			this.postTTVToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator10 = new global::System.Windows.Forms.ToolStripSeparator();
			this.nextToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.backToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.wordCountToolStripStatusLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.dockPanel.ActiveAutoHideContent = null;
			this.dockPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dockPanel.DockBackColor = global::System.Drawing.SystemColors.Control;
			this.dockPanel.Location = new global::System.Drawing.Point(0, 25);
			this.dockPanel.Name = "dockPanel";
			this.dockPanel.Size = new global::System.Drawing.Size(877, 367);
			dockPanelGradient.EndColor = global::System.Drawing.SystemColors.ControlLight;
			dockPanelGradient.StartColor = global::System.Drawing.SystemColors.ControlLight;
			autoHideStripSkin.DockStripGradient = dockPanelGradient;
			tabGradient.EndColor = global::System.Drawing.SystemColors.Control;
			tabGradient.StartColor = global::System.Drawing.SystemColors.Control;
			tabGradient.TextColor = global::System.Drawing.SystemColors.ControlDarkDark;
			autoHideStripSkin.TabGradient = tabGradient;
			dockPanelSkin.AutoHideStripSkin = autoHideStripSkin;
			tabGradient2.EndColor = global::System.Drawing.SystemColors.ControlLightLight;
			tabGradient2.StartColor = global::System.Drawing.SystemColors.ControlLightLight;
			tabGradient2.TextColor = global::System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient.ActiveTabGradient = tabGradient2;
			dockPanelGradient2.EndColor = global::System.Drawing.SystemColors.Control;
			dockPanelGradient2.StartColor = global::System.Drawing.SystemColors.Control;
			dockPaneStripGradient.DockStripGradient = dockPanelGradient2;
			tabGradient3.EndColor = global::System.Drawing.SystemColors.ControlLight;
			tabGradient3.StartColor = global::System.Drawing.SystemColors.ControlLight;
			tabGradient3.TextColor = global::System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient.InactiveTabGradient = tabGradient3;
			dockPaneStripSkin.DocumentGradient = dockPaneStripGradient;
			tabGradient4.EndColor = global::System.Drawing.SystemColors.ActiveCaption;
			tabGradient4.LinearGradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient4.StartColor = global::System.Drawing.SystemColors.GradientActiveCaption;
			tabGradient4.TextColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			dockPaneStripToolWindowGradient.ActiveCaptionGradient = tabGradient4;
			tabGradient5.EndColor = global::System.Drawing.SystemColors.Control;
			tabGradient5.StartColor = global::System.Drawing.SystemColors.Control;
			tabGradient5.TextColor = global::System.Drawing.SystemColors.ControlText;
			dockPaneStripToolWindowGradient.ActiveTabGradient = tabGradient5;
			dockPanelGradient3.EndColor = global::System.Drawing.SystemColors.ControlLight;
			dockPanelGradient3.StartColor = global::System.Drawing.SystemColors.ControlLight;
			dockPaneStripToolWindowGradient.DockStripGradient = dockPanelGradient3;
			tabGradient6.EndColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			tabGradient6.LinearGradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient6.StartColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			tabGradient6.TextColor = global::System.Drawing.SystemColors.ControlText;
			dockPaneStripToolWindowGradient.InactiveCaptionGradient = tabGradient6;
			tabGradient7.EndColor = global::System.Drawing.Color.Transparent;
			tabGradient7.StartColor = global::System.Drawing.Color.Transparent;
			tabGradient7.TextColor = global::System.Drawing.SystemColors.ControlDarkDark;
			dockPaneStripToolWindowGradient.InactiveTabGradient = tabGradient7;
			dockPaneStripSkin.ToolWindowGradient = dockPaneStripToolWindowGradient;
			dockPanelSkin.DockPaneStripSkin = dockPaneStripSkin;
			this.dockPanel.Skin = dockPanelSkin;
			this.dockPanel.TabIndex = 0;
			this.toolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
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
			this.toolStrip1.LayoutStyle = global::System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new global::System.Drawing.Size(877, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			this.fileToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fileToolStripButton.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.newWindowToolStripMenuItem,
				this.toolStripSeparator4,
				this.openToolStripMenuItem,
				this.saveToolStripMenuItem,
				this.toolStripSeparator7,
				this.exportToWordToolStripMenuItem
			});
			this.fileToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("fileToolStripButton.Image");
			this.fileToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.fileToolStripButton.Name = "fileToolStripButton";
			this.fileToolStripButton.Size = new global::System.Drawing.Size(38, 22);
			this.fileToolStripButton.Text = "&File";
			this.newWindowToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("newWindowToolStripMenuItem.Image");
			this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
			this.newWindowToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131159;
			this.newWindowToolStripMenuItem.Size = new global::System.Drawing.Size(196, 22);
			this.newWindowToolStripMenuItem.Text = "New &Window";
			this.newWindowToolStripMenuItem.Click += new global::System.EventHandler(this.NewWindowToolStripMenuItemClick);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(193, 6);
			this.openToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("openToolStripMenuItem.Image");
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131153;
			this.openToolStripMenuItem.Size = new global::System.Drawing.Size(196, 22);
			this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new global::System.EventHandler(this.OpenToolStripMenuItemClick);
			this.saveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("saveToolStripMenuItem.Image");
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131155;
			this.saveToolStripMenuItem.Size = new global::System.Drawing.Size(196, 22);
			this.saveToolStripMenuItem.Text = "&Save...";
			this.saveToolStripMenuItem.Click += new global::System.EventHandler(this.SaveToolStripMenuItemClick);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new global::System.Drawing.Size(193, 6);
			this.exportToWordToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("exportToWordToolStripMenuItem.Image");
			this.exportToWordToolStripMenuItem.Name = "exportToWordToolStripMenuItem";
			this.exportToWordToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131141;
			this.exportToWordToolStripMenuItem.Size = new global::System.Drawing.Size(196, 22);
			this.exportToWordToolStripMenuItem.Text = "&Export To Word";
			this.exportToWordToolStripMenuItem.Click += new global::System.EventHandler(this.ExportToWordToolStripMenuItemClick);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(6, 25);
			this.layoutToolStripDropDownButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.layoutToolStripDropDownButton.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chineseToolStripMenuItem,
				this.hanVietToolStripMenuItem,
				this.vietToolStripMenuItem,
				this.vietPhraseToolStripMenuItem,
				this.vietPhraseOneMeaningToolStripMenuItem
			});
			this.layoutToolStripDropDownButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("layoutToolStripDropDownButton.Image");
			this.layoutToolStripDropDownButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.layoutToolStripDropDownButton.Name = "layoutToolStripDropDownButton";
			this.layoutToolStripDropDownButton.Size = new global::System.Drawing.Size(56, 22);
			this.layoutToolStripDropDownButton.Text = "&Layout";
			this.chineseToolStripMenuItem.Checked = true;
			this.chineseToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chineseToolStripMenuItem.Enabled = false;
			this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
			this.chineseToolStripMenuItem.Size = new global::System.Drawing.Size(189, 22);
			this.chineseToolStripMenuItem.Text = "Trung (required)";
			this.hanVietToolStripMenuItem.Checked = true;
			this.hanVietToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.hanVietToolStripMenuItem.Enabled = false;
			this.hanVietToolStripMenuItem.Name = "hanVietToolStripMenuItem";
			this.hanVietToolStripMenuItem.Size = new global::System.Drawing.Size(189, 22);
			this.hanVietToolStripMenuItem.Text = "Hán Việt (required)";
			this.vietToolStripMenuItem.Checked = true;
			this.vietToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.vietToolStripMenuItem.Enabled = false;
			this.vietToolStripMenuItem.Name = "vietToolStripMenuItem";
			this.vietToolStripMenuItem.Size = new global::System.Drawing.Size(189, 22);
			this.vietToolStripMenuItem.Text = "Việt (required)";
			this.vietPhraseToolStripMenuItem.Checked = true;
			this.vietPhraseToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.vietPhraseToolStripMenuItem.Name = "vietPhraseToolStripMenuItem";
			this.vietPhraseToolStripMenuItem.Size = new global::System.Drawing.Size(189, 22);
			this.vietPhraseToolStripMenuItem.Text = "&VietPhrase";
			this.vietPhraseToolStripMenuItem.CheckStateChanged += new global::System.EventHandler(this.VietPhraseToolStripMenuItemCheckStateChanged);
			this.vietPhraseToolStripMenuItem.Click += new global::System.EventHandler(this.VietPhraseToolStripMenuItemClick);
			this.vietPhraseOneMeaningToolStripMenuItem.Checked = true;
			this.vietPhraseOneMeaningToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.vietPhraseOneMeaningToolStripMenuItem.Name = "vietPhraseOneMeaningToolStripMenuItem";
			this.vietPhraseOneMeaningToolStripMenuItem.Size = new global::System.Drawing.Size(189, 22);
			this.vietPhraseOneMeaningToolStripMenuItem.Text = "VietPhrase &Một Nghĩa";
			this.vietPhraseOneMeaningToolStripMenuItem.CheckStateChanged += new global::System.EventHandler(this.VietPhraseOneMeaningToolStripMenuItemCheckStateChanged);
			this.vietPhraseOneMeaningToolStripMenuItem.Click += new global::System.EventHandler(this.VietPhraseOneMeaningToolStripMenuItemClick);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.translateFromClipboardToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.translateFromClipboardToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("translateFromClipboardToolStripButton.Image");
			this.translateFromClipboardToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.translateFromClipboardToolStripButton.Name = "translateFromClipboardToolStripButton";
			this.translateFromClipboardToolStripButton.Size = new global::System.Drawing.Size(145, 22);
			this.translateFromClipboardToolStripButton.Text = "&Translate From Clipboard";
			this.translateFromClipboardToolStripButton.Click += new global::System.EventHandler(this.TranslateFromClipboardToolStripButtonClick);
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new global::System.Drawing.Size(6, 25);
			this.retranslateToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.retranslateToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("retranslateToolStripButton.Image");
			this.retranslateToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.retranslateToolStripButton.Name = "retranslateToolStripButton";
			this.retranslateToolStripButton.Size = new global::System.Drawing.Size(77, 22);
			this.retranslateToolStripButton.Text = "&Re-Translate";
			this.retranslateToolStripButton.Click += new global::System.EventHandler(this.RetranslateToolStripButtonClick);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(6, 25);
			this.updateVietPhraseToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.updateVietPhraseToolStripButton.Enabled = false;
			this.updateVietPhraseToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("updateVietPhraseToolStripButton.Image");
			this.updateVietPhraseToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.updateVietPhraseToolStripButton.Name = "updateVietPhraseToolStripButton";
			this.updateVietPhraseToolStripButton.Size = new global::System.Drawing.Size(107, 22);
			this.updateVietPhraseToolStripButton.Text = "Update &VietPhrase";
			this.updateVietPhraseToolStripButton.Visible = false;
			this.updateVietPhraseToolStripButton.Click += new global::System.EventHandler(this.UpdateVietPhraseToolStripButtonClick);
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripSeparator8.Visible = false;
			this.updateNameToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.updateNameToolStripButton.Enabled = false;
			this.updateNameToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("updateNameToolStripButton.Image");
			this.updateNameToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.updateNameToolStripButton.Name = "updateNameToolStripButton";
			this.updateNameToolStripButton.Size = new global::System.Drawing.Size(84, 22);
			this.updateNameToolStripButton.Text = "Update &Name";
			this.updateNameToolStripButton.Visible = false;
			this.updateNameToolStripButton.Click += new global::System.EventHandler(this.UpdateNameToolStripButtonClick);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripSeparator1.Visible = false;
			this.autoScrollToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.autoScrollToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("autoScrollToolStripButton.Image");
			this.autoScrollToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.autoScrollToolStripButton.Name = "autoScrollToolStripButton";
			this.autoScrollToolStripButton.Size = new global::System.Drawing.Size(69, 22);
			this.autoScrollToolStripButton.Text = "&Auto Scroll";
			this.autoScrollToolStripButton.Click += new global::System.EventHandler(this.AutoScrollToolStripButtonClick);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(6, 25);
			this.reloadDictToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.reloadDictToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("reloadDictToolStripButton.Image");
			this.reloadDictToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.reloadDictToolStripButton.Name = "reloadDictToolStripButton";
			this.reloadDictToolStripButton.Size = new global::System.Drawing.Size(76, 22);
			this.reloadDictToolStripButton.Text = "Reload &Dicts";
			this.reloadDictToolStripButton.Click += new global::System.EventHandler(this.ReloadDictToolStripButtonClick);
			this.toolStripButton10.Name = "toolStripButton10";
			this.toolStripButton10.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripButton1.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.toolStripButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton1.Image");
			this.toolStripButton1.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new global::System.Drawing.Size(0, 22);
			this.toolStripButton1.Text = "F1 = : \"";
			this.toolStripButton2.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.toolStripButton2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton2.Image");
			this.toolStripButton2.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new global::System.Drawing.Size(0, 22);
			this.toolStripButton2.Text = "F2 = .\"";
			this.toolStripButton3.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.toolStripButton3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton3.Image");
			this.toolStripButton3.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new global::System.Drawing.Size(0, 22);
			this.toolStripButton3.Text = "F3 = ?\"";
			this.toolStripButton4.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.toolStripButton4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton4.Image");
			this.toolStripButton4.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new global::System.Drawing.Size(0, 22);
			this.toolStripButton4.Text = "F4 = !\"";
			this.toolStripButton7.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.toolStripButton7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton7.Image");
			this.toolStripButton7.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton7.Name = "toolStripButton7";
			this.toolStripButton7.Size = new global::System.Drawing.Size(0, 22);
			this.toolStripButton7.Text = "F5 = , ";
			this.toolStripButton8.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.toolStripButton8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton8.Image");
			this.toolStripButton8.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton8.Name = "toolStripButton8";
			this.toolStripButton8.Size = new global::System.Drawing.Size(0, 22);
			this.toolStripButton8.Text = "F6 = . ";
			this.toolStripButton5.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.toolStripButton5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton5.Image");
			this.toolStripButton5.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new global::System.Drawing.Size(0, 22);
			this.toolStripButton5.Text = "F7 = hay không";
			this.toolStripButton6.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.toolStripButton6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton6.Image");
			this.toolStripButton6.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new global::System.Drawing.Size(0, 22);
			this.toolStripButton6.Text = "F8 = mà";
			this.toolStripLabel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.toolStripLabel1.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new global::System.Drawing.Size(0, 22);
			this.toolStripLabel1.Text = "F9 = của";
			this.postTTVToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.postTTVToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("postTTVToolStripButton.Image");
			this.postTTVToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.postTTVToolStripButton.Name = "postTTVToolStripButton";
			this.postTTVToolStripButton.Size = new global::System.Drawing.Size(58, 22);
			this.postTTVToolStripButton.Text = "&Post TTV";
			this.postTTVToolStripButton.Click += new global::System.EventHandler(this.PostTTVToolStripButtonClick);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new global::System.Drawing.Size(6, 25);
			this.nextToolStripButton.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.nextToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.nextToolStripButton.Enabled = false;
			this.nextToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("nextToolStripButton.Image");
			this.nextToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.nextToolStripButton.Name = "nextToolStripButton";
			this.nextToolStripButton.Size = new global::System.Drawing.Size(35, 22);
			this.nextToolStripButton.Text = "Next";
			this.nextToolStripButton.ToolTipText = "Next (Alt + Right)";
			this.nextToolStripButton.Click += new global::System.EventHandler(this.NextToolStripButtonClick);
			this.backToolStripButton.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.backToolStripButton.BackColor = global::System.Drawing.SystemColors.Control;
			this.backToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.backToolStripButton.Enabled = false;
			this.backToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("backToolStripButton.Image");
			this.backToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.backToolStripButton.Name = "backToolStripButton";
			this.backToolStripButton.Size = new global::System.Drawing.Size(36, 22);
			this.backToolStripButton.Text = "Back";
			this.backToolStripButton.ToolTipText = "Back (Alt + Left)";
			this.backToolStripButton.Click += new global::System.EventHandler(this.BackToolStripButtonClick);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel1,
				this.toolStripStatusLabel2,
				this.toolStripStatusLabel3,
				this.wordCountToolStripStatusLabel
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 392);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(877, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(0, 17);
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new global::System.Drawing.Size(384, 17);
			this.toolStripStatusLabel2.Text = "© 2009-2013 ngoctay@TangThuVien.com - Quick Translator 2013.07.08";
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new global::System.Drawing.Size(447, 17);
			this.toolStripStatusLabel3.Spring = true;
			this.wordCountToolStripStatusLabel.Name = "wordCountToolStripStatusLabel";
			this.wordCountToolStripStatusLabel.Size = new global::System.Drawing.Size(0, 17);
			this.wordCountToolStripStatusLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.AllowDrop = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(877, 414);
			base.Controls.Add(this.dockPanel);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.toolStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.IsMdiContainer = true;
			base.KeyPreview = true;
			base.Name = "MainForm";
			this.Text = "Quick Translator";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			base.Load += new global::System.EventHandler(this.MainFormLoad);
			base.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			base.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000105 RID: 261
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.ToolStripStatusLabel wordCountToolStripStatusLabel;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.ToolStripButton backToolStripButton;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.ToolStripButton nextToolStripButton;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator10;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.ToolStripButton postTTVToolStripButton;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.ToolStripMenuItem exportToWordToolStripMenuItem;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.ToolStripMenuItem vietPhraseOneMeaningToolStripMenuItem;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.ToolStripMenuItem vietPhraseToolStripMenuItem;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.ToolStripMenuItem vietToolStripMenuItem;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.ToolStripMenuItem hanVietToolStripMenuItem;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.ToolStripDropDownButton layoutToolStripDropDownButton;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.ToolStripSeparator toolStripButton10;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.ToolStripButton retranslateToolStripButton;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.ToolStripDropDownButton fileToolStripButton;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator9;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.ToolStripButton updateNameToolStripButton;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.ToolStripButton updateVietPhraseToolStripButton;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.ToolStripButton reloadDictToolStripButton;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel1;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.ToolStripButton autoScrollToolStripButton;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.ToolStripLabel toolStripButton8;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.ToolStripLabel toolStripButton7;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.ToolStripLabel toolStripButton6;

		// Token: 0x04000126 RID: 294
		private global::System.Windows.Forms.ToolStripLabel toolStripButton5;

		// Token: 0x04000127 RID: 295
		private global::System.Windows.Forms.ToolStripLabel toolStripButton4;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.ToolStripLabel toolStripButton3;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Forms.ToolStripLabel toolStripButton2;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.ToolStripLabel toolStripButton1;

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x0400012D RID: 301
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.ToolStripButton translateFromClipboardToolStripButton;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.ToolStrip toolStrip1;

		// Token: 0x04000134 RID: 308
		private global::WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
	}
}

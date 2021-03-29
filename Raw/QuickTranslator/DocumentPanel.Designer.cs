namespace QuickTranslator
{
	// Token: 0x02000004 RID: 4
	public partial class DocumentPanel : global::WeifenLuo.WinFormsUI.Docking.DockContent
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00008346 File Offset: 0x00007346
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00008368 File Offset: 0x00007368
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::QuickTranslator.DocumentPanel));
			this.commentContextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.markForReviewToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.clearNoteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.insertBlankLinesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.addToVietPhraseContextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToVietPhraseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.addToNameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.updateNamePhuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.updatePhienAmToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.baikeingToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ncikuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.copyToVietToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.copyToClipboardToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteSelectedTextToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteRememberToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contentRichTextBox = new global::QuickTranslator.ScrollingRichTextBox();
			this.chooseMeaningContextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.commentContextMenuStrip.SuspendLayout();
			this.addToVietPhraseContextMenuStrip.SuspendLayout();
			base.SuspendLayout();
			this.commentContextMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.markForReviewToolStripMenuItem,
				this.clearNoteToolStripMenuItem,
				this.toolStripSeparator1,
				this.insertBlankLinesToolStripMenuItem
			});
			this.commentContextMenuStrip.Name = "contextMenuStrip";
			this.commentContextMenuStrip.Size = new global::System.Drawing.Size(186, 76);
			this.markForReviewToolStripMenuItem.Name = "markForReviewToolStripMenuItem";
			this.markForReviewToolStripMenuItem.Overflow = global::System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
			this.markForReviewToolStripMenuItem.Size = new global::System.Drawing.Size(185, 22);
			this.markForReviewToolStripMenuItem.Text = "Chú ý cho biên dịch";
			this.markForReviewToolStripMenuItem.Click += new global::System.EventHandler(this.MarkForReviewToolStripMenuItemClick);
			this.clearNoteToolStripMenuItem.Name = "clearNoteToolStripMenuItem";
			this.clearNoteToolStripMenuItem.Size = new global::System.Drawing.Size(185, 22);
			this.clearNoteToolStripMenuItem.Text = "Bỏ chú ý";
			this.clearNoteToolStripMenuItem.Click += new global::System.EventHandler(this.ClearNoteToolStripMenuItemClick);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(182, 6);
			this.insertBlankLinesToolStripMenuItem.Name = "insertBlankLinesToolStripMenuItem";
			this.insertBlankLinesToolStripMenuItem.Size = new global::System.Drawing.Size(185, 22);
			this.insertBlankLinesToolStripMenuItem.Text = "Chèn các dòng trắng";
			this.insertBlankLinesToolStripMenuItem.Click += new global::System.EventHandler(this.InsertBlankLinesToolStripMenuItemClick);
			this.addToVietPhraseContextMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.addToVietPhraseToolStripMenuItem,
				this.addToNameToolStripMenuItem,
				this.updateNamePhuToolStripMenuItem,
				this.updatePhienAmToolStripMenuItem,
				this.toolStripSeparator2,
				this.baikeingToolStripMenuItem,
				this.ncikuToolStripMenuItem,
				this.toolStripSeparator3,
				this.copyToVietToolStripMenuItem,
				this.copyToClipboardToolStripMenuItem,
				this.deleteSelectedTextToolStripMenuItem,
				this.deleteRememberToolStripMenuItem
			});
			this.addToVietPhraseContextMenuStrip.Name = "addToVietPhraseContextMenuStrip";
			this.addToVietPhraseContextMenuStrip.Size = new global::System.Drawing.Size(241, 258);
			this.addToVietPhraseContextMenuStrip.Opening += new global::System.ComponentModel.CancelEventHandler(this.AddToVietPhraseContextMenuStripOpening);
			this.addToVietPhraseToolStripMenuItem.Name = "addToVietPhraseToolStripMenuItem";
			this.addToVietPhraseToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)262230;
			this.addToVietPhraseToolStripMenuItem.Size = new global::System.Drawing.Size(240, 22);
			this.addToVietPhraseToolStripMenuItem.Text = "Update &VietPhrase";
			this.addToVietPhraseToolStripMenuItem.Click += new global::System.EventHandler(this.AddToVietPhraseToolStripMenuItemClick);
			this.addToNameToolStripMenuItem.Name = "addToNameToolStripMenuItem";
			this.addToNameToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)262222;
			this.addToNameToolStripMenuItem.Size = new global::System.Drawing.Size(240, 22);
			this.addToNameToolStripMenuItem.Text = "Update &Name (chính)";
			this.addToNameToolStripMenuItem.Click += new global::System.EventHandler(this.AddToNameToolStripMenuItemClick);
			this.updateNamePhuToolStripMenuItem.Name = "updateNamePhuToolStripMenuItem";
			this.updateNamePhuToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)262221;
			this.updateNamePhuToolStripMenuItem.Size = new global::System.Drawing.Size(240, 22);
			this.updateNamePhuToolStripMenuItem.Text = "Update Name (phụ)";
			this.updateNamePhuToolStripMenuItem.Click += new global::System.EventHandler(this.UpdateNamePhuToolStripMenuItemClick);
			this.updatePhienAmToolStripMenuItem.Name = "updatePhienAmToolStripMenuItem";
			this.updatePhienAmToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)262224;
			this.updatePhienAmToolStripMenuItem.Size = new global::System.Drawing.Size(240, 22);
			this.updatePhienAmToolStripMenuItem.Text = "Update &Phiên Âm";
			this.updatePhienAmToolStripMenuItem.Click += new global::System.EventHandler(this.UpdatePhienAmToolStripMenuItemClick);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(237, 6);
			this.baikeingToolStripMenuItem.Name = "baikeingToolStripMenuItem";
			this.baikeingToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)262210;
			this.baikeingToolStripMenuItem.Size = new global::System.Drawing.Size(240, 22);
			this.baikeingToolStripMenuItem.Text = "&Baike-ing";
			this.baikeingToolStripMenuItem.Click += new global::System.EventHandler(this.BaikeingToolStripMenuItemClick);
			this.ncikuToolStripMenuItem.Name = "ncikuToolStripMenuItem";
			this.ncikuToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)262229;
			this.ncikuToolStripMenuItem.Size = new global::System.Drawing.Size(240, 22);
			this.ncikuToolStripMenuItem.Text = "Ncik&u-ing";
			this.ncikuToolStripMenuItem.Click += new global::System.EventHandler(this.NcikuToolStripMenuItemClick);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(237, 6);
			this.copyToVietToolStripMenuItem.Name = "copyToVietToolStripMenuItem";
			this.copyToVietToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)262211;
			this.copyToVietToolStripMenuItem.Size = new global::System.Drawing.Size(240, 22);
			this.copyToVietToolStripMenuItem.Text = "&Copy To Việt";
			this.copyToVietToolStripMenuItem.Click += new global::System.EventHandler(this.CopyToVietToolStripMenuItemClick);
			this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
			this.copyToClipboardToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131139;
			this.copyToClipboardToolStripMenuItem.Size = new global::System.Drawing.Size(240, 22);
			this.copyToClipboardToolStripMenuItem.Text = "Copy To Clipboard";
			this.copyToClipboardToolStripMenuItem.Click += new global::System.EventHandler(this.CopyToClipboardToolStripMenuItemClick);
			this.deleteSelectedTextToolStripMenuItem.Enabled = false;
			this.deleteSelectedTextToolStripMenuItem.Name = "deleteSelectedTextToolStripMenuItem";
			this.deleteSelectedTextToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)262232;
			this.deleteSelectedTextToolStripMenuItem.Size = new global::System.Drawing.Size(240, 22);
			this.deleteSelectedTextToolStripMenuItem.Text = "&Delete Selected Text";
			this.deleteSelectedTextToolStripMenuItem.Visible = false;
			this.deleteSelectedTextToolStripMenuItem.Click += new global::System.EventHandler(this.DeleteSelectedTextToolStripMenuItemClick);
			this.deleteRememberToolStripMenuItem.Enabled = false;
			this.deleteRememberToolStripMenuItem.Name = "deleteRememberToolStripMenuItem";
			this.deleteRememberToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)393304;
			this.deleteRememberToolStripMenuItem.Size = new global::System.Drawing.Size(240, 22);
			this.deleteRememberToolStripMenuItem.Text = "Delete (Remember)";
			this.deleteRememberToolStripMenuItem.Visible = false;
			this.deleteRememberToolStripMenuItem.Click += new global::System.EventHandler(this.DeleteRememberToolStripMenuItemClick);
			this.contentRichTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.contentRichTextBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.contentRichTextBox.Font = new global::System.Drawing.Font("Arial Unicode MS", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.contentRichTextBox.HideSelection = false;
			this.contentRichTextBox.Location = new global::System.Drawing.Point(0, 0);
			this.contentRichTextBox.Name = "contentRichTextBox";
			this.contentRichTextBox.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.contentRichTextBox.ShowSelectionMargin = true;
			this.contentRichTextBox.Size = new global::System.Drawing.Size(434, 365);
			this.contentRichTextBox.TabIndex = 0;
			this.contentRichTextBox.Text = "";
			this.contentRichTextBox.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.contentRichTextBox_KeyPress);
			this.contentRichTextBox.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.ContentRichTextBoxMouseMove);
			this.contentRichTextBox.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.ContentRichTextBoxMouseUp);
			this.chooseMeaningContextMenuStrip.Name = "chooseMeaningContextMenuStrip";
			this.chooseMeaningContextMenuStrip.Size = new global::System.Drawing.Size(61, 4);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(434, 365);
			base.Controls.Add(this.contentRichTextBox);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 128);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "DocumentPanel";
			this.Text = "DocumentPanel";
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.DocumentPanelKeyDown);
			this.commentContextMenuStrip.ResumeLayout(false);
			this.addToVietPhraseContextMenuStrip.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000B2 RID: 178
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.ToolStripMenuItem deleteRememberToolStripMenuItem;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.ToolStripMenuItem updateNamePhuToolStripMenuItem;

		// Token: 0x040000B5 RID: 181
		public global::System.Windows.Forms.ContextMenuStrip chooseMeaningContextMenuStrip;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.ToolStripMenuItem ncikuToolStripMenuItem;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.ToolStripMenuItem updatePhienAmToolStripMenuItem;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.ToolStripMenuItem deleteSelectedTextToolStripMenuItem;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.ToolStripMenuItem insertBlankLinesToolStripMenuItem;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.ToolStripMenuItem copyToVietToolStripMenuItem;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.ToolStripMenuItem baikeingToolStripMenuItem;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.ToolStripMenuItem addToNameToolStripMenuItem;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.ToolStripMenuItem addToVietPhraseToolStripMenuItem;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.ContextMenuStrip addToVietPhraseContextMenuStrip;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.ContextMenuStrip commentContextMenuStrip;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.ToolStripMenuItem clearNoteToolStripMenuItem;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.ToolStripMenuItem markForReviewToolStripMenuItem;

		// Token: 0x040000C6 RID: 198
		public global::QuickTranslator.ScrollingRichTextBox contentRichTextBox;
	}
}

namespace QuickTranslator
{
    public partial class DocumentPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickTranslator.DocumentPanel));
            this.commentContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.markForReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.insertBlankLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToVietPhraseContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToVietPhraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateNamePhuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePhienAmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.baikeingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ncikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToVietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRememberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentRichTextBox = new QuickTranslator.ScrollingRichTextBox();
            this.chooseMeaningContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.commentContextMenuStrip.SuspendLayout();
            this.addToVietPhraseContextMenuStrip.SuspendLayout();
            base.SuspendLayout();
            this.commentContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.markForReviewToolStripMenuItem,
                this.clearNoteToolStripMenuItem,
                this.toolStripSeparator1,
                this.insertBlankLinesToolStripMenuItem
            });
            this.commentContextMenuStrip.Name = "contextMenuStrip";
            this.commentContextMenuStrip.Size = new System.Drawing.Size(186, 76);
            this.markForReviewToolStripMenuItem.Name = "markForReviewToolStripMenuItem";
            this.markForReviewToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.markForReviewToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.markForReviewToolStripMenuItem.Text = "Chú ý cho biên dịch";
            this.markForReviewToolStripMenuItem.Click += new System.EventHandler(this.MarkForReviewToolStripMenuItemClick);
            this.clearNoteToolStripMenuItem.Name = "clearNoteToolStripMenuItem";
            this.clearNoteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.clearNoteToolStripMenuItem.Text = "Bỏ chú ý";
            this.clearNoteToolStripMenuItem.Click += new System.EventHandler(this.ClearNoteToolStripMenuItemClick);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            this.insertBlankLinesToolStripMenuItem.Name = "insertBlankLinesToolStripMenuItem";
            this.insertBlankLinesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.insertBlankLinesToolStripMenuItem.Text = "Chèn các dòng trắng";
            this.insertBlankLinesToolStripMenuItem.Click += new System.EventHandler(this.InsertBlankLinesToolStripMenuItemClick);
            this.addToVietPhraseContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
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
            this.addToVietPhraseContextMenuStrip.Size = new System.Drawing.Size(241, 258);
            this.addToVietPhraseContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.AddToVietPhraseContextMenuStripOpening);
            this.addToVietPhraseToolStripMenuItem.Name = "addToVietPhraseToolStripMenuItem";
            this.addToVietPhraseToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)262230;
            this.addToVietPhraseToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.addToVietPhraseToolStripMenuItem.Text = "Update &VietPhrase";
            this.addToVietPhraseToolStripMenuItem.Click += new System.EventHandler(this.AddToVietPhraseToolStripMenuItemClick);
            this.addToNameToolStripMenuItem.Name = "addToNameToolStripMenuItem";
            this.addToNameToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)262222;
            this.addToNameToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.addToNameToolStripMenuItem.Text = "Update &Name (chính)";
            this.addToNameToolStripMenuItem.Click += new System.EventHandler(this.AddToNameToolStripMenuItemClick);
            this.updateNamePhuToolStripMenuItem.Name = "updateNamePhuToolStripMenuItem";
            this.updateNamePhuToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)262221;
            this.updateNamePhuToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.updateNamePhuToolStripMenuItem.Text = "Update Name (phụ)";
            this.updateNamePhuToolStripMenuItem.Click += new System.EventHandler(this.UpdateNamePhuToolStripMenuItemClick);
            this.updatePhienAmToolStripMenuItem.Name = "updatePhienAmToolStripMenuItem";
            this.updatePhienAmToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)262224;
            this.updatePhienAmToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.updatePhienAmToolStripMenuItem.Text = "Update &Phiên Âm";
            this.updatePhienAmToolStripMenuItem.Click += new System.EventHandler(this.UpdatePhienAmToolStripMenuItemClick);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            this.baikeingToolStripMenuItem.Name = "baikeingToolStripMenuItem";
            this.baikeingToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)262210;
            this.baikeingToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.baikeingToolStripMenuItem.Text = "&Baike-ing";
            this.baikeingToolStripMenuItem.Click += new System.EventHandler(this.BaikeingToolStripMenuItemClick);
            this.ncikuToolStripMenuItem.Name = "ncikuToolStripMenuItem";
            this.ncikuToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)262229;
            this.ncikuToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.ncikuToolStripMenuItem.Text = "Ncik&u-ing";
            this.ncikuToolStripMenuItem.Click += new System.EventHandler(this.NcikuToolStripMenuItemClick);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(237, 6);
            this.copyToVietToolStripMenuItem.Name = "copyToVietToolStripMenuItem";
            this.copyToVietToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)262211;
            this.copyToVietToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.copyToVietToolStripMenuItem.Text = "&Copy To Việt";
            this.copyToVietToolStripMenuItem.Click += new System.EventHandler(this.CopyToVietToolStripMenuItemClick);
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)131139;
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy To Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopyToClipboardToolStripMenuItemClick);
            this.deleteSelectedTextToolStripMenuItem.Enabled = false;
            this.deleteSelectedTextToolStripMenuItem.Name = "deleteSelectedTextToolStripMenuItem";
            this.deleteSelectedTextToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)262232;
            this.deleteSelectedTextToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.deleteSelectedTextToolStripMenuItem.Text = "&Delete Selected Text";
            this.deleteSelectedTextToolStripMenuItem.Visible = false;
            this.deleteSelectedTextToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedTextToolStripMenuItemClick);
            this.deleteRememberToolStripMenuItem.Enabled = false;
            this.deleteRememberToolStripMenuItem.Name = "deleteRememberToolStripMenuItem";
            this.deleteRememberToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)393304;
            this.deleteRememberToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.deleteRememberToolStripMenuItem.Text = "Delete (Remember)";
            this.deleteRememberToolStripMenuItem.Visible = false;
            this.deleteRememberToolStripMenuItem.Click += new System.EventHandler(this.DeleteRememberToolStripMenuItemClick);
            this.contentRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentRichTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
            this.contentRichTextBox.HideSelection = false;
            this.contentRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.contentRichTextBox.ShowSelectionMargin = true;
            this.contentRichTextBox.Size = new System.Drawing.Size(434, 365);
            this.contentRichTextBox.TabIndex = 0;
            this.contentRichTextBox.Text = "";
            this.contentRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContentRichTextBox_KeyPress);
            this.contentRichTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ContentRichTextBoxMouseMove);
            this.contentRichTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentRichTextBoxMouseUp);
            this.chooseMeaningContextMenuStrip.Name = "chooseMeaningContextMenuStrip";
            this.chooseMeaningContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(434, 365);
            base.Controls.Add(this.contentRichTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            base.Name = "DocumentPanel";
            this.Text = "DocumentPanel";
            base.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DocumentPanelKeyDown);
            this.commentContextMenuStrip.ResumeLayout(false);
            this.addToVietPhraseContextMenuStrip.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripMenuItem deleteRememberToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem updateNamePhuToolStripMenuItem;

        public System.Windows.Forms.ContextMenuStrip chooseMeaningContextMenuStrip;

        private System.Windows.Forms.ToolStripMenuItem ncikuToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem updatePhienAmToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem deleteSelectedTextToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem insertBlankLinesToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem copyToVietToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem baikeingToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem addToNameToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem addToVietPhraseToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip addToVietPhraseContextMenuStrip;

        private System.Windows.Forms.ContextMenuStrip commentContextMenuStrip;

        private System.Windows.Forms.ToolStripMenuItem clearNoteToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem markForReviewToolStripMenuItem;

        public QuickTranslator.ScrollingRichTextBox contentRichTextBox;
    }
}

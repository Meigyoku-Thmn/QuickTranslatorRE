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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentPanel));
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
            this.copyToVietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRememberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentRichTextBox = new QuickTranslator.ScrollingRichTextBox();
            this.chooseMeaningContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.commentContextMenuStrip.SuspendLayout();
            this.addToVietPhraseContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // commentContextMenuStrip
            // 
            this.commentContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.commentContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markForReviewToolStripMenuItem,
            this.clearNoteToolStripMenuItem,
            this.toolStripSeparator1,
            this.insertBlankLinesToolStripMenuItem});
            this.commentContextMenuStrip.Name = "contextMenuStrip";
            this.commentContextMenuStrip.Size = new System.Drawing.Size(216, 82);
            // 
            // markForReviewToolStripMenuItem
            // 
            this.markForReviewToolStripMenuItem.Name = "markForReviewToolStripMenuItem";
            this.markForReviewToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.markForReviewToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.markForReviewToolStripMenuItem.Text = "Chú ý cho biên dịch";
            this.markForReviewToolStripMenuItem.Click += new System.EventHandler(this.MarkForReviewToolStripMenuItemClick);
            // 
            // clearNoteToolStripMenuItem
            // 
            this.clearNoteToolStripMenuItem.Name = "clearNoteToolStripMenuItem";
            this.clearNoteToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.clearNoteToolStripMenuItem.Text = "Bỏ chú ý";
            this.clearNoteToolStripMenuItem.Click += new System.EventHandler(this.ClearNoteToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // insertBlankLinesToolStripMenuItem
            // 
            this.insertBlankLinesToolStripMenuItem.Name = "insertBlankLinesToolStripMenuItem";
            this.insertBlankLinesToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.insertBlankLinesToolStripMenuItem.Text = "Chèn các dòng trắng";
            this.insertBlankLinesToolStripMenuItem.Click += new System.EventHandler(this.InsertBlankLinesToolStripMenuItemClick);
            // 
            // addToVietPhraseContextMenuStrip
            // 
            this.addToVietPhraseContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addToVietPhraseContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToVietPhraseToolStripMenuItem,
            this.addToNameToolStripMenuItem,
            this.updateNamePhuToolStripMenuItem,
            this.updatePhienAmToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyToVietToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.deleteSelectedTextToolStripMenuItem,
            this.deleteRememberToolStripMenuItem});
            this.addToVietPhraseContextMenuStrip.Name = "addToVietPhraseContextMenuStrip";
            this.addToVietPhraseContextMenuStrip.Size = new System.Drawing.Size(290, 256);
            this.addToVietPhraseContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.AddToVietPhraseContextMenuStripOpening);
            // 
            // addToVietPhraseToolStripMenuItem
            // 
            this.addToVietPhraseToolStripMenuItem.Name = "addToVietPhraseToolStripMenuItem";
            this.addToVietPhraseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.addToVietPhraseToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.addToVietPhraseToolStripMenuItem.Text = "Update &VietPhrase";
            this.addToVietPhraseToolStripMenuItem.Click += new System.EventHandler(this.AddToVietPhraseToolStripMenuItemClick);
            // 
            // addToNameToolStripMenuItem
            // 
            this.addToNameToolStripMenuItem.Name = "addToNameToolStripMenuItem";
            this.addToNameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.addToNameToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.addToNameToolStripMenuItem.Text = "Update &Name (chính)";
            this.addToNameToolStripMenuItem.Click += new System.EventHandler(this.AddToNameToolStripMenuItemClick);
            // 
            // updateNamePhuToolStripMenuItem
            // 
            this.updateNamePhuToolStripMenuItem.Name = "updateNamePhuToolStripMenuItem";
            this.updateNamePhuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.updateNamePhuToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.updateNamePhuToolStripMenuItem.Text = "Update Name (phụ)";
            this.updateNamePhuToolStripMenuItem.Click += new System.EventHandler(this.UpdateNamePhuToolStripMenuItemClick);
            // 
            // updatePhienAmToolStripMenuItem
            // 
            this.updatePhienAmToolStripMenuItem.Name = "updatePhienAmToolStripMenuItem";
            this.updatePhienAmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.updatePhienAmToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.updatePhienAmToolStripMenuItem.Text = "Update &Phiên Âm";
            this.updatePhienAmToolStripMenuItem.Click += new System.EventHandler(this.UpdatePhienAmToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
            // 
            // copyToVietToolStripMenuItem
            // 
            this.copyToVietToolStripMenuItem.Name = "copyToVietToolStripMenuItem";
            this.copyToVietToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.copyToVietToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.copyToVietToolStripMenuItem.Text = "&Copy To Việt";
            this.copyToVietToolStripMenuItem.Click += new System.EventHandler(this.CopyToVietToolStripMenuItemClick);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.copyToClipboardToolStripMenuItem.Text = "Copy To Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopyToClipboardToolStripMenuItemClick);
            // 
            // deleteSelectedTextToolStripMenuItem
            // 
            this.deleteSelectedTextToolStripMenuItem.Enabled = false;
            this.deleteSelectedTextToolStripMenuItem.Name = "deleteSelectedTextToolStripMenuItem";
            this.deleteSelectedTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.deleteSelectedTextToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.deleteSelectedTextToolStripMenuItem.Text = "&Delete Selected Text";
            this.deleteSelectedTextToolStripMenuItem.Visible = false;
            this.deleteSelectedTextToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedTextToolStripMenuItemClick);
            // 
            // deleteRememberToolStripMenuItem
            // 
            this.deleteRememberToolStripMenuItem.Enabled = false;
            this.deleteRememberToolStripMenuItem.Name = "deleteRememberToolStripMenuItem";
            this.deleteRememberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.deleteRememberToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.deleteRememberToolStripMenuItem.Text = "Delete (Remember)";
            this.deleteRememberToolStripMenuItem.Visible = false;
            this.deleteRememberToolStripMenuItem.Click += new System.EventHandler(this.DeleteRememberToolStripMenuItemClick);
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            // 
            // chooseMeaningContextMenuStrip
            // 
            this.chooseMeaningContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.chooseMeaningContextMenuStrip.Name = "chooseMeaningContextMenuStrip";
            this.chooseMeaningContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // DocumentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 365);
            this.Controls.Add(this.contentRichTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentPanel";
            this.Text = "DocumentPanel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DocumentPanelKeyDown);
            this.commentContextMenuStrip.ResumeLayout(false);
            this.addToVietPhraseContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ToolStripMenuItem deleteRememberToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem updateNamePhuToolStripMenuItem;

        public System.Windows.Forms.ContextMenuStrip chooseMeaningContextMenuStrip;

        private System.Windows.Forms.ToolStripMenuItem updatePhienAmToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem deleteSelectedTextToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem insertBlankLinesToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem copyToVietToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem addToNameToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem addToVietPhraseToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip addToVietPhraseContextMenuStrip;

        private System.Windows.Forms.ContextMenuStrip commentContextMenuStrip;

        private System.Windows.Forms.ToolStripMenuItem clearNoteToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem markForReviewToolStripMenuItem;

        public QuickTranslator.ScrollingRichTextBox contentRichTextBox;
    }
}

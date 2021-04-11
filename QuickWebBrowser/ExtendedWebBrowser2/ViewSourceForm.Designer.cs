namespace ExtendedWebBrowser2
{
    public partial class ViewSourceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSourceForm));
            this.sourceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sourceRichTextBox
            // 
            this.sourceRichTextBox.AutoWordSelection = true;
            this.sourceRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sourceRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sourceRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.sourceRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sourceRichTextBox.Name = "sourceRichTextBox";
            this.sourceRichTextBox.ReadOnly = true;
            this.sourceRichTextBox.ShowSelectionMargin = true;
            this.sourceRichTextBox.Size = new System.Drawing.Size(1371, 805);
            this.sourceRichTextBox.TabIndex = 0;
            this.sourceRichTextBox.Text = "";
            // 
            // ViewSourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 805);
            this.Controls.Add(this.sourceRichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewSourceForm";
            this.ShowInTaskbar = false;
            this.Text = "HTML Source";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.RichTextBox sourceRichTextBox;
    }
}

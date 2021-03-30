namespace QuickTranslator
{
    public partial class UpdateVietPhraseForm : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVietPhraseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.chineseTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hanVietRichTextBox = new System.Windows.Forms.TextBox();
            this.vietPhraseLabel = new System.Windows.Forms.Label();
            this.vietPhraseRichTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.sortingCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entryCountLabel = new System.Windows.Forms.Label();
            this.updatedByLabel = new System.Windows.Forms.Label();
            this.compressDictionaryHistoryCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.capitalize3WordsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.capitalize2WordsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.capitalize1WordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.capitalizeAllLinkLabel = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.surfBaikeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.existInBaikeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chinese:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chineseTextBox
            // 
            this.chineseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chineseTextBox.Location = new System.Drawing.Point(117, 32);
            this.chineseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.chineseTextBox.Name = "chineseTextBox";
            this.chineseTextBox.Size = new System.Drawing.Size(600, 34);
            this.chineseTextBox.TabIndex = 4;
            this.chineseTextBox.TextChanged += new System.EventHandler(this.ChineseTextBoxTextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hán Việt:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hanVietRichTextBox
            // 
            this.hanVietRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanVietRichTextBox.Location = new System.Drawing.Point(117, 80);
            this.hanVietRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hanVietRichTextBox.Multiline = true;
            this.hanVietRichTextBox.Name = "hanVietRichTextBox";
            this.hanVietRichTextBox.ReadOnly = true;
            this.hanVietRichTextBox.Size = new System.Drawing.Size(600, 70);
            this.hanVietRichTextBox.TabIndex = 5;
            // 
            // vietPhraseLabel
            // 
            this.vietPhraseLabel.Location = new System.Drawing.Point(12, 230);
            this.vietPhraseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vietPhraseLabel.Name = "vietPhraseLabel";
            this.vietPhraseLabel.Size = new System.Drawing.Size(97, 22);
            this.vietPhraseLabel.TabIndex = 0;
            this.vietPhraseLabel.Text = "VietPhrase:";
            this.vietPhraseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vietPhraseRichTextBox
            // 
            this.vietPhraseRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vietPhraseRichTextBox.Location = new System.Drawing.Point(117, 156);
            this.vietPhraseRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.vietPhraseRichTextBox.Multiline = true;
            this.vietPhraseRichTextBox.Name = "vietPhraseRichTextBox";
            this.vietPhraseRichTextBox.Size = new System.Drawing.Size(600, 162);
            this.vietPhraseRichTextBox.TabIndex = 6;
            this.vietPhraseRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VietPhraseRichTextBoxKeyDown);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(211, 433);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 28);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update or Add";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(600, 433);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 28);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(405, 433);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 28);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // sortingCheckBox
            // 
            this.sortingCheckBox.Location = new System.Drawing.Point(117, 354);
            this.sortingCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.sortingCheckBox.Name = "sortingCheckBox";
            this.sortingCheckBox.Size = new System.Drawing.Size(608, 30);
            this.sortingCheckBox.TabIndex = 7;
            this.sortingCheckBox.Text = "Sắp xếp lại dữ liệu từ điển";
            this.sortingCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Entries:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // entryCountLabel
            // 
            this.entryCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryCountLabel.Location = new System.Drawing.Point(117, 0);
            this.entryCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entryCountLabel.Name = "entryCountLabel";
            this.entryCountLabel.Size = new System.Drawing.Size(213, 28);
            this.entryCountLabel.TabIndex = 7;
            this.entryCountLabel.Text = "label4";
            this.entryCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatedByLabel
            // 
            this.updatedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updatedByLabel.Location = new System.Drawing.Point(117, 325);
            this.updatedByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updatedByLabel.Name = "updatedByLabel";
            this.updatedByLabel.Size = new System.Drawing.Size(608, 28);
            this.updatedByLabel.TabIndex = 8;
            this.updatedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // compressDictionaryHistoryCheckBox
            // 
            this.compressDictionaryHistoryCheckBox.Location = new System.Drawing.Point(117, 384);
            this.compressDictionaryHistoryCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.compressDictionaryHistoryCheckBox.Name = "compressDictionaryHistoryCheckBox";
            this.compressDictionaryHistoryCheckBox.Size = new System.Drawing.Size(608, 30);
            this.compressDictionaryHistoryCheckBox.TabIndex = 11;
            this.compressDictionaryHistoryCheckBox.Text = "Nén Dictionary History (với mỗi entry, chỉ giữ lại history của hành động gần nhất" +
    ")";
            this.compressDictionaryHistoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.capitalize3WordsLinkLabel);
            this.groupBox1.Controls.Add(this.capitalize2WordsLinkLabel);
            this.groupBox1.Controls.Add(this.capitalize1WordLinkLabel);
            this.groupBox1.Controls.Add(this.capitalizeAllLinkLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(725, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(192, 158);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit nhanh";
            // 
            // capitalize3WordsLinkLabel
            // 
            this.capitalize3WordsLinkLabel.Location = new System.Drawing.Point(11, 91);
            this.capitalize3WordsLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capitalize3WordsLinkLabel.Name = "capitalize3WordsLinkLabel";
            this.capitalize3WordsLinkLabel.Size = new System.Drawing.Size(171, 20);
            this.capitalize3WordsLinkLabel.TabIndex = 0;
            this.capitalize3WordsLinkLabel.TabStop = true;
            this.capitalize3WordsLinkLabel.Text = "Viết hoa 3 từ đơn đầu";
            this.capitalize3WordsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Capitalize3WordsLinkLabelLinkClicked);
            // 
            // capitalize2WordsLinkLabel
            // 
            this.capitalize2WordsLinkLabel.Location = new System.Drawing.Point(11, 55);
            this.capitalize2WordsLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capitalize2WordsLinkLabel.Name = "capitalize2WordsLinkLabel";
            this.capitalize2WordsLinkLabel.Size = new System.Drawing.Size(171, 20);
            this.capitalize2WordsLinkLabel.TabIndex = 0;
            this.capitalize2WordsLinkLabel.TabStop = true;
            this.capitalize2WordsLinkLabel.Text = "Viết hoa 2 từ đơn đầu";
            this.capitalize2WordsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Capitalize2WordsLinkLabelLinkClicked);
            // 
            // capitalize1WordLinkLabel
            // 
            this.capitalize1WordLinkLabel.Location = new System.Drawing.Point(11, 20);
            this.capitalize1WordLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capitalize1WordLinkLabel.Name = "capitalize1WordLinkLabel";
            this.capitalize1WordLinkLabel.Size = new System.Drawing.Size(171, 20);
            this.capitalize1WordLinkLabel.TabIndex = 0;
            this.capitalize1WordLinkLabel.TabStop = true;
            this.capitalize1WordLinkLabel.Text = "Viết hoa 1 từ đơn đầu";
            this.capitalize1WordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Capitalize1WordLinkLabelLinkClicked);
            // 
            // capitalizeAllLinkLabel
            // 
            this.capitalizeAllLinkLabel.Location = new System.Drawing.Point(11, 127);
            this.capitalizeAllLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capitalizeAllLinkLabel.Name = "capitalizeAllLinkLabel";
            this.capitalizeAllLinkLabel.Size = new System.Drawing.Size(171, 20);
            this.capitalizeAllLinkLabel.TabIndex = 0;
            this.capitalizeAllLinkLabel.TabStop = true;
            this.capitalizeAllLinkLabel.Text = "Viết hoa tất cả";
            this.capitalizeAllLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CapitalizeAllLinkLabelLinkClicked);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.surfBaikeLinkLabel);
            this.groupBox2.Controls.Add(this.existInBaikeLabel);
            this.groupBox2.Location = new System.Drawing.Point(725, 73);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(192, 79);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tồn tại trên Baike?";
            // 
            // surfBaikeLinkLabel
            // 
            this.surfBaikeLinkLabel.Location = new System.Drawing.Point(140, 34);
            this.surfBaikeLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surfBaikeLinkLabel.Name = "surfBaikeLinkLabel";
            this.surfBaikeLinkLabel.Size = new System.Drawing.Size(45, 25);
            this.surfBaikeLinkLabel.TabIndex = 17;
            this.surfBaikeLinkLabel.TabStop = true;
            this.surfBaikeLinkLabel.Text = "Xem";
            this.surfBaikeLinkLabel.Visible = false;
            this.surfBaikeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SurfBaikeLinkLabelLinkClicked);
            // 
            // existInBaikeLabel
            // 
            this.existInBaikeLabel.Location = new System.Drawing.Point(11, 30);
            this.existInBaikeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.existInBaikeLabel.Name = "existInBaikeLabel";
            this.existInBaikeLabel.Size = new System.Drawing.Size(117, 28);
            this.existInBaikeLabel.TabIndex = 0;
            this.existInBaikeLabel.Text = "Đang kiểm tra...";
            this.existInBaikeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateVietPhraseForm
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(927, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.compressDictionaryHistoryCheckBox);
            this.Controls.Add(this.updatedByLabel);
            this.Controls.Add(this.entryCountLabel);
            this.Controls.Add(this.sortingCheckBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.vietPhraseRichTextBox);
            this.Controls.Add(this.hanVietRichTextBox);
            this.Controls.Add(this.vietPhraseLabel);
            this.Controls.Add(this.chineseTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateVietPhraseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update VietPhrase/Name";
            this.Load += new System.EventHandler(this.UpdateVietPhraseFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.ComponentModel.IContainer components;

        private System.Windows.Forms.LinkLabel surfBaikeLinkLabel;

        private System.Windows.Forms.Label existInBaikeLabel;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.ComponentModel.BackgroundWorker backgroundWorker;

        private System.Windows.Forms.LinkLabel capitalizeAllLinkLabel;

        private System.Windows.Forms.LinkLabel capitalize1WordLinkLabel;

        private System.Windows.Forms.LinkLabel capitalize2WordsLinkLabel;

        private System.Windows.Forms.LinkLabel capitalize3WordsLinkLabel;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.CheckBox compressDictionaryHistoryCheckBox;

        private System.Windows.Forms.Label updatedByLabel;

        private System.Windows.Forms.Label entryCountLabel;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.CheckBox sortingCheckBox;

        private System.Windows.Forms.Label vietPhraseLabel;

        private System.Windows.Forms.Button updateButton;

        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.Button cancelButton;

        private System.Windows.Forms.TextBox vietPhraseRichTextBox;

        private System.Windows.Forms.TextBox hanVietRichTextBox;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox chineseTextBox;

        private System.Windows.Forms.Label label1;
    }
}

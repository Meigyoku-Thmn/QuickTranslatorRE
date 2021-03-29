namespace QuickTranslator
{
	// Token: 0x0200001A RID: 26
	public partial class UpdateVietPhraseForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000166 RID: 358 RVA: 0x00012AF7 File Offset: 0x00011AF7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00012B18 File Offset: 0x00011B18
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::QuickTranslator.UpdateVietPhraseForm));
			this.label1 = new global::System.Windows.Forms.Label();
			this.chineseTextBox = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.hanVietRichTextBox = new global::System.Windows.Forms.TextBox();
			this.vietPhraseLabel = new global::System.Windows.Forms.Label();
			this.vietPhraseRichTextBox = new global::System.Windows.Forms.TextBox();
			this.updateButton = new global::System.Windows.Forms.Button();
			this.cancelButton = new global::System.Windows.Forms.Button();
			this.deleteButton = new global::System.Windows.Forms.Button();
			this.sortingCheckBox = new global::System.Windows.Forms.CheckBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.entryCountLabel = new global::System.Windows.Forms.Label();
			this.updatedByLabel = new global::System.Windows.Forms.Label();
			this.compressDictionaryHistoryCheckBox = new global::System.Windows.Forms.CheckBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.capitalize3WordsLinkLabel = new global::System.Windows.Forms.LinkLabel();
			this.capitalize2WordsLinkLabel = new global::System.Windows.Forms.LinkLabel();
			this.capitalize1WordLinkLabel = new global::System.Windows.Forms.LinkLabel();
			this.capitalizeAllLinkLabel = new global::System.Windows.Forms.LinkLabel();
			this.backgroundWorker = new global::System.ComponentModel.BackgroundWorker();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.surfBaikeLinkLabel = new global::System.Windows.Forms.LinkLabel();
			this.existInBaikeLabel = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.label1.Location = new global::System.Drawing.Point(9, 33);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(73, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chinese:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.chineseTextBox.Font = new global::System.Drawing.Font("Arial Unicode MS", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chineseTextBox.Location = new global::System.Drawing.Point(88, 26);
			this.chineseTextBox.Name = "chineseTextBox";
			this.chineseTextBox.Size = new global::System.Drawing.Size(451, 33);
			this.chineseTextBox.TabIndex = 4;
			this.chineseTextBox.TextChanged += new global::System.EventHandler(this.ChineseTextBoxTextChanged);
			this.label2.Location = new global::System.Drawing.Point(9, 85);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(73, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Hán Việt:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hanVietRichTextBox.Font = new global::System.Drawing.Font("Arial Unicode MS", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.hanVietRichTextBox.Location = new global::System.Drawing.Point(88, 65);
			this.hanVietRichTextBox.Multiline = true;
			this.hanVietRichTextBox.Name = "hanVietRichTextBox";
			this.hanVietRichTextBox.ReadOnly = true;
			this.hanVietRichTextBox.Size = new global::System.Drawing.Size(451, 58);
			this.hanVietRichTextBox.TabIndex = 5;
			this.vietPhraseLabel.Location = new global::System.Drawing.Point(9, 187);
			this.vietPhraseLabel.Name = "vietPhraseLabel";
			this.vietPhraseLabel.Size = new global::System.Drawing.Size(73, 18);
			this.vietPhraseLabel.TabIndex = 0;
			this.vietPhraseLabel.Text = "VietPhrase:";
			this.vietPhraseLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.vietPhraseRichTextBox.Font = new global::System.Drawing.Font("Arial Unicode MS", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vietPhraseRichTextBox.Location = new global::System.Drawing.Point(88, 127);
			this.vietPhraseRichTextBox.Multiline = true;
			this.vietPhraseRichTextBox.Name = "vietPhraseRichTextBox";
			this.vietPhraseRichTextBox.Size = new global::System.Drawing.Size(451, 132);
			this.vietPhraseRichTextBox.TabIndex = 6;
			this.vietPhraseRichTextBox.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.VietPhraseRichTextBoxKeyDown);
			this.updateButton.Location = new global::System.Drawing.Point(158, 352);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new global::System.Drawing.Size(84, 23);
			this.updateButton.TabIndex = 12;
			this.updateButton.Text = "Update or Add";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new global::System.EventHandler(this.UpdateButtonClick);
			this.cancelButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new global::System.Drawing.Point(450, 352);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new global::System.Drawing.Size(84, 23);
			this.cancelButton.TabIndex = 14;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new global::System.EventHandler(this.CancelButtonClick);
			this.deleteButton.Location = new global::System.Drawing.Point(304, 352);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new global::System.Drawing.Size(84, 23);
			this.deleteButton.TabIndex = 13;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new global::System.EventHandler(this.DeleteButtonClick);
			this.sortingCheckBox.Location = new global::System.Drawing.Point(88, 288);
			this.sortingCheckBox.Name = "sortingCheckBox";
			this.sortingCheckBox.Size = new global::System.Drawing.Size(456, 24);
			this.sortingCheckBox.TabIndex = 7;
			this.sortingCheckBox.Text = "Sắp xếp lại dữ liệu từ điển";
			this.sortingCheckBox.UseVisualStyleBackColor = true;
			this.label3.Location = new global::System.Drawing.Point(9, 2);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(73, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "Entries:";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.entryCountLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.entryCountLabel.Location = new global::System.Drawing.Point(88, 0);
			this.entryCountLabel.Name = "entryCountLabel";
			this.entryCountLabel.Size = new global::System.Drawing.Size(160, 23);
			this.entryCountLabel.TabIndex = 7;
			this.entryCountLabel.Text = "label4";
			this.entryCountLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.updatedByLabel.Font = new global::System.Drawing.Font("Arial Unicode MS", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.updatedByLabel.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.updatedByLabel.Location = new global::System.Drawing.Point(88, 264);
			this.updatedByLabel.Name = "updatedByLabel";
			this.updatedByLabel.Size = new global::System.Drawing.Size(456, 23);
			this.updatedByLabel.TabIndex = 8;
			this.updatedByLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.compressDictionaryHistoryCheckBox.Location = new global::System.Drawing.Point(88, 312);
			this.compressDictionaryHistoryCheckBox.Name = "compressDictionaryHistoryCheckBox";
			this.compressDictionaryHistoryCheckBox.Size = new global::System.Drawing.Size(456, 24);
			this.compressDictionaryHistoryCheckBox.TabIndex = 11;
			this.compressDictionaryHistoryCheckBox.Text = "Nén Dictionary History (với mỗi entry, chỉ giữ lại history của hành động gần nhất)";
			this.compressDictionaryHistoryCheckBox.UseVisualStyleBackColor = true;
			this.groupBox1.Controls.Add(this.capitalize3WordsLinkLabel);
			this.groupBox1.Controls.Add(this.capitalize2WordsLinkLabel);
			this.groupBox1.Controls.Add(this.capitalize1WordLinkLabel);
			this.groupBox1.Controls.Add(this.capitalizeAllLinkLabel);
			this.groupBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox1.Location = new global::System.Drawing.Point(544, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(144, 128);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Edit nhanh";
			this.capitalize3WordsLinkLabel.Location = new global::System.Drawing.Point(8, 74);
			this.capitalize3WordsLinkLabel.Name = "capitalize3WordsLinkLabel";
			this.capitalize3WordsLinkLabel.Size = new global::System.Drawing.Size(128, 16);
			this.capitalize3WordsLinkLabel.TabIndex = 0;
			this.capitalize3WordsLinkLabel.TabStop = true;
			this.capitalize3WordsLinkLabel.Text = "Viết hoa 3 từ đơn đầu";
			this.capitalize3WordsLinkLabel.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Capitalize3WordsLinkLabelLinkClicked);
			this.capitalize2WordsLinkLabel.Location = new global::System.Drawing.Point(8, 45);
			this.capitalize2WordsLinkLabel.Name = "capitalize2WordsLinkLabel";
			this.capitalize2WordsLinkLabel.Size = new global::System.Drawing.Size(128, 16);
			this.capitalize2WordsLinkLabel.TabIndex = 0;
			this.capitalize2WordsLinkLabel.TabStop = true;
			this.capitalize2WordsLinkLabel.Text = "Viết hoa 2 từ đơn đầu";
			this.capitalize2WordsLinkLabel.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Capitalize2WordsLinkLabelLinkClicked);
			this.capitalize1WordLinkLabel.Location = new global::System.Drawing.Point(8, 16);
			this.capitalize1WordLinkLabel.Name = "capitalize1WordLinkLabel";
			this.capitalize1WordLinkLabel.Size = new global::System.Drawing.Size(128, 16);
			this.capitalize1WordLinkLabel.TabIndex = 0;
			this.capitalize1WordLinkLabel.TabStop = true;
			this.capitalize1WordLinkLabel.Text = "Viết hoa 1 từ đơn đầu";
			this.capitalize1WordLinkLabel.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Capitalize1WordLinkLabelLinkClicked);
			this.capitalizeAllLinkLabel.Location = new global::System.Drawing.Point(8, 103);
			this.capitalizeAllLinkLabel.Name = "capitalizeAllLinkLabel";
			this.capitalizeAllLinkLabel.Size = new global::System.Drawing.Size(128, 16);
			this.capitalizeAllLinkLabel.TabIndex = 0;
			this.capitalizeAllLinkLabel.TabStop = true;
			this.capitalizeAllLinkLabel.Text = "Viết hoa tất cả";
			this.capitalizeAllLinkLabel.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CapitalizeAllLinkLabelLinkClicked);
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
			this.backgroundWorker.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
			this.groupBox2.Controls.Add(this.surfBaikeLinkLabel);
			this.groupBox2.Controls.Add(this.existInBaikeLabel);
			this.groupBox2.Location = new global::System.Drawing.Point(544, 59);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(144, 64);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tồn tại trên Baike?";
			this.surfBaikeLinkLabel.Location = new global::System.Drawing.Point(105, 28);
			this.surfBaikeLinkLabel.Name = "surfBaikeLinkLabel";
			this.surfBaikeLinkLabel.Size = new global::System.Drawing.Size(34, 20);
			this.surfBaikeLinkLabel.TabIndex = 17;
			this.surfBaikeLinkLabel.TabStop = true;
			this.surfBaikeLinkLabel.Text = "Xem";
			this.surfBaikeLinkLabel.Visible = false;
			this.surfBaikeLinkLabel.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SurfBaikeLinkLabelLinkClicked);
			this.existInBaikeLabel.Location = new global::System.Drawing.Point(8, 24);
			this.existInBaikeLabel.Name = "existInBaikeLabel";
			this.existInBaikeLabel.Size = new global::System.Drawing.Size(88, 23);
			this.existInBaikeLabel.TabIndex = 0;
			this.existInBaikeLabel.Text = "Đang kiểm tra...";
			this.existInBaikeLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			base.AcceptButton = this.updateButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.cancelButton;
			base.ClientSize = new global::System.Drawing.Size(695, 383);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.compressDictionaryHistoryCheckBox);
			base.Controls.Add(this.updatedByLabel);
			base.Controls.Add(this.entryCountLabel);
			base.Controls.Add(this.sortingCheckBox);
			base.Controls.Add(this.deleteButton);
			base.Controls.Add(this.cancelButton);
			base.Controls.Add(this.updateButton);
			base.Controls.Add(this.vietPhraseRichTextBox);
			base.Controls.Add(this.hanVietRichTextBox);
			base.Controls.Add(this.vietPhraseLabel);
			base.Controls.Add(this.chineseTextBox);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UpdateVietPhraseForm";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update VietPhrase/Name";
			base.Load += new global::System.EventHandler(this.UpdateVietPhraseFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400016F RID: 367
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.LinkLabel surfBaikeLinkLabel;

		// Token: 0x04000171 RID: 369
		private global::System.Windows.Forms.Label existInBaikeLabel;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000173 RID: 371
		private global::System.ComponentModel.BackgroundWorker backgroundWorker;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.LinkLabel capitalizeAllLinkLabel;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.LinkLabel capitalize1WordLinkLabel;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.LinkLabel capitalize2WordsLinkLabel;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.LinkLabel capitalize3WordsLinkLabel;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.CheckBox compressDictionaryHistoryCheckBox;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.Label updatedByLabel;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.Label entryCountLabel;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.CheckBox sortingCheckBox;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.Label vietPhraseLabel;

		// Token: 0x0400017F RID: 383
		private global::System.Windows.Forms.Button updateButton;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.Button deleteButton;

		// Token: 0x04000181 RID: 385
		private global::System.Windows.Forms.Button cancelButton;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Forms.TextBox vietPhraseRichTextBox;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.TextBox hanVietRichTextBox;

		// Token: 0x04000184 RID: 388
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000185 RID: 389
		private global::System.Windows.Forms.TextBox chineseTextBox;

		// Token: 0x04000186 RID: 390
		private global::System.Windows.Forms.Label label1;
	}
}

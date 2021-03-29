namespace QuickTranslator
{
	// Token: 0x02000014 RID: 20
	public partial class PostTTVForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600011F RID: 287 RVA: 0x0001065C File Offset: 0x0000F65C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001067C File Offset: 0x0000F67C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::QuickTranslator.PostTTVForm));
			this.label8 = new global::System.Windows.Forms.Label();
			this.lineOneTextBox = new global::System.Windows.Forms.TextBox();
			this.lineTwoTextBox = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.lineThreeTextBox = new global::System.Windows.Forms.TextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.lineFourTextBox = new global::System.Windows.Forms.TextBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.trungCheckBox = new global::System.Windows.Forms.CheckBox();
			this.hanVietCheckBox = new global::System.Windows.Forms.CheckBox();
			this.vietCheckBox = new global::System.Windows.Forms.CheckBox();
			this.vietPhraseOneMeaningCheckBox = new global::System.Windows.Forms.CheckBox();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.thaoLuanTextBox = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.copyToClipboardButton = new global::System.Windows.Forms.Button();
			this.postContentRichTextBox = new global::System.Windows.Forms.RichTextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			base.SuspendLayout();
			this.label8.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.label8.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(6, 16);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(74, 22);
			this.label8.TabIndex = 21;
			this.label8.Text = "Dòng 1:";
			this.label8.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lineOneTextBox.Location = new global::System.Drawing.Point(86, 18);
			this.lineOneTextBox.Name = "lineOneTextBox";
			this.lineOneTextBox.Size = new global::System.Drawing.Size(434, 20);
			this.lineOneTextBox.TabIndex = 0;
			this.lineOneTextBox.TextChanged += new global::System.EventHandler(this.LineOneTextBoxTextChanged);
			this.lineTwoTextBox.Location = new global::System.Drawing.Point(86, 44);
			this.lineTwoTextBox.Name = "lineTwoTextBox";
			this.lineTwoTextBox.Size = new global::System.Drawing.Size(434, 20);
			this.lineTwoTextBox.TabIndex = 1;
			this.lineTwoTextBox.TextChanged += new global::System.EventHandler(this.LineOneTextBoxTextChanged);
			this.label9.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.label9.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.Location = new global::System.Drawing.Point(6, 42);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(74, 22);
			this.label9.TabIndex = 23;
			this.label9.Text = "Dòng 2:";
			this.label9.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lineThreeTextBox.Location = new global::System.Drawing.Point(86, 70);
			this.lineThreeTextBox.Name = "lineThreeTextBox";
			this.lineThreeTextBox.Size = new global::System.Drawing.Size(434, 20);
			this.lineThreeTextBox.TabIndex = 2;
			this.lineThreeTextBox.TextChanged += new global::System.EventHandler(this.LineOneTextBoxTextChanged);
			this.label10.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.label10.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.Location = new global::System.Drawing.Point(6, 68);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(74, 22);
			this.label10.TabIndex = 25;
			this.label10.Text = "Dòng 3:";
			this.label10.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lineFourTextBox.Location = new global::System.Drawing.Point(86, 96);
			this.lineFourTextBox.Name = "lineFourTextBox";
			this.lineFourTextBox.Size = new global::System.Drawing.Size(434, 20);
			this.lineFourTextBox.TabIndex = 3;
			this.lineFourTextBox.TextChanged += new global::System.EventHandler(this.LineOneTextBoxTextChanged);
			this.label11.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.label11.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(6, 94);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(74, 22);
			this.label11.TabIndex = 27;
			this.label11.Text = "Dòng 4:";
			this.label11.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.groupBox2.Controls.Add(this.trungCheckBox);
			this.groupBox2.Controls.Add(this.hanVietCheckBox);
			this.groupBox2.Controls.Add(this.vietCheckBox);
			this.groupBox2.Controls.Add(this.vietPhraseOneMeaningCheckBox);
			this.groupBox2.Location = new global::System.Drawing.Point(10, 156);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(594, 59);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Nội Dung (Spoiler)";
			this.trungCheckBox.Checked = true;
			this.trungCheckBox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.trungCheckBox.Location = new global::System.Drawing.Point(456, 19);
			this.trungCheckBox.Name = "trungCheckBox";
			this.trungCheckBox.Size = new global::System.Drawing.Size(123, 24);
			this.trungCheckBox.TabIndex = 2;
			this.trungCheckBox.Text = "Tiếng Trung";
			this.trungCheckBox.UseVisualStyleBackColor = true;
			this.trungCheckBox.CheckedChanged += new global::System.EventHandler(this.LineOneTextBoxTextChanged);
			this.hanVietCheckBox.Checked = true;
			this.hanVietCheckBox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.hanVietCheckBox.Location = new global::System.Drawing.Point(315, 19);
			this.hanVietCheckBox.Name = "hanVietCheckBox";
			this.hanVietCheckBox.Size = new global::System.Drawing.Size(123, 24);
			this.hanVietCheckBox.TabIndex = 1;
			this.hanVietCheckBox.Text = "Hán Việt";
			this.hanVietCheckBox.UseVisualStyleBackColor = true;
			this.hanVietCheckBox.CheckedChanged += new global::System.EventHandler(this.LineOneTextBoxTextChanged);
			this.vietCheckBox.Location = new global::System.Drawing.Point(6, 19);
			this.vietCheckBox.Name = "vietCheckBox";
			this.vietCheckBox.Size = new global::System.Drawing.Size(123, 24);
			this.vietCheckBox.TabIndex = 0;
			this.vietCheckBox.Text = "Việt";
			this.vietCheckBox.UseVisualStyleBackColor = true;
			this.vietCheckBox.CheckedChanged += new global::System.EventHandler(this.LineOneTextBoxTextChanged);
			this.vietPhraseOneMeaningCheckBox.Checked = true;
			this.vietPhraseOneMeaningCheckBox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.vietPhraseOneMeaningCheckBox.Location = new global::System.Drawing.Point(146, 19);
			this.vietPhraseOneMeaningCheckBox.Name = "vietPhraseOneMeaningCheckBox";
			this.vietPhraseOneMeaningCheckBox.Size = new global::System.Drawing.Size(149, 24);
			this.vietPhraseOneMeaningCheckBox.TabIndex = 0;
			this.vietPhraseOneMeaningCheckBox.Text = "VietPhrase một nghĩa";
			this.vietPhraseOneMeaningCheckBox.UseVisualStyleBackColor = true;
			this.vietPhraseOneMeaningCheckBox.CheckedChanged += new global::System.EventHandler(this.LineOneTextBoxTextChanged);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.lineOneTextBox);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.lineTwoTextBox);
			this.groupBox4.Controls.Add(this.lineFourTextBox);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.lineThreeTextBox);
			this.groupBox4.Location = new global::System.Drawing.Point(10, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(594, 127);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Tiêu Đề";
			this.label6.Location = new global::System.Drawing.Point(526, 96);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(62, 20);
			this.label6.TabIndex = 28;
			this.label6.Text = "(Converter)";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Location = new global::System.Drawing.Point(526, 70);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(62, 20);
			this.label5.TabIndex = 28;
			this.label5.Text = "(Tác giả)";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Location = new global::System.Drawing.Point(526, 44);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(62, 20);
			this.label4.TabIndex = 28;
			this.label4.Text = "(Chương)";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new global::System.Drawing.Point(526, 17);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(62, 20);
			this.label3.TabIndex = 28;
			this.label3.Text = "(Quyển)";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupBox5.Controls.Add(this.thaoLuanTextBox);
			this.groupBox5.Controls.Add(this.label1);
			this.groupBox5.Location = new global::System.Drawing.Point(10, 234);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(594, 70);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Link đến Thảo Luận";
			this.thaoLuanTextBox.Location = new global::System.Drawing.Point(6, 19);
			this.thaoLuanTextBox.Name = "thaoLuanTextBox";
			this.thaoLuanTextBox.Size = new global::System.Drawing.Size(573, 20);
			this.thaoLuanTextBox.TabIndex = 4;
			this.thaoLuanTextBox.TextChanged += new global::System.EventHandler(this.LineOneTextBoxTextChanged);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new global::System.Drawing.Point(6, 45);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(573, 22);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ví dụ: Mãng Hoang Kỷ là http://www.tangthuvien.com/forum/showthread.php?t=95472";
			this.copyToClipboardButton.Location = new global::System.Drawing.Point(220, 563);
			this.copyToClipboardButton.Name = "copyToClipboardButton";
			this.copyToClipboardButton.Size = new global::System.Drawing.Size(179, 34);
			this.copyToClipboardButton.TabIndex = 5;
			this.copyToClipboardButton.Text = "&Chép vào Clipboard và Đóng";
			this.copyToClipboardButton.UseVisualStyleBackColor = true;
			this.copyToClipboardButton.Click += new global::System.EventHandler(this.CopyToClipboardButtonClick);
			this.postContentRichTextBox.Location = new global::System.Drawing.Point(10, 348);
			this.postContentRichTextBox.Name = "postContentRichTextBox";
			this.postContentRichTextBox.ReadOnly = true;
			this.postContentRichTextBox.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.postContentRichTextBox.Size = new global::System.Drawing.Size(594, 200);
			this.postContentRichTextBox.TabIndex = 7;
			this.postContentRichTextBox.Text = "";
			this.label2.Location = new global::System.Drawing.Point(10, 322);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(594, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(616, 609);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.postContentRichTextBox);
			base.Controls.Add(this.copyToClipboardButton);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox5);
			base.Controls.Add(this.groupBox2);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PostTTVForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Post to TangThuVien.com";
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400013B RID: 315
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400013E RID: 318
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.RichTextBox postContentRichTextBox;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.TextBox thaoLuanTextBox;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.CheckBox vietCheckBox;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.Button copyToClipboardButton;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.CheckBox vietPhraseOneMeaningCheckBox;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.CheckBox hanVietCheckBox;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.CheckBox trungCheckBox;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.TextBox lineFourTextBox;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400014E RID: 334
		private global::System.Windows.Forms.TextBox lineThreeTextBox;

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.TextBox lineTwoTextBox;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.TextBox lineOneTextBox;

		// Token: 0x04000152 RID: 338
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.Label label1;
	}
}

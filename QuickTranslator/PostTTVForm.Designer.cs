namespace QuickTranslator
{
    public partial class PostTTVForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostTTVForm));
            this.label8 = new System.Windows.Forms.Label();
            this.lineOneTextBox = new System.Windows.Forms.TextBox();
            this.lineTwoTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lineThreeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lineFourTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trungCheckBox = new System.Windows.Forms.CheckBox();
            this.hanVietCheckBox = new System.Windows.Forms.CheckBox();
            this.vietCheckBox = new System.Windows.Forms.CheckBox();
            this.vietPhraseOneMeaningCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.thaoLuanTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.postContentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 27);
            this.label8.TabIndex = 21;
            this.label8.Text = "Dòng 1:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lineOneTextBox
            // 
            this.lineOneTextBox.Location = new System.Drawing.Point(115, 22);
            this.lineOneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineOneTextBox.Name = "lineOneTextBox";
            this.lineOneTextBox.Size = new System.Drawing.Size(577, 22);
            this.lineOneTextBox.TabIndex = 0;
            this.lineOneTextBox.TextChanged += new System.EventHandler(this.LineOneTextBoxTextChanged);
            // 
            // lineTwoTextBox
            // 
            this.lineTwoTextBox.Location = new System.Drawing.Point(115, 54);
            this.lineTwoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineTwoTextBox.Name = "lineTwoTextBox";
            this.lineTwoTextBox.Size = new System.Drawing.Size(577, 22);
            this.lineTwoTextBox.TabIndex = 1;
            this.lineTwoTextBox.TextChanged += new System.EventHandler(this.LineOneTextBoxTextChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 27);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dòng 2:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lineThreeTextBox
            // 
            this.lineThreeTextBox.Location = new System.Drawing.Point(115, 86);
            this.lineThreeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineThreeTextBox.Name = "lineThreeTextBox";
            this.lineThreeTextBox.Size = new System.Drawing.Size(577, 22);
            this.lineThreeTextBox.TabIndex = 2;
            this.lineThreeTextBox.TextChanged += new System.EventHandler(this.LineOneTextBoxTextChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "Dòng 3:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lineFourTextBox
            // 
            this.lineFourTextBox.Location = new System.Drawing.Point(115, 118);
            this.lineFourTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineFourTextBox.Name = "lineFourTextBox";
            this.lineFourTextBox.Size = new System.Drawing.Size(577, 22);
            this.lineFourTextBox.TabIndex = 3;
            this.lineFourTextBox.TextChanged += new System.EventHandler(this.LineOneTextBoxTextChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 27);
            this.label11.TabIndex = 27;
            this.label11.Text = "Dòng 4:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trungCheckBox);
            this.groupBox2.Controls.Add(this.hanVietCheckBox);
            this.groupBox2.Controls.Add(this.vietCheckBox);
            this.groupBox2.Controls.Add(this.vietPhraseOneMeaningCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 192);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(792, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nội Dung (Spoiler)";
            // 
            // trungCheckBox
            // 
            this.trungCheckBox.Checked = true;
            this.trungCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trungCheckBox.Location = new System.Drawing.Point(608, 23);
            this.trungCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trungCheckBox.Name = "trungCheckBox";
            this.trungCheckBox.Size = new System.Drawing.Size(164, 30);
            this.trungCheckBox.TabIndex = 2;
            this.trungCheckBox.Text = "Tiếng Trung";
            this.trungCheckBox.UseVisualStyleBackColor = true;
            this.trungCheckBox.CheckedChanged += new System.EventHandler(this.LineOneTextBoxTextChanged);
            // 
            // hanVietCheckBox
            // 
            this.hanVietCheckBox.Checked = true;
            this.hanVietCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hanVietCheckBox.Location = new System.Drawing.Point(420, 23);
            this.hanVietCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hanVietCheckBox.Name = "hanVietCheckBox";
            this.hanVietCheckBox.Size = new System.Drawing.Size(164, 30);
            this.hanVietCheckBox.TabIndex = 1;
            this.hanVietCheckBox.Text = "Hán Việt";
            this.hanVietCheckBox.UseVisualStyleBackColor = true;
            this.hanVietCheckBox.CheckedChanged += new System.EventHandler(this.LineOneTextBoxTextChanged);
            // 
            // vietCheckBox
            // 
            this.vietCheckBox.Location = new System.Drawing.Point(8, 23);
            this.vietCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vietCheckBox.Name = "vietCheckBox";
            this.vietCheckBox.Size = new System.Drawing.Size(164, 30);
            this.vietCheckBox.TabIndex = 0;
            this.vietCheckBox.Text = "Việt";
            this.vietCheckBox.UseVisualStyleBackColor = true;
            this.vietCheckBox.CheckedChanged += new System.EventHandler(this.LineOneTextBoxTextChanged);
            // 
            // vietPhraseOneMeaningCheckBox
            // 
            this.vietPhraseOneMeaningCheckBox.Checked = true;
            this.vietPhraseOneMeaningCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vietPhraseOneMeaningCheckBox.Location = new System.Drawing.Point(195, 23);
            this.vietPhraseOneMeaningCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vietPhraseOneMeaningCheckBox.Name = "vietPhraseOneMeaningCheckBox";
            this.vietPhraseOneMeaningCheckBox.Size = new System.Drawing.Size(199, 30);
            this.vietPhraseOneMeaningCheckBox.TabIndex = 0;
            this.vietPhraseOneMeaningCheckBox.Text = "VietPhrase một nghĩa";
            this.vietPhraseOneMeaningCheckBox.UseVisualStyleBackColor = true;
            this.vietPhraseOneMeaningCheckBox.CheckedChanged += new System.EventHandler(this.LineOneTextBoxTextChanged);
            // 
            // groupBox4
            // 
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
            this.groupBox4.Location = new System.Drawing.Point(13, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(792, 156);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiêu Đề";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(701, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "(Converter)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(701, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "(Tác giả)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(701, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "(Chương)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(701, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "(Quyển)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.thaoLuanTextBox);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(13, 288);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(792, 86);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Link đến Thảo Luận";
            // 
            // thaoLuanTextBox
            // 
            this.thaoLuanTextBox.Location = new System.Drawing.Point(8, 23);
            this.thaoLuanTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thaoLuanTextBox.Name = "thaoLuanTextBox";
            this.thaoLuanTextBox.Size = new System.Drawing.Size(763, 22);
            this.thaoLuanTextBox.TabIndex = 4;
            this.thaoLuanTextBox.TextChanged += new System.EventHandler(this.LineOneTextBoxTextChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(764, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ví dụ: Mãng Hoang Kỷ là http://www.tangthuvien.com/forum/showthread.php?t=95472";
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Location = new System.Drawing.Point(293, 693);
            this.copyToClipboardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(239, 42);
            this.copyToClipboardButton.TabIndex = 5;
            this.copyToClipboardButton.Text = "&Chép vào Clipboard và Đóng";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButtonClick);
            // 
            // postContentRichTextBox
            // 
            this.postContentRichTextBox.Location = new System.Drawing.Point(13, 428);
            this.postContentRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postContentRichTextBox.Name = "postContentRichTextBox";
            this.postContentRichTextBox.ReadOnly = true;
            this.postContentRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.postContentRichTextBox.Size = new System.Drawing.Size(791, 245);
            this.postContentRichTextBox.TabIndex = 7;
            this.postContentRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 396);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(792, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "/////////////////////////////////////////////////////////////////////////////////" +
    "////////////////////////////////////";
            // 
            // PostTTVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.postContentRichTextBox);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostTTVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Post to TangThuVien.com";
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.ComponentModel.IContainer components;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.RichTextBox postContentRichTextBox;

        private System.Windows.Forms.TextBox thaoLuanTextBox;

        private System.Windows.Forms.CheckBox vietCheckBox;

        private System.Windows.Forms.Button copyToClipboardButton;

        private System.Windows.Forms.GroupBox groupBox5;

        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.CheckBox vietPhraseOneMeaningCheckBox;

        private System.Windows.Forms.CheckBox hanVietCheckBox;

        private System.Windows.Forms.CheckBox trungCheckBox;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.TextBox lineFourTextBox;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.TextBox lineThreeTextBox;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox lineTwoTextBox;

        private System.Windows.Forms.TextBox lineOneTextBox;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label1;
    }
}

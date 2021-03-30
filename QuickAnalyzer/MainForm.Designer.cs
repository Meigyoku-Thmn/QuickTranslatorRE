namespace QuickAnalyzer
{
    // Token: 0x02000002 RID: 2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRunOrCancel = new System.Windows.Forms.Button();
            this.btnSelectOutputDirPath = new System.Windows.Forms.Button();
            this.btnSelectInputDirPath = new System.Windows.Forms.Button();
            this.txtOutputDirPath = new System.Windows.Forms.TextBox();
            this.txtInputDirPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMinCharCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxCharCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minOccurancesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.notInVietPhraseAndNameCheckBox = new System.Windows.Forms.CheckBox();
            this.cboTranslationAlgorithm = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkNamePrioritized = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMinCharCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCharCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minOccurancesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunOrCancel
            // 
            this.btnRunOrCancel.Location = new System.Drawing.Point(363, 226);
            this.btnRunOrCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRunOrCancel.Name = "btnRunOrCancel";
            this.btnRunOrCancel.Size = new System.Drawing.Size(181, 28);
            this.btnRunOrCancel.TabIndex = 22;
            this.btnRunOrCancel.Text = "Run";
            this.btnRunOrCancel.UseVisualStyleBackColor = true;
            this.btnRunOrCancel.Click += new System.EventHandler(this.RunCancelButtonClick);
            // 
            // btnSelectOutputDirPath
            // 
            this.btnSelectOutputDirPath.Location = new System.Drawing.Point(795, 39);
            this.btnSelectOutputDirPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectOutputDirPath.Name = "btnSelectOutputDirPath";
            this.btnSelectOutputDirPath.Size = new System.Drawing.Size(100, 27);
            this.btnSelectOutputDirPath.TabIndex = 21;
            this.btnSelectOutputDirPath.Text = "Browse...";
            this.btnSelectOutputDirPath.UseVisualStyleBackColor = true;
            this.btnSelectOutputDirPath.Click += new System.EventHandler(this.BrowseTargetFolderButtonClick);
            // 
            // btnSelectInputDirPath
            // 
            this.btnSelectInputDirPath.Location = new System.Drawing.Point(795, 10);
            this.btnSelectInputDirPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectInputDirPath.Name = "btnSelectInputDirPath";
            this.btnSelectInputDirPath.Size = new System.Drawing.Size(100, 27);
            this.btnSelectInputDirPath.TabIndex = 19;
            this.btnSelectInputDirPath.Text = "Browse...";
            this.btnSelectInputDirPath.UseVisualStyleBackColor = true;
            this.btnSelectInputDirPath.Click += new System.EventHandler(this.BrowseSourceFolderButtonClick);
            // 
            // txtOutputDirPath
            // 
            this.txtOutputDirPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOutputDirPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtOutputDirPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputDirPath.Location = new System.Drawing.Point(197, 41);
            this.txtOutputDirPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutputDirPath.Name = "txtOutputDirPath";
            this.txtOutputDirPath.Size = new System.Drawing.Size(591, 23);
            this.txtOutputDirPath.TabIndex = 20;
            // 
            // txtInputDirPath
            // 
            this.txtInputDirPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInputDirPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtInputDirPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputDirPath.Location = new System.Drawing.Point(197, 11);
            this.txtInputDirPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputDirPath.Name = "txtInputDirPath";
            this.txtInputDirPath.Size = new System.Drawing.Size(591, 23);
            this.txtInputDirPath.TabIndex = 18;
            this.txtInputDirPath.TextChanged += new System.EventHandler(this.SourceFolderTextBoxTextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thư mục đích:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thư mục nguồn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phân tích những cụm từ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numMinCharCount
            // 
            this.numMinCharCount.Location = new System.Drawing.Point(197, 79);
            this.numMinCharCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMinCharCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMinCharCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMinCharCount.Name = "numMinCharCount";
            this.numMinCharCount.Size = new System.Drawing.Size(53, 22);
            this.numMinCharCount.TabIndex = 23;
            this.numMinCharCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMinCharCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "đến:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numMaxCharCount
            // 
            this.numMaxCharCount.Location = new System.Drawing.Point(309, 79);
            this.numMaxCharCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMaxCharCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMaxCharCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMaxCharCount.Name = "numMaxCharCount";
            this.numMaxCharCount.Size = new System.Drawing.Size(53, 22);
            this.numMaxCharCount.TabIndex = 23;
            this.numMaxCharCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaxCharCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "chữ.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số lần lặp tối thiểu:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minOccurancesNumericUpDown
            // 
            this.minOccurancesNumericUpDown.Location = new System.Drawing.Point(197, 108);
            this.minOccurancesNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minOccurancesNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.minOccurancesNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.minOccurancesNumericUpDown.Name = "minOccurancesNumericUpDown";
            this.minOccurancesNumericUpDown.Size = new System.Drawing.Size(85, 22);
            this.minOccurancesNumericUpDown.TabIndex = 23;
            this.minOccurancesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minOccurancesNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // notInVietPhraseAndNameCheckBox
            // 
            this.notInVietPhraseAndNameCheckBox.Checked = true;
            this.notInVietPhraseAndNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notInVietPhraseAndNameCheckBox.Enabled = false;
            this.notInVietPhraseAndNameCheckBox.Location = new System.Drawing.Point(197, 167);
            this.notInVietPhraseAndNameCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notInVietPhraseAndNameCheckBox.Name = "notInVietPhraseAndNameCheckBox";
            this.notInVietPhraseAndNameCheckBox.Size = new System.Drawing.Size(373, 30);
            this.notInVietPhraseAndNameCheckBox.TabIndex = 24;
            this.notInVietPhraseAndNameCheckBox.Text = "Chỉ lấy những cụm chưa có trong VietPhrase/Names";
            this.notInVietPhraseAndNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // cboTranslationAlgorithm
            // 
            this.cboTranslationAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTranslationAlgorithm.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTranslationAlgorithm.FormattingEnabled = true;
            this.cboTranslationAlgorithm.Items.AddRange(new object[] {
            "Ưu tiên cụm VietPhrase dài",
            "Từ trái sang phải",
            "Ưu tiên cụm VietPhrase dài (>= 4 từ)"});
            this.cboTranslationAlgorithm.Location = new System.Drawing.Point(197, 138);
            this.cboTranslationAlgorithm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTranslationAlgorithm.Name = "cboTranslationAlgorithm";
            this.cboTranslationAlgorithm.Size = new System.Drawing.Size(271, 24);
            this.cboTranslationAlgorithm.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 138);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 27);
            this.label13.TabIndex = 25;
            this.label13.Text = "Thuật toán dịch:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkNamePrioritized
            // 
            this.chkNamePrioritized.Checked = true;
            this.chkNamePrioritized.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNamePrioritized.Location = new System.Drawing.Point(491, 138);
            this.chkNamePrioritized.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNamePrioritized.Name = "chkNamePrioritized";
            this.chkNamePrioritized.Size = new System.Drawing.Size(229, 30);
            this.chkNamePrioritized.TabIndex = 27;
            this.chkNamePrioritized.Text = "Ưu tiên Name hơn VietPhrase";
            this.chkNamePrioritized.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 268);
            this.Controls.Add(this.chkNamePrioritized);
            this.Controls.Add(this.cboTranslationAlgorithm);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notInVietPhraseAndNameCheckBox);
            this.Controls.Add(this.btnRunOrCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minOccurancesNumericUpDown);
            this.Controls.Add(this.btnSelectOutputDirPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelectInputDirPath);
            this.Controls.Add(this.numMaxCharCount);
            this.Controls.Add(this.txtOutputDirPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInputDirPath);
            this.Controls.Add(this.numMinCharCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Quick Analyzer";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.numMinCharCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCharCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minOccurancesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox chkNamePrioritized;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.ComboBox cboTranslationAlgorithm;

        private System.Windows.Forms.NumericUpDown minOccurancesNumericUpDown;

        private System.Windows.Forms.CheckBox notInVietPhraseAndNameCheckBox;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.NumericUpDown numMaxCharCount;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.NumericUpDown numMinCharCount;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtInputDirPath;

        private System.Windows.Forms.TextBox txtOutputDirPath;

        private System.Windows.Forms.Button btnSelectInputDirPath;

        private System.Windows.Forms.Button btnSelectOutputDirPath;

        private System.Windows.Forms.Button btnRunOrCancel;
    }
}

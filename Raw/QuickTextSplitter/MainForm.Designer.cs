
namespace QuickTextSplitter
{
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectInputFilePath = new System.Windows.Forms.Button();
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectOutputDirPath = new System.Windows.Forms.Button();
            this.txtOutputDirPath = new System.Windows.Forms.TextBox();
            this.numChunks = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.radSplitIntoChunks = new System.Windows.Forms.RadioButton();
            this.radSplitIntoChapters = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkUseRegex = new System.Windows.Forms.CheckBox();
            this.txtSeparatorToken = new System.Windows.Forms.TextBox();
            this.radSplitBySeparatorToken = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numChunks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "File nguồn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectInputFilePath
            // 
            this.btnSelectInputFilePath.Location = new System.Drawing.Point(809, 9);
            this.btnSelectInputFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectInputFilePath.Name = "btnSelectInputFilePath";
            this.btnSelectInputFilePath.Size = new System.Drawing.Size(100, 27);
            this.btnSelectInputFilePath.TabIndex = 1;
            this.btnSelectInputFilePath.Text = "Browse...";
            this.btnSelectInputFilePath.UseVisualStyleBackColor = true;
            this.btnSelectInputFilePath.Click += new System.EventHandler(this.SelectInputFilePathButton_Clicked);
            // 
            // txtInputFilePath
            // 
            this.txtInputFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInputFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtInputFilePath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFilePath.Location = new System.Drawing.Point(181, 10);
            this.txtInputFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.Size = new System.Drawing.Size(623, 23);
            this.txtInputFilePath.TabIndex = 0;
            this.txtInputFilePath.TextChanged += new System.EventHandler(this.SelectInputFilePathButton_Changed);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Thư mục chứa kết quả:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectOutputDirPath
            // 
            this.btnSelectOutputDirPath.Location = new System.Drawing.Point(809, 48);
            this.btnSelectOutputDirPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOutputDirPath.Name = "btnSelectOutputDirPath";
            this.btnSelectOutputDirPath.Size = new System.Drawing.Size(100, 27);
            this.btnSelectOutputDirPath.TabIndex = 3;
            this.btnSelectOutputDirPath.Text = "Browse...";
            this.btnSelectOutputDirPath.UseVisualStyleBackColor = true;
            this.btnSelectOutputDirPath.Click += new System.EventHandler(this.SelectOutputDirPathButton_Clicked);
            // 
            // txtOutputDirPath
            // 
            this.txtOutputDirPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOutputDirPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtOutputDirPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputDirPath.Location = new System.Drawing.Point(181, 49);
            this.txtOutputDirPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputDirPath.Name = "txtOutputDirPath";
            this.txtOutputDirPath.Size = new System.Drawing.Size(623, 23);
            this.txtOutputDirPath.TabIndex = 2;
            // 
            // numChunks
            // 
            this.numChunks.Enabled = false;
            this.numChunks.Location = new System.Drawing.Point(247, 65);
            this.numChunks.Margin = new System.Windows.Forms.Padding(4);
            this.numChunks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numChunks.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numChunks.Name = "numChunks";
            this.numChunks.Size = new System.Drawing.Size(125, 22);
            this.numChunks.TabIndex = 2;
            this.numChunks.ThousandsSeparator = true;
            this.numChunks.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(375, 303);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(149, 28);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.RunButton_Clicked);
            // 
            // radSplitIntoChunks
            // 
            this.radSplitIntoChunks.Location = new System.Drawing.Point(8, 60);
            this.radSplitIntoChunks.Margin = new System.Windows.Forms.Padding(4);
            this.radSplitIntoChunks.Name = "radSplitIntoChunks";
            this.radSplitIntoChunks.Size = new System.Drawing.Size(608, 30);
            this.radSplitIntoChunks.TabIndex = 1;
            this.radSplitIntoChunks.Text = "Thành từng phần với số lượng là";
            this.radSplitIntoChunks.UseVisualStyleBackColor = true;
            this.radSplitIntoChunks.CheckedChanged += new System.EventHandler(this.CacPhanDeuNhauRadioButton_CheckedChanged);
            // 
            // radSplitIntoChapters
            // 
            this.radSplitIntoChapters.Checked = true;
            this.radSplitIntoChapters.Location = new System.Drawing.Point(8, 23);
            this.radSplitIntoChapters.Margin = new System.Windows.Forms.Padding(4);
            this.radSplitIntoChapters.Name = "radSplitIntoChapters";
            this.radSplitIntoChapters.Size = new System.Drawing.Size(608, 30);
            this.radSplitIntoChapters.TabIndex = 0;
            this.radSplitIntoChapters.TabStop = true;
            this.radSplitIntoChapters.Text = "Thành từng chương";
            this.radSplitIntoChapters.UseVisualStyleBackColor = true;
            this.radSplitIntoChapters.CheckedChanged += new System.EventHandler(this.EachChapterRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numChunks);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkUseRegex);
            this.groupBox1.Controls.Add(this.txtSeparatorToken);
            this.groupBox1.Controls.Add(this.radSplitBySeparatorToken);
            this.groupBox1.Controls.Add(this.radSplitIntoChapters);
            this.groupBox1.Controls.Add(this.radSplitIntoChunks);
            this.groupBox1.Location = new System.Drawing.Point(181, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(624, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cắt ra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "phần";
            // 
            // chkUseRegex
            // 
            this.chkUseRegex.Enabled = false;
            this.chkUseRegex.Location = new System.Drawing.Point(265, 131);
            this.chkUseRegex.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseRegex.Name = "chkUseRegex";
            this.chkUseRegex.Size = new System.Drawing.Size(351, 27);
            this.chkUseRegex.TabIndex = 5;
            this.chkUseRegex.Text = "Regular Expression";
            this.chkUseRegex.UseVisualStyleBackColor = true;
            // 
            // txtSeparatorToken
            // 
            this.txtSeparatorToken.Enabled = false;
            this.txtSeparatorToken.Location = new System.Drawing.Point(247, 101);
            this.txtSeparatorToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparatorToken.Name = "txtSeparatorToken";
            this.txtSeparatorToken.Size = new System.Drawing.Size(369, 22);
            this.txtSeparatorToken.TabIndex = 4;
            this.txtSeparatorToken.Text = "www.zongheng.com";
            // 
            // radSplitBySeparatorToken
            // 
            this.radSplitBySeparatorToken.Location = new System.Drawing.Point(8, 97);
            this.radSplitBySeparatorToken.Margin = new System.Windows.Forms.Padding(4);
            this.radSplitBySeparatorToken.Name = "radSplitBySeparatorToken";
            this.radSplitBySeparatorToken.Size = new System.Drawing.Size(231, 30);
            this.radSplitBySeparatorToken.TabIndex = 3;
            this.radSplitBySeparatorToken.Text = "Dựa theo mô thức phân cách là";
            this.radSplitBySeparatorToken.UseVisualStyleBackColor = true;
            this.radSplitBySeparatorToken.CheckedChanged += new System.EventHandler(this.SeparatorLineRadioButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSelectOutputDirPath);
            this.Controls.Add(this.txtOutputDirPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectInputFilePath);
            this.Controls.Add(this.txtInputFilePath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Quick Text Splitter";
            ((System.ComponentModel.ISupportInitialize)(this.numChunks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox chkUseRegex;

        private System.Windows.Forms.RadioButton radSplitBySeparatorToken;

        private System.Windows.Forms.TextBox txtSeparatorToken;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.RadioButton radSplitIntoChapters;

        private System.Windows.Forms.RadioButton radSplitIntoChunks;

        private System.Windows.Forms.Button btnRun;

        private System.Windows.Forms.NumericUpDown numChunks;

        private System.Windows.Forms.TextBox txtOutputDirPath;

        private System.Windows.Forms.Button btnSelectOutputDirPath;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtInputFilePath;

        private System.Windows.Forms.Button btnSelectInputFilePath;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

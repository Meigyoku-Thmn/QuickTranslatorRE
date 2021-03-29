namespace QuickVietPhraseMerger
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
            this.btnSelectVietPhrase2FilePath = new System.Windows.Forms.Button();
            this.btnSelectVietPhrase1FilePath = new System.Windows.Forms.Button();
            this.txtVietPhrase2FilePath = new System.Windows.Forms.TextBox();
            this.txtVietPhrase1FilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputDirPath = new System.Windows.Forms.TextBox();
            this.btnSelectOutputDirPath = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVietPhrase1LogPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVietPhrase2LogPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEntryAuthor = new System.Windows.Forms.TextBox();
            this.chkOnlyMergeCreatedByAuthor = new System.Windows.Forms.CheckBox();
            this.chkOnlyMergeLastest = new System.Windows.Forms.CheckBox();
            this.chkDontMergeDeletedFromVietPhrase1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectVietPhrase2FilePath
            // 
            this.btnSelectVietPhrase2FilePath.Location = new System.Drawing.Point(825, 79);
            this.btnSelectVietPhrase2FilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectVietPhrase2FilePath.Name = "btnSelectVietPhrase2FilePath";
            this.btnSelectVietPhrase2FilePath.Size = new System.Drawing.Size(100, 27);
            this.btnSelectVietPhrase2FilePath.TabIndex = 4;
            this.btnSelectVietPhrase2FilePath.Text = "Browse...";
            this.btnSelectVietPhrase2FilePath.UseVisualStyleBackColor = true;
            this.btnSelectVietPhrase2FilePath.Click += new System.EventHandler(this.SelectVietPhrase2FilePathButton_Clicked);
            // 
            // btnSelectVietPhrase1FilePath
            // 
            this.btnSelectVietPhrase1FilePath.Location = new System.Drawing.Point(825, 10);
            this.btnSelectVietPhrase1FilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectVietPhrase1FilePath.Name = "btnSelectVietPhrase1FilePath";
            this.btnSelectVietPhrase1FilePath.Size = new System.Drawing.Size(100, 27);
            this.btnSelectVietPhrase1FilePath.TabIndex = 2;
            this.btnSelectVietPhrase1FilePath.Text = "Browse...";
            this.btnSelectVietPhrase1FilePath.UseVisualStyleBackColor = true;
            this.btnSelectVietPhrase1FilePath.Click += new System.EventHandler(this.SelectVietPhrase1FilePathButton_Clicked);
            // 
            // txtVietPhrase2FilePath
            // 
            this.txtVietPhrase2FilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVietPhrase2FilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtVietPhrase2FilePath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVietPhrase2FilePath.Location = new System.Drawing.Point(197, 80);
            this.txtVietPhrase2FilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtVietPhrase2FilePath.Name = "txtVietPhrase2FilePath";
            this.txtVietPhrase2FilePath.Size = new System.Drawing.Size(623, 23);
            this.txtVietPhrase2FilePath.TabIndex = 3;
            this.txtVietPhrase2FilePath.TextChanged += new System.EventHandler(this.VietPhrase2TextBox_TextChanged);
            // 
            // txtVietPhrase1FilePath
            // 
            this.txtVietPhrase1FilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVietPhrase1FilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtVietPhrase1FilePath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVietPhrase1FilePath.Location = new System.Drawing.Point(197, 11);
            this.txtVietPhrase1FilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtVietPhrase1FilePath.Name = "txtVietPhrase1FilePath";
            this.txtVietPhrase1FilePath.Size = new System.Drawing.Size(623, 23);
            this.txtVietPhrase1FilePath.TabIndex = 1;
            this.txtVietPhrase1FilePath.TextChanged += new System.EventHandler(this.VietPhrase1TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "VietPhrase 2:";
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
            this.label1.TabIndex = 6;
            this.label1.Text = "VietPhrase 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thư mục chứa file kết quả:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutputDirPath
            // 
            this.txtOutputDirPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOutputDirPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtOutputDirPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputDirPath.Location = new System.Drawing.Point(197, 148);
            this.txtOutputDirPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputDirPath.Name = "txtOutputDirPath";
            this.txtOutputDirPath.Size = new System.Drawing.Size(623, 23);
            this.txtOutputDirPath.TabIndex = 5;
            // 
            // btnSelectOutputDirPath
            // 
            this.btnSelectOutputDirPath.Location = new System.Drawing.Point(825, 146);
            this.btnSelectOutputDirPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOutputDirPath.Name = "btnSelectOutputDirPath";
            this.btnSelectOutputDirPath.Size = new System.Drawing.Size(100, 27);
            this.btnSelectOutputDirPath.TabIndex = 6;
            this.btnSelectOutputDirPath.Text = "Browse...";
            this.btnSelectOutputDirPath.UseVisualStyleBackColor = true;
            this.btnSelectOutputDirPath.Click += new System.EventHandler(this.SelectOutputDirPathButton_Clicked);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(395, 404);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(149, 28);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(11, 315);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(917, 69);
            this.textBox1.TabIndex = 13;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "VietPhrase 1 (History):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVietPhrase1LogPath
            // 
            this.txtVietPhrase1LogPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVietPhrase1LogPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtVietPhrase1LogPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVietPhrase1LogPath.Location = new System.Drawing.Point(197, 41);
            this.txtVietPhrase1LogPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtVietPhrase1LogPath.Name = "txtVietPhrase1LogPath";
            this.txtVietPhrase1LogPath.ReadOnly = true;
            this.txtVietPhrase1LogPath.Size = new System.Drawing.Size(623, 23);
            this.txtVietPhrase1LogPath.TabIndex = 7;
            this.txtVietPhrase1LogPath.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "VietPhrase 2 (History):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVietPhrase2LogPath
            // 
            this.txtVietPhrase2LogPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVietPhrase2LogPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtVietPhrase2LogPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVietPhrase2LogPath.Location = new System.Drawing.Point(197, 108);
            this.txtVietPhrase2LogPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtVietPhrase2LogPath.Name = "txtVietPhrase2LogPath";
            this.txtVietPhrase2LogPath.ReadOnly = true;
            this.txtVietPhrase2LogPath.Size = new System.Drawing.Size(623, 23);
            this.txtVietPhrase2LogPath.TabIndex = 7;
            this.txtVietPhrase2LogPath.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEntryAuthor);
            this.groupBox1.Controls.Add(this.chkOnlyMergeCreatedByAuthor);
            this.groupBox1.Controls.Add(this.chkOnlyMergeLastest);
            this.groupBox1.Controls.Add(this.chkDontMergeDeletedFromVietPhrase1);
            this.groupBox1.Location = new System.Drawing.Point(11, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(917, 118);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // txtEntryAuthor
            // 
            this.txtEntryAuthor.Enabled = false;
            this.txtEntryAuthor.Location = new System.Drawing.Point(293, 82);
            this.txtEntryAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntryAuthor.Name = "txtEntryAuthor";
            this.txtEntryAuthor.Size = new System.Drawing.Size(240, 22);
            this.txtEntryAuthor.TabIndex = 10;
            // 
            // chkOnlyMergeCreatedByAuthor
            // 
            this.chkOnlyMergeCreatedByAuthor.Location = new System.Drawing.Point(21, 79);
            this.chkOnlyMergeCreatedByAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.chkOnlyMergeCreatedByAuthor.Name = "chkOnlyMergeCreatedByAuthor";
            this.chkOnlyMergeCreatedByAuthor.Size = new System.Drawing.Size(888, 30);
            this.chkOnlyMergeCreatedByAuthor.TabIndex = 9;
            this.chkOnlyMergeCreatedByAuthor.Text = "Chỉ merge những từ được update do:";
            this.chkOnlyMergeCreatedByAuthor.UseVisualStyleBackColor = true;
            this.chkOnlyMergeCreatedByAuthor.CheckedChanged += new System.EventHandler(this.MergeOnlyEntriesUpdatedByCheckBox_CheckedChanged);
            // 
            // chkOnlyMergeLastest
            // 
            this.chkOnlyMergeLastest.Location = new System.Drawing.Point(21, 49);
            this.chkOnlyMergeLastest.Margin = new System.Windows.Forms.Padding(4);
            this.chkOnlyMergeLastest.Name = "chkOnlyMergeLastest";
            this.chkOnlyMergeLastest.Size = new System.Drawing.Size(888, 30);
            this.chkOnlyMergeLastest.TabIndex = 8;
            this.chkOnlyMergeLastest.Text = "Chỉ merge những từ có ngày update mới nhất. Nếu không có ngày update thì bỏ qua.";
            this.chkOnlyMergeLastest.UseVisualStyleBackColor = true;
            // 
            // chkDontMergeDeletedFromVietPhrase1
            // 
            this.chkDontMergeDeletedFromVietPhrase1.Checked = true;
            this.chkDontMergeDeletedFromVietPhrase1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDontMergeDeletedFromVietPhrase1.Location = new System.Drawing.Point(21, 20);
            this.chkDontMergeDeletedFromVietPhrase1.Margin = new System.Windows.Forms.Padding(4);
            this.chkDontMergeDeletedFromVietPhrase1.Name = "chkDontMergeDeletedFromVietPhrase1";
            this.chkDontMergeDeletedFromVietPhrase1.Size = new System.Drawing.Size(888, 30);
            this.chkDontMergeDeletedFromVietPhrase1.TabIndex = 7;
            this.chkDontMergeDeletedFromVietPhrase1.Text = "Không merge những từ trong VietPhrase 2 nhưng đã bị xóa khỏi VietPhrase 1";
            this.chkDontMergeDeletedFromVietPhrase1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSelectOutputDirPath);
            this.Controls.Add(this.btnSelectVietPhrase2FilePath);
            this.Controls.Add(this.btnSelectVietPhrase1FilePath);
            this.Controls.Add(this.txtOutputDirPath);
            this.Controls.Add(this.txtVietPhrase2FilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVietPhrase2LogPath);
            this.Controls.Add(this.txtVietPhrase1LogPath);
            this.Controls.Add(this.txtVietPhrase1FilePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Quick VietPhrase Merger";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox chkOnlyMergeLastest;

        private System.Windows.Forms.CheckBox chkOnlyMergeCreatedByAuthor;

        private System.Windows.Forms.TextBox txtEntryAuthor;

        private System.Windows.Forms.CheckBox chkDontMergeDeletedFromVietPhrase1;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox txtVietPhrase2LogPath;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox txtVietPhrase1LogPath;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TextBox txtOutputDirPath;

        private System.Windows.Forms.TextBox txtVietPhrase1FilePath;

        private System.Windows.Forms.Button btnRun;

        private System.Windows.Forms.Button btnSelectOutputDirPath;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox txtVietPhrase2FilePath;

        private System.Windows.Forms.Button btnSelectVietPhrase1FilePath;

        private System.Windows.Forms.Button btnSelectVietPhrase2FilePath;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;
    }
}

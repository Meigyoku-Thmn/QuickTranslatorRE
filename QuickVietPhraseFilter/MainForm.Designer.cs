namespace QuickVietPhraseFilter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSelectOutputDirPath = new System.Windows.Forms.Button();
            this.btnSelectFilterRuleFilePath = new System.Windows.Forms.Button();
            this.btnSelectVietPhraseFilePath = new System.Windows.Forms.Button();
            this.txtOutputDirPath = new System.Windows.Forms.TextBox();
            this.txtFilterRuleFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVietPhraseFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(11, 148);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(469, 394);
            this.textBox1.TabIndex = 40;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(405, 108);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(149, 28);
            this.btnRun.TabIndex = 39;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.RunButtonClick);
            // 
            // btnSelectOutputDirPath
            // 
            this.btnSelectOutputDirPath.Location = new System.Drawing.Point(825, 69);
            this.btnSelectOutputDirPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOutputDirPath.Name = "btnSelectOutputDirPath";
            this.btnSelectOutputDirPath.Size = new System.Drawing.Size(100, 27);
            this.btnSelectOutputDirPath.TabIndex = 38;
            this.btnSelectOutputDirPath.Text = "Browse...";
            this.btnSelectOutputDirPath.UseVisualStyleBackColor = true;
            this.btnSelectOutputDirPath.Click += new System.EventHandler(this.BrowseOutputFolderButtonClick);
            // 
            // btnSelectFilterRuleFilePath
            // 
            this.btnSelectFilterRuleFilePath.Location = new System.Drawing.Point(825, 39);
            this.btnSelectFilterRuleFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFilterRuleFilePath.Name = "btnSelectFilterRuleFilePath";
            this.btnSelectFilterRuleFilePath.Size = new System.Drawing.Size(100, 27);
            this.btnSelectFilterRuleFilePath.TabIndex = 33;
            this.btnSelectFilterRuleFilePath.Text = "Browse...";
            this.btnSelectFilterRuleFilePath.UseVisualStyleBackColor = true;
            this.btnSelectFilterRuleFilePath.Click += new System.EventHandler(this.BrowseVietPhrase2ButtonClick);
            // 
            // btnSelectVietPhraseFilePath
            // 
            this.btnSelectVietPhraseFilePath.Location = new System.Drawing.Point(825, 10);
            this.btnSelectVietPhraseFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectVietPhraseFilePath.Name = "btnSelectVietPhraseFilePath";
            this.btnSelectVietPhraseFilePath.Size = new System.Drawing.Size(100, 27);
            this.btnSelectVietPhraseFilePath.TabIndex = 31;
            this.btnSelectVietPhraseFilePath.Text = "Browse...";
            this.btnSelectVietPhraseFilePath.UseVisualStyleBackColor = true;
            this.btnSelectVietPhraseFilePath.Click += new System.EventHandler(this.BrowseVietPhrase1ButtonClick);
            // 
            // txtOutputDirPath
            // 
            this.txtOutputDirPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOutputDirPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtOutputDirPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputDirPath.Location = new System.Drawing.Point(197, 70);
            this.txtOutputDirPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputDirPath.Name = "txtOutputDirPath";
            this.txtOutputDirPath.Size = new System.Drawing.Size(623, 23);
            this.txtOutputDirPath.TabIndex = 36;
            // 
            // txtFilterRuleFilePath
            // 
            this.txtFilterRuleFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFilterRuleFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtFilterRuleFilePath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterRuleFilePath.Location = new System.Drawing.Point(197, 41);
            this.txtFilterRuleFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterRuleFilePath.Name = "txtFilterRuleFilePath";
            this.txtFilterRuleFilePath.Size = new System.Drawing.Size(623, 23);
            this.txtFilterRuleFilePath.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "Thư mục chứa file kết quả:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVietPhraseFilePath
            // 
            this.txtVietPhraseFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVietPhraseFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtVietPhraseFilePath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVietPhraseFilePath.Location = new System.Drawing.Point(197, 11);
            this.txtVietPhraseFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtVietPhraseFilePath.Name = "txtVietPhraseFilePath";
            this.txtVietPhraseFilePath.Size = new System.Drawing.Size(623, 23);
            this.txtVietPhraseFilePath.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 35;
            this.label2.Text = "Quy luật lọc:";
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
            this.label1.TabIndex = 37;
            this.label1.Text = "VietPhrase nguồn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(491, 177);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(437, 364);
            this.textBox2.TabIndex = 41;
            this.textBox2.TabStop = false;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(11, 551);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(917, 40);
            this.textBox3.TabIndex = 42;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Chú ý 1: tên file kết quả có dạng QuickVietPhraseFilter_yyyyMMddHHmmss.txt\r\nChú ý" +
    " 2: file luật lọc có thể có nhiều dòng, mỗi luật là một dòng. Chỗ thay thế {0} c" +
    "ó thể đặt ở bất kỳ vị trí nào.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 594);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSelectOutputDirPath);
            this.Controls.Add(this.btnSelectFilterRuleFilePath);
            this.Controls.Add(this.btnSelectVietPhraseFilePath);
            this.Controls.Add(this.txtOutputDirPath);
            this.Controls.Add(this.txtFilterRuleFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVietPhraseFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Quick VietPhrase Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtVietPhraseFilePath;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox txtFilterRuleFilePath;

        private System.Windows.Forms.TextBox txtOutputDirPath;

        private System.Windows.Forms.Button btnSelectVietPhraseFilePath;

        private System.Windows.Forms.Button btnSelectFilterRuleFilePath;

        private System.Windows.Forms.Button btnSelectOutputDirPath;

        private System.Windows.Forms.Button btnRun;

        private System.Windows.Forms.TextBox textBox1;
    }
}

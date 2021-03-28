
namespace QuickVietPhraseMultiplicator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSelectOutputFile = new System.Windows.Forms.Button();
            this.btnSelectMultiplyRuleFile = new System.Windows.Forms.Button();
            this.btnSelectVietPhaseFile = new System.Windows.Forms.Button();
            this.txtOutputDirPath = new System.Windows.Forms.TextBox();
            this.txtMultiplyRuleFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVietPhraseFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(373, 101);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(149, 28);
            this.btnRun.TabIndex = 28;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.RunButton_OnClick);
            // 
            // btnSelectOutputFile
            // 
            this.btnSelectOutputFile.Location = new System.Drawing.Point(825, 69);
            this.btnSelectOutputFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOutputFile.Name = "btnSelectOutputFile";
            this.btnSelectOutputFile.Size = new System.Drawing.Size(100, 27);
            this.btnSelectOutputFile.TabIndex = 25;
            this.btnSelectOutputFile.Text = "Browse...";
            this.btnSelectOutputFile.UseVisualStyleBackColor = true;
            this.btnSelectOutputFile.Click += new System.EventHandler(this.SelectOutputDirButton_OnClick);
            // 
            // btnSelectMultiplyRuleFile
            // 
            this.btnSelectMultiplyRuleFile.Location = new System.Drawing.Point(825, 39);
            this.btnSelectMultiplyRuleFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectMultiplyRuleFile.Name = "btnSelectMultiplyRuleFile";
            this.btnSelectMultiplyRuleFile.Size = new System.Drawing.Size(100, 27);
            this.btnSelectMultiplyRuleFile.TabIndex = 18;
            this.btnSelectMultiplyRuleFile.Text = "Browse...";
            this.btnSelectMultiplyRuleFile.UseVisualStyleBackColor = true;
            this.btnSelectMultiplyRuleFile.Click += new System.EventHandler(this.SelectMultiplyRuleFileButton_OnClick);
            // 
            // btnSelectVietPhaseFile
            // 
            this.btnSelectVietPhaseFile.Location = new System.Drawing.Point(825, 10);
            this.btnSelectVietPhaseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectVietPhaseFile.Name = "btnSelectVietPhaseFile";
            this.btnSelectVietPhaseFile.Size = new System.Drawing.Size(100, 27);
            this.btnSelectVietPhaseFile.TabIndex = 16;
            this.btnSelectVietPhaseFile.Text = "Browse...";
            this.btnSelectVietPhaseFile.UseVisualStyleBackColor = true;
            this.btnSelectVietPhaseFile.Click += new System.EventHandler(this.SelectVietPhraseFileButton_OnClick);
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
            this.txtOutputDirPath.TabIndex = 21;
            // 
            // txtMultiplyRuleFilePath
            // 
            this.txtMultiplyRuleFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMultiplyRuleFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtMultiplyRuleFilePath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiplyRuleFilePath.Location = new System.Drawing.Point(197, 41);
            this.txtMultiplyRuleFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtMultiplyRuleFilePath.Name = "txtMultiplyRuleFilePath";
            this.txtMultiplyRuleFilePath.Size = new System.Drawing.Size(623, 23);
            this.txtMultiplyRuleFilePath.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 27);
            this.label4.TabIndex = 19;
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
            this.txtVietPhraseFilePath.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quy luật nhân:";
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
            this.label1.TabIndex = 24;
            this.label1.Text = "VietPhrase nguồn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(11, 148);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(917, 374);
            this.textBox1.TabIndex = 29;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 529);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSelectOutputFile);
            this.Controls.Add(this.btnSelectMultiplyRuleFile);
            this.Controls.Add(this.btnSelectVietPhaseFile);
            this.Controls.Add(this.txtOutputDirPath);
            this.Controls.Add(this.txtMultiplyRuleFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVietPhraseFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick VietPhrase Multiplicator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtVietPhraseFilePath;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox txtMultiplyRuleFilePath;

        private System.Windows.Forms.TextBox txtOutputDirPath;

        private System.Windows.Forms.Button btnSelectVietPhaseFile;

        private System.Windows.Forms.Button btnSelectMultiplyRuleFile;

        private System.Windows.Forms.Button btnSelectOutputFile;

        private System.Windows.Forms.Button btnRun;
    }
}

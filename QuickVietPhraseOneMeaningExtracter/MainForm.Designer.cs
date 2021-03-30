
namespace QuickVietPhraseOneMeaningExtracter
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
            this.btnSelectVietPhraseFile = new System.Windows.Forms.Button();
            this.txtVietPhraseFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectVietPhraseFile
            // 
            this.btnSelectVietPhraseFile.Location = new System.Drawing.Point(820, 9);
            this.btnSelectVietPhraseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectVietPhraseFile.Name = "btnSelectVietPhraseFile";
            this.btnSelectVietPhraseFile.Size = new System.Drawing.Size(100, 27);
            this.btnSelectVietPhraseFile.TabIndex = 11;
            this.btnSelectVietPhraseFile.Text = "Browse...";
            this.btnSelectVietPhraseFile.UseVisualStyleBackColor = true;
            this.btnSelectVietPhraseFile.Click += new System.EventHandler(this.SelectVietPhraseFileButton_OnClick);
            // 
            // txtVietPhraseFilePath
            // 
            this.txtVietPhraseFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVietPhraseFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtVietPhraseFilePath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVietPhraseFilePath.Location = new System.Drawing.Point(192, 10);
            this.txtVietPhraseFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtVietPhraseFilePath.Name = "txtVietPhraseFilePath";
            this.txtVietPhraseFilePath.Size = new System.Drawing.Size(623, 23);
            this.txtVietPhraseFilePath.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "VietPhrase đa nghĩa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(395, 79);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(149, 28);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.RunButton_OnClick);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(5, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(917, 30);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "* Chức năng: tách nghia đầu tiên, tạo file VietPhrase một nghĩa trong cùng thư mụ" +
    "c.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 114);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSelectVietPhraseFile);
            this.Controls.Add(this.txtVietPhraseFilePath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick VietPhrase One Meaning Extracter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button btnRun;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtVietPhraseFilePath;

        private System.Windows.Forms.Button btnSelectVietPhraseFile;
    }
}

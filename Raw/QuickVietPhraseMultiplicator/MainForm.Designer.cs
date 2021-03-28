
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
            this.runButton = new System.Windows.Forms.Button();
            this.browseOutputFolderButton = new System.Windows.Forms.Button();
            this.browseVietPhrase2Button = new System.Windows.Forms.Button();
            this.browseVietPhrase1Button = new System.Windows.Forms.Button();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.vietPhrase2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vietPhrase1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(373, 101);
            this.runButton.Margin = new System.Windows.Forms.Padding(4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(149, 28);
            this.runButton.TabIndex = 28;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButtonClick);
            // 
            // browseOutputFolderButton
            // 
            this.browseOutputFolderButton.Location = new System.Drawing.Point(825, 69);
            this.browseOutputFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseOutputFolderButton.Name = "browseOutputFolderButton";
            this.browseOutputFolderButton.Size = new System.Drawing.Size(100, 27);
            this.browseOutputFolderButton.TabIndex = 25;
            this.browseOutputFolderButton.Text = "Browse...";
            this.browseOutputFolderButton.UseVisualStyleBackColor = true;
            this.browseOutputFolderButton.Click += new System.EventHandler(this.BrowseOutputFolderButtonClick);
            // 
            // browseVietPhrase2Button
            // 
            this.browseVietPhrase2Button.Location = new System.Drawing.Point(825, 39);
            this.browseVietPhrase2Button.Margin = new System.Windows.Forms.Padding(4);
            this.browseVietPhrase2Button.Name = "browseVietPhrase2Button";
            this.browseVietPhrase2Button.Size = new System.Drawing.Size(100, 27);
            this.browseVietPhrase2Button.TabIndex = 18;
            this.browseVietPhrase2Button.Text = "Browse...";
            this.browseVietPhrase2Button.UseVisualStyleBackColor = true;
            this.browseVietPhrase2Button.Click += new System.EventHandler(this.BrowseVietPhrase2ButtonClick);
            // 
            // browseVietPhrase1Button
            // 
            this.browseVietPhrase1Button.Location = new System.Drawing.Point(825, 10);
            this.browseVietPhrase1Button.Margin = new System.Windows.Forms.Padding(4);
            this.browseVietPhrase1Button.Name = "browseVietPhrase1Button";
            this.browseVietPhrase1Button.Size = new System.Drawing.Size(100, 27);
            this.browseVietPhrase1Button.TabIndex = 16;
            this.browseVietPhrase1Button.Text = "Browse...";
            this.browseVietPhrase1Button.UseVisualStyleBackColor = true;
            this.browseVietPhrase1Button.Click += new System.EventHandler(this.BrowseVietPhrase1ButtonClick);
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.outputFolderTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.outputFolderTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFolderTextBox.Location = new System.Drawing.Point(197, 70);
            this.outputFolderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(623, 23);
            this.outputFolderTextBox.TabIndex = 21;
            // 
            // vietPhrase2TextBox
            // 
            this.vietPhrase2TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.vietPhrase2TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.vietPhrase2TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vietPhrase2TextBox.Location = new System.Drawing.Point(197, 41);
            this.vietPhrase2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.vietPhrase2TextBox.Name = "vietPhrase2TextBox";
            this.vietPhrase2TextBox.Size = new System.Drawing.Size(623, 23);
            this.vietPhrase2TextBox.TabIndex = 17;
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
            // vietPhrase1TextBox
            // 
            this.vietPhrase1TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.vietPhrase1TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.vietPhrase1TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vietPhrase1TextBox.Location = new System.Drawing.Point(197, 11);
            this.vietPhrase1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.vietPhrase1TextBox.Name = "vietPhrase1TextBox";
            this.vietPhrase1TextBox.Size = new System.Drawing.Size(623, 23);
            this.vietPhrase1TextBox.TabIndex = 15;
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
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.browseOutputFolderButton);
            this.Controls.Add(this.browseVietPhrase2Button);
            this.Controls.Add(this.browseVietPhrase1Button);
            this.Controls.Add(this.outputFolderTextBox);
            this.Controls.Add(this.vietPhrase2TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vietPhrase1TextBox);
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

        private System.Windows.Forms.TextBox vietPhrase1TextBox;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox vietPhrase2TextBox;

        private System.Windows.Forms.TextBox outputFolderTextBox;

        private System.Windows.Forms.Button browseVietPhrase1Button;

        private System.Windows.Forms.Button browseVietPhrase2Button;

        private System.Windows.Forms.Button browseOutputFolderButton;

        private System.Windows.Forms.Button runButton;
    }
}

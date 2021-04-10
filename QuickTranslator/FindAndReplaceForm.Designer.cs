namespace QuickTranslator
{
    public partial class FindAndReplaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindAndReplaceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.replaceWithTextBox = new System.Windows.Forms.TextBox();
            this.findNextButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceAllButton = new System.Windows.Forms.Button();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.matchWholeWordCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downRadioButton = new System.Windows.Forms.RadioButton();
            this.upRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find:";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(124, 7);
            this.findTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(367, 22);
            this.findTextBox.TabIndex = 0;
            this.findTextBox.TextChanged += new System.EventHandler(this.FindTextBoxTextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Replace With:";
            // 
            // replaceWithTextBox
            // 
            this.replaceWithTextBox.Location = new System.Drawing.Point(124, 46);
            this.replaceWithTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.replaceWithTextBox.Name = "replaceWithTextBox";
            this.replaceWithTextBox.Size = new System.Drawing.Size(367, 22);
            this.replaceWithTextBox.TabIndex = 2;
            // 
            // findNextButton
            // 
            this.findNextButton.Enabled = false;
            this.findNextButton.Location = new System.Drawing.Point(513, 5);
            this.findNextButton.Margin = new System.Windows.Forms.Padding(4);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(100, 28);
            this.findNextButton.TabIndex = 1;
            this.findNextButton.Text = "Find Next";
            this.findNextButton.UseVisualStyleBackColor = true;
            this.findNextButton.Click += new System.EventHandler(this.FindNextButtonClick);
            // 
            // replaceButton
            // 
            this.replaceButton.Enabled = false;
            this.replaceButton.Location = new System.Drawing.Point(513, 43);
            this.replaceButton.Margin = new System.Windows.Forms.Padding(4);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(100, 28);
            this.replaceButton.TabIndex = 3;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.ReplaceButtonClick);
            // 
            // replaceAllButton
            // 
            this.replaceAllButton.Enabled = false;
            this.replaceAllButton.Location = new System.Drawing.Point(513, 79);
            this.replaceAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.Size = new System.Drawing.Size(100, 28);
            this.replaceAllButton.TabIndex = 4;
            this.replaceAllButton.Text = "Replace All";
            this.replaceAllButton.UseVisualStyleBackColor = true;
            this.replaceAllButton.Click += new System.EventHandler(this.ReplaceAllButtonClick);
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.Location = new System.Drawing.Point(16, 130);
            this.matchCaseCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(139, 30);
            this.matchCaseCheckBox.TabIndex = 5;
            this.matchCaseCheckBox.Text = "Match Case";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchWholeWordCheckBox
            // 
            this.matchWholeWordCheckBox.Location = new System.Drawing.Point(16, 167);
            this.matchWholeWordCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.matchWholeWordCheckBox.Name = "matchWholeWordCheckBox";
            this.matchWholeWordCheckBox.Size = new System.Drawing.Size(200, 30);
            this.matchWholeWordCheckBox.TabIndex = 6;
            this.matchWholeWordCheckBox.Text = "Match Whole Word";
            this.matchWholeWordCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downRadioButton);
            this.groupBox1.Controls.Add(this.upRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(225, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 66);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // downRadioButton
            // 
            this.downRadioButton.Checked = true;
            this.downRadioButton.Location = new System.Drawing.Point(147, 23);
            this.downRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.downRadioButton.Name = "downRadioButton";
            this.downRadioButton.Size = new System.Drawing.Size(112, 33);
            this.downRadioButton.TabIndex = 1;
            this.downRadioButton.TabStop = true;
            this.downRadioButton.Text = "Down";
            this.downRadioButton.UseVisualStyleBackColor = true;
            // 
            // upRadioButton
            // 
            this.upRadioButton.Location = new System.Drawing.Point(17, 23);
            this.upRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.upRadioButton.Name = "upRadioButton";
            this.upRadioButton.Size = new System.Drawing.Size(97, 33);
            this.upRadioButton.TabIndex = 0;
            this.upRadioButton.Text = "Up";
            this.upRadioButton.UseVisualStyleBackColor = true;
            // 
            // FindAndReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 208);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matchWholeWordCheckBox);
            this.Controls.Add(this.matchCaseCheckBox);
            this.Controls.Add(this.replaceAllButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.replaceWithTextBox);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindAndReplaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Replace (ô Trung)";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RadioButton upRadioButton;

        private System.Windows.Forms.RadioButton downRadioButton;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.CheckBox matchWholeWordCheckBox;

        private System.Windows.Forms.CheckBox matchCaseCheckBox;

        private System.Windows.Forms.Button replaceAllButton;

        private System.Windows.Forms.Button replaceButton;

        private System.Windows.Forms.Button findNextButton;

        private System.Windows.Forms.TextBox replaceWithTextBox;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox findTextBox;

        private System.Windows.Forms.Label label1;
    }
}

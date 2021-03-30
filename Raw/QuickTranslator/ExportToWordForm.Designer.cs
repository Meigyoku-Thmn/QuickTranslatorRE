namespace QuickTranslator
{
    public partial class ExportToWordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportToWordForm));
            this.exportFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.insertBlankLineCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.exportFormatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exportFormatGroupBox
            // 
            this.exportFormatGroupBox.Controls.Add(this.insertBlankLineCheckBox);
            this.exportFormatGroupBox.Controls.Add(this.label5);
            this.exportFormatGroupBox.Controls.Add(this.label4);
            this.exportFormatGroupBox.Controls.Add(this.label3);
            this.exportFormatGroupBox.Controls.Add(this.label2);
            this.exportFormatGroupBox.Controls.Add(this.comboBox5);
            this.exportFormatGroupBox.Controls.Add(this.comboBox4);
            this.exportFormatGroupBox.Controls.Add(this.comboBox3);
            this.exportFormatGroupBox.Controls.Add(this.comboBox2);
            this.exportFormatGroupBox.Controls.Add(this.comboBox1);
            this.exportFormatGroupBox.Controls.Add(this.label1);
            this.exportFormatGroupBox.Location = new System.Drawing.Point(16, 15);
            this.exportFormatGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.exportFormatGroupBox.Name = "exportFormatGroupBox";
            this.exportFormatGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.exportFormatGroupBox.Size = new System.Drawing.Size(592, 231);
            this.exportFormatGroupBox.TabIndex = 0;
            this.exportFormatGroupBox.TabStop = false;
            this.exportFormatGroupBox.Text = "Export Format";
            // 
            // insertBlankLineCheckBox
            // 
            this.insertBlankLineCheckBox.Checked = true;
            this.insertBlankLineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.insertBlankLineCheckBox.Location = new System.Drawing.Point(245, 187);
            this.insertBlankLineCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.insertBlankLineCheckBox.Name = "insertBlankLineCheckBox";
            this.insertBlankLineCheckBox.Size = new System.Drawing.Size(289, 30);
            this.insertBlankLineCheckBox.TabIndex = 6;
            this.insertBlankLineCheckBox.Text = "Chèn thêm dòng trắng giữa các dòng";
            this.insertBlankLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(132, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Column 5:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(132, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Column 4:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(131, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Column 3:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(132, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Column 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(245, 156);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(255, 24);
            this.comboBox5.TabIndex = 5;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(245, 124);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(255, 24);
            this.comboBox4.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(245, 91);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(255, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(245, 58);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(255, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(132, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(192, 266);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(100, 30);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(331, 266);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(105, 28);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // ExportToWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(627, 304);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.exportFormatGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportToWordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export To Word";
            this.Load += new System.EventHandler(this.ExportToWordFormLoad);
            this.exportFormatGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.ComponentModel.IContainer components;

        private System.Windows.Forms.CheckBox insertBlankLineCheckBox;

        private System.Windows.Forms.Button closeButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.ComboBox comboBox3;

        private System.Windows.Forms.ComboBox comboBox4;

        private System.Windows.Forms.ComboBox comboBox5;

        private System.Windows.Forms.Button exportButton;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.GroupBox exportFormatGroupBox;
    }
}

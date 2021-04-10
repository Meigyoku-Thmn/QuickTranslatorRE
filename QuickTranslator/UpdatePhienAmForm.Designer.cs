namespace QuickTranslator
{
    public partial class UpdatePhienAmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePhienAmForm));
            this.entryCountLabel = new System.Windows.Forms.Label();
            this.phienAmTextBox = new System.Windows.Forms.TextBox();
            this.chineseTextBox = new System.Windows.Forms.TextBox();
            this.phienAmLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sortingCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryCountLabel
            // 
            this.entryCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryCountLabel.Location = new System.Drawing.Point(107, -1);
            this.entryCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entryCountLabel.Name = "entryCountLabel";
            this.entryCountLabel.Size = new System.Drawing.Size(213, 28);
            this.entryCountLabel.TabIndex = 14;
            this.entryCountLabel.Text = "label4";
            this.entryCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phienAmTextBox
            // 
            this.phienAmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phienAmTextBox.Location = new System.Drawing.Point(107, 79);
            this.phienAmTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phienAmTextBox.Name = "phienAmTextBox";
            this.phienAmTextBox.Size = new System.Drawing.Size(233, 30);
            this.phienAmTextBox.TabIndex = 2;
            // 
            // chineseTextBox
            // 
            this.chineseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chineseTextBox.Location = new System.Drawing.Point(107, 31);
            this.chineseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.chineseTextBox.Name = "chineseTextBox";
            this.chineseTextBox.Size = new System.Drawing.Size(233, 34);
            this.chineseTextBox.TabIndex = 1;
            this.chineseTextBox.TextChanged += new System.EventHandler(this.ChineseTextBoxTextChanged);
            // 
            // phienAmLabel
            // 
            this.phienAmLabel.Location = new System.Drawing.Point(0, 89);
            this.phienAmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phienAmLabel.Name = "phienAmLabel";
            this.phienAmLabel.Size = new System.Drawing.Size(97, 22);
            this.phienAmLabel.TabIndex = 9;
            this.phienAmLabel.Text = "Phiên Âm:";
            this.phienAmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Entries:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chinese:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sortingCheckBox
            // 
            this.sortingCheckBox.Location = new System.Drawing.Point(107, 128);
            this.sortingCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.sortingCheckBox.Name = "sortingCheckBox";
            this.sortingCheckBox.Size = new System.Drawing.Size(235, 30);
            this.sortingCheckBox.TabIndex = 3;
            this.sortingCheckBox.Text = "Sắp xếp lại dữ liệu từ điển";
            this.sortingCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(128, 167);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 28);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(245, 167);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 28);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(11, 167);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 28);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update or Add";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // UpdatePhienAmForm
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(369, 210);
            this.Controls.Add(this.sortingCheckBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.entryCountLabel);
            this.Controls.Add(this.phienAmTextBox);
            this.Controls.Add(this.chineseTextBox);
            this.Controls.Add(this.phienAmLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatePhienAmForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Phiên Âm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label phienAmLabel;

        private System.Windows.Forms.Button updateButton;

        private System.Windows.Forms.Button cancelButton;

        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.CheckBox sortingCheckBox;

        private System.Windows.Forms.TextBox phienAmTextBox;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox chineseTextBox;

        private System.Windows.Forms.Label entryCountLabel;
    }
}

namespace QuickTranslator
{
	// Token: 0x02000019 RID: 25
	public partial class UpdatePhienAmForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600014E RID: 334 RVA: 0x00011BBF File Offset: 0x00010BBF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00011BE0 File Offset: 0x00010BE0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::QuickTranslator.UpdatePhienAmForm));
			this.entryCountLabel = new global::System.Windows.Forms.Label();
			this.phienAmTextBox = new global::System.Windows.Forms.TextBox();
			this.chineseTextBox = new global::System.Windows.Forms.TextBox();
			this.phienAmLabel = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.sortingCheckBox = new global::System.Windows.Forms.CheckBox();
			this.deleteButton = new global::System.Windows.Forms.Button();
			this.cancelButton = new global::System.Windows.Forms.Button();
			this.updateButton = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.entryCountLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.entryCountLabel.Location = new global::System.Drawing.Point(80, -1);
			this.entryCountLabel.Name = "entryCountLabel";
			this.entryCountLabel.Size = new global::System.Drawing.Size(160, 23);
			this.entryCountLabel.TabIndex = 14;
			this.entryCountLabel.Text = "label4";
			this.entryCountLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.phienAmTextBox.Font = new global::System.Drawing.Font("Arial Unicode MS", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.phienAmTextBox.Location = new global::System.Drawing.Point(80, 64);
			this.phienAmTextBox.Name = "phienAmTextBox";
			this.phienAmTextBox.Size = new global::System.Drawing.Size(176, 29);
			this.phienAmTextBox.TabIndex = 2;
			this.chineseTextBox.Font = new global::System.Drawing.Font("Arial Unicode MS", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chineseTextBox.Location = new global::System.Drawing.Point(80, 25);
			this.chineseTextBox.Name = "chineseTextBox";
			this.chineseTextBox.Size = new global::System.Drawing.Size(176, 33);
			this.chineseTextBox.TabIndex = 1;
			this.chineseTextBox.TextChanged += new global::System.EventHandler(this.ChineseTextBoxTextChanged);
			this.phienAmLabel.Location = new global::System.Drawing.Point(0, 72);
			this.phienAmLabel.Name = "phienAmLabel";
			this.phienAmLabel.Size = new global::System.Drawing.Size(73, 18);
			this.phienAmLabel.TabIndex = 9;
			this.phienAmLabel.Text = "Phiên Âm:";
			this.phienAmLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Location = new global::System.Drawing.Point(1, 1);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(73, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "Entries:";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new global::System.Drawing.Point(1, 32);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(73, 18);
			this.label1.TabIndex = 10;
			this.label1.Text = "Chinese:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.sortingCheckBox.Location = new global::System.Drawing.Point(80, 104);
			this.sortingCheckBox.Name = "sortingCheckBox";
			this.sortingCheckBox.Size = new global::System.Drawing.Size(176, 24);
			this.sortingCheckBox.TabIndex = 3;
			this.sortingCheckBox.Text = "Sắp xếp lại dữ liệu từ điển";
			this.sortingCheckBox.UseVisualStyleBackColor = true;
			this.deleteButton.Location = new global::System.Drawing.Point(96, 136);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new global::System.Drawing.Size(84, 23);
			this.deleteButton.TabIndex = 5;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new global::System.EventHandler(this.DeleteButtonClick);
			this.cancelButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new global::System.Drawing.Point(184, 136);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new global::System.Drawing.Size(84, 23);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new global::System.EventHandler(this.CancelButtonClick);
			this.updateButton.Location = new global::System.Drawing.Point(8, 136);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new global::System.Drawing.Size(84, 23);
			this.updateButton.TabIndex = 4;
			this.updateButton.Text = "Update or Add";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new global::System.EventHandler(this.UpdateButtonClick);
			base.AcceptButton = this.updateButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.cancelButton;
			base.ClientSize = new global::System.Drawing.Size(277, 171);
			base.Controls.Add(this.sortingCheckBox);
			base.Controls.Add(this.deleteButton);
			base.Controls.Add(this.cancelButton);
			base.Controls.Add(this.updateButton);
			base.Controls.Add(this.entryCountLabel);
			base.Controls.Add(this.phienAmTextBox);
			base.Controls.Add(this.chineseTextBox);
			base.Controls.Add(this.phienAmLabel);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UpdatePhienAmForm";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update Phiên Âm";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400015D RID: 349
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.Label phienAmLabel;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.Button updateButton;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.Button cancelButton;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.Button deleteButton;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.CheckBox sortingCheckBox;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.TextBox phienAmTextBox;

		// Token: 0x04000164 RID: 356
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.TextBox chineseTextBox;

		// Token: 0x04000167 RID: 359
		private global::System.Windows.Forms.Label entryCountLabel;
	}
}

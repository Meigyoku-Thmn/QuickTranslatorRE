namespace QuickTranslator
{
	// Token: 0x02000010 RID: 16
	public partial class ExportToWordForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00008FD1 File Offset: 0x00007FD1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00008FF0 File Offset: 0x00007FF0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::QuickTranslator.ExportToWordForm));
			this.exportFormatGroupBox = new global::System.Windows.Forms.GroupBox();
			this.insertBlankLineCheckBox = new global::System.Windows.Forms.CheckBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.comboBox5 = new global::System.Windows.Forms.ComboBox();
			this.comboBox4 = new global::System.Windows.Forms.ComboBox();
			this.comboBox3 = new global::System.Windows.Forms.ComboBox();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.exportButton = new global::System.Windows.Forms.Button();
			this.closeButton = new global::System.Windows.Forms.Button();
			this.exportFormatGroupBox.SuspendLayout();
			base.SuspendLayout();
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
			this.exportFormatGroupBox.Location = new global::System.Drawing.Point(12, 12);
			this.exportFormatGroupBox.Name = "exportFormatGroupBox";
			this.exportFormatGroupBox.Size = new global::System.Drawing.Size(444, 188);
			this.exportFormatGroupBox.TabIndex = 0;
			this.exportFormatGroupBox.TabStop = false;
			this.exportFormatGroupBox.Text = "Export Format";
			this.insertBlankLineCheckBox.Checked = true;
			this.insertBlankLineCheckBox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.insertBlankLineCheckBox.Location = new global::System.Drawing.Point(184, 152);
			this.insertBlankLineCheckBox.Name = "insertBlankLineCheckBox";
			this.insertBlankLineCheckBox.Size = new global::System.Drawing.Size(217, 24);
			this.insertBlankLineCheckBox.TabIndex = 6;
			this.insertBlankLineCheckBox.Text = "Chèn thêm dòng trắng giữa các dòng";
			this.insertBlankLineCheckBox.UseVisualStyleBackColor = true;
			this.label5.Location = new global::System.Drawing.Point(99, 129);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(67, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Column 5:";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label4.Location = new global::System.Drawing.Point(99, 103);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(67, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Column 4:";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Location = new global::System.Drawing.Point(98, 76);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(67, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Column 3:";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new global::System.Drawing.Point(99, 49);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(67, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Column 2:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.comboBox5.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new global::System.Drawing.Point(184, 127);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new global::System.Drawing.Size(192, 21);
			this.comboBox5.TabIndex = 5;
			this.comboBox4.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new global::System.Drawing.Point(184, 101);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new global::System.Drawing.Size(192, 21);
			this.comboBox4.TabIndex = 4;
			this.comboBox3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new global::System.Drawing.Point(184, 74);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new global::System.Drawing.Size(192, 21);
			this.comboBox3.TabIndex = 3;
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new global::System.Drawing.Point(184, 47);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(192, 21);
			this.comboBox2.TabIndex = 2;
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(184, 20);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(192, 21);
			this.comboBox1.TabIndex = 1;
			this.label1.Location = new global::System.Drawing.Point(99, 22);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(67, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Column 1:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.exportButton.Location = new global::System.Drawing.Point(144, 216);
			this.exportButton.Name = "exportButton";
			this.exportButton.Size = new global::System.Drawing.Size(75, 24);
			this.exportButton.TabIndex = 6;
			this.exportButton.Text = "Export";
			this.exportButton.UseVisualStyleBackColor = true;
			this.exportButton.Click += new global::System.EventHandler(this.ExportButtonClick);
			this.closeButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Location = new global::System.Drawing.Point(248, 216);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new global::System.Drawing.Size(79, 23);
			this.closeButton.TabIndex = 7;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new global::System.EventHandler(this.CloseButtonClick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.closeButton;
			base.ClientSize = new global::System.Drawing.Size(470, 247);
			base.Controls.Add(this.closeButton);
			base.Controls.Add(this.exportButton);
			base.Controls.Add(this.exportFormatGroupBox);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ExportToWordForm";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Export To Word";
			base.Load += new global::System.EventHandler(this.ExportToWordFormLoad);
			this.exportFormatGroupBox.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000CC RID: 204
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.CheckBox insertBlankLineCheckBox;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Button closeButton;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.ComboBox comboBox3;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.ComboBox comboBox4;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.ComboBox comboBox5;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Button exportButton;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.GroupBox exportFormatGroupBox;
	}
}

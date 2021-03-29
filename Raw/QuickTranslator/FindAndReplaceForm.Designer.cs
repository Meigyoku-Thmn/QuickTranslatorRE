namespace QuickTranslator
{
	// Token: 0x02000011 RID: 17
	public partial class FindAndReplaceForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00009A47 File Offset: 0x00008A47
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00009A68 File Offset: 0x00008A68
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::QuickTranslator.FindAndReplaceForm));
			this.label1 = new global::System.Windows.Forms.Label();
			this.findTextBox = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.replaceWithTextBox = new global::System.Windows.Forms.TextBox();
			this.findNextButton = new global::System.Windows.Forms.Button();
			this.replaceButton = new global::System.Windows.Forms.Button();
			this.replaceAllButton = new global::System.Windows.Forms.Button();
			this.matchCaseCheckBox = new global::System.Windows.Forms.CheckBox();
			this.matchWholeWordCheckBox = new global::System.Windows.Forms.CheckBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.downRadioButton = new global::System.Windows.Forms.RadioButton();
			this.upRadioButton = new global::System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(75, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Find:";
			this.findTextBox.Location = new global::System.Drawing.Point(93, 6);
			this.findTextBox.Name = "findTextBox";
			this.findTextBox.Size = new global::System.Drawing.Size(276, 20);
			this.findTextBox.TabIndex = 0;
			this.findTextBox.TextChanged += new global::System.EventHandler(this.FindTextBoxTextChanged);
			this.label2.Location = new global::System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(75, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "Replace With:";
			this.replaceWithTextBox.Location = new global::System.Drawing.Point(93, 37);
			this.replaceWithTextBox.Name = "replaceWithTextBox";
			this.replaceWithTextBox.Size = new global::System.Drawing.Size(276, 20);
			this.replaceWithTextBox.TabIndex = 2;
			this.findNextButton.Enabled = false;
			this.findNextButton.Location = new global::System.Drawing.Point(385, 4);
			this.findNextButton.Name = "findNextButton";
			this.findNextButton.Size = new global::System.Drawing.Size(75, 23);
			this.findNextButton.TabIndex = 1;
			this.findNextButton.Text = "Find Next";
			this.findNextButton.UseVisualStyleBackColor = true;
			this.findNextButton.Click += new global::System.EventHandler(this.FindNextButtonClick);
			this.replaceButton.Enabled = false;
			this.replaceButton.Location = new global::System.Drawing.Point(385, 35);
			this.replaceButton.Name = "replaceButton";
			this.replaceButton.Size = new global::System.Drawing.Size(75, 23);
			this.replaceButton.TabIndex = 3;
			this.replaceButton.Text = "Replace";
			this.replaceButton.UseVisualStyleBackColor = true;
			this.replaceButton.Click += new global::System.EventHandler(this.ReplaceButtonClick);
			this.replaceAllButton.Enabled = false;
			this.replaceAllButton.Location = new global::System.Drawing.Point(385, 64);
			this.replaceAllButton.Name = "replaceAllButton";
			this.replaceAllButton.Size = new global::System.Drawing.Size(75, 23);
			this.replaceAllButton.TabIndex = 4;
			this.replaceAllButton.Text = "Replace All";
			this.replaceAllButton.UseVisualStyleBackColor = true;
			this.replaceAllButton.Click += new global::System.EventHandler(this.ReplaceAllButtonClick);
			this.matchCaseCheckBox.Location = new global::System.Drawing.Point(12, 106);
			this.matchCaseCheckBox.Name = "matchCaseCheckBox";
			this.matchCaseCheckBox.Size = new global::System.Drawing.Size(104, 24);
			this.matchCaseCheckBox.TabIndex = 5;
			this.matchCaseCheckBox.Text = "Match Case";
			this.matchCaseCheckBox.UseVisualStyleBackColor = true;
			this.matchWholeWordCheckBox.Location = new global::System.Drawing.Point(12, 136);
			this.matchWholeWordCheckBox.Name = "matchWholeWordCheckBox";
			this.matchWholeWordCheckBox.Size = new global::System.Drawing.Size(150, 24);
			this.matchWholeWordCheckBox.TabIndex = 6;
			this.matchWholeWordCheckBox.Text = "Match Whole Word";
			this.matchWholeWordCheckBox.UseVisualStyleBackColor = true;
			this.groupBox1.Controls.Add(this.downRadioButton);
			this.groupBox1.Controls.Add(this.upRadioButton);
			this.groupBox1.Location = new global::System.Drawing.Point(169, 106);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(200, 54);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Direction";
			this.downRadioButton.Checked = true;
			this.downRadioButton.Location = new global::System.Drawing.Point(110, 19);
			this.downRadioButton.Name = "downRadioButton";
			this.downRadioButton.Size = new global::System.Drawing.Size(84, 27);
			this.downRadioButton.TabIndex = 1;
			this.downRadioButton.TabStop = true;
			this.downRadioButton.Text = "Down";
			this.downRadioButton.UseVisualStyleBackColor = true;
			this.upRadioButton.Location = new global::System.Drawing.Point(13, 19);
			this.upRadioButton.Name = "upRadioButton";
			this.upRadioButton.Size = new global::System.Drawing.Size(73, 27);
			this.upRadioButton.TabIndex = 0;
			this.upRadioButton.Text = "Up";
			this.upRadioButton.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(470, 169);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.matchWholeWordCheckBox);
			base.Controls.Add(this.matchCaseCheckBox);
			base.Controls.Add(this.replaceAllButton);
			base.Controls.Add(this.replaceButton);
			base.Controls.Add(this.findNextButton);
			base.Controls.Add(this.replaceWithTextBox);
			base.Controls.Add(this.findTextBox);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FindAndReplaceForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Find and Replace (ô Trung)";
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000DD RID: 221
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.RadioButton upRadioButton;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.RadioButton downRadioButton;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.CheckBox matchWholeWordCheckBox;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.CheckBox matchCaseCheckBox;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Button replaceAllButton;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Button replaceButton;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Button findNextButton;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.TextBox replaceWithTextBox;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.TextBox findTextBox;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Label label1;
	}
}

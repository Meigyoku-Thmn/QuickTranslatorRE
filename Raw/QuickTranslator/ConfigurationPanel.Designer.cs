namespace QuickTranslator
{
	// Token: 0x02000003 RID: 3
	public partial class ConfigurationPanel : global::WeifenLuo.WinFormsUI.Docking.DockContent
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00003174 File Offset: 0x00002174
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003194 File Offset: 0x00002194
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::QuickTranslator.ConfigurationPanel));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.browserPanel_DisablePopupsCheckBox = new global::System.Windows.Forms.CheckBox();
			this.browserPanel_DisableImagesCheckBox = new global::System.Windows.Forms.CheckBox();
			this.saveButton = new global::System.Windows.Forms.Button();
			this.cancelButton = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.vietPhrase_AlwaysWrapExceptHanVietRadioButton = new global::System.Windows.Forms.RadioButton();
			this.vietPhrase_OnlyWrapTwoMeaningRadioButton = new global::System.Windows.Forms.RadioButton();
			this.vietPhrase_AlwaysWrapRadioButton = new global::System.Windows.Forms.RadioButton();
			this.vietPhrase_NoWrapRadioButton = new global::System.Windows.Forms.RadioButton();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton = new global::System.Windows.Forms.RadioButton();
			this.vietPhraseOneMeaning_NoWrapRadioButton = new global::System.Windows.Forms.RadioButton();
			this.vietPhraseOneMeaning_AlwaysWrapRadioButton = new global::System.Windows.Forms.RadioButton();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.hotKeys_CopyMeaning6TextBox = new global::System.Windows.Forms.TextBox();
			this.label23 = new global::System.Windows.Forms.Label();
			this.label24 = new global::System.Windows.Forms.Label();
			this.f9TextBox = new global::System.Windows.Forms.TextBox();
			this.f7TextBox = new global::System.Windows.Forms.TextBox();
			this.f5TextBox = new global::System.Windows.Forms.TextBox();
			this.f3TextBox = new global::System.Windows.Forms.TextBox();
			this.f8TextBox = new global::System.Windows.Forms.TextBox();
			this.f6TextBox = new global::System.Windows.Forms.TextBox();
			this.f4TextBox = new global::System.Windows.Forms.TextBox();
			this.f2TextBox = new global::System.Windows.Forms.TextBox();
			this.f1TextBox = new global::System.Windows.Forms.TextBox();
			this.hotKeys_CopyMeaning5TextBox = new global::System.Windows.Forms.TextBox();
			this.label21 = new global::System.Windows.Forms.Label();
			this.label33 = new global::System.Windows.Forms.Label();
			this.label32 = new global::System.Windows.Forms.Label();
			this.label31 = new global::System.Windows.Forms.Label();
			this.label30 = new global::System.Windows.Forms.Label();
			this.label29 = new global::System.Windows.Forms.Label();
			this.label28 = new global::System.Windows.Forms.Label();
			this.label27 = new global::System.Windows.Forms.Label();
			this.label26 = new global::System.Windows.Forms.Label();
			this.label25 = new global::System.Windows.Forms.Label();
			this.label22 = new global::System.Windows.Forms.Label();
			this.hotKeys_CopyMeaning4TextBox = new global::System.Windows.Forms.TextBox();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.hotKeys_CopyMeaning3TextBox = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label18 = new global::System.Windows.Forms.Label();
			this.hotKeys_CopyMeaning2TextBox = new global::System.Windows.Forms.TextBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.hotKeys_CopyHighlightedHanVietTextBox = new global::System.Windows.Forms.TextBox();
			this.hotKeys_CopyMeaning1TextBox = new global::System.Windows.Forms.TextBox();
			this.label35 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label34 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.hotKeys_MoveUpOneParagraphTextBox = new global::System.Windows.Forms.TextBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.hotKeys_MoveDownOneParagraphTextBox = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.hotKeys_MoveUpOneLineTextBox = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.hotKeys_MoveDownOneLineTextBox = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.hotKeys_MoveLeftOneWordTextBox = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.hotKeys_MoveRightOneWordTextBox = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.translateTabPage = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.prioritizedNameCheckBox = new global::System.Windows.Forms.CheckBox();
			this.algorithm_LeftToRightRadioButton = new global::System.Windows.Forms.RadioButton();
			this.algorithm_LongestVietPhraseFirstWithConditionRadioButton = new global::System.Windows.Forms.RadioButton();
			this.algorithm_LongestVietPhraseFirstRadioButton = new global::System.Windows.Forms.RadioButton();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.alwaysFocusInVietCheckBox = new global::System.Windows.Forms.CheckBox();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.nghiaBackColorButton = new global::System.Windows.Forms.Button();
			this.trungLabel = new global::System.Windows.Forms.Label();
			this.vietBackColorButton = new global::System.Windows.Forms.Button();
			this.hanVietLabel = new global::System.Windows.Forms.Label();
			this.vietPhraseOneMeaningBackColorButton = new global::System.Windows.Forms.Button();
			this.vietPhraseLabel = new global::System.Windows.Forms.Label();
			this.vietPhraseBackColorButton = new global::System.Windows.Forms.Button();
			this.vietPhraseOneMeaningLabel = new global::System.Windows.Forms.Label();
			this.hanVietBackColorButton = new global::System.Windows.Forms.Button();
			this.vietLabel = new global::System.Windows.Forms.Label();
			this.trungBackColorButton = new global::System.Windows.Forms.Button();
			this.nghiaLabel = new global::System.Windows.Forms.Label();
			this.nghiaFontButton = new global::System.Windows.Forms.Button();
			this.trungFontButton = new global::System.Windows.Forms.Button();
			this.vietFontButton = new global::System.Windows.Forms.Button();
			this.hanVietFontButton = new global::System.Windows.Forms.Button();
			this.vietPhraseOneMeaningFontButton = new global::System.Windows.Forms.Button();
			this.vietPhraseFontButton = new global::System.Windows.Forms.Button();
			this.colorDialog = new global::System.Windows.Forms.ColorDialog();
			this.fontDialog = new global::System.Windows.Forms.FontDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.translateTabPage.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.browserPanel_DisablePopupsCheckBox);
			this.groupBox1.Controls.Add(this.browserPanel_DisableImagesCheckBox);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new global::System.Drawing.Point(0, 592);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(129, 38);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Browser Panel";
			this.groupBox1.Visible = false;
			this.browserPanel_DisablePopupsCheckBox.Checked = true;
			this.browserPanel_DisablePopupsCheckBox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.browserPanel_DisablePopupsCheckBox.Location = new global::System.Drawing.Point(6, 37);
			this.browserPanel_DisablePopupsCheckBox.Name = "browserPanel_DisablePopupsCheckBox";
			this.browserPanel_DisablePopupsCheckBox.Size = new global::System.Drawing.Size(118, 24);
			this.browserPanel_DisablePopupsCheckBox.TabIndex = 2;
			this.browserPanel_DisablePopupsCheckBox.Text = "Disable Pop-ups";
			this.browserPanel_DisablePopupsCheckBox.UseVisualStyleBackColor = true;
			this.browserPanel_DisableImagesCheckBox.Checked = true;
			this.browserPanel_DisableImagesCheckBox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.browserPanel_DisableImagesCheckBox.Location = new global::System.Drawing.Point(8, 8);
			this.browserPanel_DisableImagesCheckBox.Name = "browserPanel_DisableImagesCheckBox";
			this.browserPanel_DisableImagesCheckBox.Size = new global::System.Drawing.Size(102, 24);
			this.browserPanel_DisableImagesCheckBox.TabIndex = 1;
			this.browserPanel_DisableImagesCheckBox.Text = "Disable Images";
			this.browserPanel_DisableImagesCheckBox.UseVisualStyleBackColor = true;
			this.saveButton.Location = new global::System.Drawing.Point(192, 600);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new global::System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 20;
			this.saveButton.Text = "&Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new global::System.EventHandler(this.SaveButtonClick);
			this.cancelButton.Location = new global::System.Drawing.Point(288, 600);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new global::System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 21;
			this.cancelButton.Text = "&Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new global::System.EventHandler(this.CancelButtonClick);
			this.groupBox2.Controls.Add(this.vietPhrase_AlwaysWrapExceptHanVietRadioButton);
			this.groupBox2.Controls.Add(this.vietPhrase_OnlyWrapTwoMeaningRadioButton);
			this.groupBox2.Controls.Add(this.vietPhrase_AlwaysWrapRadioButton);
			this.groupBox2.Controls.Add(this.vietPhrase_NoWrapRadioButton);
			this.groupBox2.Location = new global::System.Drawing.Point(8, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(264, 126);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "VietPhrase";
			this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.AutoSize = true;
			this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Location = new global::System.Drawing.Point(6, 75);
			this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Name = "vietPhrase_AlwaysWrapExceptHanVietRadioButton";
			this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Size = new global::System.Drawing.Size(179, 17);
			this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.TabIndex = 6;
			this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.TabStop = true;
			this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Text = "Luôn sử dụng [ ... ] (trừ Hán Việt)";
			this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.UseVisualStyleBackColor = true;
			this.vietPhrase_OnlyWrapTwoMeaningRadioButton.Location = new global::System.Drawing.Point(6, 96);
			this.vietPhrase_OnlyWrapTwoMeaningRadioButton.Name = "vietPhrase_OnlyWrapTwoMeaningRadioButton";
			this.vietPhrase_OnlyWrapTwoMeaningRadioButton.Size = new global::System.Drawing.Size(219, 24);
			this.vietPhrase_OnlyWrapTwoMeaningRadioButton.TabIndex = 5;
			this.vietPhrase_OnlyWrapTwoMeaningRadioButton.TabStop = true;
			this.vietPhrase_OnlyWrapTwoMeaningRadioButton.Text = "Chỉ sử dụng [ ... ] nếu có hơn một nghĩa";
			this.vietPhrase_OnlyWrapTwoMeaningRadioButton.UseVisualStyleBackColor = true;
			this.vietPhrase_OnlyWrapTwoMeaningRadioButton.CheckedChanged += new global::System.EventHandler(this.VietPhrase_OnlyWrapTwoMeaningRadioButtonCheckedChanged);
			this.vietPhrase_AlwaysWrapRadioButton.Location = new global::System.Drawing.Point(6, 47);
			this.vietPhrase_AlwaysWrapRadioButton.Name = "vietPhrase_AlwaysWrapRadioButton";
			this.vietPhrase_AlwaysWrapRadioButton.Size = new global::System.Drawing.Size(219, 24);
			this.vietPhrase_AlwaysWrapRadioButton.TabIndex = 4;
			this.vietPhrase_AlwaysWrapRadioButton.TabStop = true;
			this.vietPhrase_AlwaysWrapRadioButton.Text = "Luôn sử dụng [ ... ] (cả Hán Việt)";
			this.vietPhrase_AlwaysWrapRadioButton.UseVisualStyleBackColor = true;
			this.vietPhrase_AlwaysWrapRadioButton.CheckedChanged += new global::System.EventHandler(this.VietPhrase_AlwaysWrapRadioButtonCheckedChanged);
			this.vietPhrase_NoWrapRadioButton.Location = new global::System.Drawing.Point(6, 19);
			this.vietPhrase_NoWrapRadioButton.Name = "vietPhrase_NoWrapRadioButton";
			this.vietPhrase_NoWrapRadioButton.Size = new global::System.Drawing.Size(219, 24);
			this.vietPhrase_NoWrapRadioButton.TabIndex = 3;
			this.vietPhrase_NoWrapRadioButton.TabStop = true;
			this.vietPhrase_NoWrapRadioButton.Text = "Không sử dụng [ ... ]";
			this.vietPhrase_NoWrapRadioButton.UseVisualStyleBackColor = true;
			this.vietPhrase_NoWrapRadioButton.CheckedChanged += new global::System.EventHandler(this.VietPhrase_NoWrapRadioButtonCheckedChanged);
			this.groupBox3.Controls.Add(this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton);
			this.groupBox3.Controls.Add(this.vietPhraseOneMeaning_NoWrapRadioButton);
			this.groupBox3.Controls.Add(this.vietPhraseOneMeaning_AlwaysWrapRadioButton);
			this.groupBox3.Location = new global::System.Drawing.Point(280, 88);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(256, 126);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "VietPhrase một nghĩa";
			this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.AutoSize = true;
			this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Location = new global::System.Drawing.Point(6, 73);
			this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Name = "vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton";
			this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Size = new global::System.Drawing.Size(179, 17);
			this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.TabIndex = 6;
			this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.TabStop = true;
			this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Text = "Luôn sử dụng [ ... ] (trừ Hán Việt)";
			this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.UseVisualStyleBackColor = true;
			this.vietPhraseOneMeaning_NoWrapRadioButton.Location = new global::System.Drawing.Point(6, 19);
			this.vietPhraseOneMeaning_NoWrapRadioButton.Name = "vietPhraseOneMeaning_NoWrapRadioButton";
			this.vietPhraseOneMeaning_NoWrapRadioButton.Size = new global::System.Drawing.Size(179, 24);
			this.vietPhraseOneMeaning_NoWrapRadioButton.TabIndex = 6;
			this.vietPhraseOneMeaning_NoWrapRadioButton.TabStop = true;
			this.vietPhraseOneMeaning_NoWrapRadioButton.Text = "Không sử dụng [ ... ]";
			this.vietPhraseOneMeaning_NoWrapRadioButton.UseVisualStyleBackColor = true;
			this.vietPhraseOneMeaning_NoWrapRadioButton.CheckedChanged += new global::System.EventHandler(this.VietPhraseOneMeaning_NoWrapRadioButtonCheckedChanged);
			this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Location = new global::System.Drawing.Point(6, 46);
			this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Name = "vietPhraseOneMeaning_AlwaysWrapRadioButton";
			this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Size = new global::System.Drawing.Size(179, 24);
			this.vietPhraseOneMeaning_AlwaysWrapRadioButton.TabIndex = 7;
			this.vietPhraseOneMeaning_AlwaysWrapRadioButton.TabStop = true;
			this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Text = "Luôn sử dụng [ ... ] (cả Hán Việt)";
			this.vietPhraseOneMeaning_AlwaysWrapRadioButton.UseVisualStyleBackColor = true;
			this.vietPhraseOneMeaning_AlwaysWrapRadioButton.CheckedChanged += new global::System.EventHandler(this.VietPhraseOneMeaning_AlwaysWrapRadioButtonCheckedChanged);
			this.groupBox4.Controls.Add(this.hotKeys_CopyMeaning6TextBox);
			this.groupBox4.Controls.Add(this.label23);
			this.groupBox4.Controls.Add(this.label24);
			this.groupBox4.Controls.Add(this.f9TextBox);
			this.groupBox4.Controls.Add(this.f7TextBox);
			this.groupBox4.Controls.Add(this.f5TextBox);
			this.groupBox4.Controls.Add(this.f3TextBox);
			this.groupBox4.Controls.Add(this.f8TextBox);
			this.groupBox4.Controls.Add(this.f6TextBox);
			this.groupBox4.Controls.Add(this.f4TextBox);
			this.groupBox4.Controls.Add(this.f2TextBox);
			this.groupBox4.Controls.Add(this.f1TextBox);
			this.groupBox4.Controls.Add(this.hotKeys_CopyMeaning5TextBox);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.Controls.Add(this.label33);
			this.groupBox4.Controls.Add(this.label32);
			this.groupBox4.Controls.Add(this.label31);
			this.groupBox4.Controls.Add(this.label30);
			this.groupBox4.Controls.Add(this.label29);
			this.groupBox4.Controls.Add(this.label28);
			this.groupBox4.Controls.Add(this.label27);
			this.groupBox4.Controls.Add(this.label26);
			this.groupBox4.Controls.Add(this.label25);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.Controls.Add(this.hotKeys_CopyMeaning4TextBox);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Controls.Add(this.hotKeys_CopyMeaning3TextBox);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.hotKeys_CopyMeaning2TextBox);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.hotKeys_CopyHighlightedHanVietTextBox);
			this.groupBox4.Controls.Add(this.hotKeys_CopyMeaning1TextBox);
			this.groupBox4.Controls.Add(this.label35);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label34);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.hotKeys_MoveUpOneParagraphTextBox);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.hotKeys_MoveDownOneParagraphTextBox);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.hotKeys_MoveUpOneLineTextBox);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.hotKeys_MoveDownOneLineTextBox);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.hotKeys_MoveLeftOneWordTextBox);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.hotKeys_MoveRightOneWordTextBox);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Location = new global::System.Drawing.Point(8, 224);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(528, 328);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Hot Keys";
			this.hotKeys_CopyMeaning6TextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_CopyMeaning6TextBox.Location = new global::System.Drawing.Point(394, 168);
			this.hotKeys_CopyMeaning6TextBox.MaxLength = 1;
			this.hotKeys_CopyMeaning6TextBox.Name = "hotKeys_CopyMeaning6TextBox";
			this.hotKeys_CopyMeaning6TextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_CopyMeaning6TextBox.TabIndex = 19;
			this.hotKeys_CopyMeaning6TextBox.Text = "6";
			this.hotKeys_CopyMeaning6TextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label23.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label23.Location = new global::System.Drawing.Point(355, 166);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(44, 23);
			this.label23.TabIndex = 33;
			this.label23.Text = "Ctrl + ";
			this.label23.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label24.Location = new global::System.Drawing.Point(233, 166);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(116, 23);
			this.label24.TabIndex = 32;
			this.label24.Text = "Copy nghĩa thứ 6:";
			this.label24.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.f9TextBox.Location = new global::System.Drawing.Point(139, 296);
			this.f9TextBox.MaxLength = 0;
			this.f9TextBox.Name = "f9TextBox";
			this.f9TextBox.Size = new global::System.Drawing.Size(163, 20);
			this.f9TextBox.TabIndex = 28;
			this.f7TextBox.Location = new global::System.Drawing.Point(139, 275);
			this.f7TextBox.MaxLength = 0;
			this.f7TextBox.Name = "f7TextBox";
			this.f7TextBox.Size = new global::System.Drawing.Size(163, 20);
			this.f7TextBox.TabIndex = 26;
			this.f5TextBox.Location = new global::System.Drawing.Point(139, 252);
			this.f5TextBox.MaxLength = 0;
			this.f5TextBox.Name = "f5TextBox";
			this.f5TextBox.Size = new global::System.Drawing.Size(163, 20);
			this.f5TextBox.TabIndex = 24;
			this.f3TextBox.Location = new global::System.Drawing.Point(139, 229);
			this.f3TextBox.MaxLength = 0;
			this.f3TextBox.Name = "f3TextBox";
			this.f3TextBox.Size = new global::System.Drawing.Size(163, 20);
			this.f3TextBox.TabIndex = 22;
			this.f8TextBox.Location = new global::System.Drawing.Point(355, 275);
			this.f8TextBox.MaxLength = 0;
			this.f8TextBox.Name = "f8TextBox";
			this.f8TextBox.Size = new global::System.Drawing.Size(163, 20);
			this.f8TextBox.TabIndex = 27;
			this.f6TextBox.Location = new global::System.Drawing.Point(355, 252);
			this.f6TextBox.MaxLength = 0;
			this.f6TextBox.Name = "f6TextBox";
			this.f6TextBox.Size = new global::System.Drawing.Size(163, 20);
			this.f6TextBox.TabIndex = 25;
			this.f4TextBox.Location = new global::System.Drawing.Point(355, 229);
			this.f4TextBox.MaxLength = 0;
			this.f4TextBox.Name = "f4TextBox";
			this.f4TextBox.Size = new global::System.Drawing.Size(163, 20);
			this.f4TextBox.TabIndex = 23;
			this.f2TextBox.Location = new global::System.Drawing.Point(355, 204);
			this.f2TextBox.MaxLength = 0;
			this.f2TextBox.Name = "f2TextBox";
			this.f2TextBox.Size = new global::System.Drawing.Size(163, 20);
			this.f2TextBox.TabIndex = 21;
			this.f1TextBox.Location = new global::System.Drawing.Point(139, 205);
			this.f1TextBox.MaxLength = 0;
			this.f1TextBox.Name = "f1TextBox";
			this.f1TextBox.Size = new global::System.Drawing.Size(163, 20);
			this.f1TextBox.TabIndex = 20;
			this.hotKeys_CopyMeaning5TextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_CopyMeaning5TextBox.Location = new global::System.Drawing.Point(175, 166);
			this.hotKeys_CopyMeaning5TextBox.MaxLength = 1;
			this.hotKeys_CopyMeaning5TextBox.Name = "hotKeys_CopyMeaning5TextBox";
			this.hotKeys_CopyMeaning5TextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_CopyMeaning5TextBox.TabIndex = 18;
			this.hotKeys_CopyMeaning5TextBox.Text = "5";
			this.hotKeys_CopyMeaning5TextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label21.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label21.Location = new global::System.Drawing.Point(136, 164);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(44, 23);
			this.label21.TabIndex = 30;
			this.label21.Text = "Ctrl + ";
			this.label21.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label33.Location = new global::System.Drawing.Point(233, 273);
			this.label33.Name = "label33";
			this.label33.Size = new global::System.Drawing.Size(116, 23);
			this.label33.TabIndex = 29;
			this.label33.Text = "F8:";
			this.label33.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label32.Location = new global::System.Drawing.Point(233, 250);
			this.label32.Name = "label32";
			this.label32.Size = new global::System.Drawing.Size(116, 23);
			this.label32.TabIndex = 29;
			this.label32.Text = "F6:";
			this.label32.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label31.Location = new global::System.Drawing.Point(233, 227);
			this.label31.Name = "label31";
			this.label31.Size = new global::System.Drawing.Size(116, 23);
			this.label31.TabIndex = 29;
			this.label31.Text = "F4:";
			this.label31.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label30.Location = new global::System.Drawing.Point(233, 204);
			this.label30.Name = "label30";
			this.label30.Size = new global::System.Drawing.Size(116, 23);
			this.label30.TabIndex = 29;
			this.label30.Text = "F2:";
			this.label30.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label29.Location = new global::System.Drawing.Point(14, 296);
			this.label29.Name = "label29";
			this.label29.Size = new global::System.Drawing.Size(116, 23);
			this.label29.TabIndex = 29;
			this.label29.Text = "F9:";
			this.label29.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label28.Location = new global::System.Drawing.Point(14, 273);
			this.label28.Name = "label28";
			this.label28.Size = new global::System.Drawing.Size(116, 23);
			this.label28.TabIndex = 29;
			this.label28.Text = "F7:";
			this.label28.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label27.Location = new global::System.Drawing.Point(14, 250);
			this.label27.Name = "label27";
			this.label27.Size = new global::System.Drawing.Size(116, 23);
			this.label27.TabIndex = 29;
			this.label27.Text = "F5:";
			this.label27.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label26.Location = new global::System.Drawing.Point(14, 227);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(116, 23);
			this.label26.TabIndex = 29;
			this.label26.Text = "F3:";
			this.label26.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label25.Location = new global::System.Drawing.Point(14, 204);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(116, 23);
			this.label25.TabIndex = 29;
			this.label25.Text = "F1:";
			this.label25.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label22.Location = new global::System.Drawing.Point(14, 164);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(116, 23);
			this.label22.TabIndex = 29;
			this.label22.Text = "Copy nghĩa thứ 5:";
			this.label22.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hotKeys_CopyMeaning4TextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_CopyMeaning4TextBox.Location = new global::System.Drawing.Point(394, 145);
			this.hotKeys_CopyMeaning4TextBox.MaxLength = 1;
			this.hotKeys_CopyMeaning4TextBox.Name = "hotKeys_CopyMeaning4TextBox";
			this.hotKeys_CopyMeaning4TextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_CopyMeaning4TextBox.TabIndex = 17;
			this.hotKeys_CopyMeaning4TextBox.Text = "4";
			this.hotKeys_CopyMeaning4TextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label19.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label19.Location = new global::System.Drawing.Point(355, 143);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(44, 23);
			this.label19.TabIndex = 27;
			this.label19.Text = "Ctrl + ";
			this.label19.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label20.Location = new global::System.Drawing.Point(233, 143);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(116, 23);
			this.label20.TabIndex = 26;
			this.label20.Text = "Copy nghĩa thứ 4:";
			this.label20.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hotKeys_CopyMeaning3TextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_CopyMeaning3TextBox.Location = new global::System.Drawing.Point(175, 143);
			this.hotKeys_CopyMeaning3TextBox.MaxLength = 1;
			this.hotKeys_CopyMeaning3TextBox.Name = "hotKeys_CopyMeaning3TextBox";
			this.hotKeys_CopyMeaning3TextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_CopyMeaning3TextBox.TabIndex = 16;
			this.hotKeys_CopyMeaning3TextBox.Text = "3";
			this.hotKeys_CopyMeaning3TextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label17.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.Location = new global::System.Drawing.Point(136, 141);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(44, 23);
			this.label17.TabIndex = 24;
			this.label17.Text = "Ctrl + ";
			this.label17.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label18.Location = new global::System.Drawing.Point(14, 141);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(116, 23);
			this.label18.TabIndex = 23;
			this.label18.Text = "Copy nghĩa thứ 3:";
			this.label18.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hotKeys_CopyMeaning2TextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_CopyMeaning2TextBox.Location = new global::System.Drawing.Point(394, 122);
			this.hotKeys_CopyMeaning2TextBox.MaxLength = 1;
			this.hotKeys_CopyMeaning2TextBox.Name = "hotKeys_CopyMeaning2TextBox";
			this.hotKeys_CopyMeaning2TextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_CopyMeaning2TextBox.TabIndex = 15;
			this.hotKeys_CopyMeaning2TextBox.Text = "2";
			this.hotKeys_CopyMeaning2TextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label15.Location = new global::System.Drawing.Point(355, 120);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(44, 23);
			this.label15.TabIndex = 21;
			this.label15.Text = "Ctrl + ";
			this.label15.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label16.Location = new global::System.Drawing.Point(233, 120);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(116, 23);
			this.label16.TabIndex = 20;
			this.label16.Text = "Copy nghĩa thứ 2:";
			this.label16.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hotKeys_CopyHighlightedHanVietTextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_CopyHighlightedHanVietTextBox.Location = new global::System.Drawing.Point(394, 98);
			this.hotKeys_CopyHighlightedHanVietTextBox.MaxLength = 1;
			this.hotKeys_CopyHighlightedHanVietTextBox.Name = "hotKeys_CopyHighlightedHanVietTextBox";
			this.hotKeys_CopyHighlightedHanVietTextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_CopyHighlightedHanVietTextBox.TabIndex = 14;
			this.hotKeys_CopyHighlightedHanVietTextBox.Text = "0";
			this.hotKeys_CopyHighlightedHanVietTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.hotKeys_CopyMeaning1TextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_CopyMeaning1TextBox.Location = new global::System.Drawing.Point(175, 120);
			this.hotKeys_CopyMeaning1TextBox.MaxLength = 1;
			this.hotKeys_CopyMeaning1TextBox.Name = "hotKeys_CopyMeaning1TextBox";
			this.hotKeys_CopyMeaning1TextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_CopyMeaning1TextBox.TabIndex = 14;
			this.hotKeys_CopyMeaning1TextBox.Text = "1";
			this.hotKeys_CopyMeaning1TextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label35.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label35.Location = new global::System.Drawing.Point(355, 96);
			this.label35.Name = "label35";
			this.label35.Size = new global::System.Drawing.Size(44, 23);
			this.label35.TabIndex = 18;
			this.label35.Text = "Ctrl + ";
			this.label35.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label13.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.Location = new global::System.Drawing.Point(136, 118);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(44, 23);
			this.label13.TabIndex = 18;
			this.label13.Text = "Ctrl + ";
			this.label13.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label34.Location = new global::System.Drawing.Point(208, 96);
			this.label34.Name = "label34";
			this.label34.Size = new global::System.Drawing.Size(141, 23);
			this.label34.TabIndex = 17;
			this.label34.Text = "Copy cụm Hán Việt bôi đỏ:";
			this.label34.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label14.Location = new global::System.Drawing.Point(14, 118);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(116, 23);
			this.label14.TabIndex = 17;
			this.label14.Text = "Copy nghĩa thứ 1:";
			this.label14.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hotKeys_MoveUpOneParagraphTextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_MoveUpOneParagraphTextBox.Location = new global::System.Drawing.Point(175, 60);
			this.hotKeys_MoveUpOneParagraphTextBox.MaxLength = 1;
			this.hotKeys_MoveUpOneParagraphTextBox.Name = "hotKeys_MoveUpOneParagraphTextBox";
			this.hotKeys_MoveUpOneParagraphTextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_MoveUpOneParagraphTextBox.TabIndex = 12;
			this.hotKeys_MoveUpOneParagraphTextBox.Text = "U";
			this.hotKeys_MoveUpOneParagraphTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(136, 58);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(44, 23);
			this.label11.TabIndex = 15;
			this.label11.Text = "Ctrl + ";
			this.label11.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label12.Location = new global::System.Drawing.Point(14, 58);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(116, 23);
			this.label12.TabIndex = 14;
			this.label12.Text = "Move Up 1 Paragraph:";
			this.label12.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hotKeys_MoveDownOneParagraphTextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_MoveDownOneParagraphTextBox.Location = new global::System.Drawing.Point(394, 64);
			this.hotKeys_MoveDownOneParagraphTextBox.MaxLength = 1;
			this.hotKeys_MoveDownOneParagraphTextBox.Name = "hotKeys_MoveDownOneParagraphTextBox";
			this.hotKeys_MoveDownOneParagraphTextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_MoveDownOneParagraphTextBox.TabIndex = 13;
			this.hotKeys_MoveDownOneParagraphTextBox.Text = "N";
			this.hotKeys_MoveDownOneParagraphTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.Location = new global::System.Drawing.Point(355, 62);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(44, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "Ctrl + ";
			this.label9.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label10.Location = new global::System.Drawing.Point(219, 62);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(130, 23);
			this.label10.TabIndex = 11;
			this.label10.Text = "Move Down 1 Paragraph:";
			this.label10.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hotKeys_MoveUpOneLineTextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_MoveUpOneLineTextBox.Location = new global::System.Drawing.Point(175, 37);
			this.hotKeys_MoveUpOneLineTextBox.MaxLength = 1;
			this.hotKeys_MoveUpOneLineTextBox.Name = "hotKeys_MoveUpOneLineTextBox";
			this.hotKeys_MoveUpOneLineTextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_MoveUpOneLineTextBox.TabIndex = 10;
			this.hotKeys_MoveUpOneLineTextBox.Text = "I";
			this.hotKeys_MoveUpOneLineTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(136, 35);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(44, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "Ctrl + ";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label8.Location = new global::System.Drawing.Point(14, 35);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(116, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Move Up 1 Line:";
			this.label8.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hotKeys_MoveDownOneLineTextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_MoveDownOneLineTextBox.Location = new global::System.Drawing.Point(394, 39);
			this.hotKeys_MoveDownOneLineTextBox.MaxLength = 1;
			this.hotKeys_MoveDownOneLineTextBox.Name = "hotKeys_MoveDownOneLineTextBox";
			this.hotKeys_MoveDownOneLineTextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_MoveDownOneLineTextBox.TabIndex = 11;
			this.hotKeys_MoveDownOneLineTextBox.Text = "M";
			this.hotKeys_MoveDownOneLineTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(355, 37);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(44, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Ctrl + ";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label6.Location = new global::System.Drawing.Point(233, 37);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(116, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Move Down 1 Line:";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hotKeys_MoveLeftOneWordTextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_MoveLeftOneWordTextBox.Location = new global::System.Drawing.Point(175, 13);
			this.hotKeys_MoveLeftOneWordTextBox.MaxLength = 1;
			this.hotKeys_MoveLeftOneWordTextBox.Name = "hotKeys_MoveLeftOneWordTextBox";
			this.hotKeys_MoveLeftOneWordTextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_MoveLeftOneWordTextBox.TabIndex = 8;
			this.hotKeys_MoveLeftOneWordTextBox.Text = "J";
			this.hotKeys_MoveLeftOneWordTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(136, 11);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(44, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ctrl + ";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Location = new global::System.Drawing.Point(14, 11);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(116, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Move Left 1 Word:";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.hotKeys_MoveRightOneWordTextBox.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.hotKeys_MoveRightOneWordTextBox.Location = new global::System.Drawing.Point(394, 14);
			this.hotKeys_MoveRightOneWordTextBox.MaxLength = 1;
			this.hotKeys_MoveRightOneWordTextBox.Name = "hotKeys_MoveRightOneWordTextBox";
			this.hotKeys_MoveRightOneWordTextBox.Size = new global::System.Drawing.Size(32, 20);
			this.hotKeys_MoveRightOneWordTextBox.TabIndex = 9;
			this.hotKeys_MoveRightOneWordTextBox.Text = "K";
			this.hotKeys_MoveRightOneWordTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(355, 12);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(44, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Ctrl + ";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new global::System.Drawing.Point(233, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(116, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Move Right 1 Word:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.translateTabPage.Controls.Add(this.tabPage1);
			this.translateTabPage.Controls.Add(this.tabPage2);
			this.translateTabPage.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.translateTabPage.Location = new global::System.Drawing.Point(0, 0);
			this.translateTabPage.Name = "translateTabPage";
			this.translateTabPage.SelectedIndex = 0;
			this.translateTabPage.Size = new global::System.Drawing.Size(556, 584);
			this.translateTabPage.TabIndex = 22;
			this.tabPage1.Controls.Add(this.groupBox5);
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(548, 558);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Translation";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.groupBox5.Controls.Add(this.prioritizedNameCheckBox);
			this.groupBox5.Controls.Add(this.algorithm_LeftToRightRadioButton);
			this.groupBox5.Controls.Add(this.algorithm_LongestVietPhraseFirstWithConditionRadioButton);
			this.groupBox5.Controls.Add(this.algorithm_LongestVietPhraseFirstRadioButton);
			this.groupBox5.Location = new global::System.Drawing.Point(8, 8);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(528, 72);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Thuật Toán Dịch";
			this.prioritizedNameCheckBox.Location = new global::System.Drawing.Point(272, 40);
			this.prioritizedNameCheckBox.Name = "prioritizedNameCheckBox";
			this.prioritizedNameCheckBox.Size = new global::System.Drawing.Size(172, 24);
			this.prioritizedNameCheckBox.TabIndex = 1;
			this.prioritizedNameCheckBox.Text = "Ưu tiên Name hơn VietPhrase";
			this.prioritizedNameCheckBox.UseVisualStyleBackColor = true;
			this.prioritizedNameCheckBox.CheckedChanged += new global::System.EventHandler(this.PrioritizedNameCheckBoxCheckedChanged);
			this.algorithm_LeftToRightRadioButton.Location = new global::System.Drawing.Point(272, 16);
			this.algorithm_LeftToRightRadioButton.Name = "algorithm_LeftToRightRadioButton";
			this.algorithm_LeftToRightRadioButton.Size = new global::System.Drawing.Size(232, 24);
			this.algorithm_LeftToRightRadioButton.TabIndex = 0;
			this.algorithm_LeftToRightRadioButton.TabStop = true;
			this.algorithm_LeftToRightRadioButton.Text = "Dịch từ trái sang phải";
			this.algorithm_LeftToRightRadioButton.UseVisualStyleBackColor = true;
			this.algorithm_LeftToRightRadioButton.CheckedChanged += new global::System.EventHandler(this.Algorithm_LeftToRightRadioButtonCheckedChanged);
			this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.Location = new global::System.Drawing.Point(8, 40);
			this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.Name = "algorithm_LongestVietPhraseFirstWithConditionRadioButton";
			this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.Size = new global::System.Drawing.Size(232, 24);
			this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.TabIndex = 0;
			this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.TabStop = true;
			this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.Text = "Ưu tiên cụm VietPhrase dài (>= 4 từ)";
			this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.UseVisualStyleBackColor = true;
			this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.CheckedChanged += new global::System.EventHandler(this.Algorithm_LongestVietPhraseFirstWithConditionRadioButtonCheckedChanged);
			this.algorithm_LongestVietPhraseFirstRadioButton.Location = new global::System.Drawing.Point(8, 16);
			this.algorithm_LongestVietPhraseFirstRadioButton.Name = "algorithm_LongestVietPhraseFirstRadioButton";
			this.algorithm_LongestVietPhraseFirstRadioButton.Size = new global::System.Drawing.Size(232, 24);
			this.algorithm_LongestVietPhraseFirstRadioButton.TabIndex = 0;
			this.algorithm_LongestVietPhraseFirstRadioButton.TabStop = true;
			this.algorithm_LongestVietPhraseFirstRadioButton.Text = "Ưu tiên cụm VietPhrase dài";
			this.algorithm_LongestVietPhraseFirstRadioButton.UseVisualStyleBackColor = true;
			this.algorithm_LongestVietPhraseFirstRadioButton.CheckedChanged += new global::System.EventHandler(this.Algorithm_LongestVietPhraseFirstRadioButtonCheckedChanged);
			this.tabPage2.Controls.Add(this.groupBox7);
			this.tabPage2.Controls.Add(this.groupBox6);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(548, 558);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Panel Style & Behaviors";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.groupBox7.Controls.Add(this.alwaysFocusInVietCheckBox);
			this.groupBox7.Location = new global::System.Drawing.Point(8, 392);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(528, 48);
			this.groupBox7.TabIndex = 3;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Behaviors";
			this.alwaysFocusInVietCheckBox.Location = new global::System.Drawing.Point(8, 16);
			this.alwaysFocusInVietCheckBox.Name = "alwaysFocusInVietCheckBox";
			this.alwaysFocusInVietCheckBox.Size = new global::System.Drawing.Size(208, 24);
			this.alwaysFocusInVietCheckBox.TabIndex = 0;
			this.alwaysFocusInVietCheckBox.Text = "Luôn focus vào ô Việt";
			this.alwaysFocusInVietCheckBox.UseVisualStyleBackColor = true;
			this.groupBox6.Controls.Add(this.nghiaBackColorButton);
			this.groupBox6.Controls.Add(this.trungLabel);
			this.groupBox6.Controls.Add(this.vietBackColorButton);
			this.groupBox6.Controls.Add(this.hanVietLabel);
			this.groupBox6.Controls.Add(this.vietPhraseOneMeaningBackColorButton);
			this.groupBox6.Controls.Add(this.vietPhraseLabel);
			this.groupBox6.Controls.Add(this.vietPhraseBackColorButton);
			this.groupBox6.Controls.Add(this.vietPhraseOneMeaningLabel);
			this.groupBox6.Controls.Add(this.hanVietBackColorButton);
			this.groupBox6.Controls.Add(this.vietLabel);
			this.groupBox6.Controls.Add(this.trungBackColorButton);
			this.groupBox6.Controls.Add(this.nghiaLabel);
			this.groupBox6.Controls.Add(this.nghiaFontButton);
			this.groupBox6.Controls.Add(this.trungFontButton);
			this.groupBox6.Controls.Add(this.vietFontButton);
			this.groupBox6.Controls.Add(this.hanVietFontButton);
			this.groupBox6.Controls.Add(this.vietPhraseOneMeaningFontButton);
			this.groupBox6.Controls.Add(this.vietPhraseFontButton);
			this.groupBox6.Location = new global::System.Drawing.Point(8, 8);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(528, 368);
			this.groupBox6.TabIndex = 2;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Panel Style";
			this.nghiaBackColorButton.Location = new global::System.Drawing.Point(376, 317);
			this.nghiaBackColorButton.Name = "nghiaBackColorButton";
			this.nghiaBackColorButton.Size = new global::System.Drawing.Size(75, 23);
			this.nghiaBackColorButton.TabIndex = 1;
			this.nghiaBackColorButton.Text = "Back Color";
			this.nghiaBackColorButton.UseVisualStyleBackColor = true;
			this.nghiaBackColorButton.Click += new global::System.EventHandler(this.NghiaBackColorButtonClick);
			this.trungLabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.trungLabel.Location = new global::System.Drawing.Point(72, 24);
			this.trungLabel.Name = "trungLabel";
			this.trungLabel.Size = new global::System.Drawing.Size(216, 48);
			this.trungLabel.TabIndex = 0;
			this.trungLabel.Text = "Trung";
			this.trungLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.vietBackColorButton.Location = new global::System.Drawing.Point(376, 261);
			this.vietBackColorButton.Name = "vietBackColorButton";
			this.vietBackColorButton.Size = new global::System.Drawing.Size(75, 23);
			this.vietBackColorButton.TabIndex = 1;
			this.vietBackColorButton.Text = "Back Color";
			this.vietBackColorButton.UseVisualStyleBackColor = true;
			this.vietBackColorButton.Click += new global::System.EventHandler(this.VietBackColorButtonClick);
			this.hanVietLabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.hanVietLabel.Location = new global::System.Drawing.Point(72, 80);
			this.hanVietLabel.Name = "hanVietLabel";
			this.hanVietLabel.Size = new global::System.Drawing.Size(216, 48);
			this.hanVietLabel.TabIndex = 0;
			this.hanVietLabel.Text = "Hán Việt";
			this.hanVietLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.vietPhraseOneMeaningBackColorButton.Location = new global::System.Drawing.Point(376, 205);
			this.vietPhraseOneMeaningBackColorButton.Name = "vietPhraseOneMeaningBackColorButton";
			this.vietPhraseOneMeaningBackColorButton.Size = new global::System.Drawing.Size(75, 23);
			this.vietPhraseOneMeaningBackColorButton.TabIndex = 1;
			this.vietPhraseOneMeaningBackColorButton.Text = "Back Color";
			this.vietPhraseOneMeaningBackColorButton.UseVisualStyleBackColor = true;
			this.vietPhraseOneMeaningBackColorButton.Click += new global::System.EventHandler(this.VietPhraseOneMeaningBackColorButtonClick);
			this.vietPhraseLabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.vietPhraseLabel.Location = new global::System.Drawing.Point(72, 136);
			this.vietPhraseLabel.Name = "vietPhraseLabel";
			this.vietPhraseLabel.Size = new global::System.Drawing.Size(216, 48);
			this.vietPhraseLabel.TabIndex = 0;
			this.vietPhraseLabel.Text = "VietPhrase";
			this.vietPhraseLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.vietPhraseBackColorButton.Location = new global::System.Drawing.Point(376, 149);
			this.vietPhraseBackColorButton.Name = "vietPhraseBackColorButton";
			this.vietPhraseBackColorButton.Size = new global::System.Drawing.Size(75, 23);
			this.vietPhraseBackColorButton.TabIndex = 1;
			this.vietPhraseBackColorButton.Text = "Back Color";
			this.vietPhraseBackColorButton.UseVisualStyleBackColor = true;
			this.vietPhraseBackColorButton.Click += new global::System.EventHandler(this.VietPhraseBackColorButtonClick);
			this.vietPhraseOneMeaningLabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.vietPhraseOneMeaningLabel.Location = new global::System.Drawing.Point(72, 192);
			this.vietPhraseOneMeaningLabel.Name = "vietPhraseOneMeaningLabel";
			this.vietPhraseOneMeaningLabel.Size = new global::System.Drawing.Size(216, 48);
			this.vietPhraseOneMeaningLabel.TabIndex = 0;
			this.vietPhraseOneMeaningLabel.Text = "VietPhrase Một Nghĩa";
			this.vietPhraseOneMeaningLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.hanVietBackColorButton.Location = new global::System.Drawing.Point(376, 93);
			this.hanVietBackColorButton.Name = "hanVietBackColorButton";
			this.hanVietBackColorButton.Size = new global::System.Drawing.Size(75, 23);
			this.hanVietBackColorButton.TabIndex = 1;
			this.hanVietBackColorButton.Text = "Back Color";
			this.hanVietBackColorButton.UseVisualStyleBackColor = true;
			this.hanVietBackColorButton.Click += new global::System.EventHandler(this.HanVietBackColorButtonClick);
			this.vietLabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.vietLabel.Location = new global::System.Drawing.Point(72, 248);
			this.vietLabel.Name = "vietLabel";
			this.vietLabel.Size = new global::System.Drawing.Size(216, 48);
			this.vietLabel.TabIndex = 0;
			this.vietLabel.Text = "Việt";
			this.vietLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trungBackColorButton.Location = new global::System.Drawing.Point(376, 37);
			this.trungBackColorButton.Name = "trungBackColorButton";
			this.trungBackColorButton.Size = new global::System.Drawing.Size(75, 23);
			this.trungBackColorButton.TabIndex = 1;
			this.trungBackColorButton.Text = "Back Color";
			this.trungBackColorButton.UseVisualStyleBackColor = true;
			this.trungBackColorButton.Click += new global::System.EventHandler(this.TrungBackColorButtonClick);
			this.nghiaLabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.nghiaLabel.Location = new global::System.Drawing.Point(72, 304);
			this.nghiaLabel.Name = "nghiaLabel";
			this.nghiaLabel.Size = new global::System.Drawing.Size(216, 48);
			this.nghiaLabel.TabIndex = 0;
			this.nghiaLabel.Text = "Nghĩa";
			this.nghiaLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nghiaFontButton.Location = new global::System.Drawing.Point(296, 317);
			this.nghiaFontButton.Name = "nghiaFontButton";
			this.nghiaFontButton.Size = new global::System.Drawing.Size(75, 23);
			this.nghiaFontButton.TabIndex = 1;
			this.nghiaFontButton.Text = "Font";
			this.nghiaFontButton.UseVisualStyleBackColor = true;
			this.nghiaFontButton.Click += new global::System.EventHandler(this.NghiaFontButtonClick);
			this.trungFontButton.Location = new global::System.Drawing.Point(296, 37);
			this.trungFontButton.Name = "trungFontButton";
			this.trungFontButton.Size = new global::System.Drawing.Size(75, 23);
			this.trungFontButton.TabIndex = 1;
			this.trungFontButton.Text = "Font";
			this.trungFontButton.UseVisualStyleBackColor = true;
			this.trungFontButton.Click += new global::System.EventHandler(this.TrungFontButtonClick);
			this.vietFontButton.Location = new global::System.Drawing.Point(296, 261);
			this.vietFontButton.Name = "vietFontButton";
			this.vietFontButton.Size = new global::System.Drawing.Size(75, 23);
			this.vietFontButton.TabIndex = 1;
			this.vietFontButton.Text = "Font";
			this.vietFontButton.UseVisualStyleBackColor = true;
			this.vietFontButton.Click += new global::System.EventHandler(this.VietFontButtonClick);
			this.hanVietFontButton.Location = new global::System.Drawing.Point(296, 93);
			this.hanVietFontButton.Name = "hanVietFontButton";
			this.hanVietFontButton.Size = new global::System.Drawing.Size(75, 23);
			this.hanVietFontButton.TabIndex = 1;
			this.hanVietFontButton.Text = "Font";
			this.hanVietFontButton.UseVisualStyleBackColor = true;
			this.hanVietFontButton.Click += new global::System.EventHandler(this.HanVietFontButtonClick);
			this.vietPhraseOneMeaningFontButton.Location = new global::System.Drawing.Point(296, 205);
			this.vietPhraseOneMeaningFontButton.Name = "vietPhraseOneMeaningFontButton";
			this.vietPhraseOneMeaningFontButton.Size = new global::System.Drawing.Size(75, 23);
			this.vietPhraseOneMeaningFontButton.TabIndex = 1;
			this.vietPhraseOneMeaningFontButton.Text = "Font";
			this.vietPhraseOneMeaningFontButton.UseVisualStyleBackColor = true;
			this.vietPhraseOneMeaningFontButton.Click += new global::System.EventHandler(this.VietPhraseOneMeaningFontButtonClick);
			this.vietPhraseFontButton.Location = new global::System.Drawing.Point(296, 149);
			this.vietPhraseFontButton.Name = "vietPhraseFontButton";
			this.vietPhraseFontButton.Size = new global::System.Drawing.Size(75, 23);
			this.vietPhraseFontButton.TabIndex = 1;
			this.vietPhraseFontButton.Text = "Font";
			this.vietPhraseFontButton.UseVisualStyleBackColor = true;
			this.vietPhraseFontButton.Click += new global::System.EventHandler(this.VietPhraseFontButtonClick);
			this.colorDialog.FullOpen = true;
			this.fontDialog.FontMustExist = true;
			this.fontDialog.ShowColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(556, 635);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.cancelButton);
			base.Controls.Add(this.saveButton);
			base.Controls.Add(this.translateTabPage);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "ConfigurationPanel";
			this.Text = "ConfigurationPanel";
			base.Load += new global::System.EventHandler(this.ConfigurationPanelLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.translateTabPage.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000037 RID: 55
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.CheckBox prioritizedNameCheckBox;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.CheckBox alwaysFocusInVietCheckBox;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.RadioButton algorithm_LongestVietPhraseFirstWithConditionRadioButton;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.RadioButton algorithm_LongestVietPhraseFirstRadioButton;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.RadioButton algorithm_LeftToRightRadioButton;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Button nghiaBackColorButton;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Button nghiaFontButton;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label nghiaLabel;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label vietLabel;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label vietPhraseOneMeaningLabel;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label vietPhraseLabel;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label hanVietLabel;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Button vietBackColorButton;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Button vietPhraseOneMeaningBackColorButton;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Button vietPhraseBackColorButton;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Button hanVietBackColorButton;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Button trungBackColorButton;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Button vietFontButton;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Button vietPhraseOneMeaningFontButton;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Button vietPhraseFontButton;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Button hanVietFontButton;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.FontDialog fontDialog;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.ColorDialog colorDialog;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label trungLabel;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Button trungFontButton;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.TabControl translateTabPage;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.TextBox hotKeys_CopyMeaning4TextBox;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.TextBox hotKeys_MoveRightOneWordTextBox;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.TextBox hotKeys_CopyMeaning6TextBox;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Label label14;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.TextBox hotKeys_CopyMeaning1TextBox;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Label label16;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.TextBox hotKeys_CopyMeaning2TextBox;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.TextBox hotKeys_CopyMeaning3TextBox;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.TextBox hotKeys_CopyMeaning5TextBox;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label label23;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.TextBox hotKeys_MoveUpOneLineTextBox;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.TextBox hotKeys_MoveDownOneParagraphTextBox;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.TextBox hotKeys_MoveUpOneParagraphTextBox;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.TextBox hotKeys_MoveDownOneLineTextBox;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.TextBox hotKeys_MoveLeftOneWordTextBox;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.RadioButton vietPhraseOneMeaning_AlwaysWrapRadioButton;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.RadioButton vietPhraseOneMeaning_NoWrapRadioButton;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.RadioButton vietPhrase_NoWrapRadioButton;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.RadioButton vietPhrase_OnlyWrapTwoMeaningRadioButton;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.RadioButton vietPhrase_AlwaysWrapRadioButton;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.CheckBox browserPanel_DisablePopupsCheckBox;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.CheckBox browserPanel_DisableImagesCheckBox;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Button cancelButton;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Button saveButton;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Label label26;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Label label25;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.TextBox f9TextBox;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.TextBox f7TextBox;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.TextBox f5TextBox;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.TextBox f3TextBox;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.TextBox f8TextBox;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.TextBox f6TextBox;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.TextBox f4TextBox;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.TextBox f2TextBox;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.TextBox f1TextBox;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label33;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Label label32;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.Label label31;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Label label30;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Label label28;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.RadioButton vietPhrase_AlwaysWrapExceptHanVietRadioButton;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.RadioButton vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.TextBox hotKeys_CopyHighlightedHanVietTextBox;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Label label35;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Label label34;
	}
}

namespace QuickTranslator
{
    public partial class ConfigurationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browserPanel_DisablePopupsCheckBox = new System.Windows.Forms.CheckBox();
            this.browserPanel_DisableImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton = new System.Windows.Forms.RadioButton();
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton = new System.Windows.Forms.RadioButton();
            this.vietPhrase_AlwaysWrapRadioButton = new System.Windows.Forms.RadioButton();
            this.vietPhrase_NoWrapRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton = new System.Windows.Forms.RadioButton();
            this.vietPhraseOneMeaning_NoWrapRadioButton = new System.Windows.Forms.RadioButton();
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hotKeys_CopyMeaning6TextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.f9TextBox = new System.Windows.Forms.TextBox();
            this.f7TextBox = new System.Windows.Forms.TextBox();
            this.f5TextBox = new System.Windows.Forms.TextBox();
            this.f3TextBox = new System.Windows.Forms.TextBox();
            this.f8TextBox = new System.Windows.Forms.TextBox();
            this.f6TextBox = new System.Windows.Forms.TextBox();
            this.f4TextBox = new System.Windows.Forms.TextBox();
            this.f2TextBox = new System.Windows.Forms.TextBox();
            this.f1TextBox = new System.Windows.Forms.TextBox();
            this.hotKeys_CopyMeaning5TextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.hotKeys_CopyMeaning4TextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.hotKeys_CopyMeaning3TextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.hotKeys_CopyMeaning2TextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.hotKeys_CopyHighlightedHanVietTextBox = new System.Windows.Forms.TextBox();
            this.hotKeys_CopyMeaning1TextBox = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.hotKeys_MoveUpOneParagraphTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hotKeys_MoveDownOneParagraphTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hotKeys_MoveUpOneLineTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hotKeys_MoveDownOneLineTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hotKeys_MoveLeftOneWordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hotKeys_MoveRightOneWordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.translateTabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.prioritizedNameCheckBox = new System.Windows.Forms.CheckBox();
            this.algorithm_LeftToRightRadioButton = new System.Windows.Forms.RadioButton();
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton = new System.Windows.Forms.RadioButton();
            this.algorithm_LongestVietPhraseFirstRadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.alwaysFocusInVietCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nghiaBackColorButton = new System.Windows.Forms.Button();
            this.trungLabel = new System.Windows.Forms.Label();
            this.vietBackColorButton = new System.Windows.Forms.Button();
            this.hanVietLabel = new System.Windows.Forms.Label();
            this.vietPhraseOneMeaningBackColorButton = new System.Windows.Forms.Button();
            this.vietPhraseLabel = new System.Windows.Forms.Label();
            this.vietPhraseBackColorButton = new System.Windows.Forms.Button();
            this.vietPhraseOneMeaningLabel = new System.Windows.Forms.Label();
            this.hanVietBackColorButton = new System.Windows.Forms.Button();
            this.vietLabel = new System.Windows.Forms.Label();
            this.trungBackColorButton = new System.Windows.Forms.Button();
            this.nghiaLabel = new System.Windows.Forms.Label();
            this.nghiaFontButton = new System.Windows.Forms.Button();
            this.trungFontButton = new System.Windows.Forms.Button();
            this.vietFontButton = new System.Windows.Forms.Button();
            this.hanVietFontButton = new System.Windows.Forms.Button();
            this.vietPhraseOneMeaningFontButton = new System.Windows.Forms.Button();
            this.vietPhraseFontButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
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
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browserPanel_DisablePopupsCheckBox);
            this.groupBox1.Controls.Add(this.browserPanel_DisableImagesCheckBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 592);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 38);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browser Panel";
            this.groupBox1.Visible = false;
            // 
            // browserPanel_DisablePopupsCheckBox
            // 
            this.browserPanel_DisablePopupsCheckBox.Checked = true;
            this.browserPanel_DisablePopupsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.browserPanel_DisablePopupsCheckBox.Location = new System.Drawing.Point(6, 37);
            this.browserPanel_DisablePopupsCheckBox.Name = "browserPanel_DisablePopupsCheckBox";
            this.browserPanel_DisablePopupsCheckBox.Size = new System.Drawing.Size(118, 24);
            this.browserPanel_DisablePopupsCheckBox.TabIndex = 2;
            this.browserPanel_DisablePopupsCheckBox.Text = "Disable Pop-ups";
            this.browserPanel_DisablePopupsCheckBox.UseVisualStyleBackColor = true;
            // 
            // browserPanel_DisableImagesCheckBox
            // 
            this.browserPanel_DisableImagesCheckBox.Checked = true;
            this.browserPanel_DisableImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.browserPanel_DisableImagesCheckBox.Location = new System.Drawing.Point(8, 8);
            this.browserPanel_DisableImagesCheckBox.Name = "browserPanel_DisableImagesCheckBox";
            this.browserPanel_DisableImagesCheckBox.Size = new System.Drawing.Size(102, 24);
            this.browserPanel_DisableImagesCheckBox.TabIndex = 1;
            this.browserPanel_DisableImagesCheckBox.Text = "Disable Images";
            this.browserPanel_DisableImagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(192, 600);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(288, 600);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vietPhrase_AlwaysWrapExceptHanVietRadioButton);
            this.groupBox2.Controls.Add(this.vietPhrase_OnlyWrapTwoMeaningRadioButton);
            this.groupBox2.Controls.Add(this.vietPhrase_AlwaysWrapRadioButton);
            this.groupBox2.Controls.Add(this.vietPhrase_NoWrapRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(8, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VietPhrase";
            // 
            // vietPhrase_AlwaysWrapExceptHanVietRadioButton
            // 
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.AutoSize = true;
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Location = new System.Drawing.Point(6, 75);
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Name = "vietPhrase_AlwaysWrapExceptHanVietRadioButton";
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Size = new System.Drawing.Size(237, 21);
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.TabIndex = 6;
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.TabStop = true;
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Text = "Luôn sử dụng [ ... ] (trừ Hán Việt)";
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.UseVisualStyleBackColor = true;
            // 
            // vietPhrase_OnlyWrapTwoMeaningRadioButton
            // 
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.Location = new System.Drawing.Point(6, 96);
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.Name = "vietPhrase_OnlyWrapTwoMeaningRadioButton";
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.Size = new System.Drawing.Size(252, 24);
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.TabIndex = 5;
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.TabStop = true;
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.Text = "Chỉ sử dụng [ ... ] nếu có hơn một nghĩa";
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.UseVisualStyleBackColor = true;
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.CheckedChanged += new System.EventHandler(this.VietPhrase_OnlyWrapTwoMeaningRadioButtonCheckedChanged);
            // 
            // vietPhrase_AlwaysWrapRadioButton
            // 
            this.vietPhrase_AlwaysWrapRadioButton.Location = new System.Drawing.Point(6, 47);
            this.vietPhrase_AlwaysWrapRadioButton.Name = "vietPhrase_AlwaysWrapRadioButton";
            this.vietPhrase_AlwaysWrapRadioButton.Size = new System.Drawing.Size(252, 24);
            this.vietPhrase_AlwaysWrapRadioButton.TabIndex = 4;
            this.vietPhrase_AlwaysWrapRadioButton.TabStop = true;
            this.vietPhrase_AlwaysWrapRadioButton.Text = "Luôn sử dụng [ ... ] (cả Hán Việt)";
            this.vietPhrase_AlwaysWrapRadioButton.UseVisualStyleBackColor = true;
            this.vietPhrase_AlwaysWrapRadioButton.CheckedChanged += new System.EventHandler(this.VietPhrase_AlwaysWrapRadioButtonCheckedChanged);
            // 
            // vietPhrase_NoWrapRadioButton
            // 
            this.vietPhrase_NoWrapRadioButton.Location = new System.Drawing.Point(6, 19);
            this.vietPhrase_NoWrapRadioButton.Name = "vietPhrase_NoWrapRadioButton";
            this.vietPhrase_NoWrapRadioButton.Size = new System.Drawing.Size(252, 24);
            this.vietPhrase_NoWrapRadioButton.TabIndex = 3;
            this.vietPhrase_NoWrapRadioButton.TabStop = true;
            this.vietPhrase_NoWrapRadioButton.Text = "Không sử dụng [ ... ]";
            this.vietPhrase_NoWrapRadioButton.UseVisualStyleBackColor = true;
            this.vietPhrase_NoWrapRadioButton.CheckedChanged += new System.EventHandler(this.VietPhrase_NoWrapRadioButtonCheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton);
            this.groupBox3.Controls.Add(this.vietPhraseOneMeaning_NoWrapRadioButton);
            this.groupBox3.Controls.Add(this.vietPhraseOneMeaning_AlwaysWrapRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(280, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 126);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VietPhrase một nghĩa";
            // 
            // vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton
            // 
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.AutoSize = true;
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Location = new System.Drawing.Point(6, 73);
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Name = "vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton";
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Size = new System.Drawing.Size(237, 21);
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.TabIndex = 6;
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.TabStop = true;
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Text = "Luôn sử dụng [ ... ] (trừ Hán Việt)";
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.UseVisualStyleBackColor = true;
            // 
            // vietPhraseOneMeaning_NoWrapRadioButton
            // 
            this.vietPhraseOneMeaning_NoWrapRadioButton.Location = new System.Drawing.Point(6, 19);
            this.vietPhraseOneMeaning_NoWrapRadioButton.Name = "vietPhraseOneMeaning_NoWrapRadioButton";
            this.vietPhraseOneMeaning_NoWrapRadioButton.Size = new System.Drawing.Size(179, 24);
            this.vietPhraseOneMeaning_NoWrapRadioButton.TabIndex = 6;
            this.vietPhraseOneMeaning_NoWrapRadioButton.TabStop = true;
            this.vietPhraseOneMeaning_NoWrapRadioButton.Text = "Không sử dụng [ ... ]";
            this.vietPhraseOneMeaning_NoWrapRadioButton.UseVisualStyleBackColor = true;
            this.vietPhraseOneMeaning_NoWrapRadioButton.CheckedChanged += new System.EventHandler(this.VietPhraseOneMeaning_NoWrapRadioButtonCheckedChanged);
            // 
            // vietPhraseOneMeaning_AlwaysWrapRadioButton
            // 
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Location = new System.Drawing.Point(6, 46);
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Name = "vietPhraseOneMeaning_AlwaysWrapRadioButton";
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Size = new System.Drawing.Size(237, 24);
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.TabIndex = 7;
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.TabStop = true;
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Text = "Luôn sử dụng [ ... ] (cả Hán Việt)";
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.UseVisualStyleBackColor = true;
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.CheckedChanged += new System.EventHandler(this.VietPhraseOneMeaning_AlwaysWrapRadioButtonCheckedChanged);
            // 
            // groupBox4
            // 
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
            this.groupBox4.Location = new System.Drawing.Point(8, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 328);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hot Keys";
            // 
            // hotKeys_CopyMeaning6TextBox
            // 
            this.hotKeys_CopyMeaning6TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_CopyMeaning6TextBox.Location = new System.Drawing.Point(394, 168);
            this.hotKeys_CopyMeaning6TextBox.MaxLength = 1;
            this.hotKeys_CopyMeaning6TextBox.Name = "hotKeys_CopyMeaning6TextBox";
            this.hotKeys_CopyMeaning6TextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_CopyMeaning6TextBox.TabIndex = 19;
            this.hotKeys_CopyMeaning6TextBox.Text = "6";
            this.hotKeys_CopyMeaning6TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(355, 166);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 23);
            this.label23.TabIndex = 33;
            this.label23.Text = "Ctrl + ";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(233, 166);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 23);
            this.label24.TabIndex = 32;
            this.label24.Text = "Copy nghĩa thứ 6:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // f9TextBox
            // 
            this.f9TextBox.Location = new System.Drawing.Point(139, 296);
            this.f9TextBox.MaxLength = 0;
            this.f9TextBox.Name = "f9TextBox";
            this.f9TextBox.Size = new System.Drawing.Size(163, 23);
            this.f9TextBox.TabIndex = 28;
            // 
            // f7TextBox
            // 
            this.f7TextBox.Location = new System.Drawing.Point(139, 275);
            this.f7TextBox.MaxLength = 0;
            this.f7TextBox.Name = "f7TextBox";
            this.f7TextBox.Size = new System.Drawing.Size(163, 23);
            this.f7TextBox.TabIndex = 26;
            // 
            // f5TextBox
            // 
            this.f5TextBox.Location = new System.Drawing.Point(139, 252);
            this.f5TextBox.MaxLength = 0;
            this.f5TextBox.Name = "f5TextBox";
            this.f5TextBox.Size = new System.Drawing.Size(163, 23);
            this.f5TextBox.TabIndex = 24;
            // 
            // f3TextBox
            // 
            this.f3TextBox.Location = new System.Drawing.Point(139, 229);
            this.f3TextBox.MaxLength = 0;
            this.f3TextBox.Name = "f3TextBox";
            this.f3TextBox.Size = new System.Drawing.Size(163, 23);
            this.f3TextBox.TabIndex = 22;
            // 
            // f8TextBox
            // 
            this.f8TextBox.Location = new System.Drawing.Point(355, 275);
            this.f8TextBox.MaxLength = 0;
            this.f8TextBox.Name = "f8TextBox";
            this.f8TextBox.Size = new System.Drawing.Size(163, 23);
            this.f8TextBox.TabIndex = 27;
            // 
            // f6TextBox
            // 
            this.f6TextBox.Location = new System.Drawing.Point(355, 252);
            this.f6TextBox.MaxLength = 0;
            this.f6TextBox.Name = "f6TextBox";
            this.f6TextBox.Size = new System.Drawing.Size(163, 23);
            this.f6TextBox.TabIndex = 25;
            // 
            // f4TextBox
            // 
            this.f4TextBox.Location = new System.Drawing.Point(355, 229);
            this.f4TextBox.MaxLength = 0;
            this.f4TextBox.Name = "f4TextBox";
            this.f4TextBox.Size = new System.Drawing.Size(163, 23);
            this.f4TextBox.TabIndex = 23;
            // 
            // f2TextBox
            // 
            this.f2TextBox.Location = new System.Drawing.Point(355, 204);
            this.f2TextBox.MaxLength = 0;
            this.f2TextBox.Name = "f2TextBox";
            this.f2TextBox.Size = new System.Drawing.Size(163, 23);
            this.f2TextBox.TabIndex = 21;
            // 
            // f1TextBox
            // 
            this.f1TextBox.Location = new System.Drawing.Point(139, 205);
            this.f1TextBox.MaxLength = 0;
            this.f1TextBox.Name = "f1TextBox";
            this.f1TextBox.Size = new System.Drawing.Size(163, 23);
            this.f1TextBox.TabIndex = 20;
            // 
            // hotKeys_CopyMeaning5TextBox
            // 
            this.hotKeys_CopyMeaning5TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_CopyMeaning5TextBox.Location = new System.Drawing.Point(175, 166);
            this.hotKeys_CopyMeaning5TextBox.MaxLength = 1;
            this.hotKeys_CopyMeaning5TextBox.Name = "hotKeys_CopyMeaning5TextBox";
            this.hotKeys_CopyMeaning5TextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_CopyMeaning5TextBox.TabIndex = 18;
            this.hotKeys_CopyMeaning5TextBox.Text = "5";
            this.hotKeys_CopyMeaning5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(136, 164);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 23);
            this.label21.TabIndex = 30;
            this.label21.Text = "Ctrl + ";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(233, 273);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(116, 23);
            this.label33.TabIndex = 29;
            this.label33.Text = "F8:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(233, 250);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(116, 23);
            this.label32.TabIndex = 29;
            this.label32.Text = "F6:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(233, 227);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(116, 23);
            this.label31.TabIndex = 29;
            this.label31.Text = "F4:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(233, 204);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(116, 23);
            this.label30.TabIndex = 29;
            this.label30.Text = "F2:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(14, 296);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(116, 23);
            this.label29.TabIndex = 29;
            this.label29.Text = "F9:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(14, 273);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(116, 23);
            this.label28.TabIndex = 29;
            this.label28.Text = "F7:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(14, 250);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(116, 23);
            this.label27.TabIndex = 29;
            this.label27.Text = "F5:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(14, 227);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 23);
            this.label26.TabIndex = 29;
            this.label26.Text = "F3:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(14, 204);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 23);
            this.label25.TabIndex = 29;
            this.label25.Text = "F1:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(14, 164);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 23);
            this.label22.TabIndex = 29;
            this.label22.Text = "Copy nghĩa thứ 5:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotKeys_CopyMeaning4TextBox
            // 
            this.hotKeys_CopyMeaning4TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_CopyMeaning4TextBox.Location = new System.Drawing.Point(394, 145);
            this.hotKeys_CopyMeaning4TextBox.MaxLength = 1;
            this.hotKeys_CopyMeaning4TextBox.Name = "hotKeys_CopyMeaning4TextBox";
            this.hotKeys_CopyMeaning4TextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_CopyMeaning4TextBox.TabIndex = 17;
            this.hotKeys_CopyMeaning4TextBox.Text = "4";
            this.hotKeys_CopyMeaning4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(355, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 23);
            this.label19.TabIndex = 27;
            this.label19.Text = "Ctrl + ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(233, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 23);
            this.label20.TabIndex = 26;
            this.label20.Text = "Copy nghĩa thứ 4:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotKeys_CopyMeaning3TextBox
            // 
            this.hotKeys_CopyMeaning3TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_CopyMeaning3TextBox.Location = new System.Drawing.Point(175, 143);
            this.hotKeys_CopyMeaning3TextBox.MaxLength = 1;
            this.hotKeys_CopyMeaning3TextBox.Name = "hotKeys_CopyMeaning3TextBox";
            this.hotKeys_CopyMeaning3TextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_CopyMeaning3TextBox.TabIndex = 16;
            this.hotKeys_CopyMeaning3TextBox.Text = "3";
            this.hotKeys_CopyMeaning3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(136, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 23);
            this.label17.TabIndex = 24;
            this.label17.Text = "Ctrl + ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(14, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Copy nghĩa thứ 3:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotKeys_CopyMeaning2TextBox
            // 
            this.hotKeys_CopyMeaning2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_CopyMeaning2TextBox.Location = new System.Drawing.Point(394, 122);
            this.hotKeys_CopyMeaning2TextBox.MaxLength = 1;
            this.hotKeys_CopyMeaning2TextBox.Name = "hotKeys_CopyMeaning2TextBox";
            this.hotKeys_CopyMeaning2TextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_CopyMeaning2TextBox.TabIndex = 15;
            this.hotKeys_CopyMeaning2TextBox.Text = "2";
            this.hotKeys_CopyMeaning2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(355, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 23);
            this.label15.TabIndex = 21;
            this.label15.Text = "Ctrl + ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(233, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 23);
            this.label16.TabIndex = 20;
            this.label16.Text = "Copy nghĩa thứ 2:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotKeys_CopyHighlightedHanVietTextBox
            // 
            this.hotKeys_CopyHighlightedHanVietTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_CopyHighlightedHanVietTextBox.Location = new System.Drawing.Point(394, 98);
            this.hotKeys_CopyHighlightedHanVietTextBox.MaxLength = 1;
            this.hotKeys_CopyHighlightedHanVietTextBox.Name = "hotKeys_CopyHighlightedHanVietTextBox";
            this.hotKeys_CopyHighlightedHanVietTextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_CopyHighlightedHanVietTextBox.TabIndex = 14;
            this.hotKeys_CopyHighlightedHanVietTextBox.Text = "0";
            this.hotKeys_CopyHighlightedHanVietTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hotKeys_CopyMeaning1TextBox
            // 
            this.hotKeys_CopyMeaning1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_CopyMeaning1TextBox.Location = new System.Drawing.Point(175, 120);
            this.hotKeys_CopyMeaning1TextBox.MaxLength = 1;
            this.hotKeys_CopyMeaning1TextBox.Name = "hotKeys_CopyMeaning1TextBox";
            this.hotKeys_CopyMeaning1TextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_CopyMeaning1TextBox.TabIndex = 14;
            this.hotKeys_CopyMeaning1TextBox.Text = "1";
            this.hotKeys_CopyMeaning1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(355, 96);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 23);
            this.label35.TabIndex = 18;
            this.label35.Text = "Ctrl + ";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(136, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "Ctrl + ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(208, 96);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(141, 23);
            this.label34.TabIndex = 17;
            this.label34.Text = "Copy cụm Hán Việt bôi đỏ:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(14, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 17;
            this.label14.Text = "Copy nghĩa thứ 1:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotKeys_MoveUpOneParagraphTextBox
            // 
            this.hotKeys_MoveUpOneParagraphTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_MoveUpOneParagraphTextBox.Location = new System.Drawing.Point(175, 60);
            this.hotKeys_MoveUpOneParagraphTextBox.MaxLength = 1;
            this.hotKeys_MoveUpOneParagraphTextBox.Name = "hotKeys_MoveUpOneParagraphTextBox";
            this.hotKeys_MoveUpOneParagraphTextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_MoveUpOneParagraphTextBox.TabIndex = 12;
            this.hotKeys_MoveUpOneParagraphTextBox.Text = "U";
            this.hotKeys_MoveUpOneParagraphTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(136, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Ctrl + ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(14, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Move Up 1 Paragraph:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotKeys_MoveDownOneParagraphTextBox
            // 
            this.hotKeys_MoveDownOneParagraphTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_MoveDownOneParagraphTextBox.Location = new System.Drawing.Point(394, 64);
            this.hotKeys_MoveDownOneParagraphTextBox.MaxLength = 1;
            this.hotKeys_MoveDownOneParagraphTextBox.Name = "hotKeys_MoveDownOneParagraphTextBox";
            this.hotKeys_MoveDownOneParagraphTextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_MoveDownOneParagraphTextBox.TabIndex = 13;
            this.hotKeys_MoveDownOneParagraphTextBox.Text = "N";
            this.hotKeys_MoveDownOneParagraphTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ctrl + ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(219, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Move Down 1 Paragraph:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotKeys_MoveUpOneLineTextBox
            // 
            this.hotKeys_MoveUpOneLineTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_MoveUpOneLineTextBox.Location = new System.Drawing.Point(175, 37);
            this.hotKeys_MoveUpOneLineTextBox.MaxLength = 1;
            this.hotKeys_MoveUpOneLineTextBox.Name = "hotKeys_MoveUpOneLineTextBox";
            this.hotKeys_MoveUpOneLineTextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_MoveUpOneLineTextBox.TabIndex = 10;
            this.hotKeys_MoveUpOneLineTextBox.Text = "I";
            this.hotKeys_MoveUpOneLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ctrl + ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Move Up 1 Line:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotKeys_MoveDownOneLineTextBox
            // 
            this.hotKeys_MoveDownOneLineTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_MoveDownOneLineTextBox.Location = new System.Drawing.Point(394, 39);
            this.hotKeys_MoveDownOneLineTextBox.MaxLength = 1;
            this.hotKeys_MoveDownOneLineTextBox.Name = "hotKeys_MoveDownOneLineTextBox";
            this.hotKeys_MoveDownOneLineTextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_MoveDownOneLineTextBox.TabIndex = 11;
            this.hotKeys_MoveDownOneLineTextBox.Text = "M";
            this.hotKeys_MoveDownOneLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ctrl + ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(233, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Move Down 1 Line:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotKeys_MoveLeftOneWordTextBox
            // 
            this.hotKeys_MoveLeftOneWordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_MoveLeftOneWordTextBox.Location = new System.Drawing.Point(175, 13);
            this.hotKeys_MoveLeftOneWordTextBox.MaxLength = 1;
            this.hotKeys_MoveLeftOneWordTextBox.Name = "hotKeys_MoveLeftOneWordTextBox";
            this.hotKeys_MoveLeftOneWordTextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_MoveLeftOneWordTextBox.TabIndex = 8;
            this.hotKeys_MoveLeftOneWordTextBox.Text = "J";
            this.hotKeys_MoveLeftOneWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ctrl + ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Move Left 1 Word:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hotKeys_MoveRightOneWordTextBox
            // 
            this.hotKeys_MoveRightOneWordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hotKeys_MoveRightOneWordTextBox.Location = new System.Drawing.Point(394, 14);
            this.hotKeys_MoveRightOneWordTextBox.MaxLength = 1;
            this.hotKeys_MoveRightOneWordTextBox.Name = "hotKeys_MoveRightOneWordTextBox";
            this.hotKeys_MoveRightOneWordTextBox.Size = new System.Drawing.Size(32, 23);
            this.hotKeys_MoveRightOneWordTextBox.TabIndex = 9;
            this.hotKeys_MoveRightOneWordTextBox.Text = "K";
            this.hotKeys_MoveRightOneWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ctrl + ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(233, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Move Right 1 Word:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // translateTabPage
            // 
            this.translateTabPage.Controls.Add(this.tabPage1);
            this.translateTabPage.Controls.Add(this.tabPage2);
            this.translateTabPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.translateTabPage.Location = new System.Drawing.Point(0, 0);
            this.translateTabPage.Name = "translateTabPage";
            this.translateTabPage.SelectedIndex = 0;
            this.translateTabPage.Size = new System.Drawing.Size(556, 584);
            this.translateTabPage.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Translation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.prioritizedNameCheckBox);
            this.groupBox5.Controls.Add(this.algorithm_LeftToRightRadioButton);
            this.groupBox5.Controls.Add(this.algorithm_LongestVietPhraseFirstWithConditionRadioButton);
            this.groupBox5.Controls.Add(this.algorithm_LongestVietPhraseFirstRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(8, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(528, 72);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thuật Toán Dịch";
            // 
            // prioritizedNameCheckBox
            // 
            this.prioritizedNameCheckBox.Location = new System.Drawing.Point(272, 40);
            this.prioritizedNameCheckBox.Name = "prioritizedNameCheckBox";
            this.prioritizedNameCheckBox.Size = new System.Drawing.Size(172, 24);
            this.prioritizedNameCheckBox.TabIndex = 1;
            this.prioritizedNameCheckBox.Text = "Ưu tiên Name hơn VietPhrase";
            this.prioritizedNameCheckBox.UseVisualStyleBackColor = true;
            this.prioritizedNameCheckBox.CheckedChanged += new System.EventHandler(this.PrioritizedNameCheckBoxCheckedChanged);
            // 
            // algorithm_LeftToRightRadioButton
            // 
            this.algorithm_LeftToRightRadioButton.Location = new System.Drawing.Point(272, 16);
            this.algorithm_LeftToRightRadioButton.Name = "algorithm_LeftToRightRadioButton";
            this.algorithm_LeftToRightRadioButton.Size = new System.Drawing.Size(232, 24);
            this.algorithm_LeftToRightRadioButton.TabIndex = 0;
            this.algorithm_LeftToRightRadioButton.TabStop = true;
            this.algorithm_LeftToRightRadioButton.Text = "Dịch từ trái sang phải";
            this.algorithm_LeftToRightRadioButton.UseVisualStyleBackColor = true;
            this.algorithm_LeftToRightRadioButton.CheckedChanged += new System.EventHandler(this.Algorithm_LeftToRightRadioButtonCheckedChanged);
            // 
            // algorithm_LongestVietPhraseFirstWithConditionRadioButton
            // 
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.Location = new System.Drawing.Point(8, 40);
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.Name = "algorithm_LongestVietPhraseFirstWithConditionRadioButton";
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.Size = new System.Drawing.Size(232, 24);
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.TabIndex = 0;
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.TabStop = true;
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.Text = "Ưu tiên cụm VietPhrase dài (>= 4 từ)";
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.UseVisualStyleBackColor = true;
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.CheckedChanged += new System.EventHandler(this.Algorithm_LongestVietPhraseFirstWithConditionRadioButtonCheckedChanged);
            // 
            // algorithm_LongestVietPhraseFirstRadioButton
            // 
            this.algorithm_LongestVietPhraseFirstRadioButton.Location = new System.Drawing.Point(8, 16);
            this.algorithm_LongestVietPhraseFirstRadioButton.Name = "algorithm_LongestVietPhraseFirstRadioButton";
            this.algorithm_LongestVietPhraseFirstRadioButton.Size = new System.Drawing.Size(232, 24);
            this.algorithm_LongestVietPhraseFirstRadioButton.TabIndex = 0;
            this.algorithm_LongestVietPhraseFirstRadioButton.TabStop = true;
            this.algorithm_LongestVietPhraseFirstRadioButton.Text = "Ưu tiên cụm VietPhrase dài";
            this.algorithm_LongestVietPhraseFirstRadioButton.UseVisualStyleBackColor = true;
            this.algorithm_LongestVietPhraseFirstRadioButton.CheckedChanged += new System.EventHandler(this.Algorithm_LongestVietPhraseFirstRadioButtonCheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Panel Style & Behaviors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.alwaysFocusInVietCheckBox);
            this.groupBox7.Location = new System.Drawing.Point(8, 392);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(528, 48);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Behaviors";
            // 
            // alwaysFocusInVietCheckBox
            // 
            this.alwaysFocusInVietCheckBox.Location = new System.Drawing.Point(8, 16);
            this.alwaysFocusInVietCheckBox.Name = "alwaysFocusInVietCheckBox";
            this.alwaysFocusInVietCheckBox.Size = new System.Drawing.Size(208, 24);
            this.alwaysFocusInVietCheckBox.TabIndex = 0;
            this.alwaysFocusInVietCheckBox.Text = "Luôn focus vào ô Việt";
            this.alwaysFocusInVietCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
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
            this.groupBox6.Location = new System.Drawing.Point(8, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(528, 368);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Panel Style";
            // 
            // nghiaBackColorButton
            // 
            this.nghiaBackColorButton.Location = new System.Drawing.Point(376, 317);
            this.nghiaBackColorButton.Name = "nghiaBackColorButton";
            this.nghiaBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.nghiaBackColorButton.TabIndex = 1;
            this.nghiaBackColorButton.Text = "Back Color";
            this.nghiaBackColorButton.UseVisualStyleBackColor = true;
            this.nghiaBackColorButton.Click += new System.EventHandler(this.NghiaBackColorButtonClick);
            // 
            // trungLabel
            // 
            this.trungLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trungLabel.Location = new System.Drawing.Point(72, 24);
            this.trungLabel.Name = "trungLabel";
            this.trungLabel.Size = new System.Drawing.Size(216, 48);
            this.trungLabel.TabIndex = 0;
            this.trungLabel.Text = "Trung";
            this.trungLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vietBackColorButton
            // 
            this.vietBackColorButton.Location = new System.Drawing.Point(376, 261);
            this.vietBackColorButton.Name = "vietBackColorButton";
            this.vietBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.vietBackColorButton.TabIndex = 1;
            this.vietBackColorButton.Text = "Back Color";
            this.vietBackColorButton.UseVisualStyleBackColor = true;
            this.vietBackColorButton.Click += new System.EventHandler(this.VietBackColorButtonClick);
            // 
            // hanVietLabel
            // 
            this.hanVietLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hanVietLabel.Location = new System.Drawing.Point(72, 80);
            this.hanVietLabel.Name = "hanVietLabel";
            this.hanVietLabel.Size = new System.Drawing.Size(216, 48);
            this.hanVietLabel.TabIndex = 0;
            this.hanVietLabel.Text = "Hán Việt";
            this.hanVietLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vietPhraseOneMeaningBackColorButton
            // 
            this.vietPhraseOneMeaningBackColorButton.Location = new System.Drawing.Point(376, 205);
            this.vietPhraseOneMeaningBackColorButton.Name = "vietPhraseOneMeaningBackColorButton";
            this.vietPhraseOneMeaningBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.vietPhraseOneMeaningBackColorButton.TabIndex = 1;
            this.vietPhraseOneMeaningBackColorButton.Text = "Back Color";
            this.vietPhraseOneMeaningBackColorButton.UseVisualStyleBackColor = true;
            this.vietPhraseOneMeaningBackColorButton.Click += new System.EventHandler(this.VietPhraseOneMeaningBackColorButtonClick);
            // 
            // vietPhraseLabel
            // 
            this.vietPhraseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vietPhraseLabel.Location = new System.Drawing.Point(72, 136);
            this.vietPhraseLabel.Name = "vietPhraseLabel";
            this.vietPhraseLabel.Size = new System.Drawing.Size(216, 48);
            this.vietPhraseLabel.TabIndex = 0;
            this.vietPhraseLabel.Text = "VietPhrase";
            this.vietPhraseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vietPhraseBackColorButton
            // 
            this.vietPhraseBackColorButton.Location = new System.Drawing.Point(376, 149);
            this.vietPhraseBackColorButton.Name = "vietPhraseBackColorButton";
            this.vietPhraseBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.vietPhraseBackColorButton.TabIndex = 1;
            this.vietPhraseBackColorButton.Text = "Back Color";
            this.vietPhraseBackColorButton.UseVisualStyleBackColor = true;
            this.vietPhraseBackColorButton.Click += new System.EventHandler(this.VietPhraseBackColorButtonClick);
            // 
            // vietPhraseOneMeaningLabel
            // 
            this.vietPhraseOneMeaningLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vietPhraseOneMeaningLabel.Location = new System.Drawing.Point(72, 192);
            this.vietPhraseOneMeaningLabel.Name = "vietPhraseOneMeaningLabel";
            this.vietPhraseOneMeaningLabel.Size = new System.Drawing.Size(216, 48);
            this.vietPhraseOneMeaningLabel.TabIndex = 0;
            this.vietPhraseOneMeaningLabel.Text = "VietPhrase Một Nghĩa";
            this.vietPhraseOneMeaningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hanVietBackColorButton
            // 
            this.hanVietBackColorButton.Location = new System.Drawing.Point(376, 93);
            this.hanVietBackColorButton.Name = "hanVietBackColorButton";
            this.hanVietBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.hanVietBackColorButton.TabIndex = 1;
            this.hanVietBackColorButton.Text = "Back Color";
            this.hanVietBackColorButton.UseVisualStyleBackColor = true;
            this.hanVietBackColorButton.Click += new System.EventHandler(this.HanVietBackColorButtonClick);
            // 
            // vietLabel
            // 
            this.vietLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vietLabel.Location = new System.Drawing.Point(72, 248);
            this.vietLabel.Name = "vietLabel";
            this.vietLabel.Size = new System.Drawing.Size(216, 48);
            this.vietLabel.TabIndex = 0;
            this.vietLabel.Text = "Việt";
            this.vietLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trungBackColorButton
            // 
            this.trungBackColorButton.Location = new System.Drawing.Point(376, 37);
            this.trungBackColorButton.Name = "trungBackColorButton";
            this.trungBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.trungBackColorButton.TabIndex = 1;
            this.trungBackColorButton.Text = "Back Color";
            this.trungBackColorButton.UseVisualStyleBackColor = true;
            this.trungBackColorButton.Click += new System.EventHandler(this.TrungBackColorButtonClick);
            // 
            // nghiaLabel
            // 
            this.nghiaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nghiaLabel.Location = new System.Drawing.Point(72, 304);
            this.nghiaLabel.Name = "nghiaLabel";
            this.nghiaLabel.Size = new System.Drawing.Size(216, 48);
            this.nghiaLabel.TabIndex = 0;
            this.nghiaLabel.Text = "Nghĩa";
            this.nghiaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nghiaFontButton
            // 
            this.nghiaFontButton.Location = new System.Drawing.Point(296, 317);
            this.nghiaFontButton.Name = "nghiaFontButton";
            this.nghiaFontButton.Size = new System.Drawing.Size(75, 23);
            this.nghiaFontButton.TabIndex = 1;
            this.nghiaFontButton.Text = "Font";
            this.nghiaFontButton.UseVisualStyleBackColor = true;
            this.nghiaFontButton.Click += new System.EventHandler(this.NghiaFontButtonClick);
            // 
            // trungFontButton
            // 
            this.trungFontButton.Location = new System.Drawing.Point(296, 37);
            this.trungFontButton.Name = "trungFontButton";
            this.trungFontButton.Size = new System.Drawing.Size(75, 23);
            this.trungFontButton.TabIndex = 1;
            this.trungFontButton.Text = "Font";
            this.trungFontButton.UseVisualStyleBackColor = true;
            this.trungFontButton.Click += new System.EventHandler(this.TrungFontButtonClick);
            // 
            // vietFontButton
            // 
            this.vietFontButton.Location = new System.Drawing.Point(296, 261);
            this.vietFontButton.Name = "vietFontButton";
            this.vietFontButton.Size = new System.Drawing.Size(75, 23);
            this.vietFontButton.TabIndex = 1;
            this.vietFontButton.Text = "Font";
            this.vietFontButton.UseVisualStyleBackColor = true;
            this.vietFontButton.Click += new System.EventHandler(this.VietFontButtonClick);
            // 
            // hanVietFontButton
            // 
            this.hanVietFontButton.Location = new System.Drawing.Point(296, 93);
            this.hanVietFontButton.Name = "hanVietFontButton";
            this.hanVietFontButton.Size = new System.Drawing.Size(75, 23);
            this.hanVietFontButton.TabIndex = 1;
            this.hanVietFontButton.Text = "Font";
            this.hanVietFontButton.UseVisualStyleBackColor = true;
            this.hanVietFontButton.Click += new System.EventHandler(this.HanVietFontButtonClick);
            // 
            // vietPhraseOneMeaningFontButton
            // 
            this.vietPhraseOneMeaningFontButton.Location = new System.Drawing.Point(296, 205);
            this.vietPhraseOneMeaningFontButton.Name = "vietPhraseOneMeaningFontButton";
            this.vietPhraseOneMeaningFontButton.Size = new System.Drawing.Size(75, 23);
            this.vietPhraseOneMeaningFontButton.TabIndex = 1;
            this.vietPhraseOneMeaningFontButton.Text = "Font";
            this.vietPhraseOneMeaningFontButton.UseVisualStyleBackColor = true;
            this.vietPhraseOneMeaningFontButton.Click += new System.EventHandler(this.VietPhraseOneMeaningFontButtonClick);
            // 
            // vietPhraseFontButton
            // 
            this.vietPhraseFontButton.Location = new System.Drawing.Point(296, 149);
            this.vietPhraseFontButton.Name = "vietPhraseFontButton";
            this.vietPhraseFontButton.Size = new System.Drawing.Size(75, 23);
            this.vietPhraseFontButton.TabIndex = 1;
            this.vietPhraseFontButton.Text = "Font";
            this.vietPhraseFontButton.UseVisualStyleBackColor = true;
            this.vietPhraseFontButton.Click += new System.EventHandler(this.VietPhraseFontButtonClick);
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // fontDialog
            // 
            this.fontDialog.FontMustExist = true;
            this.fontDialog.ShowColor = true;
            // 
            // ConfigurationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.translateTabPage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigurationPanel";
            this.Text = "ConfigurationPanel";
            this.Load += new System.EventHandler(this.ConfigurationPanelLoad);
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
            this.ResumeLayout(false);

        }

        private System.ComponentModel.IContainer components;

        private System.Windows.Forms.CheckBox prioritizedNameCheckBox;

        private System.Windows.Forms.GroupBox groupBox6;

        private System.Windows.Forms.CheckBox alwaysFocusInVietCheckBox;

        private System.Windows.Forms.GroupBox groupBox7;

        private System.Windows.Forms.RadioButton algorithm_LongestVietPhraseFirstWithConditionRadioButton;

        private System.Windows.Forms.RadioButton algorithm_LongestVietPhraseFirstRadioButton;

        private System.Windows.Forms.RadioButton algorithm_LeftToRightRadioButton;

        private System.Windows.Forms.GroupBox groupBox5;

        private System.Windows.Forms.Button nghiaBackColorButton;

        private System.Windows.Forms.Button nghiaFontButton;

        private System.Windows.Forms.Label nghiaLabel;

        private System.Windows.Forms.Label vietLabel;

        private System.Windows.Forms.Label vietPhraseOneMeaningLabel;

        private System.Windows.Forms.Label vietPhraseLabel;

        private System.Windows.Forms.Label hanVietLabel;

        private System.Windows.Forms.Button vietBackColorButton;

        private System.Windows.Forms.Button vietPhraseOneMeaningBackColorButton;

        private System.Windows.Forms.Button vietPhraseBackColorButton;

        private System.Windows.Forms.Button hanVietBackColorButton;

        private System.Windows.Forms.Button trungBackColorButton;

        private System.Windows.Forms.Button vietFontButton;

        private System.Windows.Forms.Button vietPhraseOneMeaningFontButton;

        private System.Windows.Forms.Button vietPhraseFontButton;

        private System.Windows.Forms.Button hanVietFontButton;

        private System.Windows.Forms.FontDialog fontDialog;

        private System.Windows.Forms.ColorDialog colorDialog;

        private System.Windows.Forms.Label trungLabel;

        private System.Windows.Forms.Button trungFontButton;

        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.TabControl translateTabPage;

        private System.Windows.Forms.TextBox hotKeys_CopyMeaning4TextBox;

        private System.Windows.Forms.TextBox hotKeys_MoveRightOneWordTextBox;

        private System.Windows.Forms.TextBox hotKeys_CopyMeaning6TextBox;

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.TextBox hotKeys_CopyMeaning1TextBox;

        private System.Windows.Forms.Label label16;

        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.TextBox hotKeys_CopyMeaning2TextBox;

        private System.Windows.Forms.Label label18;

        private System.Windows.Forms.Label label17;

        private System.Windows.Forms.TextBox hotKeys_CopyMeaning3TextBox;

        private System.Windows.Forms.Label label20;

        private System.Windows.Forms.Label label19;

        private System.Windows.Forms.Label label22;

        private System.Windows.Forms.Label label21;

        private System.Windows.Forms.TextBox hotKeys_CopyMeaning5TextBox;

        private System.Windows.Forms.Label label24;

        private System.Windows.Forms.Label label23;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox hotKeys_MoveUpOneLineTextBox;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox hotKeys_MoveDownOneParagraphTextBox;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.TextBox hotKeys_MoveUpOneParagraphTextBox;

        private System.Windows.Forms.TextBox hotKeys_MoveDownOneLineTextBox;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox hotKeys_MoveLeftOneWordTextBox;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.RadioButton vietPhraseOneMeaning_AlwaysWrapRadioButton;

        private System.Windows.Forms.RadioButton vietPhraseOneMeaning_NoWrapRadioButton;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.RadioButton vietPhrase_NoWrapRadioButton;

        private System.Windows.Forms.RadioButton vietPhrase_OnlyWrapTwoMeaningRadioButton;

        private System.Windows.Forms.RadioButton vietPhrase_AlwaysWrapRadioButton;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.CheckBox browserPanel_DisablePopupsCheckBox;

        private System.Windows.Forms.CheckBox browserPanel_DisableImagesCheckBox;

        private System.Windows.Forms.Button cancelButton;

        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label26;

        private System.Windows.Forms.Label label25;

        private System.Windows.Forms.TextBox f9TextBox;

        private System.Windows.Forms.TextBox f7TextBox;

        private System.Windows.Forms.TextBox f5TextBox;

        private System.Windows.Forms.TextBox f3TextBox;

        private System.Windows.Forms.TextBox f8TextBox;

        private System.Windows.Forms.TextBox f6TextBox;

        private System.Windows.Forms.TextBox f4TextBox;

        private System.Windows.Forms.TextBox f2TextBox;

        private System.Windows.Forms.TextBox f1TextBox;

        private System.Windows.Forms.Label label33;

        private System.Windows.Forms.Label label32;

        private System.Windows.Forms.Label label31;

        private System.Windows.Forms.Label label30;

        private System.Windows.Forms.Label label29;

        private System.Windows.Forms.Label label28;

        private System.Windows.Forms.Label label27;

        private System.Windows.Forms.RadioButton vietPhrase_AlwaysWrapExceptHanVietRadioButton;

        private System.Windows.Forms.RadioButton vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton;

        private System.Windows.Forms.TextBox hotKeys_CopyHighlightedHanVietTextBox;

        private System.Windows.Forms.Label label35;

        private System.Windows.Forms.Label label34;
    }
}

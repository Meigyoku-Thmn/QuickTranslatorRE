namespace ExtendedWebBrowser2
{
    internal partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.popupBlockerGroupBox = new System.Windows.Forms.GroupBox();
            this.filterLevelHighRadioButton = new System.Windows.Forms.RadioButton();
            this.filterLevelMediumRadioButton = new System.Windows.Forms.RadioButton();
            this.filterLevelLowRadioButton = new System.Windows.Forms.RadioButton();
            this.filterLevelNoneRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.doNotShowScriptErrorsCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton = new System.Windows.Forms.RadioButton();
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton = new System.Windows.Forms.RadioButton();
            this.vietPhrase_AlwaysWrapRadioButton = new System.Windows.Forms.RadioButton();
            this.vietPhrase_NoWrapRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vietPhraseOneMeaning_NoWrapRadioButton = new System.Windows.Forms.RadioButton();
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton = new System.Windows.Forms.RadioButton();
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.blockFlashesCheckBox = new System.Windows.Forms.CheckBox();
            this.blockImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.prioritizedNameCheckBox = new System.Windows.Forms.CheckBox();
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton = new System.Windows.Forms.RadioButton();
            this.algorithm_LeftToRightRadioButton = new System.Windows.Forms.RadioButton();
            this.algorithm_LongestVietPhraseFirstRadioButton = new System.Windows.Forms.RadioButton();
            this.popupBlockerGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupBlockerGroupBox
            // 
            this.popupBlockerGroupBox.Controls.Add(this.filterLevelHighRadioButton);
            this.popupBlockerGroupBox.Controls.Add(this.filterLevelMediumRadioButton);
            this.popupBlockerGroupBox.Controls.Add(this.filterLevelLowRadioButton);
            this.popupBlockerGroupBox.Controls.Add(this.filterLevelNoneRadioButton);
            resources.ApplyResources(this.popupBlockerGroupBox, "popupBlockerGroupBox");
            this.popupBlockerGroupBox.Name = "popupBlockerGroupBox";
            this.popupBlockerGroupBox.TabStop = false;
            // 
            // filterLevelHighRadioButton
            // 
            resources.ApplyResources(this.filterLevelHighRadioButton, "filterLevelHighRadioButton");
            this.filterLevelHighRadioButton.Name = "filterLevelHighRadioButton";
            this.filterLevelHighRadioButton.TabStop = true;
            this.filterLevelHighRadioButton.UseVisualStyleBackColor = true;
            // 
            // filterLevelMediumRadioButton
            // 
            resources.ApplyResources(this.filterLevelMediumRadioButton, "filterLevelMediumRadioButton");
            this.filterLevelMediumRadioButton.Name = "filterLevelMediumRadioButton";
            this.filterLevelMediumRadioButton.TabStop = true;
            this.filterLevelMediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // filterLevelLowRadioButton
            // 
            resources.ApplyResources(this.filterLevelLowRadioButton, "filterLevelLowRadioButton");
            this.filterLevelLowRadioButton.Name = "filterLevelLowRadioButton";
            this.filterLevelLowRadioButton.TabStop = true;
            this.filterLevelLowRadioButton.UseVisualStyleBackColor = true;
            // 
            // filterLevelNoneRadioButton
            // 
            resources.ApplyResources(this.filterLevelNoneRadioButton, "filterLevelNoneRadioButton");
            this.filterLevelNoneRadioButton.Name = "filterLevelNoneRadioButton";
            this.filterLevelNoneRadioButton.TabStop = true;
            this.filterLevelNoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doNotShowScriptErrorsCheckBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // doNotShowScriptErrorsCheckBox
            // 
            resources.ApplyResources(this.doNotShowScriptErrorsCheckBox, "doNotShowScriptErrorsCheckBox");
            this.doNotShowScriptErrorsCheckBox.Name = "doNotShowScriptErrorsCheckBox";
            this.doNotShowScriptErrorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vietPhrase_OnlyWrapTwoMeaningRadioButton);
            this.groupBox1.Controls.Add(this.vietPhrase_AlwaysWrapExceptHanVietRadioButton);
            this.groupBox1.Controls.Add(this.vietPhrase_AlwaysWrapRadioButton);
            this.groupBox1.Controls.Add(this.vietPhrase_NoWrapRadioButton);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // vietPhrase_OnlyWrapTwoMeaningRadioButton
            // 
            resources.ApplyResources(this.vietPhrase_OnlyWrapTwoMeaningRadioButton, "vietPhrase_OnlyWrapTwoMeaningRadioButton");
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.Name = "vietPhrase_OnlyWrapTwoMeaningRadioButton";
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.TabStop = true;
            this.vietPhrase_OnlyWrapTwoMeaningRadioButton.UseVisualStyleBackColor = true;
            // 
            // vietPhrase_AlwaysWrapExceptHanVietRadioButton
            // 
            resources.ApplyResources(this.vietPhrase_AlwaysWrapExceptHanVietRadioButton, "vietPhrase_AlwaysWrapExceptHanVietRadioButton");
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.Name = "vietPhrase_AlwaysWrapExceptHanVietRadioButton";
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.TabStop = true;
            this.vietPhrase_AlwaysWrapExceptHanVietRadioButton.UseVisualStyleBackColor = true;
            // 
            // vietPhrase_AlwaysWrapRadioButton
            // 
            resources.ApplyResources(this.vietPhrase_AlwaysWrapRadioButton, "vietPhrase_AlwaysWrapRadioButton");
            this.vietPhrase_AlwaysWrapRadioButton.Name = "vietPhrase_AlwaysWrapRadioButton";
            this.vietPhrase_AlwaysWrapRadioButton.TabStop = true;
            this.vietPhrase_AlwaysWrapRadioButton.UseVisualStyleBackColor = true;
            // 
            // vietPhrase_NoWrapRadioButton
            // 
            resources.ApplyResources(this.vietPhrase_NoWrapRadioButton, "vietPhrase_NoWrapRadioButton");
            this.vietPhrase_NoWrapRadioButton.Name = "vietPhrase_NoWrapRadioButton";
            this.vietPhrase_NoWrapRadioButton.TabStop = true;
            this.vietPhrase_NoWrapRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vietPhraseOneMeaning_NoWrapRadioButton);
            this.groupBox3.Controls.Add(this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton);
            this.groupBox3.Controls.Add(this.vietPhraseOneMeaning_AlwaysWrapRadioButton);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // vietPhraseOneMeaning_NoWrapRadioButton
            // 
            resources.ApplyResources(this.vietPhraseOneMeaning_NoWrapRadioButton, "vietPhraseOneMeaning_NoWrapRadioButton");
            this.vietPhraseOneMeaning_NoWrapRadioButton.Name = "vietPhraseOneMeaning_NoWrapRadioButton";
            this.vietPhraseOneMeaning_NoWrapRadioButton.TabStop = true;
            this.vietPhraseOneMeaning_NoWrapRadioButton.UseVisualStyleBackColor = true;
            // 
            // vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton
            // 
            resources.ApplyResources(this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton, "vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton");
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.Name = "vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton";
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.TabStop = true;
            this.vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton.UseVisualStyleBackColor = true;
            // 
            // vietPhraseOneMeaning_AlwaysWrapRadioButton
            // 
            resources.ApplyResources(this.vietPhraseOneMeaning_AlwaysWrapRadioButton, "vietPhraseOneMeaning_AlwaysWrapRadioButton");
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.Name = "vietPhraseOneMeaning_AlwaysWrapRadioButton";
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.TabStop = true;
            this.vietPhraseOneMeaning_AlwaysWrapRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.blockFlashesCheckBox);
            this.groupBox4.Controls.Add(this.blockImagesCheckBox);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // blockFlashesCheckBox
            // 
            resources.ApplyResources(this.blockFlashesCheckBox, "blockFlashesCheckBox");
            this.blockFlashesCheckBox.Name = "blockFlashesCheckBox";
            this.blockFlashesCheckBox.UseVisualStyleBackColor = true;
            // 
            // blockImagesCheckBox
            // 
            resources.ApplyResources(this.blockImagesCheckBox, "blockImagesCheckBox");
            this.blockImagesCheckBox.Name = "blockImagesCheckBox";
            this.blockImagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.prioritizedNameCheckBox);
            this.groupBox5.Controls.Add(this.algorithm_LongestVietPhraseFirstWithConditionRadioButton);
            this.groupBox5.Controls.Add(this.algorithm_LeftToRightRadioButton);
            this.groupBox5.Controls.Add(this.algorithm_LongestVietPhraseFirstRadioButton);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // prioritizedNameCheckBox
            // 
            resources.ApplyResources(this.prioritizedNameCheckBox, "prioritizedNameCheckBox");
            this.prioritizedNameCheckBox.Name = "prioritizedNameCheckBox";
            this.prioritizedNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // algorithm_LongestVietPhraseFirstWithConditionRadioButton
            // 
            resources.ApplyResources(this.algorithm_LongestVietPhraseFirstWithConditionRadioButton, "algorithm_LongestVietPhraseFirstWithConditionRadioButton");
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.Name = "algorithm_LongestVietPhraseFirstWithConditionRadioButton";
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.TabStop = true;
            this.algorithm_LongestVietPhraseFirstWithConditionRadioButton.UseVisualStyleBackColor = true;
            // 
            // algorithm_LeftToRightRadioButton
            // 
            resources.ApplyResources(this.algorithm_LeftToRightRadioButton, "algorithm_LeftToRightRadioButton");
            this.algorithm_LeftToRightRadioButton.Name = "algorithm_LeftToRightRadioButton";
            this.algorithm_LeftToRightRadioButton.TabStop = true;
            this.algorithm_LeftToRightRadioButton.UseVisualStyleBackColor = true;
            // 
            // algorithm_LongestVietPhraseFirstRadioButton
            // 
            resources.ApplyResources(this.algorithm_LongestVietPhraseFirstRadioButton, "algorithm_LongestVietPhraseFirstRadioButton");
            this.algorithm_LongestVietPhraseFirstRadioButton.Name = "algorithm_LongestVietPhraseFirstRadioButton";
            this.algorithm_LongestVietPhraseFirstRadioButton.TabStop = true;
            this.algorithm_LongestVietPhraseFirstRadioButton.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.popupBlockerGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.popupBlockerGroupBox.ResumeLayout(false);
            this.popupBlockerGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private global::System.ComponentModel.IContainer components;

        private global::System.Windows.Forms.CheckBox prioritizedNameCheckBox;

        private global::System.Windows.Forms.RadioButton algorithm_LongestVietPhraseFirstWithConditionRadioButton;

        private global::System.Windows.Forms.CheckBox blockFlashesCheckBox;

        private global::System.Windows.Forms.CheckBox blockImagesCheckBox;

        private global::System.Windows.Forms.Label label2;

        private global::System.Windows.Forms.GroupBox groupBox4;

        private global::System.Windows.Forms.RadioButton vietPhraseOneMeaning_AlwaysWrapRadioButton;

        private global::System.Windows.Forms.RadioButton vietPhraseOneMeaning_NoWrapRadioButton;

        private global::System.Windows.Forms.GroupBox groupBox3;

        private global::System.Windows.Forms.RadioButton vietPhrase_NoWrapRadioButton;

        private global::System.Windows.Forms.RadioButton vietPhrase_AlwaysWrapRadioButton;

        private global::System.Windows.Forms.RadioButton vietPhrase_OnlyWrapTwoMeaningRadioButton;

        private global::System.Windows.Forms.GroupBox groupBox1;

        private global::System.Windows.Forms.GroupBox popupBlockerGroupBox;

        private global::System.Windows.Forms.RadioButton filterLevelHighRadioButton;

        private global::System.Windows.Forms.RadioButton filterLevelMediumRadioButton;

        private global::System.Windows.Forms.RadioButton filterLevelLowRadioButton;

        private global::System.Windows.Forms.RadioButton filterLevelNoneRadioButton;

        private global::System.Windows.Forms.GroupBox groupBox2;

        private global::System.Windows.Forms.CheckBox doNotShowScriptErrorsCheckBox;

        private global::System.Windows.Forms.Button okButton;

        private global::System.Windows.Forms.Button cancelButton;

        private global::System.Windows.Forms.Label label1;

        private global::System.Windows.Forms.RadioButton vietPhraseOneMeaning_AlwaysWrapExceptHanVietRadioButton;

        private global::System.Windows.Forms.RadioButton vietPhrase_AlwaysWrapExceptHanVietRadioButton;

        private global::System.Windows.Forms.GroupBox groupBox5;

        private global::System.Windows.Forms.RadioButton algorithm_LeftToRightRadioButton;

        private global::System.Windows.Forms.RadioButton algorithm_LongestVietPhraseFirstRadioButton;
    }
}

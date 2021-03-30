namespace QuickConverter
{
    // Token: 0x02000003 RID: 3
    public partial class MainForm
    {
        // Token: 0x06000022 RID: 34 RVA: 0x00004509 File Offset: 0x00003509
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000023 RID: 35 RVA: 0x00004528 File Offset: 0x00003528
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.columnComboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.columnComboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.columnComboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.columnComboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.columnComboBox5 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mergeFilesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.vietPhraseTranslationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.vietPhraseOneMeaningTranslationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.sourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.browseSourceFolderButton = new System.Windows.Forms.Button();
            this.targetFolderTextBox = new System.Windows.Forms.TextBox();
            this.browseTargetFolderButton = new System.Windows.Forms.Button();
            this.btnRunOrCancel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.processingStatusPanel = new System.Windows.Forms.Panel();
            this.processedFilesLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.translationAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.changeFileNameCheckBox = new System.Windows.Forms.CheckBox();
            this.insertBlankLinesCheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.columnComboBox6 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.onlineTranslationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.prioritizedNameCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mergeFilesNumericUpDown)).BeginInit();
            this.processingStatusPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư mục nguồn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thư mục đích:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Định dạng output:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputTypeComboBox
            // 
            this.outputTypeComboBox.DisplayMember = "0";
            this.outputTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputTypeComboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTypeComboBox.FormattingEnabled = true;
            this.outputTypeComboBox.Items.AddRange(new object[] {
            "Dạng cột cho dịch giả (Word)",
            "Dạng Quick Translator cho dịch giả (*.qt)",
            "Dạng VietPhrase cho độc giả (Word)",
            "Dạng VietPhrase cho độc giả (TXT)",
            "Dạng VietPhrase một nghĩa cho độc giả (Word)",
            "Dạng VietPhrase một nghĩa cho độc giả (TXT)",
            "Dạng Hán Việt cho độc giả (Word)",
            "Dạng Hán Việt cho độc giả (TXT)",
            "Dạng Trung (TXT)"});
            this.outputTypeComboBox.Location = new System.Drawing.Point(197, 74);
            this.outputTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputTypeComboBox.MaxDropDownItems = 10;
            this.outputTypeComboBox.Name = "outputTypeComboBox";
            this.outputTypeComboBox.Size = new System.Drawing.Size(324, 24);
            this.outputTypeComboBox.TabIndex = 5;
            this.outputTypeComboBox.ValueMember = "0";
            this.outputTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.OutputTypeComboBoxSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cột 1:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnComboBox1
            // 
            this.columnComboBox1.DropDownHeight = 136;
            this.columnComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnComboBox1.Enabled = false;
            this.columnComboBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnComboBox1.FormattingEnabled = true;
            this.columnComboBox1.IntegralHeight = false;
            this.columnComboBox1.Items.AddRange(new object[] {
            "<None>",
            "Trung",
            "Hán Việt",
            "VietPhrase",
            "VietPhrase một nghĩa",
            "Việt",
            "English (Google Translator)",
            "English (Yahoo Translator)",
            "English (SYSTRANet)"});
            this.columnComboBox1.Location = new System.Drawing.Point(197, 108);
            this.columnComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.columnComboBox1.Name = "columnComboBox1";
            this.columnComboBox1.Size = new System.Drawing.Size(324, 24);
            this.columnComboBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cột 2:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnComboBox2
            // 
            this.columnComboBox2.DropDownHeight = 136;
            this.columnComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnComboBox2.Enabled = false;
            this.columnComboBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnComboBox2.FormattingEnabled = true;
            this.columnComboBox2.IntegralHeight = false;
            this.columnComboBox2.Items.AddRange(new object[] {
            "<None>",
            "Trung",
            "Hán Việt",
            "VietPhrase",
            "VietPhrase một nghĩa",
            "Việt",
            "English (Google Translator)",
            "English (Yahoo Translator)",
            "English (SYSTRANet)"});
            this.columnComboBox2.Location = new System.Drawing.Point(197, 138);
            this.columnComboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.columnComboBox2.Name = "columnComboBox2";
            this.columnComboBox2.Size = new System.Drawing.Size(324, 24);
            this.columnComboBox2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cột 3:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnComboBox3
            // 
            this.columnComboBox3.DropDownHeight = 136;
            this.columnComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnComboBox3.Enabled = false;
            this.columnComboBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnComboBox3.FormattingEnabled = true;
            this.columnComboBox3.IntegralHeight = false;
            this.columnComboBox3.Items.AddRange(new object[] {
            "<None>",
            "Trung",
            "Hán Việt",
            "VietPhrase",
            "VietPhrase một nghĩa",
            "Việt",
            "English (Google Translator)",
            "English (Yahoo Translator)",
            "English (SYSTRANet)"});
            this.columnComboBox3.Location = new System.Drawing.Point(197, 167);
            this.columnComboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.columnComboBox3.Name = "columnComboBox3";
            this.columnComboBox3.Size = new System.Drawing.Size(324, 24);
            this.columnComboBox3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cột 4:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnComboBox4
            // 
            this.columnComboBox4.DropDownHeight = 136;
            this.columnComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnComboBox4.Enabled = false;
            this.columnComboBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnComboBox4.FormattingEnabled = true;
            this.columnComboBox4.IntegralHeight = false;
            this.columnComboBox4.Items.AddRange(new object[] {
            "<None>",
            "Trung",
            "Hán Việt",
            "VietPhrase",
            "VietPhrase một nghĩa",
            "Việt",
            "English (Google Translator)",
            "English (Yahoo Translator)",
            "English (SYSTRANet)"});
            this.columnComboBox4.Location = new System.Drawing.Point(197, 197);
            this.columnComboBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.columnComboBox4.Name = "columnComboBox4";
            this.columnComboBox4.Size = new System.Drawing.Size(324, 24);
            this.columnComboBox4.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cột 5:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnComboBox5
            // 
            this.columnComboBox5.DropDownHeight = 136;
            this.columnComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnComboBox5.Enabled = false;
            this.columnComboBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnComboBox5.FormattingEnabled = true;
            this.columnComboBox5.IntegralHeight = false;
            this.columnComboBox5.Items.AddRange(new object[] {
            "<None>",
            "Trung",
            "Hán Việt",
            "VietPhrase",
            "VietPhrase một nghĩa",
            "Việt",
            "English (Google Translator)",
            "English (Yahoo Translator)",
            "English (SYSTRANet)"});
            this.columnComboBox5.Location = new System.Drawing.Point(197, 226);
            this.columnComboBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.columnComboBox5.Name = "columnComboBox5";
            this.columnComboBox5.Size = new System.Drawing.Size(324, 24);
            this.columnComboBox5.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(533, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "Gộp files (N files -> 1 file):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mergeFilesNumericUpDown
            // 
            this.mergeFilesNumericUpDown.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeFilesNumericUpDown.Location = new System.Drawing.Point(757, 74);
            this.mergeFilesNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mergeFilesNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mergeFilesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mergeFilesNumericUpDown.Name = "mergeFilesNumericUpDown";
            this.mergeFilesNumericUpDown.Size = new System.Drawing.Size(91, 23);
            this.mergeFilesNumericUpDown.TabIndex = 11;
            this.mergeFilesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mergeFilesNumericUpDown.ThousandsSeparator = true;
            this.mergeFilesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(533, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "[…] cho VietPhrase:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vietPhraseTranslationTypeComboBox
            // 
            this.vietPhraseTranslationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vietPhraseTranslationTypeComboBox.Enabled = false;
            this.vietPhraseTranslationTypeComboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vietPhraseTranslationTypeComboBox.FormattingEnabled = true;
            this.vietPhraseTranslationTypeComboBox.Items.AddRange(new object[] {
            "Không sử dụng",
            "Luôn sử dụng (cả Hán Việt)",
            "Luôn sử dụng (trừ Hán Việt)",
            "Chỉ sử dụng nếu có hơn một nghĩa"});
            this.vietPhraseTranslationTypeComboBox.Location = new System.Drawing.Point(757, 138);
            this.vietPhraseTranslationTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vietPhraseTranslationTypeComboBox.Name = "vietPhraseTranslationTypeComboBox";
            this.vietPhraseTranslationTypeComboBox.Size = new System.Drawing.Size(265, 24);
            this.vietPhraseTranslationTypeComboBox.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(533, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "[…] cho VietPhrase một nghĩa:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vietPhraseOneMeaningTranslationTypeComboBox
            // 
            this.vietPhraseOneMeaningTranslationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vietPhraseOneMeaningTranslationTypeComboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vietPhraseOneMeaningTranslationTypeComboBox.FormattingEnabled = true;
            this.vietPhraseOneMeaningTranslationTypeComboBox.Items.AddRange(new object[] {
            "Không sử dụng",
            "Luôn sử dụng (cả Hán Việt)",
            "Luôn sử dụng (trừ Hán Việt)"});
            this.vietPhraseOneMeaningTranslationTypeComboBox.Location = new System.Drawing.Point(757, 167);
            this.vietPhraseOneMeaningTranslationTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vietPhraseOneMeaningTranslationTypeComboBox.Name = "vietPhraseOneMeaningTranslationTypeComboBox";
            this.vietPhraseOneMeaningTranslationTypeComboBox.Size = new System.Drawing.Size(265, 24);
            this.vietPhraseOneMeaningTranslationTypeComboBox.TabIndex = 13;
            // 
            // sourceFolderTextBox
            // 
            this.sourceFolderTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sourceFolderTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.sourceFolderTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceFolderTextBox.Location = new System.Drawing.Point(197, 11);
            this.sourceFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sourceFolderTextBox.Name = "sourceFolderTextBox";
            this.sourceFolderTextBox.Size = new System.Drawing.Size(719, 23);
            this.sourceFolderTextBox.TabIndex = 1;
            this.sourceFolderTextBox.TextChanged += new System.EventHandler(this.sourceFolderTextBox_TextChanged);
            // 
            // browseSourceFolderButton
            // 
            this.browseSourceFolderButton.Location = new System.Drawing.Point(928, 10);
            this.browseSourceFolderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseSourceFolderButton.Name = "browseSourceFolderButton";
            this.browseSourceFolderButton.Size = new System.Drawing.Size(100, 27);
            this.browseSourceFolderButton.TabIndex = 2;
            this.browseSourceFolderButton.Text = "Browse...";
            this.browseSourceFolderButton.UseVisualStyleBackColor = true;
            this.browseSourceFolderButton.Click += new System.EventHandler(this.BrowseSourceFolderButtonClick);
            // 
            // targetFolderTextBox
            // 
            this.targetFolderTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.targetFolderTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.targetFolderTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetFolderTextBox.Location = new System.Drawing.Point(197, 41);
            this.targetFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.targetFolderTextBox.Name = "targetFolderTextBox";
            this.targetFolderTextBox.Size = new System.Drawing.Size(719, 23);
            this.targetFolderTextBox.TabIndex = 3;
            // 
            // browseTargetFolderButton
            // 
            this.browseTargetFolderButton.Location = new System.Drawing.Point(928, 39);
            this.browseTargetFolderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseTargetFolderButton.Name = "browseTargetFolderButton";
            this.browseTargetFolderButton.Size = new System.Drawing.Size(100, 27);
            this.browseTargetFolderButton.TabIndex = 4;
            this.browseTargetFolderButton.Text = "Browse...";
            this.browseTargetFolderButton.UseVisualStyleBackColor = true;
            this.browseTargetFolderButton.Click += new System.EventHandler(this.BrowseTargetFolderButtonClick);
            // 
            // btnRunOrCancel
            // 
            this.btnRunOrCancel.Location = new System.Drawing.Point(464, 315);
            this.btnRunOrCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRunOrCancel.Name = "btnRunOrCancel";
            this.btnRunOrCancel.Size = new System.Drawing.Size(181, 28);
            this.btnRunOrCancel.TabIndex = 15;
            this.btnRunOrCancel.Text = "Run";
            this.btnRunOrCancel.UseVisualStyleBackColor = true;
            this.btnRunOrCancel.Click += new System.EventHandler(this.RunCancelButtonClick);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "Đã xử lý:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // processingStatusPanel
            // 
            this.processingStatusPanel.Controls.Add(this.processedFilesLabel);
            this.processingStatusPanel.Controls.Add(this.label12);
            this.processingStatusPanel.Location = new System.Drawing.Point(373, 354);
            this.processingStatusPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.processingStatusPanel.Name = "processingStatusPanel";
            this.processingStatusPanel.Size = new System.Drawing.Size(363, 57);
            this.processingStatusPanel.TabIndex = 7;
            this.processingStatusPanel.Visible = false;
            // 
            // processedFilesLabel
            // 
            this.processedFilesLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processedFilesLabel.Location = new System.Drawing.Point(192, 15);
            this.processedFilesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processedFilesLabel.Name = "processedFilesLabel";
            this.processedFilesLabel.Size = new System.Drawing.Size(167, 27);
            this.processedFilesLabel.TabIndex = 0;
            this.processedFilesLabel.Text = "xx/yy files (30%)";
            this.processedFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1037, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(241, 20);
            this.toolStripStatusLabel1.Text = "©2009 ngoctay@TangThuVien.com";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(533, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 27);
            this.label13.TabIndex = 0;
            this.label13.Text = "Thuật toán dịch:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // translationAlgorithmComboBox
            // 
            this.translationAlgorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.translationAlgorithmComboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationAlgorithmComboBox.FormattingEnabled = true;
            this.translationAlgorithmComboBox.Items.AddRange(new object[] {
            "Ưu tiên cụm VietPhrase dài",
            "Từ trái sang phải",
            "Ưu tiên cụm VietPhrase dài (>= 4 từ)"});
            this.translationAlgorithmComboBox.Location = new System.Drawing.Point(757, 197);
            this.translationAlgorithmComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.translationAlgorithmComboBox.Name = "translationAlgorithmComboBox";
            this.translationAlgorithmComboBox.Size = new System.Drawing.Size(265, 24);
            this.translationAlgorithmComboBox.TabIndex = 13;
            // 
            // changeFileNameCheckBox
            // 
            this.changeFileNameCheckBox.Checked = true;
            this.changeFileNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.changeFileNameCheckBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeFileNameCheckBox.Location = new System.Drawing.Point(757, 105);
            this.changeFileNameCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeFileNameCheckBox.Name = "changeFileNameCheckBox";
            this.changeFileNameCheckBox.Size = new System.Drawing.Size(267, 27);
            this.changeFileNameCheckBox.TabIndex = 14;
            this.changeFileNameCheckBox.Text = "Đổi lại tên file (VD: 0001, 0002, ...)";
            this.changeFileNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // insertBlankLinesCheckBox
            // 
            this.insertBlankLinesCheckBox.Checked = true;
            this.insertBlankLinesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.insertBlankLinesCheckBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBlankLinesCheckBox.Location = new System.Drawing.Point(757, 286);
            this.insertBlankLinesCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertBlankLinesCheckBox.Name = "insertBlankLinesCheckBox";
            this.insertBlankLinesCheckBox.Size = new System.Drawing.Size(240, 27);
            this.insertBlankLinesCheckBox.TabIndex = 14;
            this.insertBlankLinesCheckBox.Text = "Chèn dòng trắng giữa các đoạn";
            this.insertBlankLinesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 256);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 27);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cột 6:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnComboBox6
            // 
            this.columnComboBox6.DropDownHeight = 136;
            this.columnComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnComboBox6.Enabled = false;
            this.columnComboBox6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnComboBox6.FormattingEnabled = true;
            this.columnComboBox6.IntegralHeight = false;
            this.columnComboBox6.Items.AddRange(new object[] {
            "<None>",
            "Trung",
            "Hán Việt",
            "VietPhrase",
            "VietPhrase một nghĩa",
            "Việt",
            "English (Google Translator)",
            "English (Yahoo Translator)",
            "English (SYSTRANet)"});
            this.columnComboBox6.Location = new System.Drawing.Point(197, 256);
            this.columnComboBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.columnComboBox6.Name = "columnComboBox6";
            this.columnComboBox6.Size = new System.Drawing.Size(324, 24);
            this.columnComboBox6.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(533, 256);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "Thuật toán dịch (online):";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // onlineTranslationTypeComboBox
            // 
            this.onlineTranslationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.onlineTranslationTypeComboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineTranslationTypeComboBox.FormattingEnabled = true;
            this.onlineTranslationTypeComboBox.Items.AddRange(new object[] {
            "Chậm (ít bị lỗi)",
            "Nhanh (dễ bị lỗi)"});
            this.onlineTranslationTypeComboBox.Location = new System.Drawing.Point(757, 256);
            this.onlineTranslationTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onlineTranslationTypeComboBox.Name = "onlineTranslationTypeComboBox";
            this.onlineTranslationTypeComboBox.Size = new System.Drawing.Size(265, 24);
            this.onlineTranslationTypeComboBox.TabIndex = 13;
            // 
            // prioritizedNameCheckBox
            // 
            this.prioritizedNameCheckBox.Checked = true;
            this.prioritizedNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prioritizedNameCheckBox.Location = new System.Drawing.Point(757, 226);
            this.prioritizedNameCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prioritizedNameCheckBox.Name = "prioritizedNameCheckBox";
            this.prioritizedNameCheckBox.Size = new System.Drawing.Size(229, 30);
            this.prioritizedNameCheckBox.TabIndex = 28;
            this.prioritizedNameCheckBox.Text = "Ưu tiên Name hơn VietPhrase";
            this.prioritizedNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 454);
            this.Controls.Add(this.prioritizedNameCheckBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.processingStatusPanel);
            this.Controls.Add(this.btnRunOrCancel);
            this.Controls.Add(this.browseTargetFolderButton);
            this.Controls.Add(this.browseSourceFolderButton);
            this.Controls.Add(this.targetFolderTextBox);
            this.Controls.Add(this.sourceFolderTextBox);
            this.Controls.Add(this.changeFileNameCheckBox);
            this.Controls.Add(this.insertBlankLinesCheckBox);
            this.Controls.Add(this.mergeFilesNumericUpDown);
            this.Controls.Add(this.onlineTranslationTypeComboBox);
            this.Controls.Add(this.translationAlgorithmComboBox);
            this.Controls.Add(this.vietPhraseOneMeaningTranslationTypeComboBox);
            this.Controls.Add(this.vietPhraseTranslationTypeComboBox);
            this.Controls.Add(this.columnComboBox6);
            this.Controls.Add(this.columnComboBox5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.columnComboBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.columnComboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.columnComboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.columnComboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputTypeComboBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mergeFilesNumericUpDown)).EndInit();
            this.processingStatusPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x0400001D RID: 29
        private global::System.ComponentModel.IContainer components;

        // Token: 0x0400001E RID: 30
        private global::System.Windows.Forms.CheckBox prioritizedNameCheckBox;

        // Token: 0x0400001F RID: 31
        private global::System.Windows.Forms.ComboBox onlineTranslationTypeComboBox;

        // Token: 0x04000020 RID: 32
        private global::System.Windows.Forms.Label label15;

        // Token: 0x04000021 RID: 33
        private global::System.Windows.Forms.ComboBox columnComboBox6;

        // Token: 0x04000022 RID: 34
        private global::System.Windows.Forms.Label label14;

        // Token: 0x04000023 RID: 35
        private global::System.Windows.Forms.CheckBox changeFileNameCheckBox;

        // Token: 0x04000024 RID: 36
        private global::System.Windows.Forms.ComboBox translationAlgorithmComboBox;

        // Token: 0x04000025 RID: 37
        private global::System.Windows.Forms.Label label13;

        // Token: 0x04000026 RID: 38
        private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        // Token: 0x04000027 RID: 39
        private global::System.Windows.Forms.StatusStrip statusStrip1;

        // Token: 0x04000028 RID: 40
        private global::System.Windows.Forms.Label processedFilesLabel;

        // Token: 0x04000029 RID: 41
        private global::System.Windows.Forms.Button btnRunOrCancel;

        // Token: 0x0400002A RID: 42
        private global::System.Windows.Forms.Button browseTargetFolderButton;

        // Token: 0x0400002B RID: 43
        private global::System.Windows.Forms.TextBox targetFolderTextBox;

        // Token: 0x0400002C RID: 44
        private global::System.Windows.Forms.Button browseSourceFolderButton;

        // Token: 0x0400002D RID: 45
        private global::System.Windows.Forms.TextBox sourceFolderTextBox;

        // Token: 0x0400002E RID: 46
        private global::System.Windows.Forms.CheckBox insertBlankLinesCheckBox;

        // Token: 0x0400002F RID: 47
        private global::System.Windows.Forms.ComboBox vietPhraseOneMeaningTranslationTypeComboBox;

        // Token: 0x04000030 RID: 48
        private global::System.Windows.Forms.ComboBox vietPhraseTranslationTypeComboBox;

        // Token: 0x04000031 RID: 49
        private global::System.Windows.Forms.NumericUpDown mergeFilesNumericUpDown;

        // Token: 0x04000032 RID: 50
        private global::System.Windows.Forms.ComboBox columnComboBox5;

        // Token: 0x04000033 RID: 51
        private global::System.Windows.Forms.ComboBox columnComboBox4;

        // Token: 0x04000034 RID: 52
        private global::System.Windows.Forms.ComboBox columnComboBox3;

        // Token: 0x04000035 RID: 53
        private global::System.Windows.Forms.ComboBox columnComboBox2;

        // Token: 0x04000036 RID: 54
        private global::System.Windows.Forms.ComboBox columnComboBox1;

        // Token: 0x04000037 RID: 55
        private global::System.Windows.Forms.Panel processingStatusPanel;

        // Token: 0x04000038 RID: 56
        private global::System.Windows.Forms.Label label12;

        // Token: 0x04000039 RID: 57
        private global::System.Windows.Forms.Label label11;

        // Token: 0x0400003A RID: 58
        private global::System.Windows.Forms.Label label10;

        // Token: 0x0400003B RID: 59
        private global::System.Windows.Forms.Label label9;

        // Token: 0x0400003C RID: 60
        private global::System.Windows.Forms.Label label8;

        // Token: 0x0400003D RID: 61
        private global::System.Windows.Forms.Label label7;

        // Token: 0x0400003E RID: 62
        private global::System.Windows.Forms.Label label6;

        // Token: 0x0400003F RID: 63
        private global::System.Windows.Forms.Label label5;

        // Token: 0x04000040 RID: 64
        private global::System.Windows.Forms.Label label4;

        // Token: 0x04000041 RID: 65
        private global::System.Windows.Forms.ComboBox outputTypeComboBox;

        // Token: 0x04000042 RID: 66
        private global::System.Windows.Forms.Label label3;

        // Token: 0x04000043 RID: 67
        private global::System.Windows.Forms.Label label2;

        // Token: 0x04000044 RID: 68
        private global::System.Windows.Forms.Label label1;
    }
}

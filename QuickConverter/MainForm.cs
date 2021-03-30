using OnlineTranslationEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TranslatorEngine;

using static TranslatorEngine.TranslatorEngine;

namespace QuickConverter
{
    // Token: 0x02000003 RID: 3
    public partial class MainForm : Form
    {
        // Token: 0x06000008 RID: 8 RVA: 0x00002685 File Offset: 0x00001685
        public MainForm()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000009 RID: 9 RVA: 0x00002694 File Offset: 0x00001694
        private void BrowseSourceFolderButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.sourceFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        // Token: 0x0600000A RID: 10 RVA: 0x000026CC File Offset: 0x000016CC
        private void BrowseTargetFolderButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.targetFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        // Token: 0x0600000B RID: 11 RVA: 0x00002704 File Offset: 0x00001704
        private void MainFormLoad(object sender, EventArgs e)
        {
            this.sourceFolderTextBox.Text = QuickConverterSettings.Default.sourceFolder;
            this.targetFolderTextBox.Text = QuickConverterSettings.Default.targetFolder;
            this.outputTypeComboBox.SelectedIndex = QuickConverterSettings.Default.outputType;
            this.columnComboBox1.SelectedIndex = QuickConverterSettings.Default.column1;
            this.columnComboBox2.SelectedIndex = QuickConverterSettings.Default.column2;
            this.columnComboBox3.SelectedIndex = QuickConverterSettings.Default.column3;
            this.columnComboBox4.SelectedIndex = QuickConverterSettings.Default.column4;
            this.columnComboBox5.SelectedIndex = QuickConverterSettings.Default.column5;
            this.columnComboBox6.SelectedIndex = QuickConverterSettings.Default.column6;
            this.vietPhraseTranslationTypeComboBox.SelectedIndex = QuickConverterSettings.Default.vietPhraseTranslationType;
            this.vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex = QuickConverterSettings.Default.vietPhraseOneMeaningTranslationType;
            this.translationAlgorithmComboBox.SelectedIndex = QuickConverterSettings.Default.translationAlgorithm;
            this.onlineTranslationTypeComboBox.SelectedIndex = QuickConverterSettings.Default.onlineTranslationAlgorithm;
            this.mergeFilesNumericUpDown.Value = QuickConverterSettings.Default.mergeFiles;
            this.changeFileNameCheckBox.Checked = QuickConverterSettings.Default.changeFileName;
            this.insertBlankLinesCheckBox.Checked = QuickConverterSettings.Default.insertBlankLines;
            this.prioritizedNameCheckBox.Checked = QuickConverterSettings.Default.prioritizedName;
            LoadDictionaries();
        }

        // Token: 0x0600000C RID: 12 RVA: 0x00002880 File Offset: 0x00001880
        private void OutputTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            this.columnComboBox1.Enabled = (this.outputTypeComboBox.SelectedIndex == 0);
            this.columnComboBox2.Enabled = (this.outputTypeComboBox.SelectedIndex == 0);
            this.columnComboBox3.Enabled = (this.outputTypeComboBox.SelectedIndex == 0);
            this.columnComboBox4.Enabled = (this.outputTypeComboBox.SelectedIndex == 0);
            this.columnComboBox5.Enabled = (this.outputTypeComboBox.SelectedIndex == 0);
            this.columnComboBox6.Enabled = (this.outputTypeComboBox.SelectedIndex == 0);
            this.vietPhraseTranslationTypeComboBox.Enabled = (this.outputTypeComboBox.SelectedIndex == 0 || this.outputTypeComboBox.SelectedIndex == 2 || this.outputTypeComboBox.SelectedIndex == 3);
            this.vietPhraseOneMeaningTranslationTypeComboBox.Enabled = (this.outputTypeComboBox.SelectedIndex != 1 && this.outputTypeComboBox.SelectedIndex != 2 && this.outputTypeComboBox.SelectedIndex != 3 && this.outputTypeComboBox.SelectedIndex != 6 && this.outputTypeComboBox.SelectedIndex != 7 && this.outputTypeComboBox.SelectedIndex != 8);
            this.translationAlgorithmComboBox.Enabled = (this.outputTypeComboBox.SelectedIndex != 1 && this.outputTypeComboBox.SelectedIndex != 6 && this.outputTypeComboBox.SelectedIndex != 7 && this.outputTypeComboBox.SelectedIndex != 8);
            this.onlineTranslationTypeComboBox.Enabled = (this.outputTypeComboBox.SelectedIndex == 0);
        }

        // Token: 0x0600000D RID: 13 RVA: 0x00002A24 File Offset: 0x00001A24
        private void RunCancelButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.runCancelButtonClickHandler();
            }
            catch (Exception)
            {
            }
        }

        // Token: 0x0600000E RID: 14 RVA: 0x00002A4C File Offset: 0x00001A4C
        private void runCancelButtonClickHandler()
        {
            this.btnRunOrCancel.Text = (this.isProcessing ? "Run" : "Cancel");
            if (this.isProcessing)
            {
                this.requestCancel = true;
                this.isProcessing = false;
                return;
            }
            if (!Directory.Exists(this.sourceFolderTextBox.Text))
            {
                MessageBox.Show("Thư mục nguồn không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.browseSourceFolderButton.Focus();
                this.btnRunOrCancel.Text = "Run";
                return;
            }
            if (string.IsNullOrEmpty(this.targetFolderTextBox.Text))
            {
                MessageBox.Show("Nhập thư mục đích!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.browseTargetFolderButton.Focus();
                this.btnRunOrCancel.Text = "Run";
                return;
            }
            if (!Directory.Exists(this.targetFolderTextBox.Text))
            {
                Directory.CreateDirectory(this.targetFolderTextBox.Text);
            }
            string[] source = File.ReadAllLines(Path.Combine(Constants.AssetsDir, "IgnoredFiles.txt"));
            string[] files = Directory.GetFiles(this.sourceFolderTextBox.Text);
            List<string> list = new List<string>();
            foreach (string text in files)
            {
                if (!source.Contains("*" + Path.GetExtension(text)) && !source.Contains(Path.GetFileName(text)))
                {
                    list.Add(text);
                }
            }
            list.Sort();
            if (list.Count == 0)
            {
                MessageBox.Show("Không tìm thấy file trong thư mục nguồn!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.browseSourceFolderButton.Focus();
                this.btnRunOrCancel.Text = "Run";
                return;
            }
            this.isProcessing = true;
            this.requestCancel = false;
            this.btnRunOrCancel.Text = "Analyzing...";
            this.btnRunOrCancel.Enabled = false;
            Application.DoEvents();
            this.startTime = DateTime.Now;
            string[] array2;
            string[] chineseContents = this.mergeSourceFiles(list.ToArray(), int.Parse(this.mergeFilesNumericUpDown.Text.Replace(",", "")), out array2);
            this.processStatus = new int[array2.Length];
            this.hanVietResult = new string[array2.Length];
            this.vietPhraseResult = new string[array2.Length];
            this.vietPhraseOneMeaningResult = new string[array2.Length];
            this.onlineResult = new string[array2.Length];
            this.calculateDoneStatus();
            this.updateProcessingStatus(list.Count, int.Parse(this.mergeFilesNumericUpDown.Text.Replace(",", "")));
            if (this.outputTypeComboBox.SelectedIndex == 0)
            {
                int[] columnIndexes = new int[]
                {
                    this.columnComboBox1.SelectedIndex,
                    this.columnComboBox2.SelectedIndex,
                    this.columnComboBox3.SelectedIndex,
                    this.columnComboBox4.SelectedIndex,
                    this.columnComboBox5.SelectedIndex,
                    this.columnComboBox6.SelectedIndex
                };
                this.translateColumnFormat(chineseContents, columnIndexes);
                this.exportColumnFormat(chineseContents, array2);
                return;
            }
            if (this.outputTypeComboBox.SelectedIndex == 1)
            {
                this.translateAndExportQuickTranslatorFormat(chineseContents, array2);
                return;
            }
            if (this.outputTypeComboBox.SelectedIndex == 2 || this.outputTypeComboBox.SelectedIndex == 3)
            {
                this.translateAndExportVietPhraseFormat(chineseContents, array2);
                return;
            }
            if (this.outputTypeComboBox.SelectedIndex == 4 || this.outputTypeComboBox.SelectedIndex == 5)
            {
                this.translateAndExportVietPhraseOneMeaningFormat(chineseContents, array2);
                return;
            }
            if (this.outputTypeComboBox.SelectedIndex == 6 || this.outputTypeComboBox.SelectedIndex == 7)
            {
                this.translateAndExportHanVietFormat(chineseContents, array2);
                return;
            }
            this.translateAndExportChineseFormat(chineseContents, array2);
        }

        // Token: 0x0600000F RID: 15 RVA: 0x00002DF4 File Offset: 0x00001DF4
        private string[] mergeSourceFiles(string[] sourceFiles, int mergeOption, out string[] mergedFileNames)
        {
            string name = CharsetDetector.DetectChineseCharset(sourceFiles[0]);
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            bool @checked = this.changeFileNameCheckBox.Checked;
            int num = sourceFiles.Length;
            bool needMarkChapterHeaders = this.outputTypeComboBox.SelectedIndex == 2 || this.outputTypeComboBox.SelectedIndex == 4 || this.outputTypeComboBox.SelectedIndex == 6;
            for (int i = 0; i < num; i += mergeOption)
            {
                stringBuilder.Length = 0;
                stringBuilder2.Length = 0;
                int num2 = 0;
                while (num2 < mergeOption && sourceFiles.Length > i + num2)
                {
                    stringBuilder.Append(StandardizeInput(this.readFile(sourceFiles[i + num2], Encoding.GetEncoding(name), needMarkChapterHeaders))).Append("\n\n----------oOo----------\n\n");
                    if (num2 == 0)
                    {
                        stringBuilder2.Append(this.getOutputFileName(sourceFiles[i + num2], i + num2, num, @checked));
                    }
                    else if (mergeOption != 1 && (num2 == mergeOption - 1 || i + num2 == sourceFiles.Length - 1))
                    {
                        stringBuilder2.Append(" - ").Append(this.getOutputFileName(sourceFiles[i + num2], i + num2, num, @checked));
                    }
                    num2++;
                }
                list.Add(stringBuilder.ToString());
                list2.Add(stringBuilder2.ToString());
            }
            mergedFileNames = list2.ToArray();
            return list.ToArray();
        }

        // Token: 0x06000010 RID: 16 RVA: 0x00002F64 File Offset: 0x00001F64
        private string getOutputFileName(string filePath, int fileIndex, int totalFileCount, bool numberingFileName)
        {
            string result = Path.GetFileName(filePath);
            if (numberingFileName)
            {
                string format = "{0:00000}";
                if (totalFileCount < 10)
                {
                    format = "{0:0}";
                }
                else if (totalFileCount < 100)
                {
                    format = "{0:00}";
                }
                else if (totalFileCount < 1000)
                {
                    format = "{0:000}";
                }
                else if (totalFileCount < 10000)
                {
                    format = "{0:0000}";
                }
                result = string.Format(format, fileIndex + 1);
            }
            return result;
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002FCC File Offset: 0x00001FCC
        private string readFile(string filePath, Encoding encoding, bool needMarkChapterHeaders)
        {
            string text = File.ReadAllText(filePath, encoding);
            if (filePath.EndsWith("html") || filePath.EndsWith("htm") || filePath.EndsWith("asp") || filePath.EndsWith("aspx") || filePath.EndsWith("php"))
            {
                text = HtmlParser.GetChineseContent(text, needMarkChapterHeaders);
            }
            else if (needMarkChapterHeaders && text.Contains("\n"))
            {
                string text2 = text.Substring(0, text.IndexOf('\n'));
                if (text2.Contains("第") && text2.Contains("章"))
                {
                    text = "$CHAPTER_HEADER$. " + text.TrimStart(" \u3000\t".ToCharArray());
                }
            }
            return text;
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00003084 File Offset: 0x00002084
        private void translateColumnFormat(string[] chineseContents, int[] columnIndexes)
        {
            int wrapType = (this.vietPhraseTranslationTypeComboBox.SelectedIndex == 2) ? 11 : this.vietPhraseTranslationTypeComboBox.SelectedIndex;
            int wrapType2 = (this.vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex == 2) ? 11 : this.vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex;
            int selectedIndex = this.translationAlgorithmComboBox.SelectedIndex;
            int selectedIndex2 = this.onlineTranslationTypeComboBox.SelectedIndex;
            bool @checked = this.prioritizedNameCheckBox.Checked;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                for (int j = 0; j < columnIndexes.Length; j++)
                {
                    if (columnIndexes[j] == 1)
                    {
                        this.processStatus[i]++;
                    }
                    else if (columnIndexes[j] == 2)
                    {
                        this.translateHanViet(chineseContents[i], i);
                    }
                    else if (columnIndexes[j] == 3)
                    {
                        this.translateVietPhrase(chineseContents[i], wrapType, selectedIndex, @checked, i);
                    }
                    else if (columnIndexes[j] == 4)
                    {
                        this.translateVietPhraseOneMeaning(chineseContents[i], wrapType2, selectedIndex, @checked, i);
                    }
                    else if (columnIndexes[j] == 5)
                    {
                        this.processStatus[i]++;
                    }
                    else if (columnIndexes[j] >= 6)
                    {
                        try
                        {
                            int translationEngine;
                            if (columnIndexes[j] == 6)
                            {
                                translationEngine = 1;
                            }
                            else if (columnIndexes[j] == 7)
                            {
                                translationEngine = 2;
                            }
                            else
                            {
                                translationEngine = 3;
                            }
                            this.translateOnline(chineseContents[i], i, translationEngine, selectedIndex2);
                        }
                        catch (Exception)
                        {
                            this.requestCancel = true;
                            MessageBox.Show("Internet connection failed!");
                        }
                    }
                }
            }
        }

        // Token: 0x06000013 RID: 19 RVA: 0x000033C4 File Offset: 0x000023C4
        private void exportColumnFormat(string[] chineseContents, string[] mergedFileNames)
        {
            bool needToRemoveBlankLine = !this.insertBlankLinesCheckBox.Checked;
            string targetFolder = this.targetFolderTextBox.Text;
            List<string> list = new List<string>();
            if (this.columnComboBox1.Text != "<None>")
            {
                list.Add(this.columnComboBox1.Text);
            }
            if (this.columnComboBox2.Text != "<None>")
            {
                list.Add(this.columnComboBox2.Text);
            }
            if (this.columnComboBox3.Text != "<None>")
            {
                list.Add(this.columnComboBox3.Text);
            }
            if (this.columnComboBox4.Text != "<None>")
            {
                list.Add(this.columnComboBox4.Text);
            }
            if (this.columnComboBox5.Text != "<None>")
            {
                list.Add(this.columnComboBox5.Text);
            }
            if (this.columnComboBox6.Text != "<None>")
            {
                list.Add(this.columnComboBox6.Text);
            }
            string[] columnNames = list.ToArray();
            new Thread(delegate () {
                while (!this.requestCancel)
                {
                    if (!this.isProcessing)
                    {
                        return;
                    }
                    for (int i = 0; i < this.processStatus.Length; i++)
                    {
                        if (this.processStatus[i] == this.doneStatus - 1)
                        {
                            string[] array = new string[columnNames.Length];
                            for (int j = 0; j < columnNames.Length; j++)
                            {
                                if (columnNames[j] == "Trung")
                                {
                                    array[j] = chineseContents[i];
                                }
                                else if (columnNames[j] == "Hán Việt")
                                {
                                    array[j] = this.hanVietResult[i];
                                }
                                else if (columnNames[j] == "VietPhrase")
                                {
                                    array[j] = this.vietPhraseResult[i];
                                }
                                else if (columnNames[j] == "VietPhrase một nghĩa")
                                {
                                    array[j] = this.vietPhraseOneMeaningResult[i];
                                }
                                else if (columnNames[j] == "Việt")
                                {
                                    array[j] = "";
                                }
                                else
                                {
                                    array[j] = this.onlineResult[i];
                                }
                            }
                            ColumnExporter.Export(columnNames, array, needToRemoveBlankLine, Path.Combine(targetFolder, mergedFileNames[i] + ".doc"));
                            this.processStatus[i]++;
                        }
                    }
                    Thread.Sleep(1000);
                }
            }) {
                IsBackground = true
            }.Start();
        }

        // Token: 0x06000014 RID: 20 RVA: 0x000035F4 File Offset: 0x000025F4
        private void translateAndExportVietPhraseFormat(string[] chineseContents, string[] mergedFileNames)
        {
            int wrapType = (this.vietPhraseTranslationTypeComboBox.SelectedIndex == 2) ? 11 : this.vietPhraseTranslationTypeComboBox.SelectedIndex;
            bool needToRemoveBlankLine = !this.insertBlankLinesCheckBox.Checked;
            string targetFolder = this.targetFolderTextBox.Text;
            bool outputToWord = this.outputTypeComboBox.SelectedIndex == 2;
            int translationAlgorithm = this.translationAlgorithmComboBox.SelectedIndex;
            bool prioritizedName = this.prioritizedNameCheckBox.Checked;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                if (this.requestCancel)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(delegate (object batchIndexObject) {
                    if (this.requestCancel)
                    {
                        return;
                    }
                    int num = (int)batchIndexObject;
                    VietPhraseExporter.Export(ChineseToVietPhraseForBatch(chineseContents[num], wrapType, translationAlgorithm, prioritizedName), needToRemoveBlankLine, Path.Combine(targetFolder, mergedFileNames[num] + (outputToWord ? ".doc" : (mergedFileNames[num].EndsWith("txt") ? "" : ".txt"))), outputToWord);
                    this.processStatus[num]++;
                }, i);
            }
        }

        // Token: 0x06000015 RID: 21 RVA: 0x00003798 File Offset: 0x00002798
        private void translateAndExportVietPhraseOneMeaningFormat(string[] chineseContents, string[] mergedFileNames)
        {
            int wrapType = (this.vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex == 2) ? 11 : this.vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex;
            bool needToRemoveBlankLine = !this.insertBlankLinesCheckBox.Checked;
            string targetFolder = this.targetFolderTextBox.Text;
            bool outputToWord = this.outputTypeComboBox.SelectedIndex == 4;
            int translationAlgorithm = this.translationAlgorithmComboBox.SelectedIndex;
            bool prioritizedName = this.prioritizedNameCheckBox.Checked;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                if (this.requestCancel)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(delegate (object batchIndexObject) {
                    if (this.requestCancel)
                    {
                        return;
                    }
                    int num = (int)batchIndexObject;
                    VietPhraseExporter.Export(ChineseToVietPhraseOneMeaningForBatch(chineseContents[num], wrapType, translationAlgorithm, prioritizedName), needToRemoveBlankLine, Path.Combine(targetFolder, mergedFileNames[num] + (outputToWord ? ".doc" : (mergedFileNames[num].EndsWith("txt") ? "" : ".txt"))), outputToWord);
                    this.processStatus[num]++;
                }, i);
            }
        }

        // Token: 0x06000016 RID: 22 RVA: 0x0000392C File Offset: 0x0000292C
        private void translateAndExportHanVietFormat(string[] chineseContents, string[] mergedFileNames)
        {
            bool needToRemoveBlankLine = !this.insertBlankLinesCheckBox.Checked;
            string targetFolder = this.targetFolderTextBox.Text;
            bool outputToWord = this.outputTypeComboBox.SelectedIndex == 6;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                if (this.requestCancel)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(delegate (object batchIndexObject) {
                    if (this.requestCancel)
                    {
                        return;
                    }
                    int num = (int)batchIndexObject;
                    VietPhraseExporter.Export(ChineseToHanVietForBatch(chineseContents[num]), needToRemoveBlankLine, Path.Combine(targetFolder, mergedFileNames[num] + (outputToWord ? ".doc" : (mergedFileNames[num].EndsWith("txt") ? "" : ".txt"))), outputToWord);
                    this.processStatus[num]++;
                }, i);
            }
        }

        // Token: 0x06000017 RID: 23 RVA: 0x00003AF0 File Offset: 0x00002AF0
        private void translateAndExportQuickTranslatorFormat(string[] chineseContents, string[] mergedFileNames)
        {
            bool needToRemoveBlankLine = !this.insertBlankLinesCheckBox.Checked;
            string targetFolder = this.targetFolderTextBox.Text;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                if (this.requestCancel)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(delegate (object batchIndexObject) {
                    if (this.requestCancel)
                    {
                        return;
                    }
                    int num = (int)batchIndexObject;
                    string path = Path.Combine(targetFolder, mergedFileNames[num] + ".qt");
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("[CurrentLines]\n");
                    stringBuilder.Append("0\n");
                    stringBuilder.Append("0\n");
                    stringBuilder.Append("0\n");
                    stringBuilder.Append("[Chinese]\n");
                    stringBuilder.Append(needToRemoveBlankLine ? chineseContents[num].Replace("\n\n", "\n") : chineseContents[num]);
                    stringBuilder.Append("\n");
                    stringBuilder.Append("[Viet]\n");
                    stringBuilder.Append("{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Arial Unicode MS;}}\n");
                    stringBuilder.Append("\\viewkind4\\uc1\\pard\\f0\\fs24\\par\n");
                    stringBuilder.Append("}\n");
                    File.WriteAllText(path, stringBuilder.ToString(), Encoding.UTF8);
                    this.processStatus[num]++;
                }, i);
            }
        }

        // Token: 0x06000018 RID: 24 RVA: 0x00003C0C File Offset: 0x00002C0C
        private void translateAndExportChineseFormat(string[] chineseContents, string[] mergedFileNames)
        {
            bool needToRemoveBlankLine = !this.insertBlankLinesCheckBox.Checked;
            string targetFolder = this.targetFolderTextBox.Text;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                if (this.requestCancel)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(delegate (object batchIndexObject) {
                    if (this.requestCancel)
                    {
                        return;
                    }
                    int num = (int)batchIndexObject;
                    VietPhraseExporter.Export(chineseContents[num], needToRemoveBlankLine, Path.Combine(targetFolder, mergedFileNames[num] + (mergedFileNames[num].EndsWith("txt") ? "" : ".txt")), false);
                    this.processStatus[num]++;
                }, i);
            }
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00003CF8 File Offset: 0x00002CF8
        private void translateHanViet(string chineseContent, int batchId)
        {
            if (this.requestCancel)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(delegate (object param0) {
                if (this.requestCancel)
                {
                    return;
                }
                this.hanVietResult[batchId] = ChineseToHanVietForBatch(chineseContent);
                this.processStatus[batchId]++;
            });
        }

        // Token: 0x0600001A RID: 26 RVA: 0x00003DB4 File Offset: 0x00002DB4
        private void translateVietPhraseOneMeaning(string chineseContent, int wrapType, int translationAlgorithm, bool prioritizedName, int batchId)
        {
            if (this.requestCancel)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(delegate (object param0) {
                if (this.requestCancel)
                {
                    return;
                }
                this.vietPhraseOneMeaningResult[batchId] = ChineseToVietPhraseOneMeaningForBatch(chineseContent, wrapType, translationAlgorithm, prioritizedName);
                this.processStatus[batchId]++;
            });
        }

        // Token: 0x0600001B RID: 27 RVA: 0x00003E88 File Offset: 0x00002E88
        private void translateVietPhrase(string chineseContent, int wrapType, int translationAlgorithm, bool prioritizedName, int batchId)
        {
            if (this.requestCancel)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(delegate (object param0) {
                if (this.requestCancel)
                {
                    return;
                }
                this.vietPhraseResult[batchId] = ChineseToVietPhraseForBatch(chineseContent, wrapType, translationAlgorithm, prioritizedName);
                this.processStatus[batchId]++;
            });
        }

        // Token: 0x0600001C RID: 28 RVA: 0x00003F7C File Offset: 0x00002F7C
        private void translateOnline(string chineseContent, int batchId, int translationEngine, int onlineTranslationAlgorithm)
        {
            if (this.requestCancel)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(delegate (object param0) {
                if (this.requestCancel)
                {
                    return;
                }
                try
                {
                    this.onlineResult[batchId] = Engine.ChineseToEnglish(ChineseToNameForBatch(chineseContent), translationEngine, onlineTranslationAlgorithm);
                }
                catch (Exception ex)
                {
                    this.requestCancel = true;
                    throw ex;
                }
                this.processStatus[batchId]++;
            });
        }

        // Token: 0x0600001D RID: 29 RVA: 0x00004124 File Offset: 0x00003124
        private void updateProcessingStatus(int sourceFileCount, int mergeOption)
        {
            new Thread(delegate () {
                while (!this.requestCancel)
                {
                    int num = 0;
                    foreach (int num2 in this.processStatus)
                    {
                        if (num2 == this.doneStatus)
                        {
                            num++;
                        }
                    }
                    bool flag = num * mergeOption >= sourceFileCount;
                    string processingStatusText;
                    if (flag)
                    {
                        processingStatusText = string.Concat(new object[]
                        {
                            sourceFileCount,
                            "/",
                            sourceFileCount,
                            " files (100%)"
                        });
                    }
                    else
                    {
                        processingStatusText = string.Concat(new object[]
                        {
                            num * mergeOption,
                            "/",
                            sourceFileCount,
                            " files (",
                            ((double)num * (double)mergeOption / (double)sourceFileCount).ToString("0.0%"),
                            ")"
                        });
                    }
                    this.updateProcessingStatusToGui(processingStatusText, flag);
                    if (flag)
                    {
                        this.isProcessing = false;
                        return;
                    }
                    Thread.Sleep(1000);
                }
            }) {
                IsBackground = true
            }.Start();
        }

        // Token: 0x0600001E RID: 30 RVA: 0x00004254 File Offset: 0x00003254
        private void updateProcessingStatusToGui(string processingStatusText, bool done)
        {
            MainForm.GenericDelegate method = delegate () {
                this.processingStatusPanel.Visible = true;
                this.processedFilesLabel.Text = processingStatusText;
                this.btnRunOrCancel.Enabled = true;
                this.btnRunOrCancel.Text = (done ? "Run" : "Cancel");
                if (done)
                {
                    TimeSpan timeSpan = DateTime.Now.Subtract(this.startTime);
                    MessageBox.Show("Done!!! Running Time = " + timeSpan, "Quick Converter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (this.requestCancel)
                {
                    MessageBox.Show("Cancelled by user!!!", "Quick Converter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.btnRunOrCancel.Text = "Run";
                }
            };
            base.BeginInvoke(method);
        }

        // Token: 0x0600001F RID: 31 RVA: 0x00004294 File Offset: 0x00003294
        private void calculateDoneStatus()
        {
            this.doneStatus = 0;
            if (this.outputTypeComboBox.SelectedIndex != 0)
            {
                this.doneStatus = 1;
                return;
            }
            this.doneStatus = 1;
            if (this.columnComboBox1.SelectedIndex != 0)
            {
                this.doneStatus++;
            }
            if (this.columnComboBox2.SelectedIndex != 0)
            {
                this.doneStatus++;
            }
            if (this.columnComboBox3.SelectedIndex != 0)
            {
                this.doneStatus++;
            }
            if (this.columnComboBox4.SelectedIndex != 0)
            {
                this.doneStatus++;
            }
            if (this.columnComboBox5.SelectedIndex != 0)
            {
                this.doneStatus++;
            }
            if (this.columnComboBox6.SelectedIndex != 0)
            {
                this.doneStatus++;
            }
        }

        // Token: 0x06000020 RID: 32 RVA: 0x00004366 File Offset: 0x00003366
        private void sourceFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            this.targetFolderTextBox.Text = this.sourceFolderTextBox.Text + "\\QuickConverter";
        }

        // Token: 0x06000021 RID: 33 RVA: 0x00004388 File Offset: 0x00003388
        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            QuickConverterSettings.Default.sourceFolder = this.sourceFolderTextBox.Text;
            QuickConverterSettings.Default.targetFolder = this.targetFolderTextBox.Text;
            QuickConverterSettings.Default.outputType = this.outputTypeComboBox.SelectedIndex;
            QuickConverterSettings.Default.column1 = this.columnComboBox1.SelectedIndex;
            QuickConverterSettings.Default.column2 = this.columnComboBox2.SelectedIndex;
            QuickConverterSettings.Default.column3 = this.columnComboBox3.SelectedIndex;
            QuickConverterSettings.Default.column4 = this.columnComboBox4.SelectedIndex;
            QuickConverterSettings.Default.column5 = this.columnComboBox5.SelectedIndex;
            QuickConverterSettings.Default.column6 = this.columnComboBox6.SelectedIndex;
            QuickConverterSettings.Default.vietPhraseTranslationType = this.vietPhraseTranslationTypeComboBox.SelectedIndex;
            QuickConverterSettings.Default.vietPhraseOneMeaningTranslationType = this.vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex;
            QuickConverterSettings.Default.translationAlgorithm = this.translationAlgorithmComboBox.SelectedIndex;
            QuickConverterSettings.Default.onlineTranslationAlgorithm = this.onlineTranslationTypeComboBox.SelectedIndex;
            QuickConverterSettings.Default.mergeFiles = (int)this.mergeFilesNumericUpDown.Value;
            QuickConverterSettings.Default.changeFileName = this.changeFileNameCheckBox.Checked;
            QuickConverterSettings.Default.insertBlankLines = this.insertBlankLinesCheckBox.Checked;
            QuickConverterSettings.Default.prioritizedName = this.prioritizedNameCheckBox.Checked;
            QuickConverterSettings.Default.Save();
        }

        // Token: 0x0400000B RID: 11
        private const int OUTPUT_TYPE_ID_COLUMN_FOR_TRANSLATOR = 0;

        // Token: 0x0400000C RID: 12
        private const int OUTPUT_TYPE_ID_QT_FOR_TRANSLATOR = 1;

        // Token: 0x0400000D RID: 13
        private const int OUTPUT_TYPE_ID_VIETPHRASE_FOR_READER_WORD = 2;

        // Token: 0x0400000E RID: 14
        private const int OUTPUT_TYPE_ID_VIETPHRASE_FOR_READER_TXT = 3;

        // Token: 0x0400000F RID: 15
        private const int OUTPUT_TYPE_ID_VIETPHRASE_ONE_MEANING_FOR_READER_WORD = 4;

        // Token: 0x04000010 RID: 16
        private const int OUTPUT_TYPE_ID_VIETPHRASE_ONE_MEANING_FOR_READER_TXT = 5;

        // Token: 0x04000011 RID: 17
        private const int OUTPUT_TYPE_ID_HAN_VIET_FOR_READER_WORD = 6;

        // Token: 0x04000012 RID: 18
        private const int OUTPUT_TYPE_ID_HAN_VIET_FOR_READER_TXT = 7;

        // Token: 0x04000013 RID: 19
        private const int OUTPUT_TYPE_ID_CHINESE = 8;

        // Token: 0x04000014 RID: 20
        private bool isProcessing;

        // Token: 0x04000015 RID: 21
        private bool requestCancel;

        // Token: 0x04000016 RID: 22
        private int[] processStatus;

        // Token: 0x04000017 RID: 23
        private int doneStatus;

        // Token: 0x04000018 RID: 24
        private string[] hanVietResult;

        // Token: 0x04000019 RID: 25
        private string[] vietPhraseResult;

        // Token: 0x0400001A RID: 26
        private string[] vietPhraseOneMeaningResult;

        // Token: 0x0400001B RID: 27
        private string[] onlineResult;

        // Token: 0x0400001C RID: 28
        private DateTime startTime;

        // Token: 0x02000004 RID: 4
        // (Invoke) Token: 0x06000025 RID: 37
        private delegate void GenericDelegate();
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickTranslatorCore;
using QuickTranslatorCore.Engine;

namespace QuickConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseSourceFolderButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                sourceFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void BrowseTargetFolderButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                targetFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            sourceFolderTextBox.Text = QuickConverterSettings.Default.sourceFolder;
            targetFolderTextBox.Text = QuickConverterSettings.Default.targetFolder;
            outputTypeComboBox.SelectedIndex = QuickConverterSettings.Default.outputType;
            columnComboBox1.SelectedIndex = QuickConverterSettings.Default.column1;
            columnComboBox2.SelectedIndex = QuickConverterSettings.Default.column2;
            columnComboBox3.SelectedIndex = QuickConverterSettings.Default.column3;
            columnComboBox4.SelectedIndex = QuickConverterSettings.Default.column4;
            columnComboBox5.SelectedIndex = QuickConverterSettings.Default.column5;
            columnComboBox6.SelectedIndex = QuickConverterSettings.Default.column6;
            vietPhraseTranslationTypeComboBox.SelectedIndex = QuickConverterSettings.Default.vietPhraseTranslationType;
            vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex = QuickConverterSettings.Default.vietPhraseOneMeaningTranslationType;
            translationAlgorithmComboBox.SelectedIndex = QuickConverterSettings.Default.translationAlgorithm;
            onlineTranslationTypeComboBox.SelectedIndex = QuickConverterSettings.Default.onlineTranslationAlgorithm;
            mergeFilesNumericUpDown.Value = QuickConverterSettings.Default.mergeFiles;
            changeFileNameCheckBox.Checked = QuickConverterSettings.Default.changeFileName;
            insertBlankLinesCheckBox.Checked = QuickConverterSettings.Default.insertBlankLines;
            prioritizedNameCheckBox.Checked = QuickConverterSettings.Default.prioritizedName;
            Initializer.LoadDictionaries();
        }

        private void OutputTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            columnComboBox1.Enabled = (outputTypeComboBox.SelectedIndex == 0);
            columnComboBox2.Enabled = (outputTypeComboBox.SelectedIndex == 0);
            columnComboBox3.Enabled = (outputTypeComboBox.SelectedIndex == 0);
            columnComboBox4.Enabled = (outputTypeComboBox.SelectedIndex == 0);
            columnComboBox5.Enabled = (outputTypeComboBox.SelectedIndex == 0);
            columnComboBox6.Enabled = (outputTypeComboBox.SelectedIndex == 0);
            vietPhraseTranslationTypeComboBox.Enabled = (outputTypeComboBox.SelectedIndex == 0 || outputTypeComboBox.SelectedIndex == 2 || outputTypeComboBox.SelectedIndex == 3);
            vietPhraseOneMeaningTranslationTypeComboBox.Enabled = (outputTypeComboBox.SelectedIndex != 1 && outputTypeComboBox.SelectedIndex != 2 && outputTypeComboBox.SelectedIndex != 3 && outputTypeComboBox.SelectedIndex != 6 && outputTypeComboBox.SelectedIndex != 7 && outputTypeComboBox.SelectedIndex != 8);
            translationAlgorithmComboBox.Enabled = (outputTypeComboBox.SelectedIndex != 1 && outputTypeComboBox.SelectedIndex != 6 && outputTypeComboBox.SelectedIndex != 7 && outputTypeComboBox.SelectedIndex != 8);
            onlineTranslationTypeComboBox.Enabled = (outputTypeComboBox.SelectedIndex == 0);
        }

        private void RunCancelButtonClick(object sender, EventArgs e)
        {
            try
            {
                runCancelButtonClickHandler();
            }
            catch (Exception)
            {
            }
        }

        private void runCancelButtonClickHandler()
        {
            btnRunOrCancel.Text = (isProcessing ? "Run" : "Cancel");
            if (isProcessing)
            {
                requestCancel = true;
                isProcessing = false;
                return;
            }
            if (!Directory.Exists(sourceFolderTextBox.Text))
            {
                MessageBox.Show("Thư mục nguồn không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                browseSourceFolderButton.Focus();
                btnRunOrCancel.Text = "Run";
                return;
            }
            if (string.IsNullOrEmpty(targetFolderTextBox.Text))
            {
                MessageBox.Show("Nhập thư mục đích!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                browseTargetFolderButton.Focus();
                btnRunOrCancel.Text = "Run";
                return;
            }
            if (!Directory.Exists(targetFolderTextBox.Text))
            {
                Directory.CreateDirectory(targetFolderTextBox.Text);
            }
            string[] source = File.ReadAllLines(Path.Combine(Constants.AssetsDir, "IgnoredFiles.txt"));
            string[] files = Directory.GetFiles(sourceFolderTextBox.Text);
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
                browseSourceFolderButton.Focus();
                btnRunOrCancel.Text = "Run";
                return;
            }
            isProcessing = true;
            requestCancel = false;
            btnRunOrCancel.Text = "Analyzing...";
            btnRunOrCancel.Enabled = false;
            Application.DoEvents();
            startTime = DateTime.Now;
            string[] array2;
            string[] chineseContents = mergeSourceFiles(list.ToArray(), int.Parse(mergeFilesNumericUpDown.Text.Replace(",", "")), out array2);
            processStatus = new int[array2.Length];
            hanVietResult = new string[array2.Length];
            vietPhraseResult = new string[array2.Length];
            vietPhraseOneMeaningResult = new string[array2.Length];
            onlineResult = new string[array2.Length];
            calculateDoneStatus();
            updateProcessingStatus(list.Count, int.Parse(mergeFilesNumericUpDown.Text.Replace(",", "")));
            if (outputTypeComboBox.SelectedIndex == 0)
            {
                int[] columnIndexes = new int[]
                {
                    columnComboBox1.SelectedIndex,
                    columnComboBox2.SelectedIndex,
                    columnComboBox3.SelectedIndex,
                    columnComboBox4.SelectedIndex,
                    columnComboBox5.SelectedIndex,
                    columnComboBox6.SelectedIndex
                };
                translateColumnFormat(chineseContents, columnIndexes);
                exportColumnFormat(chineseContents, array2);
                return;
            }
            if (outputTypeComboBox.SelectedIndex == 1)
            {
                translateAndExportQuickTranslatorFormat(chineseContents, array2);
                return;
            }
            if (outputTypeComboBox.SelectedIndex == 2 || outputTypeComboBox.SelectedIndex == 3)
            {
                translateAndExportVietPhraseFormat(chineseContents, array2);
                return;
            }
            if (outputTypeComboBox.SelectedIndex == 4 || outputTypeComboBox.SelectedIndex == 5)
            {
                translateAndExportVietPhraseOneMeaningFormat(chineseContents, array2);
                return;
            }
            if (outputTypeComboBox.SelectedIndex == 6 || outputTypeComboBox.SelectedIndex == 7)
            {
                translateAndExportHanVietFormat(chineseContents, array2);
                return;
            }
            translateAndExportChineseFormat(chineseContents, array2);
        }

        private string[] mergeSourceFiles(string[] sourceFiles, int mergeOption, out string[] mergedFileNames)
        {
            string name = CharsetDetector.GuessCharsetOfFile(sourceFiles[0]);
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            bool @checked = changeFileNameCheckBox.Checked;
            int num = sourceFiles.Length;
            bool needMarkChapterHeaders = outputTypeComboBox.SelectedIndex == 2 || outputTypeComboBox.SelectedIndex == 4 || outputTypeComboBox.SelectedIndex == 6;
            for (int i = 0; i < num; i += mergeOption)
            {
                stringBuilder.Length = 0;
                stringBuilder2.Length = 0;
                int num2 = 0;
                while (num2 < mergeOption && sourceFiles.Length > i + num2)
                {
                    stringBuilder.Append(Util.NormalizeTextAndRemoveIgnoredChinesePhrases(readFile(sourceFiles[i + num2], Encoding.GetEncoding(name), needMarkChapterHeaders))).Append("\n\n----------oOo----------\n\n");
                    if (num2 == 0)
                    {
                        stringBuilder2.Append(getOutputFileName(sourceFiles[i + num2], i + num2, num, @checked));
                    }
                    else if (mergeOption != 1 && (num2 == mergeOption - 1 || i + num2 == sourceFiles.Length - 1))
                    {
                        stringBuilder2.Append(" - ").Append(getOutputFileName(sourceFiles[i + num2], i + num2, num, @checked));
                    }
                    num2++;
                }
                list.Add(stringBuilder.ToString());
                list2.Add(stringBuilder2.ToString());
            }
            mergedFileNames = list2.ToArray();
            return list.ToArray();
        }

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

        private string readFile(string filePath, Encoding encoding, bool needMarkChapterHeaders)
        {
            string text = File.ReadAllText(filePath, encoding);
            if (filePath.EndsWith("html") || filePath.EndsWith("htm") || filePath.EndsWith("asp") || filePath.EndsWith("aspx") || filePath.EndsWith("php"))
            {
                text = HtmlScrapper.GetChineseContent(text, needMarkChapterHeaders);
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

        private void translateColumnFormat(string[] chineseContents, int[] columnIndexes)
        {
            int wrapType = (vietPhraseTranslationTypeComboBox.SelectedIndex == 2) ? 11 : vietPhraseTranslationTypeComboBox.SelectedIndex;
            int wrapType2 = (vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex == 2) ? 11 : vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex;
            int selectedIndex = translationAlgorithmComboBox.SelectedIndex;
            int selectedIndex2 = onlineTranslationTypeComboBox.SelectedIndex;
            bool @checked = prioritizedNameCheckBox.Checked;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                for (int j = 0; j < columnIndexes.Length; j++)
                {
                    if (columnIndexes[j] == 1)
                    {
                        processStatus[i]++;
                    }
                    else if (columnIndexes[j] == 2)
                    {
                        translateHanViet(chineseContents[i], i);
                    }
                    else if (columnIndexes[j] == 3)
                    {
                        translateVietPhrase(chineseContents[i], wrapType, selectedIndex, @checked, i);
                    }
                    else if (columnIndexes[j] == 4)
                    {
                        translateVietPhraseOneMeaning(chineseContents[i], wrapType2, selectedIndex, @checked, i);
                    }
                    else if (columnIndexes[j] == 5)
                    {
                        processStatus[i]++;
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
                            translateOnline(chineseContents[i], i, translationEngine, selectedIndex2);
                        }
                        catch (Exception)
                        {
                            requestCancel = true;
                            MessageBox.Show("Internet connection failed!");
                        }
                    }
                }
            }
        }

        private void exportColumnFormat(string[] chineseContents, string[] mergedFileNames)
        {
            bool needToRemoveBlankLine = !insertBlankLinesCheckBox.Checked;
            string targetFolder = targetFolderTextBox.Text;
            List<string> list = new List<string>();
            if (columnComboBox1.Text != "<None>")
            {
                list.Add(columnComboBox1.Text);
            }
            if (columnComboBox2.Text != "<None>")
            {
                list.Add(columnComboBox2.Text);
            }
            if (columnComboBox3.Text != "<None>")
            {
                list.Add(columnComboBox3.Text);
            }
            if (columnComboBox4.Text != "<None>")
            {
                list.Add(columnComboBox4.Text);
            }
            if (columnComboBox5.Text != "<None>")
            {
                list.Add(columnComboBox5.Text);
            }
            if (columnComboBox6.Text != "<None>")
            {
                list.Add(columnComboBox6.Text);
            }
            string[] columnNames = list.ToArray();
            new Thread(delegate () {
                while (!requestCancel)
                {
                    if (!isProcessing)
                    {
                        return;
                    }
                    for (int i = 0; i < processStatus.Length; i++)
                    {
                        if (processStatus[i] == doneStatus - 1)
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
                                    array[j] = hanVietResult[i];
                                }
                                else if (columnNames[j] == "VietPhrase")
                                {
                                    array[j] = vietPhraseResult[i];
                                }
                                else if (columnNames[j] == "VietPhrase một nghĩa")
                                {
                                    array[j] = vietPhraseOneMeaningResult[i];
                                }
                                else if (columnNames[j] == "Việt")
                                {
                                    array[j] = "";
                                }
                                else
                                {
                                    array[j] = onlineResult[i];
                                }
                            }
                            ColumnExporter.Export(columnNames, array, needToRemoveBlankLine, Path.Combine(targetFolder, mergedFileNames[i] + ".doc"));
                            processStatus[i]++;
                        }
                    }
                    Thread.Sleep(1000);
                }
            }) {
                IsBackground = true
            }.Start();
        }

        private void translateAndExportVietPhraseFormat(string[] chineseContents, string[] mergedFileNames)
        {
            int wrapType = (vietPhraseTranslationTypeComboBox.SelectedIndex == 2) ? 11 : vietPhraseTranslationTypeComboBox.SelectedIndex;
            bool needToRemoveBlankLine = !insertBlankLinesCheckBox.Checked;
            string targetFolder = targetFolderTextBox.Text;
            bool outputToWord = outputTypeComboBox.SelectedIndex == 2;
            int translationAlgorithm = translationAlgorithmComboBox.SelectedIndex;
            bool prioritizedName = prioritizedNameCheckBox.Checked;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                if (requestCancel)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(delegate (object batchIndexObject) {
                    if (requestCancel)
                    {
                        return;
                    }
                    int num = (int)batchIndexObject;
                    VietPhraseExporter.Export(Translator.ChineseToVietPhraseForBatch(chineseContents[num], wrapType, translationAlgorithm, prioritizedName), needToRemoveBlankLine, Path.Combine(targetFolder, mergedFileNames[num] + (outputToWord ? ".doc" : (mergedFileNames[num].EndsWith("txt") ? "" : ".txt"))), outputToWord);
                    processStatus[num]++;
                }, i);
            }
        }

        private void translateAndExportVietPhraseOneMeaningFormat(string[] chineseContents, string[] mergedFileNames)
        {
            int wrapType = (vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex == 2) ? 11 : vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex;
            bool needToRemoveBlankLine = !insertBlankLinesCheckBox.Checked;
            string targetFolder = targetFolderTextBox.Text;
            bool outputToWord = outputTypeComboBox.SelectedIndex == 4;
            int translationAlgorithm = translationAlgorithmComboBox.SelectedIndex;
            bool prioritizedName = prioritizedNameCheckBox.Checked;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                if (requestCancel)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(delegate (object batchIndexObject) {
                    if (requestCancel)
                    {
                        return;
                    }
                    int num = (int)batchIndexObject;
                    VietPhraseExporter.Export(Translator.ChineseToVietPhraseOneMeaningForBatch(chineseContents[num], wrapType, translationAlgorithm, prioritizedName), needToRemoveBlankLine, Path.Combine(targetFolder, mergedFileNames[num] + (outputToWord ? ".doc" : (mergedFileNames[num].EndsWith("txt") ? "" : ".txt"))), outputToWord);
                    processStatus[num]++;
                }, i);
            }
        }

        private void translateAndExportHanVietFormat(string[] chineseContents, string[] mergedFileNames)
        {
            bool needToRemoveBlankLine = !insertBlankLinesCheckBox.Checked;
            string targetFolder = targetFolderTextBox.Text;
            bool outputToWord = outputTypeComboBox.SelectedIndex == 6;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                if (requestCancel)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(delegate (object batchIndexObject) {
                    if (requestCancel)
                    {
                        return;
                    }
                    int num = (int)batchIndexObject;
                    VietPhraseExporter.Export(Translator.ChineseToHanVietForBatch(chineseContents[num]), needToRemoveBlankLine, Path.Combine(targetFolder, mergedFileNames[num] + (outputToWord ? ".doc" : (mergedFileNames[num].EndsWith("txt") ? "" : ".txt"))), outputToWord);
                    processStatus[num]++;
                }, i);
            }
        }

        private void translateAndExportQuickTranslatorFormat(string[] chineseContents, string[] mergedFileNames)
        {
            bool needToRemoveBlankLine = !insertBlankLinesCheckBox.Checked;
            string targetFolder = targetFolderTextBox.Text;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                if (requestCancel)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(delegate (object batchIndexObject) {
                    if (requestCancel)
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
                    processStatus[num]++;
                }, i);
            }
        }

        private void translateAndExportChineseFormat(string[] chineseContents, string[] mergedFileNames)
        {
            bool needToRemoveBlankLine = !insertBlankLinesCheckBox.Checked;
            string targetFolder = targetFolderTextBox.Text;
            for (int i = 0; i < chineseContents.Length; i++)
            {
                if (requestCancel)
                {
                    return;
                }
                ThreadPool.QueueUserWorkItem(delegate (object batchIndexObject) {
                    if (requestCancel)
                    {
                        return;
                    }
                    int num = (int)batchIndexObject;
                    VietPhraseExporter.Export(chineseContents[num], needToRemoveBlankLine, Path.Combine(targetFolder, mergedFileNames[num] + (mergedFileNames[num].EndsWith("txt") ? "" : ".txt")), false);
                    processStatus[num]++;
                }, i);
            }
        }

        private void translateHanViet(string chineseContent, int batchId)
        {
            if (requestCancel)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(delegate (object param0) {
                if (requestCancel)
                {
                    return;
                }
                hanVietResult[batchId] = Translator.ChineseToHanVietForBatch(chineseContent);
                processStatus[batchId]++;
            });
        }

        private void translateVietPhraseOneMeaning(string chineseContent, int wrapType, int translationAlgorithm, bool prioritizedName, int batchId)
        {
            if (requestCancel)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(delegate (object param0) {
                if (requestCancel)
                {
                    return;
                }
                vietPhraseOneMeaningResult[batchId] = Translator.ChineseToVietPhraseOneMeaningForBatch(chineseContent, wrapType, translationAlgorithm, prioritizedName);
                processStatus[batchId]++;
            });
        }

        private void translateVietPhrase(string chineseContent, int wrapType, int translationAlgorithm, bool prioritizedName, int batchId)
        {
            if (requestCancel)
                return;
            ThreadPool.QueueUserWorkItem(delegate (object param0) {
                if (requestCancel)
                    return;
                vietPhraseResult[batchId] = Translator.ChineseToVietPhraseForBatch(chineseContent, wrapType, translationAlgorithm, prioritizedName);
                processStatus[batchId]++;
            });
        }

        private void translateOnline(string _d, int _o, int _n, int _e)
        {
            if (requestCancel)
                return;

            ThreadPool.QueueUserWorkItem(delegate (object param0) {
                if (requestCancel)
                    return;

                try
                {
                    throw new NotSupportedException("Bing Translation API has been obsoleted.");
                }
                catch (Exception ex)
                {
                    requestCancel = true;
                    throw ex;
                }
            });
        }

        private void updateProcessingStatus(int sourceFileCount, int mergeOption)
        {
            new Thread(delegate () {
                while (!requestCancel)
                {
                    int num = 0;
                    foreach (int num2 in processStatus)
                    {
                        if (num2 == doneStatus)
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
                    updateProcessingStatusToGui(processingStatusText, flag);
                    if (flag)
                    {
                        isProcessing = false;
                        return;
                    }
                    Thread.Sleep(1000);
                }
            }) {
                IsBackground = true
            }.Start();
        }

        private void updateProcessingStatusToGui(string processingStatusText, bool done)
        {
            MainForm.GenericDelegate method = delegate () {
                processingStatusPanel.Visible = true;
                processedFilesLabel.Text = processingStatusText;
                btnRunOrCancel.Enabled = true;
                btnRunOrCancel.Text = (done ? "Run" : "Cancel");
                if (done)
                {
                    TimeSpan timeSpan = DateTime.Now.Subtract(startTime);
                    MessageBox.Show("Done!!! Running Time = " + timeSpan, "Quick Converter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (requestCancel)
                {
                    MessageBox.Show("Cancelled by user!!!", "Quick Converter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    btnRunOrCancel.Text = "Run";
                }
            };
            BeginInvoke(method);
        }

        private void calculateDoneStatus()
        {
            doneStatus = 0;

            if (outputTypeComboBox.SelectedIndex != 0)
            {
                doneStatus = 1;
                return;
            }

            doneStatus = 1;

            if (columnComboBox1.SelectedIndex != 0)
                doneStatus++;

            if (columnComboBox2.SelectedIndex != 0)
                doneStatus++;

            if (columnComboBox3.SelectedIndex != 0)
                doneStatus++;

            if (columnComboBox4.SelectedIndex != 0)
                doneStatus++;

            if (columnComboBox5.SelectedIndex != 0)
                doneStatus++;

            if (columnComboBox6.SelectedIndex != 0)
                doneStatus++;
        }

        private void sourceFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            targetFolderTextBox.Text = sourceFolderTextBox.Text + "\\QuickConverter";
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            QuickConverterSettings.Default.sourceFolder = sourceFolderTextBox.Text;
            QuickConverterSettings.Default.targetFolder = targetFolderTextBox.Text;
            QuickConverterSettings.Default.outputType = outputTypeComboBox.SelectedIndex;
            QuickConverterSettings.Default.column1 = columnComboBox1.SelectedIndex;
            QuickConverterSettings.Default.column2 = columnComboBox2.SelectedIndex;
            QuickConverterSettings.Default.column3 = columnComboBox3.SelectedIndex;
            QuickConverterSettings.Default.column4 = columnComboBox4.SelectedIndex;
            QuickConverterSettings.Default.column5 = columnComboBox5.SelectedIndex;
            QuickConverterSettings.Default.column6 = columnComboBox6.SelectedIndex;
            QuickConverterSettings.Default.vietPhraseTranslationType = vietPhraseTranslationTypeComboBox.SelectedIndex;
            QuickConverterSettings.Default.vietPhraseOneMeaningTranslationType = vietPhraseOneMeaningTranslationTypeComboBox.SelectedIndex;
            QuickConverterSettings.Default.translationAlgorithm = translationAlgorithmComboBox.SelectedIndex;
            QuickConverterSettings.Default.onlineTranslationAlgorithm = onlineTranslationTypeComboBox.SelectedIndex;
            QuickConverterSettings.Default.mergeFiles = (int)mergeFilesNumericUpDown.Value;
            QuickConverterSettings.Default.changeFileName = changeFileNameCheckBox.Checked;
            QuickConverterSettings.Default.insertBlankLines = insertBlankLinesCheckBox.Checked;
            QuickConverterSettings.Default.prioritizedName = prioritizedNameCheckBox.Checked;
            QuickConverterSettings.Default.Save();
        }

        private bool isProcessing;

        private bool requestCancel;

        private int[] processStatus;

        private int doneStatus;

        private string[] hanVietResult;

        private string[] vietPhraseResult;

        private string[] vietPhraseOneMeaningResult;

        private string[] onlineResult;

        private DateTime startTime;

        private delegate void GenericDelegate();
    }
}

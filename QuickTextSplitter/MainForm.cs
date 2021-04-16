using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuickTranslatorCore;

namespace QuickTextSplitter
{
    public partial class MainForm : Form
    {
        const string DefaultPattern = "第[^,\\.!?]{1,10}[章|节]";

        public MainForm()
        {
            InitializeComponent();
            radSplitIntoChapters.Text += $" theo mô thức phân cách là: {DefaultPattern}";
        }

        private void SelectInputFilePathButton_Clicked(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog {
                CheckFileExists = true,
                Multiselect = false,
                Filter = "Text Documents (*.txt)|*.txt"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                txtInputFilePath.Text = fileDialog.FileName;
        }

        private void SelectOutputDirPathButton_Clicked(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog {
                ShowNewFolderButton = true
            };
            if (folderDialog.ShowDialog() == DialogResult.OK)
                txtOutputDirPath.Text = folderDialog.SelectedPath;
        }

        private void SelectInputFilePathButton_Changed(object sender, EventArgs e)
        {
            string inputFilePath = txtInputFilePath.Text;
            txtOutputDirPath.Text = Path.GetDirectoryName(inputFilePath) + "\\QuickTextSplitter";
        }

        private void RunButton_Clicked(object sender, EventArgs e)
        {
            if (!File.Exists(txtInputFilePath.Text))
            {
                MessageBox.Show("Đường dẫn đến file nguồn không đúng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectInputFilePath.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtOutputDirPath.Text))
            {
                MessageBox.Show("Nhập thư mục chứa kết quả!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectOutputDirPath.Focus();
                return;
            }

            Directory.CreateDirectory(txtOutputDirPath.Text);

            if (radSplitIntoChunks.Checked)
            {
                var inputFile = new FileStream(txtInputFilePath.Text, FileMode.Open, FileAccess.Read);
                var inputFileSize = inputFile.Length;

                var nChunks = numChunks.Value;
                int chunkSize = (int)Math.Ceiling(inputFileSize / nChunks);

                int amountStrWidth = nChunks.ToString().Length;

                for (int i = 0; i < nChunks; i++)
                {
                    var chunk = new byte[chunkSize];

                    int nByteRead;
                    if ((nByteRead = inputFile.Read(chunk, 0, chunkSize)) > 0)
                    {
                        var outputFilePath = Path.Combine(
                            txtOutputDirPath.Text, i.ToString().PadLeft(amountStrWidth, '0') + ".txt");

                        var outputFile = new FileStream(outputFilePath, FileMode.OpenOrCreate, FileAccess.Write);

                        outputFile.Write(chunk, 0, nByteRead);

                        outputFile.Close();
                    }
                }
                inputFile.Close();
            }
            else
            {
                var charset = CharsetDetector.GuessCharsetOfFile(txtInputFilePath.Text);

                var inputLines = File.ReadAllLines(txtInputFilePath.Text, Encoding.GetEncoding(charset));

                int amountStrWidth = 4;

                var stringBuilder = new StringBuilder();

                var pattern =
                    radSplitIntoChapters.Checked ? DefaultPattern :
                    chkUseRegex.Checked ? txtSeparatorToken.Text : Regex.Escape(txtSeparatorToken.Text);
                var regex = new Regex(pattern, RegexOptions.Compiled);

                int i = 0;
                foreach (var line in inputLines)
                {                    
                    // normal line
                    if (stringBuilder.Length == 0 || !regex.IsMatch(line))
                    {
                        stringBuilder.AppendLine(line);
                        continue;
                    }
                    
                    // separator line
                    if (radSplitBySeparatorToken.Checked)
                        stringBuilder.AppendLine(line);

                    var outputFilePath = Path.Combine(txtOutputDirPath.Text,
                        i.ToString().PadLeft(amountStrWidth, '0') + ".txt");
                    File.WriteAllText(outputFilePath, stringBuilder.ToString(), Encoding.GetEncoding(charset));

                    stringBuilder.Length = 0;

                    if (!radSplitBySeparatorToken.Checked)
                        stringBuilder.AppendLine(line);

                    i++;
                }

                if (stringBuilder.Length > 0)
                {
                    var outputFilePath = Path.Combine(txtOutputDirPath.Text,
                        i.ToString().PadLeft(amountStrWidth, '0') + ".txt");
                    File.WriteAllText(outputFilePath, stringBuilder.ToString(), Encoding.GetEncoding(charset));
                }
            }
            MessageBox.Show("Xong!!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void EachChapterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            numChunks.Enabled = radSplitIntoChunks.Checked;
        }

        private void CacPhanDeuNhauRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            numChunks.Enabled = radSplitIntoChunks.Checked;
        }

        private void SeparatorLineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            txtSeparatorToken.Enabled = radSplitBySeparatorToken.Checked;
            chkUseRegex.Enabled = radSplitBySeparatorToken.Checked;
        }
    }
}

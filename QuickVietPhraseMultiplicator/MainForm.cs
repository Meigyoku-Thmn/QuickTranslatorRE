using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TranslatorEngine;

using static TranslatorEngine.TranslatorEngine;

namespace QuickVietPhraseMultiplicator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectVietPhraseFileButton_OnClick(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog {
                CheckFileExists = true,
                Multiselect = false
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                txtVietPhraseFilePath.Text = fileDialog.FileName;
        }

        private void SelectMultiplyRuleFileButton_OnClick(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog {
                CheckFileExists = true,
                Multiselect = false
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                txtMultiplyRuleFilePath.Text = fileDialog.FileName;
        }

        private void SelectOutputDirButton_OnClick(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog {
                ShowNewFolderButton = true
            };
            if (folderDialog.ShowDialog() == DialogResult.OK)
                txtOutputDirPath.Text = folderDialog.SelectedPath;
        }

        private void RunButton_OnClick(object sender, EventArgs e)
        {
            if (!File.Exists(txtVietPhraseFilePath.Text))
            {
                MessageBox.Show("Đường dẫn đến file VietPhrase nguồn không đúng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectVietPhaseFile.Focus();
                return;
            }

            if (!File.Exists(txtMultiplyRuleFilePath.Text))
            {
                MessageBox.Show("Đường dẫn đến file luật nhân không đúng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectMultiplyRuleFile.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOutputDirPath.Text))
            {
                MessageBox.Show("Nhập thư mục chứa kết quả!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectOutputFile.Focus();
                return;
            }

            btnRun.Text = "Đang xử lý...";
            btnRun.Enabled = false;

            Application.DoEvents(); // refresh GUI

            Directory.CreateDirectory(txtOutputDirPath.Text);

            var vietPhraseDict = LoadDictionary(txtVietPhraseFilePath.Text);
            var multiplyRuleDict = LoadDictionary(txtMultiplyRuleFilePath.Text);

            var dict = (from multiplyRule in multiplyRuleDict
                        from vietPhrase in vietPhraseDict
                        where vietPhrase.Key != multiplyRule.Key.Replace("{0}", "")
                        let key = multiplyRule.Key.Replace("{0}", vietPhrase.Key)
                        let value = MultiplyMeanings(multiplyRule.Value, vietPhrase.Value)
                        group new { key, value } by key into g
                        select g.First())
                        .ToDictionary(item => item.key, item => item.value);

            SaveDictionaryToFileWithoutSorting(dict, Path.Combine(
                txtOutputDirPath.Text, $"QuickVietPhraseMultiplicator_{DateTime.Now:yyyyMMddHHmmss}.txt"));

            MessageBox.Show("Xong!!!");

            btnRun.Text = "Run";
            btnRun.Enabled = true;
        }

        private string MultiplyMeanings(string multiplyRule, string meanings)
        {
            var meaningArr = meanings.Split("|/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            return string.Join("/", meaningArr.Select(meaning => multiplyRule.Replace("{0}", meaning)));
        }

        private Dictionary<string, string> LoadDictionary(string dictPath)
        {
            var dict = new Dictionary<string, string>();
            var charset = CharsetDetector.DetectChineseCharset(dictPath);

            if (charset == "GB2312")
                charset = "UTF-8";

            using (var textReader = new StreamReader(dictPath, Encoding.GetEncoding(charset)))
            {
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    var tuple = line.Split('=');
                    if (tuple.Length == 2 && !dict.ContainsKey(tuple[0]))
                    {
                        dict.Add(tuple[0], tuple[1]);
                    }
                }
            }
            return dict;
        }
    }
}

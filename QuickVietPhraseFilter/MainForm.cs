using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuickTranslatorCore;
using QuickTranslatorCore.Engine;

namespace QuickVietPhraseFilter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseVietPhrase1ButtonClick(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog {
                CheckFileExists = true,
                Multiselect = false
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                txtVietPhraseFilePath.Text = fileDialog.FileName;
        }

        private void BrowseVietPhrase2ButtonClick(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog {
                CheckFileExists = true,
                Multiselect = false
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                txtFilterRuleFilePath.Text = fileDialog.FileName;
        }

        private void BrowseOutputFolderButtonClick(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog {
                ShowNewFolderButton = true
            };
            if (folderDialog.ShowDialog() == DialogResult.OK)
                txtOutputDirPath.Text = folderDialog.SelectedPath;
        }

        private void RunButtonClick(object sender, EventArgs e)
        {
            if (!File.Exists(txtVietPhraseFilePath.Text))
            {
                MessageBox.Show("Đường dẫn đến file VietPhrase nguồn không đúng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectVietPhraseFilePath.Focus();
                return;
            }
            if (!File.Exists(txtFilterRuleFilePath.Text))
            {
                MessageBox.Show("Đường dẫn đến file luật lọc VietPhrase không đúng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectFilterRuleFilePath.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtOutputDirPath.Text))
            {
                MessageBox.Show("Nhập thư mục chứa kết quả!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectOutputDirPath.Focus();
                return;
            }

            btnRun.Text = "Analyzing...";
            btnRun.Enabled = false;

            Application.DoEvents();

            Directory.CreateDirectory(txtOutputDirPath.Text);

            var vietPhraseDict = LoadDictionary(txtVietPhraseFilePath.Text);
            var filterRuleLines = LoadFilterRules(txtFilterRuleFilePath.Text);

            var pattern = FilterRulesToRegexPattern(filterRuleLines);
            var regex = new Regex(pattern, RegexOptions.Compiled);

            var sortedVietPhrases = from vietPhrase in vietPhraseDict
                                    where regex.IsMatch(vietPhrase.Key)
                                    orderby vietPhrase.Key.Length descending, vietPhrase.Key
                                    select vietPhrase;
            var dict = sortedVietPhrases.ToDictionary(pair => pair.Key, pair => pair.Value);

            Operator.SaveDictionaryToFileNoSort(dict,
                Path.Combine(txtOutputDirPath.Text, $"QuickVietPhraseFilter_{DateTime.Now:yyyyMMddHHmmss}.txt"));

            MessageBox.Show("Done!!!");

            btnRun.Text = "Run";
            btnRun.Enabled = true;
        }

        private string[] LoadFilterRules(string rulePath)
        {
            var charset = CharsetDetector.DetectChineseCharset(rulePath);
            if (charset == "GB2312")
                charset = "UTF-8";
            return File.ReadAllLines(rulePath, Encoding.GetEncoding(charset));
        }

        private string FilterRulesToRegexPattern(string[] rules)
        {
            return string.Join("|", rules
                .Where(rule => !string.IsNullOrEmpty(rule))
                .Select(rule => $"({ConvertRuleToPattern(rule)})"));
        }

        private string ConvertRuleToPattern(string rule)
        {
            var pattern = rule.Replace("{0}", ".*");

            if (!pattern.StartsWith(".*"))
                pattern = "^" + pattern;

            if (!pattern.EndsWith(".*"))
                pattern += "$";

            return pattern;
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
                        dict.Add(tuple[0], tuple[1]);
                }
            }
            return dict;
        }
    }
}

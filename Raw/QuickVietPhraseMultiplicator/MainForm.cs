using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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

        private void BrowseVietPhrase1ButtonClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog {
                CheckFileExists = true,
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                vietPhrase1TextBox.Text = openFileDialog.FileName;
        }

        private void BrowseVietPhrase2ButtonClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog {
                CheckFileExists = true,
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                vietPhrase2TextBox.Text = openFileDialog.FileName;
        }

        private void BrowseOutputFolderButtonClick(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog {
                ShowNewFolderButton = true
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                outputFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void RunButtonClick(object sender, EventArgs e)
        {
            if (!File.Exists(vietPhrase1TextBox.Text))
            {
                MessageBox.Show("Đường dẫn đến file VietPhrase nguồn không đúng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                browseVietPhrase1Button.Focus();
                return;
            }
            if (!File.Exists(vietPhrase2TextBox.Text))
            {
                MessageBox.Show("Đường dẫn đến file luật nhân không đúng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                browseVietPhrase2Button.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(outputFolderTextBox.Text))
            {
                MessageBox.Show("Nhập thư mục chứa kết quả!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                browseOutputFolderButton.Focus();
                return;
            }
            runButton.Text = "Analyzing...";
            runButton.Enabled = false;

            Application.DoEvents(); // refresh GUI

            if (!Directory.Exists(outputFolderTextBox.Text))
            {
                Directory.CreateDirectory(outputFolderTextBox.Text);
            }

            var dictionary = LoadDictionary(vietPhrase1TextBox.Text);
            var dictionary2 = LoadDictionary(vietPhrase2TextBox.Text);
            var dictionary3 = new Dictionary<string, string>();
            foreach (var keyValuePair in dictionary2)
            {
                foreach (var keyValuePair2 in dictionary)
                {
                    if (!(keyValuePair2.Key == keyValuePair.Key.Replace("{0}", "")))
                    {
                        string key = keyValuePair.Key.Replace("{0}", keyValuePair2.Key);
                        if (!dictionary3.ContainsKey(key))
                        {
                            string value = MultiplyMeanings(keyValuePair.Value, keyValuePair2.Value);
                            dictionary3.Add(key, value);
                        }
                    }
                }
            }
            SaveDictionaryToFileWithoutSorting(dictionary3, Path.Combine(
                outputFolderTextBox.Text, $"QuickVietPhraseMultiplicator_{DateTime.Now:yyyyMMddHHmmss}.txt"));

            MessageBox.Show("Done!!!");

            runButton.Text = "Run";
            runButton.Enabled = true;
        }

        private string MultiplyMeanings(string multiplicationRule, string originalMeanings)
        {
            var array = originalMeanings.Split("|/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var stringBuilder = new StringBuilder();
            foreach (var newValue in array)
            {
                stringBuilder.Append(multiplicationRule.Replace("{0}", newValue)).Append("/");
            }
            return stringBuilder.ToString().TrimEnd('/');
        }

        private Dictionary<string, string> LoadDictionary(string dictPath)
        {
            var dictionary = new Dictionary<string, string>();
            var text = CharsetDetector.DetectChineseCharset(dictPath);
            if (text == "GB2312")
            {
                text = "UTF-8";
            }
            using (var textReader = new StreamReader(dictPath, Encoding.GetEncoding(text)))
            {
                string text2;
                while ((text2 = textReader.ReadLine()) != null)
                {
                    var array = text2.Split('=');
                    if (array.Length == 2 && !dictionary.ContainsKey(array[0]))
                    {
                        dictionary.Add(array[0], array[1]);
                    }
                }
            }
            return dictionary;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TranslatorEngine;

using static TranslatorEngine.TranslatorEngine;

namespace QuickVietPhraseOneMeaningExtracter
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
                Multiselect = false,
                Filter = "VietPhrase (*.txt)|*.txt"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                txtVietPhraseFilePath.Text = fileDialog.FileName;
        }

        private void RunButton_OnClick(object sender, EventArgs e)
        {
            if (!File.Exists(txtVietPhraseFilePath.Text))
            {
                MessageBox.Show("Đường dẫn đến VietPhrase đa nghĩa không đúng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectVietPhraseFile.Focus();
                return;
            }
            var dirPath = Path.GetDirectoryName(txtVietPhraseFilePath.Text);
            var dict = LoadOneMeaningDictionary(txtVietPhraseFilePath.Text);
            SaveDictionaryToFile(ref dict, Path.Combine(dirPath, "VietPhraseOneMeaning.txt"));
            MessageBox.Show("Xong!!!");
        }

        private Dictionary<string, string> LoadOneMeaningDictionary(string dictPath)
        {
            var dict = new Dictionary<string, string>();
            var charSet = CharsetDetector.DetectChineseCharset(dictPath);
            using (var textReader = new StreamReader(dictPath, Encoding.GetEncoding(charSet)))
            {
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    var tuple = line.Split('=');
                    if (tuple.Length == 2 && !dict.ContainsKey(tuple[0]))
                    {
                        dict.Add(tuple[0], tuple[1].Split('/', '|')[0]);
                    }
                }
            }
            return dict;
        }
    }
}

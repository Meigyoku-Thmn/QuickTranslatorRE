using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickTranslatorCore;
using QuickTranslatorCore.Engine;

namespace QuickAnalyzer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            Initializer.LoadDictionaries();
            cboTranslationAlgorithm.SelectedIndex = 0;
            LoadSettings();
        }

        void BrowseSourceFolderButtonClick(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog {
                ShowNewFolderButton = false
            };
            if (folderDialog.ShowDialog() == DialogResult.OK)
                txtInputDirPath.Text = folderDialog.SelectedPath;
        }

        void BrowseTargetFolderButtonClick(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog {
                ShowNewFolderButton = true
            };
            if (folderDialog.ShowDialog() == DialogResult.OK)
                txtOutputDirPath.Text = folderDialog.SelectedPath;
        }

        void RunCancelButtonClick(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtInputDirPath.Text))
            {
                MessageBox.Show("Thư mục nguồn không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectInputDirPath.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtOutputDirPath.Text))
            {
                MessageBox.Show("Nhập thư mục đích!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectOutputDirPath.Focus();
                return;
            }

            Directory.CreateDirectory(txtOutputDirPath.Text);

            var list = Directory.GetFiles(txtInputDirPath.Text).ToList();
            list.Sort();

            if (list.Count == 0)
            {
                MessageBox.Show("Không tìm thấy file trong thư mục nguồn!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnSelectInputDirPath.Focus();
                return;
            }

            btnRunOrCancel.Text = "Analyzing...";
            btnRunOrCancel.Enabled = false;
            Application.DoEvents();

            DateTime now = DateTime.Now;

            MINIMUM_CONTINUOUS_WORDS = int.Parse(numMinCharCount.Value.ToString());
            MAXIMUM_CONTINUOUS_WORDS = int.Parse(numMaxCharCount.Value.ToString());

            content = ReadAllFiles(Directory.GetFiles(txtInputDirPath.Text));

            clauses = content.Split("=＝\n\\*,.\"'()?!:;·[/]，。…“、”（）-《》？！ \u3000：※；`—&".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            int num = clauses.Length;
            int num2 = 0;

            MINIMUM_OCCURANCES = int.Parse(minOccurancesNumericUpDown.Value.ToString());
            for (int i = MINIMUM_CONTINUOUS_WORDS; i <= MAXIMUM_CONTINUOUS_WORDS; i++)
            {
                for (int j = 0; j < num - 160; j++)
                {
                    for (var a = 1; a <= 159; a++)
                    {
                        InterateAllGroupsOfAClause(i, j++);
                    }
                    InterateAllGroupsOfAClause(i, j);
                    num2 = j;
                }
                for (int k = num2 + 1; k < num; k++)
                {
                    InterateAllGroupsOfAClause(i, k);
                }
            }
            var list2 = new List<string>();
            var stringBuilder = new StringBuilder();
            var stringBuilder2 = new StringBuilder();
            int selectedIndex = cboTranslationAlgorithm.SelectedIndex;
            bool @checked = chkNamePrioritized.Checked;

            var orderedEnumerable = from pair in resultDictionary
                                    orderby pair.Key.Length descending, pair.Value descending, pair.Key
                                    select pair;

            foreach (var keyValuePair in orderedEnumerable)
            {
                if (Refine(list2, keyValuePair.Key))
                {
                    stringBuilder.AppendLine(string.Concat(new[] {
                        keyValuePair.Key,
                        "=",
                        ChineseToHanViet(keyValuePair.Key),
                        "=",
                        ChineseToVietPhrase(keyValuePair.Key, selectedIndex, @checked),
                        "=",
                        keyValuePair.Value.ToString(),
                    }));
                    stringBuilder2.AppendLine(keyValuePair.Key + "=" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ChineseToHanViet(keyValuePair.Key)));
                }
            }
            File.WriteAllText(Path.Combine(txtOutputDirPath.Text, "result_TheoĐộDài.txt"),
                stringBuilder.ToString(), Encoding.UTF8);
            File.WriteAllText(Path.Combine(txtOutputDirPath.Text, "result_TheoĐộDài_ViếtHoa.txt"),
                stringBuilder2.ToString(), Encoding.UTF8);

            list2.Clear();
            stringBuilder.Length = 0;
            stringBuilder2.Length = 0;

            var stringBuilder3 = new StringBuilder();
            var orderedEnumerable2 = from pair in orderedEnumerable
                                     orderby pair.Value descending, pair.Key.Length descending, pair.Key
                                     select pair;

            foreach (var keyValuePair2 in orderedEnumerable2)
            {
                if (Util.IsInVietPhrase(keyValuePair2.Key))
                {
                    stringBuilder3.AppendLine(string.Concat(new[] {
                        keyValuePair2.Key,
                        "=",
                        ChineseToHanViet(keyValuePair2.Key),
                        "=",
                        ChineseToVietPhrase(keyValuePair2.Key, selectedIndex, @checked),
                        "=",
                        keyValuePair2.Value.ToString(),
                    }));
                }
                else if (Refine(list2, keyValuePair2.Key))
                {
                    stringBuilder.AppendLine(string.Concat(new[] {
                        keyValuePair2.Key,
                        "=",
                        ChineseToHanViet(keyValuePair2.Key),
                        "=",
                        ChineseToVietPhrase(keyValuePair2.Key, selectedIndex, @checked),
                        "=",
                        keyValuePair2.Value.ToString(),
                    }));
                    stringBuilder2.AppendLine(keyValuePair2.Key + "=" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ChineseToHanViet(keyValuePair2.Key)));
                }
            }
            File.WriteAllText(txtOutputDirPath.Text + "\\result_TheoTầnSuất.txt", stringBuilder.ToString(), Encoding.UTF8);
            File.WriteAllText(txtOutputDirPath.Text + "\\result_TheoTầnSuất_ViếtHoa.txt", stringBuilder2.ToString(), Encoding.UTF8);
            File.WriteAllText(txtOutputDirPath.Text + "\\result_TheoTầnSuất_VietPhraseOnly.txt", stringBuilder3.ToString(), Encoding.UTF8);

            resultDictionary.Clear();
            unfilteredResultDictionary.Clear();

            btnRunOrCancel.Text = "Run";
            btnRunOrCancel.Enabled = true;
            DateTime now2 = DateTime.Now;

            MessageBox.Show("Done!!! Time = " + (now2 - now).ToString());
            SaveSettings();
        }

        string ChineseToHanViet(string chinese)
        {
            return Util.ChineseToHanVietForAnalyzer(chinese);
        }

        string ChineseToVietPhrase(string chinese, int translationAlgorithm, bool prioritizedName)
        {
            return Util.ChineseToVietPhraseForAnalyzer(chinese, translationAlgorithm, prioritizedName);
        }

        bool Refine(List<string> doneList, string key)
        {
            if (Util.IsInVietPhrase(key))
            {
                doneList.Add(key);
                return false;
            }
            if (key.Contains("了") || key.Contains("个") || key.Contains("一") || key.Contains("的")
                || key.Contains("是") || key.Contains("么") || key.Contains("没") || key.Contains("和")
                || key.Contains("我") || key.Contains("他") || key.Contains("你") || key.Contains("们")
                || key.Contains("\t") || key.Contains("\n")
            )
            {
                return false;
            }

            foreach (string text in doneList)
            {
                if (text.Contains(key))
                {
                    return false;
                }
            }
            doneList.Add(key);
            return true;
        }

        void InterateAllGroupsOfAClause(int groupLength, int clauseIndex)
        {
            for (int i = 0; i < clauses[clauseIndex].Length - groupLength + 1; i++)
            {
                SearchAndAddToTheDictionary(groupLength, clauseIndex, i);
            }
        }

        void SearchAndAddToTheDictionary(int groupLength, int clauseIndex, int charIndex)
        {
            group = clauses[clauseIndex].Substring(charIndex, groupLength);
            if (unfilteredResultDictionary.ContainsKey(group))
            {
                if (MINIMUM_OCCURANCES - 1 <= unfilteredResultDictionary[group])
                {
                    unfilteredResultDictionary.Remove(group);
                    resultDictionary.Add(group, MINIMUM_OCCURANCES);
                    return;
                }
                Dictionary<string, int> dictionary;
                string key;
                (dictionary = unfilteredResultDictionary)[key = group] = dictionary[key] + 1;
                return;
            }
            else
            {
                if (resultDictionary.ContainsKey(group))
                {
                    Dictionary<string, int> dictionary2;
                    string key2;
                    (dictionary2 = resultDictionary)[key2 = group] = dictionary2[key2] + 1;
                    return;
                }
                unfilteredResultDictionary.Add(group, 1);
                return;
            }
        }

        void SourceFolderTextBoxTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputDirPath.Text))
            {
                return;
            }
            txtOutputDirPath.Text = txtInputDirPath.Text + "\\QuickAnalyzer";
        }

        string ReadAllFiles(string[] files)
        {
            if (files.Length < 1)
            {
                return string.Empty;
            }
            string name = CharsetDetector.DetectChineseCharset(files[0]);
            Encoding encoding = Encoding.GetEncoding(name);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string filePath in files)
            {
                stringBuilder.AppendLine(ReadFile(filePath, encoding, false));
            }
            return stringBuilder.ToString();
        }

        string ReadFile(string filePath, Encoding encoding, bool needMarkChapterHeaders)
        {
            string text = File.ReadAllText(filePath, encoding);
            if (filePath.EndsWith("html") || filePath.EndsWith("htm") || filePath.EndsWith("asp")
                || filePath.EndsWith("aspx") || filePath.EndsWith("php")
            )
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

        void LoadSettings()
        {
            txtInputDirPath.Text = QuickAnalyzerSettings.Default.thuMucNguon;
            txtOutputDirPath.Text = QuickAnalyzerSettings.Default.thuMucDich;
        }

        void SaveSettings()
        {
            QuickAnalyzerSettings.Default.thuMucNguon = txtInputDirPath.Text;
            QuickAnalyzerSettings.Default.thuMucDich = txtOutputDirPath.Text;
            QuickAnalyzerSettings.Default.Save();
        }

        int MINIMUM_CONTINUOUS_WORDS = 2;

        int MAXIMUM_CONTINUOUS_WORDS = 8;

        int MINIMUM_OCCURANCES = 1000;

        string group;

        readonly Dictionary<string, int> resultDictionary = new Dictionary<string, int>();

        readonly Dictionary<string, int> unfilteredResultDictionary = new Dictionary<string, int>();

        string content;

        string[] clauses;
    }
}

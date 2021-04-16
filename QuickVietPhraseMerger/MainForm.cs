using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuickTranslatorCore;
using QuickTranslatorCore.Engine;

using static System.StringSplitOptions;

namespace QuickVietPhraseMerger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnSelectVietPhrase1FilePath.Focus();
        }

        private void SelectVietPhrase1FilePathButton_Clicked(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog {
                CheckFileExists = true,
                Multiselect = false,
                Filter = "VietPhrase (*.txt)|*.txt"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                txtVietPhrase1FilePath.Text = fileDialog.FileName;
        }

        private void SelectVietPhrase2FilePathButton_Clicked(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog {
                CheckFileExists = true,
                Multiselect = false,
                Filter = "VietPhrase (*.txt)|*.txt"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                txtVietPhrase2FilePath.Text = fileDialog.FileName;
        }

        private void SelectOutputDirPathButton_Clicked(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog {
                ShowNewFolderButton = true
            };
            if (folderDialog.ShowDialog() == DialogResult.OK)
                txtOutputDirPath.Text = folderDialog.SelectedPath;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtVietPhrase1FilePath.Text))
            {
                MessageBox.Show("Đường dẫn đến VietPhrase 1 không đúng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectVietPhrase1FilePath.Focus();
                return;
            }
            if (!File.Exists(txtVietPhrase2FilePath.Text))
            {
                MessageBox.Show("Đường dẫn đến VietPhrase 2 không đúng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectVietPhrase2FilePath.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtOutputDirPath.Text))
            {
                MessageBox.Show("Nhập thư mục chứa kết quả!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnSelectOutputDirPath.Focus();
                return;
            }
            if (chkOnlyMergeCreatedByAuthor.Checked && string.IsNullOrWhiteSpace(txtEntryAuthor.Text))
            {
                MessageBox.Show("Xin hãy nhập tên tác giả để lọc trong VietPhrase!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtEntryAuthor.Focus();
                return;
            }

            btnRun.Text = "Đang xử lý...";
            btnRun.Enabled = false;
            Application.DoEvents();

            Directory.CreateDirectory(txtOutputDirPath.Text);

            var vietPhrase1Dict = LoadDictionary(txtVietPhrase1FilePath.Text);
            var vietPhrase2Dict = LoadDictionary(txtVietPhrase2FilePath.Text);

            var vietPhrase1DictLog = LoadDictionaryLog(txtVietPhrase1LogPath.Text);
            var vietPhrase2DictLog = LoadDictionaryLog(txtVietPhrase2LogPath.Text);

            // TODO: but what about "txtVietPhrase2LogPath" ?
            Helper.CopyIfSourceExists(txtVietPhrase1LogPath.Text,
                Path.Combine(txtOutputDirPath.Text, "VietPhraseHistory.txt"), true);

            var dict = MergeDictionaries(vietPhrase1Dict, vietPhrase1DictLog, vietPhrase2Dict, vietPhrase2DictLog);
            var dict2 = CompareDictionaries(vietPhrase1Dict, vietPhrase1DictLog, vietPhrase2Dict, vietPhrase2DictLog);

            Operator.SaveDictionaryToFileSorted(dict, Path.Combine(txtOutputDirPath.Text, "VietPhrase.txt"));
            Operator.SaveDictionaryToFileSorted(dict2, Path.Combine(txtOutputDirPath.Text, "VietPhraseDiff.txt"));

            MessageBox.Show("Xong!!!");

            btnRun.Text = "Run";
            btnRun.Enabled = true;
        }

        private Dictionary<string, string> CompareDictionaries(
            Dictionary<string, string> vietPhrase1Dict, DataSet vietPhrase1DictLog,
            Dictionary<string, string> vietPhrase2Dict, DataSet vietPhrase2DictLog)
        {
            var diffDict = new Dictionary<string, string>();

            bool dontMergeDeletedFromVietPhrase1 = chkDontMergeDeletedFromVietPhrase1.Checked;
            bool onlyMergeLastest = chkOnlyMergeLastest.Checked;
            bool onlyMergeCreatedByAuthor = chkOnlyMergeCreatedByAuthor.Checked;

            string recordAuthor = txtEntryAuthor.Text;

            foreach (var vietPhrase2 in vietPhrase2Dict)
            {
                if (dontMergeDeletedFromVietPhrase1)
                {
                    var vietPhrase1ChangeEntry = vietPhrase1DictLog.Tables[0].Rows.Find(vietPhrase2.Key);

                    if ((string)vietPhrase1ChangeEntry?["Action"] == "Deleted")
                        continue;
                }

                if (onlyMergeLastest)
                {
                    var vietPhrase2ChangeEntry = vietPhrase2DictLog.Tables[0].Rows.Find(vietPhrase2.Key);

                    if (vietPhrase2ChangeEntry == null)
                        continue;

                    var vietPhrase1ChangeEntry = vietPhrase1DictLog.Tables[0].Rows.Find(vietPhrase2.Key);

                    if ((DateTime)vietPhrase2ChangeEntry["Updated Date"]
                        < (DateTime)vietPhrase1ChangeEntry?["Updated Date"])
                        continue;
                }

                if (onlyMergeCreatedByAuthor)
                {
                    var vietPhrase2ChangeEntry = vietPhrase2DictLog.Tables[0].Rows.Find(vietPhrase2.Key);

                    if ((string)vietPhrase2ChangeEntry?["User"] != recordAuthor)
                        continue;
                }

                if (!vietPhrase1Dict.ContainsKey(vietPhrase2.Key) && !diffDict.ContainsKey(vietPhrase2.Key))
                    diffDict.Add(vietPhrase2.Key, vietPhrase2.Value);
            }
            return diffDict;
        }

        private Dictionary<string, string> MergeDictionaries(
            Dictionary<string, string> vietPhrase1Dict, DataSet vietPhrase1DictLog,
            Dictionary<string, string> vietPhrase2Dict, DataSet vietPhrase2DictLog)
        {
            var mergedDict = new Dictionary<string, string>(vietPhrase1Dict);

            bool dontMergeDeletedFromVietPhrase1 = chkDontMergeDeletedFromVietPhrase1.Checked;
            bool onlyMergeLastest = chkOnlyMergeLastest.Checked;
            bool onlyMergeCreatedByAuthor = chkOnlyMergeCreatedByAuthor.Checked;

            var recordAuthor = txtEntryAuthor.Text;

            var logPath = Path.Combine(txtOutputDirPath.Text, "VietPhraseHistory.txt");

            var stringBuilder = new StringBuilder();

            // the idea is that we pick entries from VietPhrase 2, then put them into VietPhrase 1
            foreach (var vietPhrase2 in vietPhrase2Dict)
            {
                if (dontMergeDeletedFromVietPhrase1)
                {
                    var vietPhrase1ChangeEntry = vietPhrase1DictLog.Tables[0].Rows.Find(vietPhrase2.Key);

                    if ((string)vietPhrase1ChangeEntry?["Action"] == "Deleted")
                        continue;
                }

                if (onlyMergeLastest)
                {
                    var vietPhrase2ChangeEntry = vietPhrase2DictLog.Tables[0].Rows.Find(vietPhrase2.Key);

                    if (vietPhrase2ChangeEntry == null)
                        continue;

                    var vietPhrase1ChangeEntry = vietPhrase1DictLog.Tables[0].Rows.Find(vietPhrase2.Key);

                    if ((DateTime)vietPhrase2ChangeEntry["Updated Date"]
                        < (DateTime)vietPhrase1ChangeEntry?["Updated Date"])
                        continue;
                }

                if (onlyMergeCreatedByAuthor)
                {
                    var vietPhrase2ChangeEntry = vietPhrase2DictLog.Tables[0].Rows.Find(vietPhrase2.Key);

                    if ((string)vietPhrase2ChangeEntry?["User"] != recordAuthor)
                        continue;
                }

                if (mergedDict.ContainsKey(vietPhrase2.Key))
                {
                    mergedDict[vietPhrase2.Key] = MergeMeanings(mergedDict[vietPhrase2.Key], vietPhrase2.Value);
                    Operator.CreateLog(vietPhrase2.Key, "Updated", ref stringBuilder);
                }
                else
                {
                    mergedDict[vietPhrase2.Key] = vietPhrase2.Value;
                    Operator.CreateLog(vietPhrase2.Key, "Added", ref stringBuilder);
                }
            }

            Operator.WriteLog(stringBuilder.ToString(), logPath);

            return mergedDict;
        }

        private string MergeMeanings(string meanings1, string meanings2)
        {
            var mergedSet = meanings1.Split("|/".ToCharArray(), RemoveEmptyEntries).ToHashSet();

            foreach (var meaning in meanings2.Split("|/".ToCharArray(), RemoveEmptyEntries))
                mergedSet.Add(meaning);

            return string.Join("/", mergedSet);
        }

        private Dictionary<string, string> LoadDictionary(string dictPath)
        {
            var dict = new Dictionary<string, string>();
            var charset = CharsetDetector.GuessCharsetOfFile(dictPath);
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

        private DataSet LoadDictionaryLog(string dictLogPath)
        {
            var result = new DataSet();
            Helper.LoadLog(dictLogPath, result);
            return result;
        }

        private void MergeOnlyEntriesUpdatedByCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            txtEntryAuthor.Enabled = chkOnlyMergeCreatedByAuthor.Checked;
        }

        private void VietPhrase1TextBox_TextChanged(object sender, EventArgs e)
        {
            var text = txtVietPhrase1FilePath.Text;
            txtVietPhrase1LogPath.Text = Path.Combine(
                Path.GetDirectoryName(text),
                Path.GetFileNameWithoutExtension(text) + "History" + Path.GetExtension(text));
        }

        private void VietPhrase2TextBox_TextChanged(object sender, EventArgs e)
        {
            var text = txtVietPhrase2FilePath.Text;
            txtVietPhrase2LogPath.Text = Path.Combine(
                Path.GetDirectoryName(text),
                Path.GetFileNameWithoutExtension(text) + "History" + Path.GetExtension(text));
        }
    }
}

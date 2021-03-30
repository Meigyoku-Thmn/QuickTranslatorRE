using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using QuickConverter;

namespace QuickTranslator
{
    public partial class ExportToWordForm : Form
    {
        public ExportToWordForm()
        {
            InitializeComponent();
        }

        public ExportToWordForm(string chinese, string hanViet, string vietPhrase, string vietPhraseOneMeaning, string viet)
        {
            InitializeComponent();
            this.chinese = chinese;
            this.hanViet = hanViet;
            this.vietPhrase = vietPhrase;
            this.vietPhraseOneMeaning = vietPhraseOneMeaning;
            this.viet = viet.Replace("\n\n", "\n").Replace("\n", "\n\n");
        }

        private void ExportToWordFormLoad(object sender, EventArgs e)
        {
            PopulateControls();
            exportButton.Focus();
        }

        public void PopulateControls()
        {
            PopulateComboBox(comboBox1);
            comboBox1.SelectedItem = "Trung";
            PopulateComboBox(comboBox2);
            comboBox2.SelectedItem = "Hán Việt";
            PopulateComboBox(comboBox3);
            comboBox3.SelectedItem = "VietPhrase";
            PopulateComboBox(comboBox4);
            comboBox4.SelectedItem = "VietPhrase một nghĩa";
            PopulateComboBox(comboBox5);
            comboBox5.SelectedItem = "Việt";
        }

        private void PopulateComboBox(ComboBox comboBox)
        {
            comboBox.Items.AddRange(new string[]
            {
                "<None>",
                "Trung",
                "Hán Việt",
                "VietPhrase",
                "VietPhrase một nghĩa",
                "Việt"
            });
        }

        private void ExportButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                CheckFileExists = false,
                Filter = "Microsoft Word (*.doc)|*.doc"
            };
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            string fileName = saveFileDialog.FileName;
            ExportToWord(fileName);
            Close();
        }

        public void ExportToWord(string exportFilePath)
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            AnalyzeColumn(comboBox1, list, list2);
            AnalyzeColumn(comboBox2, list, list2);
            AnalyzeColumn(comboBox3, list, list2);
            AnalyzeColumn(comboBox4, list, list2);
            AnalyzeColumn(comboBox5, list, list2);
            ColumnExporter.Export(list.ToArray(), list2.ToArray(), !insertBlankLineCheckBox.Checked, exportFilePath);
        }

        private void AnalyzeColumn(ComboBox comboBox, List<string> columnNameList, List<string> columnContentList)
        {
            if (comboBox.SelectedIndex == 1)
            {
                columnNameList.Add("Trung");
                columnContentList.Add(chinese);
                return;
            }
            if (comboBox.SelectedIndex == 2)
            {
                columnNameList.Add("Hán Việt");
                columnContentList.Add(hanViet);
                return;
            }
            if (comboBox.SelectedIndex == 3)
            {
                columnNameList.Add("VietPhrase");
                columnContentList.Add(vietPhrase);
                return;
            }
            if (comboBox.SelectedIndex == 4)
            {
                columnNameList.Add("VietPhrase một nghĩa");
                columnContentList.Add(vietPhraseOneMeaning);
                return;
            }
            if (comboBox.SelectedIndex == 5)
            {
                columnNameList.Add("Việt");
                columnContentList.Add(viet);
            }
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private string chinese;

        private string hanViet;

        private string vietPhrase;

        private string vietPhraseOneMeaning;

        private string viet;
    }
}

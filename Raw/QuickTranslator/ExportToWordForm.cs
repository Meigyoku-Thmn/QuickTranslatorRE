using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using QuickConverter;

namespace QuickTranslator
{
	// Token: 0x02000010 RID: 16
	public partial class ExportToWordForm : Form
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00008CE3 File Offset: 0x00007CE3
		public ExportToWordForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008CF4 File Offset: 0x00007CF4
		public ExportToWordForm(string chinese, string hanViet, string vietPhrase, string vietPhraseOneMeaning, string viet)
		{
			this.InitializeComponent();
			this.chinese = chinese;
			this.hanViet = hanViet;
			this.vietPhrase = vietPhrase;
			this.vietPhraseOneMeaning = vietPhraseOneMeaning;
			this.viet = viet.Replace("\n\n", "\n").Replace("\n", "\n\n");
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00008D50 File Offset: 0x00007D50
		private void ExportToWordFormLoad(object sender, EventArgs e)
		{
			this.PopulateControls();
			this.exportButton.Focus();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00008D64 File Offset: 0x00007D64
		public void PopulateControls()
		{
			this.populateComboBox(this.comboBox1);
			this.comboBox1.SelectedItem = "Trung";
			this.populateComboBox(this.comboBox2);
			this.comboBox2.SelectedItem = "Hán Việt";
			this.populateComboBox(this.comboBox3);
			this.comboBox3.SelectedItem = "VietPhrase";
			this.populateComboBox(this.comboBox4);
			this.comboBox4.SelectedItem = "VietPhrase một nghĩa";
			this.populateComboBox(this.comboBox5);
			this.comboBox5.SelectedItem = "Việt";
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008E00 File Offset: 0x00007E00
		private void populateComboBox(ComboBox comboBox)
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

		// Token: 0x0600009D RID: 157 RVA: 0x00008E50 File Offset: 0x00007E50
		private void ExportButtonClick(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.CheckFileExists = false;
			saveFileDialog.Filter = "Microsoft Word (*.doc)|*.doc";
			DialogResult dialogResult = saveFileDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			string fileName = saveFileDialog.FileName;
			this.ExportToWord(fileName);
			base.Close();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00008E98 File Offset: 0x00007E98
		public void ExportToWord(string exportFilePath)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			this.AnalyzeColumn(this.comboBox1, list, list2);
			this.AnalyzeColumn(this.comboBox2, list, list2);
			this.AnalyzeColumn(this.comboBox3, list, list2);
			this.AnalyzeColumn(this.comboBox4, list, list2);
			this.AnalyzeColumn(this.comboBox5, list, list2);
			ColumnExporter.Export(list.ToArray(), list2.ToArray(), !this.insertBlankLineCheckBox.Checked, exportFilePath);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008F18 File Offset: 0x00007F18
		private void AnalyzeColumn(ComboBox comboBox, List<string> columnNameList, List<string> columnContentList)
		{
			if (comboBox.SelectedIndex == 1)
			{
				columnNameList.Add("Trung");
				columnContentList.Add(this.chinese);
				return;
			}
			if (comboBox.SelectedIndex == 2)
			{
				columnNameList.Add("Hán Việt");
				columnContentList.Add(this.hanViet);
				return;
			}
			if (comboBox.SelectedIndex == 3)
			{
				columnNameList.Add("VietPhrase");
				columnContentList.Add(this.vietPhrase);
				return;
			}
			if (comboBox.SelectedIndex == 4)
			{
				columnNameList.Add("VietPhrase một nghĩa");
				columnContentList.Add(this.vietPhraseOneMeaning);
				return;
			}
			if (comboBox.SelectedIndex == 5)
			{
				columnNameList.Add("Việt");
				columnContentList.Add(this.viet);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00008FC9 File Offset: 0x00007FC9
		private void CloseButtonClick(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x040000C7 RID: 199
		private string chinese;

		// Token: 0x040000C8 RID: 200
		private string hanViet;

		// Token: 0x040000C9 RID: 201
		private string vietPhrase;

		// Token: 0x040000CA RID: 202
		private string vietPhraseOneMeaning;

		// Token: 0x040000CB RID: 203
		private string viet;
	}
}

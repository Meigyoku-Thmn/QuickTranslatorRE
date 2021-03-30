using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TranslatorEngine;

using static TranslatorEngine.TranslatorEngine;

namespace QuickTranslator
{
    public partial class UpdatePhienAmForm : Form
    {
        public UpdatePhienAmForm()
        {
            InitializeComponent();
        }

        public UpdatePhienAmForm(string chineseToLookup)
        {
            InitializeComponent();
            chineseTextBox.Text = chineseToLookup.Trim(new char[]
            {
                ' ',
                '.',
                ':',
                ';',
                '?',
                '!',
                '"',
                '\'',
                ',',
                '\n',
                '\t'
            });
            entryCountLabel.Text = GetPhienAmDictionaryCount().ToString();
            ActiveControl = phienAmTextBox;
        }

        private void ChineseTextBoxTextChanged(object sender, EventArgs e)
        {
            updateButton.Enabled = !string.IsNullOrEmpty(chineseTextBox.Text.Trim());
            deleteButton.Enabled = !string.IsNullOrEmpty(chineseTextBox.Text.Trim());
            if (string.IsNullOrEmpty(chineseTextBox.Text.Trim()))
            {
                phienAmTextBox.Text = "";
                return;
            }

            phienAmTextBox.Text = ChineseToHanViet(chineseTextBox.Text, out _).Trim();
            if (1 != chineseTextBox.Text.Length)
            {
                deleteButton.Enabled = false;
                updateButton.Enabled = false;
                return;
            }
            bool flag = ExistInPhienAmDictionary(chineseTextBox.Text);
            deleteButton.Enabled = flag;
            updateButton.Enabled = true;
            updateButton.Text = (flag ? "Update" : "Add");
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            if (chineseTextBox.Text.Length != 1)
            {
                return;
            }
            if (string.IsNullOrEmpty(phienAmTextBox.Text))
            {
                return;
            }
            UpdatePhienAmDictionary(chineseTextBox.Text, phienAmTextBox.Text, sortingCheckBox.Checked);
            Close();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            DeleteKeyFromPhienAmDictionary(chineseTextBox.Text, sortingCheckBox.Checked);
            Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

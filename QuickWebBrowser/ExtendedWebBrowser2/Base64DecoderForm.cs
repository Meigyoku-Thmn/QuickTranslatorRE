using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedWebBrowser2
{
    public partial class Base64DecoderForm : Form
    {
        public Base64DecoderForm()
        {
            InitializeComponent();
        }

        private void DecodeButtonClick(object sender, EventArgs e)
        {
            decodedTextBox.Text = HtmlUtilities.DecodeLink(encodedStringTextBox.Text);
        }

        private void CopyAndCloseButtonClick(object sender, EventArgs e)
        {
            try { Clipboard.SetText(decodedTextBox.Text); }
            catch { }
            Close();
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

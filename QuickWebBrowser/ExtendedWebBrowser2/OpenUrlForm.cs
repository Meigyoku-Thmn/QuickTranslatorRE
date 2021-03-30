using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtendedWebBrowser2
{
    internal partial class OpenUrlForm : Form
    {
        public OpenUrlForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Uri uri = null;
            try
            {
                uri = new Uri(addressTextBox.Text);
            }
            catch (UriFormatException)
            {
            }
            if (uri == null)
            {
                try
                {
                    uri = new Uri("http://" + addressTextBox.Text);
                }
                catch (UriFormatException)
                {
                }
                if (uri == null)
                {
                    invalidAddressLabel.Visible = true;
                    return;
                }
            }
            if (uri.Scheme == "http" || uri.Scheme == "https" || uri.Scheme == "file")
            {
                _url = uri;
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            invalidAddressLabel.Visible = false;
        }

        public Uri Url {
            get {
                return _url;
            }
        }

        private void OpenUrlForm_Load(object sender, EventArgs e)
        {
            invalidAddressLabel.Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            invalidAddressLabel.Visible = false;
        }

        private Uri _url;
    }
}

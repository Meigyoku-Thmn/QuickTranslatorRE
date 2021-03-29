using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExtendedWebBrowser2
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void LicenseButton_Click(object sender, EventArgs e)
        {
            Process.Start("http://creativecommons.org/licenses/by-sa/2.5/");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TheWheelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.thewheel.nl");
        }
    }
}

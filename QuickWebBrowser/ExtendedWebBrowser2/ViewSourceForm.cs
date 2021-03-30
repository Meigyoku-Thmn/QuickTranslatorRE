using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedWebBrowser2
{
    public partial class ViewSourceForm : Form
    {
        public ViewSourceForm(HtmlDocument htmlDocument)
        {
            InitializeComponent();
            foreach (object obj in htmlDocument.All)
            {
                HtmlElement htmlElement = (HtmlElement)obj;
                if (!string.IsNullOrEmpty(htmlElement.OuterHtml) && htmlElement.OuterHtml.Trim(new char[]
                {
                    ' ',
                    '\r',
                    '\n',
                    '\t'
                }).StartsWith("<HTML", StringComparison.InvariantCultureIgnoreCase))
                {
                    sourceRichTextBox.Text = htmlElement.OuterHtml;
                    Text = "HTML Source - " + htmlDocument.Url.AbsoluteUri;
                    break;
                }
            }
        }

        public ViewSourceForm(string source)
        {
            InitializeComponent();
            sourceRichTextBox.Text = source;
            Text = "HTML Source";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((msg.Msg == 256 || msg.Msg == 260) && keyData == Keys.Escape)
            {
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

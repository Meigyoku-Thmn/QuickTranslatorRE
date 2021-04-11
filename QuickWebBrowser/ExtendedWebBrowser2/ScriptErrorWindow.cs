using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace ExtendedWebBrowser2
{
    internal partial class ScriptErrorWindow : Form
    {
        public ScriptErrorWindow()
        {
            InitializeComponent();
            ScriptErrorManager.Instance.ScriptErrors.CollectionChanged += ScriptErrors_CollectionChanged;
        }

        private void ScriptErrors_CollectionChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();
            foreach (var scriptError in ScriptErrorManager.Instance.ScriptErrors)
            {
                var listViewItem = new ListViewItem(scriptError.Description);
                listViewItem.SubItems.Add(scriptError.LineNumber.ToString(CultureInfo.CurrentCulture));
                listViewItem.SubItems.Add(scriptError.Url.ToString());
                listView1.Items.Add(listViewItem);
            }
            listView1.EndUpdate();
        }

        private void ScriptErrorWindow_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void ClearListToolStripButton_Click(object sender, EventArgs e)
        {
            ScriptErrorManager.Instance.ScriptErrors.Clear();
        }
    }
}

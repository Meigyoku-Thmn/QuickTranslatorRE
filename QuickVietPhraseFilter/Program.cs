using QuickTranslatorCore;
using System;
using System.Windows.Forms;

namespace QuickVietPhraseFilter
{
    internal sealed class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Logger.SetUpErrorHandler();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

using System;
using System.Windows.Forms;

namespace QuickVietPhraseMultiplicator
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}

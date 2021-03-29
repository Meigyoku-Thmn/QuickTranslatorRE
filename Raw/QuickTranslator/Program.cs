using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TranslatorEngine;

namespace QuickTranslator
{
	// Token: 0x02000016 RID: 22
	internal sealed class Program
	{
		// Token: 0x06000136 RID: 310 RVA: 0x0001167C File Offset: 0x0001067C
		[STAThread]
		private static void Main(string[] args)
		{
			Application.ThreadException += Program.Application_ThreadException;
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			AppDomain.CurrentDomain.UnhandledException += Program.AppDomain_CurrentDomain_UnhandledException;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000116CB File Offset: 0x000106CB
		private static void AppDomain_CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			Program.UnhandledExceptionHandler((Exception)e.ExceptionObject);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000116DD File Offset: 0x000106DD
		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			Program.UnhandledExceptionHandler(e.Exception);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000116EC File Offset: 0x000106EC
		private static void UnhandledExceptionHandler(Exception exception)
		{
			string text = "QuickTranslator";
			ApplicationLog.Log(Path.GetDirectoryName(Application.ExecutablePath), text, exception);
			MessageBox.Show("Lỗi chương trình! Hãy gửi " + text + ".log cho tác giả. Xin cám ơn!", "Lỗi chương trình", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Application.Exit();
		}
	}
}

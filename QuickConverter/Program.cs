using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TranslatorEngine;

namespace QuickConverter
{
    // Token: 0x02000005 RID: 5
    internal sealed class Program
    {
        // Token: 0x06000028 RID: 40 RVA: 0x0000644C File Offset: 0x0000544C
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

        // Token: 0x06000029 RID: 41 RVA: 0x0000649B File Offset: 0x0000549B
        private static void AppDomain_CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Program.UnhandledExceptionHandler((Exception)e.ExceptionObject);
        }

        // Token: 0x0600002A RID: 42 RVA: 0x000064AD File Offset: 0x000054AD
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Program.UnhandledExceptionHandler(e.Exception);
        }

        // Token: 0x0600002B RID: 43 RVA: 0x000064BC File Offset: 0x000054BC
        private static void UnhandledExceptionHandler(Exception exception)
        {
            string text = "QuickConverter";
            ApplicationLog.Log(Path.GetDirectoryName(Application.ExecutablePath), text, exception);
            MessageBox.Show("Lỗi chương trình! Hãy gửi " + text + ".log cho tác giả. Xin cám ơn!", "Lỗi chương trình", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Application.Exit();
        }
    }
}

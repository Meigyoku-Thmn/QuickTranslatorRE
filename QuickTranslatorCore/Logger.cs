using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace QuickTranslatorCore
{
    public class Logger
    {
        const int OneMB = 1 * 1024 * 1024;
        static readonly string CurrentAppName = Assembly.GetEntryAssembly().GetName().Name;
        static readonly string AppDirPath = Path.GetDirectoryName(Application.ExecutablePath);
        static readonly string LogFilePath = Path.Combine(AppDirPath, CurrentAppName + ".log");

        public static void SetUpErrorHandler()
        {
            Application.ThreadException += (_, e) => UnexpectedErrorHandler(e.Exception);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += (_, e) => UnexpectedErrorHandler(e.ExceptionObject);
        }

        /// <summary>
        /// Append log message to a file specified using Path.Combine(appDirPath, appName + ".log")
        /// </summary>
        public static void LogError(object error)
        {
            // TODO: improve log truncation
            try
            {
                var logFileInfo = new FileInfo(LogFilePath);
                if (logFileInfo.Exists && logFileInfo.Length > OneMB)
                    logFileInfo.Delete();
                var message = string.Format($"[{DateTime.Now:G}] {error}");
                File.AppendAllLines(LogFilePath, new[] { message }, Encoding.UTF8);
            }
            catch { }
        }

        static void UnexpectedErrorHandler(object error)
        {
            LogError(error);
            MessageBox.Show($"Lỗi chương trình! Hãy gửi {CurrentAppName}.log cho tác giả. Xin cám ơn!",
                "Lỗi chương trình", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Application.Exit();
        }
    }
}

using System;
using System.IO;
using System.Text;

namespace QuickTranslatorCore
{
    public class Logger
    {
        const int OneMB = 1 * 1024 * 1024;

        /// <summary>
        /// Append log message to a file specified using Path.Combine(applicationPath, application + ".log")
        /// </summary>
        /// <param name="applicationPath"></param>
        /// <param name="application"></param>
        /// <param name="exception"></param>
        public static void Log(string applicationPath, string application, Exception exception)
        {
            try
            {
                var logPath = Path.Combine(applicationPath, application + ".log");
                var logFileInfo = new FileInfo(logPath);
                if (logFileInfo.Exists && logFileInfo.Length > OneMB)
                    logFileInfo.Delete();
                var message = string.Format($"[{DateTime.Now:G}] {exception}");
                File.AppendAllLines(logPath, new[] { message }, Encoding.UTF8);
            }
            catch { }
        }
    }
}

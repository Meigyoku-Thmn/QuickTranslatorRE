using System;
using System.IO;
using System.Text;

namespace TranslatorEngine
{
    public class ApplicationLog
    {
        public static void Log(string applicationPath, string application, Exception exception)
        {
            try
            {
                var logPath = Path.Combine(applicationPath, application + ".log");
                var logFileInfo = new FileInfo(logPath);
                if (logFileInfo.Exists && 1000000L < logFileInfo.Length)
                {
                    logFileInfo.Delete();
                }
                var contents = string.Format("{0:G}: {1}\r\n", DateTime.Now, string.Concat(new[] {
                    exception.Message,
                    "\r\n",
                    exception.GetType().ToString(),
                    "\r\n",
                    exception.StackTrace
                }));
                File.AppendAllText(logPath, contents, Encoding.UTF8);
            }
            catch { }
        }
    }
}

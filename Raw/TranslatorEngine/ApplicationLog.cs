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
                var text = Path.Combine(applicationPath, application + ".log");
                var fileInfo = new FileInfo(text);
                if (fileInfo.Exists && 1000000L < fileInfo.Length)
                {
                    fileInfo.Delete();
                }
                var contents = string.Format("{0:G}: {1}\r\n", DateTime.Now, string.Concat(new[] {
                    exception.Message,
                    "\r\n",
                    exception.GetType().ToString(),
                    "\r\n",
                    exception.StackTrace
                }));
                File.AppendAllText(text, contents, Encoding.UTF8);
            }
            catch { }
        }
    }
}

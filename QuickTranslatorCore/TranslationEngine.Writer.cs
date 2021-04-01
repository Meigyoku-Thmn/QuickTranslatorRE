using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTranslatorCore
{
    public partial class TranslationEngine
    {
        static void WriteVietPhraseLog(string key, string action)
        {
            UpdateLogInCache(key, action, ref VietPhraseOnlyLogDataSet);
            WriteLog(key, action, DictionaryConfiguration.GetVietPhraseLogPath());
        }

        static void WriteNamesLog(string key, string action, bool usePrimary)
        {
            var dataSet = usePrimary ? NameOnlyLogDataSet : NamePhuOnlyLogDataSet;
            UpdateLogInCache(key, action, ref dataSet);
            WriteLog(key, action, usePrimary ? DictionaryConfiguration.GetNameLogPath() : DictionaryConfiguration.GetSecondaryNameLogPath());
        }

        static void WriteSinoVietPronunciationLog(string key, string action)
        {
            UpdateLogInCache(key, action, ref SinoVietPronunciationLogDataSet);
            WriteLog(key, action, DictionaryConfiguration.GetSinoVietPronunciationLogPath());
        }

        public static void CompressSinoVietPronunciationLog()
            => CompressDictLog(
                SinoVietPronunciationLogDataSet, DictionaryConfiguration.GetSinoVietPronunciationLogPath());

        public static void CompressVietPhraseOnlyLog()
            => CompressDictLog(VietPhraseOnlyLogDataSet, DictionaryConfiguration.GetVietPhraseLogPath());

        public static void WriteLog(string historyLogs, string logPath)
        {
            if (!File.Exists(logPath))
                File.AppendAllText(logPath, "Entry\tAction\tUser Name\tUpdated Date\r\n", Encoding.UTF8);
            File.AppendAllText(logPath, historyLogs, Encoding.UTF8);
        }

        public static void CreateLog(string key, string action, ref StringBuilder historyLogs)
        {
            historyLogs.AppendLine(string.Concat(new[] {
                key,
                "\t",
                action,
                "\t",
                Environment.GetEnvironmentVariable("USERNAME"),
                "\t",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffzzz")
            }));
        }
        public static void WriteLog(string key, string action, string logPath)
        {
            if (!File.Exists(logPath))
                File.AppendAllText(logPath, "Entry\tAction\tUser Name\tUpdated Date\r\n", Encoding.UTF8);

            File.AppendAllText(logPath, string.Concat(new[] {
                key,
                "\t",
                action,
                "\t",
                Environment.GetEnvironmentVariable("USERNAME"),
                "\t",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffzzz"),
                "\r\n"
            }), Encoding.UTF8);
        }

        public static void CompressNameOnlyDictLog(bool usePrimary)
        {
            CompressDictLog(
                usePrimary ? NameOnlyLogDataSet : NamePhuOnlyLogDataSet,
                usePrimary
                    ? DictionaryConfiguration.GetNameLogPath()
                    : DictionaryConfiguration.GetSecondaryNameLogPath()
            );
        }

        static void CompressDictLog(DataSet logDataSet, string logFilePath)
        {
            var bakPath = logFilePath + "." + DateTime.Now.Ticks;
            Helper.CopyIfSourceExists(logFilePath, bakPath, true);
            using (var writer = new StreamWriter(logFilePath, false, Encoding.UTF8))
            {
                try
                {
                    writer.WriteLine("Entry\tAction\tUser Name\tUpdated Date");
                    var logTable = logDataSet.Tables["DictionaryHistory"];
                    foreach (DataRow dataRow in logTable.Rows)
                    {
                        writer.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", new[] {
                            dataRow[0],
                            dataRow[1],
                            dataRow[2],
                            ((DateTime)dataRow[3]).ToString("yyyy-MM-dd HH:mm:ss.fffzzz")
                        }));
                    }
                }
                catch (Exception ex)
                {
                    try { writer.Close(); }
                    catch { }

                    if (File.Exists(logFilePath))
                    {
                        try { File.Copy(bakPath, logFilePath, true); }
                        catch { }
                    }
                    throw ex;
                }
                finally
                {
                    File.Delete(bakPath);
                }
            }
        }
    }
}

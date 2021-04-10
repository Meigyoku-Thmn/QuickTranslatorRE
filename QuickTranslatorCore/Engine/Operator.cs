using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTranslatorCore.Engine
{
    using static Data;
    using static Initializer;

    public class Operator
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
            WriteLog(key, action, usePrimary
                ? DictionaryConfiguration.GetNameLogPath()
                : DictionaryConfiguration.GetSecondaryNameLogPath());
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
            using var writer = new StreamWriter(logFilePath, false, Encoding.UTF8);
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

        public static bool ExistInSinoVietPronunciationDict(string text)
            => text.Length == 1 && SinoVietPronunciationDict.ContainsKey(text);

        static void UpdateLogInCache(string key, string action, ref DataSet logDataset)
        {
            var dataRow = logDataset.Tables["DictionaryHistory"].Rows.Find(key);
            if (dataRow == null)
            {
                logDataset.Tables["DictionaryHistory"].Rows.Add(new object[] {
                    key,
                    action,
                    Environment.GetEnvironmentVariable("USERNAME"),
                    DateTime.Now
                });
                return;
            }
            dataRow[1] = action;
            dataRow[2] = Environment.GetEnvironmentVariable("USERNAME");
            dataRow[3] = DateTime.Now;
        }

        public static void UpdateVietPhraseDict(string key, string value, bool useSort)
        {
            VietPhraseAndNameDict[key] = value;
            VietPhraseOneMeaningDict[key] = value.Split('/', '|')[0];

            string action;
            if (VietPhraseDict.ContainsKey(key))
            {
                VietPhraseDict[key] = value;
                action = "Updated";
            }
            else
            {
                if (useSort)
                    VietPhraseDict[key] = value;
                else
                    VietPhraseDict = AddEntryToDictionaryNoSort(VietPhraseDict, key, value);
                action = "Added";
            }
            WriteVietPhraseLog(key, action);

            var dictPath = DictionaryConfiguration.GetVietPhraseDictPath();

            if (useSort)
                SaveDictionaryToFile(ref VietPhraseDict, dictPath);
            else
                SaveDictionaryToFileNoSort(VietPhraseDict, dictPath);
        }

        public static void UpdateNameDict(string key, string value, bool useSort, bool usePrimary)
        {
            VietPhraseAndNameDict[key] = value;
            VietPhraseOneMeaningDict[key] = value.Split('/', '|')[0];

            var selectedNameDict = usePrimary ? PrimaryNameDict : SecondaryNameDict;

            string action;
            if (selectedNameDict.ContainsKey(key))
            {
                selectedNameDict[key] = value;
                action = "Updated";
            }
            else
            {
                if (useSort)
                    selectedNameDict[key] = value;
                else if (usePrimary)
                    selectedNameDict = PrimaryNameDict = AddEntryToDictionaryNoSort(selectedNameDict, key, value);
                else
                    selectedNameDict = SecondaryNameDict = AddEntryToDictionaryNoSort(selectedNameDict, key, value);
                action = "Added";
            }
            WriteNamesLog(key, action, usePrimary);

            if (NameDict.ContainsKey(key))
            {
                NameDict[key] = value;
                NameOneMeaningDict[key] = value.Split('/', '|')[0];
            }
            else if (useSort)
            {
                NameDict[key] = value;
                NameOneMeaningDict[key] = value.Split('/', '|')[0];
            }
            else
            {
                NameDict = AddEntryToDictionaryNoSort(NameDict, key, value);
                NameOneMeaningDict = AddEntryToDictionaryNoSort(NameOneMeaningDict, key, value.Split('/', '|')[0]);
            }

            var dictPath = usePrimary
                ? DictionaryConfiguration.GetPrimaryNameDictPath()
                : DictionaryConfiguration.GetSecondaryNameDictPath();

            if (useSort)
                SaveDictionaryToFile(ref selectedNameDict, dictPath);
            else
                SaveDictionaryToFileNoSort(selectedNameDict, dictPath);
        }

        public static void UpdateSinoVietPronunciationDict(string key, string value, bool useSort)
        {
            string action;
            if (SinoVietPronunciationDict.ContainsKey(key))
            {
                SinoVietPronunciationDict[key] = value;
                action = "Update";
            }
            else
            {
                if (useSort)
                    SinoVietPronunciationDict[key] = value;
                else
                    SinoVietPronunciationDict = AddEntryToDictionaryNoSort(SinoVietPronunciationDict, key, value);
                action = "Added";
            }
            WriteSinoVietPronunciationLog(key, action);

            var dictPath = DictionaryConfiguration.GetSinoVietPronunciationDictPath();

            if (useSort)
                SaveDictionaryToFile(ref SinoVietPronunciationDict, dictPath);
            else
                SaveDictionaryToFileNoSort(SinoVietPronunciationDict, dictPath);
        }

        private static Dictionary<string, string> AddEntryToDictionaryNoSort(
            Dictionary<string, string> dict, string key, string value)
        {
            return dict
                .Concat(new[] { new KeyValuePair<string, string>(key, value) })
                .ToDictionary(e => e.Key, e => e.Value);
        }

        public static void SaveDictionaryToFileNoSort(Dictionary<string, string> dict, string filePath)
        {
            // Back up old file in case of error
            var bakFilePath = filePath + "." + DateTime.Now.Ticks;
            Helper.CopyIfSourceExists(filePath, bakFilePath, true);

            var lines = dict.Select(pair => $"{pair.Key}={pair.Value}");

            try
            {
                File.WriteAllLines(filePath, lines, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                // Try to restore old file
                try { File.Copy(bakFilePath, filePath, true); }
                catch { }
                throw ex;
            }

            // Remove old file when completing
            if (File.Exists(filePath))
                File.Delete(bakFilePath);
        }


        public static void SaveDictionaryToFile(ref Dictionary<string, string> dict, string filePath)
        {
            var sortedPairs = from pair in dict
                              orderby pair.Key.Length descending, pair.Key
                              select pair;

            var newDict = new Dictionary<string, string>();

            // Back up old file in case of error
            string bakFilePath = filePath + "." + DateTime.Now.Ticks;
            Helper.CopyIfSourceExists(filePath, bakFilePath, true);

            var lines = sortedPairs.Select(pair => $"{pair.Key}={pair.Value}");

            // TODO: maybe the original author really want to sort but didn't know how
            // dict = sortedPairs.ToDictionary(e => e.Key, e => e.Value);

            try
            {
                File.WriteAllLines(filePath, lines, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                // Try to restore old file
                try { File.Copy(bakFilePath, filePath, true); }
                catch { }
                throw ex;
            }

            // Remove old file when completing
            if (File.Exists(filePath))
                File.Delete(bakFilePath);
        }

        public static void AddIgnoredChinesePhrase(string ignoredChinesePhrase)
        {
            if (IgnoredChinesePhrases.Contains(ignoredChinesePhrase))
                return;

            IgnoredChinesePhrases.Add(ignoredChinesePhrase);
            try
            {
                File.WriteAllLines(DictionaryConfiguration.GetIgnoredChinesePhraseListPath(),
                    IgnoredChinesePhrases, Encoding.UTF8);
            }
            catch { }
            LoadIgnoredChinesePhraseLists();
        }

        public static int GetVietPhraseDictCount() => VietPhraseDict.Count;

        public static int GetNameDictCount(bool usePrimary)
            => usePrimary ? PrimaryNameDict.Count : SecondaryNameDict.Count;

        public static int GetSinoVietPronunciationDictCount() => SinoVietPronunciationDict.Count;

        public static string GetVietPhraseLogRecord(string key)
         => GetLogRecordInCache(key, VietPhraseOnlyLogDataSet);

        public static string GetNameLogRecord(string key, bool usePrimary)
            => GetLogRecordInCache(key, usePrimary ? NameOnlyLogDataSet : NamePhuOnlyLogDataSet);

        public static string GetSinoVietPronunciationLogRecord(string key)
            => GetLogRecordInCache(key, SinoVietPronunciationLogDataSet);

        static string GetLogRecordInCache(string key, DataSet logDataSet)
        {
            var dataRow = logDataSet.Tables["DictionaryHistory"].Rows.Find(key);
            if (dataRow == null)
                return "";
            return $"Entry này đã được <{dataRow[2]}> <{dataRow[1]}> " +
                $"lúc <{(DateTime)dataRow[3]:yyyy-MM-dd HH:mm:ss.fffzzz}>.";
        }

        public static string GetVietPhraseOrName(string key)
        {
            VietPhraseAndNameDict.TryGetValue(key, out var value);
            return value;
        }

        public static string GetVietPhrase(string key)
        {
            VietPhraseDict.TryGetValue(key, out var value);
            return value;
        }

        public static string GetName(string key)
        {
            NameDict.TryGetValue(key, out var value);
            return value;
        }

        public static string GetName(string key, bool usePrimary)
        {
            var selectedNameDict = usePrimary ? PrimaryNameDict : SecondaryNameDict;
            selectedNameDict.TryGetValue(key, out var value);
            return value;
        }

        public static void DeleteVietPhrase(string key, bool useSort)
        {
            VietPhraseAndNameDict.Remove(key);
            VietPhraseOneMeaningDict.Remove(key);
            VietPhraseDict.Remove(key);

            var dictPath = DictionaryConfiguration.GetVietPhraseDictPath();

            if (useSort)
                SaveDictionaryToFile(ref VietPhraseDict, dictPath);
            else
                SaveDictionaryToFileNoSort(VietPhraseDict, dictPath);

            WriteVietPhraseLog(key, "Deleted");
        }

        public static void DeleteKeyFromNameDict(string key, bool useSort, bool usePrimary)
        {
            NameDict.Remove(key);
            NameOneMeaningDict.Remove(key);
            VietPhraseAndNameDict.Remove(key);
            VietPhraseOneMeaningDict.Remove(key);

            var selectedNameDict = usePrimary ? PrimaryNameDict : SecondaryNameDict;
            if (!selectedNameDict.Remove(key))
                return;

            var selectedNameDictPath = usePrimary
                ? DictionaryConfiguration.GetPrimaryNameDictPath()
                : DictionaryConfiguration.GetSecondaryNameDictPath();

            if (useSort)
                SaveDictionaryToFile(ref selectedNameDict, selectedNameDictPath);
            else
                SaveDictionaryToFileNoSort(selectedNameDict, selectedNameDictPath);

            WriteNamesLog(key, "Deleted", usePrimary);
        }

        public static void DeleteKeyFromSinoVietPronunciationDict(string key, bool useSort)
        {
            SinoVietPronunciationDict.Remove(key);

            var dictPath = DictionaryConfiguration.GetSinoVietPronunciationDictPath();

            if (useSort)
                SaveDictionaryToFile(ref SinoVietPronunciationDict, dictPath);
            else
                SaveDictionaryToFileNoSort(SinoVietPronunciationDict, dictPath);

            WriteSinoVietPronunciationLog(key, "Deleted");
        }
    }
}

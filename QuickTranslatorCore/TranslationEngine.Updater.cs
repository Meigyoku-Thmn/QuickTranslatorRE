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

            dict = sortedPairs.ToDictionary(e => e.Key, e => e.Value);

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
    }
}

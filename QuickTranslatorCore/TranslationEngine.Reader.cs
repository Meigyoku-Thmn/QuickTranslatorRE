using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTranslatorCore
{
    public partial class TranslationEngine
    {
        static readonly object LockObj = new object();
        public static bool FlagToLoadData = true;

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
    }
}

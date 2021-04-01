using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTranslatorCore
{
    public partial class TranslationEngine
    {
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

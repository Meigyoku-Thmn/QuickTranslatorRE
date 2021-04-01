using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuickTranslatorCore
{
    public partial class TranslationEngine
    {
        public const int CHINESE_LOOKUP_MAX_LENGTH = 20;

        #region Database
        static Dictionary<string, string> SinoVietPronunciationDict = new Dictionary<string, string>();

        static Dictionary<string, string> VietPhraseAndNameDict = new Dictionary<string, string>();

        static Dictionary<string, string> ThieuChuuDict = new Dictionary<string, string>();

        static Dictionary<string, string> LacVietDict = new Dictionary<string, string>();

        static Dictionary<string, string> CedictBabylonDict = new Dictionary<string, string>();

        static Dictionary<string, string> EnglishTransliterationDict = new Dictionary<string, string>();

        static Dictionary<string, string> VietPhraseDict = new Dictionary<string, string>();

        static Dictionary<string, string> VietPhraseOneMeaningDict = new Dictionary<string, string>();

        static Dictionary<string, string> NameDict = new Dictionary<string, string>();

        static Dictionary<string, string> NameOneMeaningDict = new Dictionary<string, string>();

        static Dictionary<string, string> PrimaryNameDict = new Dictionary<string, string>();

        static Dictionary<string, string> SecondaryNameDict = new Dictionary<string, string>();

        static Dictionary<string, string> MultiplyRuleDict = new Dictionary<string, string>();

        static Dictionary<string, string> PronounDict = new Dictionary<string, string>();

        static Dictionary<string, string> PronounOneMeaningDict = new Dictionary<string, string>();

        static Dictionary<string, string> MultiplyByDict = null;

        static Dictionary<string, string> MultiplyByOneMeaningDict = null;

        static DataSet VietPhraseOnlyLogDataSet = new DataSet();

        static DataSet NameOnlyLogDataSet = new DataSet();

        static DataSet NamePhuOnlyLogDataSet = new DataSet();

        static DataSet SinoVietPronunciationLogDataSet = new DataSet();

        static List<string> IgnoredChinesePhrases = new List<string>();

        static List<string> IgnoredChinesePhrasesForBrowser = new List<string>();

        public static string LastTranslatedWord_SinoViet = "";

        public static string LastTranslatedWord_VietPhrase = "";

        public static string LastTranslatedWord_VietPhraseOneMeaning = "";
        #endregion

        public static void LoadDictionaries(bool force = false)
        {
            lock (LockObj)
            {
                if (force == false && FlagToLoadData == false)
                    return;

                Helper.QueueWork(() => SinoVietPronunciationDict
                    = Helper.LoadDictionary(DictionaryConfiguration.GetSinoVietPronunciationDictPath()));

                Helper.QueueWork(() => ThieuChuuDict
                    = Helper.LoadDictionary(DictionaryConfiguration.GetThieuChuuDictPath()));

                Helper.QueueWork(() => LacVietDict
                    = Helper.LoadDictionary(DictionaryConfiguration.GetLacVietDictPath()));

                Helper.QueueWork(() => {
                    CedictBabylonDict = Helper.LoadCedict(DictionaryConfiguration.GetCEDictDictPath());
                    Helper.LoadDictionary(ref CedictBabylonDict, DictionaryConfiguration.GetBabylonDictPath());
                });

                Helper.QueueWork(() => EnglishTransliterationDict =
                    Helper.LoadDictionary(DictionaryConfiguration.GetEnglishTransliterationDictPath()));

                Helper.QueueWork(LoadIgnoredChinesePhraseLists);

                Helper.QueueWork(() => Helper.LoadLog(
                    DictionaryConfiguration.GetNameLogPath(), ref NameOnlyLogDataSet));

                Helper.QueueWork(() => Helper.LoadLog(
                    DictionaryConfiguration.GetSecondaryNameLogPath(), ref NamePhuOnlyLogDataSet));

                Helper.QueueWork(() => Helper.LoadLog(
                    DictionaryConfiguration.GetVietPhraseLogPath(), ref VietPhraseOnlyLogDataSet));

                Helper.QueueWork(() => Helper.LoadLog(
                    DictionaryConfiguration.GetSinoVietPronunciationLogPath(), ref SinoVietPronunciationLogDataSet));

                var multiplyRuleTask = Helper.QueueWork(() => MultiplyRuleDict
                    = Helper.LoadDictionary(DictionaryConfiguration.GetMultiplyRuleDictPath(), ignoreComment: true)
                        .OrderByDescending(e => e.Key.Length)
                            .ThenBy(e => e.Key)
                        .ToDictionary(e => e.Key, e => e.Value),
                    useDoneEvent: true
                );

                foreach (var task in new[] {
                    Helper.QueueWork(() => PronounDict =
                        Helper.LoadDictionary(DictionaryConfiguration.GetPronounDictPath()), useDoneEvent: true),

                    Helper.QueueWork(() => VietPhraseDict
                        = Helper.LoadDictionary(DictionaryConfiguration.GetVietPhraseDictPath()), useDoneEvent: true),

                    Helper.QueueWork(LoadNameOnlyDict, useDoneEvent: true),
                }) task.WaitOne();

                ComposeVietPhraseAndNameDict();
                VietPhraseDictionaryToVietPhraseOneMeaningDictionary();
                PronounDictionaryToPronounOneMeaningDictionary();
                LoadMultiplyByDict();
                LoadMultiplyByOneMeaningDict();

                multiplyRuleTask.WaitOne();

                FlagToLoadData = false;
            }
        }



        static void LoadMultiplyByOneMeaningDict()
        {
            if (DictionaryConfiguration.IsMultiplyByPronoun)
            {
                MultiplyByOneMeaningDict = PronounOneMeaningDict;
                return;
            }

            if (DictionaryConfiguration.IsMultiplyByPronounAndName)
            {
                MultiplyByOneMeaningDict = new Dictionary<string, string>(PronounOneMeaningDict);
                foreach (var pair in NameOneMeaningDict)
                {
                    if (!MultiplyByOneMeaningDict.ContainsKey(pair.Key))
                        MultiplyByOneMeaningDict.Add(pair.Key, pair.Value);
                }
                return;
            }

            if (DictionaryConfiguration.IsMultiplyByPronounAndNameAndVietPhrase)
            {
                MultiplyByOneMeaningDict = new Dictionary<string, string>(PronounOneMeaningDict);
                foreach (var pair in VietPhraseOneMeaningDict)
                {
                    if (!MultiplyByOneMeaningDict.ContainsKey(pair.Key))
                        MultiplyByOneMeaningDict.Add(pair.Key, pair.Value);
                }
                return;
            }

            MultiplyByOneMeaningDict = null;
        }


        static void LoadMultiplyByDict()
        {
            if (DictionaryConfiguration.IsMultiplyByPronoun)
            {
                MultiplyByDict = PronounDict;
                return;
            }

            if (DictionaryConfiguration.IsMultiplyByPronounAndName)
            {
                MultiplyByDict = new Dictionary<string, string>(PronounDict);

                foreach (var pair in NameDict)
                {
                    if (!MultiplyByDict.ContainsKey(pair.Key))
                        MultiplyByDict.Add(pair.Key, pair.Value);
                }
                return;
            }

            if (DictionaryConfiguration.IsMultiplyByPronounAndNameAndVietPhrase)
            {
                MultiplyByDict = new Dictionary<string, string>(PronounDict);
                foreach (var pair in VietPhraseAndNameDict)
                {
                    if (!MultiplyByDict.ContainsKey(pair.Key))
                        MultiplyByDict.Add(pair.Key, pair.Value);
                }
                return;
            }

            MultiplyByDict = null;
        }

        static void VietPhraseDictionaryToVietPhraseOneMeaningDictionary()
        {
            VietPhraseOneMeaningDict = new Dictionary<string, string>();
            foreach (var pair in VietPhraseAndNameDict)
            {
                VietPhraseOneMeaningDict.Add(
                    pair.Key,
                    pair.Value.Contains("/") || pair.Value.Contains("|")
                        ? pair.Value.Split('/', '|')[0]
                        : pair.Value
                );
            }
        }

        static void PronounDictionaryToPronounOneMeaningDictionary()
        {
            PronounOneMeaningDict = new Dictionary<string, string>();
            foreach (var pair in PronounDict)
            {
                PronounOneMeaningDict.Add(
                    pair.Key,
                    pair.Value.Contains("/") || pair.Value.Contains("|")
                        ? pair.Value.Split('/', '|')[0]
                        : pair.Value
                );
            }
        }

        static void LoadIgnoredChinesePhraseLists()
        {
            IgnoredChinesePhrases = new List<string>();
            IgnoredChinesePhrasesForBrowser = new List<string>();

            var trimChars = "\t\n".ToCharArray();
            using (var reader = new StreamReader(DictionaryConfiguration.GetIgnoredChinesePhraseListPath(), true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var rs = NormalizeText(line).Trim(trimChars);
                    if (!string.IsNullOrEmpty(rs) && !IgnoredChinesePhrases.Contains(rs))
                        IgnoredChinesePhrases.Add(rs);

                    var browserRs = NormalizedTextForBrowser(line).Trim(trimChars);
                    if (!string.IsNullOrEmpty(browserRs) && !IgnoredChinesePhrasesForBrowser.Contains(browserRs))
                        IgnoredChinesePhrasesForBrowser.Add(browserRs);
                }
            }
            // Descending
            int IgnoredListComparer(string aPhrase, string bPhrase)
            {
                if (aPhrase == null && bPhrase == null)
                    return 0;
                if (aPhrase == null && bPhrase != null)
                    return 1;
                if (aPhrase != null && bPhrase == null)
                    return -1;

                if (aPhrase.Length > bPhrase.Length)
                    return -1;
                if (aPhrase.Length < bPhrase.Length)
                    return 1;

                return aPhrase.CompareTo(bPhrase) * -1;
            }
            IgnoredChinesePhrases.Sort(new Comparison<string>(IgnoredListComparer));
            IgnoredChinesePhrasesForBrowser.Sort(new Comparison<string>(IgnoredListComparer));
        }

        static void ComposeVietPhraseAndNameDict()
        {
            VietPhraseAndNameDict = new Dictionary<string, string>();
            foreach (var tuple in NameDict)
            {
                if (!VietPhraseAndNameDict.ContainsKey(tuple.Key))
                    VietPhraseAndNameDict.Add(tuple.Key, tuple.Value);
            }
            foreach (var tuple in VietPhraseDict)
            {
                if (!VietPhraseAndNameDict.ContainsKey(tuple.Key))
                    VietPhraseAndNameDict.Add(tuple.Key, tuple.Value);
            }
        }

        static void LoadNameOnlyDict()
        {
            NameDict = new Dictionary<string, string>();
            NameOneMeaningDict = new Dictionary<string, string>();
            PrimaryNameDict = new Dictionary<string, string>();
            SecondaryNameDict = new Dictionary<string, string>();

            var separator = "/|".ToCharArray();
            using (var reader = new StreamReader(DictionaryConfiguration.GetPrimaryNameDictPath(), true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var tuple = line.Split('=');
                    if (tuple.Length == 2 && !NameDict.ContainsKey(tuple[0]))
                    {
                        NameDict.Add(tuple[0], tuple[1]);
                        NameOneMeaningDict.Add(tuple[0], tuple[1].Split(separator)[0]);
                        PrimaryNameDict.Add(tuple[0], tuple[1]);
                    }
                }
            }
            using (var reader = new StreamReader(DictionaryConfiguration.GetSecondaryNameDictPath(), true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var tuple = line.Split('=');
                    if (tuple.Length == 2 && !SecondaryNameDict.ContainsKey(tuple[0]))
                    {
                        if (NameDict.ContainsKey(tuple[0]))
                        {
                            NameDict[tuple[0]] = tuple[1];
                            NameOneMeaningDict[tuple[0]] = tuple[1].Split(separator)[0];
                        }
                        else
                        {
                            NameDict.Add(tuple[0], tuple[1]);
                            NameOneMeaningDict.Add(tuple[0], tuple[1].Split(separator)[0]);
                        }
                        SecondaryNameDict.Add(tuple[0], tuple[1]);
                    }
                }
            }
        }
    }
}

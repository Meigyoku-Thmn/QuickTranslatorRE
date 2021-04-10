using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuickTranslatorCore.Engine
{
    using static Data;
    using static Util;
    using static DictionaryConfiguration;
    using static Helper;

    using WorkList = List<WaitHandle>;

    public class Initializer
    {
        static bool DataIsLoaded = false;

        /// <summary>
        /// This is a partially CPU-bound operation.
        /// </summary>
        public static void LoadDictionaries(bool force = false)
        {
            if (force == false && DataIsLoaded)
                return;

            var works = new WorkList(11);

            works.AddWork(() =>
                SinoVietPronunciationDict = GetSinoVietPronunciationDictPath().LoadDictionary());

            works.AddWork(() =>
                ThieuChuuDict = GetThieuChuuDictPath().LoadDictionary());

            works.AddWork(() =>
                LacVietDict = GetLacVietDictPath().LoadDictionary());

            works.AddWork(() =>
                CedictBabylonDict = (GetCEDictDictPath(), GetBabylonDictPath()).LoadCedictAndBabylon());

            works.AddWork(() =>
                EnglishTransliterationDict = GetEnglishTransliterationDictPath().LoadDictionary());

            works.AddWork(() =>
                LoadIgnoredChinesePhraseLists());

            works.AddWork(() =>
                LoadLog(GetNameLogPath(), NameOnlyLogDataSet));

            works.AddWork(() =>
                LoadLog(GetSecondaryNameLogPath(), NamePhuOnlyLogDataSet));

            works.AddWork(() =>
                LoadLog(GetVietPhraseLogPath(), VietPhraseOnlyLogDataSet));

            works.AddWork(() =>
                LoadLog(GetSinoVietPronunciationLogPath(), SinoVietPronunciationLogDataSet));

            works.AddWork(() =>
                MultiplyRuleDict = GetMultiplyRuleDictPath().LoadDictionary(ignoreComment: true));

            var works2 = new WorkList(3);

            works2.AddWork(() =>
                PronounDict = GetPronounDictPath().LoadDictionary());

            works2.AddWork(() =>
                VietPhraseDict = GetVietPhraseDictPath().LoadDictionary());

            works2.AddWork(() =>
                LoadNameOnlyDict());

            works2.ForEach(work => work.WaitOne());

            ComposeVietPhraseAndNameDict();

            VietPhraseDictionaryToVietPhraseOneMeaningDictionary();

            PronounDictionaryToPronounOneMeaningDictionary();

            LoadMultiplyByDict();

            LoadMultiplyByOneMeaningDict();

            works.ForEach(work => work.WaitOne());

            DataIsLoaded = true;
        }

        public static void LoadMultiplyByOneMeaningDict()
        {
            if (IsMultiplyByPronoun)
            {
                MultiplyByOneMeaningDict = PronounOneMeaningDict;
                return;
            }

            if (IsMultiplyByPronounAndName)
            {
                MultiplyByOneMeaningDict = new Dictionary<string, string>(PronounOneMeaningDict);
                foreach (var pair in NameOneMeaningDict)
                {
                    if (!MultiplyByOneMeaningDict.ContainsKey(pair.Key))
                        MultiplyByOneMeaningDict.Add(pair.Key, pair.Value);
                }
                return;
            }

            if (IsMultiplyByPronounAndNameAndVietPhrase)
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

        internal static void LoadMultiplyByDict()
        {
            if (IsMultiplyByPronoun)
            {
                MultiplyByDict = PronounDict;
                return;
            }

            if (IsMultiplyByPronounAndName)
            {
                MultiplyByDict = new Dictionary<string, string>(PronounDict);

                foreach (var pair in NameDict)
                {
                    if (!MultiplyByDict.ContainsKey(pair.Key))
                        MultiplyByDict.Add(pair.Key, pair.Value);
                }
                return;
            }

            if (IsMultiplyByPronounAndNameAndVietPhrase)
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

        static void PronounDictionaryToPronounOneMeaningDictionary()
        {
            PronounOneMeaningDict = PronounDict
                .ToDictionary(pair => pair.Key,
                    pair => pair.Value.Contains("/") || pair.Value.Contains("|")
                        ? pair.Value.Split('/', '|')[0]
                        : pair.Value);
        }

        static void VietPhraseDictionaryToVietPhraseOneMeaningDictionary()
        {
            VietPhraseOneMeaningDict = VietPhraseAndNameDict
                .ToDictionary(pair => pair.Key,
                    pair => pair.Value.Contains("/") || pair.Value.Contains("|")
                        ? pair.Value.Split('/', '|')[0]
                        : pair.Value);
        }

        static void ComposeVietPhraseAndNameDict()
        {
            VietPhraseAndNameDict = new Dictionary<string, string>(NameDict);
            foreach (var pair in VietPhraseDict)
            {
                if (!VietPhraseAndNameDict.ContainsKey(pair.Key))
                    VietPhraseAndNameDict.Add(pair.Key, pair.Value);
            }
        }

        static void LoadNameOnlyDict()
        {
            NameDict = new Dictionary<string, string>();
            NameOneMeaningDict = new Dictionary<string, string>();
            PrimaryNameDict = new Dictionary<string, string>();
            SecondaryNameDict = new Dictionary<string, string>();

            var separator = "/|".ToCharArray();
            using (var reader = new StreamReader(GetPrimaryNameDictPath(), true))
            {
                foreach (var line in reader.Lines())
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
            using (var reader = new StreamReader(GetSecondaryNameDictPath(), true))
            {
                foreach (var line in reader.Lines())
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

        internal static void LoadIgnoredChinesePhraseLists()
        {
            IgnoredChinesePhrases = new List<string>();
            IgnoredChinesePhrasesForBrowser = new List<string>();

            var trimChars = "\t\n".ToCharArray();
            using (var reader = new StreamReader(GetIgnoredChinesePhraseListPath(), true))
            {
                foreach (var line in reader.Lines())
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
            static int IgnoredListComparer(string aPhrase, string bPhrase)
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
    }
}

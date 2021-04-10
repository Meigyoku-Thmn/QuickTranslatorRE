using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTranslatorCore.Engine
{
    using StringDict = Dictionary<string, string>;

    internal class Data
    {
        public static StringDict SinoVietPronunciationDict = new StringDict();

        public static StringDict VietPhraseAndNameDict = new StringDict();

        public static StringDict ThieuChuuDict = new StringDict();

        public static StringDict LacVietDict = new StringDict();

        public static StringDict CedictBabylonDict = new StringDict();

        public static StringDict EnglishTransliterationDict = new StringDict();

        public static StringDict VietPhraseDict = new StringDict();

        public static StringDict VietPhraseOneMeaningDict = new StringDict();

        public static StringDict NameDict = new StringDict();

        public static StringDict NameOneMeaningDict = new StringDict();

        public static StringDict PrimaryNameDict = new StringDict();

        public static StringDict SecondaryNameDict = new StringDict();

        public static StringDict MultiplyRuleDict = new StringDict();

        public static StringDict PronounDict = new StringDict();

        public static StringDict PronounOneMeaningDict = new StringDict();

        public static StringDict MultiplyByDict = null;

        public static StringDict MultiplyByOneMeaningDict = null;

        public static DataSet VietPhraseOnlyLogDataSet = new DataSet();

        public static DataSet NameOnlyLogDataSet = new DataSet();

        public static DataSet NamePhuOnlyLogDataSet = new DataSet();

        public static DataSet SinoVietPronunciationLogDataSet = new DataSet();

        public static List<string> IgnoredChinesePhrases = new List<string>();

        public static List<string> IgnoredChinesePhrasesForBrowser = new List<string>();

        public static string LastTranslatedWord_SinoViet = "";

        public static string LastTranslatedWord_VietPhrase = "";

        public static string LastTranslatedWord_VietPhraseOneMeaning = "";
    }
}

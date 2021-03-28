using System;
using System.IO;
using System.Reflection;

namespace TranslatorEngine
{
    public class DictionaryConfigurationHelper
    {
        public static string GetNamesPhuDictionaryPath() => GetDictionaryPathByKey("NamesPhu");

        public static string GetNamesDictionaryPath() => GetDictionaryPathByKey("Names");

        public static string GetNamesDictionaryHistoryPath()
        {
            return Path.Combine(
                Path.GetDirectoryName(GetNamesDictionaryPath()),
                Path.GetFileNameWithoutExtension(GetNamesDictionaryPath())
                    + "History"
                    + Path.GetExtension(GetNamesDictionaryPath())
            );
        }

        public static string GetNamesPhuDictionaryHistoryPath()
        {
            return Path.Combine(
                Path.GetDirectoryName(GetNamesPhuDictionaryPath()),
                Path.GetFileNameWithoutExtension(GetNamesPhuDictionaryPath())
                    + "History"
                    + Path.GetExtension(GetNamesPhuDictionaryPath())
            );
        }

        public static string GetVietPhraseDictionaryPath() => GetDictionaryPathByKey("VietPhrase");

        public static string GetVietPhraseDictionaryHistoryPath()
        {
            return Path.Combine(
                Path.GetDirectoryName(GetVietPhraseDictionaryPath()),
                Path.GetFileNameWithoutExtension(GetVietPhraseDictionaryPath())
                    + "History"
                    + Path.GetExtension(GetVietPhraseDictionaryPath())
            );
        }

        public static string GetChinesePhienAmWordsDictionaryPath() => GetDictionaryPathByKey("ChinesePhienAmWords");

        public static string GetChinesePhienAmWordsDictionaryHistoryPath()
        {
            return Path.Combine(
                Path.GetDirectoryName(GetChinesePhienAmWordsDictionaryPath()),
                Path.GetFileNameWithoutExtension(GetChinesePhienAmWordsDictionaryPath())
                    + "History"
                    + Path.GetExtension(GetChinesePhienAmWordsDictionaryPath())
            );
        }

        public static string GetChinesePhienAmEnglishWordsDictionaryPath()
            => GetDictionaryPathByKey("ChinesePhienAmEnglishWords");

        public static string GetCEDictDictionaryPath()
            => GetDictionaryPathByKey("CEDict");

        public static string GetBabylonDictionaryPath()
            => GetDictionaryPathByKey("Babylon");

        public static string GetLacVietDictionaryPath()
            => GetDictionaryPathByKey("LacViet");

        public static string GetThieuChuuDictionaryPath()
            => GetDictionaryPathByKey("ThieuChuu");

        public static string GetIgnoredChinesePhraseListPath()
            => GetDictionaryPathByKey("IgnoredChinesePhrases");

        public static string GetLuatNhanDictionaryPath()
            => GetDictionaryPathByKey("LuatNhan");

        public static string GetPronounsDictionaryPath()
            => GetDictionaryPathByKey("Pronouns");

        static string GetDictionaryPathByKey(string dictionaryKey)
        {
            var array = File.ReadAllLines(Path.Combine(directoryPath, "Dictionaries.config"));
            var text = "";
            foreach (var text2 in array)
            {
                if (!string.IsNullOrEmpty(text2) && !text2.StartsWith("#") && text2.StartsWith(dictionaryKey + "="))
                {
                    text = text2.Split('=')[1];
                    break;
                }
            }
            if (!Path.IsPathRooted(text))
            {
                text = Path.Combine(directoryPath, text);
            }
            if (!File.Exists(text))
            {
                throw new FileNotFoundException("Dictionary Not Found: " + text);
            }
            return text;
        }

        public static bool IsNhanByPronouns {
            get {
                if (string.IsNullOrEmpty(thuatToanNhan))
                {
                    ReadThuatToanNhan();
                }
                return thuatToanNhan == "1";
            }
        }

        public static bool IsNhanByPronounsAndNames {
            get {
                if (string.IsNullOrEmpty(thuatToanNhan))
                {
                    ReadThuatToanNhan();
                }
                return thuatToanNhan == "2";
            }
        }

        public static bool IsNhanByPronounsAndNamesAndVietPhrase {
            get {
                if (string.IsNullOrEmpty(thuatToanNhan))
                {
                    ReadThuatToanNhan();
                }
                return thuatToanNhan == "3";
            }
        }

        static void ReadThuatToanNhan()
        {
            string[] array = File.ReadAllLines(Path.Combine(directoryPath, "Dictionaries.config"));
            foreach (string text in array)
            {
                if (!string.IsNullOrEmpty(text) && !text.StartsWith("#") && text.StartsWith("ThuatToanNhan="))
                {
                    thuatToanNhan = text.Split('=')[1];
                    return;
                }
            }
        }

        static readonly string directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        static string thuatToanNhan = "";
    }
}

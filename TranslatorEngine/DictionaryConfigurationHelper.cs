using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TranslatorEngine
{
    public class DictionaryConfigurationHelper
    {
        public static string GetNamesPhuDictionaryPath()
            => GetDictionaryPathByKey("NamesPhu");

        public static string GetNamesDictionaryPath()
            => GetDictionaryPathByKey("Names");

        public static string GetVietPhraseDictionaryPath()
            => GetDictionaryPathByKey("VietPhrase");

        public static string GetChinesePhienAmWordsDictionaryPath()
            => GetDictionaryPathByKey("ChinesePhienAmWords");

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

        public static string GetVietPhraseDictionaryHistoryPath()
        {
            return Path.Combine(
                Path.GetDirectoryName(GetVietPhraseDictionaryPath()),
                Path.GetFileNameWithoutExtension(GetVietPhraseDictionaryPath())
                    + "History"
                    + Path.GetExtension(GetVietPhraseDictionaryPath())
            );
        }


        public static string GetChinesePhienAmWordsDictionaryHistoryPath()
        {
            return Path.Combine(
                Path.GetDirectoryName(GetChinesePhienAmWordsDictionaryPath()),
                Path.GetFileNameWithoutExtension(GetChinesePhienAmWordsDictionaryPath())
                    + "History"
                    + Path.GetExtension(GetChinesePhienAmWordsDictionaryPath())
            );
        }


        static string GetDictionaryPathByKey(string key)
        {
            var lines = File.ReadAllLines(Path.Combine(Constants.ConfigsDir, "Dictionaries.config"));

            var dictPath = lines
                .FirstOrDefault(line =>
                    !string.IsNullOrWhiteSpace(line) && !line.StartsWith("#") && line.StartsWith(key + "="))
                ?.Split('=')[1] ?? "";

            if (!Path.IsPathRooted(dictPath))
                dictPath = Path.Combine(Constants.WorkingDir, dictPath);

            if (!File.Exists(dictPath))
                throw new FileNotFoundException("Dictionary Not Found: " + dictPath);

            return dictPath;
        }

        public static bool IsNhanByPronouns {
            get => GetMultiplyAlgorithmConfig() == "1";
        }

        public static bool IsNhanByPronounsAndNames {
            get => GetMultiplyAlgorithmConfig() == "2";
        }

        public static bool IsNhanByPronounsAndNamesAndVietPhrase {
            get => GetMultiplyAlgorithmConfig() == "3";
        }

        static string _multiplyAlgorithm = "";
        static string GetMultiplyAlgorithmConfig()
        {
            if (!string.IsNullOrEmpty(_multiplyAlgorithm))
                return _multiplyAlgorithm;

            var lines = File.ReadAllLines(Path.Combine(Constants.ConfigsDir, "Dictionaries.config"));

            _multiplyAlgorithm = lines
                .FirstOrDefault(line =>
                    !string.IsNullOrWhiteSpace(line) && !line.StartsWith("#") & line.StartsWith("ThuatToanNhan="))
                ?.Split('=')[1] ?? _multiplyAlgorithm;

            return _multiplyAlgorithm;
        }
    }
}

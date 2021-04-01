using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace QuickTranslatorCore
{
    public class DictionaryConfiguration
    {
        static readonly string MultiplyAlgorithm;

        static DictionaryConfiguration()
        {
            var lines = File.ReadAllLines(Path.Combine(Constants.ConfigsDir, "Dictionaries.config"));
            MultiplyAlgorithm = lines
                .Select(line => line.Trim())
                .FirstOrDefault(line =>
                    !string.IsNullOrWhiteSpace(line) && !line.StartsWith("#") & line.StartsWith("ThuatToanNhan="))
                ?.Split('=')[1] ?? MultiplyAlgorithm;
        }

        public static bool IsMultiplyByPronoun {
            get => MultiplyAlgorithm == "1";
        }

        public static bool IsMultiplyByPronounAndName {
            get => MultiplyAlgorithm == "2";
        }

        public static bool IsMultiplyByPronounAndNameAndVietPhrase {
            get => MultiplyAlgorithm == "3";
        }
        // Tên phụ
        public static string GetSecondaryNameDictPath()
            => GetDictionaryPathByKey("NamesPhu");

        // Tên chính
        public static string GetPrimaryNameDictPath()
            => GetDictionaryPathByKey("Names");

        // Cụm từ Việt
        public static string GetVietPhraseDictPath()
            => GetDictionaryPathByKey("VietPhrase");

        // Phiên âm Hán-Việt
        public static string GetSinoVietPronunciationDictPath()
            => GetDictionaryPathByKey("ChinesePhienAmWords");

        // Chuyển tự Tiếng Anh
        public static string GetEnglishTransliterationDictPath()
            => GetDictionaryPathByKey("ChinesePhienAmEnglishWords");

        // Từ điển CEDict
        public static string GetCEDictDictPath()
            => GetDictionaryPathByKey("CEDict");

        // Từ điển Babylon
        public static string GetBabylonDictPath()
            => GetDictionaryPathByKey("Babylon");

        // Từ điển Lạc Việt
        public static string GetLacVietDictPath()
            => GetDictionaryPathByKey("LacViet");

        // Tự điển Thiều Chửu
        public static string GetThieuChuuDictPath()
            => GetDictionaryPathByKey("ThieuChuu");

        // List những cụm từ Tiếng Trung được lược bỏ
        public static string GetIgnoredChinesePhraseListPath()
            => GetDictionaryPathByKey("IgnoredChinesePhrases");

        // Luật nhân
        public static string GetMultiplyRuleDictPath()
            => GetDictionaryPathByKey("LuatNhan");

        // Đại từ
        public static string GetPronounDictPath()
            => GetDictionaryPathByKey("Pronouns");

        public static string GetNameLogPath()
            => MakeLogPath(GetPrimaryNameDictPath());

        public static string GetSecondaryNameLogPath()
            => MakeLogPath(GetSecondaryNameDictPath());

        public static string GetVietPhraseLogPath()
            => MakeLogPath(GetVietPhraseDictPath());


        public static string GetSinoVietPronunciationLogPath()
            => MakeLogPath(GetSinoVietPronunciationDictPath());

        static string MakeLogPath(string dictPath) => Path.Combine(
            Path.GetDirectoryName(dictPath),
            Path.GetFileNameWithoutExtension(dictPath)
                + "History"
                + Path.GetExtension(dictPath)
        );


        static string GetDictionaryPathByKey(string key)
        {
            var lines = File.ReadAllLines(Path.Combine(Constants.ConfigsDir, "Dictionaries.config"));

            var dictPath = lines
                .Select(line => line.Trim())
                .FirstOrDefault(line =>
                    !string.IsNullOrWhiteSpace(line) && !line.StartsWith("#") && line.StartsWith(key + "="))
                ?.Split('=')[1] ?? "";

            if (!Path.IsPathRooted(dictPath))
                dictPath = Path.Combine(Constants.WorkingDir, dictPath);

            if (!File.Exists(dictPath))
                throw new FileNotFoundException("Không tìm thấy file từ điển: " + dictPath);

            return dictPath;
        }
    }
}

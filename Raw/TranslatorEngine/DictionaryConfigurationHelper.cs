using System;
using System.IO;
using System.Reflection;

namespace TranslatorEngine
{
    // Token: 0x02000007 RID: 7
    public class DictionaryConfigurationHelper
    {
        // Token: 0x0600000F RID: 15 RVA: 0x00002220 File Offset: 0x00001220
        public static string GetNamesPhuDictionaryPath()
        {
            return GetDictionaryPathByKey("NamesPhu");
        }

        // Token: 0x06000010 RID: 16 RVA: 0x0000222C File Offset: 0x0000122C
        public static string GetNamesDictionaryPath()
        {
            return GetDictionaryPathByKey("Names");
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002238 File Offset: 0x00001238
        public static string GetNamesDictionaryHistoryPath()
        {
            return Path.Combine(Path.GetDirectoryName(GetNamesDictionaryPath()), Path.GetFileNameWithoutExtension(GetNamesDictionaryPath()) + "History" + Path.GetExtension(GetNamesDictionaryPath()));
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002267 File Offset: 0x00001267
        public static string GetNamesPhuDictionaryHistoryPath()
        {
            return Path.Combine(Path.GetDirectoryName(GetNamesPhuDictionaryPath()), Path.GetFileNameWithoutExtension(GetNamesPhuDictionaryPath()) + "History" + Path.GetExtension(GetNamesPhuDictionaryPath()));
        }

        // Token: 0x06000013 RID: 19 RVA: 0x00002296 File Offset: 0x00001296
        public static string GetVietPhraseDictionaryPath()
        {
            return GetDictionaryPathByKey("VietPhrase");
        }

        // Token: 0x06000014 RID: 20 RVA: 0x000022A2 File Offset: 0x000012A2
        public static string GetVietPhraseDictionaryHistoryPath()
        {
            return Path.Combine(Path.GetDirectoryName(GetVietPhraseDictionaryPath()), Path.GetFileNameWithoutExtension(GetVietPhraseDictionaryPath()) + "History" + Path.GetExtension(GetVietPhraseDictionaryPath()));
        }

        // Token: 0x06000015 RID: 21 RVA: 0x000022D1 File Offset: 0x000012D1
        public static string GetChinesePhienAmWordsDictionaryPath()
        {
            return GetDictionaryPathByKey("ChinesePhienAmWords");
        }

        // Token: 0x06000016 RID: 22 RVA: 0x000022DD File Offset: 0x000012DD
        public static string GetChinesePhienAmWordsDictionaryHistoryPath()
        {
            return Path.Combine(Path.GetDirectoryName(GetChinesePhienAmWordsDictionaryPath()), Path.GetFileNameWithoutExtension(GetChinesePhienAmWordsDictionaryPath()) + "History" + Path.GetExtension(GetChinesePhienAmWordsDictionaryPath()));
        }

        // Token: 0x06000017 RID: 23 RVA: 0x0000230C File Offset: 0x0000130C
        public static string GetChinesePhienAmEnglishWordsDictionaryPath()
        {
            return GetDictionaryPathByKey("ChinesePhienAmEnglishWords");
        }

        // Token: 0x06000018 RID: 24 RVA: 0x00002318 File Offset: 0x00001318
        public static string GetCEDictDictionaryPath()
        {
            return GetDictionaryPathByKey("CEDict");
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00002324 File Offset: 0x00001324
        public static string GetBabylonDictionaryPath()
        {
            return GetDictionaryPathByKey("Babylon");
        }

        // Token: 0x0600001A RID: 26 RVA: 0x00002330 File Offset: 0x00001330
        public static string GetLacVietDictionaryPath()
        {
            return GetDictionaryPathByKey("LacViet");
        }

        // Token: 0x0600001B RID: 27 RVA: 0x0000233C File Offset: 0x0000133C
        public static string GetThieuChuuDictionaryPath()
        {
            return GetDictionaryPathByKey("ThieuChuu");
        }

        // Token: 0x0600001C RID: 28 RVA: 0x00002348 File Offset: 0x00001348
        public static string GetIgnoredChinesePhraseListPath()
        {
            return GetDictionaryPathByKey("IgnoredChinesePhrases");
        }

        // Token: 0x0600001D RID: 29 RVA: 0x00002354 File Offset: 0x00001354
        public static string GetLuatNhanDictionaryPath()
        {
            return GetDictionaryPathByKey("LuatNhan");
        }

        // Token: 0x0600001E RID: 30 RVA: 0x00002360 File Offset: 0x00001360
        public static string GetPronounsDictionaryPath()
        {
            return GetDictionaryPathByKey("Pronouns");
        }

        // Token: 0x0600001F RID: 31 RVA: 0x0000236C File Offset: 0x0000136C
        private static string GetDictionaryPathByKey(string dictionaryKey)
        {
            string[] array = File.ReadAllLines(Path.Combine(directoryPath, "Dictionaries.config"));
            string text = string.Empty;
            foreach (string text2 in array)
            {
                if (!string.IsNullOrEmpty(text2) && !text2.StartsWith("#") && text2.StartsWith(dictionaryKey + "="))
                {
                    text = text2.Split(new char[]
                    {
                        '='
                    })[1];
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

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x06000020 RID: 32 RVA: 0x0000241E File Offset: 0x0000141E
        public static bool IsNhanByPronouns {
            get {
                if (string.IsNullOrEmpty(thuatToanNhan))
                {
                    readThuatToanNhan();
                }
                return thuatToanNhan == "1";
            }
        }

        // Token: 0x17000004 RID: 4
        // (get) Token: 0x06000021 RID: 33 RVA: 0x00002440 File Offset: 0x00001440
        public static bool IsNhanByPronounsAndNames {
            get {
                if (string.IsNullOrEmpty(thuatToanNhan))
                {
                    readThuatToanNhan();
                }
                return thuatToanNhan == "2";
            }
        }

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x06000022 RID: 34 RVA: 0x00002462 File Offset: 0x00001462
        public static bool IsNhanByPronounsAndNamesAndVietPhrase {
            get {
                if (string.IsNullOrEmpty(thuatToanNhan))
                {
                    readThuatToanNhan();
                }
                return thuatToanNhan == "3";
            }
        }

        // Token: 0x06000023 RID: 35 RVA: 0x00002484 File Offset: 0x00001484
        private static void readThuatToanNhan()
        {
            string[] array = File.ReadAllLines(Path.Combine(directoryPath, "Dictionaries.config"));
            foreach (string text in array)
            {
                if (!string.IsNullOrEmpty(text) && !text.StartsWith("#") && text.StartsWith("ThuatToanNhan="))
                {
                    thuatToanNhan = text.Split(new char[]
                    {
                        '='
                    })[1];
                    return;
                }
            }
        }

        // Token: 0x04000004 RID: 4
        private static string directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // Token: 0x04000005 RID: 5
        private static string thuatToanNhan = string.Empty;
    }
}

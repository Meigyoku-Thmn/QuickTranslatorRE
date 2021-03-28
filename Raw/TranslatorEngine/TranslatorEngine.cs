using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;

namespace TranslatorEngine
{
    public class TranslatorEngine
    {
        public static bool DictionaryDirty { get; set; }

        public static string GetVietPhraseOrNameValueFromKey(string key)
        {
            vietPhraseDictionary.TryGetValue(key, out var value);
            return value;
        }

        public static string GetVietPhraseValueFromKey(string key)
        {
            onlyVietPhraseDictionary.TryGetValue(key, out var value);
            return value;
        }

        public static string GetNameValueFromKey(string key)
        {
            onlyNameDictionary.TryGetValue(key, out var value);
            return value;
        }

        public static string GetNameValueFromKey(string key, bool isNameChinh)
        {
            var dict = isNameChinh ? onlyNameChinhDictionary : onlyNamePhuDictionary;
            dict.TryGetValue(key, out var value);
            return value;
        }

        public static void DeleteKeyFromVietPhraseDictionary(string key, bool sorting)
        {
            vietPhraseDictionary.Remove(key);
            vietPhraseOneMeaningDictionary.Remove(key);
            onlyVietPhraseDictionary.Remove(key);
            if (sorting)
            {
                SaveDictionaryToFile(ref onlyVietPhraseDictionary, DictionaryConfigurationHelper.GetVietPhraseDictionaryPath());
            }
            else
            {
                SaveDictionaryToFileWithoutSorting(onlyVietPhraseDictionary, DictionaryConfigurationHelper.GetVietPhraseDictionaryPath());
            }
            WriteVietPhraseHistoryLog(key, "Deleted");
        }

        public static void DeleteKeyFromNameDictionary(string key, bool sorting, bool isNameChinh)
        {
            vietPhraseDictionary.Remove(key);
            vietPhraseOneMeaningDictionary.Remove(key);
            onlyNameDictionary.Remove(key);
            onlyNameOneMeaningDictionary.Remove(key);
            var dict = isNameChinh ? onlyNameChinhDictionary : onlyNamePhuDictionary;
            if (!dict.Remove(key))
                return;

            if (sorting)
            {
                SaveDictionaryToFile(ref dict, isNameChinh ? DictionaryConfigurationHelper.GetNamesDictionaryPath() : DictionaryConfigurationHelper.GetNamesPhuDictionaryPath());
            }
            else
            {
                SaveDictionaryToFileWithoutSorting(dict, isNameChinh ? DictionaryConfigurationHelper.GetNamesDictionaryPath() : DictionaryConfigurationHelper.GetNamesPhuDictionaryPath());
            }
            WriteNamesHistoryLog(key, "Deleted", isNameChinh);
        }

        public static void DeleteKeyFromPhienAmDictionary(string key, bool sorting)
        {
            hanVietDictionary.Remove(key);
            if (sorting)
            {
                SaveDictionaryToFile(ref hanVietDictionary, DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryPath());
            }
            else
            {
                SaveDictionaryToFileWithoutSorting(hanVietDictionary, DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryPath());
            }
            WritePhienAmHistoryLog(key, "Deleted");
        }

        public static void UpdateVietPhraseDictionary(string key, string value, bool sorting)
        {
            vietPhraseDictionary[key] = value;
            vietPhraseOneMeaningDictionary[key] = value.Split('/', '|')[0];
            if (onlyVietPhraseDictionary.ContainsKey(key))
            {
                onlyVietPhraseDictionary[key] = value;
                WriteVietPhraseHistoryLog(key, "Updated");
            }
            else
            {
                if (sorting)
                {
                    onlyVietPhraseDictionary.Add(key, value);
                }
                else
                {
                    onlyVietPhraseDictionary = AddEntryToDictionaryWithoutSorting(onlyVietPhraseDictionary, key, value);
                }
                WriteVietPhraseHistoryLog(key, "Added");
            }

            if (sorting)
            {
                SaveDictionaryToFile(ref onlyVietPhraseDictionary, DictionaryConfigurationHelper.GetVietPhraseDictionaryPath());
                return;
            }
            SaveDictionaryToFileWithoutSorting(onlyVietPhraseDictionary, DictionaryConfigurationHelper.GetVietPhraseDictionaryPath());
        }

        static Dictionary<string, string> AddEntryToDictionaryWithoutSorting(Dictionary<string, string> dictionary, string key, string value)
        {
            return dictionary
                .Concat(new[] { new KeyValuePair<string, string>(key, value) })
                .ToDictionary(e => e.Key, e => e.Value);
        }

        public static void UpdateNameDictionary(string key, string value, bool sorting, bool isNameChinh)
        {
            vietPhraseDictionary[key] = value;
            vietPhraseOneMeaningDictionary[key] = value.Split('/', '|')[0];
            var dict = isNameChinh ? onlyNameChinhDictionary : onlyNamePhuDictionary;

            if (dict.ContainsKey(key))
            {
                dict[key] = value;
                WriteNamesHistoryLog(key, "Updated", isNameChinh);
            }
            else
            {
                if (sorting)
                {
                    dict.Add(key, value);
                }
                else if (isNameChinh)
                {
                    onlyNameChinhDictionary = AddEntryToDictionaryWithoutSorting(onlyNameChinhDictionary, key, value);
                    dict = onlyNameChinhDictionary;
                }
                else
                {
                    onlyNamePhuDictionary = AddEntryToDictionaryWithoutSorting(onlyNamePhuDictionary, key, value);
                    dict = onlyNamePhuDictionary;
                }
                WriteNamesHistoryLog(key, "Added", isNameChinh);
            }

            if (onlyNameDictionary.ContainsKey(key))
            {
                onlyNameDictionary[key] = value;
                onlyNameOneMeaningDictionary[key] = value.Split('/', '|')[0];
            }
            else if (sorting)
            {
                onlyNameDictionary.Add(key, value);
                onlyNameOneMeaningDictionary.Add(key, value.Split('/', '|')[0]);
            }
            else
            {
                onlyNameDictionary = AddEntryToDictionaryWithoutSorting(onlyNameDictionary, key, value);
                onlyNameOneMeaningDictionary = AddEntryToDictionaryWithoutSorting(onlyNameOneMeaningDictionary, key, value.Split('/', '|')[0]);
            }
            if (sorting)
            {
                SaveDictionaryToFile(ref dict, isNameChinh ? DictionaryConfigurationHelper.GetNamesDictionaryPath() : DictionaryConfigurationHelper.GetNamesPhuDictionaryPath());
                return;
            }
            SaveDictionaryToFileWithoutSorting(dict, isNameChinh ? DictionaryConfigurationHelper.GetNamesDictionaryPath() : DictionaryConfigurationHelper.GetNamesPhuDictionaryPath());
        }

        public static void UpdatePhienAmDictionary(string key, string value, bool sorting)
        {
            if (hanVietDictionary.ContainsKey(key))
            {
                hanVietDictionary[key] = value;
                WritePhienAmHistoryLog(key, "Updated");
            }
            else
            {
                if (sorting)
                {
                    hanVietDictionary.Add(key, value);
                }
                else
                {
                    hanVietDictionary = AddEntryToDictionaryWithoutSorting(hanVietDictionary, key, value);
                }
                WritePhienAmHistoryLog(key, "Added");
            }
            if (sorting)
            {
                SaveDictionaryToFile(ref hanVietDictionary, DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryPath());
                return;
            }
            SaveDictionaryToFileWithoutSorting(hanVietDictionary, DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryPath());
        }

        public static void SaveDictionaryToFileWithoutSorting(Dictionary<string, string> dict, string filePath)
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

        public static string ChineseToHanViet(string chinese, out CharRange[] chineseHanVietMappingArray)
        {
            LastTranslatedWord_HanViet = "";
            var list = new List<CharRange>();
            var stringBuilder = new StringBuilder();
            int length = chinese.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int length2 = stringBuilder.ToString().Length;
                char c = chinese[i];
                char character = chinese[i + 1];
                if (IsChineseInternal(c))
                {
                    if (IsChineseInternal(character))
                    {
                        AppendTranslatedWord(stringBuilder, ChineseToHanViet(c), ref LastTranslatedWord_HanViet, ref length2);
                        stringBuilder.Append(" ");
                        LastTranslatedWord_HanViet += " ";
                        list.Add(new CharRange(length2, ChineseToHanViet(c).Length));
                    }
                    else
                    {
                        AppendTranslatedWord(stringBuilder, ChineseToHanViet(c), ref LastTranslatedWord_HanViet, ref length2);
                        list.Add(new CharRange(length2, ChineseToHanViet(c).Length));
                    }
                }
                else
                {
                    stringBuilder.Append(c);
                    LastTranslatedWord_HanViet += c.ToString();
                    list.Add(new CharRange(length2, 1));
                }
            }
            if (IsChineseInternal(chinese[length - 1]))
            {
                AppendTranslatedWord(stringBuilder, ChineseToHanViet(chinese[length - 1]), ref LastTranslatedWord_HanViet);
                list.Add(new CharRange(stringBuilder.ToString().Length, ChineseToHanViet(chinese[length - 1]).Length));
            }
            else
            {
                stringBuilder.Append(chinese[length - 1]);
                LastTranslatedWord_HanViet += chinese[length - 1].ToString();
                list.Add(new CharRange(stringBuilder.ToString().Length, 1));
            }
            chineseHanVietMappingArray = list.ToArray();
            LastTranslatedWord_HanViet = "";
            return stringBuilder.ToString();
        }

        public static string ChineseToHanVietForBrowser(string chinese)
        {
            if (string.IsNullOrEmpty(chinese))
                return "";
            chinese = StandardizeInputForBrowser(chinese);
            var stringBuilder = new StringBuilder();
            var array = ClassifyWordsIntoLatinAndChinese(chinese);
            var num = array.Length;
            for (int i = 0; i < num; i++)
            {
                string text = array[i];
                if (!string.IsNullOrEmpty(text))
                {
                    string text2;
                    if (IsChineseInternal(text[0]))
                    {
                        text2 = ChineseToHanViet(text, out _).TrimStart(new char[0]);
                        if (i == 0 || !array[i - 1].EndsWith(", "))
                        {
                            text2 = ToUpperCase(text2);
                        }
                    }
                    else
                    {
                        text2 = text;
                    }
                    stringBuilder.Append(text2);
                }
            }
            return stringBuilder.ToString();
        }

        public static string ChineseToHanVietForBatch(string chinese)
        {
            var str = "";
            var stringBuilder = new StringBuilder();
            var length = chinese.Length;
            for (int i = 0; i < length - 1; i++)
            {
                char c = chinese[i];
                char character = chinese[i + 1];
                if (IsChineseInternal(c))
                {
                    if (IsChineseInternal(character))
                    {
                        AppendTranslatedWord(stringBuilder, ChineseToHanViet(c), ref str);
                        stringBuilder.Append(" ");
                        str += " ";
                    }
                    else
                    {
                        AppendTranslatedWord(stringBuilder, ChineseToHanViet(c), ref str);
                    }
                }
                else
                {
                    stringBuilder.Append(c);
                    str += c.ToString();
                }
            }
            if (IsChineseInternal(chinese[length - 1]))
            {
                AppendTranslatedWord(stringBuilder, ChineseToHanViet(chinese[length - 1]), ref str);
            }
            else
            {
                stringBuilder.Append(chinese[length - 1]);
                str += chinese[length - 1].ToString();
            }
            return stringBuilder.ToString();
        }

        public static string ChineseToHanViet(char chinese)
        {
            if (chinese == ' ')
            {
                return "";
            }
            if (!hanVietDictionary.ContainsKey(chinese.ToString()))
            {
                return ToNarrow(chinese.ToString());
            }
            return hanVietDictionary[chinese.ToString()];
        }

        public static string ChineseToVietPhrase(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName, out CharRange[] chinesePhraseRanges, out CharRange[] vietPhraseRanges)
        {
            LastTranslatedWord_VietPhrase = "";
            var list = new List<CharRange>();
            var list2 = new List<CharRange>();
            var stringBuilder = new StringBuilder();
            int num = chinese.Length - 1;
            int i = 0;
            int num2 = -1;
            int num3 = -1;
            int num4 = -1;
            LoadNhanByDictionary();
            while (i <= num)
            {
                bool flag = false;
                bool flag2 = true;
                for (int j = 20; j > 0; j--)
                {
                    if (chinese.Length >= i + j)
                    {
                        if (vietPhraseDictionary.ContainsKey(chinese.Substring(i, j)))
                        {
                            if ((!prioritizedName || !ContainsName(chinese, i, j)) && ((translationAlgorithm != 0 && translationAlgorithm != 2) || IsLongestPhraseInSentence(chinese, i, j, vietPhraseDictionary, translationAlgorithm) || (prioritizedName && onlyNameDictionary.ContainsKey(chinese.Substring(i, j)))))
                            {
                                list.Add(new CharRange(i, j));
                                if (wrapType == 0)
                                {
                                    AppendTranslatedWord(stringBuilder, vietPhraseDictionary[chinese.Substring(i, j)], ref LastTranslatedWord_VietPhrase);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - vietPhraseDictionary[chinese.Substring(i, j)].Length, vietPhraseDictionary[chinese.Substring(i, j)].Length));
                                }
                                else if (wrapType == 1 || wrapType == 11)
                                {
                                    AppendTranslatedWord(stringBuilder, "[" + vietPhraseDictionary[chinese.Substring(i, j)] + "]", ref LastTranslatedWord_VietPhrase);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - vietPhraseDictionary[chinese.Substring(i, j)].Length - 2, vietPhraseDictionary[chinese.Substring(i, j)].Length + 2));
                                }
                                else if (HasOnlyOneMeaning(vietPhraseDictionary[chinese.Substring(i, j)]))
                                {
                                    AppendTranslatedWord(stringBuilder, vietPhraseDictionary[chinese.Substring(i, j)], ref LastTranslatedWord_VietPhrase);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - vietPhraseDictionary[chinese.Substring(i, j)].Length, vietPhraseDictionary[chinese.Substring(i, j)].Length));
                                }
                                else
                                {
                                    AppendTranslatedWord(stringBuilder, "[" + vietPhraseDictionary[chinese.Substring(i, j)] + "]", ref LastTranslatedWord_VietPhrase);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - vietPhraseDictionary[chinese.Substring(i, j)].Length - 2, vietPhraseDictionary[chinese.Substring(i, j)].Length + 2));
                                }
                                if (NextCharIsChinese(chinese, i + j - 1))
                                {
                                    stringBuilder.Append(" ");
                                    LastTranslatedWord_VietPhrase += " ";
                                }
                                flag = true;
                                i += j;
                                break;
                            }
                        }
                        else if (!chinese.Substring(i, j).Contains("\n") && !chinese.Substring(i, j).Contains("\t") && nhanByDictionary != null && flag2 && 2 < j && num2 < i + j - 1 && IsAllChinese(chinese.Substring(i, j)))
                        {
                            if (i < num3)
                            {
                                if (num3 < i + j && j <= num4 - num3)
                                {
                                    j = num3 - i + 1;
                                }
                            }
                            else
                            {
                                int num6 = ContainsLuatNhan(chinese.Substring(i, j), nhanByDictionary, out _, out int num5);
                                num3 = i + num6;
                                num4 = num3 + num5;
                                if (num6 == 0)
                                {
                                    if (IsLongestPhraseInSentence(chinese, i - 1, num5 - 1, vietPhraseOneMeaningDictionary, translationAlgorithm))
                                    {
                                        j = num5;
                                        list.Add(new CharRange(i, j));
                                        string text = ChineseToLuatNhan(chinese.Substring(i, j), nhanByDictionary);
                                        if (wrapType == 0)
                                        {
                                            AppendTranslatedWord(stringBuilder, text, ref LastTranslatedWord_VietPhrase);
                                            list2.Add(new CharRange(stringBuilder.ToString().Length - text.Length, text.Length));
                                        }
                                        else if (wrapType == 1 || wrapType == 11)
                                        {
                                            AppendTranslatedWord(stringBuilder, "[" + text + "]", ref LastTranslatedWord_VietPhrase);
                                            list2.Add(new CharRange(stringBuilder.ToString().Length - text.Length - 2, text.Length + 2));
                                        }
                                        else if (HasOnlyOneMeaning(text))
                                        {
                                            AppendTranslatedWord(stringBuilder, text, ref LastTranslatedWord_VietPhrase);
                                            list2.Add(new CharRange(stringBuilder.ToString().Length - text.Length, text.Length));
                                        }
                                        else
                                        {
                                            AppendTranslatedWord(stringBuilder, "[" + text + "]", ref LastTranslatedWord_VietPhrase);
                                            list2.Add(new CharRange(stringBuilder.ToString().Length - text.Length - 2, text.Length + 2));
                                        }
                                        if (NextCharIsChinese(chinese, i + j - 1))
                                        {
                                            stringBuilder.Append(" ");
                                            LastTranslatedWord_VietPhrase += " ";
                                        }
                                        flag = true;
                                        i += j;
                                        break;
                                    }
                                }
                                else if (0 >= num6)
                                {
                                    num2 = i + j - 1;
                                    flag2 = false;
                                    int num7 = 100;
                                    while (i + num7 < chinese.Length && IsChineseInternal(chinese[i + num7 - 1]))
                                    {
                                        num7++;
                                    }
                                    if (i + num7 <= chinese.Length)
                                    {
                                        num6 = ContainsLuatNhan(chinese.Substring(i, num7), nhanByDictionary, out _, out _);
                                        if (num6 < 0)
                                        {
                                            num2 = i + num7 - 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (!flag)
                {
                    int length = stringBuilder.ToString().Length;
                    int num8 = ChineseToHanViet(chinese[i]).Length;
                    list.Add(new CharRange(i, 1));
                    if (IsChineseInternal(chinese[i]))
                    {
                        AppendTranslatedWord(stringBuilder, ((wrapType != 1) ? "" : "[") + ChineseToHanViet(chinese[i]) + ((wrapType != 1) ? "" : "]"), ref LastTranslatedWord_VietPhrase);
                        if (NextCharIsChinese(chinese, i))
                        {
                            stringBuilder.Append(" ");
                            LastTranslatedWord_VietPhrase += " ";
                        }
                        num8 += ((wrapType != 1) ? 0 : 2);
                    }
                    else if ((chinese[i] == '"' || chinese[i] == '\'') && !LastTranslatedWord_VietPhrase.EndsWith(" ") && !LastTranslatedWord_VietPhrase.EndsWith(".") && !LastTranslatedWord_VietPhrase.EndsWith("?") && !LastTranslatedWord_VietPhrase.EndsWith("!") && !LastTranslatedWord_VietPhrase.EndsWith("\t") && i < chinese.Length - 1 && chinese[i + 1] != ' ' && chinese[i + 1] != ',')
                    {
                        stringBuilder.Append(" ").Append(chinese[i]);
                        LastTranslatedWord_VietPhrase = LastTranslatedWord_VietPhrase + " " + chinese[i].ToString();
                    }
                    else
                    {
                        stringBuilder.Append(chinese[i]);
                        LastTranslatedWord_VietPhrase += chinese[i].ToString();
                        num8 = 1;
                    }
                    list2.Add(new CharRange(length, num8));
                    i++;
                }
            }
            chinesePhraseRanges = list.ToArray();
            vietPhraseRanges = list2.ToArray();
            LastTranslatedWord_VietPhrase = "";
            return stringBuilder.ToString();
        }

        public static string ChineseToVietPhraseForBrowser(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName)
        {
            chinese = StandardizeInputForBrowser(chinese);
            var stringBuilder = new StringBuilder();
            var array = ClassifyWordsIntoLatinAndChinese(chinese);
            foreach (var text in array)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    if (IsChineseInternal(text[0]))
                    {
                        stringBuilder.Append(
                            ChineseToVietPhrase(text, wrapType, translationAlgorithm, prioritizedName, out _, out _));
                    }
                    else
                    {
                        stringBuilder.Append(text);
                    }
                }
            }
            return stringBuilder.ToString();
        }

        public static string ChineseToVietPhraseForBatch(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName)
        {
            string text = "";
            StringBuilder stringBuilder = new StringBuilder();
            int num = chinese.Length - 1;
            int i = 0;
            int num2 = -1;
            int num3 = -1;
            int num4 = -1;
            while (i <= num)
            {
                bool flag = false;
                bool flag2 = true;
                for (int j = 20; j > 0; j--)
                {
                    if (chinese.Length >= i + j)
                    {
                        if (vietPhraseDictionary.ContainsKey(chinese.Substring(i, j)))
                        {
                            if ((!prioritizedName || !ContainsName(chinese, i, j)) && ((translationAlgorithm != 0 && translationAlgorithm != 2) || IsLongestPhraseInSentence(chinese, i, j, vietPhraseDictionary, translationAlgorithm) || (prioritizedName && onlyNameDictionary.ContainsKey(chinese.Substring(i, j)))))
                            {
                                if (!string.IsNullOrEmpty(vietPhraseDictionary[chinese.Substring(i, j)]))
                                {
                                    if (wrapType == 0)
                                    {
                                        AppendTranslatedWord(stringBuilder, vietPhraseDictionary[chinese.Substring(i, j)], ref text);
                                    }
                                    else if (wrapType == 1 || wrapType == 11)
                                    {
                                        AppendTranslatedWord(stringBuilder, "[" + vietPhraseDictionary[chinese.Substring(i, j)] + "]", ref text);
                                    }
                                    else if (HasOnlyOneMeaning(vietPhraseDictionary[chinese.Substring(i, j)]))
                                    {
                                        AppendTranslatedWord(stringBuilder, vietPhraseDictionary[chinese.Substring(i, j)], ref text);
                                    }
                                    else
                                    {
                                        AppendTranslatedWord(stringBuilder, "[" + vietPhraseDictionary[chinese.Substring(i, j)] + "]", ref text);
                                    }
                                    if (NextCharIsChinese(chinese, i + j - 1))
                                    {
                                        stringBuilder.Append(" ");
                                        text += " ";
                                    }
                                }
                                flag = true;
                                i += j;
                                break;
                            }
                        }
                        else if (!chinese.Substring(i, j).Contains("\n") && !chinese.Substring(i, j).Contains("\t") && nhanByDictionary != null && flag2 && 2 < j && num2 < i + j - 1 && IsAllChinese(chinese.Substring(i, j)))
                        {
                            if (i < num3)
                            {
                                if (num3 < i + j && j <= num4 - num3)
                                {
                                    j = num3 - i + 1;
                                }
                            }
                            else
                            {
                                int num6 = ContainsLuatNhan(chinese.Substring(i, j), nhanByDictionary, out _, out int num5);
                                num3 = i + num6;
                                num4 = num3 + num5;
                                if (num6 == 0)
                                {
                                    if (IsLongestPhraseInSentence(chinese, i - 1, num5 - 1, vietPhraseOneMeaningDictionary, translationAlgorithm))
                                    {
                                        j = num5;
                                        string text2 = ChineseToLuatNhan(chinese.Substring(i, j), nhanByDictionary);
                                        if (wrapType == 0)
                                        {
                                            AppendTranslatedWord(stringBuilder, text2, ref text);
                                        }
                                        else if (wrapType == 1 || wrapType == 11)
                                        {
                                            AppendTranslatedWord(stringBuilder, "[" + text2 + "]", ref text);
                                        }
                                        else if (HasOnlyOneMeaning(text2))
                                        {
                                            AppendTranslatedWord(stringBuilder, text2, ref text);
                                        }
                                        else
                                        {
                                            AppendTranslatedWord(stringBuilder, "[" + text2 + "]", ref text);
                                        }
                                        if (NextCharIsChinese(chinese, i + j - 1))
                                        {
                                            stringBuilder.Append(" ");
                                            text += " ";
                                        }
                                        flag = true;
                                        i += j;
                                        break;
                                    }
                                }
                                else if (0 >= num6)
                                {
                                    num2 = i + j - 1;
                                    flag2 = false;
                                    int num7 = 100;
                                    while (i + num7 < chinese.Length && IsChineseInternal(chinese[i + num7 - 1]))
                                    {
                                        num7++;
                                    }
                                    if (i + num7 <= chinese.Length)
                                    {
                                        num6 = ContainsLuatNhan(chinese.Substring(i, num7), nhanByDictionary, out _, out _);
                                        if (num6 < 0)
                                        {
                                            num2 = i + num7 - 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (!flag)
                {
                    if (IsChineseInternal(chinese[i]))
                    {
                        AppendTranslatedWord(stringBuilder, ((wrapType != 1) ? "" : "[") + ChineseToHanViet(chinese[i]) + ((wrapType != 1) ? "" : "]"), ref text);
                        if (NextCharIsChinese(chinese, i))
                        {
                            stringBuilder.Append(" ");
                            text += " ";
                        }
                    }
                    else if ((chinese[i] == '"' || chinese[i] == '\'') && !text.EndsWith(" ") && !text.EndsWith(".") && !text.EndsWith("?") && !text.EndsWith("!") && !text.EndsWith("\t") && i < chinese.Length - 1 && chinese[i + 1] != ' ' && chinese[i + 1] != ',')
                    {
                        stringBuilder.Append(" ").Append(chinese[i]);
                        text = text + " " + chinese[i].ToString();
                    }
                    else
                    {
                        stringBuilder.Append(chinese[i]);
                        text += chinese[i].ToString();
                    }
                    i++;
                }
            }
            return stringBuilder.ToString().Replace("  ", " ");
        }

        public static string ChineseToVietPhraseOneMeaning(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName, out CharRange[] chinesePhraseRanges, out CharRange[] vietPhraseRanges)
        {
            LastTranslatedWord_VietPhraseOneMeaning = "";
            List<CharRange> list = new List<CharRange>();
            List<CharRange> list2 = new List<CharRange>();
            StringBuilder stringBuilder = new StringBuilder();
            int num = chinese.Length - 1;
            int i = 0;
            int num2 = -1;
            int num3 = -1;
            int num4 = -1;
            LoadNhanByOneMeaningDictionary();
            while (i <= num)
            {
                bool flag = false;
                bool flag2 = true;
                for (int j = 20; j > 0; j--)
                {
                    if (chinese.Length >= i + j)
                    {
                        if (vietPhraseOneMeaningDictionary.ContainsKey(chinese.Substring(i, j)))
                        {
                            if ((!prioritizedName || !ContainsName(chinese, i, j)) && ((translationAlgorithm != 0 && translationAlgorithm != 2) || IsLongestPhraseInSentence(chinese, i, j, vietPhraseOneMeaningDictionary, translationAlgorithm) || (prioritizedName && onlyNameDictionary.ContainsKey(chinese.Substring(i, j)))))
                            {
                                list.Add(new CharRange(i, j));
                                if (wrapType == 0)
                                {
                                    AppendTranslatedWord(stringBuilder, vietPhraseOneMeaningDictionary[chinese.Substring(i, j)], ref LastTranslatedWord_VietPhraseOneMeaning);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - vietPhraseOneMeaningDictionary[chinese.Substring(i, j)].Length, vietPhraseOneMeaningDictionary[chinese.Substring(i, j)].Length));
                                }
                                else
                                {
                                    AppendTranslatedWord(stringBuilder, "[" + vietPhraseOneMeaningDictionary[chinese.Substring(i, j)] + "]", ref LastTranslatedWord_VietPhraseOneMeaning);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - vietPhraseOneMeaningDictionary[chinese.Substring(i, j)].Length - 2, vietPhraseOneMeaningDictionary[chinese.Substring(i, j)].Length + 2));
                                }
                                if (NextCharIsChinese(chinese, i + j - 1))
                                {
                                    stringBuilder.Append(" ");
                                    LastTranslatedWord_VietPhraseOneMeaning += " ";
                                }
                                flag = true;
                                i += j;
                                break;
                            }
                        }
                        else if (!chinese.Substring(i, j).Contains("\n") && !chinese.Substring(i, j).Contains("\t") && nhanByOneMeaningDictionary != null && flag2 && 2 < j && num2 < i + j - 1 && IsAllChinese(chinese.Substring(i, j)))
                        {
                            if (i < num3)
                            {
                                if (num3 < i + j && j <= num4 - num3)
                                {
                                    j = num3 - i + 1;
                                }
                            }
                            else
                            {
                                int num6 = ContainsLuatNhan(chinese.Substring(i, j), nhanByOneMeaningDictionary, out _, out int num5);
                                num3 = i + num6;
                                num4 = num3 + num5;
                                if (num6 == 0)
                                {
                                    if (IsLongestPhraseInSentence(chinese, i - 1, num5 - 1, vietPhraseOneMeaningDictionary, translationAlgorithm))
                                    {
                                        j = num5;
                                        list.Add(new CharRange(i, j));
                                        string text = ChineseToLuatNhan(chinese.Substring(i, j), nhanByOneMeaningDictionary);
                                        if (wrapType == 0)
                                        {
                                            AppendTranslatedWord(stringBuilder, text, ref LastTranslatedWord_VietPhraseOneMeaning);
                                            list2.Add(new CharRange(stringBuilder.ToString().Length - text.Length, text.Length));
                                        }
                                        else
                                        {
                                            AppendTranslatedWord(stringBuilder, "[" + text + "]", ref LastTranslatedWord_VietPhraseOneMeaning);
                                            list2.Add(new CharRange(stringBuilder.ToString().Length - text.Length - 2, text.Length + 2));
                                        }
                                        if (NextCharIsChinese(chinese, i + j - 1))
                                        {
                                            stringBuilder.Append(" ");
                                            LastTranslatedWord_VietPhraseOneMeaning += " ";
                                        }
                                        flag = true;
                                        i += j;
                                        break;
                                    }
                                }
                                else if (0 >= num6)
                                {
                                    num2 = i + j - 1;
                                    flag2 = false;
                                    int num7 = 100;
                                    while (i + num7 < chinese.Length && IsChineseInternal(chinese[i + num7 - 1]))
                                    {
                                        num7++;
                                    }
                                    if (i + num7 <= chinese.Length)
                                    {
                                        num6 = ContainsLuatNhan(chinese.Substring(i, num7), nhanByOneMeaningDictionary, out _, out _);
                                        if (num6 < 0)
                                        {
                                            num2 = i + num7 - 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (!flag)
                {
                    int length = stringBuilder.ToString().Length;
                    int num8 = ChineseToHanViet(chinese[i]).Length;
                    list.Add(new CharRange(i, 1));
                    if (IsChineseInternal(chinese[i]))
                    {
                        AppendTranslatedWord(stringBuilder, ((wrapType != 1) ? "" : "[") + ChineseToHanViet(chinese[i]) + ((wrapType != 1) ? "" : "]"), ref LastTranslatedWord_VietPhraseOneMeaning);
                        if (NextCharIsChinese(chinese, i))
                        {
                            stringBuilder.Append(" ");
                            LastTranslatedWord_VietPhraseOneMeaning += " ";
                        }
                        num8 += ((wrapType != 1) ? 0 : 2);
                    }
                    else if ((chinese[i] == '"' || chinese[i] == '\'') && !LastTranslatedWord_VietPhraseOneMeaning.EndsWith(" ") && !LastTranslatedWord_VietPhraseOneMeaning.EndsWith(".") && !LastTranslatedWord_VietPhraseOneMeaning.EndsWith("?") && !LastTranslatedWord_VietPhraseOneMeaning.EndsWith("!") && !LastTranslatedWord_VietPhraseOneMeaning.EndsWith("\t") && i < chinese.Length - 1 && chinese[i + 1] != ' ' && chinese[i + 1] != ',')
                    {
                        stringBuilder.Append(" ").Append(chinese[i]);
                        LastTranslatedWord_VietPhraseOneMeaning = LastTranslatedWord_VietPhraseOneMeaning + " " + chinese[i].ToString();
                    }
                    else
                    {
                        stringBuilder.Append(chinese[i]);
                        LastTranslatedWord_VietPhraseOneMeaning += chinese[i].ToString();
                        num8 = 1;
                    }
                    list2.Add(new CharRange(length, num8));
                    i++;
                }
            }
            chinesePhraseRanges = list.ToArray();
            vietPhraseRanges = list2.ToArray();
            LastTranslatedWord_VietPhraseOneMeaning = "";
            return stringBuilder.ToString();
        }

        public static string ChineseToVietPhraseOneMeaningForBrowser(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName)
        {
            chinese = StandardizeInputForBrowser(chinese);
            var stringBuilder = new StringBuilder();
            var array = ClassifyWordsIntoLatinAndChinese(chinese);
            int num = array.Length;
            for (int i = 0; i < num; i++)
            {
                var text = array[i];
                if (!string.IsNullOrEmpty(text))
                {
                    string text2;
                    if (IsChineseInternal(text[0]))
                    {
                        text2 = ChineseToVietPhraseOneMeaning(text, wrapType, translationAlgorithm, prioritizedName,
                            out _, out _).TrimStart();
                        if (i == 0 || !array[i - 1].EndsWith(", "))
                        {
                            text2 = ToUpperCase(text2);
                        }
                    }
                    else
                    {
                        text2 = text;
                    }
                    stringBuilder.Append(text2);
                }
            }
            return stringBuilder.ToString();
        }

        public static string ChineseToVietPhraseOneMeaningForProxy(string chinese, int wrapType,
            int translationAlgorithm, bool prioritizedName)
        {
            chinese = StandardizeInputForProxy(chinese);
            var stringBuilder = new StringBuilder();
            var array = ClassifyWordsIntoLatinAndChineseForProxy(chinese);
            foreach (string text in array)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    if (IsChineseInternal(text[0]))
                    {
                        stringBuilder.Append(ChineseToVietPhraseOneMeaning(text, wrapType, translationAlgorithm, prioritizedName, out _, out _));
                    }
                    else
                    {
                        stringBuilder.Append(text);
                    }
                }
            }
            return stringBuilder.ToString();
        }

        public static string ChineseToVietPhraseOneMeaningForBatch(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName)
        {
            var text = "";
            var stringBuilder = new StringBuilder();
            int num = chinese.Length - 1;
            int i = 0;
            int num2 = -1;
            int num3 = -1;
            int num4 = -1;
            while (i <= num)
            {
                var flag = false;
                var flag2 = true;
                if (chinese[i] != '\n' && chinese[i] != '\t')
                {
                    for (int j = 20; j > 0; j--)
                    {
                        if (chinese.Length >= i + j)
                        {
                            if (vietPhraseOneMeaningDictionary.ContainsKey(chinese.Substring(i, j)))
                            {
                                if ((!prioritizedName || !ContainsName(chinese, i, j)) && ((translationAlgorithm != 0 && translationAlgorithm != 2) || IsLongestPhraseInSentence(chinese, i, j, vietPhraseOneMeaningDictionary, translationAlgorithm) || (prioritizedName && onlyNameDictionary.ContainsKey(chinese.Substring(i, j)))))
                                {
                                    if (!string.IsNullOrEmpty(vietPhraseOneMeaningDictionary[chinese.Substring(i, j)]))
                                    {
                                        if (wrapType == 0)
                                        {
                                            AppendTranslatedWord(stringBuilder, vietPhraseOneMeaningDictionary[chinese.Substring(i, j)], ref text);
                                        }
                                        else
                                        {
                                            AppendTranslatedWord(stringBuilder, "[" + vietPhraseOneMeaningDictionary[chinese.Substring(i, j)] + "]", ref text);
                                        }
                                        if (NextCharIsChinese(chinese, i + j - 1))
                                        {
                                            stringBuilder.Append(" ");
                                            text += " ";
                                        }
                                    }
                                    flag = true;
                                    i += j;
                                    break;
                                }
                            }
                            else if (!chinese.Substring(i, j).Contains("\n") && !chinese.Substring(i, j).Contains("\t") && nhanByOneMeaningDictionary != null && flag2 && 2 < j && num2 < i + j - 1 && IsAllChinese(chinese.Substring(i, j)))
                            {
                                if (i < num3)
                                {
                                    if (num3 < i + j && j <= num4 - num3)
                                    {
                                        j = num3 - i + 1;
                                    }
                                }
                                else
                                {
                                    int num6 = ContainsLuatNhan(chinese.Substring(i, j), nhanByOneMeaningDictionary, out _, out int num5);
                                    num3 = i + num6;
                                    num4 = num3 + num5;
                                    if (num6 == 0)
                                    {
                                        if (IsLongestPhraseInSentence(chinese, i - 1, num5 - 1, vietPhraseOneMeaningDictionary, translationAlgorithm))
                                        {
                                            j = num5;
                                            string text2 = ChineseToLuatNhan(chinese.Substring(i, j), nhanByOneMeaningDictionary);
                                            if (wrapType == 0)
                                            {
                                                AppendTranslatedWord(stringBuilder, text2, ref text);
                                            }
                                            else
                                            {
                                                AppendTranslatedWord(stringBuilder, "[" + text2 + "]", ref text);
                                            }
                                            if (NextCharIsChinese(chinese, i + j - 1))
                                            {
                                                stringBuilder.Append(" ");
                                                text += " ";
                                            }
                                            flag = true;
                                            i += j;
                                            break;
                                        }
                                    }
                                    else if (0 >= num6)
                                    {
                                        num2 = i + j - 1;
                                        flag2 = false;
                                        int num7 = 100;
                                        while (i + num7 < chinese.Length && IsChineseInternal(chinese[i + num7 - 1]))
                                        {
                                            num7++;
                                        }
                                        if (i + num7 <= chinese.Length)
                                        {
                                            num6 = ContainsLuatNhan(chinese.Substring(i, num7), nhanByOneMeaningDictionary, out _, out _);
                                            if (num6 < 0)
                                            {
                                                num2 = i + num7 - 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (!flag)
                {
                    if (IsChineseInternal(chinese[i]))
                    {
                        AppendTranslatedWord(stringBuilder, ((wrapType != 1) ? "" : "[") + ChineseToHanViet(chinese[i]) + ((wrapType != 1) ? "" : "]"), ref text);
                        if (NextCharIsChinese(chinese, i))
                        {
                            stringBuilder.Append(" ");
                            text += " ";
                        }
                    }
                    else if ((chinese[i] == '"' || chinese[i] == '\'') && !text.EndsWith(" ") && !text.EndsWith(".") && !text.EndsWith("?") && !text.EndsWith("!") && !text.EndsWith("\t") && i < chinese.Length - 1 && chinese[i + 1] != ' ' && chinese[i + 1] != ',')
                    {
                        stringBuilder.Append(" ").Append(chinese[i]);
                        text = text + " " + chinese[i].ToString();
                    }
                    else
                    {
                        stringBuilder.Append(chinese[i]);
                        text += chinese[i].ToString();
                    }
                    i++;
                }
            }
            return stringBuilder.ToString();
        }

        public static string ChineseToNameForBatch(string chinese)
        {
            var stringBuilder = new StringBuilder();
            int num = chinese.Length - 1;
            int i = 0;
            while (i <= num)
            {
                bool flag = false;
                if (IsChineseInternal(chinese[i]))
                {
                    for (int j = 20; j > 0; j--)
                    {
                        if (chinese.Length >= i + j && onlyNameDictionary.ContainsKey(chinese.Substring(i, j)))
                        {
                            stringBuilder.Append(onlyNameDictionary[chinese.Substring(i, j)]);
                            flag = true;
                            i += j;
                            break;
                        }
                    }
                }
                if (!flag)
                {
                    stringBuilder.Append(chinese[i]);
                    i++;
                }
            }
            return stringBuilder.ToString();
        }

        public static string ChineseToMeanings(string chinese, out int phraseTranslatedLength)
        {
            string text = "";
            if (chinese.Length == 0)
            {
                phraseTranslatedLength = 0;
                return "";
            }
            int num = 0;
            for (int i = 20; i > 0; i--)
            {
                if (chinese.Length >= i
                    && !chinese.Substring(0, i).Contains("\n")
                    && !chinese.Substring(0, i).Contains("\t"))
                {
                    if (ContainsLuatNhan(chinese.Substring(0, i), vietPhraseDictionary) != 0)
                    {
                        break;
                    }
                    if (MatchesLuatNhan(chinese.Substring(0, i), vietPhraseDictionary))
                    {
                        ChineseToLuatNhan(chinese.Substring(0, i), vietPhraseDictionary, out string empty);
                        var text2 = text;
                        text = string.Concat(new[] {
                            text2,
                            empty,
                            " <<Luật Nhân>> ",
                            luatNhanDictionary[empty].Replace("/", "; "),
                            "\n-----------------\n"
                        });
                        if (num == 0)
                        {
                            num = i;
                        }
                    }
                }
            }
            for (int j = 20; j > 0; j--)
            {
                if (chinese.Length >= j)
                {
                    var text3 = chinese.Substring(0, j);
                    if (vietPhraseDictionary.ContainsKey(text3))
                    {
                        var text4 = text;
                        text = string.Concat(new[] {
                            text4,
                            text3,
                            " <<VietPhrase>> ",
                            vietPhraseDictionary[text3].Replace("/", "; "),
                            "\n-----------------\n"
                        });
                        if (num == 0)
                        {
                            num = text3.Length;
                        }
                    }
                }
            }
            for (int k = 20; k > 0; k--)
            {
                if (chinese.Length >= k)
                {
                    var text3 = chinese.Substring(0, k);
                    if (lacVietDictionary.ContainsKey(text3))
                    {
                        var text5 = text;
                        text = string.Concat(new[] {
                            text5,
                            text3,
                            " <<Lạc Việt>>\n",
                            lacVietDictionary[text3],
                            "\n-----------------\n"
                        });
                        if (num == 0)
                        {
                            num = 1;
                        }
                    }
                }
            }
            for (int l = 20; l > 0; l--)
            {
                if (chinese.Length >= l)
                {
                    string text3 = chinese.Substring(0, l);
                    if (cedictDictionary.ContainsKey(text3))
                    {
                        var text6 = text;
                        text = string.Concat(new[] {
                            text6,
                            text3,
                            " <<Cedict or Babylon>> ",
                            cedictDictionary[text3].Replace("] /", "] ").Replace("/", "; "),
                            "\n-----------------\n"
                        });
                        if (num == 0)
                        {
                            num = 1;
                        }
                    }
                }
            }
            if (thieuChuuDictionary.ContainsKey(chinese[0].ToString()))
            {
                num = ((num == 0) ? 1 : num);
                var obj = text;
                text = string.Concat(new[] {
                    obj,
                    chinese[0].ToString(),
                    " <<Thiều Chửu>> ",
                    thieuChuuDictionary[chinese[0].ToString()],
                    "\n-----------------\n"
                });
            }
            int num2 = (chinese.Length < 10) ? chinese.Length : 10;
            text = text + chinese.Substring(0, num2).Trim("\n\t ".ToCharArray()) + " <<Phiên Âm English>> ";
            for (int m = 0; m < num2; m++)
            {
                if (chinesePhienAmEnglishDictionary.ContainsKey(chinese[m].ToString()))
                {
                    text = text + "[" + chinesePhienAmEnglishDictionary[chinese[m].ToString()] + "] ";
                }
                else
                {
                    text = text + ChineseToHanViet(chinese[m]) + " ";
                }
            }
            if (num == 0)
            {
                num = 1;
                text = chinese[0] + "\n-----------------\nNot Found";
            }
            phraseTranslatedLength = num;
            return text;
        }

        public static void LoadDictionaries()
        {
            lock (lockObject)
            {
                if (DictionaryDirty)
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadHanVietDictionaryWithNewThread));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadThieuChuuDictionaryWithNewThread));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadLacVietDictionaryWithNewThread));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadCedictDictionaryWithNewThread));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadChinesePhienAmEnglishDictionaryWithNewThread));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadIgnoredChinesePhraseListsWithNewThread));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadOnlyNameDictionaryHistoryWithNewThread));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadOnlyNamePhuDictionaryHistoryWithNewThread));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadOnlyVietPhraseDictionaryHistoryWithNewThread));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadHanVietDictionaryHistoryWithNewThread));
                    var array = new[] {
                        new ManualResetEvent(false)
                    };
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadLuatNhanDictionaryWithNewThread), array[0]);
                    var array2 = new[] {
                        new ManualResetEvent(false)
                    };
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadPronounDictionaryWithNewThread), array2[0]);
                    var array3 = new[] {
                        new ManualResetEvent(false)
                    };
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadOnlyVietPhraseDictionaryWithNewThread), array3[0]);
                    var array4 = new[] {
                        new ManualResetEvent(false)
                    };
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadOnlyNameDictionaryWithNewThread), array4[0]);
                    WaitHandle.WaitAll(array2);
                    WaitHandle.WaitAll(array3);
                    WaitHandle.WaitAll(array4);
                    LoadVietPhraseDictionary();
                    VietPhraseDictionaryToVietPhraseOneMeaningDictionary();
                    PronounDictionaryToPronounOneMeaningDictionary();
                    LoadNhanByDictionary();
                    LoadNhanByOneMeaningDictionary();
                    WaitHandle.WaitAll(array);
                    DictionaryDirty = false;
                }
            }
        }

        static void LoadLuatNhanDictionaryWithNewThread(object stateInfo)
        {
            LoadLuatNhanDictionary();
            ((ManualResetEvent)stateInfo).Set();
        }

        static void LoadLuatNhanDictionary()
        {
            var dictionary = new Dictionary<string, string>();
            using (var textReader = new StreamReader(DictionaryConfigurationHelper.GetLuatNhanDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    if (!text.StartsWith("#"))
                    {
                        var array = text.Split('=');
                        if (array.Length == 2 && !dictionary.ContainsKey(array[0]))
                        {
                            dictionary.Add(array[0], array[1]);
                        }
                    }
                }
            }
            var orderedEnumerable = from pair in dictionary
                                    orderby pair.Key.Length descending, pair.Key
                                    select pair;
            luatNhanDictionary.Clear();
            foreach (var keyValuePair in orderedEnumerable)
            {
                luatNhanDictionary.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }

        static void LoadHanVietDictionaryWithNewThread(object stateInfo)
            => LoadHanVietDictionary();

        static void LoadHanVietDictionary()
        {
            hanVietDictionary.Clear();
            using (var textReader = new StreamReader(DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    var array = text.Split('=');
                    if (array.Length == 2 && !hanVietDictionary.ContainsKey(array[0]))
                    {
                        hanVietDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        static void LoadVietPhraseDictionary()
        {
            vietPhraseDictionary.Clear();
            foreach (var keyValuePair in onlyNameDictionary)
            {
                if (!vietPhraseDictionary.ContainsKey(keyValuePair.Key))
                {
                    vietPhraseDictionary.Add(keyValuePair.Key, keyValuePair.Value);
                }
            }
            foreach (var keyValuePair2 in onlyVietPhraseDictionary)
            {
                if (!vietPhraseDictionary.ContainsKey(keyValuePair2.Key))
                {
                    vietPhraseDictionary.Add(keyValuePair2.Key, keyValuePair2.Value);
                }
            }
        }

        static void LoadOnlyVietPhraseDictionaryWithNewThread(object stateInfo)
        {
            LoadOnlyVietPhraseDictionary();
            ((ManualResetEvent)stateInfo).Set();
        }

        static void LoadOnlyVietPhraseDictionary()
        {
            onlyVietPhraseDictionary.Clear();
            using (var textReader = new StreamReader(DictionaryConfigurationHelper.GetVietPhraseDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    var array = text.Split('=');
                    if (array.Length == 2 && !onlyVietPhraseDictionary.ContainsKey(array[0]))
                    {
                        onlyVietPhraseDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        static void LoadOnlyNameDictionaryWithNewThread(object stateInfo)
        {
            LoadOnlyNameDictionary();
            ((ManualResetEvent)stateInfo).Set();
        }

        static void LoadOnlyNameDictionary()
        {
            onlyNameDictionary.Clear();
            onlyNameOneMeaningDictionary.Clear();
            onlyNameChinhDictionary.Clear();
            onlyNamePhuDictionary.Clear();
            var separator = "/|".ToCharArray();
            using (var textReader = new StreamReader(DictionaryConfigurationHelper.GetNamesDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    var array = text.Split('=');
                    if (array.Length == 2 && !onlyNameDictionary.ContainsKey(array[0]))
                    {
                        onlyNameDictionary.Add(array[0], array[1]);
                        onlyNameOneMeaningDictionary.Add(array[0], array[1].Split(separator)[0]);
                        onlyNameChinhDictionary.Add(array[0], array[1]);
                    }
                }
            }
            using (var textReader2 = new StreamReader(DictionaryConfigurationHelper.GetNamesPhuDictionaryPath(), true))
            {
                string text2;
                while ((text2 = textReader2.ReadLine()) != null)
                {
                    var array2 = text2.Split('=');
                    if (array2.Length == 2 && !onlyNamePhuDictionary.ContainsKey(array2[0]))
                    {
                        if (onlyNameDictionary.ContainsKey(array2[0]))
                        {
                            onlyNameDictionary[array2[0]] = array2[1];
                            onlyNameOneMeaningDictionary[array2[0]] = array2[1].Split(separator)[0];
                        }
                        else
                        {
                            onlyNameDictionary.Add(array2[0], array2[1]);
                            onlyNameOneMeaningDictionary.Add(array2[0], array2[1].Split(separator)[0]);
                        }
                        onlyNamePhuDictionary.Add(array2[0], array2[1]);
                    }
                }
            }
        }

        static void VietPhraseDictionaryToVietPhraseOneMeaningDictionary()
        {
            vietPhraseOneMeaningDictionary.Clear();
            foreach (var keyValuePair in vietPhraseDictionary)
            {
                vietPhraseOneMeaningDictionary.Add(
                    keyValuePair.Key,
                    keyValuePair.Value.Contains("/") || keyValuePair.Value.Contains("|")
                        ? keyValuePair.Value.Split('/', '|')[0]
                        : keyValuePair.Value
                );
            }
        }

        static void PronounDictionaryToPronounOneMeaningDictionary()
        {
            pronounOneMeaningDictionary.Clear();
            foreach (var keyValuePair in pronounDictionary)
            {
                pronounOneMeaningDictionary.Add(
                    keyValuePair.Key,
                    keyValuePair.Value.Contains("/") || keyValuePair.Value.Contains("|")
                        ? keyValuePair.Value.Split('/', '|')[0]
                        : keyValuePair.Value
                );
            }
        }

        static void LoadNhanByDictionary()
        {
            if (DictionaryConfigurationHelper.IsNhanByPronouns)
            {
                nhanByDictionary = pronounDictionary;
                return;
            }
            if (DictionaryConfigurationHelper.IsNhanByPronounsAndNames)
            {
                nhanByDictionary = new Dictionary<string, string>(pronounDictionary);
                using (var enumerator = onlyNameDictionary.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        var keyValuePair = enumerator.Current;
                        if (!nhanByDictionary.ContainsKey(keyValuePair.Key))
                        {
                            nhanByDictionary.Add(keyValuePair.Key, keyValuePair.Value);
                        }
                    }
                    return;
                }
            }
            if (DictionaryConfigurationHelper.IsNhanByPronounsAndNamesAndVietPhrase)
            {
                nhanByDictionary = new Dictionary<string, string>(pronounDictionary);
                using (var enumerator2 = vietPhraseDictionary.GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        var keyValuePair2 = enumerator2.Current;
                        if (!nhanByDictionary.ContainsKey(keyValuePair2.Key))
                        {
                            nhanByDictionary.Add(keyValuePair2.Key, keyValuePair2.Value);
                        }
                    }
                    return;
                }
            }
            nhanByDictionary = null;
        }

        static void LoadNhanByOneMeaningDictionary()
        {
            if (DictionaryConfigurationHelper.IsNhanByPronouns)
            {
                nhanByOneMeaningDictionary = pronounOneMeaningDictionary;
                return;
            }
            if (DictionaryConfigurationHelper.IsNhanByPronounsAndNames)
            {
                nhanByOneMeaningDictionary = new Dictionary<string, string>(pronounOneMeaningDictionary);
                using (var enumerator = onlyNameOneMeaningDictionary.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        var keyValuePair = enumerator.Current;
                        if (!nhanByOneMeaningDictionary.ContainsKey(keyValuePair.Key))
                        {
                            nhanByOneMeaningDictionary.Add(keyValuePair.Key, keyValuePair.Value);
                        }
                    }
                    return;
                }
            }
            if (DictionaryConfigurationHelper.IsNhanByPronounsAndNamesAndVietPhrase)
            {
                nhanByOneMeaningDictionary = new Dictionary<string, string>(pronounOneMeaningDictionary);
                using (var enumerator2 = vietPhraseOneMeaningDictionary.GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        var keyValuePair2 = enumerator2.Current;
                        if (!nhanByOneMeaningDictionary.ContainsKey(keyValuePair2.Key))
                        {
                            nhanByOneMeaningDictionary.Add(keyValuePair2.Key, keyValuePair2.Value);
                        }
                    }
                    return;
                }
            }
            nhanByOneMeaningDictionary = null;
        }

        static void LoadThieuChuuDictionaryWithNewThread(object stateInfo)
            => LoadThieuChuuDictionary();

        static void LoadThieuChuuDictionary()
        {
            thieuChuuDictionary.Clear();
            using (var textReader = new StreamReader(DictionaryConfigurationHelper.GetThieuChuuDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    var array = text.Split('=');
                    if (array.Length == 2 && !thieuChuuDictionary.ContainsKey(array[0]))
                    {
                        thieuChuuDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        static void LoadLacVietDictionaryWithNewThread(object stateInfo)
            => LoadLacVietDictionary();

        static void LoadLacVietDictionary()
        {
            lacVietDictionary.Clear();
            using (var textReader = new StreamReader(DictionaryConfigurationHelper.GetLacVietDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    var array = text.Split('=');
                    if (array.Length == 2 && !lacVietDictionary.ContainsKey(array[0]))
                    {
                        lacVietDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        static void LoadCedictDictionaryWithNewThread(object stateInfo)
            => LoadCedictDictionary();

        static void LoadChinesePhienAmEnglishDictionaryWithNewThread(object stateInfo)
            => LoadChinesePhienAmEnglishDictionary();

        static void LoadPronounDictionaryWithNewThread(object stateInfo)
        {
            LoadPronounDictionary();
            ((ManualResetEvent)stateInfo).Set();
        }

        static void LoadIgnoredChinesePhraseListsWithNewThread(object stateInfo)
            => LoadIgnoredChinesePhraseLists();

        static void LoadOnlyVietPhraseDictionaryHistoryWithNewThread(object stateInfo)
            => LoadOnlyVietPhraseDictionaryHistory();

        static void LoadOnlyNameDictionaryHistoryWithNewThread(object stateInfo)
            => LoadOnlyNameDictionaryHistory();

        static void LoadOnlyNamePhuDictionaryHistoryWithNewThread(object stateInfo)
            => LoadOnlyNamePhuDictionaryHistory();

        static void LoadHanVietDictionaryHistoryWithNewThread(object stateInfo)
            => LoadHanVietDictionaryHistory();

        static void LoadOnlyVietPhraseDictionaryHistory()
        {
            LoadDictionaryHistory(DictionaryConfigurationHelper.GetVietPhraseDictionaryHistoryPath(), ref onlyVietPhraseDictionaryHistoryDataSet);
        }

        static void LoadOnlyNameDictionaryHistory()
        {
            LoadDictionaryHistory(DictionaryConfigurationHelper.GetNamesDictionaryHistoryPath(), ref onlyNameDictionaryHistoryDataSet);
        }

        static void LoadOnlyNamePhuDictionaryHistory()
        {
            LoadDictionaryHistory(DictionaryConfigurationHelper.GetNamesPhuDictionaryHistoryPath(), ref onlyNamePhuDictionaryHistoryDataSet);
        }

        static void LoadHanVietDictionaryHistory()
        {
            LoadDictionaryHistory(DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryHistoryPath(), ref hanVietDictionaryHistoryDataSet);
        }

        public static void LoadDictionaryHistory(string dictionaryHistoryPath, ref DataSet dictionaryHistoryDataSet)
        {
            dictionaryHistoryDataSet.Clear();
            var name = "DictionaryHistory";
            if (!dictionaryHistoryDataSet.Tables.Contains(name))
            {
                dictionaryHistoryDataSet.Tables.Add(name);
                dictionaryHistoryDataSet.Tables[name].Columns.Add("Entry", Type.GetType("System.String"));
                dictionaryHistoryDataSet.Tables[name].Columns.Add("Action", Type.GetType("System.String"));
                dictionaryHistoryDataSet.Tables[name].Columns.Add("User Name", Type.GetType("System.String"));
                dictionaryHistoryDataSet.Tables[name].Columns.Add("Updated Date", Type.GetType("System.DateTime"));
                dictionaryHistoryDataSet.Tables[name].PrimaryKey = new DataColumn[] {
                    dictionaryHistoryDataSet.Tables[name].Columns["Entry"]
                };
            }
            if (!File.Exists(dictionaryHistoryPath))
            {
                return;
            }
            var name2 = CharsetDetector.DetectChineseCharset(dictionaryHistoryPath);
            using (var textReader = new StreamReader(dictionaryHistoryPath, Encoding.GetEncoding(name2)))
            {
                textReader.ReadLine();
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    var array = text.Split('\t');
                    if (array.Length == 4)
                    {
                        var dataRow = dictionaryHistoryDataSet.Tables[name].Rows.Find(array[0]);
                        if (dataRow == null)
                        {
                            dictionaryHistoryDataSet.Tables[name].Rows.Add(new object[] {
                                array[0],
                                array[1],
                                array[2],
                                DateTime.ParseExact(array[3], "yyyy-MM-dd HH:mm:ss.fffzzz", null)
                            });
                        }
                        else
                        {
                            dataRow[1] = array[1];
                            dataRow[2] = array[2];
                            dataRow[3] = DateTime.ParseExact(array[3], "yyyy-MM-dd HH:mm:ss.fffzzz", null);
                        }
                    }
                }
            }
        }

        static void LoadCedictDictionary()
        {
            cedictDictionary.Clear();
            using (var textReader = new StreamReader(DictionaryConfigurationHelper.GetCEDictDictionaryPath(), Encoding.UTF8))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    if (!text.StartsWith("#"))
                    {
                        var text2 = text.Substring(0, text.IndexOf(" ["));
                        foreach (string key in text2.Split(' '))
                        {
                            if (!cedictDictionary.ContainsKey(key))
                            {
                                cedictDictionary.Add(key, text.Substring(text.IndexOf(" [")));
                            }
                        }
                    }
                }
            }
            using (var textReader2 = new StreamReader(DictionaryConfigurationHelper.GetBabylonDictionaryPath(), Encoding.UTF8))
            {
                string text3;
                while ((text3 = textReader2.ReadLine()) != null)
                {
                    var array2 = text3.Split('=');
                    if (!cedictDictionary.ContainsKey(array2[0]))
                    {
                        cedictDictionary.Add(array2[0], array2[1]);
                    }
                }
            }
        }

        static void LoadChinesePhienAmEnglishDictionary()
        {
            chinesePhienAmEnglishDictionary.Clear();
            using (var textReader = new StreamReader(DictionaryConfigurationHelper.GetChinesePhienAmEnglishWordsDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    var array = text.Split('=');
                    if (array.Length == 2 && !chinesePhienAmEnglishDictionary.ContainsKey(array[0]))
                    {
                        chinesePhienAmEnglishDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        static void LoadPronounDictionary()
        {
            pronounDictionary.Clear();
            using (var textReader = new StreamReader(DictionaryConfigurationHelper.GetPronounsDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    var array = text.Split('=');
                    if (array.Length == 2 && !pronounDictionary.ContainsKey(array[0]))
                    {
                        pronounDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        public static void AddIgnoredChinesePhrase(string ignoredChinesePhrase)
        {
            if (ignoredChinesePhraseList.Contains(ignoredChinesePhrase))
            {
                return;
            }
            ignoredChinesePhraseList.Add(ignoredChinesePhrase);
            try
            {
                File.WriteAllLines(DictionaryConfigurationHelper.GetIgnoredChinesePhraseListPath(), ignoredChinesePhraseList.ToArray(), Encoding.UTF8);
            }
            catch { }
            LoadIgnoredChinesePhraseLists();
        }

        static void LoadIgnoredChinesePhraseLists()
        {
            ignoredChinesePhraseList.Clear();
            ignoredChinesePhraseForBrowserList.Clear();
            var trimChars = "\t\n".ToCharArray();
            using (var textReader = new StreamReader(DictionaryConfigurationHelper.GetIgnoredChinesePhraseListPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(text))
                    {
                        var text2 = StandardizeInputWithoutRemovingIgnoredChinesePhrases(text).Trim(trimChars);
                        if (!string.IsNullOrEmpty(text2) && !ignoredChinesePhraseList.Contains(text2))
                        {
                            ignoredChinesePhraseList.Add(text2);
                        }
                        var text3 = StandardizeInputForBrowserWithoutRemovingIgnoredChinesePhrases(text).Trim(trimChars);
                        if (!string.IsNullOrEmpty(text3) && !ignoredChinesePhraseForBrowserList.Contains(text3))
                        {
                            ignoredChinesePhraseForBrowserList.Add(text3);
                        }
                    }
                }
            }
            ignoredChinesePhraseList.Sort(new Comparison<string>(CompareStringByDescending));
            ignoredChinesePhraseForBrowserList.Sort(new Comparison<string>(CompareStringByDescending));
        }

        static int CompareStringByDescending(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                return 1;
            }
            else
            {
                if (y == null)
                {
                    return -1;
                }
                int num = x.Length.CompareTo(y.Length);
                if (num != 0)
                {
                    return num * -1;
                }
                return x.CompareTo(y) * -1;
            }
        }

        public static string StandardizeInput(string original)
        {
            string standardizedChinese = StandardizeInputWithoutRemovingIgnoredChinesePhrases(original);
            return RemoveIgnoredChinesePhrases(standardizedChinese);
        }

        static string StandardizeInputWithoutRemovingIgnoredChinesePhrases(string original)
        {
            if (string.IsNullOrEmpty(original))
            {
                return "";
            }
            var text = ToSimplified(original);
            var array = new[] {
                "，",
                "。",
                "：",
                "“",
                "”",
                "‘",
                "’",
                "？",
                "！",
                "「",
                "」",
                "．",
                "、",
                "\u3000",
                "…",
                NULL_STRING
            };
            var array2 = new[] {
                ", ",
                ".",
                ": ",
                "\"",
                "\" ",
                "'",
                "' ",
                "?",
                "!",
                "\"",
                "\" ",
                ".",
                ", ",
                " ",
                "...",
                ""
            };
            for (int i = 0; i < array.Length; i++)
            {
                text = text.Replace(array[i], array2[i]);
            }
            text = text
                .Replace("  ", " ")
                .Replace(" \r\n", "\n")
                .Replace(" \n", "\n")
                .Replace(" ,", ",");
            text = ToNarrow(text);
            int length = text.Length;
            var stringBuilder = new StringBuilder();
            for (int j = 0; j < length - 1; j++)
            {
                var c = text[j];
                var c2 = text[j + 1];
                if (!char.IsControl(c) || c == '\t' || c == '\n' || c == '\r')
                {
                    if (IsChineseInternal(c))
                    {
                        if (!IsChineseInternal(c2)
                            && c2 != ','
                            && c2 != '.'
                            && c2 != ':'
                            && c2 != ';'
                            && c2 != '"'
                            && c2 != '\''
                            && c2 != '?'
                            && c2 != ' '
                            && c2 != '!'
                            && c2 != ')')
                        {
                            stringBuilder.Append(c).Append(" ");
                        }
                        else
                        {
                            stringBuilder.Append(c);
                        }
                    }
                    else if (c == '\t' || c == ' ' || c == '"' || c == '\'' || c == '\n' || c == '(')
                    {
                        stringBuilder.Append(c);
                    }
                    else if (c == '!' || c == '.' || c == '?')
                    {
                        if (c2 == '"' || c2 == ' ' || c2 == '\'')
                        {
                            stringBuilder.Append(c);
                        }
                        else
                        {
                            stringBuilder.Append(c).Append(" ");
                        }
                    }
                    else if (IsChineseInternal(c2))
                    {
                        stringBuilder.Append(c).Append(" ");
                    }
                    else
                    {
                        stringBuilder.Append(c);
                    }
                }
            }
            stringBuilder.Append(text[length - 1]);
            text = IndentAllLines(stringBuilder.ToString(), true);
            return text.Replace(". . . . . .", "...");
        }

        public static string StandardizeInputForBrowser(string original)
        {
            string standardizedChinese = StandardizeInputForBrowserWithoutRemovingIgnoredChinesePhrases(original);
            return RemoveIgnoredChinesePhrasesForBrowser(standardizedChinese);
        }

        static string StandardizeInputForBrowserWithoutRemovingIgnoredChinesePhrases(string original)
        {
            if (string.IsNullOrEmpty(original))
            {
                return "";
            }
            var text = ToSimplified(original);
            var array = new[] {
                "，",
                "。",
                "：",
                "“",
                "”",
                "‘",
                "’",
                "？",
                "！",
                "「",
                "」",
                "．",
                "、",
                "\u3000",
                "…",
                NULL_STRING
            };
            var array2 = new[] {
                ", ",
                ".",
                ": ",
                "\"",
                "\" ",
                "'",
                "' ",
                "?",
                "!",
                "\"",
                "\" ",
                ".",
                ", ",
                " ",
                "...",
                ""
            };
            for (int i = 0; i < array.Length; i++)
            {
                text = text.Replace(array[i], array2[i]);
            }
            text = text.Replace("  ", " ").Replace(" \r\n", "\n").Replace(" \n", "\n");
            text = ToNarrow(text);
            int length = text.Length;
            var stringBuilder = new StringBuilder();
            for (int j = 0; j < length - 1; j++)
            {
                char c = text[j];
                char c2 = text[j + 1];
                if (IsChineseInternal(c))
                {
                    if (!IsChineseInternal(c2)
                        && c2 != ','
                        && c2 != '.'
                        && c2 != ':'
                        && c2 != ';'
                        && c2 != '"'
                        && c2 != '\''
                        && c2 != '?'
                        && c2 != ' '
                        && c2 != '!')
                    {
                        stringBuilder.Append(c).Append(" ");
                    }
                    else
                    {
                        stringBuilder.Append(c);
                    }
                }
                else if (c == '\t' || c == ' ' || c == '"' || c == '\'' || c == '\n')
                {
                    stringBuilder.Append(c);
                }
                else if (IsChineseInternal(c2))
                {
                    stringBuilder.Append(c).Append(" ");
                }
                else
                {
                    stringBuilder.Append(c);
                }
            }
            stringBuilder.Append(text[length - 1]);
            return IndentAllLines(stringBuilder.ToString());
        }

        public static string StandardizeInputForProxy(string original)
        {
            return RemoveIgnoredChinesePhrasesForBrowser(
                StandardizeInputForProxyWithoutRemovingIgnoredChinesePhrases(original)
            );
        }

        static string StandardizeInputForProxyWithoutRemovingIgnoredChinesePhrases(string original)
        {
            if (string.IsNullOrEmpty(original))
            {
                return "";
            }
            var text = ToSimplified(original);
            var array = new[] {
                "，",
                "。",
                "：",
                "“",
                "”",
                "‘",
                "’",
                "？",
                "！",
                "「",
                "」",
                "．",
                "、",
                "\u3000",
                "…",
                NULL_STRING
            };
            var array2 = new[]
            {
                ", ",
                ".",
                ": ",
                "\"",
                "\" ",
                "'",
                "' ",
                "?",
                "!",
                "\"",
                "\" ",
                ".",
                ", ",
                " ",
                "...",
                ""
            };
            for (int i = 0; i < array.Length; i++)
            {
                text = text.Replace(array[i], array2[i]);
            }
            text = text.Replace("  ", " ").Replace(" \r\n", "\n").Replace(" \n", "\n");
            text = ToNarrow(text);
            int length = text.Length;
            var stringBuilder = new StringBuilder();
            for (int j = 0; j < length - 1; j++)
            {
                var c = text[j];
                var c2 = text[j + 1];
                if (IsChineseInternal(c))
                {
                    if (!IsChineseInternal(c2) && c2 != ','
                        && c2 != '.'
                        && c2 != ':'
                        && c2 != ';'
                        && c2 != '"'
                        && c2 != '\''
                        && c2 != '?'
                        && c2 != ' '
                        && c2 != '!')
                    {
                        stringBuilder.Append(c).Append(" ");
                    }
                    else
                    {
                        stringBuilder.Append(c);
                    }
                }
                else if (c == '\t' || c == ' ' || c == '"' || c == '\'' || c == '\n')
                {
                    stringBuilder.Append(c);
                }
                else if (IsChineseInternal(c2))
                {
                    stringBuilder.Append(c).Append(" ");
                }
                else
                {
                    stringBuilder.Append(c);
                }
            }
            stringBuilder.Append(text[length - 1]);
            return text;
        }

        static string IndentAllLines(string text, bool insertBlankLine)
        {
            var array = text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var stringBuilder = new StringBuilder();
            foreach (var text2 in array)
            {
                if (!string.IsNullOrEmpty(text2.Trim()))
                {
                    stringBuilder.Append("\t" + text2.Trim()).Append("\n").Append(insertBlankLine ? "\n" : "");
                }
            }
            return stringBuilder.ToString();
        }

        static string IndentAllLines(string text) => IndentAllLines(text, false);

        static bool IsChineseInternal(char character) => hanVietDictionary.ContainsKey(character.ToString());

        public static bool IsChinese(char character) => IsChineseInternal(character);

        public static bool IsAllChinese(string text)
        {
            foreach (var character in text)
            {
                if (!IsChineseInternal(character))
                {
                    return false;
                }
            }
            return true;
        }

        static bool HasOnlyOneMeaning(string meaning) => meaning.Split('/', '|').Length == 1;

        internal static string ToSimplified(string str) => Strings.StrConv(str, VbStrConv.SimplifiedChinese, 0);

        internal static string ToWide(string str)
        {
            int length = str.Length;
            int i;
            for (i = 0; i < length; i++)
            {
                char c = str[i];
                if (c >= '!' && c <= '~')
                {
                    break;
                }
            }
            if (i >= length)
            {
                return str;
            }
            var stringBuilder = new StringBuilder();
            for (i = 0; i < length; i++)
            {
                char c = str[i];
                if (c >= '!' && c <= '~')
                {
                    stringBuilder.Append(c - '!' + '！');
                }
                else
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString();
        }

        internal static string ToNarrow(string str)
        {
            int length = str.Length;
            int i;
            for (i = 0; i < length; i++)
            {
                char c = str[i];
                if (c >= '！' && c <= '～')
                {
                    break;
                }
            }
            if (i >= length)
            {
                return str;
            }
            var stringBuilder = new StringBuilder();
            for (i = 0; i < length; i++)
            {
                char c = str[i];
                if (c >= '！' && c <= '～')
                {
                    stringBuilder.Append(c - '！' + '!');
                }
                else
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString();
        }

        static void AppendTranslatedWord(StringBuilder result, string translatedText, ref string lastTranslatedWord)
        {
            int _ = 0;
            AppendTranslatedWord(result, translatedText, ref lastTranslatedWord, ref _);
        }

        static void AppendTranslatedWord(StringBuilder result, string translatedText,
            ref string lastTranslatedWord, ref int startIndexOfNextTranslatedText)
        {
            if (lastTranslatedWord.EndsWith("\n")
                || lastTranslatedWord.EndsWith("\t")
                || lastTranslatedWord.EndsWith(". ")
                || lastTranslatedWord.EndsWith("\"")
                || lastTranslatedWord.EndsWith("'")
                || lastTranslatedWord.EndsWith("? ")
                || lastTranslatedWord.EndsWith("! ")
                || lastTranslatedWord.EndsWith(".\" ")
                || lastTranslatedWord.EndsWith("?\" ")
                || lastTranslatedWord.EndsWith("!\" ")
                || lastTranslatedWord.EndsWith(": "))
            {
                lastTranslatedWord = ToUpperCase(translatedText);
            }
            else if (lastTranslatedWord.EndsWith(" ") || lastTranslatedWord.EndsWith("("))
            {
                lastTranslatedWord = translatedText;
            }
            else
            {
                lastTranslatedWord = " " + translatedText;
            }

            if ((string.IsNullOrEmpty(translatedText)
                || translatedText[0] == ','
                || translatedText[0] == '.'
                || translatedText[0] == '?'
                || translatedText[0] == '!')
                && 0 < result.Length && result[result.Length - 1] == ' ')
            {
                result = result.Remove(result.Length - 1, 1);
                startIndexOfNextTranslatedText--;
            }
            result.Append(lastTranslatedWord);
        }

        static string ToUpperCase(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }
            if (text.StartsWith("[") && 2 <= text.Length)
            {
                return "[" + char.ToUpper(text[1]) + ((text.Length <= 2) ? "" : text.Substring(2));
            }
            return char.ToUpper(text[0]) + ((text.Length <= 1) ? "" : text.Substring(1));
        }

        static bool NextCharIsChinese(string chinese, int currentPhraseEndIndex)
        {
            return chinese.Length - 1 > currentPhraseEndIndex && IsChineseInternal(chinese[currentPhraseEndIndex + 1]);
        }

        static string[] ClassifyWordsIntoLatinAndChinese(string inputText)
        {
            var list = new List<string>();
            var stringBuilder = new StringBuilder();
            var flag = false;
            foreach (var c in inputText)
            {
                if (IsChineseInternal(c))
                {
                    if (flag)
                    {
                        stringBuilder.Append(c);
                    }
                    else
                    {
                        list.Add(stringBuilder.ToString());
                        stringBuilder.Length = 0;
                        stringBuilder.Append(c);
                    }
                    flag = true;
                }
                else
                {
                    if (!flag)
                    {
                        stringBuilder.Append(c);
                    }
                    else
                    {
                        list.Add(stringBuilder.ToString());
                        stringBuilder.Length = 0;
                        stringBuilder.Append(c);
                    }
                    flag = false;
                }
            }
            list.Add(stringBuilder.ToString());
            return list.ToArray();
        }

        static string[] ClassifyWordsIntoLatinAndChineseForProxy(string inputText)
        {
            var list = new List<string>();
            var stringBuilder = new StringBuilder();
            bool flag = false;
            bool flag2 = false;
            foreach (char c in inputText)
            {
                if (flag2)
                {
                    stringBuilder.Append(c);
                    flag = false;
                    if (c == '>')
                    {
                        list.Add(stringBuilder.ToString());
                        stringBuilder.Length = 0;
                        flag2 = false;
                    }
                }
                else if (c == '<')
                {
                    list.Add(stringBuilder.ToString());
                    stringBuilder.Length = 0;
                    stringBuilder.Append(c);
                    flag2 = true;
                    flag = false;
                }
                else if (IsChineseInternal(c))
                {
                    if (flag)
                    {
                        stringBuilder.Append(c);
                    }
                    else
                    {
                        list.Add(stringBuilder.ToString());
                        stringBuilder.Length = 0;
                        stringBuilder.Append(c);
                    }
                    flag = true;
                }
                else
                {
                    if (!flag)
                    {
                        stringBuilder.Append(c);
                    }
                    else
                    {
                        list.Add(stringBuilder.ToString());
                        stringBuilder.Length = 0;
                        stringBuilder.Append(c);
                    }
                    flag = false;
                }
            }
            list.Add(stringBuilder.ToString());
            return list.ToArray();
        }

        public static bool IsInVietPhrase(string chinese) => vietPhraseDictionary.ContainsKey(chinese);

        public static string ChineseToHanVietForAnalyzer(string chinese)
        {
            var stringBuilder = new StringBuilder();
            foreach (char c in chinese)
            {
                if (hanVietDictionary.ContainsKey(c.ToString()))
                {
                    stringBuilder.Append(hanVietDictionary[c.ToString()] + " ");
                }
                else
                {
                    stringBuilder.Append(c + " ");
                }
            }
            return stringBuilder.ToString().Trim();
        }

        public static string ChineseToVietPhraseForAnalyzer(string chinese, int translationAlgorithm,
            bool prioritizedName)
        {
            return ChineseToVietPhraseForBrowser(chinese, 11, translationAlgorithm, prioritizedName)
                .Trim(trimCharsForAnalyzer);
        }

        static bool ContainsName(string chinese, int startIndex, int phraseLength)
        {
            if (phraseLength < 2)
            {
                return false;
            }
            if (onlyNameDictionary.ContainsKey(chinese.Substring(startIndex, phraseLength)))
            {
                return false;
            }
            int num = startIndex + phraseLength - 1;
            int num2 = 2;
            for (int i = startIndex + 1; i <= num; i++)
            {
                for (int j = 20; j >= num2; j--)
                {
                    if (chinese.Length >= i + j && onlyNameDictionary.ContainsKey(chinese.Substring(i, j)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool IsLongestPhraseInSentence(string chinese, int startIndex, int phraseLength,
            Dictionary<string, string> dictionary, int translationAlgorithm)
        {
            if (phraseLength < 2)
            {
                return true;
            }
            int num = (translationAlgorithm == 0) ? phraseLength : ((phraseLength < 3) ? 3 : phraseLength);
            int num2 = startIndex + phraseLength - 1;
            for (int i = startIndex + 1; i <= num2; i++)
            {
                for (int j = 20; j > num; j--)
                {
                    if (chinese.Length >= i + j && dictionary.ContainsKey(chinese.Substring(i, j)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int GetVietPhraseDictionaryCount() => onlyVietPhraseDictionary.Count;

        public static int GetNameDictionaryCount(bool isNameChinh)
            => isNameChinh ? onlyNameChinhDictionary.Count : onlyNamePhuDictionary.Count;

        public static int GetPhienAmDictionaryCount() => hanVietDictionary.Count;

        public static bool ExistInPhienAmDictionary(string chinese)
            => chinese.Length == 1 && hanVietDictionary.ContainsKey(chinese);

        static void UpdateHistoryLogInCache(string key, string action, ref DataSet dictionaryHistoryDataSet)
        {
            var dataRow = dictionaryHistoryDataSet.Tables["DictionaryHistory"].Rows.Find(key);
            if (dataRow == null)
            {
                dictionaryHistoryDataSet.Tables["DictionaryHistory"].Rows.Add(new object[] {
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

        static void WriteVietPhraseHistoryLog(string key, string action)
        {
            UpdateHistoryLogInCache(key, action, ref onlyVietPhraseDictionaryHistoryDataSet);
            WriteHistoryLog(key, action, DictionaryConfigurationHelper.GetVietPhraseDictionaryHistoryPath());
        }

        static void WriteNamesHistoryLog(string key, string action, bool isNameChinh)
        {
            DataSet dataSet = isNameChinh ? onlyNameDictionaryHistoryDataSet : onlyNamePhuDictionaryHistoryDataSet;
            UpdateHistoryLogInCache(key, action, ref dataSet);
            WriteHistoryLog(key, action, isNameChinh ? DictionaryConfigurationHelper.GetNamesDictionaryHistoryPath() : DictionaryConfigurationHelper.GetNamesPhuDictionaryHistoryPath());
        }

        static void WritePhienAmHistoryLog(string key, string action)
        {
            UpdateHistoryLogInCache(key, action, ref hanVietDictionaryHistoryDataSet);
            WriteHistoryLog(key, action, DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryHistoryPath());
        }

        public static string GetVietPhraseHistoryLogRecord(string key)
            => GetDictionaryHistoryLogRecordInCache(key, onlyVietPhraseDictionaryHistoryDataSet);

        public static string GetNameHistoryLogRecord(string key, bool isNameChinh)
        {
            return GetDictionaryHistoryLogRecordInCache(key, isNameChinh ? onlyNameDictionaryHistoryDataSet : onlyNamePhuDictionaryHistoryDataSet);
        }

        public static string GetPhienAmHistoryLogRecord(string key)
            => GetDictionaryHistoryLogRecordInCache(key, hanVietDictionaryHistoryDataSet);

        static string GetDictionaryHistoryLogRecordInCache(string key, DataSet dictionaryHistoryDataSet)
        {
            var dataRow = dictionaryHistoryDataSet.Tables["DictionaryHistory"].Rows.Find(key);
            if (dataRow == null)
            {
                return "";
            }
            return $"Entry này đã được <{dataRow[1]}> " +
                $"bởi <{dataRow[2]}> vào <{(DateTime)dataRow[3]:yyyy-MM-dd HH:mm:ss.fffzzz}>.";
        }

        public static void CompressPhienAmDictionaryHistory()
        {
            CompressDictionaryHistory(hanVietDictionaryHistoryDataSet, DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryHistoryPath());
        }

        public static void CompressOnlyVietPhraseDictionaryHistory()
        {
            CompressDictionaryHistory(onlyVietPhraseDictionaryHistoryDataSet, DictionaryConfigurationHelper.GetVietPhraseDictionaryHistoryPath());
        }

        public static void CompressOnlyNameDictionaryHistory(bool isNameChinh)
        {
            CompressDictionaryHistory(
                isNameChinh ? onlyNameDictionaryHistoryDataSet : onlyNamePhuDictionaryHistoryDataSet,
                isNameChinh
                    ? DictionaryConfigurationHelper.GetNamesDictionaryHistoryPath()
                    : DictionaryConfigurationHelper.GetNamesPhuDictionaryHistoryPath()
            );
        }

        static void CompressDictionaryHistory(DataSet dictionaryHistoryDataSet, string dictionaryHistoryFilePath)
        {
            var text = dictionaryHistoryFilePath + "." + DateTime.Now.Ticks;
            Helper.CopyIfSourceExists(dictionaryHistoryFilePath, text, true);
            using (var textWriter = new StreamWriter(dictionaryHistoryFilePath, false, Encoding.UTF8))
            {
                try
                {
                    textWriter.WriteLine("Entry\tAction\tUser Name\tUpdated Date");
                    var dataTable = dictionaryHistoryDataSet.Tables["DictionaryHistory"];
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        textWriter.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", new[] {
                            dataRow[0],
                            dataRow[1],
                            dataRow[2],
                            ((DateTime)dataRow[3]).ToString("yyyy-MM-dd HH:mm:ss.fffzzz")
                        }));
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        textWriter.Close();
                    }
                    catch { }

                    if (File.Exists(dictionaryHistoryFilePath))
                    {
                        try
                        {
                            File.Copy(text, dictionaryHistoryFilePath, true);
                        }
                        catch { }
                    }
                    throw ex;
                }
                finally
                {
                    File.Delete(text);
                }
            }
        }

        public static void WriteHistoryLog(string key, string action, string logPath)
        {
            if (!File.Exists(logPath))
            {
                File.AppendAllText(logPath, "Entry\tAction\tUser Name\tUpdated Date\r\n", Encoding.UTF8);
            }
            File.AppendAllText(logPath, string.Concat(new[] {
                key,
                "\t",
                action,
                "\t",
                Environment.GetEnvironmentVariable("USERNAME"),
                "\t",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffzzz"),
                "\r\n"
            }), Encoding.UTF8);
        }

        public static void CreateHistoryLog(string key, string action, ref StringBuilder historyLogs)
        {
            historyLogs.AppendLine(string.Concat(new[] {
                key,
                "\t",
                action,
                "\t",
                Environment.GetEnvironmentVariable("USERNAME"),
                "\t",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffzzz")
            }));
        }

        public static void WriteHistoryLog(string historyLogs, string logPath)
        {
            if (!File.Exists(logPath))
            {
                File.AppendAllText(logPath, "Entry\tAction\tUser Name\tUpdated Date\r\n", Encoding.UTF8);
            }
            File.AppendAllText(logPath, historyLogs, Encoding.UTF8);
        }

        static string RemoveIgnoredChinesePhrases(string standardizedChinese)
        {
            if (string.IsNullOrEmpty(standardizedChinese))
            {
                return "";
            }
            var text = standardizedChinese;
            foreach (var oldValue in ignoredChinesePhraseList)
            {
                text = text.Replace(oldValue, "");
            }
            return text.Replace("\t\n\n", "");
        }

        static string RemoveIgnoredChinesePhrasesForBrowser(string standardizedChinese)
        {
            if (string.IsNullOrEmpty(standardizedChinese))
            {
                return "";
            }
            var text = standardizedChinese;
            foreach (var oldValue in ignoredChinesePhraseForBrowserList)
            {
                text = text.Replace(oldValue, "");
            }
            return text.Replace("\t\n\n", "");
        }

        static int ContainsLuatNhan(string chinese, Dictionary<string, string> dictionary)
            => ContainsLuatNhan(chinese, dictionary, out _, out _);

        static int ContainsLuatNhan(string chinese, Dictionary<string, string> dictionary,
            out string luatNhan, out int matchedLength)
        {
            int length = chinese.Length;
            foreach (var keyValuePair in luatNhanDictionary)
            {
                if (length >= keyValuePair.Key.Length - 2)
                {
                    var text = keyValuePair.Key.Replace("{0}", "([^,\\. ?]{1,10})");
                    var match = Regex.Match(chinese, text);
                    int num = 0;
                    while (match.Success)
                    {
                        var value = match.Groups[1].Value;
                        if (keyValuePair.Key.StartsWith("{0}"))
                        {
                            for (int i = 0; i < value.Length; i++)
                            {
                                if (dictionary.ContainsKey(value.Substring(i)))
                                {
                                    luatNhan = text;
                                    matchedLength = match.Length - i;
                                    return match.Index + i;
                                }
                            }
                        }
                        else if (keyValuePair.Key.EndsWith("{0}"))
                        {
                            int num2 = value.Length;
                            while (0 < num2)
                            {
                                if (dictionary.ContainsKey(value.Substring(0, num2)))
                                {
                                    luatNhan = text;
                                    matchedLength = match.Length - (value.Length - num2);
                                    return match.Index;
                                }
                                num2--;
                            }
                        }
                        else if (dictionary.ContainsKey(value))
                        {
                            luatNhan = text;
                            matchedLength = match.Length;
                            return match.Index;
                        }
                        match = match.NextMatch();
                        num++;
                        if (num > 1)
                        {
                            break;
                        }
                    }
                }
            }
            luatNhan = "";
            matchedLength = -1;
            return -1;
        }

        static bool MatchesLuatNhan(string chinese, Dictionary<string, string> dictionary)
        {
            foreach (var keyValuePair in luatNhanDictionary)
            {
                var str = keyValuePair.Key.Replace("{0}", "(.+)");
                var match = Regex.Match(chinese, "^" + str + "$");
                if (match.Success && dictionary.ContainsKey(match.Groups[1].Value))
                {
                    return true;
                }
            }
            return false;
        }

        public static string ChineseToLuatNhan(string chinese, Dictionary<string, string> dictionary)
            => ChineseToLuatNhan(chinese, dictionary, out _);

        public static string ChineseToLuatNhan(string chinese, Dictionary<string, string> dictionary, out string luatNhan)
        {
            foreach (var keyValuePair in luatNhanDictionary)
            {
                var str = keyValuePair.Key.Replace("{0}", "(.+)");
                var match = Regex.Match(chinese, "^" + str + "$");
                if (match.Success && dictionary.ContainsKey(match.Groups[1].Value))
                {
                    string[] array = dictionary[match.Groups[1].Value].Split('/', '|');
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (string newValue in array)
                    {
                        stringBuilder.Append(keyValuePair.Value.Replace("{0}", newValue));
                        stringBuilder.Append("/");
                    }
                    luatNhan = keyValuePair.Key;
                    return stringBuilder.ToString().Trim('/');
                }
            }
            throw new NotImplementedException("Lỗi xử lý luật nhân cho cụm từ: " + chinese);
        }

        public const int CHINESE_LOOKUP_MAX_LENGTH = 20;

        static Dictionary<string, string> hanVietDictionary = new Dictionary<string, string>();

        static readonly Dictionary<string, string> vietPhraseDictionary = new Dictionary<string, string>();

        static readonly Dictionary<string, string> thieuChuuDictionary = new Dictionary<string, string>();

        static readonly Dictionary<string, string> lacVietDictionary = new Dictionary<string, string>();

        static readonly Dictionary<string, string> cedictDictionary = new Dictionary<string, string>();

        static readonly Dictionary<string, string> chinesePhienAmEnglishDictionary = new Dictionary<string, string>();

        static readonly Dictionary<string, string> vietPhraseOneMeaningDictionary = new Dictionary<string, string>();

        static Dictionary<string, string> onlyVietPhraseDictionary = new Dictionary<string, string>();

        static Dictionary<string, string> onlyNameDictionary = new Dictionary<string, string>();

        static Dictionary<string, string> onlyNameOneMeaningDictionary = new Dictionary<string, string>();

        static Dictionary<string, string> onlyNameChinhDictionary = new Dictionary<string, string>();

        static Dictionary<string, string> onlyNamePhuDictionary = new Dictionary<string, string>();

        static readonly Dictionary<string, string> luatNhanDictionary = new Dictionary<string, string>();

        static readonly Dictionary<string, string> pronounDictionary = new Dictionary<string, string>();

        static readonly Dictionary<string, string> pronounOneMeaningDictionary = new Dictionary<string, string>();

        static Dictionary<string, string> nhanByDictionary = null;

        static Dictionary<string, string> nhanByOneMeaningDictionary = null;

        static DataSet onlyVietPhraseDictionaryHistoryDataSet = new DataSet();

        static DataSet onlyNameDictionaryHistoryDataSet = new DataSet();

        static DataSet onlyNamePhuDictionaryHistoryDataSet = new DataSet();

        static DataSet hanVietDictionaryHistoryDataSet = new DataSet();

        static readonly List<string> ignoredChinesePhraseList = new List<string>();

        static readonly List<string> ignoredChinesePhraseForBrowserList = new List<string>();

        static readonly object lockObject = new object();

        static readonly string NULL_STRING = "\0";

        public static string LastTranslatedWord_HanViet = "";

        public static string LastTranslatedWord_VietPhrase = "";

        public static string LastTranslatedWord_VietPhraseOneMeaning = "";

        static readonly char[] trimCharsForAnalyzer = new[] { ' ', '\n', '\t', };
    }
}

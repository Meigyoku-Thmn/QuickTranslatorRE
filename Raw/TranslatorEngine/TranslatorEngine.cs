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
            if (vietPhraseDictionary.ContainsKey(key))
            {
                vietPhraseDictionary[key] = value;
            }
            else
            {
                vietPhraseDictionary.Add(key, value);
            }
            if (vietPhraseOneMeaningDictionary.ContainsKey(key))
            {
                vietPhraseOneMeaningDictionary[key] = value.Split(new char[]
                {
                    '/',
                    '|'
                })[0];
            }
            else
            {
                vietPhraseOneMeaningDictionary.Add(key, value.Split(new char[]
                {
                    '/',
                    '|'
                })[0]);
            }
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

        // Token: 0x060000E8 RID: 232 RVA: 0x00006AEC File Offset: 0x00005AEC
        private static Dictionary<string, string> AddEntryToDictionaryWithoutSorting(Dictionary<string, string> dictionary, string key, string value)
        {
            Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                dictionary2.Add(keyValuePair.Key, keyValuePair.Value);
            }
            dictionary2.Add(key, value);
            return dictionary2;
        }

        // Token: 0x060000E9 RID: 233 RVA: 0x00006B58 File Offset: 0x00005B58
        public static void UpdateNameDictionary(string key, string value, bool sorting, bool isNameChinh)
        {
            if (vietPhraseDictionary.ContainsKey(key))
            {
                vietPhraseDictionary[key] = value;
            }
            else
            {
                vietPhraseDictionary.Add(key, value);
            }
            if (vietPhraseOneMeaningDictionary.ContainsKey(key))
            {
                vietPhraseOneMeaningDictionary[key] = value.Split(new char[]
                {
                    '/',
                    '|'
                })[0];
            }
            else
            {
                vietPhraseOneMeaningDictionary.Add(key, value.Split(new char[]
                {
                    '/',
                    '|'
                })[0]);
            }
            Dictionary<string, string> dictionary = isNameChinh ? onlyNameChinhDictionary : onlyNamePhuDictionary;
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
                WriteNamesHistoryLog(key, "Updated", isNameChinh);
            }
            else
            {
                if (sorting)
                {
                    dictionary.Add(key, value);
                }
                else if (isNameChinh)
                {
                    onlyNameChinhDictionary = AddEntryToDictionaryWithoutSorting(onlyNameChinhDictionary, key, value);
                    dictionary = onlyNameChinhDictionary;
                }
                else
                {
                    onlyNamePhuDictionary = AddEntryToDictionaryWithoutSorting(onlyNamePhuDictionary, key, value);
                    dictionary = onlyNamePhuDictionary;
                }
                WriteNamesHistoryLog(key, "Added", isNameChinh);
            }
            if (onlyNameDictionary.ContainsKey(key))
            {
                onlyNameDictionary[key] = value;
                onlyNameOneMeaningDictionary[key] = value.Split(new char[]
                {
                    '/',
                    '|'
                })[0];
            }
            else if (sorting)
            {
                onlyNameDictionary.Add(key, value);
                onlyNameOneMeaningDictionary.Add(key, value.Split(new char[]
                {
                    '/',
                    '|'
                })[0]);
            }
            else
            {
                onlyNameDictionary = AddEntryToDictionaryWithoutSorting(onlyNameDictionary, key, value);
                onlyNameOneMeaningDictionary = AddEntryToDictionaryWithoutSorting(onlyNameOneMeaningDictionary, key, value.Split(new char[]
                {
                    '/',
                    '|'
                })[0]);
            }
            if (sorting)
            {
                SaveDictionaryToFile(ref dictionary, isNameChinh ? DictionaryConfigurationHelper.GetNamesDictionaryPath() : DictionaryConfigurationHelper.GetNamesPhuDictionaryPath());
                return;
            }
            SaveDictionaryToFileWithoutSorting(dictionary, isNameChinh ? DictionaryConfigurationHelper.GetNamesDictionaryPath() : DictionaryConfigurationHelper.GetNamesPhuDictionaryPath());
        }

        // Token: 0x060000EA RID: 234 RVA: 0x00006D48 File Offset: 0x00005D48
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

        // Token: 0x060000EB RID: 235 RVA: 0x00006DCC File Offset: 0x00005DCC
        public static void SaveDictionaryToFileWithoutSorting(Dictionary<string, string> dictionary, string filePath)
        {
            string text = filePath + "." + DateTime.Now.Ticks;
            if (File.Exists(filePath))
            {
                File.Copy(filePath, text, true);
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                stringBuilder.Append(keyValuePair.Key).Append("=").AppendLine(keyValuePair.Value);
            }
            try
            {
                File.WriteAllText(filePath, stringBuilder.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                try
                {
                    File.Copy(text, filePath, true);
                }
                catch
                {
                }
                throw ex;
            }
            if (File.Exists(filePath))
            {
                File.Delete(text);
            }
        }

        // Token: 0x060000EC RID: 236 RVA: 0x00006ED0 File Offset: 0x00005ED0
        public static void SaveDictionaryToFile(ref Dictionary<string, string> dictionary, string filePath)
        {
            IOrderedEnumerable<KeyValuePair<string, string>> orderedEnumerable = from pair in dictionary
                                                                                 orderby pair.Key.Length descending, pair.Key
                                                                                 select pair;
            Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
            string text = filePath + "." + DateTime.Now.Ticks;
            if (File.Exists(filePath))
            {
                File.Copy(filePath, text, true);
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, string> keyValuePair in orderedEnumerable)
            {
                stringBuilder.Append(keyValuePair.Key).Append("=").AppendLine(keyValuePair.Value);
                dictionary2.Add(keyValuePair.Key, keyValuePair.Value);
            }
            dictionary = dictionary2;
            try
            {
                File.WriteAllText(filePath, stringBuilder.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                try
                {
                    File.Copy(text, filePath, true);
                }
                catch
                {
                }
                throw ex;
            }
            if (File.Exists(filePath))
            {
                File.Delete(text);
            }
        }

        // Token: 0x060000ED RID: 237 RVA: 0x00007020 File Offset: 0x00006020
        public static string ChineseToHanViet(string chinese, out CharRange[] chineseHanVietMappingArray)
        {
            LastTranslatedWord_HanViet = "";
            List<CharRange> list = new List<CharRange>();
            StringBuilder stringBuilder = new StringBuilder();
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

        // Token: 0x060000EE RID: 238 RVA: 0x000071F8 File Offset: 0x000061F8
        public static string ChineseToHanVietForBrowser(string chinese)
        {
            if (string.IsNullOrEmpty(chinese))
                return "";
            chinese = StandardizeInputForBrowser(chinese);
            StringBuilder stringBuilder = new StringBuilder();
            string[] array = ClassifyWordsIntoLatinAndChinese(chinese);
            int num = array.Length;
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

        // Token: 0x060000EF RID: 239 RVA: 0x000072A4 File Offset: 0x000062A4
        public static string ChineseToHanVietForBatch(string chinese)
        {
            string str = "";
            StringBuilder stringBuilder = new StringBuilder();
            int length = chinese.Length;
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

        // Token: 0x060000F0 RID: 240 RVA: 0x000073A5 File Offset: 0x000063A5
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

        // Token: 0x060000F1 RID: 241 RVA: 0x000073E4 File Offset: 0x000063E4
        public static string ChineseToVietPhrase(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName, out CharRange[] chinesePhraseRanges, out CharRange[] vietPhraseRanges)
        {
            LastTranslatedWord_VietPhrase = "";
            List<CharRange> list = new List<CharRange>();
            List<CharRange> list2 = new List<CharRange>();
            StringBuilder stringBuilder = new StringBuilder();
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

        // Token: 0x060000F2 RID: 242 RVA: 0x00007BEC File Offset: 0x00006BEC
        public static string ChineseToVietPhraseForBrowser(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName)
        {
            chinese = StandardizeInputForBrowser(chinese);
            StringBuilder stringBuilder = new StringBuilder();
            string[] array = ClassifyWordsIntoLatinAndChinese(chinese);
            foreach (string text in array)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    if (IsChineseInternal(text[0]))
                    {
                        stringBuilder.Append(ChineseToVietPhrase(text, wrapType, translationAlgorithm, prioritizedName, out _, out _));
                    }
                    else
                    {
                        stringBuilder.Append(text);
                    }
                }
            }
            return stringBuilder.ToString();
        }

        // Token: 0x060000F3 RID: 243 RVA: 0x00007C6C File Offset: 0x00006C6C
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

        // Token: 0x060000F4 RID: 244 RVA: 0x000081A4 File Offset: 0x000071A4
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

        // Token: 0x060000F5 RID: 245 RVA: 0x00008804 File Offset: 0x00007804
        public static string ChineseToVietPhraseOneMeaningForBrowser(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName)
        {
            chinese = StandardizeInputForBrowser(chinese);
            StringBuilder stringBuilder = new StringBuilder();
            string[] array = ClassifyWordsIntoLatinAndChinese(chinese);
            int num = array.Length;
            for (int i = 0; i < num; i++)
            {
                string text = array[i];
                if (!string.IsNullOrEmpty(text))
                {
                    string text2;
                    if (IsChineseInternal(text[0]))
                    {
                        text2 = ChineseToVietPhraseOneMeaning(text, wrapType, translationAlgorithm, prioritizedName, out _, out _).TrimStart(new char[0]);
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

        // Token: 0x060000F6 RID: 246 RVA: 0x000088AC File Offset: 0x000078AC
        public static string ChineseToVietPhraseOneMeaningForProxy(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName)
        {
            chinese = StandardizeInputForProxy(chinese);
            StringBuilder stringBuilder = new StringBuilder();
            string[] array = ClassifyWordsIntoLatinAndChineseForProxy(chinese);
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

        // Token: 0x060000F7 RID: 247 RVA: 0x0000892C File Offset: 0x0000792C
        public static string ChineseToVietPhraseOneMeaningForBatch(string chinese, int wrapType, int translationAlgorithm, bool prioritizedName)
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

        // Token: 0x060000F8 RID: 248 RVA: 0x00008DCC File Offset: 0x00007DCC
        public static string ChineseToNameForBatch(string chinese)
        {
            StringBuilder stringBuilder = new StringBuilder();
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

        // Token: 0x060000F9 RID: 249 RVA: 0x00008E70 File Offset: 0x00007E70
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
                if (chinese.Length >= i && !chinese.Substring(0, i).Contains("\n") && !chinese.Substring(0, i).Contains("\t"))
                {
                    if (ContainsLuatNhan(chinese.Substring(0, i), vietPhraseDictionary) != 0)
                    {
                        break;
                    }
                    if (MatchesLuatNhan(chinese.Substring(0, i), vietPhraseDictionary))
                    {
                        ChineseToLuatNhan(chinese.Substring(0, i), vietPhraseDictionary, out string empty);
                        string text2 = text;
                        text = string.Concat(new string[] {
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
                    string text3 = chinese.Substring(0, j);
                    if (vietPhraseDictionary.ContainsKey(text3))
                    {
                        string text4 = text;
                        text = string.Concat(new string[]
                        {
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
                    string text3 = chinese.Substring(0, k);
                    if (lacVietDictionary.ContainsKey(text3))
                    {
                        string text5 = text;
                        text = string.Concat(new string[]
                        {
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
                        string text6 = text;
                        text = string.Concat(new string[]
                        {
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
                object obj = text;
                text = string.Concat(new object[]
                {
                    obj,
                    chinese[0],
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

        // Token: 0x060000FA RID: 250 RVA: 0x0000926C File Offset: 0x0000826C
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
                    ManualResetEvent[] array = new ManualResetEvent[]
                    {
                        new ManualResetEvent(false)
                    };
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadLuatNhanDictionaryWithNewThread), array[0]);
                    ManualResetEvent[] array2 = new ManualResetEvent[]
                    {
                        new ManualResetEvent(false)
                    };
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadPronounDictionaryWithNewThread), array2[0]);
                    ManualResetEvent[] array3 = new ManualResetEvent[]
                    {
                        new ManualResetEvent(false)
                    };
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadOnlyVietPhraseDictionaryWithNewThread), array3[0]);
                    ManualResetEvent[] array4 = new ManualResetEvent[]
                    {
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

        // Token: 0x060000FB RID: 251 RVA: 0x0000943C File Offset: 0x0000843C
        private static void LoadLuatNhanDictionaryWithNewThread(object stateInfo)
        {
            LoadLuatNhanDictionary();
            ((ManualResetEvent)stateInfo).Set();
        }

        // Token: 0x060000FC RID: 252 RVA: 0x00009468 File Offset: 0x00008468
        private static void LoadLuatNhanDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            using (TextReader textReader = new StreamReader(DictionaryConfigurationHelper.GetLuatNhanDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    if (!text.StartsWith("#"))
                    {
                        string[] array = text.Split(new char[]
                        {
                            '='
                        });
                        if (array.Length == 2 && !dictionary.ContainsKey(array[0]))
                        {
                            dictionary.Add(array[0], array[1]);
                        }
                    }
                }
            }
            IOrderedEnumerable<KeyValuePair<string, string>> orderedEnumerable =
                from pair in dictionary
                orderby pair.Key.Length descending, pair.Key
                select pair;
            luatNhanDictionary.Clear();
            foreach (KeyValuePair<string, string> keyValuePair in orderedEnumerable)
            {
                luatNhanDictionary.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }

        // Token: 0x060000FE RID: 254 RVA: 0x0000962C File Offset: 0x0000862C
        private static void LoadHanVietDictionaryWithNewThread(object stateInfo)
        {
            LoadHanVietDictionary();
        }

        // Token: 0x060000FF RID: 255 RVA: 0x00009634 File Offset: 0x00008634
        private static void LoadHanVietDictionary()
        {
            hanVietDictionary.Clear();
            using (TextReader textReader = new StreamReader(DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    string[] array = text.Split(new char[]
                    {
                        '='
                    });
                    if (array.Length == 2 && !hanVietDictionary.ContainsKey(array[0]))
                    {
                        hanVietDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        // Token: 0x06000100 RID: 256 RVA: 0x000096B8 File Offset: 0x000086B8
        private static void LoadVietPhraseDictionary()
        {
            vietPhraseDictionary.Clear();
            foreach (KeyValuePair<string, string> keyValuePair in onlyNameDictionary)
            {
                if (!vietPhraseDictionary.ContainsKey(keyValuePair.Key))
                {
                    vietPhraseDictionary.Add(keyValuePair.Key, keyValuePair.Value);
                }
            }
            foreach (KeyValuePair<string, string> keyValuePair2 in onlyVietPhraseDictionary)
            {
                if (!vietPhraseDictionary.ContainsKey(keyValuePair2.Key))
                {
                    vietPhraseDictionary.Add(keyValuePair2.Key, keyValuePair2.Value);
                }
            }
        }

        // Token: 0x06000101 RID: 257 RVA: 0x000097A0 File Offset: 0x000087A0
        private static void LoadOnlyVietPhraseDictionaryWithNewThread(object stateInfo)
        {
            LoadOnlyVietPhraseDictionary();
            ((ManualResetEvent)stateInfo).Set();
        }

        // Token: 0x06000102 RID: 258 RVA: 0x000097B4 File Offset: 0x000087B4
        private static void LoadOnlyVietPhraseDictionary()
        {
            onlyVietPhraseDictionary.Clear();
            using (TextReader textReader = new StreamReader(DictionaryConfigurationHelper.GetVietPhraseDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    string[] array = text.Split(new char[] {
                        '='
                    });
                    if (array.Length == 2 && !onlyVietPhraseDictionary.ContainsKey(array[0]))
                    {
                        onlyVietPhraseDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        // Token: 0x06000103 RID: 259 RVA: 0x00009838 File Offset: 0x00008838
        private static void LoadOnlyNameDictionaryWithNewThread(object stateInfo)
        {
            LoadOnlyNameDictionary();
            ((ManualResetEvent)stateInfo).Set();
        }

        // Token: 0x06000104 RID: 260 RVA: 0x0000984C File Offset: 0x0000884C
        private static void LoadOnlyNameDictionary()
        {
            onlyNameDictionary.Clear();
            onlyNameOneMeaningDictionary.Clear();
            onlyNameChinhDictionary.Clear();
            onlyNamePhuDictionary.Clear();
            char[] separator = "/|".ToCharArray();
            using (TextReader textReader = new StreamReader(DictionaryConfigurationHelper.GetNamesDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    string[] array = text.Split(new char[]
                    {
                        '='
                    });
                    if (array.Length == 2 && !onlyNameDictionary.ContainsKey(array[0]))
                    {
                        onlyNameDictionary.Add(array[0], array[1]);
                        onlyNameOneMeaningDictionary.Add(array[0], array[1].Split(separator)[0]);
                        onlyNameChinhDictionary.Add(array[0], array[1]);
                    }
                }
            }
            using (TextReader textReader2 = new StreamReader(DictionaryConfigurationHelper.GetNamesPhuDictionaryPath(), true))
            {
                string text2;
                while ((text2 = textReader2.ReadLine()) != null)
                {
                    string[] array2 = text2.Split(new char[]
                    {
                        '='
                    });
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

        // Token: 0x06000105 RID: 261 RVA: 0x00009A10 File Offset: 0x00008A10
        private static void VietPhraseDictionaryToVietPhraseOneMeaningDictionary()
        {
            vietPhraseOneMeaningDictionary.Clear();
            foreach (KeyValuePair<string, string> keyValuePair in vietPhraseDictionary)
            {
                vietPhraseOneMeaningDictionary.Add(keyValuePair.Key, (keyValuePair.Value.Contains("/") || keyValuePair.Value.Contains("|")) ? keyValuePair.Value.Split(new char[]
                {
                    '/',
                    '|'
                })[0] : keyValuePair.Value);
            }
        }

        // Token: 0x06000106 RID: 262 RVA: 0x00009AC8 File Offset: 0x00008AC8
        private static void PronounDictionaryToPronounOneMeaningDictionary()
        {
            pronounOneMeaningDictionary.Clear();
            foreach (KeyValuePair<string, string> keyValuePair in pronounDictionary)
            {
                pronounOneMeaningDictionary.Add(keyValuePair.Key, (keyValuePair.Value.Contains("/") || keyValuePair.Value.Contains("|")) ? keyValuePair.Value.Split(new char[]
                {
                    '/',
                    '|'
                })[0] : keyValuePair.Value);
            }
        }

        // Token: 0x06000107 RID: 263 RVA: 0x00009B80 File Offset: 0x00008B80
        private static void LoadNhanByDictionary()
        {
            if (DictionaryConfigurationHelper.IsNhanByPronouns)
            {
                nhanByDictionary = pronounDictionary;
                return;
            }
            if (DictionaryConfigurationHelper.IsNhanByPronounsAndNames)
            {
                nhanByDictionary = new Dictionary<string, string>(pronounDictionary);
                using (Dictionary<string, string>.Enumerator enumerator = onlyNameDictionary.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        KeyValuePair<string, string> keyValuePair = enumerator.Current;
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
                using (Dictionary<string, string>.Enumerator enumerator2 = vietPhraseDictionary.GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        KeyValuePair<string, string> keyValuePair2 = enumerator2.Current;
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

        // Token: 0x06000108 RID: 264 RVA: 0x00009CA4 File Offset: 0x00008CA4
        private static void LoadNhanByOneMeaningDictionary()
        {
            if (DictionaryConfigurationHelper.IsNhanByPronouns)
            {
                nhanByOneMeaningDictionary = pronounOneMeaningDictionary;
                return;
            }
            if (DictionaryConfigurationHelper.IsNhanByPronounsAndNames)
            {
                nhanByOneMeaningDictionary = new Dictionary<string, string>(pronounOneMeaningDictionary);
                using (Dictionary<string, string>.Enumerator enumerator = onlyNameOneMeaningDictionary.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        KeyValuePair<string, string> keyValuePair = enumerator.Current;
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
                using (Dictionary<string, string>.Enumerator enumerator2 = vietPhraseOneMeaningDictionary.GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        KeyValuePair<string, string> keyValuePair2 = enumerator2.Current;
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

        // Token: 0x06000109 RID: 265 RVA: 0x00009DC8 File Offset: 0x00008DC8
        private static void LoadThieuChuuDictionaryWithNewThread(object stateInfo)
        {
            LoadThieuChuuDictionary();
        }

        // Token: 0x0600010A RID: 266 RVA: 0x00009DD0 File Offset: 0x00008DD0
        private static void LoadThieuChuuDictionary()
        {
            thieuChuuDictionary.Clear();
            using (TextReader textReader = new StreamReader(DictionaryConfigurationHelper.GetThieuChuuDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    string[] array = text.Split(new char[]
                    {
                        '='
                    });
                    if (array.Length == 2 && !thieuChuuDictionary.ContainsKey(array[0]))
                    {
                        thieuChuuDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        // Token: 0x0600010B RID: 267 RVA: 0x00009E54 File Offset: 0x00008E54
        private static void LoadLacVietDictionaryWithNewThread(object stateInfo)
        {
            LoadLacVietDictionary();
        }

        // Token: 0x0600010C RID: 268 RVA: 0x00009E5C File Offset: 0x00008E5C
        private static void LoadLacVietDictionary()
        {
            lacVietDictionary.Clear();
            using (TextReader textReader = new StreamReader(DictionaryConfigurationHelper.GetLacVietDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    string[] array = text.Split(new char[]
                    {
                        '='
                    });
                    if (array.Length == 2 && !lacVietDictionary.ContainsKey(array[0]))
                    {
                        lacVietDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        // Token: 0x0600010D RID: 269 RVA: 0x00009EE0 File Offset: 0x00008EE0
        private static void LoadCedictDictionaryWithNewThread(object stateInfo)
        {
            LoadCedictDictionary();
        }

        // Token: 0x0600010E RID: 270 RVA: 0x00009EE7 File Offset: 0x00008EE7
        private static void LoadChinesePhienAmEnglishDictionaryWithNewThread(object stateInfo)
        {
            LoadChinesePhienAmEnglishDictionary();
        }

        // Token: 0x0600010F RID: 271 RVA: 0x00009EEE File Offset: 0x00008EEE
        private static void LoadPronounDictionaryWithNewThread(object stateInfo)
        {
            LoadPronounDictionary();
            ((ManualResetEvent)stateInfo).Set();
        }

        // Token: 0x06000110 RID: 272 RVA: 0x00009F01 File Offset: 0x00008F01
        private static void LoadIgnoredChinesePhraseListsWithNewThread(object stateInfo)
        {
            LoadIgnoredChinesePhraseLists();
        }

        // Token: 0x06000111 RID: 273 RVA: 0x00009F08 File Offset: 0x00008F08
        private static void LoadOnlyVietPhraseDictionaryHistoryWithNewThread(object stateInfo)
        {
            LoadOnlyVietPhraseDictionaryHistory();
        }

        // Token: 0x06000112 RID: 274 RVA: 0x00009F0F File Offset: 0x00008F0F
        private static void LoadOnlyNameDictionaryHistoryWithNewThread(object stateInfo)
        {
            LoadOnlyNameDictionaryHistory();
        }

        // Token: 0x06000113 RID: 275 RVA: 0x00009F16 File Offset: 0x00008F16
        private static void LoadOnlyNamePhuDictionaryHistoryWithNewThread(object stateInfo)
        {
            LoadOnlyNamePhuDictionaryHistory();
        }

        // Token: 0x06000114 RID: 276 RVA: 0x00009F1D File Offset: 0x00008F1D
        private static void LoadHanVietDictionaryHistoryWithNewThread(object stateInfo)
        {
            LoadHanVietDictionaryHistory();
        }

        // Token: 0x06000115 RID: 277 RVA: 0x00009F24 File Offset: 0x00008F24
        private static void LoadOnlyVietPhraseDictionaryHistory()
        {
            LoadDictionaryHistory(DictionaryConfigurationHelper.GetVietPhraseDictionaryHistoryPath(), ref onlyVietPhraseDictionaryHistoryDataSet);
        }

        // Token: 0x06000116 RID: 278 RVA: 0x00009F35 File Offset: 0x00008F35
        private static void LoadOnlyNameDictionaryHistory()
        {
            LoadDictionaryHistory(DictionaryConfigurationHelper.GetNamesDictionaryHistoryPath(), ref onlyNameDictionaryHistoryDataSet);
        }

        // Token: 0x06000117 RID: 279 RVA: 0x00009F46 File Offset: 0x00008F46
        private static void LoadOnlyNamePhuDictionaryHistory()
        {
            LoadDictionaryHistory(DictionaryConfigurationHelper.GetNamesPhuDictionaryHistoryPath(), ref onlyNamePhuDictionaryHistoryDataSet);
        }

        // Token: 0x06000118 RID: 280 RVA: 0x00009F57 File Offset: 0x00008F57
        private static void LoadHanVietDictionaryHistory()
        {
            LoadDictionaryHistory(DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryHistoryPath(), ref hanVietDictionaryHistoryDataSet);
        }

        // Token: 0x06000119 RID: 281 RVA: 0x00009F68 File Offset: 0x00008F68
        public static void LoadDictionaryHistory(string dictionaryHistoryPath, ref DataSet dictionaryHistoryDataSet)
        {
            dictionaryHistoryDataSet.Clear();
            string name = "DictionaryHistory";
            if (!dictionaryHistoryDataSet.Tables.Contains(name))
            {
                dictionaryHistoryDataSet.Tables.Add(name);
                dictionaryHistoryDataSet.Tables[name].Columns.Add("Entry", Type.GetType("System.String"));
                dictionaryHistoryDataSet.Tables[name].Columns.Add("Action", Type.GetType("System.String"));
                dictionaryHistoryDataSet.Tables[name].Columns.Add("User Name", Type.GetType("System.String"));
                dictionaryHistoryDataSet.Tables[name].Columns.Add("Updated Date", Type.GetType("System.DateTime"));
                dictionaryHistoryDataSet.Tables[name].PrimaryKey = new DataColumn[]
                {
                    dictionaryHistoryDataSet.Tables[name].Columns["Entry"]
                };
            }
            if (!File.Exists(dictionaryHistoryPath))
            {
                return;
            }
            string name2 = CharsetDetector.DetectChineseCharset(dictionaryHistoryPath);
            using (TextReader textReader = new StreamReader(dictionaryHistoryPath, Encoding.GetEncoding(name2)))
            {
                textReader.ReadLine();
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    string[] array = text.Split(new char[]
                    {
                        '\t'
                    });
                    if (array.Length == 4)
                    {
                        DataRow dataRow = dictionaryHistoryDataSet.Tables[name].Rows.Find(array[0]);
                        if (dataRow == null)
                        {
                            dictionaryHistoryDataSet.Tables[name].Rows.Add(new object[]
                            {
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

        // Token: 0x0600011A RID: 282 RVA: 0x0000A198 File Offset: 0x00009198
        private static void LoadCedictDictionary()
        {
            cedictDictionary.Clear();
            using (TextReader textReader = new StreamReader(DictionaryConfigurationHelper.GetCEDictDictionaryPath(), Encoding.UTF8))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    if (!text.StartsWith("#"))
                    {
                        string text2 = text.Substring(0, text.IndexOf(" ["));
                        foreach (string key in text2.Split(new char[]
                        {
                            ' '
                        }))
                        {
                            if (!cedictDictionary.ContainsKey(key))
                            {
                                cedictDictionary.Add(key, text.Substring(text.IndexOf(" [")));
                            }
                        }
                    }
                }
            }
            using (TextReader textReader2 = new StreamReader(DictionaryConfigurationHelper.GetBabylonDictionaryPath(), Encoding.UTF8))
            {
                string text3;
                while ((text3 = textReader2.ReadLine()) != null)
                {
                    string[] array2 = text3.Split(new char[]
                    {
                        '='
                    });
                    if (!cedictDictionary.ContainsKey(array2[0]))
                    {
                        cedictDictionary.Add(array2[0], array2[1]);
                    }
                }
            }
        }

        // Token: 0x0600011B RID: 283 RVA: 0x0000A2D8 File Offset: 0x000092D8
        private static void LoadChinesePhienAmEnglishDictionary()
        {
            chinesePhienAmEnglishDictionary.Clear();
            using (TextReader textReader = new StreamReader(DictionaryConfigurationHelper.GetChinesePhienAmEnglishWordsDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    string[] array = text.Split(new char[]
                    {
                        '='
                    });
                    if (array.Length == 2 && !chinesePhienAmEnglishDictionary.ContainsKey(array[0]))
                    {
                        chinesePhienAmEnglishDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        // Token: 0x0600011C RID: 284 RVA: 0x0000A35C File Offset: 0x0000935C
        private static void LoadPronounDictionary()
        {
            pronounDictionary.Clear();
            using (TextReader textReader = new StreamReader(DictionaryConfigurationHelper.GetPronounsDictionaryPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    string[] array = text.Split(new char[]
                    {
                        '='
                    });
                    if (array.Length == 2 && !pronounDictionary.ContainsKey(array[0]))
                    {
                        pronounDictionary.Add(array[0], array[1]);
                    }
                }
            }
        }

        // Token: 0x0600011D RID: 285 RVA: 0x0000A3E0 File Offset: 0x000093E0
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
            catch
            {
            }
            LoadIgnoredChinesePhraseLists();
        }

        // Token: 0x0600011E RID: 286 RVA: 0x0000A43C File Offset: 0x0000943C
        private static void LoadIgnoredChinesePhraseLists()
        {
            ignoredChinesePhraseList.Clear();
            ignoredChinesePhraseForBrowserList.Clear();
            char[] trimChars = "\t\n".ToCharArray();
            using (TextReader textReader = new StreamReader(DictionaryConfigurationHelper.GetIgnoredChinesePhraseListPath(), true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(text))
                    {
                        string text2 = StandardizeInputWithoutRemovingIgnoredChinesePhrases(text).Trim(trimChars);
                        if (!string.IsNullOrEmpty(text2) && !ignoredChinesePhraseList.Contains(text2))
                        {
                            ignoredChinesePhraseList.Add(text2);
                        }
                        string text3 = StandardizeInputForBrowserWithoutRemovingIgnoredChinesePhrases(text).Trim(trimChars);
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

        // Token: 0x0600011F RID: 287 RVA: 0x0000A530 File Offset: 0x00009530
        private static int CompareStringByDescending(string x, string y)
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

        // Token: 0x06000120 RID: 288 RVA: 0x0000A574 File Offset: 0x00009574
        public static string StandardizeInput(string original)
        {
            string standardizedChinese = StandardizeInputWithoutRemovingIgnoredChinesePhrases(original);
            return RemoveIgnoredChinesePhrases(standardizedChinese);
        }

        // Token: 0x06000121 RID: 289 RVA: 0x0000A590 File Offset: 0x00009590
        private static string StandardizeInputWithoutRemovingIgnoredChinesePhrases(string original)
        {
            if (string.IsNullOrEmpty(original) || string.IsNullOrEmpty(original))
            {
                return "";
            }
            string text = ToSimplified(original);
            string[] array = new string[]
            {
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
            string[] array2 = new string[]
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
            text = text.Replace("  ", " ").Replace(" \r\n", "\n").Replace(" \n", "\n").Replace(" ,", ",");
            text = ToNarrow(text);
            int length = text.Length;
            StringBuilder stringBuilder = new StringBuilder();
            for (int j = 0; j < length - 1; j++)
            {
                char c = text[j];
                char c2 = text[j + 1];
                if (!char.IsControl(c) || c == '\t' || c == '\n' || c == '\r')
                {
                    if (IsChineseInternal(c))
                    {
                        if (!IsChineseInternal(c2) && c2 != ',' && c2 != '.' && c2 != ':' && c2 != ';' && c2 != '"' && c2 != '\'' && c2 != '?' && c2 != ' ' && c2 != '!' && c2 != ')')
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

        // Token: 0x06000122 RID: 290 RVA: 0x0000A908 File Offset: 0x00009908
        public static string StandardizeInputForBrowser(string original)
        {
            string standardizedChinese = StandardizeInputForBrowserWithoutRemovingIgnoredChinesePhrases(original);
            return RemoveIgnoredChinesePhrasesForBrowser(standardizedChinese);
        }

        // Token: 0x06000123 RID: 291 RVA: 0x0000A924 File Offset: 0x00009924
        private static string StandardizeInputForBrowserWithoutRemovingIgnoredChinesePhrases(string original)
        {
            if (string.IsNullOrEmpty(original) || string.IsNullOrEmpty(original))
            {
                return "";
            }
            string text = ToSimplified(original);
            string[] array = new string[]
            {
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
            string[] array2 = new string[]
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
            StringBuilder stringBuilder = new StringBuilder();
            for (int j = 0; j < length - 1; j++)
            {
                char c = text[j];
                char c2 = text[j + 1];
                if (IsChineseInternal(c))
                {
                    if (!IsChineseInternal(c2) && c2 != ',' && c2 != '.' && c2 != ':' && c2 != ';' && c2 != '"' && c2 != '\'' && c2 != '?' && c2 != ' ' && c2 != '!')
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

        // Token: 0x06000124 RID: 292 RVA: 0x0000AC04 File Offset: 0x00009C04
        public static string StandardizeInputForProxy(string original)
        {
            string standardizedChinese = StandardizeInputForProxyWithoutRemovingIgnoredChinesePhrases(original);
            return RemoveIgnoredChinesePhrasesForBrowser(standardizedChinese);
        }

        // Token: 0x06000125 RID: 293 RVA: 0x0000AC20 File Offset: 0x00009C20
        private static string StandardizeInputForProxyWithoutRemovingIgnoredChinesePhrases(string original)
        {
            if (string.IsNullOrEmpty(original) || string.IsNullOrEmpty(original))
            {
                return "";
            }
            string text = ToSimplified(original);
            string[] array = new string[]
            {
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
            string[] array2 = new string[]
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
            StringBuilder stringBuilder = new StringBuilder();
            for (int j = 0; j < length - 1; j++)
            {
                char c = text[j];
                char c2 = text[j + 1];
                if (IsChineseInternal(c))
                {
                    if (!IsChineseInternal(c2) && c2 != ',' && c2 != '.' && c2 != ':' && c2 != ';' && c2 != '"' && c2 != '\'' && c2 != '?' && c2 != ' ' && c2 != '!')
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

        // Token: 0x06000126 RID: 294 RVA: 0x0000AEF4 File Offset: 0x00009EF4
        private static string IndentAllLines(string text, bool insertBlankLine)
        {
            string[] array = text.Split(new char[]
            {
                '\n'
            }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string text2 in array)
            {
                if (!string.IsNullOrEmpty(text2.Trim()))
                {
                    stringBuilder.Append("\t" + text2.Trim()).Append("\n").Append(insertBlankLine ? "\n" : "");
                }
            }
            return stringBuilder.ToString();
        }

        // Token: 0x06000127 RID: 295 RVA: 0x0000AF80 File Offset: 0x00009F80
        private static string IndentAllLines(string text)
        {
            return IndentAllLines(text, false);
        }

        // Token: 0x06000128 RID: 296 RVA: 0x0000AF89 File Offset: 0x00009F89
        private static bool IsChineseInternal(char character)
        {
            return hanVietDictionary.ContainsKey(character.ToString());
        }

        // Token: 0x06000129 RID: 297 RVA: 0x0000AF9C File Offset: 0x00009F9C
        public static bool IsChinese(char character)
        {
            return IsChineseInternal(character);
        }

        // Token: 0x0600012A RID: 298 RVA: 0x0000AFA4 File Offset: 0x00009FA4
        public static bool IsAllChinese(string text)
        {
            foreach (char character in text)
            {
                if (!IsChineseInternal(character))
                {
                    return false;
                }
            }
            return true;
        }

        // Token: 0x0600012B RID: 299 RVA: 0x0000AFDC File Offset: 0x00009FDC
        private static bool HasOnlyOneMeaning(string meaning)
        {
            return meaning.Split(new char[]
            {
                '/',
                '|'
            }).Length == 1;
        }

        // Token: 0x0600012C RID: 300 RVA: 0x0000B006 File Offset: 0x0000A006
        internal static string ToSimplified(string str)
        {
            return Strings.StrConv(str, VbStrConv.SimplifiedChinese, 0);
        }

        // Token: 0x0600012D RID: 301 RVA: 0x0000B014 File Offset: 0x0000A014
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
            StringBuilder stringBuilder = new StringBuilder();
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

        // Token: 0x0600012E RID: 302 RVA: 0x0000B094 File Offset: 0x0000A094
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
            StringBuilder stringBuilder = new StringBuilder();
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

        // Token: 0x0600012F RID: 303 RVA: 0x0000B120 File Offset: 0x0000A120
        private static void AppendTranslatedWord(StringBuilder result, string translatedText, ref string lastTranslatedWord)
        {
            int num = 0;
            AppendTranslatedWord(result, translatedText, ref lastTranslatedWord, ref num);
        }

        // Token: 0x06000130 RID: 304 RVA: 0x0000B13C File Offset: 0x0000A13C
        private static void AppendTranslatedWord(StringBuilder result, string translatedText, ref string lastTranslatedWord, ref int startIndexOfNextTranslatedText)
        {
            if (lastTranslatedWord.EndsWith("\n") || lastTranslatedWord.EndsWith("\t") || lastTranslatedWord.EndsWith(". ") || lastTranslatedWord.EndsWith("\"") || lastTranslatedWord.EndsWith("'") || lastTranslatedWord.EndsWith("? ") || lastTranslatedWord.EndsWith("! ") || lastTranslatedWord.EndsWith(".\" ") || lastTranslatedWord.EndsWith("?\" ") || lastTranslatedWord.EndsWith("!\" ") || lastTranslatedWord.EndsWith(": "))
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
            if ((string.IsNullOrEmpty(translatedText) || translatedText[0] == ',' || translatedText[0] == '.' || translatedText[0] == '?' || translatedText[0] == '!') && 0 < result.Length && result[result.Length - 1] == ' ')
            {
                result = result.Remove(result.Length - 1, 1);
                startIndexOfNextTranslatedText--;
            }
            result.Append(lastTranslatedWord);
        }

        // Token: 0x06000131 RID: 305 RVA: 0x0000B290 File Offset: 0x0000A290
        private static string ToUpperCase(string text)
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

        // Token: 0x06000132 RID: 306 RVA: 0x0000B31D File Offset: 0x0000A31D
        private static bool NextCharIsChinese(string chinese, int currentPhraseEndIndex)
        {
            return chinese.Length - 1 > currentPhraseEndIndex && IsChineseInternal(chinese[currentPhraseEndIndex + 1]);
        }

        // Token: 0x06000133 RID: 307 RVA: 0x0000B33C File Offset: 0x0000A33C
        private static string[] ClassifyWordsIntoLatinAndChinese(string inputText)
        {
            List<string> list = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = false;
            foreach (char c in inputText)
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

        // Token: 0x06000134 RID: 308 RVA: 0x0000B3EC File Offset: 0x0000A3EC
        private static string[] ClassifyWordsIntoLatinAndChineseForProxy(string inputText)
        {
            List<string> list = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
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

        // Token: 0x06000135 RID: 309 RVA: 0x0000B501 File Offset: 0x0000A501
        public static bool IsInVietPhrase(string chinese)
        {
            return vietPhraseDictionary.ContainsKey(chinese);
        }

        // Token: 0x06000136 RID: 310 RVA: 0x0000B510 File Offset: 0x0000A510
        public static string ChineseToHanVietForAnalyzer(string chinese)
        {
            StringBuilder stringBuilder = new StringBuilder();
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

        // Token: 0x06000137 RID: 311 RVA: 0x0000B597 File Offset: 0x0000A597
        public static string ChineseToVietPhraseForAnalyzer(string chinese, int translationAlgorithm, bool prioritizedName)
        {
            return ChineseToVietPhraseForBrowser(chinese, 11, translationAlgorithm, prioritizedName).Trim(trimCharsForAnalyzer);
        }

        // Token: 0x06000138 RID: 312 RVA: 0x0000B5B0 File Offset: 0x0000A5B0
        private static bool ContainsName(string chinese, int startIndex, int phraseLength)
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

        // Token: 0x06000139 RID: 313 RVA: 0x0000B620 File Offset: 0x0000A620
        private static bool IsLongestPhraseInSentence(string chinese, int startIndex, int phraseLength, Dictionary<string, string> dictionary, int translationAlgorithm)
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

        // Token: 0x0600013A RID: 314 RVA: 0x0000B682 File Offset: 0x0000A682
        public static int GetVietPhraseDictionaryCount()
        {
            return onlyVietPhraseDictionary.Count;
        }

        // Token: 0x0600013B RID: 315 RVA: 0x0000B68E File Offset: 0x0000A68E
        public static int GetNameDictionaryCount(bool isNameChinh)
        {
            if (!isNameChinh)
            {
                return onlyNamePhuDictionary.Count;
            }
            return onlyNameChinhDictionary.Count;
        }

        // Token: 0x0600013C RID: 316 RVA: 0x0000B6A8 File Offset: 0x0000A6A8
        public static int GetPhienAmDictionaryCount()
        {
            return hanVietDictionary.Count;
        }

        // Token: 0x0600013D RID: 317 RVA: 0x0000B6B4 File Offset: 0x0000A6B4
        public static bool ExistInPhienAmDictionary(string chinese)
        {
            return chinese.Length == 1 && hanVietDictionary.ContainsKey(chinese);
        }

        // Token: 0x0600013E RID: 318 RVA: 0x0000B6CC File Offset: 0x0000A6CC
        private static void UpdateHistoryLogInCache(string key, string action, ref DataSet dictionaryHistoryDataSet)
        {
            string name = "DictionaryHistory";
            DataRow dataRow = dictionaryHistoryDataSet.Tables[name].Rows.Find(key);
            if (dataRow == null)
            {
                dictionaryHistoryDataSet.Tables[name].Rows.Add(new object[]
                {
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

        // Token: 0x0600013F RID: 319 RVA: 0x0000B768 File Offset: 0x0000A768
        private static void WriteVietPhraseHistoryLog(string key, string action)
        {
            UpdateHistoryLogInCache(key, action, ref onlyVietPhraseDictionaryHistoryDataSet);
            WriteHistoryLog(key, action, DictionaryConfigurationHelper.GetVietPhraseDictionaryHistoryPath());
        }

        // Token: 0x06000140 RID: 320 RVA: 0x0000B784 File Offset: 0x0000A784
        private static void WriteNamesHistoryLog(string key, string action, bool isNameChinh)
        {
            DataSet dataSet = isNameChinh ? onlyNameDictionaryHistoryDataSet : onlyNamePhuDictionaryHistoryDataSet;
            UpdateHistoryLogInCache(key, action, ref dataSet);
            WriteHistoryLog(key, action, isNameChinh ? DictionaryConfigurationHelper.GetNamesDictionaryHistoryPath() : DictionaryConfigurationHelper.GetNamesPhuDictionaryHistoryPath());
        }

        // Token: 0x06000141 RID: 321 RVA: 0x0000B7C0 File Offset: 0x0000A7C0
        private static void WritePhienAmHistoryLog(string key, string action)
        {
            UpdateHistoryLogInCache(key, action, ref hanVietDictionaryHistoryDataSet);
            WriteHistoryLog(key, action, DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryHistoryPath());
        }

        // Token: 0x06000142 RID: 322 RVA: 0x0000B7DA File Offset: 0x0000A7DA
        public static string GetVietPhraseHistoryLogRecord(string key)
        {
            return GetDictionaryHistoryLogRecordInCache(key, onlyVietPhraseDictionaryHistoryDataSet);
        }

        // Token: 0x06000143 RID: 323 RVA: 0x0000B7E7 File Offset: 0x0000A7E7
        public static string GetNameHistoryLogRecord(string key, bool isNameChinh)
        {
            return GetDictionaryHistoryLogRecordInCache(key, isNameChinh ? onlyNameDictionaryHistoryDataSet : onlyNamePhuDictionaryHistoryDataSet);
        }

        // Token: 0x06000144 RID: 324 RVA: 0x0000B7FE File Offset: 0x0000A7FE
        public static string GetPhienAmHistoryLogRecord(string key)
        {
            return GetDictionaryHistoryLogRecordInCache(key, hanVietDictionaryHistoryDataSet);
        }

        // Token: 0x06000145 RID: 325 RVA: 0x0000B80C File Offset: 0x0000A80C
        private static string GetDictionaryHistoryLogRecordInCache(string key, DataSet dictionaryHistoryDataSet)
        {
            string name = "DictionaryHistory";
            DataRow dataRow = dictionaryHistoryDataSet.Tables[name].Rows.Find(key);
            if (dataRow == null)
            {
                return "";
            }
            return string.Format("Entry này đã được <{0}> bởi <{1}> vào <{2}>.", dataRow[1], dataRow[2], ((DateTime)dataRow[3]).ToString("yyyy-MM-dd HH:mm:ss.fffzzz"));
        }

        // Token: 0x06000146 RID: 326 RVA: 0x0000B871 File Offset: 0x0000A871
        public static void CompressPhienAmDictionaryHistory()
        {
            CompressDictionaryHistory(hanVietDictionaryHistoryDataSet, DictionaryConfigurationHelper.GetChinesePhienAmWordsDictionaryHistoryPath());
        }

        // Token: 0x06000147 RID: 327 RVA: 0x0000B882 File Offset: 0x0000A882
        public static void CompressOnlyVietPhraseDictionaryHistory()
        {
            CompressDictionaryHistory(onlyVietPhraseDictionaryHistoryDataSet, DictionaryConfigurationHelper.GetVietPhraseDictionaryHistoryPath());
        }

        // Token: 0x06000148 RID: 328 RVA: 0x0000B893 File Offset: 0x0000A893
        public static void CompressOnlyNameDictionaryHistory(bool isNameChinh)
        {
            CompressDictionaryHistory(isNameChinh ? onlyNameDictionaryHistoryDataSet : onlyNamePhuDictionaryHistoryDataSet, isNameChinh ? DictionaryConfigurationHelper.GetNamesDictionaryHistoryPath() : DictionaryConfigurationHelper.GetNamesPhuDictionaryHistoryPath());
        }

        // Token: 0x06000149 RID: 329 RVA: 0x0000B8B8 File Offset: 0x0000A8B8
        private static void CompressDictionaryHistory(DataSet dictionaryHistoryDataSet, string dictionaryHistoryFilePath)
        {
            string name = "DictionaryHistory";
            string text = dictionaryHistoryFilePath + "." + DateTime.Now.Ticks;
            if (File.Exists(dictionaryHistoryFilePath))
            {
                File.Copy(dictionaryHistoryFilePath, text, true);
            }
            using (TextWriter textWriter = new StreamWriter(dictionaryHistoryFilePath, false, Encoding.UTF8))
            {
                try
                {
                    textWriter.WriteLine("Entry\tAction\tUser Name\tUpdated Date");
                    DataTable dataTable = dictionaryHistoryDataSet.Tables[name];
                    foreach (object obj in dataTable.Rows)
                    {
                        DataRow dataRow = (DataRow)obj;
                        textWriter.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", new object[]
                        {
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
                    catch
                    {
                    }
                    if (File.Exists(dictionaryHistoryFilePath))
                    {
                        try
                        {
                            File.Copy(text, dictionaryHistoryFilePath, true);
                        }
                        catch
                        {
                        }
                    }
                    throw ex;
                }
                finally
                {
                    File.Delete(text);
                }
            }
        }

        // Token: 0x0600014A RID: 330 RVA: 0x0000BA44 File Offset: 0x0000AA44
        public static void WriteHistoryLog(string key, string action, string logPath)
        {
            if (!File.Exists(logPath))
            {
                File.AppendAllText(logPath, "Entry\tAction\tUser Name\tUpdated Date\r\n", Encoding.UTF8);
            }
            File.AppendAllText(logPath, string.Concat(new string[]
            {
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

        // Token: 0x0600014B RID: 331 RVA: 0x0000BACC File Offset: 0x0000AACC
        public static void CreateHistoryLog(string key, string action, ref StringBuilder historyLogs)
        {
            historyLogs.AppendLine(string.Concat(new string[]
            {
                key,
                "\t",
                action,
                "\t",
                Environment.GetEnvironmentVariable("USERNAME"),
                "\t",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffzzz")
            }));
        }

        // Token: 0x0600014C RID: 332 RVA: 0x0000BB30 File Offset: 0x0000AB30
        public static void WriteHistoryLog(string historyLogs, string logPath)
        {
            if (!File.Exists(logPath))
            {
                File.AppendAllText(logPath, "Entry\tAction\tUser Name\tUpdated Date\r\n", Encoding.UTF8);
            }
            File.AppendAllText(logPath, historyLogs, Encoding.UTF8);
        }

        // Token: 0x0600014D RID: 333 RVA: 0x0000BB58 File Offset: 0x0000AB58
        private static string RemoveIgnoredChinesePhrases(string standardizedChinese)
        {
            if (string.IsNullOrEmpty(standardizedChinese))
            {
                return string.Empty;
            }
            string text = standardizedChinese;
            foreach (string oldValue in ignoredChinesePhraseList)
            {
                text = text.Replace(oldValue, string.Empty);
            }
            return text.Replace("\t\n\n", string.Empty);
        }

        // Token: 0x0600014E RID: 334 RVA: 0x0000BBD0 File Offset: 0x0000ABD0
        private static string RemoveIgnoredChinesePhrasesForBrowser(string standardizedChinese)
        {
            if (string.IsNullOrEmpty(standardizedChinese))
            {
                return string.Empty;
            }
            string text = standardizedChinese;
            foreach (string oldValue in ignoredChinesePhraseForBrowserList)
            {
                text = text.Replace(oldValue, string.Empty);
            }
            return text.Replace("\t\n\n", string.Empty);
        }

        // Token: 0x0600014F RID: 335 RVA: 0x0000BC48 File Offset: 0x0000AC48
        private static int ContainsLuatNhan(string chinese, Dictionary<string, string> dictionary)
        {
            return ContainsLuatNhan(chinese, dictionary, out _, out _);
        }

        // Token: 0x06000150 RID: 336 RVA: 0x0000BC60 File Offset: 0x0000AC60
        private static int ContainsLuatNhan(string chinese, Dictionary<string, string> dictionary, out string luatNhan, out int matchedLength)
        {
            int length = chinese.Length;
            foreach (KeyValuePair<string, string> keyValuePair in luatNhanDictionary)
            {
                if (length >= keyValuePair.Key.Length - 2)
                {
                    string text = keyValuePair.Key.Replace("{0}", "([^,\\. ?]{1,10})");
                    Match match = Regex.Match(chinese, text);
                    int num = 0;
                    while (match.Success)
                    {
                        string value = match.Groups[1].Value;
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
            luatNhan = string.Empty;
            matchedLength = -1;
            return -1;
        }

        // Token: 0x06000151 RID: 337 RVA: 0x0000BE14 File Offset: 0x0000AE14
        private static bool MatchesLuatNhan(string chinese, Dictionary<string, string> dictionary)
        {
            foreach (KeyValuePair<string, string> keyValuePair in luatNhanDictionary)
            {
                string str = keyValuePair.Key.Replace("{0}", "(.+)");
                Match match = Regex.Match(chinese, "^" + str + "$");
                if (match.Success && dictionary.ContainsKey(match.Groups[1].Value))
                {
                    return true;
                }
            }
            return false;
        }

        // Token: 0x06000153 RID: 339 RVA: 0x0000BF00 File Offset: 0x0000AF00
        public static string ChineseToLuatNhan(string chinese, Dictionary<string, string> dictionary)
        {
            return ChineseToLuatNhan(chinese, dictionary, out _);
        }

        // Token: 0x06000154 RID: 340 RVA: 0x0000BF1C File Offset: 0x0000AF1C
        public static string ChineseToLuatNhan(string chinese, Dictionary<string, string> dictionary, out string luatNhan)
        {
            foreach (KeyValuePair<string, string> keyValuePair in luatNhanDictionary)
            {
                string str = keyValuePair.Key.Replace("{0}", "(.+)");
                Match match = Regex.Match(chinese, "^" + str + "$");
                if (match.Success && dictionary.ContainsKey(match.Groups[1].Value))
                {
                    string[] array = dictionary[match.Groups[1].Value].Split(new char[]
                    {
                        '/',
                        '|'
                    });
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (string newValue in array)
                    {
                        stringBuilder.Append(keyValuePair.Value.Replace("{0}", newValue));
                        stringBuilder.Append("/");
                    }
                    luatNhan = keyValuePair.Key;
                    return stringBuilder.ToString().Trim(new char[]
                    {
                        '/'
                    });
                }
            }
            throw new NotImplementedException("Lỗi xử lý luật nhân cho cụm từ: " + chinese);
        }

        // Token: 0x04000090 RID: 144
        public const int CHINESE_LOOKUP_MAX_LENGTH = 20;

        // Token: 0x04000092 RID: 146
        private static Dictionary<string, string> hanVietDictionary = new Dictionary<string, string>();

        // Token: 0x04000093 RID: 147
        private static readonly Dictionary<string, string> vietPhraseDictionary = new Dictionary<string, string>();

        // Token: 0x04000094 RID: 148
        private static readonly Dictionary<string, string> thieuChuuDictionary = new Dictionary<string, string>();

        // Token: 0x04000095 RID: 149
        private static readonly Dictionary<string, string> lacVietDictionary = new Dictionary<string, string>();

        // Token: 0x04000096 RID: 150
        private static readonly Dictionary<string, string> cedictDictionary = new Dictionary<string, string>();

        // Token: 0x04000097 RID: 151
        private static readonly Dictionary<string, string> chinesePhienAmEnglishDictionary = new Dictionary<string, string>();

        // Token: 0x04000098 RID: 152
        private static readonly Dictionary<string, string> vietPhraseOneMeaningDictionary = new Dictionary<string, string>();

        // Token: 0x04000099 RID: 153
        private static Dictionary<string, string> onlyVietPhraseDictionary = new Dictionary<string, string>();

        // Token: 0x0400009A RID: 154
        private static Dictionary<string, string> onlyNameDictionary = new Dictionary<string, string>();

        // Token: 0x0400009B RID: 155
        private static Dictionary<string, string> onlyNameOneMeaningDictionary = new Dictionary<string, string>();

        // Token: 0x0400009C RID: 156
        private static Dictionary<string, string> onlyNameChinhDictionary = new Dictionary<string, string>();

        // Token: 0x0400009D RID: 157
        private static Dictionary<string, string> onlyNamePhuDictionary = new Dictionary<string, string>();

        // Token: 0x0400009E RID: 158
        private static readonly Dictionary<string, string> luatNhanDictionary = new Dictionary<string, string>();

        // Token: 0x0400009F RID: 159
        private static readonly Dictionary<string, string> pronounDictionary = new Dictionary<string, string>();

        // Token: 0x040000A0 RID: 160
        private static readonly Dictionary<string, string> pronounOneMeaningDictionary = new Dictionary<string, string>();

        // Token: 0x040000A1 RID: 161
        private static Dictionary<string, string> nhanByDictionary = null;

        // Token: 0x040000A2 RID: 162
        private static Dictionary<string, string> nhanByOneMeaningDictionary = null;

        // Token: 0x040000A3 RID: 163
        private static DataSet onlyVietPhraseDictionaryHistoryDataSet = new DataSet();

        // Token: 0x040000A4 RID: 164
        private static DataSet onlyNameDictionaryHistoryDataSet = new DataSet();

        // Token: 0x040000A5 RID: 165
        private static DataSet onlyNamePhuDictionaryHistoryDataSet = new DataSet();

        // Token: 0x040000A6 RID: 166
        private static DataSet hanVietDictionaryHistoryDataSet = new DataSet();

        // Token: 0x040000A7 RID: 167
        private static readonly List<string> ignoredChinesePhraseList = new List<string>();

        // Token: 0x040000A8 RID: 168
        private static readonly List<string> ignoredChinesePhraseForBrowserList = new List<string>();

        // Token: 0x040000A9 RID: 169
        private static readonly object lockObject = new object();

        // Token: 0x040000AA RID: 170
        private static readonly string NULL_STRING = Convert.ToChar(0).ToString();

        // Token: 0x040000AB RID: 171
        public static string LastTranslatedWord_HanViet = "";

        // Token: 0x040000AC RID: 172
        public static string LastTranslatedWord_VietPhrase = "";

        // Token: 0x040000AD RID: 173
        public static string LastTranslatedWord_VietPhraseOneMeaning = "";

        // Token: 0x040000AE RID: 174
        private static readonly char[] trimCharsForAnalyzer = new char[]
        {
            ' ',
            '\n',
            '\t'
        };
    }
}

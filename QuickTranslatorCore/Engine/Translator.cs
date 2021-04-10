using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTranslatorCore.Engine
{
    using static Data;
    using static Util;
    using static Initializer;

    public class Translator
    {
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
                || lastTranslatedWord.EndsWith("!\" ") || lastTranslatedWord.EndsWith(": "))
                lastTranslatedWord = ToUpperCaseFirstChar(translatedText);
            else if (lastTranslatedWord.EndsWith(" ") || lastTranslatedWord.EndsWith("("))
                lastTranslatedWord = translatedText;
            else
                lastTranslatedWord = " " + translatedText;

            if ((string.IsNullOrEmpty(translatedText)
                || translatedText[0] == ','
                || translatedText[0] == '.'
                || translatedText[0] == '?' || translatedText[0] == '!')
                && 0 < result.Length && result[result.Length - 1] == ' ')
            {
                result = result.Remove(result.Length - 1, 1);
                startIndexOfNextTranslatedText--;
            }
            result.Append(lastTranslatedWord);
        }


        public static string ChineseToHanViet(string chinese, out CharRange[] chineseHanVietMappingArray)
        {
            LastTranslatedWord_SinoViet = "";
            var list = new List<CharRange>();
            var stringBuilder = new StringBuilder();
            int length = chinese.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int length2 = stringBuilder.ToString().Length;
                char c = chinese[i];
                char character = chinese[i + 1];
                if (IsChineseChar(c))
                {
                    if (IsChineseChar(character))
                    {
                        AppendTranslatedWord(stringBuilder, ChineseToHanViet(c), ref LastTranslatedWord_SinoViet, ref length2);
                        stringBuilder.Append(" ");
                        LastTranslatedWord_SinoViet += " ";
                        list.Add(new CharRange(length2, ChineseToHanViet(c).Length));
                    }
                    else
                    {
                        AppendTranslatedWord(stringBuilder, ChineseToHanViet(c), ref LastTranslatedWord_SinoViet, ref length2);
                        list.Add(new CharRange(length2, ChineseToHanViet(c).Length));
                    }
                }
                else
                {
                    stringBuilder.Append(c);
                    LastTranslatedWord_SinoViet += c.ToString();
                    list.Add(new CharRange(length2, 1));
                }
            }
            if (IsChineseChar(chinese[length - 1]))
            {
                AppendTranslatedWord(stringBuilder, ChineseToHanViet(chinese[length - 1]), ref LastTranslatedWord_SinoViet);
                list.Add(new CharRange(stringBuilder.ToString().Length, ChineseToHanViet(chinese[length - 1]).Length));
            }
            else
            {
                stringBuilder.Append(chinese[length - 1]);
                LastTranslatedWord_SinoViet += chinese[length - 1].ToString();
                list.Add(new CharRange(stringBuilder.ToString().Length, 1));
            }
            chineseHanVietMappingArray = list.ToArray();
            LastTranslatedWord_SinoViet = "";
            return stringBuilder.ToString();
        }

        public static string ChineseToHanVietForBrowser(string chinese)
        {
            if (string.IsNullOrEmpty(chinese))
                return "";
            chinese = NormalizeTextAndRemoveIgnoredChinesePhrasesForBrowser(chinese);
            var stringBuilder = new StringBuilder();
            var array = GroupCharByLatinOrChinese(chinese);
            var num = array.Length;
            for (int i = 0; i < num; i++)
            {
                string text = array[i];
                if (!string.IsNullOrEmpty(text))
                {
                    string text2;
                    if (IsChineseChar(text[0]))
                    {
                        text2 = ChineseToHanViet(text, out _).TrimStart(new char[0]);
                        if (i == 0 || !array[i - 1].EndsWith(", "))
                        {
                            text2 = ToUpperCaseFirstChar(text2);
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
                if (IsChineseChar(c))
                {
                    if (IsChineseChar(character))
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
            if (IsChineseChar(chinese[length - 1]))
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
            if (!SinoVietPronunciationDict.ContainsKey(chinese.ToString()))
            {
                return ToNarrow(chinese.ToString());
            }
            return SinoVietPronunciationDict[chinese.ToString()];
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
            LoadMultiplyByDict();
            while (i <= num)
            {
                bool flag = false;
                bool flag2 = true;
                for (int j = 20; j > 0; j--)
                {
                    if (chinese.Length >= i + j)
                    {
                        if (VietPhraseAndNameDict.ContainsKey(chinese.Substring(i, j)))
                        {
                            if ((!prioritizedName || !ContainsName(chinese, i, j)) && ((translationAlgorithm != 0 && translationAlgorithm != 2) || IsLongestPhraseInSentence(chinese, i, j, VietPhraseAndNameDict, translationAlgorithm) || (prioritizedName && NameDict.ContainsKey(chinese.Substring(i, j)))))
                            {
                                list.Add(new CharRange(i, j));
                                if (wrapType == 0)
                                {
                                    AppendTranslatedWord(stringBuilder, VietPhraseAndNameDict[chinese.Substring(i, j)], ref LastTranslatedWord_VietPhrase);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - VietPhraseAndNameDict[chinese.Substring(i, j)].Length, VietPhraseAndNameDict[chinese.Substring(i, j)].Length));
                                }
                                else if (wrapType == 1 || wrapType == 11)
                                {
                                    AppendTranslatedWord(stringBuilder, "[" + VietPhraseAndNameDict[chinese.Substring(i, j)] + "]", ref LastTranslatedWord_VietPhrase);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - VietPhraseAndNameDict[chinese.Substring(i, j)].Length - 2, VietPhraseAndNameDict[chinese.Substring(i, j)].Length + 2));
                                }
                                else if (HasOnlyOneMeaning(VietPhraseAndNameDict[chinese.Substring(i, j)]))
                                {
                                    AppendTranslatedWord(stringBuilder, VietPhraseAndNameDict[chinese.Substring(i, j)], ref LastTranslatedWord_VietPhrase);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - VietPhraseAndNameDict[chinese.Substring(i, j)].Length, VietPhraseAndNameDict[chinese.Substring(i, j)].Length));
                                }
                                else
                                {
                                    AppendTranslatedWord(stringBuilder, "[" + VietPhraseAndNameDict[chinese.Substring(i, j)] + "]", ref LastTranslatedWord_VietPhrase);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - VietPhraseAndNameDict[chinese.Substring(i, j)].Length - 2, VietPhraseAndNameDict[chinese.Substring(i, j)].Length + 2));
                                }
                                if (IsNextCharChinese(chinese, i + j - 1))
                                {
                                    stringBuilder.Append(" ");
                                    LastTranslatedWord_VietPhrase += " ";
                                }
                                flag = true;
                                i += j;
                                break;
                            }
                        }
                        else if (!chinese.Substring(i, j).Contains("\n") && !chinese.Substring(i, j).Contains("\t") && MultiplyByDict != null && flag2 && 2 < j && num2 < i + j - 1 && IsChineseString(chinese.Substring(i, j)))
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
                                int num6 = ContainsLuatNhan(chinese.Substring(i, j), MultiplyByDict, out _, out int num5);
                                num3 = i + num6;
                                num4 = num3 + num5;
                                if (num6 == 0)
                                {
                                    if (IsLongestPhraseInSentence(chinese, i - 1, num5 - 1, VietPhraseOneMeaningDict, translationAlgorithm))
                                    {
                                        j = num5;
                                        list.Add(new CharRange(i, j));
                                        string text = ChineseToLuatNhan(chinese.Substring(i, j), MultiplyByDict);
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
                                        if (IsNextCharChinese(chinese, i + j - 1))
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
                                    while (i + num7 < chinese.Length && IsChineseChar(chinese[i + num7 - 1]))
                                    {
                                        num7++;
                                    }
                                    if (i + num7 <= chinese.Length)
                                    {
                                        num6 = ContainsLuatNhan(chinese.Substring(i, num7), MultiplyByDict, out _, out _);
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
                    if (IsChineseChar(chinese[i]))
                    {
                        AppendTranslatedWord(stringBuilder, ((wrapType != 1) ? "" : "[") + ChineseToHanViet(chinese[i]) + ((wrapType != 1) ? "" : "]"), ref LastTranslatedWord_VietPhrase);
                        if (IsNextCharChinese(chinese, i))
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
            chinese = NormalizeTextAndRemoveIgnoredChinesePhrasesForBrowser(chinese);
            var stringBuilder = new StringBuilder();
            var array = GroupCharByLatinOrChinese(chinese);
            foreach (var text in array)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    if (IsChineseChar(text[0]))
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
                        if (VietPhraseAndNameDict.ContainsKey(chinese.Substring(i, j)))
                        {
                            if ((!prioritizedName || !ContainsName(chinese, i, j)) && ((translationAlgorithm != 0 && translationAlgorithm != 2) || IsLongestPhraseInSentence(chinese, i, j, VietPhraseAndNameDict, translationAlgorithm) || (prioritizedName && NameDict.ContainsKey(chinese.Substring(i, j)))))
                            {
                                if (!string.IsNullOrEmpty(VietPhraseAndNameDict[chinese.Substring(i, j)]))
                                {
                                    if (wrapType == 0)
                                    {
                                        AppendTranslatedWord(stringBuilder, VietPhraseAndNameDict[chinese.Substring(i, j)], ref text);
                                    }
                                    else if (wrapType == 1 || wrapType == 11)
                                    {
                                        AppendTranslatedWord(stringBuilder, "[" + VietPhraseAndNameDict[chinese.Substring(i, j)] + "]", ref text);
                                    }
                                    else if (HasOnlyOneMeaning(VietPhraseAndNameDict[chinese.Substring(i, j)]))
                                    {
                                        AppendTranslatedWord(stringBuilder, VietPhraseAndNameDict[chinese.Substring(i, j)], ref text);
                                    }
                                    else
                                    {
                                        AppendTranslatedWord(stringBuilder, "[" + VietPhraseAndNameDict[chinese.Substring(i, j)] + "]", ref text);
                                    }
                                    if (IsNextCharChinese(chinese, i + j - 1))
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
                        else if (!chinese.Substring(i, j).Contains("\n") && !chinese.Substring(i, j).Contains("\t") && MultiplyByDict != null && flag2 && 2 < j && num2 < i + j - 1 && IsChineseString(chinese.Substring(i, j)))
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
                                int num6 = ContainsLuatNhan(chinese.Substring(i, j), MultiplyByDict, out _, out int num5);
                                num3 = i + num6;
                                num4 = num3 + num5;
                                if (num6 == 0)
                                {
                                    if (IsLongestPhraseInSentence(chinese, i - 1, num5 - 1, VietPhraseOneMeaningDict, translationAlgorithm))
                                    {
                                        j = num5;
                                        string text2 = ChineseToLuatNhan(chinese.Substring(i, j), MultiplyByDict);
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
                                        if (IsNextCharChinese(chinese, i + j - 1))
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
                                    while (i + num7 < chinese.Length && IsChineseChar(chinese[i + num7 - 1]))
                                    {
                                        num7++;
                                    }
                                    if (i + num7 <= chinese.Length)
                                    {
                                        num6 = ContainsLuatNhan(chinese.Substring(i, num7), MultiplyByDict, out _, out _);
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
                    if (IsChineseChar(chinese[i]))
                    {
                        AppendTranslatedWord(stringBuilder, ((wrapType != 1) ? "" : "[") + ChineseToHanViet(chinese[i]) + ((wrapType != 1) ? "" : "]"), ref text);
                        if (IsNextCharChinese(chinese, i))
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
            LoadMultiplyByOneMeaningDict();
            while (i <= num)
            {
                bool flag = false;
                bool flag2 = true;
                for (int j = 20; j > 0; j--)
                {
                    if (chinese.Length >= i + j)
                    {
                        if (VietPhraseOneMeaningDict.ContainsKey(chinese.Substring(i, j)))
                        {
                            if ((!prioritizedName || !ContainsName(chinese, i, j)) && ((translationAlgorithm != 0 && translationAlgorithm != 2) || IsLongestPhraseInSentence(chinese, i, j, VietPhraseOneMeaningDict, translationAlgorithm) || (prioritizedName && NameDict.ContainsKey(chinese.Substring(i, j)))))
                            {
                                list.Add(new CharRange(i, j));
                                if (wrapType == 0)
                                {
                                    AppendTranslatedWord(stringBuilder, VietPhraseOneMeaningDict[chinese.Substring(i, j)], ref LastTranslatedWord_VietPhraseOneMeaning);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - VietPhraseOneMeaningDict[chinese.Substring(i, j)].Length, VietPhraseOneMeaningDict[chinese.Substring(i, j)].Length));
                                }
                                else
                                {
                                    AppendTranslatedWord(stringBuilder, "[" + VietPhraseOneMeaningDict[chinese.Substring(i, j)] + "]", ref LastTranslatedWord_VietPhraseOneMeaning);
                                    list2.Add(new CharRange(stringBuilder.ToString().Length - VietPhraseOneMeaningDict[chinese.Substring(i, j)].Length - 2, VietPhraseOneMeaningDict[chinese.Substring(i, j)].Length + 2));
                                }
                                if (IsNextCharChinese(chinese, i + j - 1))
                                {
                                    stringBuilder.Append(" ");
                                    LastTranslatedWord_VietPhraseOneMeaning += " ";
                                }
                                flag = true;
                                i += j;
                                break;
                            }
                        }
                        else if (!chinese.Substring(i, j).Contains("\n") && !chinese.Substring(i, j).Contains("\t") && MultiplyByOneMeaningDict != null && flag2 && 2 < j && num2 < i + j - 1 && IsChineseString(chinese.Substring(i, j)))
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
                                int num6 = ContainsLuatNhan(chinese.Substring(i, j), MultiplyByOneMeaningDict, out _, out int num5);
                                num3 = i + num6;
                                num4 = num3 + num5;
                                if (num6 == 0)
                                {
                                    if (IsLongestPhraseInSentence(chinese, i - 1, num5 - 1, VietPhraseOneMeaningDict, translationAlgorithm))
                                    {
                                        j = num5;
                                        list.Add(new CharRange(i, j));
                                        string text = ChineseToLuatNhan(chinese.Substring(i, j), MultiplyByOneMeaningDict);
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
                                        if (IsNextCharChinese(chinese, i + j - 1))
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
                                    while (i + num7 < chinese.Length && IsChineseChar(chinese[i + num7 - 1]))
                                    {
                                        num7++;
                                    }
                                    if (i + num7 <= chinese.Length)
                                    {
                                        num6 = ContainsLuatNhan(chinese.Substring(i, num7), MultiplyByOneMeaningDict, out _, out _);
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
                    if (IsChineseChar(chinese[i]))
                    {
                        AppendTranslatedWord(stringBuilder, ((wrapType != 1) ? "" : "[") + ChineseToHanViet(chinese[i]) + ((wrapType != 1) ? "" : "]"), ref LastTranslatedWord_VietPhraseOneMeaning);
                        if (IsNextCharChinese(chinese, i))
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
            chinese = NormalizeTextAndRemoveIgnoredChinesePhrasesForBrowser(chinese);
            var stringBuilder = new StringBuilder();
            var array = GroupCharByLatinOrChinese(chinese);
            int num = array.Length;
            for (int i = 0; i < num; i++)
            {
                var text = array[i];
                if (!string.IsNullOrEmpty(text))
                {
                    string text2;
                    if (IsChineseChar(text[0]))
                    {
                        text2 = ChineseToVietPhraseOneMeaning(text, wrapType, translationAlgorithm, prioritizedName,
                            out _, out _).TrimStart();
                        if (i == 0 || !array[i - 1].EndsWith(", "))
                        {
                            text2 = ToUpperCaseFirstChar(text2);
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
            chinese = NormalizeTextAndRemoveIgnoredChinesePhrasesForProxy(chinese);
            var stringBuilder = new StringBuilder();
            var array = GroupCharByLatinOrChineseForProxy(chinese);
            foreach (string text in array)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    if (IsChineseChar(text[0]))
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
                            if (VietPhraseOneMeaningDict.ContainsKey(chinese.Substring(i, j)))
                            {
                                if ((!prioritizedName || !ContainsName(chinese, i, j)) && ((translationAlgorithm != 0 && translationAlgorithm != 2) || IsLongestPhraseInSentence(chinese, i, j, VietPhraseOneMeaningDict, translationAlgorithm) || (prioritizedName && NameDict.ContainsKey(chinese.Substring(i, j)))))
                                {
                                    if (!string.IsNullOrEmpty(VietPhraseOneMeaningDict[chinese.Substring(i, j)]))
                                    {
                                        if (wrapType == 0)
                                        {
                                            AppendTranslatedWord(stringBuilder, VietPhraseOneMeaningDict[chinese.Substring(i, j)], ref text);
                                        }
                                        else
                                        {
                                            AppendTranslatedWord(stringBuilder, "[" + VietPhraseOneMeaningDict[chinese.Substring(i, j)] + "]", ref text);
                                        }
                                        if (IsNextCharChinese(chinese, i + j - 1))
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
                            else if (!chinese.Substring(i, j).Contains("\n") && !chinese.Substring(i, j).Contains("\t") && MultiplyByOneMeaningDict != null && flag2 && 2 < j && num2 < i + j - 1 && IsChineseString(chinese.Substring(i, j)))
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
                                    int num6 = ContainsLuatNhan(chinese.Substring(i, j), MultiplyByOneMeaningDict, out _, out int num5);
                                    num3 = i + num6;
                                    num4 = num3 + num5;
                                    if (num6 == 0)
                                    {
                                        if (IsLongestPhraseInSentence(chinese, i - 1, num5 - 1, VietPhraseOneMeaningDict, translationAlgorithm))
                                        {
                                            j = num5;
                                            string text2 = ChineseToLuatNhan(chinese.Substring(i, j), MultiplyByOneMeaningDict);
                                            if (wrapType == 0)
                                            {
                                                AppendTranslatedWord(stringBuilder, text2, ref text);
                                            }
                                            else
                                            {
                                                AppendTranslatedWord(stringBuilder, "[" + text2 + "]", ref text);
                                            }
                                            if (IsNextCharChinese(chinese, i + j - 1))
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
                                        while (i + num7 < chinese.Length && IsChineseChar(chinese[i + num7 - 1]))
                                        {
                                            num7++;
                                        }
                                        if (i + num7 <= chinese.Length)
                                        {
                                            num6 = ContainsLuatNhan(chinese.Substring(i, num7), MultiplyByOneMeaningDict, out _, out _);
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
                    if (IsChineseChar(chinese[i]))
                    {
                        AppendTranslatedWord(stringBuilder, ((wrapType != 1) ? "" : "[") + ChineseToHanViet(chinese[i]) + ((wrapType != 1) ? "" : "]"), ref text);
                        if (IsNextCharChinese(chinese, i))
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
                if (IsChineseChar(chinese[i]))
                {
                    for (int j = 20; j > 0; j--)
                    {
                        if (chinese.Length >= i + j && NameDict.ContainsKey(chinese.Substring(i, j)))
                        {
                            stringBuilder.Append(NameDict[chinese.Substring(i, j)]);
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
                    if (ContainsLuatNhan(chinese.Substring(0, i), VietPhraseAndNameDict) != 0)
                    {
                        break;
                    }
                    if (MatchesLuatNhan(chinese.Substring(0, i), VietPhraseAndNameDict))
                    {
                        ChineseToLuatNhan(chinese.Substring(0, i), VietPhraseAndNameDict, out string empty);
                        var text2 = text;
                        text = string.Concat(new[] {
                            text2,
                            empty,
                            " <<Luật Nhân>> ",
                            MultiplyRuleDict[empty].Replace("/", "; "),
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
                    if (VietPhraseAndNameDict.ContainsKey(text3))
                    {
                        var text4 = text;
                        text = string.Concat(new[] {
                            text4,
                            text3,
                            " <<VietPhrase>> ",
                            VietPhraseAndNameDict[text3].Replace("/", "; "),
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
                    if (LacVietDict.ContainsKey(text3))
                    {
                        var text5 = text;
                        text = string.Concat(new[] {
                            text5,
                            text3,
                            " <<Lạc Việt>>\n",
                            LacVietDict[text3],
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
                    if (CedictBabylonDict.ContainsKey(text3))
                    {
                        var text6 = text;
                        text = string.Concat(new[] {
                            text6,
                            text3,
                            " <<Cedict or Babylon>> ",
                            CedictBabylonDict[text3].Replace("] /", "] ").Replace("/", "; "),
                            "\n-----------------\n"
                        });
                        if (num == 0)
                        {
                            num = 1;
                        }
                    }
                }
            }
            if (ThieuChuuDict.ContainsKey(chinese[0].ToString()))
            {
                num = ((num == 0) ? 1 : num);
                var obj = text;
                text = string.Concat(new[] {
                    obj,
                    chinese[0].ToString(),
                    " <<Thiều Chửu>> ",
                    ThieuChuuDict[chinese[0].ToString()],
                    "\n-----------------\n"
                });
            }
            int num2 = (chinese.Length < 10) ? chinese.Length : 10;
            text = text + chinese.Substring(0, num2).Trim("\n\t ".ToCharArray()) + " <<Phiên Âm English>> ";
            for (int m = 0; m < num2; m++)
            {
                if (EnglishTransliterationDict.ContainsKey(chinese[m].ToString()))
                {
                    text = text + "[" + EnglishTransliterationDict[chinese[m].ToString()] + "] ";
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


    }
}

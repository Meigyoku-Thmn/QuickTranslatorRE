using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuickTranslatorCore
{
    public partial class TranslationEngine
    {
        static bool ContainsName(string text, int startIndex, int length)
        {
            if (length < 2)
                return false;
            if (NameDict.ContainsKey(text.Substring(startIndex, length)))
                return false;
            int num = startIndex + length - 1;
            int num2 = 2;
            for (int i = startIndex + 1; i <= num; i++)
            {
                for (int j = 20; j >= num2; j--)
                {
                    if (text.Length >= i + j && NameDict.ContainsKey(text.Substring(i, j)))
                        return true;
                }
            }
            return false;
        }
        static bool IsLongestPhraseInSentence(string text, int startIndex, int length,
            Dictionary<string, string> dict, int translationAlgorithm)
        {
            if (length < 2)
                return true;
            int num = (translationAlgorithm == 0) ? length : ((length < 3) ? 3 : length);
            int num2 = startIndex + length - 1;
            for (int i = startIndex + 1; i <= num2; i++)
            {
                for (int j = 20; j > num; j--)
                {
                    if (text.Length >= i + j && dict.ContainsKey(text.Substring(i, j)))
                        return false;
                }
            }
            return true;
        }

        static string[] GroupCharByLatinOrChineseForProxy(string text)
        {
            var list = new List<string>();
            var stringBuilder = new StringBuilder();
            bool isInChineseGroup = false;
            bool isInDiamondGroup = false;
            foreach (char chr in text)
            {
                if (isInDiamondGroup)
                {
                    stringBuilder.Append(chr);
                    isInChineseGroup = false;
                    if (chr == '>')
                    {
                        list.Add(stringBuilder.ToString());
                        stringBuilder.Length = 0;
                        isInDiamondGroup = false;
                    }
                }
                else if (chr == '<')
                {
                    list.Add(stringBuilder.ToString());
                    stringBuilder.Length = 0;
                    stringBuilder.Append(chr);
                    isInDiamondGroup = true;
                    isInChineseGroup = false;
                }
                else if (IsChineseChar(chr))
                {
                    if (isInChineseGroup)
                        stringBuilder.Append(chr);
                    else
                    {
                        list.Add(stringBuilder.ToString());
                        stringBuilder.Length = 0;
                        stringBuilder.Append(chr);
                    }
                    isInChineseGroup = true;
                }
                else
                {
                    if (!isInChineseGroup)
                        stringBuilder.Append(chr);
                    else
                    {
                        list.Add(stringBuilder.ToString());
                        stringBuilder.Length = 0;
                        stringBuilder.Append(chr);
                    }
                    isInChineseGroup = false;
                }
            }
            list.Add(stringBuilder.ToString());
            return list.ToArray();
        }

        static string[] GroupCharByLatinOrChinese(string text)
        {
            var list = new List<string>();
            var stringBuilder = new StringBuilder();
            var isInChineseGroup = false;
            foreach (var chr in text)
            {
                if (IsChineseChar(chr))
                {
                    if (isInChineseGroup)
                        stringBuilder.Append(chr);
                    else
                    {
                        list.Add(stringBuilder.ToString());
                        stringBuilder.Length = 0;
                        stringBuilder.Append(chr);
                    }
                    isInChineseGroup = true;
                }
                else
                {
                    if (!isInChineseGroup)
                        stringBuilder.Append(chr);
                    else
                    {
                        list.Add(stringBuilder.ToString());
                        stringBuilder.Length = 0;
                        stringBuilder.Append(chr);
                    }
                    isInChineseGroup = false;
                }
            }
            list.Add(stringBuilder.ToString());
            return list.ToArray();
        }

        static bool IsNextCharChinese(string text, int currentPhraseEndIndex)
            => text.Length - 1 > currentPhraseEndIndex && IsChineseChar(text[currentPhraseEndIndex + 1]);

        static string ToUpperCaseFirstChar(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;
            else if (text.StartsWith("[") && text.Length >= 2)
                return "[" + char.ToUpper(text[1]) + (text.Length <= 2 ? "" : text.Substring(2));
            else
                return char.ToUpper(text[0]) + (text.Length <= 1 ? "" : text.Substring(1));
        }

        public static bool IsChineseChar(char character)
            => SinoVietPronunciationDict.ContainsKey(character.ToString());

        public static bool IsChineseString(string text)
            => text.All(chr => IsChineseChar(chr));

        /// <summary>
        /// Check if "meanings" has only one value
        /// </summary>
        static bool HasOnlyOneMeaning(string meanings)
        {
            var separatorIdx = meanings.IndexOfAny(new[] { '/', '|' });
            if (separatorIdx == -1)
                return true;
            if (separatorIdx + 1 == meanings.Length)
                return true;
            return false;
        }

        /// <summary>
        /// Convert "str" to simplified chinese
        /// </summary>
        static string ToSimplified(string str)
            => Strings.StrConv(str, VbStrConv.SimplifiedChinese);

        static string ToNarrow(string str)
        {
            if (str.FindIndex(c => c >= '！' && c <= '～') == -1)
                return str;

            return string.Join("", str.Select(c => (c >= '！' && c <= '～') ? (c - '！' + '!') : c));
        }

        public static bool IsInVietPhrase(string text)
            => VietPhraseAndNameDict.ContainsKey(text);

        static bool MatchesLuatNhan(string text, Dictionary<string, string> dict)
        {
            return MultiplyRuleDict
                .Select(rule => $"^{rule.Key.Replace("{0}", "(.+)")}$")
                .Select(pattern => Regex.Match(text, pattern))
                .Any(match => match.Success && dict.ContainsKey(match.Groups[1].Value));
        }

        public static string ChineseToLuatNhan(string text, Dictionary<string, string> dict)
            => ChineseToLuatNhan(text, dict, out _);

        public static string ChineseToLuatNhan(string text, Dictionary<string, string> dict, out string matchedRule)
        {
            var (rule, match) = MultiplyRuleDict
                .Select(_rule => (rule: _rule, pattern: $"^{_rule.Key.Replace("{0}", "(.+)")}$"))
                .Select(e => (e.rule, match: Regex.Match(text, e.pattern)))
                .SkipWhile(e => !e.match.Success || !dict.ContainsKey(e.match.Groups[1].Value))
                .FirstOrDefault();

            if (match == null)
                throw new NotImplementedException("Lỗi xử lý luật nhân cho cụm từ: " + text);

            matchedRule = rule.Key;
            var meanings = dict[match.Groups[1].Value].Split('/', '|');
            return string.Join("/", meanings.Select(meaning => rule.Value.Replace("{0}", meaning)));
        }

        static string IndentAllLines(string text, bool insertBlankLine = false)
        {
            var additionalLastLine = insertBlankLine ? "\n" : "";
            var lines = text
                .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Trim())
                .Where(line => !string.IsNullOrEmpty(line))
                .Select(line => $"\t{line}\n{additionalLastLine}");

            return string.Join("", lines);
        }

        static int ContainsLuatNhan(string text, Dictionary<string, string> dict)
            => ContainsLuatNhan(text, dict, out _, out _);

        static int ContainsLuatNhan(string text, Dictionary<string, string> dict,
            out string matchedRule, out int matchedLength)
        {
            foreach (var rule in MultiplyRuleDict)
            {
                if (text.Length < rule.Key.Length - 2)
                    continue;
                var pattern = rule.Key.Replace("{0}", "([^,\\. ?]{1,10})");
                int num = 0;
                for (var match = Regex.Match(text, pattern); match.Success; match = match.NextMatch())
                {
                    var value = match.Groups[1].Value;
                    if (rule.Key.StartsWith("{0}"))
                    {
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (dict.ContainsKey(value.Substring(i)))
                            {
                                matchedRule = pattern;
                                matchedLength = match.Length - i;
                                return match.Index + i;
                            }
                        }
                    }
                    else if (rule.Key.EndsWith("{0}"))
                    {
                        int num2 = value.Length;
                        while (0 < num2)
                        {
                            if (dict.ContainsKey(value.Substring(0, num2)))
                            {
                                matchedRule = pattern;
                                matchedLength = match.Length - (value.Length - num2);
                                return match.Index;
                            }
                            num2--;
                        }
                    }
                    else if (dict.ContainsKey(value))
                    {
                        matchedRule = pattern;
                        matchedLength = match.Length;
                        return match.Index;
                    }
                    num++;
                    if (num > 1)
                    {
                        break;
                    }
                }
            }
            matchedRule = "";
            matchedLength = -1;
            return -1;
        }

    }
}

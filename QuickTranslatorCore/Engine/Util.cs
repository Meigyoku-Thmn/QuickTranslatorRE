using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuickTranslatorCore.Engine
{
    using static Data;
    using static Translator;

    public class Util
    {
        public static string NormalizeTextAndRemoveIgnoredChinesePhrasesForProxy(string text)
            => RemoveIgnoredChinesePhrasesForBrowser(NormalizeTextForProxy(text));

        static string NormalizeTextForProxy(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            text = ToSimplified(text);
            var chinesePunctations = new[] {
                "，", "。", "：", "“", "”", "‘", "’", "？", "！", "「", "」", "．", "、", "\u3000", "…", "\0",
            };
            var latinPunctations = new[] {
                ", ", ".", ": ", "\"", "\" ", "'", "' ", "?", "!", "\"", "\" ", ".", ", ", " ", "...", ""
            };
            for (int i = 0; i < chinesePunctations.Length; i++)
                text = text.Replace(chinesePunctations[i], latinPunctations[i]);

            text = text
                .Replace("  ", " ")
                .Replace(" \r\n", "\n")
                .Replace(" \n", "\n");

            text = ToNarrow(text);

            var stringBuilder = new StringBuilder();

            foreach (var (currentChr, nextChr) in text.Take(text.Length - 1).Zip(text.Skip(1), (a, b) => (a, b)))
            {
                if (IsChineseChar(currentChr))
                {
                    if (!IsChineseChar(nextChr)
                        && nextChr != ',' && nextChr != '.'
                        && nextChr != ':' && nextChr != ';'
                        && nextChr != '"' && nextChr != '\''
                        && nextChr != '?' && nextChr != ' ' && nextChr != '!')
                        stringBuilder.Append(currentChr).Append(" ");
                    else
                        stringBuilder.Append(currentChr);
                }
                else if (currentChr == '\t' || currentChr == ' '
                    || currentChr == '"' || currentChr == '\'' || currentChr == '\n')
                    stringBuilder.Append(currentChr);
                else if (IsChineseChar(nextChr))
                    stringBuilder.Append(currentChr).Append(" ");
                else
                    stringBuilder.Append(currentChr);
            }
            stringBuilder.Append(text[text.Length - 1]);
            return text;
        }

        static string RemoveIgnoredChinesePhrases(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            foreach (var oldValue in IgnoredChinesePhrases)
                text = text.Replace(oldValue, "");
            return text.Replace("\t\n\n", "");
        }

        static string RemoveIgnoredChinesePhrasesForBrowser(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            foreach (var oldValue in IgnoredChinesePhrasesForBrowser)
                text = text.Replace(oldValue, "");
            return text.Replace("\t\n\n", "");
        }

        public static string NormalizeTextAndRemoveIgnoredChinesePhrases(string text)
              => RemoveIgnoredChinesePhrases(NormalizeText(text));

        public static string NormalizeTextAndRemoveIgnoredChinesePhrasesForBrowser(string text)
            => RemoveIgnoredChinesePhrasesForBrowser(NormalizedTextForBrowser(text));

        public static string ChineseToHanVietForAnalyzer(string chinese)
        {
            var stringBuilder = new StringBuilder();
            foreach (char c in chinese)
            {
                if (SinoVietPronunciationDict.ContainsKey(c.ToString()))
                    stringBuilder.Append(SinoVietPronunciationDict[c.ToString()] + " ");
                else
                    stringBuilder.Append(c + " ");
            }
            return stringBuilder.ToString().Trim();
        }

        public static string ChineseToVietPhraseForAnalyzer(
            string chinese, int translationAlgorithm, bool prioritizedName)
        {
            return ChineseToVietPhraseForBrowser(chinese, 11, translationAlgorithm, prioritizedName)
                .Trim(' ', '\n', '\t');
        }

        public static int ContainsLuatNhan(string text, Dictionary<string, string> dict)
               => ContainsLuatNhan(text, dict, out _, out _);

        public static int ContainsLuatNhan(string text, Dictionary<string, string> dict,
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

        public static bool IsInVietPhrase(string text)
           => VietPhraseAndNameDict.ContainsKey(text);

        public static bool MatchesLuatNhan(string text, Dictionary<string, string> dict)
        {
            return MultiplyRuleDict
                .Select(rule => $"^{rule.Key.Replace("{0}", "(.+)")}$")
                .Select(pattern => Regex.Match(text, pattern))
                .Any(match => match.Success && dict.ContainsKey(match.Groups[1].Value));
        }

        /// <summary>
        /// Check if "meanings" has only one value
        /// </summary>
        public static bool HasOnlyOneMeaning(string meanings)
        {
            var separatorIdx = meanings.IndexOfAny(new[] { '/', '|' });
            if (separatorIdx == -1)
                return true;
            if (separatorIdx + 1 == meanings.Length)
                return true;
            return false;
        }

        public static bool IsNextCharChinese(string text, int currentPhraseEndIndex)
               => text.Length - 1 > currentPhraseEndIndex && IsChineseChar(text[currentPhraseEndIndex + 1]);

        public static string ToUpperCaseFirstChar(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;
            else if (text.StartsWith("[") && text.Length >= 2)
                return "[" + char.ToUpper(text[1]) + (text.Length <= 2 ? "" : text.Substring(2));
            else
                return char.ToUpper(text[0]) + (text.Length <= 1 ? "" : text.Substring(1));
        }

        public static string[] GroupCharByLatinOrChineseForProxy(string text)
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

        public static string[] GroupCharByLatinOrChinese(string text)
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

        public static bool ContainsName(string text, int startIndex, int length)
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
        public static bool IsLongestPhraseInSentence(string text, int startIndex, int length,
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

        public static string NormalizedTextForBrowser(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            text = ToSimplified(text);
            var chinesePunctations = new[] {
                "，", "。", "：", "“", "”", "‘", "’", "？", "！", "「", "」", "．", "、", "\u3000", "…", "\0",
            };
            var latinPunctations = new[] {
                ", ", ".", ": ", "\"", "\" ", "'", "' ", "?", "!", "\"", "\" ", ".", ", ", " ", "...", ""
            };
            for (int i = 0; i < chinesePunctations.Length; i++)
                text = text.Replace(chinesePunctations[i], latinPunctations[i]);

            text = text
                .Replace("  ", " ")
                .Replace(" \r\n", "\n")
                .Replace(" \n", "\n");

            text = ToNarrow(text);

            var stringBuilder = new StringBuilder();

            foreach (var (currentChr, nextChr) in text.Take(text.Length - 1).Zip(text.Skip(1), (a, b) => (a, b)))
            {
                if (IsChineseChar(currentChr))
                {
                    if (!IsChineseChar(nextChr)
                        && nextChr != ',' && nextChr != '.'
                        && nextChr != ':' && nextChr != ';'
                        && nextChr != '"' && nextChr != '\''
                        && nextChr != '?' && nextChr != ' ' && nextChr != '!')
                        stringBuilder.Append(currentChr).Append(" ");
                    else
                        stringBuilder.Append(currentChr);
                }
                else if (currentChr == '\t' || currentChr == ' '
                    || currentChr == '"' || currentChr == '\'' || currentChr == '\n')
                    stringBuilder.Append(currentChr);
                else if (IsChineseChar(nextChr))
                    stringBuilder.Append(currentChr).Append(" ");
                else
                    stringBuilder.Append(currentChr);
            }
            stringBuilder.Append(text[text.Length - 1]);
            return IndentAllLines(stringBuilder.ToString());
        }

        public static string IndentAllLines(string text, bool insertBlankLine = false)
        {
            var additionalLastLine = insertBlankLine ? "\n" : "";
            var lines = text
                .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Trim())
                .Where(line => !string.IsNullOrEmpty(line))
                .Select(line => $"\t{line}\n{additionalLastLine}");

            return string.Join("", lines);
        }

        public static bool IsChineseChar(char character)
               => SinoVietPronunciationDict.ContainsKey(character.ToString());

        public static bool IsChineseString(string text)
            => text.All(chr => IsChineseChar(chr));

        /// <summary>
        /// Convert "str" to simplified chinese
        /// </summary>
        public static string ToSimplified(string str)
            => Strings.StrConv(str, VbStrConv.SimplifiedChinese);

        public static string ToNarrow(string str)
        {
            if (str.FindIndex(c => c >= '！' && c <= '～') == -1)
                return str;

            return string.Join("", str.Select(c => (c >= '！' && c <= '～') ? (char)(c - '！' + '!') : c));
        }

        public static string NormalizeText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            text = ToSimplified(text);

            var chinesePunctations = new[] {
                "，", "。", "：", "“", "”", "‘", "’", "？", "！", "「", "」", "．", "、", "\u3000", "…", "\0",
            };
            var latinPunctations = new[] {
                ", ", ".", ": ", "\"", "\" ", "'", "' ", "?", "!", "\"", "\" ", ".", ", ", " ", "...", ""
            };
            for (int i = 0; i < chinesePunctations.Length; i++)
                text = text.Replace(chinesePunctations[i], latinPunctations[i]);

            text = text
                .Replace("  ", " ")
                .Replace(" \r\n", "\n")
                .Replace(" \n", "\n")
                .Replace(" ,", ",");

            text = ToNarrow(text);

            var stringBuilder = new StringBuilder();
            foreach (var (currentChr, nextChr) in text.Take(text.Length - 1).Zip(text.Skip(1), (a, b) => (a, b)))
            {
                if (char.IsControl(currentChr) && currentChr != '\t' && currentChr != '\n' && currentChr != '\r')
                    continue;

                if (IsChineseChar(currentChr))
                {
                    if (!IsChineseChar(nextChr)
                        && nextChr != ',' && nextChr != '.'
                        && nextChr != ':' && nextChr != ';'
                        && nextChr != '"' && nextChr != '\''
                        && nextChr != '?' && nextChr != ' ' && nextChr != '!' && nextChr != ')')
                        stringBuilder.Append(currentChr).Append(" ");
                    else
                        stringBuilder.Append(currentChr);
                }
                else if (currentChr == '\t' || currentChr == ' '
                    || currentChr == '"' || currentChr == '\'' || currentChr == '\n' || currentChr == '(')
                    stringBuilder.Append(currentChr);
                else if (currentChr == '!' || currentChr == '.' || currentChr == '?')
                {
                    if (nextChr == '"' || nextChr == ' ' || nextChr == '\'')
                        stringBuilder.Append(currentChr);
                    else
                        stringBuilder.Append(currentChr).Append(" ");
                }
                else if (IsChineseChar(nextChr))
                    stringBuilder.Append(currentChr).Append(" ");
                else
                    stringBuilder.Append(currentChr);
            }
            stringBuilder.Append(text[text.Length - 1]);
            text = IndentAllLines(stringBuilder.ToString(), insertBlankLine: true);
            return text.Replace(". . . . . .", "...");
        }
    }
}

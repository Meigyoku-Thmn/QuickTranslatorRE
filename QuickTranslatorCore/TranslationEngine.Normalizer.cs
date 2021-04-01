using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTranslatorCore
{
    public partial class TranslationEngine
    {
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


        static string NormalizeText(string text)
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
        public static string NormalizeTextAndRemoveIgnoredChinesePhrases(string text)
            => RemoveIgnoredChinesePhrases(NormalizeText(text));

        public static string NormalizeTextAndRemoveIgnoredChinesePhrasesForBrowser(string text)
            => RemoveIgnoredChinesePhrasesForBrowser(NormalizedTextForBrowser(text));

        static string NormalizedTextForBrowser(string text)
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
    }
}

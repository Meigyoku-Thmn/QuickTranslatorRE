using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace QuickTranslatorCore
{
    public class HtmlScrapper
    {
        static readonly string[] titleTokens = File.ReadAllLines(
            Path.Combine(Constants.ConfigsDir, "HtmlChapterTitleTags.config"));

        static readonly string[] contentTokens = File.ReadAllLines(
            Path.Combine(Constants.ConfigsDir, "HtmlChapterContentTags.config"));

        static readonly string[] noiseTokens = File.ReadAllLines(
            Path.Combine(Constants.ConfigsDir, "HtmlRemovedTags.config"));

        static readonly Regex NoiseToken = new Regex("<(.|\\n)*?>", RegexOptions.Compiled);

        /// <summary>
        /// Try to extract content from html of Chinese websites
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <param name="needMarkChapterHeaders"></param>
        /// <returns></returns>
        public static string GetChineseContent(string htmlContent, bool needMarkChapterHeaders)
        {
            var htmlContentLower = htmlContent.ToLower();

            var fullContent = new StringBuilder();

            foreach (var titleToken in titleTokens)
            {
                if (string.IsNullOrWhiteSpace(titleToken)               // blank line
                    || titleToken.StartsWith("#")                       // comment
                    || !htmlContentLower.Contains(titleToken.ToLower()) // htmlContent doesn't contains token
                ) continue;

                var afterTokenHtmlContent = htmlContent.Substring(
                    htmlContentLower.IndexOf(titleToken.ToLower()) + titleToken.Length);

                var afterTokenHtmlContentLower = afterTokenHtmlContent.ToLower();

                var _ = titleToken.Substring(titleToken.LastIndexOf('<') + 1);
                var wrapperTagName = _.Substring(0, _.IndexOfAny(new[] { ' ', '>' })).ToLower();

                var wrapperClosingTag = $"</{wrapperTagName}>";

                if (afterTokenHtmlContentLower.Contains(wrapperClosingTag))
                {
                    var title = afterTokenHtmlContent
                        .Substring(0, afterTokenHtmlContentLower.IndexOf(wrapperClosingTag))
                        .TrimStart();
                    fullContent.AppendLine((needMarkChapterHeaders ? "$CHAPTER_HEADER$. " : "") + title);
                    break;
                }
            }

            foreach (var contentToken in contentTokens)
            {
                if (string.IsNullOrEmpty(contentToken)                      // blank line
                    || contentToken.StartsWith("#")                         // comment
                    || !htmlContentLower.Contains(contentToken.ToLower())   // htmlContent doesn't contains token
                ) continue;

                var afterTokenHtmlContent = htmlContent.Substring(
                    htmlContentLower.IndexOf(contentToken.ToLower()) + contentToken.Length);

                var afterTokenHtmlContentLower = afterTokenHtmlContent.ToLower();

                if (contentToken != "<!--bodybegin-->")
                {
                    var _ = contentToken.Substring(contentToken.LastIndexOf('<') + 1);
                    var wrapperTagName = _.Substring(0, _.IndexOfAny(new[] { ' ', '>' })).ToLower();

                    var wrapperClosingTag = $"</{wrapperTagName}>";

                    if (afterTokenHtmlContentLower.Contains(wrapperClosingTag))
                    {
                        var content = afterTokenHtmlContent
                            .Substring(0, afterTokenHtmlContentLower.IndexOf(wrapperClosingTag));
                        fullContent.AppendLine(content);
                        break;
                    }
                }
                else
                {
                    string bodyEnd = "<!--bodyend-->";
                    if (afterTokenHtmlContent.Contains(bodyEnd))
                    {
                        var content = afterTokenHtmlContent.Substring(0,
                            afterTokenHtmlContentLower.IndexOf(bodyEnd.ToLower()));
                        fullContent.AppendLine(content);
                    }
                }
            }

            var fullContentStr = fullContent.ToString();

            foreach (var noiseToken in noiseTokens)
            {
                if (string.IsNullOrEmpty(noiseToken) || noiseToken.StartsWith("#"))
                    continue;
                fullContentStr = fullContentStr.Replace(noiseToken, "");
            }

            fullContentStr = fullContentStr
                .Replace("<p>", "\n")
                .Replace("</p>", "\n")
                .Replace("<br>", "\n")
                .Replace("<br/>", "\n")
                .Replace("<br />", "\n")
                .Replace("<BR>", "\n")
                .Replace("<BR/>", "\n")
                .Replace("<BR />", "\n")
                .Replace("&nbsp;", "")
                .Replace("&lt;", "")
                .Replace("&gt;", "");

            return NoiseToken.Replace(fullContentStr, "");
        }
    }
}

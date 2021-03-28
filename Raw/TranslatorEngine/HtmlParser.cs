using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslatorEngine
{
    public class HtmlParser
    {
        public static string GetChineseContent(string htmlContent, bool needMarkChapterHeaders)
        {
            LoadConfiguration();
            var stringBuilder = new StringBuilder();
            foreach (var text in titleTags)
            {
                if (!string.IsNullOrEmpty(text)
                    && !text.StartsWith("#")
                    && htmlContent.ToLower().Contains(text.ToLower()))
                {
                    var text2 = htmlContent.Substring(htmlContent.ToLower().IndexOf(text.ToLower()) + text.Length);
                    var text3 = text.Substring(text.LastIndexOf('<') + 1);
                    text3 = text3.Substring(0, text3.IndexOfAny(new[] { ' ', '>' }));
                    if (text2.ToLower().Contains("</" + text3.ToLower() + ">"))
                    {
                        stringBuilder.AppendLine((needMarkChapterHeaders ? "$CHAPTER_HEADER$. " : "")
                            + text2.Substring(0, text2.ToLower().IndexOf("</" + text3.ToLower() + ">"))
                                .TrimStart(" \u3000\t".ToCharArray())
                        );
                        break;
                    }
                }
            }
            foreach (var text4 in contentTags)
            {
                if (!string.IsNullOrEmpty(text4) && !text4.StartsWith("#") && htmlContent.ToLower().Contains(text4.ToLower()))
                {
                    string text5 = htmlContent.Substring(htmlContent.ToLower().IndexOf(text4.ToLower()) + text4.Length);
                    if (text4 != "<!--bodybegin-->")
                    {
                        string text6 = text4.Substring(text4.LastIndexOf('<') + 1);
                        text6 = text6.Substring(0, text6.IndexOfAny(new char[]
                        {
                            ' ',
                            '>'
                        }));
                        if (text5.ToLower().Contains("</" + text6.ToLower().TrimStart(new char[]
                        {
                            '/'
                        }) + ">"))
                        {
                            stringBuilder.AppendLine(text5.Substring(0, text5.ToLower().IndexOf("</" + text6.ToLower().TrimStart(new char[]
                            {
                                '/'
                            }) + ">")));
                            break;
                        }
                    }
                    else
                    {
                        string text6 = "<!--bodyend-->";
                        if (text5.Contains(text6))
                        {
                            stringBuilder.AppendLine(text5.Substring(0, text5.ToLower().IndexOf(text6.ToLower())));
                        }
                    }
                }
            }
            string text7 = stringBuilder.ToString();
            foreach (string text8 in removedTags)
            {
                if (!string.IsNullOrEmpty(text8) && !text8.StartsWith("#"))
                {
                    text7 = text7.Replace(text8, string.Empty);
                }
            }
            text7 = text7.Replace("<p>", "\n").Replace("</p>", "\n").Replace("<br>", "\n").Replace("<br/>", "\n").Replace("<br />", "\n").Replace("<BR>", "\n").Replace("<BR/>", "\n").Replace("<BR />", "\n").Replace("&nbsp;", "").Replace("&lt;", "").Replace("&gt;", "");
            return Regex.Replace(text7, "<(.|\\n)*?>", string.Empty);
        }

        static void LoadConfiguration()
        {
            if (!dirty)
            {
                return;
            }
            titleTags = File.ReadAllLines(Path.Combine(directoryPath, "HtmlChapterTitleTags.config"));
            contentTags = File.ReadAllLines(Path.Combine(directoryPath, "HtmlChapterContentTags.config"));
            removedTags = File.ReadAllLines(Path.Combine(directoryPath, "HtmlRemovedTags.config"));
            dirty = false;
        }

        static string[] titleTags;

        static string[] contentTags;

        static string[] removedTags;

        static bool dirty = true;

        static readonly string directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}

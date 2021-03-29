using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExtendedWebBrowser2
{
    public class HtmlUtilities
    {
        public static void SetInnerHtml(HtmlElement element, string innerHtml)
        {
            try
            {
                element.InnerHtml = innerHtml;
            }
            catch
            {
            }
        }

        public static void SetOuterHtml(HtmlElement element, string outerHtml)
        {
            try
            {
                element.OuterHtml = outerHtml;
            }
            catch
            {
            }
        }

        public static string ExtractTagName(string fullTagName)
        {
            if (fullTagName.Contains(" "))
            {
                return fullTagName.Substring(1, fullTagName.IndexOf(" "));
            }
            return fullTagName.Substring(1, fullTagName.Length - 2);
        }

        public static string RemoveChildTag(string html, string ignoredTag)
        {
            if (string.IsNullOrEmpty(html))
            {
                return html;
            }
            if (!html.Contains(ignoredTag))
            {
                return html;
            }
            string text;
            if (ignoredTag.Contains(" "))
            {
                text = ignoredTag.Substring(1, ignoredTag.IndexOf(" "));
            }
            else
            {
                text = ignoredTag.Substring(1, ignoredTag.Length - 2);
            }
            string pattern = string.Concat(new string[]
            {
                ignoredTag,
                "(.|\\n)*?((?<TAG><",
                text,
                ")(.|\\n)*?(?<-TAG></",
                text,
                ">))?(?(TAG)(?!))</",
                text,
                ">"
            });
            return Regex.Replace(html, pattern, "", RegexOptions.Multiline);
        }

        public static string DecodeLink(string link)
        {
            string text = link.Trim().Trim(new char[]
            {
                '/'
            });
            if (text.Contains("&"))
            {
                text = text.Substring(0, text.IndexOf("&"));
            }
            else if (text.Contains("=="))
            {
                text = text.Substring(0, text.IndexOf("==") + 2);
            }
            else if (text.Contains("="))
            {
                text = text.Substring(0, text.IndexOf("=") + 1);
            }
            if (text.Contains("://"))
            {
                text = text.Substring(text.IndexOf("://") + 3);
            }
            string text2;
            try
            {
                byte[] bytes = Convert.FromBase64String(text);
                text2 = Encoding.UTF8.GetString(bytes).Trim(new char[]
                {
                    'A',
                    'Z'
                });
                text2 = text2.Replace("[FLASHGET]", "");
            }
            catch
            {
                text2 = "Invalid Base64 string!!!";
            }
            return text2;
        }

        public static string DecodeLink(Match match)
        {
            string link = match.Groups[4].ToString().Trim(new char[]
            {
                '"'
            });
            return "<a href=\"" + HtmlUtilities.DecodeLink(link) + "\">";
        }

        public static string DecodeLinks(string innerHtml)
        {
            return Regex.Replace(innerHtml, "<(a|A) ([^>]+)\"(thunder|flashget)://([^\"]+)\"([^>]*)>", new MatchEvaluator(HtmlUtilities.DecodeLink));
        }

        public static char[] TrimmingChars = new char[]
        {
            ' ',
            '\n'
        };
    }
}

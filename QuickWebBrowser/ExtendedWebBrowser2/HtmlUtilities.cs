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
            try { element.InnerHtml = innerHtml; }
            catch { }
        }

        public static string DecodeLink(string link)
        {
            string text = link.Trim().Trim('/');
            if (text.Contains("&"))
                text = text.Substring(0, text.IndexOf("&"));
            else if (text.Contains("=="))
                text = text.Substring(0, text.IndexOf("==") + 2);
            else if (text.Contains("="))
                text = text.Substring(0, text.IndexOf("=") + 1);
            if (text.Contains("://"))
                text = text.Substring(text.IndexOf("://") + 3);
            string text2;
            try
            {
                byte[] bytes = Convert.FromBase64String(text);
                text2 = Encoding.UTF8.GetString(bytes).Trim('A', 'Z');
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
            string link = match.Groups[4].ToString().Trim('"');
            return "<a href=\"" + DecodeLink(link) + "\">";
        }

        public static string DecodeLinks(string innerHtml)
        {
            return Regex.Replace(innerHtml,
                "<(a|A) ([^>]+)\"(thunder|flashget)://([^\"]+)\"([^>]*)>", new MatchEvaluator(DecodeLink));
        }
    }
}

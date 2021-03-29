using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using OnlineTranslationEngine.Bing;

namespace OnlineTranslationEngine
{
    // Token: 0x02000004 RID: 4
    public class Engine
    {
        // Token: 0x06000007 RID: 7 RVA: 0x00002174 File Offset: 0x00001174
        public static string ChineseToEnglish(string chinese, int engineType, int onlineTranslationAlgorithm)
        {
            string empty = "";
            if (onlineTranslationAlgorithm == 0)
            {
                lock (lockObject)
                {
                    TryToTranslate(chinese, engineType, ref empty);
                }
            }
            else
            {
                TryToTranslate(chinese, engineType, ref empty);
            }
            return empty.Replace("\0", " ");
        }

        // Token: 0x06000008 RID: 8 RVA: 0x000021D4 File Offset: 0x000011D4
        static void TryToTranslate(string chinese, int engineType, ref string result)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    if (engineType == 1)
                    {
                        result = GoogleTranslate(chinese);
                    }
                    else if (engineType == 2)
                    {
                        result = YahooTranslate(chinese);
                    }
                    else if (engineType == 3)
                    {
                        result = SystranetTranslate(chinese);
                    }
                    else
                    {
                        result = MicrosoftTranslate(chinese);
                    }
                    break;
                }
                catch (Exception ex)
                {
                    if (i == 9)
                    {
                        throw ex;
                    }
                }
            }
        }

        // Token: 0x06000009 RID: 9 RVA: 0x0000223C File Offset: 0x0000123C
        static string GoogleTranslate(string chinese)
        {
            string address = "http://www.google.com/translate_t";
            string format = "hl=en&ie=UTF-8&sl=zh-CN&tl=en&text={0}";
            string pattern = "(?<=<div id=result_box dir=\"ltr\">)(.*?)(?=</div>)";
            int num = 20000;
            string[] array = chinese.Split(new char[]
            {
                '\n'
            });
            List<string> list = new List<string>();
            foreach (string text in array)
            {
                if (list.Count == 0)
                {
                    list.Add(text);
                }
                else if (list[list.Count - 1].Length + text.Length < num)
                {
                    list[list.Count - 1] = list[list.Count - 1] + "\n" + text;
                }
                else
                {
                    list.Add(text);
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("");
            using (WebClient webClient = new WebClient())
            {
                foreach (string text2 in list)
                {
                    if (string.IsNullOrEmpty(text2.Trim()))
                    {
                        stringBuilder.AppendLine();
                    }
                    else
                    {
                        webClient.Encoding = Encoding.UTF8;
                        webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                        webClient.Headers.Add("Accept-Encoding", "gzip,deflate");
                        webClient.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
                        string text3 = webClient.UploadString(address, string.Format(format, HttpUtility.HtmlDecode(text2)));
                        Match match = Regex.Match(text3, pattern);
                        if (!match.Success)
                        {
                            throw new Exception("Internet connection failed!\nresponseContent = " + text3);
                        }
                        stringBuilder.AppendLine(HttpUtility.HtmlDecode(match.Value.Replace("<br>", "\n")));
                    }
                }
            }
            return stringBuilder.ToString();
        }

        // Token: 0x0600000A RID: 10 RVA: 0x00002454 File Offset: 0x00001454
        static string YahooTranslate(string chinese)
        {
            string address = "http://babelfish.yahoo.com/translate_txt";
            string format = "btnTrTxt=en&doit=done&ei=UTF-8&fr=bf-res&intl=1&lp=zh_en&trtext={0}&tt=urltext";
            string pattern = "(?<=<div style=\"padding:0.6em;\">)(.*?)(?=</div>)";
            int num = 3000;
            string[] array = chinese.Replace("&nbsp;", " ").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&", "").Split(new char[]
            {
                '\n'
            });
            List<string> list = new List<string>();
            foreach (string text in array)
            {
                if (list.Count == 0)
                {
                    list.Add(text);
                }
                else if (list[list.Count - 1].Length + text.Length < num)
                {
                    list[list.Count - 1] = list[list.Count - 1] + "$NewLine$" + text;
                }
                else
                {
                    list.Add(text);
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("");
            using (WebClient webClient = new WebClient())
            {
                foreach (string text2 in list)
                {
                    if (string.IsNullOrEmpty(text2.Trim()))
                    {
                        stringBuilder.AppendLine();
                    }
                    else
                    {
                        webClient.Encoding = Encoding.UTF8;
                        webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                        webClient.Headers.Add("Accept-Encoding", "gzip,deflate");
                        webClient.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
                        string text3 = webClient.UploadString(address, string.Format(format, HttpUtility.HtmlDecode(text2)));
                        Match match = Regex.Match(text3, pattern);
                        if (!match.Success)
                        {
                            throw new Exception("Internet connection failed!\nresponseContent = " + text3);
                        }
                        stringBuilder.AppendLine(HttpUtility.HtmlDecode(match.Value.Replace("$NewLine$", "\n")));
                    }
                }
            }
            return stringBuilder.ToString();
        }

        // Token: 0x0600000B RID: 11 RVA: 0x000026A8 File Offset: 0x000016A8
        static string SystranetTranslate(string chinese)
        {
            string address = "http://www.systranet.com/tt?gui=local;/snetcom/text/ts&lp=zh_en&MAX_TRANSLATED_WORDS=500000&sessionid=12521648004845373&service=translate";
            string format = "{0}";
            int num = 20000;
            string[] array = chinese.Replace("&nbsp;", " ").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&", "").Split(new char[]
            {
                '\n'
            });
            List<string> list = new List<string>();
            foreach (string text in array)
            {
                if (list.Count == 0)
                {
                    list.Add(text);
                }
                else if (list[list.Count - 1].Length + text.Length < num)
                {
                    list[list.Count - 1] = list[list.Count - 1] + "\n" + text;
                }
                else
                {
                    list.Add(text);
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("");
            using (WebClient webClient = new WebClient())
            {
                foreach (string text2 in list)
                {
                    if (string.IsNullOrEmpty(text2.Trim()))
                    {
                        stringBuilder.AppendLine();
                    }
                    else
                    {
                        webClient.Encoding = Encoding.UTF8;
                        webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                        webClient.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
                        byte[] bytes = webClient.UploadData(address, Encoding.UTF8.GetBytes(string.Format(format, HttpUtility.HtmlDecode(text2))));
                        string @string = Encoding.UTF8.GetString(bytes);
                        if (!@string.Contains("body=\n"))
                        {
                            throw new Exception("Internet connection failed!\nresponseContent = " + @string);
                        }
                        stringBuilder.AppendLine(@string.Substring(@string.IndexOf("body=\n") + "body=\n".Length));
                    }
                }
            }
            return stringBuilder.ToString();
        }

        // Token: 0x0600000C RID: 12 RVA: 0x000028F4 File Offset: 0x000018F4
        static string MicrosoftTranslate(string chinese)
        {
            return new BingOnlineTranslationEngine().ChineseToEnglish(chinese);
        }

        // Token: 0x04000003 RID: 3
        static object lockObject = new object();
    }
}

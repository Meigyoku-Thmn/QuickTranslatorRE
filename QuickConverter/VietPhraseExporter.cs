using System;
using System.IO;
using System.Reflection;
using System.Text;
using QuickTranslatorCore;

namespace QuickConverter
{
    // Token: 0x02000007 RID: 7
    public class VietPhraseExporter
    {
        // Token: 0x06000052 RID: 82 RVA: 0x0000679C File Offset: 0x0000579C
        public static void Export(string content, bool needRemoveBlankLines, string filePath, bool outputToWord)
        {
            string text = needRemoveBlankLines ? content.Replace("\n\n", "\n") : content;
            if (outputToWord)
            {
                loadTemplate();
                text = text.Replace("\t", "");
                text = string.Concat(new string[]
                {
                    BEFORE_PARAGRAPH,
                    PARAGRAPH_START,
                    text.Replace("\n", PARAGRAPH_END + PARAGRAPH_START),
                    PARAGRAPH_END,
                    AFTER_PARAGRAPH
                });
                text = text.Replace("</w:pPr><w:r><w:t><![CDATA[$CHAPTER_HEADER$. ", "<w:jc w:val=\"center\"/><w:rPr><w:b/></w:rPr></w:pPr><w:r><w:rPr><w:b/></w:rPr><w:t><![CDATA[").Replace("$CHAPTER_HEADER$. ", "");
            }
            File.WriteAllText(filePath, text, Encoding.UTF8);
        }

        // Token: 0x06000053 RID: 83 RVA: 0x00006854 File Offset: 0x00005854
        private static void loadTemplate()
        {
            if (templateLoaded)
            {
                return;
            }
            string text = File.ReadAllText(vietPhraseTemplateFilePath);
            BEFORE_PARAGRAPH = text.Substring(0, text.IndexOf("<wx:sect>") + "<wx:sect>".Length + 1);
            string text2 = text.Substring(BEFORE_PARAGRAPH.Length);
            string text3 = text2.Substring(0, text2.IndexOf("</w:p>") + "</w:p>".Length + 1);
            PARAGRAPH_START = text3.Substring(0, text3.IndexOf("{content}")) + "<![CDATA[";
            PARAGRAPH_END = "]]>" + text3.Substring(text3.IndexOf("{content}") + "{content}".Length);
            AFTER_PARAGRAPH = text2.Substring(text3.Length);
            templateLoaded = true;
        }

        // Token: 0x04000046 RID: 70
        private static string BEFORE_PARAGRAPH = "<html><head><meta content=\"text/html; charset=UTF-8\" http-equiv=\"content-type\"/><style>pre {font-family: 'Times New Roman'; font-size: 14pt; word-wrap:break-word;} </style></head><body><pre>";

        // Token: 0x04000047 RID: 71
        private static string AFTER_PARAGRAPH = "</PRE></body></html>";

        // Token: 0x04000048 RID: 72
        private static string PARAGRAPH_START = "";

        // Token: 0x04000049 RID: 73
        private static string PARAGRAPH_END = "";

        // Token: 0x0400004A RID: 74
        private static string vietPhraseTemplateFilePath = Path.Combine(Constants.AssetsDir, "vietPhraseTemplate.doc");

        // Token: 0x0400004B RID: 75
        private static bool templateLoaded = false;
    }
}

using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using QuickTranslatorCore;

namespace QuickConverter
{
    public class ColumnExporter
    {
        public static void Export(string[] columnNames, string[] columnContents, bool needRemoveBlankLines, string filePath)
        {
            if (columnNames.Length != columnContents.Length || columnNames.Length == 0)
                return;
            loadTemplate();
            string[][] array = new string[columnNames.Length][];
            for (int i = 0; i < columnNames.Length; i++)
                array[i] = getLines(columnContents[i], needRemoveBlankLines);
            int maxLineCount = getMaxLineCount(array);
            int num = columnNames.Length;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(HTML_BEFORE_TABLE);
            stringBuilder.Append(HTML_ROW_HEADER_START);
            for (int j = 0; j < num; j++)
                stringBuilder.Append(HTML_CELL_HEADER.Replace("{header}", columnNames[j]));
            stringBuilder.Append(HTML_ROW_HEADER_END);
            for (int k = 0; k < maxLineCount; k++)
            {
                stringBuilder.Append(HTML_ROW_START);
                for (int l = 0; l < num; l++)
                    stringBuilder.Append(HTML_CELL.Replace("{content}", "<![CDATA[" + ((k < array[l].Length) ? array[l][k].Trim() : "") + "]]>"));
                stringBuilder.Append(HTML_ROW_END);
            }
            stringBuilder.Append(HTML_AFTER_TABLE);
            File.WriteAllText(filePath, stringBuilder.ToString(), Encoding.UTF8);
        }

        public static void ExtractFromWord(string wordMLContent, out string chinese, out string viet)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(wordMLContent);
            XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
            xmlNamespaceManager.AddNamespace("w", "http://schemas.microsoft.com/office/word/2003/wordml");
            xmlNamespaceManager.AddNamespace("v", "urn:schemas-microsoft-com:vml");
            xmlNamespaceManager.AddNamespace("w10", "urn:schemas-microsoft-com:office:word");
            xmlNamespaceManager.AddNamespace("sl", "http://schemas.microsoft.com/schemaLibrary/2003/core");
            xmlNamespaceManager.AddNamespace("aml", "http://schemas.microsoft.com/aml/2001/core");
            xmlNamespaceManager.AddNamespace("wx", "http://schemas.microsoft.com/office/word/2003/auxHint");
            xmlNamespaceManager.AddNamespace("o", "urn:schemas-microsoft-com:office:office");
            xmlNamespaceManager.AddNamespace("dt", "uuid:C2F41010-65B3-11d1-A29F-00AA00C14882");
            xmlNamespaceManager.AddNamespace("wsp", "http://schemas.microsoft.com/office/word/2003/wordml/sp2");
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("w:wordDocument/w:body/wx:sect/w:tbl/w:tr", xmlNamespaceManager);
            int num = -1;
            int num2 = -1;
            int count = xmlNodeList[0].ChildNodes.Count;
            for (int i = 0; i < count; i++)
            {
                if (xmlNodeList[0].ChildNodes[i].SelectSingleNode("w:p/w:r/w:t", xmlNamespaceManager).InnerText == "Trung")
                    num = i;
                else if (xmlNodeList[0].ChildNodes[i].SelectSingleNode("w:p/w:r/w:t", xmlNamespaceManager).InnerText == "Việt")
                    num2 = i;
            }
            if (num == -1 && num2 == -1)
            {
                chinese = "";
                viet = "";
                return;
            }
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            int count2 = xmlNodeList.Count;
            for (int j = 1; j < count2; j++)
            {
                stringBuilder.AppendLine(xmlNodeList[j].ChildNodes[num].SelectSingleNode("w:p/w:r/w:t", xmlNamespaceManager).InnerText.Replace("<![CDATA[", "").Replace("]]>", ""));
                stringBuilder2.AppendLine(xmlNodeList[j].ChildNodes[num2].SelectSingleNode("w:p/w:r/w:t", xmlNamespaceManager).InnerText);
            }
            chinese = stringBuilder.ToString();
            viet = stringBuilder2.ToString().Trim(' ', '\n', 't', '\r');
        }

        private static string[] getLines(string content, bool needRemoveBlankLines)
        {
            return content.Split(new [] { '\n' }, needRemoveBlankLines ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None);
        }

        private static int getMaxLineCount(string[][] columnLines)
        {
            int[] array = new int[columnLines.Length];
            for (int i = 0; i < columnLines.Length; i++)
                array[i] = columnLines[i].Length;
            Array.Sort(array);
            return array[array.Length - 1];
        }

        private static void loadTemplate()
        {
            if (templateLoaded)
                return;
            string text = File.ReadAllText(columnTemplateFilePath).Replace("=\r\n", "").Replace("=\n", "");
            HTML_BEFORE_TABLE = text.Substring(0, text.IndexOf("<w:tr"));
            HTML_AFTER_TABLE = text.Substring(text.IndexOf("</w:tbl>"));
            string text2 = text.Substring(text.IndexOf("<w:tr"), text.IndexOf("</w:tbl>") - text.IndexOf("<w:tr"));
            string text3 = text2.Substring(0, text2.IndexOf("</w:tr>"));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in text3)
            {
                stringBuilder.Append(c);
                if (c == '>')
                    break;
            }
            HTML_ROW_HEADER_START = stringBuilder.ToString();
            HTML_ROW_HEADER_END = "</w:tr>";
            HTML_CELL_HEADER = text3.Replace(HTML_ROW_HEADER_START, "").Replace(HTML_ROW_HEADER_END, "");
            HTML_ROW_START = HTML_ROW_HEADER_START;
            HTML_ROW_END = HTML_ROW_HEADER_END;
            string text5 = text2.Substring(text2.IndexOf("</w:tr>") + "</w:tr>".Length);
            text5 = text5.Substring(text5.IndexOf("<w:tr"));
            text5 = text5.Substring(0, text5.IndexOf("</w:tr>") + "</w:tr>".Length);
            HTML_CELL = text5.Replace(HTML_ROW_START, "").Replace(HTML_ROW_END, "");
            templateLoaded = true;
        }

        private static string HTML_BEFORE_TABLE = "<html><head><meta content=\"text/html; charset=UTF-8\" http-equiv=\"content-type\"/><style>table {width: 100%; border-width: 1px; border-style: solid; border-color: black; border-collapse: collapse;} body {font-family: 'Times New Roman'; font-size: 12pt;} th {background-color: #FAF0E6; font-weight: bold;} th, td {border-width: 1px; border-style: solid; border-color: black; padding: 4px; vertical-align: top;}</style></head><body><table>";

        private static string HTML_AFTER_TABLE = "</table></body></html>";

        private static string HTML_ROW_HEADER_START = "<tr>";

        private static string HTML_ROW_HEADER_END = "</tr>";

        private static string HTML_ROW_START = "<tr>";

        private static string HTML_ROW_END = "</tr>";

        private static string HTML_CELL_HEADER = "<td>{header}</td>";

        private static string HTML_CELL = "<td>{content}</td>";

        private static string columnTemplateFilePath = Path.Combine(Constants.AssetsDir, "columnTemplate.doc");

        private static bool templateLoaded = false;
    }
}

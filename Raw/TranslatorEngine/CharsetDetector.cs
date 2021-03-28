using System;
using System.IO;
using org.mozilla.intl.chardet;

namespace TranslatorEngine
{
	// Token: 0x02000004 RID: 4
	public class CharsetDetector
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002174 File Offset: 0x00001174
		public static string DetectChineseCharset(string filePath)
		{
			CharsetDetector.DetectedCharset = "GB2312";
			nsDetector nsDetector = new nsDetector(3);
			Notifier aObserver = new Notifier();
			nsDetector.Init(aObserver);
			byte[] array = new byte[1024];
			int aLen = File.OpenRead(filePath).Read(array, 0, array.Length);
			bool flag = nsDetector.isAscii(array, aLen);
			if (!flag)
			{
				nsDetector.DoIt(array, aLen, false);
			}
			nsDetector.DataEnd();
			if (flag)
			{
				CharsetDetector.DetectedCharset = "ASCII";
			}
			if (File.ReadAllText(filePath).Contains("CONTENT=\"text/html; charset=gb2312\""))
			{
				CharsetDetector.DetectedCharset = "GB2312";
			}
			return CharsetDetector.DetectedCharset;
		}

		// Token: 0x04000003 RID: 3
		public static string DetectedCharset;
	}
}

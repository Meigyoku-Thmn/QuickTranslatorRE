﻿using System;
using System.IO;
using org.mozilla.intl.chardet;

namespace TranslatorEngine
{
	public class CharsetDetector
	{
		public static string DetectedCharset;

		public static string DetectChineseCharset(string filePath)
		{
            DetectedCharset = "GB2312";
			var nsDetector = new nsDetector(3);
			var aObserver = new Notifier();
			nsDetector.Init(aObserver);
			var array = new byte[1024];
			int aLen = File.OpenRead(filePath).Read(array, 0, array.Length);
			var flag = nsDetector.isAscii(array, aLen);
			if (!flag) nsDetector.DoIt(array, aLen, false);
			nsDetector.DataEnd();
			if (flag) DetectedCharset = "ASCII";
			if (File.ReadAllText(filePath).Contains("CONTENT=\"text/html; charset=gb2312\""))
			{
                DetectedCharset = "GB2312";
			}
			return DetectedCharset;
		}
	}
}

using System;
using System.IO;
using NChardet;

namespace QuickTranslatorCore
{
    public class CharsetDetector
    {
        class Observer : ICharsetDetectionObserver
        {
            public string DetectedCharset { get; private set; }
            public Observer(string defaultCharset = Constants.DefaultCharset) => DetectedCharset = defaultCharset;
            public void Notify(string charset) => DetectedCharset = charset;
        }

        /// <summary>
        /// Try to guess charset of file specified by filePath.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string DetectChineseCharset(string filePath)
        {
            // case when input file is html with charset=gb2312 meta
            // TODO: this code is not useful and very naive.
            if (File.ReadAllText(filePath).Contains("CONTENT=\"text/html; charset=gb2312\""))
                return Constants.DefaultCharset;

            var sample = new byte[1024];
            int sampleLen = File.OpenRead(filePath).Read(sample, 0, sample.Length);

            var nsDetector = new Detector(3);
            var observer = new Observer();
            nsDetector.Init(observer);

            if (nsDetector.isAscii(sample, sampleLen))
                return "ASCII";

            nsDetector.DoIt(sample, sampleLen, false);
            nsDetector.DataEnd();

            return observer.DetectedCharset;
        }
    }
}

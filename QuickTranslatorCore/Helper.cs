using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuickTranslatorCore
{
    using StringDict = Dictionary<string, string>;

    public static class Helper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="match"></param>
        /// <param name="startIndex"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static int FindIndex(this string text, Predicate<char> match, int startIndex = 0, int count = -1)
        {
            if (count < 0)
                count = text.Length;

            var idx = 0;
            foreach (var chr in text.Skip(startIndex).Take(count))
            {
                if (match(chr))
                    return idx + startIndex;
                idx++;
            }
            return -1;
        }

        /// <summary>
        /// Copy file from sourceFileName to destFileName if sourceFileName exists. Params are the same as File.Copy
        /// </summary>
        /// <returns>true if successful, false if sourceFileName doesn't exists</returns>
        public static bool CopyIfSourceExists(string sourceFileName, string destFileName, bool overwrite = false)
        {
            try
            {
                File.Copy(sourceFileName, destFileName, true);
                return true;
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is DirectoryNotFoundException)
            {
                return false;
            }
        }

        public static WaitHandle QueueWork(Action callback, bool useDoneEvent = true)
        {
            var doneEvent = useDoneEvent ? new ManualResetEvent(false) : null;
            ThreadPool.QueueUserWorkItem(_ => { callback(); doneEvent?.Set(); });
            return doneEvent;
        }

        public static void AddWork(this ICollection<WaitHandle> handles,
            Action callback, bool useDoneEvent = true)
        {
            handles.Add(QueueWork(callback, useDoneEvent));
        }

        public static IEnumerable<string> Lines(this TextReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
                yield return line;
        }

        public static void LoadDictionary(StringDict dict, string dictPath, bool ignoreComment = false)
        {
            using var textReader = new StreamReader(dictPath, true);

            foreach (var line in textReader.Lines())
            {
                if (ignoreComment == true && line.StartsWith("#"))
                    continue;
                var tuple = line.Split('=');
                if (tuple.Length == 2 && !dict.ContainsKey(tuple[0]))
                    dict.Add(tuple[0], tuple[1]);
            }
        }

        public static StringDict LoadDictionary(this string dictPath, bool ignoreComment = false)
        {
            var dict = new StringDict();
            LoadDictionary(dict, dictPath, ignoreComment);
            return dict;
        }

        public static StringDict LoadCedictAndBabylon(this (string cedictPath, string babylonDictPath) paths)
        {
            var (cedictPath, babylonDictPath) = paths;

            var dict = new StringDict();

            using var reader = new StreamReader(cedictPath, Encoding.UTF8);

            foreach (var line in reader.Lines())
            {
                if (line.StartsWith("#"))
                    continue;

                var tuple = line.Substring(0, line.IndexOf(" ["));
                foreach (string key in tuple.Split(' '))
                {
                    if (!dict.ContainsKey(key))
                        dict.Add(key, line.Substring(line.IndexOf(" [")));
                }
            }

            LoadDictionary(dict, babylonDictPath);

            return dict;
        }
        /// <summary>
        /// Load change log of dictionary specified by dictLogPath, only get the lastest change for an entry
        /// </summary>
        /// <param name="logPath"></param>
        /// <param name="logDataset"></param>
        public static void LoadLog(string logPath, DataSet logDataset)
        {
            logDataset.Clear();

            var tblName = "DictionaryHistory";

            if (!logDataset.Tables.Contains(tblName))
            {
                logDataset.Tables.Add(tblName);

                logDataset.Tables[tblName].Columns.Add("Entry", typeof(string));
                logDataset.Tables[tblName].Columns.Add("Action", typeof(string));
                logDataset.Tables[tblName].Columns.Add("User Name", typeof(string));
                logDataset.Tables[tblName].Columns.Add("Updated Date", typeof(DateTime));

                logDataset.Tables[tblName].PrimaryKey = new[] {
                    logDataset.Tables[tblName].Columns["Entry"]
                };
            }

            if (!File.Exists(logPath))
                return;

            var charset = CharsetDetector.GuessCharsetOfFile(logPath);
            using var reader = new StreamReader(logPath, Encoding.GetEncoding(charset));

            foreach (var line in reader.Lines().Skip(1)) // skip header
            {
                var tuple = line.Split('\t');
                if (tuple.Length != 4)
                    continue;
                var dataRow = logDataset.Tables[tblName].Rows.Find(tuple[0]); // search by key
                if (dataRow == null)
                {
                    logDataset.Tables[tblName].Rows.Add(new object[] {
                        tuple[0],
                        tuple[1],
                        tuple[2],
                        DateTime.ParseExact(tuple[3], "yyyy-MM-dd HH:mm:ss.fffzzz", null)
                    });
                }
                else
                {
                    // only get the lastest change of an entry
                    dataRow[1] = tuple[1];
                    dataRow[2] = tuple[2];
                    dataRow[3] = DateTime.ParseExact(tuple[3], "yyyy-MM-dd HH:mm:ss.fffzzz", null);
                }
            }
        }

    }
}

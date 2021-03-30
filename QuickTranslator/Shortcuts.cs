using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QuickTranslator
{
    public class Shortcuts
    {
        public static void LoadFromFile(string dictPath)
        {
            shortcutDictionary.Clear();
            using (TextReader textReader = new StreamReader(dictPath, true))
            {
                string text;
                while ((text = textReader.ReadLine()) != null)
                {
                    if (text.Split('=').Length == 2)
                    {
                        string text2 = text.Split('=')[0];
                        string value = text.Split('=')[1];
                        if (!shortcutDictionary.ContainsKey(text2.ToLower()))
                        {
                            shortcutDictionary.Add(text2.ToLower(), value);
                        }
                    }
                }
            }
        }

        public static void SaveDictionaryToFile(string dictPath)
        {
            var orderedEnumerable = from pair in shortcutDictionary
                                    orderby pair.Key.Length descending, pair.Key
                                    select pair;
            using (var textWriter = new StreamWriter(dictPath, false, Encoding.UTF8))
            {
                foreach (var keyValuePair in orderedEnumerable)
                {
                    textWriter.WriteLine(keyValuePair.Key + "=" + keyValuePair.Value);
                }
            }
        }

        public static string GetValueFromKey(string key)
        {
            if (shortcutDictionary.ContainsKey(key.ToLower()))
            {
                return shortcutDictionary[key.ToLower()];
            }
            return null;
        }

        private static Dictionary<string, string> shortcutDictionary = new Dictionary<string, string>();
    }
}

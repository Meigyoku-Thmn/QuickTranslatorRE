using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QuickTranslator
{
	// Token: 0x02000018 RID: 24
	public class Shortcuts
	{
		// Token: 0x06000141 RID: 321 RVA: 0x000117C0 File Offset: 0x000107C0
		public static void LoadFromFile(string dictPath)
		{
			Shortcuts.shortcutDictionary.Clear();
			using (TextReader textReader = new StreamReader(dictPath, true))
			{
				string text;
				while ((text = textReader.ReadLine()) != null)
				{
					if (text.Split(new char[]
					{
						'='
					}).Length == 2)
					{
						string text2 = text.Split(new char[]
						{
							'='
						})[0];
						string value = text.Split(new char[]
						{
							'='
						})[1];
						if (!Shortcuts.shortcutDictionary.ContainsKey(text2.ToLower()))
						{
							Shortcuts.shortcutDictionary.Add(text2.ToLower(), value);
						}
					}
				}
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00011898 File Offset: 0x00010898
		public static void SaveDictionaryToFile(string dictPath)
		{
			IOrderedEnumerable<KeyValuePair<string, string>> orderedEnumerable = from pair in Shortcuts.shortcutDictionary
			orderby pair.Key.Length descending, pair.Key
			select pair;
			using (TextWriter textWriter = new StreamWriter(dictPath, false, Encoding.UTF8))
			{
				foreach (KeyValuePair<string, string> keyValuePair in orderedEnumerable)
				{
					textWriter.WriteLine(keyValuePair.Key + "=" + keyValuePair.Value);
				}
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00011968 File Offset: 0x00010968
		public static string GetValueFromKey(string key)
		{
			if (Shortcuts.shortcutDictionary.ContainsKey(key.ToLower()))
			{
				return Shortcuts.shortcutDictionary[key.ToLower()];
			}
			return null;
		}

		// Token: 0x0400015A RID: 346
		private static Dictionary<string, string> shortcutDictionary = new Dictionary<string, string>();
	}
}

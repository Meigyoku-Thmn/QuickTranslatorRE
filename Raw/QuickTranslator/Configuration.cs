using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuickTranslator
{
	// Token: 0x02000002 RID: 2
	[Serializable]
	public class Configuration
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002268 File Offset: 0x00001268
		public static Configuration LoadFromFile(string configFilePath)
		{
			if (!File.Exists(configFilePath))
			{
				return new Configuration();
			}
			Stream stream = null;
			Configuration result = null;
			try
			{
				IFormatter formatter = new BinaryFormatter();
				stream = new FileStream(configFilePath, FileMode.Open, FileAccess.Read, FileShare.None);
				int num = (int)formatter.Deserialize(stream);
				result = (Configuration)formatter.Deserialize(stream);
			}
			finally
			{
				if (stream != null)
				{
					stream.Close();
				}
			}
			return result;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000022D0 File Offset: 0x000012D0
		public void SaveToFile(string configFilePath)
		{
			Stream stream = null;
			try
			{
				IFormatter formatter = new BinaryFormatter();
				stream = new FileStream(configFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
				formatter.Serialize(stream, 1);
				formatter.Serialize(stream, this);
			}
			finally
			{
				if (stream != null)
				{
					stream.Close();
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private const int VERSION = 1;

		// Token: 0x04000002 RID: 2
		public bool BrowserPanel_DisableImages;

		// Token: 0x04000003 RID: 3
		public bool BrowserPanel_DisablePopups;

		// Token: 0x04000004 RID: 4
		public int VietPhrase_Wrap = 1;

		// Token: 0x04000005 RID: 5
		public int VietPhraseOneMeaning_Wrap = 1;

		// Token: 0x04000006 RID: 6
		public char HotKeys_CopyHighlightedHanViet = '0';

		// Token: 0x04000007 RID: 7
		public char HotKeys_CopyMeaning1 = '1';

		// Token: 0x04000008 RID: 8
		public char HotKeys_CopyMeaning2 = '2';

		// Token: 0x04000009 RID: 9
		public char HotKeys_CopyMeaning3 = '3';

		// Token: 0x0400000A RID: 10
		public char HotKeys_CopyMeaning4 = '4';

		// Token: 0x0400000B RID: 11
		public char HotKeys_CopyMeaning5 = '5';

		// Token: 0x0400000C RID: 12
		public char HotKeys_CopyMeaning6 = '6';

		// Token: 0x0400000D RID: 13
		public char HotKeys_MoveDownOneLine = 'M';

		// Token: 0x0400000E RID: 14
		public char HotKeys_MoveDownOneParagraph = 'N';

		// Token: 0x0400000F RID: 15
		public char HotKeys_MoveLeftOneWord = 'J';

		// Token: 0x04000010 RID: 16
		public char HotKeys_MoveRightOneWord = 'K';

		// Token: 0x04000011 RID: 17
		public char HotKeys_MoveUpOneLine = 'I';

		// Token: 0x04000012 RID: 18
		public char HotKeys_MoveUpOneParagraph = 'U';

		// Token: 0x04000013 RID: 19
		public string HotKeys_F1 = "";

		// Token: 0x04000014 RID: 20
		public string HotKeys_F2 = "";

		// Token: 0x04000015 RID: 21
		public string HotKeys_F3 = "";

		// Token: 0x04000016 RID: 22
		public string HotKeys_F4 = "";

		// Token: 0x04000017 RID: 23
		public string HotKeys_F5 = "";

		// Token: 0x04000018 RID: 24
		public string HotKeys_F6 = "";

		// Token: 0x04000019 RID: 25
		public string HotKeys_F7 = "";

		// Token: 0x0400001A RID: 26
		public string HotKeys_F8 = "";

		// Token: 0x0400001B RID: 27
		public string HotKeys_F9 = "";

		// Token: 0x0400001C RID: 28
		public bool Layout_VietPhrase = true;

		// Token: 0x0400001D RID: 29
		public bool Layout_VietPhraseOneMeaning = true;

		// Token: 0x0400001E RID: 30
		public Font Style_TrungFont = new Font("Arial Unicode MS", 14f);

		// Token: 0x0400001F RID: 31
		public Font Style_HanVietFont = new Font("Arial Unicode MS", 12f);

		// Token: 0x04000020 RID: 32
		public Font Style_VietPhraseFont = new Font("Arial Unicode MS", 12f);

		// Token: 0x04000021 RID: 33
		public Font Style_VietPhraseOneMeaningFont = new Font("Arial Unicode MS", 12f);

		// Token: 0x04000022 RID: 34
		public Font Style_VietFont = new Font("Arial Unicode MS", 12f);

		// Token: 0x04000023 RID: 35
		public Font Style_NghiaFont = new Font("Arial Unicode MS", 12f);

		// Token: 0x04000024 RID: 36
		public Color Style_TrungForeColor = default(Color);

		// Token: 0x04000025 RID: 37
		public Color Style_HanVietForeColor = default(Color);

		// Token: 0x04000026 RID: 38
		public Color Style_VietPhraseForeColor = default(Color);

		// Token: 0x04000027 RID: 39
		public Color Style_VietPhraseOneMeaningForeColor = default(Color);

		// Token: 0x04000028 RID: 40
		public Color Style_VietForeColor = default(Color);

		// Token: 0x04000029 RID: 41
		public Color Style_NghiaForeColor = default(Color);

		// Token: 0x0400002A RID: 42
		public Color Style_TrungBackColor = default(Color);

		// Token: 0x0400002B RID: 43
		public Color Style_HanVietBackColor = default(Color);

		// Token: 0x0400002C RID: 44
		public Color Style_VietPhraseBackColor = default(Color);

		// Token: 0x0400002D RID: 45
		public Color Style_VietPhraseOneMeaningBackColor = default(Color);

		// Token: 0x0400002E RID: 46
		public Color Style_VietBackColor = default(Color);

		// Token: 0x0400002F RID: 47
		public Color Style_NghiaBackColor = default(Color);

		// Token: 0x04000030 RID: 48
		public int TranslationAlgorithm;

		// Token: 0x04000031 RID: 49
		public bool PrioritizedName = true;

		// Token: 0x04000032 RID: 50
		public bool AlwaysFocusInViet = true;
	}
}

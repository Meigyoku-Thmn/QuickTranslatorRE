using System;

namespace TranslatorEngine
{
	// Token: 0x02000003 RID: 3
	public class CharRange
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002108 File Offset: 0x00001108
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002110 File Offset: 0x00001110
		public int StartIndex
		{
			get
			{
				return this.startIndex;
			}
			set
			{
				this.startIndex = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002119 File Offset: 0x00001119
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002121 File Offset: 0x00001121
		public int Length
		{
			get
			{
				return this.length;
			}
			set
			{
				this.length = value;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000212A File Offset: 0x0000112A
		public CharRange(int startIndex, int length)
		{
			this.startIndex = startIndex;
			this.length = length;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002140 File Offset: 0x00001140
		public bool IsInRange(int index)
		{
			return this.startIndex <= index && index <= this.startIndex + this.length - 1;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002162 File Offset: 0x00001162
		public int GetEndIndex()
		{
			return this.startIndex + this.length - 1;
		}

		// Token: 0x04000001 RID: 1
		private int startIndex;

		// Token: 0x04000002 RID: 2
		private int length;
	}
}

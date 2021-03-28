using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000009 RID: 9
	public abstract class nsEUCStatistics
	{
		// Token: 0x0600002A RID: 42
		public abstract float[] mFirstByteFreq();

		// Token: 0x0600002B RID: 43
		public abstract float mFirstByteStdDev();

		// Token: 0x0600002C RID: 44
		public abstract float mFirstByteMean();

		// Token: 0x0600002D RID: 45
		public abstract float mFirstByteWeight();

		// Token: 0x0600002E RID: 46
		public abstract float[] mSecondByteFreq();

		// Token: 0x0600002F RID: 47
		public abstract float mSecondByteStdDev();

		// Token: 0x06000030 RID: 48
		public abstract float mSecondByteMean();

		// Token: 0x06000031 RID: 49
		public abstract float mSecondByteWeight();

		// Token: 0x06000032 RID: 50 RVA: 0x0000296E File Offset: 0x0000196E
		public nsEUCStatistics()
		{
		}
	}
}

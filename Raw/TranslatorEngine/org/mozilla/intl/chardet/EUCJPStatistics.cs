using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200000B RID: 11
	public class EUCJPStatistics : nsEUCStatistics
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00002D1D File Offset: 0x00001D1D
		public override float[] mFirstByteFreq()
		{
			return EUCJPStatistics.m_FirstByteFreq;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002D24 File Offset: 0x00001D24
		public override float mFirstByteStdDev()
		{
			return EUCJPStatistics.m_FirstByteStdDev;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002D2B File Offset: 0x00001D2B
		public override float mFirstByteMean()
		{
			return EUCJPStatistics.m_FirstByteMean;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002D32 File Offset: 0x00001D32
		public override float mFirstByteWeight()
		{
			return EUCJPStatistics.m_FirstByteWeight;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002D39 File Offset: 0x00001D39
		public override float[] mSecondByteFreq()
		{
			return EUCJPStatistics.m_SecondByteFreq;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002D40 File Offset: 0x00001D40
		public override float mSecondByteStdDev()
		{
			return EUCJPStatistics.m_SecondByteStdDev;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002D47 File Offset: 0x00001D47
		public override float mSecondByteMean()
		{
			return EUCJPStatistics.m_SecondByteMean;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002D4E File Offset: 0x00001D4E
		public override float mSecondByteWeight()
		{
			return EUCJPStatistics.m_SecondByteWeight;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003048 File Offset: 0x00002048
		public EUCJPStatistics()
		{
			EUCJPStatistics.m_FirstByteFreq = new float[]
			{
				0.364808f,
				0f,
				0f,
				0.145325f,
				0.304891f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0.001835f,
				0.010771f,
				0.006462f,
				0.001157f,
				0.002114f,
				0.003231f,
				0.001356f,
				0.00742f,
				0.004189f,
				0.003231f,
				0.003032f,
				0.03319f,
				0.006303f,
				0.006064f,
				0.009973f,
				0.002354f,
				0.00367f,
				0.009135f,
				0.001675f,
				0.002792f,
				0.002194f,
				0.01472f,
				0.011928f,
				0.000878f,
				0.013124f,
				0.001077f,
				0.009295f,
				0.003471f,
				0.002872f,
				0.002433f,
				0.000957f,
				0.001636f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				8E-05f,
				0.000279f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				8E-05f,
				0f
			};
			EUCJPStatistics.m_FirstByteStdDev = 0.050407f;
			EUCJPStatistics.m_FirstByteMean = 0.010638f;
			EUCJPStatistics.m_FirstByteWeight = 0.640871f;
			EUCJPStatistics.m_SecondByteFreq = new float[]
			{
				0.002473f,
				0.039134f,
				0.152745f,
				0.009694f,
				0.000359f,
				0.02218f,
				0.000758f,
				0.004308f,
				0.00016f,
				0.002513f,
				0.003072f,
				0.001316f,
				0.00383f,
				0.001037f,
				0.00359f,
				0.000957f,
				0.00016f,
				0.000239f,
				0.006462f,
				0.001596f,
				0.031554f,
				0.001316f,
				0.002194f,
				0.016555f,
				0.003271f,
				0.000678f,
				0.000598f,
				0.206438f,
				0.000718f,
				0.001077f,
				0.00371f,
				0.001356f,
				0.001356f,
				0.000439f,
				0.004388f,
				0.005704f,
				0.000878f,
				0.010172f,
				0.007061f,
				0.01468f,
				0.000638f,
				0.02573f,
				0.002792f,
				0.000718f,
				0.001795f,
				0.091551f,
				0.000758f,
				0.003909f,
				0.000558f,
				0.031195f,
				0.007061f,
				0.001316f,
				0.022579f,
				0.006981f,
				0.00726f,
				0.001117f,
				0.000239f,
				0.012127f,
				0.000878f,
				0.00379f,
				0.001077f,
				0.000758f,
				0.002114f,
				0.002234f,
				0.000678f,
				0.002992f,
				0.003311f,
				0.023416f,
				0.001237f,
				0.002753f,
				0.005146f,
				0.002194f,
				0.007021f,
				0.008497f,
				0.013763f,
				0.011768f,
				0.006303f,
				0.001915f,
				0.000638f,
				0.008776f,
				0.000918f,
				0.003431f,
				0.057603f,
				0.000439f,
				0.000439f,
				0.000758f,
				0.002872f,
				0.001675f,
				0.01105f,
				0f,
				0.000279f,
				0.012127f,
				0.000718f,
				0.00738f
			};
			EUCJPStatistics.m_SecondByteStdDev = 0.028247f;
			EUCJPStatistics.m_SecondByteMean = 0.010638f;
			EUCJPStatistics.m_SecondByteWeight = 0.359129f;
		}

		// Token: 0x04000013 RID: 19
		private static float[] m_FirstByteFreq;

		// Token: 0x04000014 RID: 20
		private static float m_FirstByteStdDev;

		// Token: 0x04000015 RID: 21
		private static float m_FirstByteMean;

		// Token: 0x04000016 RID: 22
		private static float m_FirstByteWeight;

		// Token: 0x04000017 RID: 23
		private static float[] m_SecondByteFreq;

		// Token: 0x04000018 RID: 24
		private static float m_SecondByteStdDev;

		// Token: 0x04000019 RID: 25
		private static float m_SecondByteMean;

		// Token: 0x0400001A RID: 26
		private static float m_SecondByteWeight;
	}
}

using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200000E RID: 14
	public class GB2312Statistics : nsEUCStatistics
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00003815 File Offset: 0x00002815
		public override float[] mFirstByteFreq()
		{
			return GB2312Statistics.m_FirstByteFreq;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000381C File Offset: 0x0000281C
		public override float mFirstByteStdDev()
		{
			return GB2312Statistics.m_FirstByteStdDev;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003823 File Offset: 0x00002823
		public override float mFirstByteMean()
		{
			return GB2312Statistics.m_FirstByteMean;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000382A File Offset: 0x0000282A
		public override float mFirstByteWeight()
		{
			return GB2312Statistics.m_FirstByteWeight;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003831 File Offset: 0x00002831
		public override float[] mSecondByteFreq()
		{
			return GB2312Statistics.m_SecondByteFreq;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003838 File Offset: 0x00002838
		public override float mSecondByteStdDev()
		{
			return GB2312Statistics.m_SecondByteStdDev;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000383F File Offset: 0x0000283F
		public override float mSecondByteMean()
		{
			return GB2312Statistics.m_SecondByteMean;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003846 File Offset: 0x00002846
		public override float mSecondByteWeight()
		{
			return GB2312Statistics.m_SecondByteWeight;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003B40 File Offset: 0x00002B40
		public GB2312Statistics()
		{
			GB2312Statistics.m_FirstByteFreq = new float[]
			{
				0.011628f,
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
				0.011628f,
				0.012403f,
				0.009302f,
				0.003876f,
				0.017829f,
				0.037209f,
				0.008527f,
				0.010078f,
				0.01938f,
				0.054264f,
				0.010078f,
				0.041085f,
				0.02093f,
				0.018605f,
				0.010078f,
				0.013178f,
				0.016279f,
				0.006202f,
				0.009302f,
				0.017054f,
				0.011628f,
				0.008527f,
				0.004651f,
				0.006202f,
				0.017829f,
				0.024806f,
				0.020155f,
				0.013953f,
				0.032558f,
				0.035659f,
				0.068217f,
				0.010853f,
				0.036434f,
				0.117054f,
				0.027907f,
				0.100775f,
				0.010078f,
				0.017829f,
				0.062016f,
				0.012403f,
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
				0.00155f,
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
				0f
			};
			GB2312Statistics.m_FirstByteStdDev = 0.020081f;
			GB2312Statistics.m_FirstByteMean = 0.010638f;
			GB2312Statistics.m_FirstByteWeight = 0.586533f;
			GB2312Statistics.m_SecondByteFreq = new float[]
			{
				0.006202f,
				0.031008f,
				0.005426f,
				0.003101f,
				0.00155f,
				0.003101f,
				0.082171f,
				0.014729f,
				0.006977f,
				0.00155f,
				0.013953f,
				0f,
				0.013953f,
				0.010078f,
				0.008527f,
				0.006977f,
				0.004651f,
				0.003101f,
				0.003101f,
				0.003101f,
				0.008527f,
				0.003101f,
				0.005426f,
				0.005426f,
				0.005426f,
				0.003101f,
				0.00155f,
				0.006202f,
				0.014729f,
				0.010853f,
				0f,
				0.011628f,
				0f,
				0.031783f,
				0.013953f,
				0.030233f,
				0.039535f,
				0.008527f,
				0.015504f,
				0f,
				0.003101f,
				0.008527f,
				0.016279f,
				0.005426f,
				0.00155f,
				0.013953f,
				0.013953f,
				0.044961f,
				0.003101f,
				0.004651f,
				0.006977f,
				0.00155f,
				0.005426f,
				0.012403f,
				0.00155f,
				0.015504f,
				0f,
				0.006202f,
				0.00155f,
				0f,
				0.007752f,
				0.006977f,
				0.00155f,
				0.009302f,
				0.011628f,
				0.004651f,
				0.010853f,
				0.012403f,
				0.017829f,
				0.005426f,
				0.024806f,
				0f,
				0.006202f,
				0f,
				0.082171f,
				0.015504f,
				0.004651f,
				0f,
				0.006977f,
				0.004651f,
				0f,
				0.008527f,
				0.012403f,
				0.004651f,
				0.003876f,
				0.003101f,
				0.022481f,
				0.024031f,
				0.00155f,
				0.047287f,
				0.009302f,
				0.00155f,
				0.005426f,
				0.017054f
			};
			GB2312Statistics.m_SecondByteStdDev = 0.014156f;
			GB2312Statistics.m_SecondByteMean = 0.010638f;
			GB2312Statistics.m_SecondByteWeight = 0.413467f;
		}

		// Token: 0x0400002B RID: 43
		private static float[] m_FirstByteFreq;

		// Token: 0x0400002C RID: 44
		private static float m_FirstByteStdDev;

		// Token: 0x0400002D RID: 45
		private static float m_FirstByteMean;

		// Token: 0x0400002E RID: 46
		private static float m_FirstByteWeight;

		// Token: 0x0400002F RID: 47
		private static float[] m_SecondByteFreq;

		// Token: 0x04000030 RID: 48
		private static float m_SecondByteStdDev;

		// Token: 0x04000031 RID: 49
		private static float m_SecondByteMean;

		// Token: 0x04000032 RID: 50
		private static float m_SecondByteWeight;
	}
}

using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200000D RID: 13
	public class EUCTWStatistics : nsEUCStatistics
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000346D File Offset: 0x0000246D
		public override float[] mFirstByteFreq()
		{
			return EUCTWStatistics.m_FirstByteFreq;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003474 File Offset: 0x00002474
		public override float mFirstByteStdDev()
		{
			return EUCTWStatistics.m_FirstByteStdDev;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000347B File Offset: 0x0000247B
		public override float mFirstByteMean()
		{
			return EUCTWStatistics.m_FirstByteMean;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003482 File Offset: 0x00002482
		public override float mFirstByteWeight()
		{
			return EUCTWStatistics.m_FirstByteWeight;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003489 File Offset: 0x00002489
		public override float[] mSecondByteFreq()
		{
			return EUCTWStatistics.m_SecondByteFreq;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003490 File Offset: 0x00002490
		public override float mSecondByteStdDev()
		{
			return EUCTWStatistics.m_SecondByteStdDev;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003497 File Offset: 0x00002497
		public override float mSecondByteMean()
		{
			return EUCTWStatistics.m_SecondByteMean;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000349E File Offset: 0x0000249E
		public override float mSecondByteWeight()
		{
			return EUCTWStatistics.m_SecondByteWeight;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003798 File Offset: 0x00002798
		public EUCTWStatistics()
		{
			EUCTWStatistics.m_FirstByteFreq = new float[]
			{
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
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0.119286f,
				0.052233f,
				0.044126f,
				0.052494f,
				0.045906f,
				0.019038f,
				0.032465f,
				0.026252f,
				0.025502f,
				0.015963f,
				0.052493f,
				0.019256f,
				0.015137f,
				0.031782f,
				0.01737f,
				0.018494f,
				0.015575f,
				0.016621f,
				0.007444f,
				0.011642f,
				0.013916f,
				0.019159f,
				0.016445f,
				0.007851f,
				0.011079f,
				0.022842f,
				0.015513f,
				0.010033f,
				0.00995f,
				0.010347f,
				0.013103f,
				0.015371f,
				0.012502f,
				0.007436f,
				0.018253f,
				0.014134f,
				0.008907f,
				0.005411f,
				0.00957f,
				0.013598f,
				0.006092f,
				0.007409f,
				0.008432f,
				0.005816f,
				0.009349f,
				0.005472f,
				0.00717f,
				0.00742f,
				0.003681f,
				0.007523f,
				0.00461f,
				0.006154f,
				0.003348f,
				0.005074f,
				0.005922f,
				0.005254f,
				0.004682f,
				0.002093f,
				0f
			};
			EUCTWStatistics.m_FirstByteStdDev = 0.016681f;
			EUCTWStatistics.m_FirstByteMean = 0.010638f;
			EUCTWStatistics.m_FirstByteWeight = 0.715599f;
			EUCTWStatistics.m_SecondByteFreq = new float[]
			{
				0.028933f,
				0.011371f,
				0.011053f,
				0.007232f,
				0.010192f,
				0.004093f,
				0.015043f,
				0.011752f,
				0.022387f,
				0.00841f,
				0.012448f,
				0.007473f,
				0.003594f,
				0.007139f,
				0.018912f,
				0.006083f,
				0.003302f,
				0.010215f,
				0.008791f,
				0.024236f,
				0.014107f,
				0.014108f,
				0.010303f,
				0.009728f,
				0.007877f,
				0.009719f,
				0.007952f,
				0.021028f,
				0.005764f,
				0.009341f,
				0.006591f,
				0.012517f,
				0.005921f,
				0.008982f,
				0.008771f,
				0.012802f,
				0.005926f,
				0.008342f,
				0.003086f,
				0.006843f,
				0.007576f,
				0.004734f,
				0.016404f,
				0.008803f,
				0.008071f,
				0.005349f,
				0.008566f,
				0.01084f,
				0.015401f,
				0.031904f,
				0.00867f,
				0.011479f,
				0.010936f,
				0.007617f,
				0.008995f,
				0.008114f,
				0.008658f,
				0.005934f,
				0.010452f,
				0.009142f,
				0.004519f,
				0.008339f,
				0.007476f,
				0.007027f,
				0.006025f,
				0.021804f,
				0.024248f,
				0.015895f,
				0.003768f,
				0.010171f,
				0.010007f,
				0.010178f,
				0.008316f,
				0.006832f,
				0.006364f,
				0.009141f,
				0.009148f,
				0.012081f,
				0.011914f,
				0.004464f,
				0.014257f,
				0.006907f,
				0.011292f,
				0.018622f,
				0.008149f,
				0.004636f,
				0.006612f,
				0.013478f,
				0.012614f,
				0.005186f,
				0.048285f,
				0.006816f,
				0.006743f,
				0.008671f
			};
			EUCTWStatistics.m_SecondByteStdDev = 0.00663f;
			EUCTWStatistics.m_SecondByteMean = 0.010638f;
			EUCTWStatistics.m_SecondByteWeight = 0.284401f;
		}

		// Token: 0x04000023 RID: 35
		private static float[] m_FirstByteFreq;

		// Token: 0x04000024 RID: 36
		private static float m_FirstByteStdDev;

		// Token: 0x04000025 RID: 37
		private static float m_FirstByteMean;

		// Token: 0x04000026 RID: 38
		private static float m_FirstByteWeight;

		// Token: 0x04000027 RID: 39
		private static float[] m_SecondByteFreq;

		// Token: 0x04000028 RID: 40
		private static float m_SecondByteStdDev;

		// Token: 0x04000029 RID: 41
		private static float m_SecondByteMean;

		// Token: 0x0400002A RID: 42
		private static float m_SecondByteWeight;
	}
}

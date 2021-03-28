using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200000C RID: 12
	public class EUCKRStatistics : nsEUCStatistics
	{
		// Token: 0x06000045 RID: 69 RVA: 0x000030C5 File Offset: 0x000020C5
		public override float[] mFirstByteFreq()
		{
			return EUCKRStatistics.m_FirstByteFreq;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000030CC File Offset: 0x000020CC
		public override float mFirstByteStdDev()
		{
			return EUCKRStatistics.m_FirstByteStdDev;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000030D3 File Offset: 0x000020D3
		public override float mFirstByteMean()
		{
			return EUCKRStatistics.m_FirstByteMean;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000030DA File Offset: 0x000020DA
		public override float mFirstByteWeight()
		{
			return EUCKRStatistics.m_FirstByteWeight;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000030E1 File Offset: 0x000020E1
		public override float[] mSecondByteFreq()
		{
			return EUCKRStatistics.m_SecondByteFreq;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000030E8 File Offset: 0x000020E8
		public override float mSecondByteStdDev()
		{
			return EUCKRStatistics.m_SecondByteStdDev;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000030EF File Offset: 0x000020EF
		public override float mSecondByteMean()
		{
			return EUCKRStatistics.m_SecondByteMean;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000030F6 File Offset: 0x000020F6
		public override float mSecondByteWeight()
		{
			return EUCKRStatistics.m_SecondByteWeight;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000033F0 File Offset: 0x000023F0
		public EUCKRStatistics()
		{
			EUCKRStatistics.m_FirstByteFreq = new float[]
			{
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0.000412f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0f,
				0.057502f,
				0.033182f,
				0.002267f,
				0.016076f,
				0.014633f,
				0.032976f,
				0.004122f,
				0.011336f,
				0.058533f,
				0.024526f,
				0.025969f,
				0.054411f,
				0.01958f,
				0.063273f,
				0.113974f,
				0.029885f,
				0.150041f,
				0.059151f,
				0.002679f,
				0.009893f,
				0.014839f,
				0.026381f,
				0.015045f,
				0.069456f,
				0.08986f,
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
			EUCKRStatistics.m_FirstByteStdDev = 0.025593f;
			EUCKRStatistics.m_FirstByteMean = 0.010638f;
			EUCKRStatistics.m_FirstByteWeight = 0.647437f;
			EUCKRStatistics.m_SecondByteFreq = new float[]
			{
				0.016694f,
				0f,
				0.012778f,
				0.030091f,
				0.002679f,
				0.006595f,
				0.001855f,
				0.000824f,
				0.005977f,
				0.00474f,
				0.003092f,
				0.000824f,
				0.01958f,
				0.037304f,
				0.008244f,
				0.014633f,
				0.001031f,
				0f,
				0.003298f,
				0.002061f,
				0.006183f,
				0.005977f,
				0.000824f,
				0.021847f,
				0.014839f,
				0.052968f,
				0.017312f,
				0.007626f,
				0.000412f,
				0.000824f,
				0.011129f,
				0f,
				0.000412f,
				0.001649f,
				0.005977f,
				0.065746f,
				0.020198f,
				0.021434f,
				0.014633f,
				0.004122f,
				0.001649f,
				0.000824f,
				0.000824f,
				0.051937f,
				0.01958f,
				0.023289f,
				0.026381f,
				0.040396f,
				0.009068f,
				0.001443f,
				0.00371f,
				0.00742f,
				0.001443f,
				0.01319f,
				0.002885f,
				0.000412f,
				0.003298f,
				0.025969f,
				0.000412f,
				0.000412f,
				0.006183f,
				0.003298f,
				0.066983f,
				0.002679f,
				0.002267f,
				0.011129f,
				0.000412f,
				0.010099f,
				0.015251f,
				0.007626f,
				0.043899f,
				0.00371f,
				0.002679f,
				0.001443f,
				0.010923f,
				0.002885f,
				0.009068f,
				0.019992f,
				0.000412f,
				0.00845f,
				0.005153f,
				0f,
				0.010099f,
				0f,
				0.001649f,
				0.01216f,
				0.011542f,
				0.006595f,
				0.001855f,
				0.010923f,
				0.000412f,
				0.023702f,
				0.00371f,
				0.001855f
			};
			EUCKRStatistics.m_SecondByteStdDev = 0.013937f;
			EUCKRStatistics.m_SecondByteMean = 0.010638f;
			EUCKRStatistics.m_SecondByteWeight = 0.352563f;
		}

		// Token: 0x0400001B RID: 27
		private static float[] m_FirstByteFreq;

		// Token: 0x0400001C RID: 28
		private static float m_FirstByteStdDev;

		// Token: 0x0400001D RID: 29
		private static float m_FirstByteMean;

		// Token: 0x0400001E RID: 30
		private static float m_FirstByteWeight;

		// Token: 0x0400001F RID: 31
		private static float[] m_SecondByteFreq;

		// Token: 0x04000020 RID: 32
		private static float m_SecondByteStdDev;

		// Token: 0x04000021 RID: 33
		private static float m_SecondByteMean;

		// Token: 0x04000022 RID: 34
		private static float m_SecondByteWeight;
	}
}

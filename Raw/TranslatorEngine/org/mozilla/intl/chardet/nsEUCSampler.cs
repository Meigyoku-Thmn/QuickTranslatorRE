using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000017 RID: 23
	public class nsEUCSampler
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00004DE8 File Offset: 0x00003DE8
		public nsEUCSampler()
		{
			this.Reset();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004E40 File Offset: 0x00003E40
		public void Reset()
		{
			this.mTotal = 0;
			this.mState = 0;
			for (int i = 0; i < 94; i++)
			{
				this.mFirstByteCnt[i] = (this.mSecondByteCnt[i] = 0);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004E7C File Offset: 0x00003E7C
		public bool EnoughData()
		{
			return this.mTotal > this.mThreshold;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004E8C File Offset: 0x00003E8C
		public bool GetSomeData()
		{
			return this.mTotal > 1;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004E98 File Offset: 0x00003E98
		public bool Sample(byte[] aIn, int aLen)
		{
			if (this.mState == 1)
			{
				return false;
			}
			int num = 0;
			int num2 = 0;
			while (num2 < aLen && 1 != this.mState)
			{
				switch (this.mState)
				{
				case 0:
					if ((aIn[num] & 128) != 0)
					{
						if (255 == (255 & aIn[num]) || 161 > (255 & aIn[num]))
						{
							this.mState = 1;
						}
						else
						{
							this.mTotal++;
							this.mFirstByteCnt[(int)((byte.MaxValue & aIn[num]) - 161)]++;
							this.mState = 2;
						}
					}
					break;
				case 1:
					break;
				case 2:
					if ((aIn[num] & 128) != 0)
					{
						if (255 == (255 & aIn[num]) || 161 > (255 & aIn[num]))
						{
							this.mState = 1;
						}
						else
						{
							this.mTotal++;
							this.mSecondByteCnt[(int)((byte.MaxValue & aIn[num]) - 161)]++;
							this.mState = 0;
						}
					}
					else
					{
						this.mState = 1;
					}
					break;
				default:
					this.mState = 1;
					break;
				}
				num2++;
				num++;
			}
			return 1 != this.mState;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004FF8 File Offset: 0x00003FF8
		public void CalFreq()
		{
			for (int i = 0; i < 94; i++)
			{
				this.mFirstByteFreq[i] = (float)this.mFirstByteCnt[i] / (float)this.mTotal;
				this.mSecondByteFreq[i] = (float)this.mSecondByteCnt[i] / (float)this.mTotal;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00005044 File Offset: 0x00004044
		public float GetScore(float[] aFirstByteFreq, float aFirstByteWeight, float[] aSecondByteFreq, float aSecondByteWeight)
		{
			return aFirstByteWeight * this.GetScore(aFirstByteFreq, this.mFirstByteFreq) + aSecondByteWeight * this.GetScore(aSecondByteFreq, this.mSecondByteFreq);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005068 File Offset: 0x00004068
		public float GetScore(float[] array1, float[] array2)
		{
			float num = 0f;
			for (int i = 0; i < 94; i++)
			{
				float num2 = array1[i] - array2[i];
				num += num2 * num2;
			}
			return (float)Math.Sqrt((double)num) / 94f;
		}

		// Token: 0x0400005D RID: 93
		private int mTotal;

		// Token: 0x0400005E RID: 94
		private int mThreshold = 200;

		// Token: 0x0400005F RID: 95
		private int mState;

		// Token: 0x04000060 RID: 96
		public int[] mFirstByteCnt = new int[94];

		// Token: 0x04000061 RID: 97
		public int[] mSecondByteCnt = new int[94];

		// Token: 0x04000062 RID: 98
		public float[] mFirstByteFreq = new float[94];

		// Token: 0x04000063 RID: 99
		public float[] mSecondByteFreq = new float[94];
	}
}

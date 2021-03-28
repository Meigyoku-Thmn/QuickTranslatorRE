using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000012 RID: 18
	public abstract class nsPSMDetector
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00004069 File Offset: 0x00003069
		public nsPSMDetector()
		{
			this.initVerifiers(0);
			this.Reset();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000040A3 File Offset: 0x000030A3
		public nsPSMDetector(int langFlag)
		{
			this.initVerifiers(langFlag);
			this.Reset();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000040E0 File Offset: 0x000030E0
		public nsPSMDetector(int aItems, nsVerifier[] aVerifierSet, nsEUCStatistics[] aStatisticsSet)
		{
			this.mClassRunSampler = (aStatisticsSet != null);
			this.mStatisticsData = aStatisticsSet;
			this.mVerifier = aVerifierSet;
			this.mClassItems = aItems;
			this.Reset();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004140 File Offset: 0x00003140
		public void Reset()
		{
			this.mRunSampler = this.mClassRunSampler;
			this.mDone = false;
			this.mItems = this.mClassItems;
			for (int i = 0; i < this.mItems; i++)
			{
				this.mState[i] = 0;
				this.mItemIdx[i] = i;
			}
			this.mSampler.Reset();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000419C File Offset: 0x0000319C
		protected void initVerifiers(int currVerSet)
		{
			int num;
			if (currVerSet >= 0 && currVerSet < 6)
			{
				num = currVerSet;
			}
			else
			{
				num = 0;
			}
			this.mVerifier = null;
			this.mStatisticsData = null;
			if (num == 4)
			{
				this.mVerifier = new nsVerifier[]
				{
					new nsUTF8Verifier(),
					new nsBIG5Verifier(),
					new nsISO2022CNVerifier(),
					new nsEUCTWVerifier(),
					new nsCP1252Verifier(),
					new nsUCS2BEVerifier(),
					new nsUCS2LEVerifier()
				};
				nsEUCStatistics[] array = new nsEUCStatistics[7];
				array[1] = new Big5Statistics();
				array[3] = new EUCTWStatistics();
				this.mStatisticsData = array;
			}
			else if (num == 5)
			{
				this.mVerifier = new nsVerifier[]
				{
					new nsUTF8Verifier(),
					new nsEUCKRVerifier(),
					new nsISO2022KRVerifier(),
					new nsCP1252Verifier(),
					new nsUCS2BEVerifier(),
					new nsUCS2LEVerifier()
				};
			}
			else if (num == 3)
			{
				this.mVerifier = new nsVerifier[]
				{
					new nsUTF8Verifier(),
					new nsGB2312Verifier(),
					new nsGB18030Verifier(),
					new nsISO2022CNVerifier(),
					new nsHZVerifier(),
					new nsUCS2BEVerifier(),
					new nsUCS2LEVerifier(),
					new nsCP1252Verifier()
				};
			}
			else if (num == 1)
			{
				this.mVerifier = new nsVerifier[]
				{
					new nsUTF8Verifier(),
					new nsSJISVerifier(),
					new nsEUCJPVerifier(),
					new nsISO2022JPVerifier(),
					new nsCP1252Verifier(),
					new nsUCS2BEVerifier(),
					new nsUCS2LEVerifier()
				};
			}
			else if (num == 2)
			{
				this.mVerifier = new nsVerifier[]
				{
					new nsUTF8Verifier(),
					new nsGB2312Verifier(),
					new nsGB18030Verifier(),
					new nsBIG5Verifier(),
					new nsISO2022CNVerifier(),
					new nsHZVerifier(),
					new nsEUCTWVerifier(),
					new nsCP1252Verifier(),
					new nsUCS2BEVerifier(),
					new nsUCS2LEVerifier()
				};
				nsEUCStatistics[] array2 = new nsEUCStatistics[10];
				array2[1] = new GB2312Statistics();
				array2[3] = new Big5Statistics();
				array2[6] = new EUCTWStatistics();
				this.mStatisticsData = array2;
			}
			else if (num == 0)
			{
				this.mVerifier = new nsVerifier[]
				{
					new nsUTF8Verifier(),
					new nsSJISVerifier(),
					new nsEUCJPVerifier(),
					new nsISO2022JPVerifier(),
					new nsEUCKRVerifier(),
					new nsISO2022KRVerifier(),
					new nsBIG5Verifier(),
					new nsEUCTWVerifier(),
					new nsGB2312Verifier(),
					new nsGB18030Verifier(),
					new nsISO2022CNVerifier(),
					new nsHZVerifier(),
					new nsCP1252Verifier(),
					new nsUCS2BEVerifier(),
					new nsUCS2LEVerifier()
				};
				nsEUCStatistics[] array3 = new nsEUCStatistics[15];
				array3[2] = new EUCJPStatistics();
				array3[4] = new EUCKRStatistics();
				array3[6] = new Big5Statistics();
				array3[7] = new EUCTWStatistics();
				array3[8] = new GB2312Statistics();
				this.mStatisticsData = array3;
			}
			this.mClassRunSampler = (this.mStatisticsData != null);
			this.mClassItems = this.mVerifier.Length;
		}

		// Token: 0x06000078 RID: 120
		public abstract void Report(string charset);

		// Token: 0x06000079 RID: 121 RVA: 0x000044D8 File Offset: 0x000034D8
		public bool HandleData(byte[] aBuf, int len)
		{
			for (int i = 0; i < len; i++)
			{
				byte b = aBuf[i];
				int j = 0;
				while (j < this.mItems)
				{
					byte nextState = nsVerifier.getNextState(this.mVerifier[this.mItemIdx[j]], b, this.mState[j]);
					if (nextState == 2)
					{
						this.Report(this.mVerifier[this.mItemIdx[j]].charset());
						this.mDone = true;
						return this.mDone;
					}
					if (nextState == 1)
					{
						this.mItems--;
						if (j < this.mItems)
						{
							this.mItemIdx[j] = this.mItemIdx[this.mItems];
							this.mState[j] = this.mState[this.mItems];
						}
					}
					else
					{
						this.mState[j++] = nextState;
					}
				}
				if (this.mItems <= 1)
				{
					if (1 == this.mItems)
					{
						this.Report(this.mVerifier[this.mItemIdx[0]].charset());
					}
					this.mDone = true;
					return this.mDone;
				}
				int num = 0;
				int num2 = 0;
				for (j = 0; j < this.mItems; j++)
				{
					if (!this.mVerifier[this.mItemIdx[j]].isUCS2() && !this.mVerifier[this.mItemIdx[j]].isUCS2())
					{
						num++;
						num2 = j;
					}
				}
				if (1 == num)
				{
					this.Report(this.mVerifier[this.mItemIdx[num2]].charset());
					this.mDone = true;
					return this.mDone;
				}
			}
			if (this.mRunSampler)
			{
				this.Sample(aBuf, len);
			}
			return this.mDone;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004678 File Offset: 0x00003678
		public void DataEnd()
		{
			if (this.mDone)
			{
				return;
			}
			if (this.mItems == 2)
			{
				if (this.mVerifier[this.mItemIdx[0]].charset() == "GB18030")
				{
					this.Report(this.mVerifier[this.mItemIdx[1]].charset());
					this.mDone = true;
				}
				else if (this.mVerifier[this.mItemIdx[1]].charset() == "GB18030")
				{
					this.Report(this.mVerifier[this.mItemIdx[0]].charset());
					this.mDone = true;
				}
			}
			if (this.mRunSampler)
			{
				this.Sample(null, 0, true);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000472F File Offset: 0x0000372F
		public void Sample(byte[] aBuf, int aLen)
		{
			this.Sample(aBuf, aLen, false);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000473C File Offset: 0x0000373C
		public void Sample(byte[] aBuf, int aLen, bool aLastChance)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < this.mItems; i++)
			{
				if (this.mStatisticsData[this.mItemIdx[i]] != null)
				{
					num2++;
				}
				if (!this.mVerifier[this.mItemIdx[i]].isUCS2() && !(this.mVerifier[this.mItemIdx[i]].charset() == "GB18030"))
				{
					num++;
				}
			}
			this.mRunSampler = (num2 > 1);
			if (this.mRunSampler)
			{
				this.mRunSampler = this.mSampler.Sample(aBuf, aLen);
				if (((aLastChance && this.mSampler.GetSomeData()) || this.mSampler.EnoughData()) && num2 == num)
				{
					this.mSampler.CalFreq();
					int num3 = -1;
					int num4 = 0;
					float num5 = 0f;
					for (int i = 0; i < this.mItems; i++)
					{
						if (this.mStatisticsData[this.mItemIdx[i]] != null && !(this.mVerifier[this.mItemIdx[i]].charset() == "Big5"))
						{
							float score = this.mSampler.GetScore(this.mStatisticsData[this.mItemIdx[i]].mFirstByteFreq(), this.mStatisticsData[this.mItemIdx[i]].mFirstByteWeight(), this.mStatisticsData[this.mItemIdx[i]].mSecondByteFreq(), this.mStatisticsData[this.mItemIdx[i]].mSecondByteWeight());
							if (num4++ == 0 || num5 > score)
							{
								num5 = score;
								num3 = i;
							}
						}
					}
					if (num3 >= 0)
					{
						this.Report(this.mVerifier[this.mItemIdx[num3]].charset());
						this.mDone = true;
					}
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000048F8 File Offset: 0x000038F8
		public string[] getProbableCharsets()
		{
			if (this.mItems <= 0)
			{
				return new string[]
				{
					"nomatch"
				};
			}
			string[] array = new string[this.mItems];
			for (int i = 0; i < this.mItems; i++)
			{
				array[i] = this.mVerifier[this.mItemIdx[i]].charset();
			}
			return array;
		}

		// Token: 0x04000042 RID: 66
		public const int ALL = 0;

		// Token: 0x04000043 RID: 67
		public const int JAPANESE = 1;

		// Token: 0x04000044 RID: 68
		public const int CHINESE = 2;

		// Token: 0x04000045 RID: 69
		public const int SIMPLIFIED_CHINESE = 3;

		// Token: 0x04000046 RID: 70
		public const int TRADITIONAL_CHINESE = 4;

		// Token: 0x04000047 RID: 71
		public const int KOREAN = 5;

		// Token: 0x04000048 RID: 72
		public const int NO_OF_LANGUAGES = 6;

		// Token: 0x04000049 RID: 73
		public const int MAX_VERIFIERS = 16;

		// Token: 0x0400004A RID: 74
		private nsVerifier[] mVerifier;

		// Token: 0x0400004B RID: 75
		private nsEUCStatistics[] mStatisticsData;

		// Token: 0x0400004C RID: 76
		private nsEUCSampler mSampler = new nsEUCSampler();

		// Token: 0x0400004D RID: 77
		private byte[] mState = new byte[16];

		// Token: 0x0400004E RID: 78
		private int[] mItemIdx = new int[16];

		// Token: 0x0400004F RID: 79
		private int mItems;

		// Token: 0x04000050 RID: 80
		private int mClassItems;

		// Token: 0x04000051 RID: 81
		protected bool mDone;

		// Token: 0x04000052 RID: 82
		protected bool mRunSampler;

		// Token: 0x04000053 RID: 83
		protected bool mClassRunSampler;
	}
}

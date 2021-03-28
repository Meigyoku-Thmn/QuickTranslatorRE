using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200000F RID: 15
	public abstract class nsVerifier
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00003BBD File Offset: 0x00002BBD
		public nsVerifier()
		{
		}

		// Token: 0x06000061 RID: 97
		public abstract string charset();

		// Token: 0x06000062 RID: 98
		public abstract int stFactor();

		// Token: 0x06000063 RID: 99
		public abstract int[] cclass();

		// Token: 0x06000064 RID: 100
		public abstract int[] states();

		// Token: 0x06000065 RID: 101
		public abstract bool isUCS2();

		// Token: 0x06000066 RID: 102 RVA: 0x00003BC8 File Offset: 0x00002BC8
		public static byte getNextState(nsVerifier v, byte b, byte s)
		{
			return (byte)(255 & (v.states()[((int)s * v.stFactor() + (v.cclass()[(b & byte.MaxValue) >> 3] >> ((int)(b & 7) << 2) & 15) & 255) >> 3] >> (((int)s * v.stFactor() + (v.cclass()[(b & byte.MaxValue) >> 3] >> ((int)(b & 7) << 2) & 15) & 255 & 7) << 2) & 15));
		}

		// Token: 0x04000033 RID: 51
		public const byte eStart = 0;

		// Token: 0x04000034 RID: 52
		public const byte eError = 1;

		// Token: 0x04000035 RID: 53
		public const byte eItsMe = 2;

		// Token: 0x04000036 RID: 54
		public const int eidxSft4bits = 3;

		// Token: 0x04000037 RID: 55
		public const int eSftMsk4bits = 7;

		// Token: 0x04000038 RID: 56
		public const int eBitSft4bits = 2;

		// Token: 0x04000039 RID: 57
		public const int eUnitMsk4bits = 15;
	}
}

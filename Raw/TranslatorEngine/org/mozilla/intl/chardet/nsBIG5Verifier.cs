using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000010 RID: 16
	public class nsBIG5Verifier : nsVerifier
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00003C46 File Offset: 0x00002C46
		public override int[] cclass()
		{
			return nsBIG5Verifier.m_cclass;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003C4D File Offset: 0x00002C4D
		public override int[] states()
		{
			return nsBIG5Verifier.m_states;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003C54 File Offset: 0x00002C54
		public override int stFactor()
		{
			return nsBIG5Verifier.m_stFactor;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003C5B File Offset: 0x00002C5B
		public override string charset()
		{
			return nsBIG5Verifier.m_charset;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003C64 File Offset: 0x00002C64
		public nsBIG5Verifier()
		{
			nsBIG5Verifier.m_cclass = new int[32];
			nsBIG5Verifier.m_cclass[0] = 286331153;
			nsBIG5Verifier.m_cclass[1] = 1118481;
			nsBIG5Verifier.m_cclass[2] = 286331153;
			nsBIG5Verifier.m_cclass[3] = 286327057;
			nsBIG5Verifier.m_cclass[4] = 286331153;
			nsBIG5Verifier.m_cclass[5] = 286331153;
			nsBIG5Verifier.m_cclass[6] = 286331153;
			nsBIG5Verifier.m_cclass[7] = 286331153;
			nsBIG5Verifier.m_cclass[8] = 572662306;
			nsBIG5Verifier.m_cclass[9] = 572662306;
			nsBIG5Verifier.m_cclass[10] = 572662306;
			nsBIG5Verifier.m_cclass[11] = 572662306;
			nsBIG5Verifier.m_cclass[12] = 572662306;
			nsBIG5Verifier.m_cclass[13] = 572662306;
			nsBIG5Verifier.m_cclass[14] = 572662306;
			nsBIG5Verifier.m_cclass[15] = 304226850;
			nsBIG5Verifier.m_cclass[16] = 1145324612;
			nsBIG5Verifier.m_cclass[17] = 1145324612;
			nsBIG5Verifier.m_cclass[18] = 1145324612;
			nsBIG5Verifier.m_cclass[19] = 1145324612;
			nsBIG5Verifier.m_cclass[20] = 858993460;
			nsBIG5Verifier.m_cclass[21] = 858993459;
			nsBIG5Verifier.m_cclass[22] = 858993459;
			nsBIG5Verifier.m_cclass[23] = 858993459;
			nsBIG5Verifier.m_cclass[24] = 858993459;
			nsBIG5Verifier.m_cclass[25] = 858993459;
			nsBIG5Verifier.m_cclass[26] = 858993459;
			nsBIG5Verifier.m_cclass[27] = 858993459;
			nsBIG5Verifier.m_cclass[28] = 858993459;
			nsBIG5Verifier.m_cclass[29] = 858993459;
			nsBIG5Verifier.m_cclass[30] = 858993459;
			nsBIG5Verifier.m_cclass[31] = 53687091;
			nsBIG5Verifier.m_states = new int[3];
			nsBIG5Verifier.m_states[0] = 286339073;
			nsBIG5Verifier.m_states[1] = 304226833;
			nsBIG5Verifier.m_states[2] = 1;
			nsBIG5Verifier.m_charset = "Big5";
			nsBIG5Verifier.m_stFactor = 5;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003E55 File Offset: 0x00002E55
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x0400003A RID: 58
		private static int[] m_cclass;

		// Token: 0x0400003B RID: 59
		private static int[] m_states;

		// Token: 0x0400003C RID: 60
		private static int m_stFactor;

		// Token: 0x0400003D RID: 61
		private static string m_charset;
	}
}

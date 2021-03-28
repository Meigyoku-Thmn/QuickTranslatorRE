using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000022 RID: 34
	public class nsUTF8Verifier : nsVerifier
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x000064E0 File Offset: 0x000054E0
		public override int[] cclass()
		{
			return nsUTF8Verifier.m_cclass;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000064E7 File Offset: 0x000054E7
		public override int[] states()
		{
			return nsUTF8Verifier.m_states;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000064EE File Offset: 0x000054EE
		public override int stFactor()
		{
			return nsUTF8Verifier.m_stFactor;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000064F5 File Offset: 0x000054F5
		public override string charset()
		{
			return nsUTF8Verifier.m_charset;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000064FC File Offset: 0x000054FC
		public nsUTF8Verifier()
		{
			nsUTF8Verifier.m_cclass = new int[32];
			nsUTF8Verifier.m_cclass[0] = 286331153;
			nsUTF8Verifier.m_cclass[1] = 1118481;
			nsUTF8Verifier.m_cclass[2] = 286331153;
			nsUTF8Verifier.m_cclass[3] = 286327057;
			nsUTF8Verifier.m_cclass[4] = 286331153;
			nsUTF8Verifier.m_cclass[5] = 286331153;
			nsUTF8Verifier.m_cclass[6] = 286331153;
			nsUTF8Verifier.m_cclass[7] = 286331153;
			nsUTF8Verifier.m_cclass[8] = 286331153;
			nsUTF8Verifier.m_cclass[9] = 286331153;
			nsUTF8Verifier.m_cclass[10] = 286331153;
			nsUTF8Verifier.m_cclass[11] = 286331153;
			nsUTF8Verifier.m_cclass[12] = 286331153;
			nsUTF8Verifier.m_cclass[13] = 286331153;
			nsUTF8Verifier.m_cclass[14] = 286331153;
			nsUTF8Verifier.m_cclass[15] = 286331153;
			nsUTF8Verifier.m_cclass[16] = 858989090;
			nsUTF8Verifier.m_cclass[17] = 1145324612;
			nsUTF8Verifier.m_cclass[18] = 1145324612;
			nsUTF8Verifier.m_cclass[19] = 1145324612;
			nsUTF8Verifier.m_cclass[20] = 1431655765;
			nsUTF8Verifier.m_cclass[21] = 1431655765;
			nsUTF8Verifier.m_cclass[22] = 1431655765;
			nsUTF8Verifier.m_cclass[23] = 1431655765;
			nsUTF8Verifier.m_cclass[24] = 1717986816;
			nsUTF8Verifier.m_cclass[25] = 1717986918;
			nsUTF8Verifier.m_cclass[26] = 1717986918;
			nsUTF8Verifier.m_cclass[27] = 1717986918;
			nsUTF8Verifier.m_cclass[28] = -2004318073;
			nsUTF8Verifier.m_cclass[29] = -2003269496;
			nsUTF8Verifier.m_cclass[30] = -1145324614;
			nsUTF8Verifier.m_cclass[31] = 16702940;
			nsUTF8Verifier.m_states = new int[26];
			nsUTF8Verifier.m_states[0] = -1408167679;
			nsUTF8Verifier.m_states[1] = 878082233;
			nsUTF8Verifier.m_states[2] = 286331153;
			nsUTF8Verifier.m_states[3] = 286331153;
			nsUTF8Verifier.m_states[4] = 572662306;
			nsUTF8Verifier.m_states[5] = 572662306;
			nsUTF8Verifier.m_states[6] = 290805009;
			nsUTF8Verifier.m_states[7] = 286331153;
			nsUTF8Verifier.m_states[8] = 290803985;
			nsUTF8Verifier.m_states[9] = 286331153;
			nsUTF8Verifier.m_states[10] = 293041937;
			nsUTF8Verifier.m_states[11] = 286331153;
			nsUTF8Verifier.m_states[12] = 293015825;
			nsUTF8Verifier.m_states[13] = 286331153;
			nsUTF8Verifier.m_states[14] = 295278865;
			nsUTF8Verifier.m_states[15] = 286331153;
			nsUTF8Verifier.m_states[16] = 294719761;
			nsUTF8Verifier.m_states[17] = 286331153;
			nsUTF8Verifier.m_states[18] = 298634257;
			nsUTF8Verifier.m_states[19] = 286331153;
			nsUTF8Verifier.m_states[20] = 297865489;
			nsUTF8Verifier.m_states[21] = 286331153;
			nsUTF8Verifier.m_states[22] = 287099921;
			nsUTF8Verifier.m_states[23] = 286331153;
			nsUTF8Verifier.m_states[24] = 285212689;
			nsUTF8Verifier.m_states[25] = 286331153;
			nsUTF8Verifier.m_charset = "UTF-8";
			nsUTF8Verifier.m_stFactor = 16;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00006818 File Offset: 0x00005818
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x0400008C RID: 140
		private static int[] m_cclass;

		// Token: 0x0400008D RID: 141
		private static int[] m_states;

		// Token: 0x0400008E RID: 142
		private static int m_stFactor;

		// Token: 0x0400008F RID: 143
		private static string m_charset;
	}
}

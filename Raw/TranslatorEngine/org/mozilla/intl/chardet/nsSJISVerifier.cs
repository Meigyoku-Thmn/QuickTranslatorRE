using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200001F RID: 31
	public class nsSJISVerifier : nsVerifier
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00005F21 File Offset: 0x00004F21
		public override int[] cclass()
		{
			return nsSJISVerifier.m_cclass;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005F28 File Offset: 0x00004F28
		public override int[] states()
		{
			return nsSJISVerifier.m_states;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005F2F File Offset: 0x00004F2F
		public override int stFactor()
		{
			return nsSJISVerifier.m_stFactor;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005F36 File Offset: 0x00004F36
		public override string charset()
		{
			return nsSJISVerifier.m_charset;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005F40 File Offset: 0x00004F40
		public nsSJISVerifier()
		{
			nsSJISVerifier.m_cclass = new int[32];
			nsSJISVerifier.m_cclass[0] = 286331152;
			nsSJISVerifier.m_cclass[1] = 1118481;
			nsSJISVerifier.m_cclass[2] = 286331153;
			nsSJISVerifier.m_cclass[3] = 286327057;
			nsSJISVerifier.m_cclass[4] = 286331153;
			nsSJISVerifier.m_cclass[5] = 286331153;
			nsSJISVerifier.m_cclass[6] = 286331153;
			nsSJISVerifier.m_cclass[7] = 286331153;
			nsSJISVerifier.m_cclass[8] = 572662306;
			nsSJISVerifier.m_cclass[9] = 572662306;
			nsSJISVerifier.m_cclass[10] = 572662306;
			nsSJISVerifier.m_cclass[11] = 572662306;
			nsSJISVerifier.m_cclass[12] = 572662306;
			nsSJISVerifier.m_cclass[13] = 572662306;
			nsSJISVerifier.m_cclass[14] = 572662306;
			nsSJISVerifier.m_cclass[15] = 304226850;
			nsSJISVerifier.m_cclass[16] = 858993459;
			nsSJISVerifier.m_cclass[17] = 858993459;
			nsSJISVerifier.m_cclass[18] = 858993459;
			nsSJISVerifier.m_cclass[19] = 858993459;
			nsSJISVerifier.m_cclass[20] = 572662308;
			nsSJISVerifier.m_cclass[21] = 572662306;
			nsSJISVerifier.m_cclass[22] = 572662306;
			nsSJISVerifier.m_cclass[23] = 572662306;
			nsSJISVerifier.m_cclass[24] = 572662306;
			nsSJISVerifier.m_cclass[25] = 572662306;
			nsSJISVerifier.m_cclass[26] = 572662306;
			nsSJISVerifier.m_cclass[27] = 572662306;
			nsSJISVerifier.m_cclass[28] = 858993459;
			nsSJISVerifier.m_cclass[29] = 1145393971;
			nsSJISVerifier.m_cclass[30] = 1145324612;
			nsSJISVerifier.m_cclass[31] = 279620;
			nsSJISVerifier.m_states = new int[3];
			nsSJISVerifier.m_states[0] = 286339073;
			nsSJISVerifier.m_states[1] = 572657937;
			nsSJISVerifier.m_states[2] = 4386;
			nsSJISVerifier.m_charset = "Shift_JIS";
			nsSJISVerifier.m_stFactor = 6;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00006135 File Offset: 0x00005135
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x04000080 RID: 128
		private static int[] m_cclass;

		// Token: 0x04000081 RID: 129
		private static int[] m_states;

		// Token: 0x04000082 RID: 130
		private static int m_stFactor;

		// Token: 0x04000083 RID: 131
		private static string m_charset;
	}
}

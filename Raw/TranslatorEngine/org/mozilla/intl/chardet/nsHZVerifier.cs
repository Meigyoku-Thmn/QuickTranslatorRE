using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200001B RID: 27
	public class nsHZVerifier : nsVerifier
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00005700 File Offset: 0x00004700
		public override int[] cclass()
		{
			return nsHZVerifier.m_cclass;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005707 File Offset: 0x00004707
		public override int[] states()
		{
			return nsHZVerifier.m_states;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000570E File Offset: 0x0000470E
		public override int stFactor()
		{
			return nsHZVerifier.m_stFactor;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005715 File Offset: 0x00004715
		public override string charset()
		{
			return nsHZVerifier.m_charset;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000571C File Offset: 0x0000471C
		public nsHZVerifier()
		{
			nsHZVerifier.m_cclass = new int[32];
			nsHZVerifier.m_cclass[0] = 1;
			nsHZVerifier.m_cclass[1] = 0;
			nsHZVerifier.m_cclass[2] = 0;
			nsHZVerifier.m_cclass[3] = 4096;
			nsHZVerifier.m_cclass[4] = 0;
			nsHZVerifier.m_cclass[5] = 0;
			nsHZVerifier.m_cclass[6] = 0;
			nsHZVerifier.m_cclass[7] = 0;
			nsHZVerifier.m_cclass[8] = 0;
			nsHZVerifier.m_cclass[9] = 0;
			nsHZVerifier.m_cclass[10] = 0;
			nsHZVerifier.m_cclass[11] = 0;
			nsHZVerifier.m_cclass[12] = 0;
			nsHZVerifier.m_cclass[13] = 0;
			nsHZVerifier.m_cclass[14] = 0;
			nsHZVerifier.m_cclass[15] = 38813696;
			nsHZVerifier.m_cclass[16] = 286331153;
			nsHZVerifier.m_cclass[17] = 286331153;
			nsHZVerifier.m_cclass[18] = 286331153;
			nsHZVerifier.m_cclass[19] = 286331153;
			nsHZVerifier.m_cclass[20] = 286331153;
			nsHZVerifier.m_cclass[21] = 286331153;
			nsHZVerifier.m_cclass[22] = 286331153;
			nsHZVerifier.m_cclass[23] = 286331153;
			nsHZVerifier.m_cclass[24] = 286331153;
			nsHZVerifier.m_cclass[25] = 286331153;
			nsHZVerifier.m_cclass[26] = 286331153;
			nsHZVerifier.m_cclass[27] = 286331153;
			nsHZVerifier.m_cclass[28] = 286331153;
			nsHZVerifier.m_cclass[29] = 286331153;
			nsHZVerifier.m_cclass[30] = 286331153;
			nsHZVerifier.m_cclass[31] = 286331153;
			nsHZVerifier.m_states = new int[6];
			nsHZVerifier.m_states[0] = 285213456;
			nsHZVerifier.m_states[1] = 572657937;
			nsHZVerifier.m_states[2] = 335548706;
			nsHZVerifier.m_states[3] = 341120533;
			nsHZVerifier.m_states[4] = 336872468;
			nsHZVerifier.m_states[5] = 36;
			nsHZVerifier.m_charset = "HZ-GB-2312";
			nsHZVerifier.m_stFactor = 6;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000058FA File Offset: 0x000048FA
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x04000070 RID: 112
		private static int[] m_cclass;

		// Token: 0x04000071 RID: 113
		private static int[] m_states;

		// Token: 0x04000072 RID: 114
		private static int m_stFactor;

		// Token: 0x04000073 RID: 115
		private static string m_charset;
	}
}

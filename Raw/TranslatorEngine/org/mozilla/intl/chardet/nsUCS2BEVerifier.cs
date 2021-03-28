using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000020 RID: 32
	public class nsUCS2BEVerifier : nsVerifier
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00006138 File Offset: 0x00005138
		public override int[] cclass()
		{
			return nsUCS2BEVerifier.m_cclass;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000613F File Offset: 0x0000513F
		public override int[] states()
		{
			return nsUCS2BEVerifier.m_states;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00006146 File Offset: 0x00005146
		public override int stFactor()
		{
			return nsUCS2BEVerifier.m_stFactor;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000614D File Offset: 0x0000514D
		public override string charset()
		{
			return nsUCS2BEVerifier.m_charset;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006154 File Offset: 0x00005154
		public nsUCS2BEVerifier()
		{
			nsUCS2BEVerifier.m_cclass = new int[32];
			nsUCS2BEVerifier.m_cclass[0] = 0;
			nsUCS2BEVerifier.m_cclass[1] = 2097408;
			nsUCS2BEVerifier.m_cclass[2] = 0;
			nsUCS2BEVerifier.m_cclass[3] = 12288;
			nsUCS2BEVerifier.m_cclass[4] = 0;
			nsUCS2BEVerifier.m_cclass[5] = 3355440;
			nsUCS2BEVerifier.m_cclass[6] = 0;
			nsUCS2BEVerifier.m_cclass[7] = 0;
			nsUCS2BEVerifier.m_cclass[8] = 0;
			nsUCS2BEVerifier.m_cclass[9] = 0;
			nsUCS2BEVerifier.m_cclass[10] = 0;
			nsUCS2BEVerifier.m_cclass[11] = 0;
			nsUCS2BEVerifier.m_cclass[12] = 0;
			nsUCS2BEVerifier.m_cclass[13] = 0;
			nsUCS2BEVerifier.m_cclass[14] = 0;
			nsUCS2BEVerifier.m_cclass[15] = 0;
			nsUCS2BEVerifier.m_cclass[16] = 0;
			nsUCS2BEVerifier.m_cclass[17] = 0;
			nsUCS2BEVerifier.m_cclass[18] = 0;
			nsUCS2BEVerifier.m_cclass[19] = 0;
			nsUCS2BEVerifier.m_cclass[20] = 0;
			nsUCS2BEVerifier.m_cclass[21] = 0;
			nsUCS2BEVerifier.m_cclass[22] = 0;
			nsUCS2BEVerifier.m_cclass[23] = 0;
			nsUCS2BEVerifier.m_cclass[24] = 0;
			nsUCS2BEVerifier.m_cclass[25] = 0;
			nsUCS2BEVerifier.m_cclass[26] = 0;
			nsUCS2BEVerifier.m_cclass[27] = 0;
			nsUCS2BEVerifier.m_cclass[28] = 0;
			nsUCS2BEVerifier.m_cclass[29] = 0;
			nsUCS2BEVerifier.m_cclass[30] = 0;
			nsUCS2BEVerifier.m_cclass[31] = 1409286144;
			nsUCS2BEVerifier.m_states = new int[7];
			nsUCS2BEVerifier.m_states[0] = 288626549;
			nsUCS2BEVerifier.m_states[1] = 572657937;
			nsUCS2BEVerifier.m_states[2] = 291923490;
			nsUCS2BEVerifier.m_states[3] = 1713792614;
			nsUCS2BEVerifier.m_states[4] = 393569894;
			nsUCS2BEVerifier.m_states[5] = 1717659269;
			nsUCS2BEVerifier.m_states[6] = 1140326;
			nsUCS2BEVerifier.m_charset = "UTF-16BE";
			nsUCS2BEVerifier.m_stFactor = 6;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006309 File Offset: 0x00005309
		public override bool isUCS2()
		{
			return true;
		}

		// Token: 0x04000084 RID: 132
		private static int[] m_cclass;

		// Token: 0x04000085 RID: 133
		private static int[] m_states;

		// Token: 0x04000086 RID: 134
		private static int m_stFactor;

		// Token: 0x04000087 RID: 135
		private static string m_charset;
	}
}

using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200001C RID: 28
	public class nsISO2022CNVerifier : nsVerifier
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x000058FD File Offset: 0x000048FD
		public override int[] cclass()
		{
			return nsISO2022CNVerifier.m_cclass;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005904 File Offset: 0x00004904
		public override int[] states()
		{
			return nsISO2022CNVerifier.m_states;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000590B File Offset: 0x0000490B
		public override int stFactor()
		{
			return nsISO2022CNVerifier.m_stFactor;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005912 File Offset: 0x00004912
		public override string charset()
		{
			return nsISO2022CNVerifier.m_charset;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000591C File Offset: 0x0000491C
		public nsISO2022CNVerifier()
		{
			nsISO2022CNVerifier.m_cclass = new int[32];
			nsISO2022CNVerifier.m_cclass[0] = 2;
			nsISO2022CNVerifier.m_cclass[1] = 0;
			nsISO2022CNVerifier.m_cclass[2] = 0;
			nsISO2022CNVerifier.m_cclass[3] = 4096;
			nsISO2022CNVerifier.m_cclass[4] = 0;
			nsISO2022CNVerifier.m_cclass[5] = 48;
			nsISO2022CNVerifier.m_cclass[6] = 0;
			nsISO2022CNVerifier.m_cclass[7] = 0;
			nsISO2022CNVerifier.m_cclass[8] = 16384;
			nsISO2022CNVerifier.m_cclass[9] = 0;
			nsISO2022CNVerifier.m_cclass[10] = 0;
			nsISO2022CNVerifier.m_cclass[11] = 0;
			nsISO2022CNVerifier.m_cclass[12] = 0;
			nsISO2022CNVerifier.m_cclass[13] = 0;
			nsISO2022CNVerifier.m_cclass[14] = 0;
			nsISO2022CNVerifier.m_cclass[15] = 0;
			nsISO2022CNVerifier.m_cclass[16] = 572662306;
			nsISO2022CNVerifier.m_cclass[17] = 572662306;
			nsISO2022CNVerifier.m_cclass[18] = 572662306;
			nsISO2022CNVerifier.m_cclass[19] = 572662306;
			nsISO2022CNVerifier.m_cclass[20] = 572662306;
			nsISO2022CNVerifier.m_cclass[21] = 572662306;
			nsISO2022CNVerifier.m_cclass[22] = 572662306;
			nsISO2022CNVerifier.m_cclass[23] = 572662306;
			nsISO2022CNVerifier.m_cclass[24] = 572662306;
			nsISO2022CNVerifier.m_cclass[25] = 572662306;
			nsISO2022CNVerifier.m_cclass[26] = 572662306;
			nsISO2022CNVerifier.m_cclass[27] = 572662306;
			nsISO2022CNVerifier.m_cclass[28] = 572662306;
			nsISO2022CNVerifier.m_cclass[29] = 572662306;
			nsISO2022CNVerifier.m_cclass[30] = 572662306;
			nsISO2022CNVerifier.m_cclass[31] = 572662306;
			nsISO2022CNVerifier.m_states = new int[8];
			nsISO2022CNVerifier.m_states[0] = 304;
			nsISO2022CNVerifier.m_states[1] = 286331152;
			nsISO2022CNVerifier.m_states[2] = 572662289;
			nsISO2022CNVerifier.m_states[3] = 336663074;
			nsISO2022CNVerifier.m_states[4] = 286335249;
			nsISO2022CNVerifier.m_states[5] = 286331237;
			nsISO2022CNVerifier.m_states[6] = 286335249;
			nsISO2022CNVerifier.m_states[7] = 18944273;
			nsISO2022CNVerifier.m_charset = "ISO-2022-CN";
			nsISO2022CNVerifier.m_stFactor = 9;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005B17 File Offset: 0x00004B17
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x04000074 RID: 116
		private static int[] m_cclass;

		// Token: 0x04000075 RID: 117
		private static int[] m_states;

		// Token: 0x04000076 RID: 118
		private static int m_stFactor;

		// Token: 0x04000077 RID: 119
		private static string m_charset;
	}
}

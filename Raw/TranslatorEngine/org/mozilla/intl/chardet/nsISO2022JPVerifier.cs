using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200001D RID: 29
	public class nsISO2022JPVerifier : nsVerifier
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00005B1A File Offset: 0x00004B1A
		public override int[] cclass()
		{
			return nsISO2022JPVerifier.m_cclass;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005B21 File Offset: 0x00004B21
		public override int[] states()
		{
			return nsISO2022JPVerifier.m_states;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005B28 File Offset: 0x00004B28
		public override int stFactor()
		{
			return nsISO2022JPVerifier.m_stFactor;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005B2F File Offset: 0x00004B2F
		public override string charset()
		{
			return nsISO2022JPVerifier.m_charset;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005B38 File Offset: 0x00004B38
		public nsISO2022JPVerifier()
		{
			nsISO2022JPVerifier.m_cclass = new int[32];
			nsISO2022JPVerifier.m_cclass[0] = 2;
			nsISO2022JPVerifier.m_cclass[1] = 570425344;
			nsISO2022JPVerifier.m_cclass[2] = 0;
			nsISO2022JPVerifier.m_cclass[3] = 4096;
			nsISO2022JPVerifier.m_cclass[4] = 458752;
			nsISO2022JPVerifier.m_cclass[5] = 3;
			nsISO2022JPVerifier.m_cclass[6] = 0;
			nsISO2022JPVerifier.m_cclass[7] = 0;
			nsISO2022JPVerifier.m_cclass[8] = 1030;
			nsISO2022JPVerifier.m_cclass[9] = 1280;
			nsISO2022JPVerifier.m_cclass[10] = 0;
			nsISO2022JPVerifier.m_cclass[11] = 0;
			nsISO2022JPVerifier.m_cclass[12] = 0;
			nsISO2022JPVerifier.m_cclass[13] = 0;
			nsISO2022JPVerifier.m_cclass[14] = 0;
			nsISO2022JPVerifier.m_cclass[15] = 0;
			nsISO2022JPVerifier.m_cclass[16] = 572662306;
			nsISO2022JPVerifier.m_cclass[17] = 572662306;
			nsISO2022JPVerifier.m_cclass[18] = 572662306;
			nsISO2022JPVerifier.m_cclass[19] = 572662306;
			nsISO2022JPVerifier.m_cclass[20] = 572662306;
			nsISO2022JPVerifier.m_cclass[21] = 572662306;
			nsISO2022JPVerifier.m_cclass[22] = 572662306;
			nsISO2022JPVerifier.m_cclass[23] = 572662306;
			nsISO2022JPVerifier.m_cclass[24] = 572662306;
			nsISO2022JPVerifier.m_cclass[25] = 572662306;
			nsISO2022JPVerifier.m_cclass[26] = 572662306;
			nsISO2022JPVerifier.m_cclass[27] = 572662306;
			nsISO2022JPVerifier.m_cclass[28] = 572662306;
			nsISO2022JPVerifier.m_cclass[29] = 572662306;
			nsISO2022JPVerifier.m_cclass[30] = 572662306;
			nsISO2022JPVerifier.m_cclass[31] = 572662306;
			nsISO2022JPVerifier.m_states = new int[6];
			nsISO2022JPVerifier.m_states[0] = 304;
			nsISO2022JPVerifier.m_states[1] = 286331153;
			nsISO2022JPVerifier.m_states[2] = 572662306;
			nsISO2022JPVerifier.m_states[3] = 1091653905;
			nsISO2022JPVerifier.m_states[4] = 303173905;
			nsISO2022JPVerifier.m_states[5] = 287445265;
			nsISO2022JPVerifier.m_charset = "ISO-2022-JP";
			nsISO2022JPVerifier.m_stFactor = 8;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005D25 File Offset: 0x00004D25
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x04000078 RID: 120
		private static int[] m_cclass;

		// Token: 0x04000079 RID: 121
		private static int[] m_states;

		// Token: 0x0400007A RID: 122
		private static int m_stFactor;

		// Token: 0x0400007B RID: 123
		private static string m_charset;
	}
}

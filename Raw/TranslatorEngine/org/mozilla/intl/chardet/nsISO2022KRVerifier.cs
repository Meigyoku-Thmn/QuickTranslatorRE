using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200001E RID: 30
	public class nsISO2022KRVerifier : nsVerifier
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00005D28 File Offset: 0x00004D28
		public override int[] cclass()
		{
			return nsISO2022KRVerifier.m_cclass;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005D2F File Offset: 0x00004D2F
		public override int[] states()
		{
			return nsISO2022KRVerifier.m_states;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005D36 File Offset: 0x00004D36
		public override int stFactor()
		{
			return nsISO2022KRVerifier.m_stFactor;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005D3D File Offset: 0x00004D3D
		public override string charset()
		{
			return nsISO2022KRVerifier.m_charset;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005D44 File Offset: 0x00004D44
		public nsISO2022KRVerifier()
		{
			nsISO2022KRVerifier.m_cclass = new int[32];
			nsISO2022KRVerifier.m_cclass[0] = 2;
			nsISO2022KRVerifier.m_cclass[1] = 0;
			nsISO2022KRVerifier.m_cclass[2] = 0;
			nsISO2022KRVerifier.m_cclass[3] = 4096;
			nsISO2022KRVerifier.m_cclass[4] = 196608;
			nsISO2022KRVerifier.m_cclass[5] = 64;
			nsISO2022KRVerifier.m_cclass[6] = 0;
			nsISO2022KRVerifier.m_cclass[7] = 0;
			nsISO2022KRVerifier.m_cclass[8] = 20480;
			nsISO2022KRVerifier.m_cclass[9] = 0;
			nsISO2022KRVerifier.m_cclass[10] = 0;
			nsISO2022KRVerifier.m_cclass[11] = 0;
			nsISO2022KRVerifier.m_cclass[12] = 0;
			nsISO2022KRVerifier.m_cclass[13] = 0;
			nsISO2022KRVerifier.m_cclass[14] = 0;
			nsISO2022KRVerifier.m_cclass[15] = 0;
			nsISO2022KRVerifier.m_cclass[16] = 572662306;
			nsISO2022KRVerifier.m_cclass[17] = 572662306;
			nsISO2022KRVerifier.m_cclass[18] = 572662306;
			nsISO2022KRVerifier.m_cclass[19] = 572662306;
			nsISO2022KRVerifier.m_cclass[20] = 572662306;
			nsISO2022KRVerifier.m_cclass[21] = 572662306;
			nsISO2022KRVerifier.m_cclass[22] = 572662306;
			nsISO2022KRVerifier.m_cclass[23] = 572662306;
			nsISO2022KRVerifier.m_cclass[24] = 572662306;
			nsISO2022KRVerifier.m_cclass[25] = 572662306;
			nsISO2022KRVerifier.m_cclass[26] = 572662306;
			nsISO2022KRVerifier.m_cclass[27] = 572662306;
			nsISO2022KRVerifier.m_cclass[28] = 572662306;
			nsISO2022KRVerifier.m_cclass[29] = 572662306;
			nsISO2022KRVerifier.m_cclass[30] = 572662306;
			nsISO2022KRVerifier.m_cclass[31] = 572662306;
			nsISO2022KRVerifier.m_states = new int[5];
			nsISO2022KRVerifier.m_states[0] = 285212976;
			nsISO2022KRVerifier.m_states[1] = 572657937;
			nsISO2022KRVerifier.m_states[2] = 289476898;
			nsISO2022KRVerifier.m_states[3] = 286593297;
			nsISO2022KRVerifier.m_states[4] = 8465;
			nsISO2022KRVerifier.m_charset = "ISO-2022-KR";
			nsISO2022KRVerifier.m_stFactor = 6;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005F1E File Offset: 0x00004F1E
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x0400007C RID: 124
		private static int[] m_cclass;

		// Token: 0x0400007D RID: 125
		private static int[] m_states;

		// Token: 0x0400007E RID: 126
		private static int m_stFactor;

		// Token: 0x0400007F RID: 127
		private static string m_charset;
	}
}

using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000018 RID: 24
	public class nsEUCTWVerifier : nsVerifier
	{
		// Token: 0x0600009C RID: 156 RVA: 0x000050A4 File Offset: 0x000040A4
		public override int[] cclass()
		{
			return nsEUCTWVerifier.m_cclass;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000050AB File Offset: 0x000040AB
		public override int[] states()
		{
			return nsEUCTWVerifier.m_states;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000050B2 File Offset: 0x000040B2
		public override int stFactor()
		{
			return nsEUCTWVerifier.m_stFactor;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000050B9 File Offset: 0x000040B9
		public override string charset()
		{
			return nsEUCTWVerifier.m_charset;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000050C0 File Offset: 0x000040C0
		public nsEUCTWVerifier()
		{
			nsEUCTWVerifier.m_cclass = new int[32];
			nsEUCTWVerifier.m_cclass[0] = 572662306;
			nsEUCTWVerifier.m_cclass[1] = 2236962;
			nsEUCTWVerifier.m_cclass[2] = 572662306;
			nsEUCTWVerifier.m_cclass[3] = 572654114;
			nsEUCTWVerifier.m_cclass[4] = 572662306;
			nsEUCTWVerifier.m_cclass[5] = 572662306;
			nsEUCTWVerifier.m_cclass[6] = 572662306;
			nsEUCTWVerifier.m_cclass[7] = 572662306;
			nsEUCTWVerifier.m_cclass[8] = 572662306;
			nsEUCTWVerifier.m_cclass[9] = 572662306;
			nsEUCTWVerifier.m_cclass[10] = 572662306;
			nsEUCTWVerifier.m_cclass[11] = 572662306;
			nsEUCTWVerifier.m_cclass[12] = 572662306;
			nsEUCTWVerifier.m_cclass[13] = 572662306;
			nsEUCTWVerifier.m_cclass[14] = 572662306;
			nsEUCTWVerifier.m_cclass[15] = 572662306;
			nsEUCTWVerifier.m_cclass[16] = 0;
			nsEUCTWVerifier.m_cclass[17] = 100663296;
			nsEUCTWVerifier.m_cclass[18] = 0;
			nsEUCTWVerifier.m_cclass[19] = 0;
			nsEUCTWVerifier.m_cclass[20] = 1145324592;
			nsEUCTWVerifier.m_cclass[21] = 286331221;
			nsEUCTWVerifier.m_cclass[22] = 286331153;
			nsEUCTWVerifier.m_cclass[23] = 286331153;
			nsEUCTWVerifier.m_cclass[24] = 858985233;
			nsEUCTWVerifier.m_cclass[25] = 858993459;
			nsEUCTWVerifier.m_cclass[26] = 858993459;
			nsEUCTWVerifier.m_cclass[27] = 858993459;
			nsEUCTWVerifier.m_cclass[28] = 858993459;
			nsEUCTWVerifier.m_cclass[29] = 858993459;
			nsEUCTWVerifier.m_cclass[30] = 858993459;
			nsEUCTWVerifier.m_cclass[31] = 53687091;
			nsEUCTWVerifier.m_states = new int[6];
			nsEUCTWVerifier.m_states[0] = 338898961;
			nsEUCTWVerifier.m_states[1] = 571543825;
			nsEUCTWVerifier.m_states[2] = 269623842;
			nsEUCTWVerifier.m_states[3] = 286330880;
			nsEUCTWVerifier.m_states[4] = 1052949;
			nsEUCTWVerifier.m_states[5] = 16;
			nsEUCTWVerifier.m_charset = "x-euc-tw";
			nsEUCTWVerifier.m_stFactor = 7;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000052CA File Offset: 0x000042CA
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x04000064 RID: 100
		private static int[] m_cclass;

		// Token: 0x04000065 RID: 101
		private static int[] m_states;

		// Token: 0x04000066 RID: 102
		private static int m_stFactor;

		// Token: 0x04000067 RID: 103
		private static string m_charset;
	}
}

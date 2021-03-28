using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000016 RID: 22
	public class nsEUCKRVerifier : nsVerifier
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00004BF0 File Offset: 0x00003BF0
		public override int[] cclass()
		{
			return nsEUCKRVerifier.m_cclass;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004BF7 File Offset: 0x00003BF7
		public override int[] states()
		{
			return nsEUCKRVerifier.m_states;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004BFE File Offset: 0x00003BFE
		public override int stFactor()
		{
			return nsEUCKRVerifier.m_stFactor;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004C05 File Offset: 0x00003C05
		public override string charset()
		{
			return nsEUCKRVerifier.m_charset;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004C0C File Offset: 0x00003C0C
		public nsEUCKRVerifier()
		{
			nsEUCKRVerifier.m_cclass = new int[32];
			nsEUCKRVerifier.m_cclass[0] = 286331153;
			nsEUCKRVerifier.m_cclass[1] = 1118481;
			nsEUCKRVerifier.m_cclass[2] = 286331153;
			nsEUCKRVerifier.m_cclass[3] = 286327057;
			nsEUCKRVerifier.m_cclass[4] = 286331153;
			nsEUCKRVerifier.m_cclass[5] = 286331153;
			nsEUCKRVerifier.m_cclass[6] = 286331153;
			nsEUCKRVerifier.m_cclass[7] = 286331153;
			nsEUCKRVerifier.m_cclass[8] = 286331153;
			nsEUCKRVerifier.m_cclass[9] = 286331153;
			nsEUCKRVerifier.m_cclass[10] = 286331153;
			nsEUCKRVerifier.m_cclass[11] = 286331153;
			nsEUCKRVerifier.m_cclass[12] = 286331153;
			nsEUCKRVerifier.m_cclass[13] = 286331153;
			nsEUCKRVerifier.m_cclass[14] = 286331153;
			nsEUCKRVerifier.m_cclass[15] = 286331153;
			nsEUCKRVerifier.m_cclass[16] = 0;
			nsEUCKRVerifier.m_cclass[17] = 0;
			nsEUCKRVerifier.m_cclass[18] = 0;
			nsEUCKRVerifier.m_cclass[19] = 0;
			nsEUCKRVerifier.m_cclass[20] = 572662304;
			nsEUCKRVerifier.m_cclass[21] = 858923554;
			nsEUCKRVerifier.m_cclass[22] = 572662306;
			nsEUCKRVerifier.m_cclass[23] = 572662306;
			nsEUCKRVerifier.m_cclass[24] = 572662306;
			nsEUCKRVerifier.m_cclass[25] = 572662322;
			nsEUCKRVerifier.m_cclass[26] = 572662306;
			nsEUCKRVerifier.m_cclass[27] = 572662306;
			nsEUCKRVerifier.m_cclass[28] = 572662306;
			nsEUCKRVerifier.m_cclass[29] = 572662306;
			nsEUCKRVerifier.m_cclass[30] = 572662306;
			nsEUCKRVerifier.m_cclass[31] = 35791394;
			nsEUCKRVerifier.m_states = new int[2];
			nsEUCKRVerifier.m_states[0] = 286331649;
			nsEUCKRVerifier.m_states[1] = 1122850;
			nsEUCKRVerifier.m_charset = "EUC-KR";
			nsEUCKRVerifier.m_stFactor = 4;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004DE5 File Offset: 0x00003DE5
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x04000059 RID: 89
		private static int[] m_cclass;

		// Token: 0x0400005A RID: 90
		private static int[] m_states;

		// Token: 0x0400005B RID: 91
		private static int m_stFactor;

		// Token: 0x0400005C RID: 92
		private static string m_charset;
	}
}

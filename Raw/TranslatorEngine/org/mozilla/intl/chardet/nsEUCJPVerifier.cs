using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000015 RID: 21
	public class nsEUCJPVerifier : nsVerifier
	{
		// Token: 0x06000088 RID: 136 RVA: 0x000049CF File Offset: 0x000039CF
		public override int[] cclass()
		{
			return nsEUCJPVerifier.m_cclass;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000049D6 File Offset: 0x000039D6
		public override int[] states()
		{
			return nsEUCJPVerifier.m_states;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000049DD File Offset: 0x000039DD
		public override int stFactor()
		{
			return nsEUCJPVerifier.m_stFactor;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000049E4 File Offset: 0x000039E4
		public override string charset()
		{
			return nsEUCJPVerifier.m_charset;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000049EC File Offset: 0x000039EC
		public nsEUCJPVerifier()
		{
			nsEUCJPVerifier.m_cclass = new int[32];
			nsEUCJPVerifier.m_cclass[0] = 1145324612;
			nsEUCJPVerifier.m_cclass[1] = 1430537284;
			nsEUCJPVerifier.m_cclass[2] = 1145324612;
			nsEUCJPVerifier.m_cclass[3] = 1145328708;
			nsEUCJPVerifier.m_cclass[4] = 1145324612;
			nsEUCJPVerifier.m_cclass[5] = 1145324612;
			nsEUCJPVerifier.m_cclass[6] = 1145324612;
			nsEUCJPVerifier.m_cclass[7] = 1145324612;
			nsEUCJPVerifier.m_cclass[8] = 1145324612;
			nsEUCJPVerifier.m_cclass[9] = 1145324612;
			nsEUCJPVerifier.m_cclass[10] = 1145324612;
			nsEUCJPVerifier.m_cclass[11] = 1145324612;
			nsEUCJPVerifier.m_cclass[12] = 1145324612;
			nsEUCJPVerifier.m_cclass[13] = 1145324612;
			nsEUCJPVerifier.m_cclass[14] = 1145324612;
			nsEUCJPVerifier.m_cclass[15] = 1145324612;
			nsEUCJPVerifier.m_cclass[16] = 1431655765;
			nsEUCJPVerifier.m_cclass[17] = 827675989;
			nsEUCJPVerifier.m_cclass[18] = 1431655765;
			nsEUCJPVerifier.m_cclass[19] = 1431655765;
			nsEUCJPVerifier.m_cclass[20] = 572662309;
			nsEUCJPVerifier.m_cclass[21] = 572662306;
			nsEUCJPVerifier.m_cclass[22] = 572662306;
			nsEUCJPVerifier.m_cclass[23] = 572662306;
			nsEUCJPVerifier.m_cclass[24] = 572662306;
			nsEUCJPVerifier.m_cclass[25] = 572662306;
			nsEUCJPVerifier.m_cclass[26] = 572662306;
			nsEUCJPVerifier.m_cclass[27] = 572662306;
			nsEUCJPVerifier.m_cclass[28] = 0;
			nsEUCJPVerifier.m_cclass[29] = 0;
			nsEUCJPVerifier.m_cclass[30] = 0;
			nsEUCJPVerifier.m_cclass[31] = 1342177280;
			nsEUCJPVerifier.m_states = new int[5];
			nsEUCJPVerifier.m_states[0] = 286282563;
			nsEUCJPVerifier.m_states[1] = 572657937;
			nsEUCJPVerifier.m_states[2] = 286265378;
			nsEUCJPVerifier.m_states[3] = 319885329;
			nsEUCJPVerifier.m_states[4] = 4371;
			nsEUCJPVerifier.m_charset = "EUC-JP";
			nsEUCJPVerifier.m_stFactor = 6;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004BED File Offset: 0x00003BED
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x04000055 RID: 85
		private static int[] m_cclass;

		// Token: 0x04000056 RID: 86
		private static int[] m_states;

		// Token: 0x04000057 RID: 87
		private static int m_stFactor;

		// Token: 0x04000058 RID: 88
		private static string m_charset;
	}
}

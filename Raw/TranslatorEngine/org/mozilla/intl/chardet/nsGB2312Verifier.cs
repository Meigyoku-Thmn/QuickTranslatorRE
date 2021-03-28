using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x0200001A RID: 26
	public class nsGB2312Verifier : nsVerifier
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00005505 File Offset: 0x00004505
		public override int[] cclass()
		{
			return nsGB2312Verifier.m_cclass;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000550C File Offset: 0x0000450C
		public override int[] states()
		{
			return nsGB2312Verifier.m_states;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005513 File Offset: 0x00004513
		public override int stFactor()
		{
			return nsGB2312Verifier.m_stFactor;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000551A File Offset: 0x0000451A
		public override string charset()
		{
			return nsGB2312Verifier.m_charset;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005524 File Offset: 0x00004524
		public nsGB2312Verifier()
		{
			nsGB2312Verifier.m_cclass = new int[32];
			nsGB2312Verifier.m_cclass[0] = 286331153;
			nsGB2312Verifier.m_cclass[1] = 1118481;
			nsGB2312Verifier.m_cclass[2] = 286331153;
			nsGB2312Verifier.m_cclass[3] = 286327057;
			nsGB2312Verifier.m_cclass[4] = 286331153;
			nsGB2312Verifier.m_cclass[5] = 286331153;
			nsGB2312Verifier.m_cclass[6] = 286331153;
			nsGB2312Verifier.m_cclass[7] = 286331153;
			nsGB2312Verifier.m_cclass[8] = 286331153;
			nsGB2312Verifier.m_cclass[9] = 286331153;
			nsGB2312Verifier.m_cclass[10] = 286331153;
			nsGB2312Verifier.m_cclass[11] = 286331153;
			nsGB2312Verifier.m_cclass[12] = 286331153;
			nsGB2312Verifier.m_cclass[13] = 286331153;
			nsGB2312Verifier.m_cclass[14] = 286331153;
			nsGB2312Verifier.m_cclass[15] = 286331153;
			nsGB2312Verifier.m_cclass[16] = 0;
			nsGB2312Verifier.m_cclass[17] = 0;
			nsGB2312Verifier.m_cclass[18] = 0;
			nsGB2312Verifier.m_cclass[19] = 0;
			nsGB2312Verifier.m_cclass[20] = 572662304;
			nsGB2312Verifier.m_cclass[21] = 858993442;
			nsGB2312Verifier.m_cclass[22] = 572662306;
			nsGB2312Verifier.m_cclass[23] = 572662306;
			nsGB2312Verifier.m_cclass[24] = 572662306;
			nsGB2312Verifier.m_cclass[25] = 572662306;
			nsGB2312Verifier.m_cclass[26] = 572662306;
			nsGB2312Verifier.m_cclass[27] = 572662306;
			nsGB2312Verifier.m_cclass[28] = 572662306;
			nsGB2312Verifier.m_cclass[29] = 572662306;
			nsGB2312Verifier.m_cclass[30] = 572662306;
			nsGB2312Verifier.m_cclass[31] = 35791394;
			nsGB2312Verifier.m_states = new int[2];
			nsGB2312Verifier.m_states[0] = 286331649;
			nsGB2312Verifier.m_states[1] = 1122850;
			nsGB2312Verifier.m_charset = "GB2312";
			nsGB2312Verifier.m_stFactor = 4;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000056FD File Offset: 0x000046FD
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x0400006C RID: 108
		private static int[] m_cclass;

		// Token: 0x0400006D RID: 109
		private static int[] m_states;

		// Token: 0x0400006E RID: 110
		private static int m_stFactor;

		// Token: 0x0400006F RID: 111
		private static string m_charset;
	}
}

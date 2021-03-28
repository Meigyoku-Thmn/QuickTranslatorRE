using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000011 RID: 17
	public class nsCP1252Verifier : nsVerifier
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00003E58 File Offset: 0x00002E58
		public override int[] cclass()
		{
			return nsCP1252Verifier.m_cclass;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003E5F File Offset: 0x00002E5F
		public override int[] states()
		{
			return nsCP1252Verifier.m_states;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003E66 File Offset: 0x00002E66
		public override int stFactor()
		{
			return nsCP1252Verifier.m_stFactor;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003E6D File Offset: 0x00002E6D
		public override string charset()
		{
			return nsCP1252Verifier.m_charset;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003E74 File Offset: 0x00002E74
		public nsCP1252Verifier()
		{
			nsCP1252Verifier.m_cclass = new int[32];
			nsCP1252Verifier.m_cclass[0] = 572662305;
			nsCP1252Verifier.m_cclass[1] = 2236962;
			nsCP1252Verifier.m_cclass[2] = 572662306;
			nsCP1252Verifier.m_cclass[3] = 572654114;
			nsCP1252Verifier.m_cclass[4] = 572662306;
			nsCP1252Verifier.m_cclass[5] = 572662306;
			nsCP1252Verifier.m_cclass[6] = 572662306;
			nsCP1252Verifier.m_cclass[7] = 572662306;
			nsCP1252Verifier.m_cclass[8] = 572662306;
			nsCP1252Verifier.m_cclass[9] = 572662306;
			nsCP1252Verifier.m_cclass[10] = 572662306;
			nsCP1252Verifier.m_cclass[11] = 572662306;
			nsCP1252Verifier.m_cclass[12] = 572662306;
			nsCP1252Verifier.m_cclass[13] = 572662306;
			nsCP1252Verifier.m_cclass[14] = 572662306;
			nsCP1252Verifier.m_cclass[15] = 572662306;
			nsCP1252Verifier.m_cclass[16] = 572662274;
			nsCP1252Verifier.m_cclass[17] = 16851234;
			nsCP1252Verifier.m_cclass[18] = 572662304;
			nsCP1252Verifier.m_cclass[19] = 285286690;
			nsCP1252Verifier.m_cclass[20] = 572662306;
			nsCP1252Verifier.m_cclass[21] = 572662306;
			nsCP1252Verifier.m_cclass[22] = 572662306;
			nsCP1252Verifier.m_cclass[23] = 572662306;
			nsCP1252Verifier.m_cclass[24] = 286331153;
			nsCP1252Verifier.m_cclass[25] = 286331153;
			nsCP1252Verifier.m_cclass[26] = 554766609;
			nsCP1252Verifier.m_cclass[27] = 286331153;
			nsCP1252Verifier.m_cclass[28] = 286331153;
			nsCP1252Verifier.m_cclass[29] = 286331153;
			nsCP1252Verifier.m_cclass[30] = 554766609;
			nsCP1252Verifier.m_cclass[31] = 286331153;
			nsCP1252Verifier.m_states = new int[3];
			nsCP1252Verifier.m_states[0] = 571543601;
			nsCP1252Verifier.m_states[1] = 340853778;
			nsCP1252Verifier.m_states[2] = 65;
			nsCP1252Verifier.m_charset = "windows-1252";
			nsCP1252Verifier.m_stFactor = 3;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004066 File Offset: 0x00003066
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x0400003E RID: 62
		private static int[] m_cclass;

		// Token: 0x0400003F RID: 63
		private static int[] m_states;

		// Token: 0x04000040 RID: 64
		private static int m_stFactor;

		// Token: 0x04000041 RID: 65
		private static string m_charset;
	}
}

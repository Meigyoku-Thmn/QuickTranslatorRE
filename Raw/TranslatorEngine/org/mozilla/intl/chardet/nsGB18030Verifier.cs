using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000019 RID: 25
	public class nsGB18030Verifier : nsVerifier
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000052CD File Offset: 0x000042CD
		public override int[] cclass()
		{
			return nsGB18030Verifier.m_cclass;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000052D4 File Offset: 0x000042D4
		public override int[] states()
		{
			return nsGB18030Verifier.m_states;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000052DB File Offset: 0x000042DB
		public override int stFactor()
		{
			return nsGB18030Verifier.m_stFactor;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000052E2 File Offset: 0x000042E2
		public override string charset()
		{
			return nsGB18030Verifier.m_charset;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000052EC File Offset: 0x000042EC
		public nsGB18030Verifier()
		{
			nsGB18030Verifier.m_cclass = new int[32];
			nsGB18030Verifier.m_cclass[0] = 286331153;
			nsGB18030Verifier.m_cclass[1] = 1118481;
			nsGB18030Verifier.m_cclass[2] = 286331153;
			nsGB18030Verifier.m_cclass[3] = 286327057;
			nsGB18030Verifier.m_cclass[4] = 286331153;
			nsGB18030Verifier.m_cclass[5] = 286331153;
			nsGB18030Verifier.m_cclass[6] = 858993459;
			nsGB18030Verifier.m_cclass[7] = 286331187;
			nsGB18030Verifier.m_cclass[8] = 572662306;
			nsGB18030Verifier.m_cclass[9] = 572662306;
			nsGB18030Verifier.m_cclass[10] = 572662306;
			nsGB18030Verifier.m_cclass[11] = 572662306;
			nsGB18030Verifier.m_cclass[12] = 572662306;
			nsGB18030Verifier.m_cclass[13] = 572662306;
			nsGB18030Verifier.m_cclass[14] = 572662306;
			nsGB18030Verifier.m_cclass[15] = 1109533218;
			nsGB18030Verifier.m_cclass[16] = 1717986917;
			nsGB18030Verifier.m_cclass[17] = 1717986918;
			nsGB18030Verifier.m_cclass[18] = 1717986918;
			nsGB18030Verifier.m_cclass[19] = 1717986918;
			nsGB18030Verifier.m_cclass[20] = 1717986918;
			nsGB18030Verifier.m_cclass[21] = 1717986918;
			nsGB18030Verifier.m_cclass[22] = 1717986918;
			nsGB18030Verifier.m_cclass[23] = 1717986918;
			nsGB18030Verifier.m_cclass[24] = 1717986918;
			nsGB18030Verifier.m_cclass[25] = 1717986918;
			nsGB18030Verifier.m_cclass[26] = 1717986918;
			nsGB18030Verifier.m_cclass[27] = 1717986918;
			nsGB18030Verifier.m_cclass[28] = 1717986918;
			nsGB18030Verifier.m_cclass[29] = 1717986918;
			nsGB18030Verifier.m_cclass[30] = 1717986918;
			nsGB18030Verifier.m_cclass[31] = 107374182;
			nsGB18030Verifier.m_states = new int[6];
			nsGB18030Verifier.m_states[0] = 318767105;
			nsGB18030Verifier.m_states[1] = 571543825;
			nsGB18030Verifier.m_states[2] = 17965602;
			nsGB18030Verifier.m_states[3] = 286326804;
			nsGB18030Verifier.m_states[4] = 303109393;
			nsGB18030Verifier.m_states[5] = 17;
			nsGB18030Verifier.m_charset = "GB18030";
			nsGB18030Verifier.m_stFactor = 7;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005502 File Offset: 0x00004502
		public override bool isUCS2()
		{
			return false;
		}

		// Token: 0x04000068 RID: 104
		private static int[] m_cclass;

		// Token: 0x04000069 RID: 105
		private static int[] m_states;

		// Token: 0x0400006A RID: 106
		private static int m_stFactor;

		// Token: 0x0400006B RID: 107
		private static string m_charset;
	}
}

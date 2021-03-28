using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000021 RID: 33
	public class nsUCS2LEVerifier : nsVerifier
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0000630C File Offset: 0x0000530C
		public override int[] cclass()
		{
			return nsUCS2LEVerifier.m_cclass;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006313 File Offset: 0x00005313
		public override int[] states()
		{
			return nsUCS2LEVerifier.m_states;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000631A File Offset: 0x0000531A
		public override int stFactor()
		{
			return nsUCS2LEVerifier.m_stFactor;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00006321 File Offset: 0x00005321
		public override string charset()
		{
			return nsUCS2LEVerifier.m_charset;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006328 File Offset: 0x00005328
		public nsUCS2LEVerifier()
		{
			nsUCS2LEVerifier.m_cclass = new int[32];
			nsUCS2LEVerifier.m_cclass[0] = 0;
			nsUCS2LEVerifier.m_cclass[1] = 2097408;
			nsUCS2LEVerifier.m_cclass[2] = 0;
			nsUCS2LEVerifier.m_cclass[3] = 12288;
			nsUCS2LEVerifier.m_cclass[4] = 0;
			nsUCS2LEVerifier.m_cclass[5] = 3355440;
			nsUCS2LEVerifier.m_cclass[6] = 0;
			nsUCS2LEVerifier.m_cclass[7] = 0;
			nsUCS2LEVerifier.m_cclass[8] = 0;
			nsUCS2LEVerifier.m_cclass[9] = 0;
			nsUCS2LEVerifier.m_cclass[10] = 0;
			nsUCS2LEVerifier.m_cclass[11] = 0;
			nsUCS2LEVerifier.m_cclass[12] = 0;
			nsUCS2LEVerifier.m_cclass[13] = 0;
			nsUCS2LEVerifier.m_cclass[14] = 0;
			nsUCS2LEVerifier.m_cclass[15] = 0;
			nsUCS2LEVerifier.m_cclass[16] = 0;
			nsUCS2LEVerifier.m_cclass[17] = 0;
			nsUCS2LEVerifier.m_cclass[18] = 0;
			nsUCS2LEVerifier.m_cclass[19] = 0;
			nsUCS2LEVerifier.m_cclass[20] = 0;
			nsUCS2LEVerifier.m_cclass[21] = 0;
			nsUCS2LEVerifier.m_cclass[22] = 0;
			nsUCS2LEVerifier.m_cclass[23] = 0;
			nsUCS2LEVerifier.m_cclass[24] = 0;
			nsUCS2LEVerifier.m_cclass[25] = 0;
			nsUCS2LEVerifier.m_cclass[26] = 0;
			nsUCS2LEVerifier.m_cclass[27] = 0;
			nsUCS2LEVerifier.m_cclass[28] = 0;
			nsUCS2LEVerifier.m_cclass[29] = 0;
			nsUCS2LEVerifier.m_cclass[30] = 0;
			nsUCS2LEVerifier.m_cclass[31] = 1409286144;
			nsUCS2LEVerifier.m_states = new int[7];
			nsUCS2LEVerifier.m_states[0] = 288647014;
			nsUCS2LEVerifier.m_states[1] = 572657937;
			nsUCS2LEVerifier.m_states[2] = 303387938;
			nsUCS2LEVerifier.m_states[3] = 1712657749;
			nsUCS2LEVerifier.m_states[4] = 357927015;
			nsUCS2LEVerifier.m_states[5] = 1427182933;
			nsUCS2LEVerifier.m_states[6] = 1381717;
			nsUCS2LEVerifier.m_charset = "UTF-16LE";
			nsUCS2LEVerifier.m_stFactor = 6;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000064DD File Offset: 0x000054DD
		public override bool isUCS2()
		{
			return true;
		}

		// Token: 0x04000088 RID: 136
		private static int[] m_cclass;

		// Token: 0x04000089 RID: 137
		private static int[] m_states;

		// Token: 0x0400008A RID: 138
		private static int m_stFactor;

		// Token: 0x0400008B RID: 139
		private static string m_charset;
	}
}

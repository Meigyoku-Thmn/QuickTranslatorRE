using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000014 RID: 20
	public class nsDetector : nsPSMDetector, nsICharsetDetector
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00004954 File Offset: 0x00003954
		public nsDetector()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000495C File Offset: 0x0000395C
		public nsDetector(int langFlag) : base(langFlag)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004965 File Offset: 0x00003965
		public void Init(nsICharsetDetectionObserver aObserver)
		{
			this.mObserver = aObserver;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000496E File Offset: 0x0000396E
		public bool DoIt(byte[] aBuf, int aLen, bool oDontFeedMe)
		{
			if (aBuf == null || oDontFeedMe)
			{
				return false;
			}
			base.HandleData(aBuf, aLen);
			return this.mDone;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004987 File Offset: 0x00003987
		public void Done()
		{
			base.DataEnd();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000498F File Offset: 0x0000398F
		public override void Report(string charset)
		{
			if (this.mObserver != null)
			{
				this.mObserver.Notify(charset);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000049A8 File Offset: 0x000039A8
		public bool isAscii(byte[] aBuf, int aLen)
		{
			for (int i = 0; i < aLen; i++)
			{
				if ((128 & aBuf[i]) != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000054 RID: 84
		private nsICharsetDetectionObserver mObserver;
	}
}

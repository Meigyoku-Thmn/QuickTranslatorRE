using System;

namespace org.mozilla.intl.chardet
{
	// Token: 0x02000013 RID: 19
	public interface nsICharsetDetector
	{
		// Token: 0x0600007E RID: 126
		void Init(nsICharsetDetectionObserver observer);

		// Token: 0x0600007F RID: 127
		bool DoIt(byte[] aBuf, int aLen, bool oDontFeedMe);

		// Token: 0x06000080 RID: 128
		void Done();
	}
}

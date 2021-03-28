using System;
using org.mozilla.intl.chardet;

namespace TranslatorEngine
{
	// Token: 0x02000006 RID: 6
	public class Notifier : nsICharsetDetectionObserver
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002210 File Offset: 0x00001210
		public void Notify(string charset)
		{
			CharsetDetector.DetectedCharset = charset;
		}
	}
}

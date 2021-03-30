using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000011 RID: 17
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [Serializable]
    public class NewsArticle
    {
        // Token: 0x04000050 RID: 80
        public string Title;

        // Token: 0x04000051 RID: 81
        public string Url;

        // Token: 0x04000052 RID: 82
        public string Source;

        // Token: 0x04000053 RID: 83
        public string Snippet;

        // Token: 0x04000054 RID: 84
        public string Date;
    }
}

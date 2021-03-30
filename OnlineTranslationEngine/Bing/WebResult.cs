using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000023 RID: 35
    [DebuggerStepThrough]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DesignerCategory("code")]
    [Serializable]
    public class WebResult
    {
        // Token: 0x040000B7 RID: 183
        public string Title;

        // Token: 0x040000B8 RID: 184
        public string Description;

        // Token: 0x040000B9 RID: 185
        public string Url;

        // Token: 0x040000BA RID: 186
        public string CacheUrl;

        // Token: 0x040000BB RID: 187
        public string DisplayUrl;

        // Token: 0x040000BC RID: 188
        public string DateTime;

        // Token: 0x040000BD RID: 189
        [XmlArrayItem(IsNullable = false)]
        public WebSearchTag[] SearchTags;

        // Token: 0x040000BE RID: 190
        [XmlArrayItem(IsNullable = false)]
        public DeepLink[] DeepLinks;
    }
}

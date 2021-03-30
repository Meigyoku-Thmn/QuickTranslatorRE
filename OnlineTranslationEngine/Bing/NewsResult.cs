using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000013 RID: 19
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [Serializable]
    public class NewsResult
    {
        // Token: 0x04000057 RID: 87
        public string Title;

        // Token: 0x04000058 RID: 88
        public string Url;

        // Token: 0x04000059 RID: 89
        public string Source;

        // Token: 0x0400005A RID: 90
        public string Snippet;

        // Token: 0x0400005B RID: 91
        public string Date;

        // Token: 0x0400005C RID: 92
        public uint BreakingNews;

        // Token: 0x0400005D RID: 93
        [XmlIgnore]
        public bool BreakingNewsSpecified;

        // Token: 0x0400005E RID: 94
        [XmlArrayItem(IsNullable = false)]
        public NewsCollection[] NewsCollections;
    }
}

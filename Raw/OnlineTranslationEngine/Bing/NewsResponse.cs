using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000015 RID: 21
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DesignerCategory("code")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [Serializable]
    public class NewsResponse
    {
        // Token: 0x04000061 RID: 97
        public uint Total;

        // Token: 0x04000062 RID: 98
        [XmlIgnore]
        public bool TotalSpecified;

        // Token: 0x04000063 RID: 99
        public uint Offset;

        // Token: 0x04000064 RID: 100
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x04000065 RID: 101
        [XmlArrayItem(IsNullable = false)]
        public NewsRelatedSearch[] RelatedSearches;

        // Token: 0x04000066 RID: 102
        [XmlArrayItem(IsNullable = false)]
        public NewsResult[] Results;
    }
}

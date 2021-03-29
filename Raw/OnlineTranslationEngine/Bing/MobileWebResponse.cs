using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000010 RID: 16
    [DebuggerStepThrough]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [Serializable]
    public class MobileWebResponse
    {
        // Token: 0x0400004B RID: 75
        public uint Total;

        // Token: 0x0400004C RID: 76
        [XmlIgnore]
        public bool TotalSpecified;

        // Token: 0x0400004D RID: 77
        public uint Offset;

        // Token: 0x0400004E RID: 78
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x0400004F RID: 79
        [XmlArrayItem(IsNullable = false)]
        public MobileWebResult[] Results;
    }
}

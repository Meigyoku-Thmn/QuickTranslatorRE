using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000024 RID: 36
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class WebResponse
    {
        // Token: 0x040000BF RID: 191
        public uint Total;

        // Token: 0x040000C0 RID: 192
        [XmlIgnore]
        public bool TotalSpecified;

        // Token: 0x040000C1 RID: 193
        public uint Offset;

        // Token: 0x040000C2 RID: 194
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x040000C3 RID: 195
        [XmlArrayItem(IsNullable = false)]
        public WebResult[] Results;
    }
}

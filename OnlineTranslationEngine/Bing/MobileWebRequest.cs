using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200002A RID: 42
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class MobileWebRequest
    {
        // Token: 0x040000DA RID: 218
        public uint Offset;

        // Token: 0x040000DB RID: 219
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x040000DC RID: 220
        public uint Count;

        // Token: 0x040000DD RID: 221
        [XmlIgnore]
        public bool CountSpecified;

        // Token: 0x040000DE RID: 222
        public MobileWebSearchOption[] Options;
    }
}

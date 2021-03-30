using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000026 RID: 38
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class SpellResponse
    {
        // Token: 0x040000C5 RID: 197
        public uint Total;

        // Token: 0x040000C6 RID: 198
        [XmlIgnore]
        public bool TotalSpecified;

        // Token: 0x040000C7 RID: 199
        [XmlArrayItem(IsNullable = false)]
        public SpellResult[] Results;
    }
}

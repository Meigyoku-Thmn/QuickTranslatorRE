using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000020 RID: 32
    [DebuggerStepThrough]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [Serializable]
    public class ImageResponse
    {
        // Token: 0x040000AE RID: 174
        public uint Total;

        // Token: 0x040000AF RID: 175
        [XmlIgnore]
        public bool TotalSpecified;

        // Token: 0x040000B0 RID: 176
        public uint Offset;

        // Token: 0x040000B1 RID: 177
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x040000B2 RID: 178
        [XmlArrayItem(IsNullable = false)]
        public ImageResult[] Results;
    }
}

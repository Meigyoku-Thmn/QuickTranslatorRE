using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200001A RID: 26
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DesignerCategory("code")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [Serializable]
    public class VideoResponse
    {
        // Token: 0x0400007F RID: 127
        public uint Total;

        // Token: 0x04000080 RID: 128
        [XmlIgnore]
        public bool TotalSpecified;

        // Token: 0x04000081 RID: 129
        public uint Offset;

        // Token: 0x04000082 RID: 130
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x04000083 RID: 131
        [XmlArrayItem(IsNullable = false)]
        public VideoResult[] Results;
    }
}

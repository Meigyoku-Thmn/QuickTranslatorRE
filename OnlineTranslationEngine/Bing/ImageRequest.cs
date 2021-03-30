using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000032 RID: 50
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DesignerCategory("code")]
    [Serializable]
    public class ImageRequest
    {
        // Token: 0x04000104 RID: 260
        public uint Offset;

        // Token: 0x04000105 RID: 261
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x04000106 RID: 262
        public uint Count;

        // Token: 0x04000107 RID: 263
        [XmlIgnore]
        public bool CountSpecified;

        // Token: 0x04000108 RID: 264
        [XmlArrayItem(IsNullable = false)]
        public string[] Filters;
    }
}

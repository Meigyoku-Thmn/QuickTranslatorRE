using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200002E RID: 46
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class VideoRequest
    {
        // Token: 0x040000ED RID: 237
        public uint Offset;

        // Token: 0x040000EE RID: 238
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x040000EF RID: 239
        public uint Count;

        // Token: 0x040000F0 RID: 240
        [XmlIgnore]
        public bool CountSpecified;

        // Token: 0x040000F1 RID: 241
        [XmlArrayItem(IsNullable = false)]
        public string[] Filters;

        // Token: 0x040000F2 RID: 242
        public VideoSortOption SortBy;

        // Token: 0x040000F3 RID: 243
        [XmlIgnore]
        public bool SortBySpecified;
    }
}

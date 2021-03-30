using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000030 RID: 48
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DebuggerStepThrough]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [Serializable]
    public class PhonebookRequest
    {
        // Token: 0x040000F7 RID: 247
        public uint Offset;

        // Token: 0x040000F8 RID: 248
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x040000F9 RID: 249
        public uint Count;

        // Token: 0x040000FA RID: 250
        [XmlIgnore]
        public bool CountSpecified;

        // Token: 0x040000FB RID: 251
        public string FileType;

        // Token: 0x040000FC RID: 252
        public PhonebookSortOption SortBy;

        // Token: 0x040000FD RID: 253
        [XmlIgnore]
        public bool SortBySpecified;

        // Token: 0x040000FE RID: 254
        public string LocId;

        // Token: 0x040000FF RID: 255
        public string Category;
    }
}

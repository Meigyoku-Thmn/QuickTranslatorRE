using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200002C RID: 44
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DebuggerStepThrough]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [Serializable]
    public class NewsRequest
    {
        // Token: 0x040000E2 RID: 226
        public uint Offset;

        // Token: 0x040000E3 RID: 227
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x040000E4 RID: 228
        public uint Count;

        // Token: 0x040000E5 RID: 229
        [XmlIgnore]
        public bool CountSpecified;

        // Token: 0x040000E6 RID: 230
        public string LocationOverride;

        // Token: 0x040000E7 RID: 231
        public string Category;

        // Token: 0x040000E8 RID: 232
        public NewsSortOption SortBy;

        // Token: 0x040000E9 RID: 233
        [XmlIgnore]
        public bool SortBySpecified;
    }
}

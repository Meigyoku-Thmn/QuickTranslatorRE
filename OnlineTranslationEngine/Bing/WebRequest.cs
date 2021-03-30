using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200000A RID: 10
    [DebuggerStepThrough]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DesignerCategory("code")]
    [Serializable]
    public class WebRequest
    {
        // Token: 0x04000031 RID: 49
        public uint Offset;

        // Token: 0x04000032 RID: 50
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x04000033 RID: 51
        public uint Count;

        // Token: 0x04000034 RID: 52
        [XmlIgnore]
        public bool CountSpecified;

        // Token: 0x04000035 RID: 53
        public string FileType;

        // Token: 0x04000036 RID: 54
        public WebSearchOption[] Options;

        // Token: 0x04000037 RID: 55
        [XmlArrayItem(IsNullable = false)]
        public string[] SearchTags;
    }
}

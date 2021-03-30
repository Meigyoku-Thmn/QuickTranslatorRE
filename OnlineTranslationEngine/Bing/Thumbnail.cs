using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000019 RID: 25
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class Thumbnail
    {
        // Token: 0x04000075 RID: 117
        public string Url;

        // Token: 0x04000076 RID: 118
        public string ContentType;

        // Token: 0x04000077 RID: 119
        public uint Width;

        // Token: 0x04000078 RID: 120
        [XmlIgnore]
        public bool WidthSpecified;

        // Token: 0x04000079 RID: 121
        public uint Height;

        // Token: 0x0400007A RID: 122
        [XmlIgnore]
        public bool HeightSpecified;

        // Token: 0x0400007B RID: 123
        public uint FileSize;

        // Token: 0x0400007C RID: 124
        [XmlIgnore]
        public bool FileSizeSpecified;

        // Token: 0x0400007D RID: 125
        public uint RunTime;

        // Token: 0x0400007E RID: 126
        [XmlIgnore]
        public bool RunTimeSpecified;
    }
}

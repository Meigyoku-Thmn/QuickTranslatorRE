using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000018 RID: 24
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DesignerCategory("code")]
    [DebuggerStepThrough]
    [Serializable]
    public class VideoResult
    {
        // Token: 0x0400006E RID: 110
        public string Title;

        // Token: 0x0400006F RID: 111
        public string PlayUrl;

        // Token: 0x04000070 RID: 112
        public string SourceTitle;

        // Token: 0x04000071 RID: 113
        public uint RunTime;

        // Token: 0x04000072 RID: 114
        [XmlIgnore]
        public bool RunTimeSpecified;

        // Token: 0x04000073 RID: 115
        public string ClickThroughPageUrl;

        // Token: 0x04000074 RID: 116
        public Thumbnail StaticThumbnail;
    }
}

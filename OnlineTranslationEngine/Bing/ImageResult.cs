using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200001F RID: 31
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class ImageResult
    {
        // Token: 0x040000A2 RID: 162
        public string Title;

        // Token: 0x040000A3 RID: 163
        public string MediaUrl;

        // Token: 0x040000A4 RID: 164
        public string Url;

        // Token: 0x040000A5 RID: 165
        public string DisplayUrl;

        // Token: 0x040000A6 RID: 166
        public uint Width;

        // Token: 0x040000A7 RID: 167
        [XmlIgnore]
        public bool WidthSpecified;

        // Token: 0x040000A8 RID: 168
        public uint Height;

        // Token: 0x040000A9 RID: 169
        [XmlIgnore]
        public bool HeightSpecified;

        // Token: 0x040000AA RID: 170
        public uint FileSize;

        // Token: 0x040000AB RID: 171
        [XmlIgnore]
        public bool FileSizeSpecified;

        // Token: 0x040000AC RID: 172
        public string ContentType;

        // Token: 0x040000AD RID: 173
        public Thumbnail Thumbnail;
    }
}

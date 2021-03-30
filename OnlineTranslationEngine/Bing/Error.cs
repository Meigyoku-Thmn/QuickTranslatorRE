using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200000C RID: 12
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class Error
    {
        // Token: 0x0400003B RID: 59
        public uint Code;

        // Token: 0x0400003C RID: 60
        [XmlIgnore]
        public bool CodeSpecified;

        // Token: 0x0400003D RID: 61
        public string Message;

        // Token: 0x0400003E RID: 62
        public string Parameter;

        // Token: 0x0400003F RID: 63
        public string Value;

        // Token: 0x04000040 RID: 64
        public string HelpUrl;

        // Token: 0x04000041 RID: 65
        public string SourceType;

        // Token: 0x04000042 RID: 66
        public uint SourceTypeErrorCode;

        // Token: 0x04000043 RID: 67
        [XmlIgnore]
        public bool SourceTypeErrorCodeSpecified;
    }
}

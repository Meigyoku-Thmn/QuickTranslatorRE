using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200000F RID: 15
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class MobileWebResult
    {
        // Token: 0x04000046 RID: 70
        public string Title;

        // Token: 0x04000047 RID: 71
        public string Description;

        // Token: 0x04000048 RID: 72
        public string Url;

        // Token: 0x04000049 RID: 73
        public string DisplayUrl;

        // Token: 0x0400004A RID: 74
        public string DateTime;
    }
}

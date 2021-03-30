using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000016 RID: 22
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class InstantAnswerResult
    {
        // Token: 0x04000067 RID: 103
        public string ContentType;

        // Token: 0x04000068 RID: 104
        public string Title;

        // Token: 0x04000069 RID: 105
        public string ClickThroughUrl;

        // Token: 0x0400006A RID: 106
        public string Url;

        // Token: 0x0400006B RID: 107
        public string Attribution;

        // Token: 0x0400006C RID: 108
        public string InstantAnswerSpecificData;
    }
}

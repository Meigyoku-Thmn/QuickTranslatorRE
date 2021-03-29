using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000029 RID: 41
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [Serializable]
    public class TranslationRequest
    {
        // Token: 0x040000D8 RID: 216
        public string SourceLanguage;

        // Token: 0x040000D9 RID: 217
        public string TargetLanguage;
    }
}

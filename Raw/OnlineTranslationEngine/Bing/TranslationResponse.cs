using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200000E RID: 14
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [Serializable]
    public class TranslationResponse
    {
        // Token: 0x04000045 RID: 69
        [XmlArrayItem(IsNullable = false)]
        public TranslationResult[] Results;
    }
}

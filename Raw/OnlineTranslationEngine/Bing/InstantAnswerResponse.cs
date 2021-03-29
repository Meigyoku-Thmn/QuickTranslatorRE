using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000017 RID: 23
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [Serializable]
    public class InstantAnswerResponse
    {
        // Token: 0x0400006D RID: 109
        [XmlArrayItem(IsNullable = false)]
        public InstantAnswerResult[] Results;
    }
}

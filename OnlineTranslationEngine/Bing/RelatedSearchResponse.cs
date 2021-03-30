using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200001E RID: 30
    [DebuggerStepThrough]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DesignerCategory("code")]
    [Serializable]
    public class RelatedSearchResponse
    {
        // Token: 0x040000A1 RID: 161
        [XmlArrayItem(IsNullable = false)]
        public RelatedSearchResult[] Results;
    }
}

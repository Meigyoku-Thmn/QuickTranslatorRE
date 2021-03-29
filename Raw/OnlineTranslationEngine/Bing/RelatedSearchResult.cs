using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200001D RID: 29
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class RelatedSearchResult
    {
        // Token: 0x0400009F RID: 159
        public string Title;

        // Token: 0x040000A0 RID: 160
        public string Url;
    }
}

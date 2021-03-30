using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000027 RID: 39
    [DebuggerStepThrough]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DesignerCategory("code")]
    [Serializable]
    public class Query
    {
        // Token: 0x040000C8 RID: 200
        public string SearchTerms;

        // Token: 0x040000C9 RID: 201
        public string AlteredQuery;

        // Token: 0x040000CA RID: 202
        public string AlterationOverrideQuery;
    }
}

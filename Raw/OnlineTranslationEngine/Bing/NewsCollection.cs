using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000012 RID: 18
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DesignerCategory("code")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [Serializable]
    public class NewsCollection
    {
        // Token: 0x04000055 RID: 85
        public string Name;

        // Token: 0x04000056 RID: 86
        [XmlArrayItem(IsNullable = false)]
        public NewsArticle[] NewsArticles;
    }
}

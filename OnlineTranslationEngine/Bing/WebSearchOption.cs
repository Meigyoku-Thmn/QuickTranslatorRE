using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200000B RID: 11
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [Serializable]
    public enum WebSearchOption
    {
        // Token: 0x04000039 RID: 57
        DisableHostCollapsing,
        // Token: 0x0400003A RID: 58
        DisableQueryAlterations
    }
}

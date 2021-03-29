using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000007 RID: 7
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [Serializable]
    public enum AdultOption
    {
        // Token: 0x0400001B RID: 27
        Off,
        // Token: 0x0400001C RID: 28
        Moderate,
        // Token: 0x0400001D RID: 29
        Strict
    }
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200001C RID: 28
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DesignerCategory("code")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DebuggerStepThrough]
    [Serializable]
    public class PhonebookResponse
    {
        // Token: 0x04000098 RID: 152
        public uint Total;

        // Token: 0x04000099 RID: 153
        [XmlIgnore]
        public bool TotalSpecified;

        // Token: 0x0400009A RID: 154
        public uint Offset;

        // Token: 0x0400009B RID: 155
        [XmlIgnore]
        public bool OffsetSpecified;

        // Token: 0x0400009C RID: 156
        public string LocalSerpUrl;

        // Token: 0x0400009D RID: 157
        public string Title;

        // Token: 0x0400009E RID: 158
        [XmlArrayItem(IsNullable = false)]
        public PhonebookResult[] Results;
    }
}

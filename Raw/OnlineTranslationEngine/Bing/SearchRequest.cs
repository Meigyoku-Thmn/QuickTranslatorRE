using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000006 RID: 6
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [DesignerCategory("code")]
    [Serializable]
    public class SearchRequest
    {
        // Token: 0x06000013 RID: 19 RVA: 0x0000299D File Offset: 0x0000199D
        public SearchRequest()
        {
            this.Version = "2.2";
        }

        // Token: 0x04000004 RID: 4
        [DefaultValue("2.2")]
        public string Version;

        // Token: 0x04000005 RID: 5
        public string Market;

        // Token: 0x04000006 RID: 6
        public string UILanguage;

        // Token: 0x04000007 RID: 7
        public string Query;

        // Token: 0x04000008 RID: 8
        public string AppId;

        // Token: 0x04000009 RID: 9
        public AdultOption Adult;

        // Token: 0x0400000A RID: 10
        [XmlIgnore]
        public bool AdultSpecified;

        // Token: 0x0400000B RID: 11
        public double Latitude;

        // Token: 0x0400000C RID: 12
        [XmlIgnore]
        public bool LatitudeSpecified;

        // Token: 0x0400000D RID: 13
        public double Longitude;

        // Token: 0x0400000E RID: 14
        [XmlIgnore]
        public bool LongitudeSpecified;

        // Token: 0x0400000F RID: 15
        public double Radius;

        // Token: 0x04000010 RID: 16
        [XmlIgnore]
        public bool RadiusSpecified;

        // Token: 0x04000011 RID: 17
        public SearchOption[] Options;

        // Token: 0x04000012 RID: 18
        public SourceType[] Sources;

        // Token: 0x04000013 RID: 19
        public WebRequest Web;

        // Token: 0x04000014 RID: 20
        public ImageRequest Image;

        // Token: 0x04000015 RID: 21
        public PhonebookRequest Phonebook;

        // Token: 0x04000016 RID: 22
        public VideoRequest Video;

        // Token: 0x04000017 RID: 23
        public NewsRequest News;

        // Token: 0x04000018 RID: 24
        public MobileWebRequest MobileWeb;

        // Token: 0x04000019 RID: 25
        public TranslationRequest Translation;
    }
}

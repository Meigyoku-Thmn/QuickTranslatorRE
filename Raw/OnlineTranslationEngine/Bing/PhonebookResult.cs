using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x0200001B RID: 27
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [Serializable]
    public class PhonebookResult
    {
        // Token: 0x04000084 RID: 132
        public string Title;

        // Token: 0x04000085 RID: 133
        public string Url;

        // Token: 0x04000086 RID: 134
        public string Business;

        // Token: 0x04000087 RID: 135
        public string PhoneNumber;

        // Token: 0x04000088 RID: 136
        public string Address;

        // Token: 0x04000089 RID: 137
        public string City;

        // Token: 0x0400008A RID: 138
        public string StateOrProvince;

        // Token: 0x0400008B RID: 139
        public string CountryOrRegion;

        // Token: 0x0400008C RID: 140
        public string PostalCode;

        // Token: 0x0400008D RID: 141
        public double Latitude;

        // Token: 0x0400008E RID: 142
        [XmlIgnore]
        public bool LatitudeSpecified;

        // Token: 0x0400008F RID: 143
        public double Longitude;

        // Token: 0x04000090 RID: 144
        [XmlIgnore]
        public bool LongitudeSpecified;

        // Token: 0x04000091 RID: 145
        public string UniqueId;

        // Token: 0x04000092 RID: 146
        public string BusinessUrl;

        // Token: 0x04000093 RID: 147
        public double UserRating;

        // Token: 0x04000094 RID: 148
        [XmlIgnore]
        public bool UserRatingSpecified;

        // Token: 0x04000095 RID: 149
        public uint ReviewCount;

        // Token: 0x04000096 RID: 150
        [XmlIgnore]
        public bool ReviewCountSpecified;

        // Token: 0x04000097 RID: 151
        public string DisplayUrl;
    }
}

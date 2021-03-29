using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000009 RID: 9
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [Serializable]
    public enum SourceType
    {
        // Token: 0x04000022 RID: 34
        Spell,
        // Token: 0x04000023 RID: 35
        Web,
        // Token: 0x04000024 RID: 36
        Image,
        // Token: 0x04000025 RID: 37
        RelatedSearch,
        // Token: 0x04000026 RID: 38
        Phonebook,
        // Token: 0x04000027 RID: 39
        Showtimes,
        // Token: 0x04000028 RID: 40
        Weather,
        // Token: 0x04000029 RID: 41
        Video,
        // Token: 0x0400002A RID: 42
        Ad,
        // Token: 0x0400002B RID: 43
        XRank,
        // Token: 0x0400002C RID: 44
        InstantAnswer,
        // Token: 0x0400002D RID: 45
        News,
        // Token: 0x0400002E RID: 46
        QueryLocation,
        // Token: 0x0400002F RID: 47
        MobileWeb,
        // Token: 0x04000030 RID: 48
        Translation
    }
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000028 RID: 40
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    [XmlType(Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class SearchResponse
    {
        // Token: 0x040000CB RID: 203
        public string Version;

        // Token: 0x040000CC RID: 204
        public Query Query;

        // Token: 0x040000CD RID: 205
        public SpellResponse Spell;

        // Token: 0x040000CE RID: 206
        public WebResponse Web;

        // Token: 0x040000CF RID: 207
        public ImageResponse Image;

        // Token: 0x040000D0 RID: 208
        public RelatedSearchResponse RelatedSearch;

        // Token: 0x040000D1 RID: 209
        public PhonebookResponse Phonebook;

        // Token: 0x040000D2 RID: 210
        public VideoResponse Video;

        // Token: 0x040000D3 RID: 211
        public InstantAnswerResponse InstantAnswer;

        // Token: 0x040000D4 RID: 212
        public NewsResponse News;

        // Token: 0x040000D5 RID: 213
        public MobileWebResponse MobileWeb;

        // Token: 0x040000D6 RID: 214
        public TranslationResponse Translation;

        // Token: 0x040000D7 RID: 215
        [XmlArrayItem(IsNullable = false)]
        public Error[] Errors;
    }
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000005 RID: 5
    [DebuggerStepThrough]
    [WebServiceBinding(Name = "LiveSearchPortBinding", Namespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search")]
    [DesignerCategory("code")]
    [GeneratedCode("SharpDevelop", "3.0.0.3800")]
    public class LiveSearchService : SoapHttpClientProtocol
    {
        // Token: 0x0600000F RID: 15 RVA: 0x00002915 File Offset: 0x00001915
        public LiveSearchService()
        {
            base.Url = "http://api.search.live.net:80/soap.asmx";
        }

        // Token: 0x06000010 RID: 16 RVA: 0x00002928 File Offset: 0x00001928
        [SoapDocumentMethod("http://schemas.microsoft.com/LiveSearch/2008/03/Search/Search", RequestElementName = "SearchRequest", RequestNamespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search", ResponseNamespace = "http://schemas.microsoft.com/LiveSearch/2008/03/Search", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("parameters")]
        public SearchResponse Search(SearchRequest parameters)
        {
            object[] array = base.Invoke("Search", new object[]
            {
                parameters
            });
            return (SearchResponse)array[0];
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002958 File Offset: 0x00001958
        public IAsyncResult BeginSearch(SearchRequest parameters, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("Search", new object[]
            {
                parameters
            }, callback, asyncState);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002980 File Offset: 0x00001980
        public SearchResponse EndSearch(IAsyncResult asyncResult)
        {
            object[] array = base.EndInvoke(asyncResult);
            return (SearchResponse)array[0];
        }
    }
}

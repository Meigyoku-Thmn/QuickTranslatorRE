using System;
using System.Text;

namespace OnlineTranslationEngine.Bing
{
    // Token: 0x02000003 RID: 3
    public class BingOnlineTranslationEngine : OnlineTranslationEngine
    {
        // Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00001050
        public string ChineseToEnglish(string chinese)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (LiveSearchService liveSearchService = new LiveSearchService())
            {
                SearchRequest request = BuildRequest(chinese.Replace("\n", "\r\n"));
                SearchResponse response = GetResponse(liveSearchService, request, 10);
                foreach (TranslationResult translationResult in response.Translation.Results)
                {
                    stringBuilder.Append(translationResult.TranslatedTerm);
                }
            }
            return stringBuilder.ToString();
        }

        // Token: 0x06000003 RID: 3 RVA: 0x000020E4 File Offset: 0x000010E4
        private SearchResponse GetResponse(LiveSearchService service, SearchRequest request, int retryTime)
        {
            return service.Search(request);
        }

        // Token: 0x06000004 RID: 4 RVA: 0x000020FC File Offset: 0x000010FC
        private SearchRequest BuildRequest(string chinese)
        {
            return new SearchRequest {
                AppId = "F52CC4B9C5D0FFCF07F449772B58B636D4B9F290",
                Query = chinese,
                Sources = new[] {
                    SourceType.Translation
                },
                Translation = new TranslationRequest {
                    SourceLanguage = "zh-CHS",
                    TargetLanguage = "en"
                }
            };
        }
    }
}

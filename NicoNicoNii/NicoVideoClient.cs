using AngleSharp;
using NicoNicoNii.Entities.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace NicoNicoNii
{
    public class NicoVideoClient
    {
        private readonly NNDClient _nndClient;

        public NicoVideoClient(NNDClient nndClient)
        {
            this._nndClient = nndClient;
        }

        public async Task<WatchPageData> GetWatchPageInfoAsync(string videoId)
        {
            var pageResponse = await this._nndClient._client.GetAsync($"https://www.nicovideo.jp/watch/{videoId}", System.Net.Http.HttpCompletionOption.ResponseHeadersRead);

            if (!pageResponse.IsSuccessStatusCode)
                return default;

            var page = await pageResponse.Content.ReadAsStringAsync();
            var context = BrowsingContext.New(Configuration.Default);
            var doc = await context.OpenAsync(req => req.Content(page));
            var elm = doc.GetElementById("js-initial-watch-data").GetAttribute("data-api-data");
            var json = HttpUtility.HtmlDecode(elm);
            var data = JsonSerializer.Deserialize<WatchPageData>(json);
            return data;
        }
    }
}

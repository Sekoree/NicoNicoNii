using AngleSharp;
using NicoNicoNii.Entities.JSON;
using NicoNicoNii.Entities.JSON.Video;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        public async Task<SessionCreateResponse> GetVideoApiResponseAsync(WatchPageData watchPageData, string[] audioQualities = null, string[] videoQualities = null)
        {
            if (videoQualities == null)
                videoQualities = watchPageData.Media.Delivery.Movie.Session.Videos.ToArray();
            if (audioQualities == null)
                audioQualities = watchPageData.Media.Delivery.Movie.Session.Audios.ToArray();

            var json = JsonSerializer.Serialize(new SessionCreate(watchPageData, audioQualities, videoQualities));
            using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
            using (var msg = new HttpRequestMessage(HttpMethod.Post, $"{watchPageData.Media.Delivery.Movie.Session.Urls[0].UrlUrl}?_format=json"))
            {
                msg.Content = content;
                var response = await this._nndClient._client.SendAsync(msg);
                var responseJson = await response.Content.ReadAsStringAsync();
                var sessionResponse = JsonSerializer.Deserialize<SessionCreateResponse>(responseJson);
                return sessionResponse;
            }
        }
    }
}

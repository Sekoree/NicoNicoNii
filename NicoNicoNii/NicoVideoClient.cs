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

        /// <summary>
        /// Get the WatchPage JSON from a NicoNico Video page (js-initial-watch-data)
        /// </summary>
        /// <param name="videoId">ID of the video smXXXXXXX</param>
        /// <returns>WatchPage object</returns>
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

        /// <summary>
        /// Initialize a NonMember session, NND might cache this so its only needed once, but not sure
        /// </summary>
        /// <param name="watchPageData">WatchPage object needed for anonymous user info</param>
        /// <returns>Returns nothing, the POST has an empty repsonse</returns>
        public async Task InitializeNonMemberSessionAsync(WatchPageData watchPageData)
        {
            var noMemberJson = JsonSerializer.Serialize(new[] { new NoMemberRequest(watchPageData) });
            using (var content = new StringContent(noMemberJson, Encoding.UTF8, "application/json"))
            using (var msg = new HttpRequestMessage(HttpMethod.Post ,$"https://public.api.nicovideo.jp/v1/user/actions/watch-events/nonmember.json?__retry=0"))
            {
                msg.Content = content;
                msg.Headers.Add("X-Frontend-Id","6");
                msg.Headers.Add("X-Frontend-Version","0");
                msg.Headers.Add("X-Request-With", $"https://www.nicovideo.jp/watch/{watchPageData.Client.WatchId}");
                var response = await this._nndClient._client.SendAsync(msg);
            }
        }

        /// <summary>
        /// Get a reponse object from the Video API for the HTTP (usually mp4) version of a video
        /// </summary>
        /// <param name="watchPageData">WatchPage object</param>
        /// <param name="audioQualities">Preferred audio streams (there are like 1-2 depending on video), if multiple or null NND will decide</param>
        /// <param name="videoQualities">Preferred video streams, if multiple or null NND will decide</param>
        /// <returns>SessionCreate Response with video API info about the content</returns>
        public async Task<SessionCreateResponse> GetHTTPVideoApiResponseAsync(WatchPageData watchPageData, string[] audioQualities = null, string[] videoQualities = null)
        {
            if (videoQualities == null)
                videoQualities = watchPageData.Media.Delivery.Movie.Session.Videos.ToArray();
            if (audioQualities == null)
                audioQualities = watchPageData.Media.Delivery.Movie.Session.Audios.ToArray();

            var loggedIn = false;
            if (this._nndClient._loginDate != null 
                && (DateTimeOffset.UtcNow.DateTime - this._nndClient._loginDate?.DateTime)?.Hours < 5)
            {
                loggedIn = true;
            }

            var json = JsonSerializer.Serialize(new SessionCreateHTTP(watchPageData, audioQualities, videoQualities, loggedIn));
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

        /// <summary>
        /// Get a reponse object from the Video API for the HLS (so DASH but video and audio arent seperated I think) version of a video
        /// </summary>
        /// <param name="watchPageData">WatchPage object</param>
        /// <param name="audioQualities">Preferred audio streams (there are like 1-2 depending on video), if multiple or null NND will decide</param>
        /// <param name="videoQualities">Preferred video streams, if multiple or null NND will decide</param>
        /// <returns>SessionCreate Response with video API info about the content</returns>
        public async Task<SessionCreateResponse> GetHLSVideoApiResponseAsync(WatchPageData watchPageData, string[] audioQualities = null, string[] videoQualities = null)
        {
            if (videoQualities == null)
                videoQualities = watchPageData.Media.Delivery.Movie.Session.Videos.ToArray();
            if (audioQualities == null)
                audioQualities = watchPageData.Media.Delivery.Movie.Session.Audios.ToArray();

            var loggedIn = false;
            if (this._nndClient._loginDate != null
                && (DateTimeOffset.UtcNow.DateTime - this._nndClient._loginDate?.DateTime)?.Hours < 5)
            {
                loggedIn = true;
            }

            var json = JsonSerializer.Serialize(new SessionCreateHLS(watchPageData, audioQualities, videoQualities, loggedIn));
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

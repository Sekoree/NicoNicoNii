using NicoNicoNii.Entities.JSON;
using NicoNicoNii.Entities.XML;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NicoNicoNii
{
    public class NNDClient
    {
        internal readonly HttpClient _client;
        internal readonly HttpClientHandler _handler;

        public LoginSessionData LoginSessionData { get; internal set; }

        public NNDClient()
        {
            var cc = new CookieContainer();
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                CookieContainer = cc,
                UseCookies = true,
                UseDefaultCredentials = false
            };
            this._handler = handler;
            this._client = new HttpClient(handler);
        }

        public NNDClient(HttpClientHandler handler)
        {
            this._handler = handler;
            this._client = new HttpClient(handler);
        }

        public async Task<LoginSessionData> LoginAsync(string emailTel, string password)
        {
            using (var cont = new StringContent($"mail={emailTel}&password={password}&site=nicometro", Encoding.UTF8, "application/x-www-form-urlencoded"))
            using (var msg = new HttpRequestMessage(HttpMethod.Post, "https://account.nicovideo.jp/login/redirector"))
            {
                msg.Content = cont;
                var response = await _client.SendAsync(msg);
                var serializer = new XmlSerializer(typeof(LoginSessionData));
                var loginData = serializer.Deserialize(await response.Content.ReadAsStreamAsync()) as LoginSessionData;
                this.LoginSessionData = loginData;
                this._handler.CookieContainer.Add(new Uri("http://api.ce.nicovideo.jp"), new Cookie("user_session", this.LoginSessionData.SessionKey, "/", "nicovideo.jp"));
                return loginData;
            }
        }

        public async Task<bool> CheckSessionValidityAsync()
        {
            using (var msg = new HttpRequestMessage(HttpMethod.Get, "https://api.ce.nicovideo.jp/api/v1/session.alive"))
            {
                msg.Headers.Add("X-NICOVITA-SESSION", this.LoginSessionData?.SessionKey);
                var resp = await this._client.SendAsync(msg);
                var txt = await resp.Content.ReadAsStringAsync();
                var dec = JsonSerializer.Deserialize<SessionKeepAlive>(txt);
                return dec.NiconicoResponse.Status == "ok";
            }
        }

        public async Task<bool> LogoutAsync()
        {
            var responseMessage = await this._client.GetAsync("https://account.nicovideo.jp/logout", HttpCompletionOption.ResponseHeadersRead);
            return responseMessage.IsSuccessStatusCode;
        }
    }
}

using Newtonsoft.Json;
using NHL.NET.Exceptions;
using NHL.NET.Http.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace NHL.NET.Http
{
    public class Requester : IRequester
    {
        private const string ExceptionMessage = "NHL API request failed with status code {0}";
        private readonly HttpClient _client;

        public Requester()
        {
            _client = new HttpClient();
        }

        public Requester(HttpClient client)
        {
            _client = client;
        }

        public async Task<T> GetRequestAsync<T>(string uri) where T : class
        {
            var req = new HttpRequestMessage(HttpMethod.Get, uri);
            var response = await _client.SendAsync(req);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }

            throw new NHLClientRequestException(string.Format(ExceptionMessage, response.StatusCode), (int)response.StatusCode);
        }

        public async Task<string> GetRequestAsync(string uri)
        {
            var req = new HttpRequestMessage(HttpMethod.Get, uri);
            var response = await _client.SendAsync(req);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            throw new NHLClientRequestException(string.Format(ExceptionMessage, response.StatusCode), (int)response.StatusCode);
        }

        public T GetRequest<T>(string uri) where T : class
        {
            var req = new HttpRequestMessage(HttpMethod.Get, uri);
            var response = _client.SendAsync(req).Result;

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
            }

            throw new NHLClientRequestException(string.Format(ExceptionMessage, response.StatusCode), (int)response.StatusCode);
        }

        public string GetRequest(string uri)
        {
            var req = new HttpRequestMessage(HttpMethod.Get, uri);
            var response = _client.SendAsync(req).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }

            throw new NHLClientRequestException(string.Format(ExceptionMessage, response.StatusCode), (int)response.StatusCode);
        }
    }
}

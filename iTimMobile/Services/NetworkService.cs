using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using iTimMobile.Services.Interfaces;

namespace iTimMobile.Services
{
    public class HttpService : INetworkService
    {
        private HttpClient _httpClient;

        public HttpService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<TResult> GetAsync<TResult>(string uri)
        {
            var response = await _httpClient.GetAsync(uri);
            string json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TResult>(json);
        }

        public async Task<TResult> PostAsync<TResult>(string uri, string jsonData)
        {
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(uri, content);
            string json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TResult>(json);
        }

        public async Task<TResult> PutAsync<TResult>(string uri, string jsonData)
        {
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(uri, content);
            string json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TResult>(json);
        }

        public async Task DeleteAsync(string uri)
        {
            await _httpClient.DeleteAsync(uri);
        }

    }
}

using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using covid19info.Models;

namespace covid19info.Repository
{
    public class CountryRepository {
        private readonly IHttpClientFactory clientFactory;

        private HttpRequestMessage InvokeURL(string endpoint) {
            return new HttpRequestMessage(
                HttpMethod.Get,
                endpoint
            );
        }

        private async Task<CountryBase[]> GetCountries()
        {
            var client = clientFactory.CreateClient("covid19api");
            var response = await client.SendAsync(InvokeURL("country"));
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("unavailable external api, please try again later!");
            }

            return JsonSerializer.Deserialize<CountryBase[]>(response.Content.ToString());
        }
    }
}

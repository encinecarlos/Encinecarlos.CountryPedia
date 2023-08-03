using System.Text.Json;
using Encinecarlos.CountryPedia.Application.Utils;
using Encinecarlos.CountryPedia.Domain.Entities;
using Encinecarlos.CountryPedia.Infrastructure.Interfaces;

namespace Encinecarlos.CountryPedia.Infrastructure.Services
{
    public class HttpService : IHttpService
    {
        private readonly IHttpClientFactory _client = null;
        private readonly ILogger<HttpService> _logger = null;

        public HttpService(IHttpClientFactory client, ILogger<HttpService> logger) 
            => (_client, _logger) = (client, logger);

        public async Task<List<Country>> GetAllCountries()
        {
            using HttpClient client = _client.CreateClient();

            _logger.LogInformation("Get list fo countries from web serice");
            var response = client.GetAsync("https://restcountries.com/v3.1/all").Result;

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<List<Country>>(content);

            return result ?? new List<Country>();
        }              
    }
}
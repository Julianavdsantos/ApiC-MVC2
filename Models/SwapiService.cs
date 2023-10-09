using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.Models
{
    public class SwapiService
    {
        private readonly HttpClient _httpClient;

        public SwapiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://swapi.dev/api/");
        }

        public async Task<List<Films>> GetFilmsAsync()
        {
            var response = await _httpClient.GetAsync("films/");
            if (response.IsSuccessStatusCode)
            {
                var swapiResponse = await response.Content.ReadAsAsync<SwapiFilmsResponse>();
                return swapiResponse.Results;
            }
            else
            {
                throw new Exception("Falha ao buscar os dados da API SWAPI.");
            }
        }
        
      
    }
}

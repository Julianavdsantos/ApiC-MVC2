using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.Models
{
    public class SwapiPlanetsService
    {
        private readonly HttpClient _httpClient;

        public SwapiPlanetsService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://swapi.dev/api/");
        }

        public async Task<List<Planets>> GetPlanetsAsync()
        {
            var responsePlanet = await _httpClient.GetAsync("planets/");
            if (responsePlanet.IsSuccessStatusCode)
            {
                var swapiResponsePlanet = await responsePlanet.Content.ReadAsAsync<SwapiPlanetsResponse>();
                // Adicione o ID à lista de pessoas antes de retorná-la
                foreach (var person in swapiResponsePlanet.Results)
                {
                    person.Id = ExtractIdFromUrl(person.Url);
                }
                return swapiResponsePlanet.Results;
            }
            else
            {
                throw new Exception("Falha ao buscar os dados da API SWAPI.");
            }
        }

        // Função para extrair o ID da URL
        private int ExtractIdFromUrl(string url)
        {
            string[] segments = url.TrimEnd('/').Split('/');
            string lastSegment = segments[segments.Length - 1];

            if (int.TryParse(lastSegment, out int id))
            {
                return id;
            }
            else
            {
                throw new Exception($"Falha ao extrair o ID da URL: {url}");
            }
        }

    }
}

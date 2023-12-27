using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.Models
{
    public class SwapiPeopleService
    {
        private readonly HttpClient _httpClient;

        public SwapiPeopleService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://swapi.dev/api/");
        }

        public async Task<List<Peoples>> GetPeopleAsync()
        {
            var response = await _httpClient.GetAsync("people/");
            if (response.IsSuccessStatusCode)
            {
                var swapiResponse = await response.Content.ReadAsAsync<SwapiPeopleResponse>();

               
                foreach (var person in swapiResponse.Results)
                {
                    person.Id = ExtractIdFromUrl(person.Url);
                }

                return swapiResponse.Results;
            }
            else
            {
                throw new Exception("Falha ao buscar os dados da API SWAPI para pessoas.");
            }
        }

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

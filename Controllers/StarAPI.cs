/*using API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class StarAPI : Controller
    {
        private const string BaseUrl = "https://swapi.dev/api/";

        public async Task<ActionResult> Films()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync($"{BaseUrl}films/");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var films = JsonConvert.DeserializeObject<Films>(content);

                

                ViewData["FilmsData"] = films; // Armazena os filmes na ViewData
                return View("Index", films); // Exibe diretamente a view "Index" com os filmes
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Erro ao buscar dados da API: " + ex.Message;
                return View("Error"); // Retorna uma view de erro aqui
            }
        }
    }
}
*/
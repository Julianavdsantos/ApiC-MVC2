using API.Models; // Importe o namespace onde SwapiService está definida
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SwapiService _swapiService;
        private readonly SwapiPlanetsService _swapiPlanetsService; // Inclua a instância de SwapiPlanetsService
        private readonly SwapiPeopleService _swapiPeopleService; // Inclua a instância de SwapiPeopleService

       

        public HomeController(ILogger<HomeController> logger, SwapiService swapiService, SwapiPlanetsService swapiPlanetsService, SwapiPeopleService swapiPeopleService )
        {
            _logger = logger;
            _swapiService = swapiService;
            _swapiPlanetsService = swapiPlanetsService;
            _swapiPeopleService = swapiPeopleService;

         

        }

        public async Task<IActionResult> Index()
        {
            var films = await _swapiService.GetFilmsAsync();
            var people = await _swapiPeopleService.GetPeopleAsync(); // Corrigi o nome do serviço aqui
            var planets = await _swapiPlanetsService.GetPlanetsAsync(); // Corrigi o nome do serviço aqui

         

            var combinedDataViewModel = new CombinedDataViewModel
            {
                Films = films,
                Peoples = people,
                Planets = planets,
              
            };

            return View(combinedDataViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

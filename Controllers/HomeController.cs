using API.Models; 
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
        private readonly SwapiPlanetsService _swapiPlanetsService; 
        private readonly SwapiPeopleService _swapiPeopleService; 
       

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
            var people = await _swapiPeopleService.GetPeopleAsync(); 
            var planets = await _swapiPlanetsService.GetPlanetsAsync(); 

         

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

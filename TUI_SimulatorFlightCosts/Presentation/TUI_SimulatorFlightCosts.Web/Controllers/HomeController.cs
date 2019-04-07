using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TUI.SimulatorFlights.Domain;
using TUI_SimulatorFlightCosts.Application;
using TUI_SimulatorFlightCosts.Web.Models;
using UI_SimulatorFlightCosts.Web.Models;

namespace TUI_SimulatorFlightCosts.Web.Controllers
{
    public class HomeController : Controller
    {
        private FlightSimulatorService _flightSimulatorService;

        public HomeController(IPersistenceService persistenceService)
        {
            _flightSimulatorService = new FlightSimulatorService(persistenceService);
        }
        public IActionResult Index()
        {
            // Afficher les vols présents
            var flights = _flightSimulatorService.GetFlights();

            return View(new HomeModel()
            {
                Flights = flights
            });
        }

        public IActionResult Report()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

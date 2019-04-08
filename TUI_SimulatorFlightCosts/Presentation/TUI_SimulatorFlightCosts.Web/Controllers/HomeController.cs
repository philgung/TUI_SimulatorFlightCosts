using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Linq;
using TUI.SimulatorFlights.Domain;
using TUI_SimulatorFlightCosts.Application;
using TUI_SimulatorFlightCosts.Web.Adapters;
using TUI_SimulatorFlightCosts.Web.Models;
using UI_SimulatorFlightCosts.Web.Models;

namespace TUI_SimulatorFlightCosts.Web.Controllers
{
    public class HomeController : Controller
    {
        private FlightSimulatorService _flightSimulatorService;

        public HomeController(IPersistenceService persistenceService, IConfiguration configuration)
        {
            persistenceService.InitializeService(ConfigurationExtensions.GetConnectionString(configuration, "DefaultConnection"));
            _flightSimulatorService = new FlightSimulatorService(persistenceService);
        }
        public IActionResult Index()
        {
            var flights = _flightSimulatorService.GetFlights();            
            return View(new HomeModel()
            {
                Flights = flights
            });
        }

        public IActionResult Edit(string flightName)
        {
            if (!string.IsNullOrEmpty(flightName))
            {
                var flight = _flightSimulatorService.GetFlight(flightName);
                if (flight != null)
                    return View(flight.ToFlightModel());
            }
           
            return View();
        }

        [HttpPost]
        public IActionResult Edit(FlightModel flightModel)
        {
            _flightSimulatorService.Save(flightModel.ToFlight());
            return View();
        }

        public JsonResult CalculDistance(string flightName)
        {
            var distance = _flightSimulatorService.CalculateDistance(flightName);
            return Json(distance);
        }

        public JsonResult CalculConsumptionFuel(string flightName)
        {
            var consumptionFuel = _flightSimulatorService.CalculateFuelConsumption(flightName);
            return Json(consumptionFuel);
        }

        public IActionResult Report()
        {
            var reports = _flightSimulatorService.GetReports()?.Select(x => x.ToReportModel());
            return View(reports);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

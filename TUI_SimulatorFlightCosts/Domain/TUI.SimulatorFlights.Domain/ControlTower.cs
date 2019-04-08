using System.Collections.Generic;
using TUI.SimulatorFlights.Domain;

namespace TUI.Domain.SimulatorFlights
{
    public class ControlTower : IFlightsManager, IFlightsSimulator
    {
        private readonly IPersistenceService _persistenceService;

        public ControlTower(IPersistenceService persistenceService)
        {
            _persistenceService = persistenceService;
        }

        public double CalculateDistance(string flightName)
        {
            var flight = GetFlight(flightName);
            var distanceTraveled = flight.CalculateDistance();
            _persistenceService.SaveReport(flightName, CalculType.CalculateDistance, distanceTraveled);
            return distanceTraveled;
        }

        public double CalculateFuelConsumption(string flightName)
        {
            var flight = GetFlight(flightName);

            var fuelConsumption = flight.CalculateFuelConsumption();
            _persistenceService.SaveReport(flightName, CalculType.CalculateFuelConsumption, fuelConsumption);
            return fuelConsumption;
        }

        public IFlight GetFlight(string flightName)
        {
            return _persistenceService.GetFlight(flightName);
        }

        public void RegisterFlight(IFlight flight)
        {
            _persistenceService.SaveFlight(flight);            
        }

        public ICollection<Report> GetReports()
        {
            return _persistenceService.GetReports();
        }

        public ICollection<IFlight> GetFlights()
        {
            return _persistenceService.GetFlights();
        }
    }
}

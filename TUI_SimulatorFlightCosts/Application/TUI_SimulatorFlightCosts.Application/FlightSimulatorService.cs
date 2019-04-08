using System.Collections.Generic;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Domain;

namespace TUI_SimulatorFlightCosts.Application
{
    public class FlightSimulatorService
    {
        private readonly ControlTower _controlTower;

        public FlightSimulatorService(IPersistenceService persistenceService)
        {
            _controlTower = new ControlTower(persistenceService);
        }

        public ICollection<IFlight> GetFlights()
        {
            return _controlTower.GetFlights();
        }

        public IFlight GetFlight(string flightName)
        {
            return _controlTower.GetFlight(flightName);
        }

        public void Save(IFlight flight)
        {
            _controlTower.RegisterFlight(flight);
        }

        public ICollection<Report> GetReports()
        {
            return _controlTower.GetReports();
        }

        public double CalculateDistance(string flightName)
        {
            return _controlTower.CalculateDistance(flightName);
        }

        public double CalculateFuelConsumption(string flightName)
        {
            return _controlTower.CalculateFuelConsumption(flightName);
        }
    }
}
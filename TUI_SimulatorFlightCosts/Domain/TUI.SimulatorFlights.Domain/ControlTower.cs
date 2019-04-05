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
            return flight.CalculateDistance();
        }

        public double CalculateFuelConsumption(string flightName)
        {
            var flight = GetFlight(flightName);
            return flight.CalculateFuelConsumption();
        }

        public IFlight GetFlight(string flightName)
        {
            return _persistenceService.GetFlight(flightName);
        }

        public void RegisterFlight(IFlight flight)
        {
            _persistenceService.SaveFlight(flight);            
        }
    }
}

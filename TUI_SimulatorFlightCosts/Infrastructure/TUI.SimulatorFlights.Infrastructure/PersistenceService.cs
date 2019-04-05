using System;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Domain;

namespace TUI.SimulatorFlights.Infrastructure
{
    public class PersistenceService : IPersistenceService
    {
        public IFlight GetFlight(string flightName)
        {
            throw new NotImplementedException();
        }

        public void SaveFlight(IFlight flight)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Domain;

namespace TUI_SimulatorFlightCosts.Application
{
    public class FlightSimulatorService
    {
        private readonly IPersistenceService _persistenceService;

        public FlightSimulatorService(IPersistenceService persistenceService)
        {
            this._persistenceService = persistenceService;
        }

        public ICollection<IFlight> GetFlights()
        {
            return _persistenceService.GetFlights();
        }

        public IFlight GetFlight(string flightName)
        {
            return _persistenceService.GetFlight(flightName);
        }

        public void Save(IFlight flight)
        {
            _persistenceService.SaveFlight(flight);
        }
    }
}
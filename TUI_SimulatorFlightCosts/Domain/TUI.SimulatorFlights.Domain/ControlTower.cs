using System;
using System.Collections.Generic;
using System.Linq;
using TUI.SimulatorFlights.Domain;

namespace TUI.Domain.SimulatorFlights
{
    public class ControlTower : IFlightsManager, IFlightsSimulator
    {
        private readonly IList<IFlight> _flights = new List<IFlight>();

        public double CalculateDistance(IFlight flight)
        {
            return flight.CalculateDistance();
        }

        public double CalculateFuelConsumption(IFlight flight)
        {
            return flight.CalculateFuelConsumption();
        }

        public IFlight GetFlight(string flightName)
        {
            return _flights.SingleOrDefault(x => x.Name == flightName);
        }

        public void RegisterFlight(IFlight flight)
        {
            _flights.Add(flight);
        }
    }
}

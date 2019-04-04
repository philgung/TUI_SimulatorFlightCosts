using System;
using System.Collections.Generic;
using System.Linq;
using TUI.SimulatorFlights.Domain;

namespace TUI.Domain.SimulatorFlights
{
    public class ControlTower : IFlightsManager, IFlightsSimulator
    {
        private readonly IList<Flight> _flights = new List<Flight>();

        public double CalculateDistance(Flight flight)
        {
            throw new NotImplementedException();
        }

        public double CalculateFuelConsumption(Flight flight)
        {
            throw new NotImplementedException();
        }

        public Flight GetFlight(string flightName)
        {
            return _flights.SingleOrDefault(x => x.Name == flightName);
        }

        public void RegisterFlight(Flight flight)
        {
            _flights.Add(flight);
        }
    }
}

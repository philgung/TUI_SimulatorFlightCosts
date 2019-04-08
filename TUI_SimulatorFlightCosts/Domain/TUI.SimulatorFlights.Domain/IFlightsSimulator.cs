using System.Collections.Generic;
using TUI.Domain.SimulatorFlights;

namespace TUI.SimulatorFlights.Domain
{
    public interface IFlightsSimulator
    {
        double CalculateDistance(string flightName);
        double CalculateFuelConsumption(string flightName);
        ICollection<Report> GetReports();
    }
}

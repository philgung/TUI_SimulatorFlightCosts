using System.Collections.Generic;
using TUI.Domain.SimulatorFlights;

namespace TUI.SimulatorFlights.Domain
{
    public interface IFlightsManager
    {
        void RegisterFlight(IFlight flight);

        IFlight GetFlight(string flightName);
        ICollection<IFlight> GetFlights();
    }
}

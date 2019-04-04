using TUI.Domain.SimulatorFlights;

namespace TUI.SimulatorFlights.Domain
{
    public interface IFlightsManager
    {
        void RegisterFlight(Flight flight);

        Flight GetFlight(string flightName);
    }
}

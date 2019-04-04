using TUI.Domain.SimulatorFlights;

namespace TUI.SimulatorFlights.Domain
{
    public interface IFlightsSimulator
    {
        double CalculateDistance(Flight flight);
        double CalculateFuelConsumption(Flight flight);
    }
}

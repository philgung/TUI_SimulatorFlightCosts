using TUI.Domain.SimulatorFlights;

namespace TUI.SimulatorFlights.Domain
{
    public interface IFlightsSimulator
    {
        double CalculateDistance(IFlight flight);
        double CalculateFuelConsumption(IFlight flight);
    }
}

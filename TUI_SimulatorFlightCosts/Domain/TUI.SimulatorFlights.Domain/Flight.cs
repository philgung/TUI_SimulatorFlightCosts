namespace TUI.Domain.SimulatorFlights
{
    public class Flight
    {
        public Flight(string flightName)
        {
            this.Name = flightName;
        }

        public string Name { get; }
    }
}

namespace TUI.Domain.SimulatorFlights
{
    public class Airport
    {
        public GPSPosition GPSPosition { get; }
        public string AirportName { get; }

        public Airport(string airportName, GPSPosition gPSPosition)
        {
            this.AirportName = airportName;
            this.GPSPosition = gPSPosition;
        }
    }
}

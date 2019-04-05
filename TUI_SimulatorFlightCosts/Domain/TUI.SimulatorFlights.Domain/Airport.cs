namespace TUI.Domain.SimulatorFlights
{
    public class Airport
    {
        private string airportName;
        public GPSPosition GPSPosition { get; }

        public Airport(string airportName, GPSPosition gPSPosition)
        {
            this.airportName = airportName;
            this.GPSPosition = gPSPosition;
        }
    }
}

namespace TUI.Domain.SimulatorFlights
{
    public class Airport
    {
        private GPSPosition _GPSPosition;
        public string AirportName { get; }

        public Airport(string airportName, GPSPosition gPSPosition)
        {
            this.AirportName = airportName;
            this._GPSPosition = gPSPosition;
        }

        public double GetLatitude()
        {
            return _GPSPosition.Latitude;
        }

        public double GetLongitude()
        {
            return _GPSPosition.Longitude;
        }
    }
}

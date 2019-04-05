namespace TUI.Domain.SimulatorFlights
{
    public struct GPSPosition
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public GPSPosition(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
}
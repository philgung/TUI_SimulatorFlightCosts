namespace TUI.Domain.SimulatorFlights
{
    internal struct GPSPosition
    {
        private decimal latitude;
        private decimal longitude;

        public GPSPosition(decimal latitude, decimal longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
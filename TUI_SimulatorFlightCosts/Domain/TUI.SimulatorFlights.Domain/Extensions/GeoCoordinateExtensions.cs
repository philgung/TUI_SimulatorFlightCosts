using GeoCoordinatePortable;
using TUI.Domain.SimulatorFlights;

namespace TUI.SimulatorFlights.Domain.Extensions
{
    public static class GeoCoordinateExtensions
    {
        public static double GetDistanceTo(this Airport departureAirport, Airport destinationAirport)
        {
            var departurePosition = new GeoCoordinate(departureAirport.GPSPosition.Latitude, departureAirport.GPSPosition.Longitude);
            var destinationPosition = new GeoCoordinate(destinationAirport.GPSPosition.Latitude, destinationAirport.GPSPosition.Longitude);
            return departurePosition.GetDistanceTo(destinationPosition) / 1000;
        }
    }
}

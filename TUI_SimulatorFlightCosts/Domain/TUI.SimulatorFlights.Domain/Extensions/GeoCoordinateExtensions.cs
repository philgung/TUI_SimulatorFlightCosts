using GeoCoordinatePortable;
using TUI.Domain.SimulatorFlights;

namespace TUI.SimulatorFlights.Domain.Extensions
{
    public static class GeoCoordinateExtensions
    {
        public static double GetDistanceTo(this Airport departureAirport, Airport destinationAirport)
        {
            var departurePosition = new GeoCoordinate(departureAirport.GetLatitude(), departureAirport.GetLongitude());
            var destinationPosition = new GeoCoordinate(destinationAirport.GetLatitude(), destinationAirport.GetLongitude());
            return departurePosition.GetDistanceTo(destinationPosition) / 1000;
        }
    }
}

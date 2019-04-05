using FluentAssertions;
using GeoCoordinatePortable;
using Xunit;

namespace TUI_GeoCoordinateTests
{
    public class GeoCoordinateTests
    {
        [Fact]
        public void CalculateDistanceBetweenParisAirportAndLondonAirport()
        {
            // Arrange
            var latitudeAirportRoissy = 49.007;
            var longitudeAirportRoissy = 2.559790000000021;

            var roissyAirportGPSPosition = new GeoCoordinate(latitudeAirportRoissy, longitudeAirportRoissy);

            var latitudeAirportLondon = 51.5048;
            var longitudeAirportLondon = 0.052745500000014545;

            var londonAirportGPSPosition = new GeoCoordinate(latitudeAirportLondon, longitudeAirportLondon);
            var expectedDistance = 330.25267832631084;
            // Act
            var distanceKmCalculated = londonAirportGPSPosition.GetDistanceTo(roissyAirportGPSPosition) / 1000;
            // Assert
            distanceKmCalculated.Should().Be(expectedDistance);

        }
    }
}

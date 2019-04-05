using FluentAssertions;
using TUI.Domain.SimulatorFlights;
using Xunit;

namespace TUI_SimulatorFlightCostsTests
{
    public class FlightTests
    {
        const string _flightName = "Roissy Charles De Gaulle - London";

        [Fact]
        public void CalculateDistance()
        {
            // Arrange
            var flight = new Flight(_flightName);
            flight.RegisterDepartureAirport("Roissy Charles de Gaulle", 49.007, 2.559790000000021);
            flight.RegisterDestinationAirport("London", 51.5048, 0.052745500000014545);
            // Act
            var distance = flight.CalculateDistance();
            // Assert
            distance.Should().Be(330.25267832631084);
        }

        [Fact]
        public void CalculateFuelConsumption()
        {
            // Arrange
            var flight = new Flight(_flightName);
            flight.RegisterDepartureAirport("Roissy Charles de Gaulle", 49.007, 2.559790000000021);
            flight.RegisterDestinationAirport("London", 51.5048, 0.052745500000014545);            
            flight.SetFuelConsumptionPerDistance(1000);
            flight.SetFuelConsumptionTakeoffEffort(2000);

            // Act
            var fuelConsumption = flight.CalculateFuelConsumption();
            // Assert
            fuelConsumption.Should().Be(332252.67832631082);
        }
    }
}

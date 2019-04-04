using FluentAssertions;
using System;
using TUI.Domain.SimulatorFlights;
using Xunit;

namespace TUI_SimulatorFlightCostsTests
{
    public class FlightsManagerTests
    {
        [Fact]
        public void RegisterFlightAndRetriveIt()
        {
            // Arrange
            var controlTower = new ControlTower();
            var firstFlight = new Flight("firstFlightName");
            // Act
            controlTower.RegisterFlight(firstFlight);
            var flightLoaded = controlTower.GetFlight("firstFlightName");
            // Assert
            flightLoaded.Should().Be(firstFlight);
        }
    }
}

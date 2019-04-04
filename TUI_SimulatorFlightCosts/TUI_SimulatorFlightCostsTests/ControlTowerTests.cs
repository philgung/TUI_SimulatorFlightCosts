using FluentAssertions;
using Moq;
using System;
using TUI.Domain.SimulatorFlights;
using Xunit;

namespace TUI_SimulatorFlightCostsTests
{
    public class ControlTowerTests
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

        [Fact]
        public void CalculateDistanceForAFlight()
        {
            // Arrange
            var flightMock = new Mock<IFlight>();
            var controlTower = new ControlTower();
            
            // Act
            controlTower.CalculateDistance(flightMock.Object);
            // Assert
            flightMock.Verify(x => x.CalculateDistance(), Times.Once);
        }

        [Fact]
        public void CalculateFuelConsumption()
        {
            // Arrange
            var flightMock = new Mock<IFlight>();
            var controlTower = new ControlTower();

            // Act
            controlTower.CalculateFuelConsumption(flightMock.Object);
            // Assert
            flightMock.Verify(x => x.CalculateFuelConsumption(), Times.Once);
        }
    }
}

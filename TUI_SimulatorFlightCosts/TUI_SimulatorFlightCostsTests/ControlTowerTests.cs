using FluentAssertions;
using Moq;
using System;
using TUI.Domain.SimulatorFlights;
using Xunit;

namespace TUI_SimulatorFlightCostsTests
{
    public class ControlTowerTests
    {
        const string flightName = "Roissy Charles De Gaulle - London";

        [Fact]
        public void RegisterFlightAndRetriveIt()
        {
            // Arrange
            var controlTower = new ControlTower();
            var firstFlight = new Flight(flightName);
            // Act
            controlTower.RegisterFlight(firstFlight);
            var flightLoaded = controlTower.GetFlight(flightName);
            // Assert
            flightLoaded.Should().Be(firstFlight);
        }

        [Fact]
        public void CalculateDistanceForAFlight()
        {
            // Arrange
            var flightMock = new Mock<IFlight>();
            var controlTower = new ControlTower();
            flightMock.SetupGet(x => x.Name).Returns(flightName);
            controlTower.RegisterFlight(flightMock.Object);

            // Act
            controlTower.CalculateDistance(flightName);
            // Assert
            flightMock.Verify(x => x.CalculateDistance(), Times.Once);
        }

        [Fact]
        public void CalculateFuelConsumption()
        {
            // Arrange
            var flightMock = new Mock<IFlight>();
            var controlTower = new ControlTower();
            flightMock.SetupGet(x => x.Name).Returns(flightName);
            controlTower.RegisterFlight(flightMock.Object);

            // Act
            controlTower.CalculateFuelConsumption(flightName);
            // Assert
            flightMock.Verify(x => x.CalculateFuelConsumption(), Times.Once);
        }
    }
}

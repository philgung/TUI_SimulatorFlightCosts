using FluentAssertions;
using Moq;
using System.Collections.Generic;
using System.Linq;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Domain;
using Xunit;

namespace TUI_SimulatorFlightCostsTests
{
    public class ControlTowerTests
    {
        const string flightName = "Roissy Charles De Gaulle - London";
        ControlTower _controlTower;
        List<IFlight> _flights = new List<IFlight>();

        public ControlTowerTests()
        {
            var persistenceServiceMock = new Mock<IPersistenceService>();
            persistenceServiceMock.Setup(x => x.SaveFlight(It.IsAny<IFlight>()))
                .Callback((IFlight flight) => _flights.Add(flight));
            persistenceServiceMock.Setup(x => x.GetFlight(It.IsAny<string>()))
                .Returns((string flightName) => _flights.SingleOrDefault(x => x.Name == flightName));
            _controlTower = new ControlTower(persistenceServiceMock.Object);
        }

        [Fact]
        public void RegisterFlightAndRetriveIt()
        {
            // Arrange            
            var firstFlight = new Flight(flightName);
            // Act
            _controlTower.RegisterFlight(firstFlight);
            var flightLoaded = _controlTower.GetFlight(flightName);
            // Assert
            flightLoaded.Should().Be(firstFlight);
        }

        [Fact]
        public void CalculateDistanceForAFlight()
        {
            // Arrange
            var flightMock = new Mock<IFlight>();
            flightMock.SetupGet(x => x.Name).Returns(flightName);
            _controlTower.RegisterFlight(flightMock.Object);

            // Act
            _controlTower.CalculateDistance(flightName);
            // Assert
            flightMock.Verify(x => x.CalculateDistance(), Times.Once);
        }

        [Fact]
        public void CalculateFuelConsumption()
        {
            // Arrange
            var flightMock = new Mock<IFlight>();            
            flightMock.SetupGet(x => x.Name).Returns(flightName);
            _controlTower.RegisterFlight(flightMock.Object);

            // Act
            _controlTower.CalculateFuelConsumption(flightName);
            // Assert
            flightMock.Verify(x => x.CalculateFuelConsumption(), Times.Once);
        }
    }
}

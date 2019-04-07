using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Domain;
using TUI_SimulatorFlightCosts.Application;
using Xunit;

namespace TUI_SimulatorFlightCosts.App.Tests
{
    public class FlightSimulatorServiceTests
    {
        Mock<IPersistenceService> _persistenceServiceMock;
        const string _flightName = "FlightTest";
        FlightSimulatorService _flightSimulatorService;

        public FlightSimulatorServiceTests()
        {
            _persistenceServiceMock = new Mock<IPersistenceService>();
            _flightSimulatorService = new FlightSimulatorService(_persistenceServiceMock.Object);
        }
        // Feature : 
        // Afficher un rapport avec les calculs
        [Fact]
        public void GetFlights()
        {
            // Arrange
            _persistenceServiceMock.Setup(x => x.GetFlights()).Returns(new List<IFlight> { new Flight(_flightName) });
            // Act
            var flights = _flightSimulatorService.GetFlights();
            // Assert
            flights.Should().NotBeEmpty();
            flights.Should().HaveCount(1);
            flights.First().Name.Should().Be(_flightName);
        }

        [Fact]
        public void GetFlightByName()
        {
            // Arrange
            _persistenceServiceMock.Setup(x => x.GetFlight(_flightName)).Returns(new Flight(_flightName));
            // Act
            var flight = _flightSimulatorService.GetFlight(_flightName);
            // Assert
            flight.Name.Should().Be(_flightName);
        }

        [Fact]
        public void SaveFlight()
        {
            // Arrange
            // Act
            _flightSimulatorService.Save(new Flight(_flightName));
            // Assert
            _persistenceServiceMock.Verify(x => x.SaveFlight(It.IsAny<IFlight>()), Times.Once);
        }
    }
}

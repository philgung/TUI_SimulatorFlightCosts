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

        [Fact]
        public void GetReports()
        {
            // Arrange
            _persistenceServiceMock.Setup(x => x.GetReports()).Returns(new List<Report> {
                new Report { FlightName = "test", CalculType = CalculType.CalculateDistance, Result = 633.445, CalculDate = new DateTime(2019, 04, 08) },
                new Report { FlightName = "test2", CalculType = CalculType.CalculateFuelConsumption, Result = 699.001, CalculDate = new DateTime(2019, 04, 08) }});
            // Act
            var reports = _flightSimulatorService.GetReports();
            // Assert
            reports.Should().NotBeEmpty();
            reports.Should().HaveCount(2);
            reports.First().CalculType.Should().Be(CalculType.CalculateDistance);
            reports.Last().CalculType.Should().Be(CalculType.CalculateFuelConsumption);
        }
    }
}

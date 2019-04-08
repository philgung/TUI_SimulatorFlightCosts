using FluentAssertions;
using TechTalk.SpecFlow;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Infrastructure;

namespace TUI_SimulatorFlightCosts_AcceptanceTests
{
    [Binding]
    public class Register_A_New_FlightSteps
    {
        private ControlTower _currentControlTower;
        public Register_A_New_FlightSteps()
        {
            var persistenceService = new SQLLitePersistenceService();
            persistenceService.InitializeService(@"Data Source=..\..\..\..\Sqlite\TUI.SimulatorFlights.sqlite;Version=3;");
            _currentControlTower = new ControlTower(persistenceService);
        }

        [When(@"A user enters a new flight called '(.*)' on system")]
        public void WhenAUserEntersANewFlightCalledOnSystem(string flightName)
        {
            var flight = new Flight(flightName);
            flight.RegisterDepartureAirport("departure_airport", 0.0, 0.0);
            flight.RegisterDestinationAirport("destination_airport", 0.0, 0.0);
            _currentControlTower.RegisterFlight(flight);
        }

        [Then(@"The flight called '(.*)' can be retrived on system")]
        public void ThenTheFlightCalledCanBeRetrivedOnSystem(string flightName)
        {
            var flightFound = _currentControlTower.GetFlight(flightName);
            flightFound.Should().NotBeNull();
        }
    }
}

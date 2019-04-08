using FluentAssertions;
using TechTalk.SpecFlow;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Infrastructure;

namespace TUI_SimulatorFlightCosts_AcceptanceTests
{
    [Binding]
    public class Calculate_Flight_Distance_And_Fuel_NeededSteps
    {
        private Flight _currentFlight;
        private ControlTower _currentControlTower;
        private double _distanceKm, _fuelConsumption;

        public Calculate_Flight_Distance_And_Fuel_NeededSteps()
        {
            var persistenceService = new SQLLitePersistenceService();
            persistenceService.InitializeService(@"Data Source=..\..\..\..\Sqlite\TUI.SimulatorFlights.sqlite;Version=3;");
            _currentControlTower = new ControlTower(persistenceService);
            _currentFlight = new Flight("currentFlight");
        }


        [Given(@"A flight which has a departure airport with GPS Position \((.*) - (.*), (.*)\)")]
        public void GivenAFlightWhichHasADepartureAirportWithGPSPositionLondon_(string airportName, double latitude, double longitude)
        {
            _currentFlight.RegisterDepartureAirport(airportName, latitude, longitude);
        }        
        
        [Given(@"has a destination airport with GPS Position \((.*) - (.*), (.*)\)")]
        public void GivenHasADestinationAirportWithGPSPosition(string airportName, double latitude, double longitude)
        {
            _currentFlight.RegisterDestinationAirport(airportName, latitude, longitude);
        }
        
        [Given(@"the aircraft fuel consumption per distance/flight time \((.*) L/km\) \+ takeoff effort \((.*) L\)")]
        public void GivenTheAircraftFuelConsumptionPerDistanceFlightTimeLKmHTakeoffEffortLKmH(int fuelConsumptionPerDistancePerFlightTime, int fuelConsumptionTakeoffEffort)
        {
            _currentFlight.SetFuelConsumptionPerDistance(fuelConsumptionPerDistancePerFlightTime);
            _currentFlight.SetFuelConsumptionTakeoffEffort(fuelConsumptionTakeoffEffort);
        }       

        [Given(@"is registered in control tower like '(.*)'")]
        public void GivenIsRegisteredInControlTowerLike(string flightName)
        {
            _currentFlight.Rename(flightName);
            _currentControlTower.RegisterFlight(_currentFlight);
        }


        [When(@"the simulator calculate travel distance for the flight '(.*)'")]
        public void WhenTheFlightTakesPlace(string flightName)
        {
            _distanceKm = _currentControlTower.CalculateDistance(flightName);
        }

        [When(@"the simulator calculate the fuel consumption for the flight '(.*)'")]
        public void WhenTheFuelConsumptionSimulatorCalculate(string flightName)
        {
            _fuelConsumption = _currentControlTower.CalculateFuelConsumption(flightName);
        }


        [Then(@"the travel distance was (.*) km")]
        public void ThenTheTravelDistanceWasKm(double distanceExpected)
        {
            _distanceKm.Should().Be(distanceExpected);
        }
        
        [Then(@"the total fuel consumption was (.*) L")]
        public void ThenTheTotalFuelConsumptionWasL(double fuelConsumptionExpected)
        {
            _fuelConsumption.Should().Be(fuelConsumptionExpected);
        }
    }
}

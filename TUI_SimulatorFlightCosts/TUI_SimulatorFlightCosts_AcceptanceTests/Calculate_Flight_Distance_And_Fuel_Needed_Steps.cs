using System;
using TechTalk.SpecFlow;
using TUI.Domain.SimulatorFlights;

namespace TUI_SimulatorFlightCosts_AcceptanceTests
{
    [Binding]
    public class Calculate_Flight_Distance_And_Fuel_NeededSteps
    {
        private Flight _currentFlight = new Flight("currentFlight");
        private ControlTower _currentControlTower = new ControlTower();

        [Given(@"A flight which has a departure airport with GPS Position \((.*) - (.*), (.*)\)")]
        public void GivenAFlightWhichHasADepartureAirportWithGPSPositionLondon_(string airportName, Decimal latitude, Decimal longitude)
        {
            _currentFlight.RegisterDepartureAirport(airportName, latitude, longitude);
        }        
        
        [Given(@"has a destination airport with GPS Position \((.*) - (.*), (.*)\)")]
        public void GivenHasADestinationAirportWithGPSPosition(string airportName, Decimal latitude, Decimal longitude)
        {
            _currentFlight.RegisterDestinationAirport(airportName, latitude, longitude);
        }
        
        [Given(@"the aircraft fuel consumption per distance/flight time \((.*) L/km/h\) \+ takeoff effort \((.*) L/km/h\)")]
        public void GivenTheAircraftFuelConsumptionPerDistanceFlightTimeLKmHTakeoffEffortLKmH(int fuelConsumptionPerDistancePerFlightTime, int fuelConsumptionTakeoffEffort)
        {
            _currentFlight.SetFuelConsumptionPerDistancePerFlightTime(fuelConsumptionPerDistancePerFlightTime);
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
            var flight = _currentControlTower.GetFlight(flightName);
            _currentControlTower.CalculateDistance(flight);
        }

        [When(@"the simulator calculate the fuel consumption for the flight '(.*)'")]
        public void WhenTheFuelConsumptionSimulatorCalculate(string flightName)
        {
            var flight = _currentControlTower.GetFlight(flightName);
            _currentControlTower.CalculateFuelConsumption(flight);
        }


        [Then(@"the travel distance was (.*) km")]
        public void ThenTheTravelDistanceWasKm(int distanceExpected)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the total fuel consumption was (.*) L")]
        public void ThenTheTotalFuelConsumptionWasL(int fuelConsumptionExpected)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

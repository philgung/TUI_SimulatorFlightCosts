using System;
using TechTalk.SpecFlow;

namespace TUI_SimulatorFlightCosts_AcceptanceTests
{
    [Binding]
    public class Calculate_Flight_Distance_And_Fuel_NeededSteps
    {
        [Given(@"A flight which has a departure airport with GPS Position \(London - (.*), (.*)\)")]
        public void GivenAFlightWhichHasADepartureAirportWithGPSPositionLondon_(Decimal latitude, Decimal longitude)
        {
            ScenarioContext.Current.Pending();
        }        
        
        [Given(@"has a destination airport with GPS Position \(Roissy Charlles De Gaulle - (.*), (.*)\)")]
        public void GivenHasADestinationAirportWithGPSPosition(Decimal latitude, Decimal longitude)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the aircraft fuel consumption per distance/flight time \((.*) L/km/h\) \+ takeoff effort \((.*) L/km/h\)")]
        public void GivenTheAircraftFuelConsumptionPerDistanceFlightTimeLKmHTakeoffEffortLKmH(int fuelConsumptionPerDistancePerFlightTime, int fuelConsumptionTakeoffEffort)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the flight takes place")]
        public void WhenTheFlightTakesPlace()
        {
            ScenarioContext.Current.Pending();
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

using System;
using TechTalk.SpecFlow;

namespace TUI_SimulatorFlightCosts_AcceptanceTests
{
    [Binding]
    public class Register_A_New_FlightSteps
    {
        [When(@"A user enters a new flight called '(.*)' on system")]
        public void WhenAUserEntersANewFlightCalledOnSystem(string flightName)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The flight called '(.*)' can be retrived on system")]
        public void ThenTheFlightCalledCanBeRetrivedOnSystem(string flightName)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

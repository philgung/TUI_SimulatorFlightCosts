﻿using FluentAssertions;
using System;
using TechTalk.SpecFlow;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Infrastructure;

namespace TUI_SimulatorFlightCosts_AcceptanceTests
{
    [Binding]
    public class Calculate_Flight_Distance_And_Fuel_NeededSteps
    {
        private Flight _currentFlight = new Flight("currentFlight");
        private ControlTower _currentControlTower = new ControlTower(new SQLLitePersistenceService());
        private double _distanceKm, _fuelConsumption;


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
            _distanceKm = _currentControlTower.CalculateDistance(flightName);
        }

        [When(@"the simulator calculate the fuel consumption for the flight '(.*)'")]
        public void WhenTheFuelConsumptionSimulatorCalculate(string flightName)
        {
            _fuelConsumption = _currentControlTower.CalculateFuelConsumption(flightName);
        }


        [Then(@"the travel distance was (.*) km")]
        public void ThenTheTravelDistanceWasKm(int distanceExpected)
        {
            _distanceKm.Should().Be(distanceExpected);
        }
        
        [Then(@"the total fuel consumption was (.*) L")]
        public void ThenTheTotalFuelConsumptionWasL(int fuelConsumptionExpected)
        {
            _fuelConsumption.Should().Be(fuelConsumptionExpected);
        }
    }
}

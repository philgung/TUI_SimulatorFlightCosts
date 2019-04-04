using System;

namespace TUI.Domain.SimulatorFlights
{
    public class Flight
    {
        public Flight(string flightName)
        {
            this.Name = flightName;
        }

        public string Name { get; }

        public void RegisterDepartureAirport(string airportName, decimal latitude, decimal longitude)
        {
            throw new NotImplementedException();
        }

        public void RegisterDestinationAirport(string airportName, decimal latitude, decimal longitude)
        {
            throw new NotImplementedException();
        }

        public void SetFuelConsumptionPerDistancePerFlightTime(int fuelConsumptionPerDistancePerFlightTime)
        {
            throw new NotImplementedException();
        }

        public void SetFuelConsumptionTakeoffEffort(int fuelConsumptionTakeoffEffort)
        {
            throw new NotImplementedException();
        }

        public void Rename(string flightName)
        {
            throw new NotImplementedException();
        }
    }
}

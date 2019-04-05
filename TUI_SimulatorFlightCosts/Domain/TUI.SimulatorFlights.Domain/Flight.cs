using System;

namespace TUI.Domain.SimulatorFlights
{
    public class Flight : IFlight
    {
        private Airport _departureAirport;
        private Airport _destinationAirport;
        private int _fuelConsumptionPerDistancePerFlightTime;
        private int _fuelConsumptionTakeoffEffort;
        private int _averageSpeedAircraft;

        public string Name { get; private set; }

        public Flight(string flightName)
        {
            this.Name = flightName;
        }

        public double CalculateDistance()
        {
            throw new NotImplementedException();
        }

        public double CalculateFuelConsumption()
        {
            throw new NotImplementedException();
        }       

        public void RegisterDepartureAirport(string airportName, decimal latitude, decimal longitude)
        {
            _departureAirport = new Airport(airportName, new GPSPosition(latitude, longitude));
        }

        public void RegisterDestinationAirport(string airportName, decimal latitude, decimal longitude)
        {
            _destinationAirport = new Airport(airportName, new GPSPosition(latitude, longitude));
        }

        public void SetFuelConsumptionPerDistancePerFlightTime(int fuelConsumptionPerDistancePerFlightTime)
        {
            _fuelConsumptionPerDistancePerFlightTime = fuelConsumptionPerDistancePerFlightTime;
        }

        public void SetFuelConsumptionTakeoffEffort(int fuelConsumptionTakeoffEffort)
        {
            _fuelConsumptionTakeoffEffort = fuelConsumptionTakeoffEffort;
        }

        public void Rename(string flightName)
        {
            Name = flightName;
        }

        public void SetAverageSpeedAircraft(int averageSpeedAircraft)
        {
            _averageSpeedAircraft = averageSpeedAircraft;
        }
    }
}

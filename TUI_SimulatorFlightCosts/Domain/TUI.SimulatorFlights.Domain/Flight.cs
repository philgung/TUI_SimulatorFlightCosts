using TUI.SimulatorFlights.Domain.Extensions;

namespace TUI.Domain.SimulatorFlights
{
    public class Flight : IFlight
    {
        private Airport _departureAirport;
        private Airport _destinationAirport;
        private int _fuelConsumptionPerDistancePerFlightTime;
        private int _fuelConsumptionTakeoffEffort;

        public string Name { get; private set; }

        public Flight(string flightName)
        {
            this.Name = flightName;
        }

        public double CalculateDistance()
        {
            return _departureAirport.GetDistanceTo(_destinationAirport);
        }

        public double CalculateFuelConsumption()
        {
            return (CalculateDistance() * _fuelConsumptionPerDistancePerFlightTime) + _fuelConsumptionTakeoffEffort;
        }

        public void RegisterDepartureAirport(string airportName, double latitude, double longitude)
        {
            _departureAirport = new Airport(airportName, new GPSPosition(latitude, longitude));
        }

        public void RegisterDestinationAirport(string airportName, double latitude, double longitude)
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
    }
}

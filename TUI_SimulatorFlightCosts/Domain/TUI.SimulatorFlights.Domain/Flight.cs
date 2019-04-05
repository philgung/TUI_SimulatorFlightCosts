using TUI.SimulatorFlights.Domain.Extensions;

namespace TUI.Domain.SimulatorFlights
{
    public class Flight : IFlight
    {
        public Airport DepartureAirport { get; private set; }
        public Airport DestinationAirport { get; private set; }

        public string Name { get; private set; }
        public int FuelConsumptionPerDistance { get; private set; }
        public int FuelConsumptionTakeoffEffort { get; private set; }

        public Flight(string flightName)
        {
            this.Name = flightName;
        }

        public double CalculateDistance()
        {
            return DepartureAirport.GetDistanceTo(DestinationAirport);
        }

        public double CalculateFuelConsumption()
        {
            return (CalculateDistance() * FuelConsumptionPerDistance) + FuelConsumptionTakeoffEffort;
        }

        public void RegisterDepartureAirport(string airportName, double latitude, double longitude)
        {
            DepartureAirport = new Airport(airportName, new GPSPosition(latitude, longitude));
        }

        public void RegisterDestinationAirport(string airportName, double latitude, double longitude)
        {
            DestinationAirport = new Airport(airportName, new GPSPosition(latitude, longitude));
        }

        public void SetFuelConsumptionPerDistance(int fuelConsumptionPerDistance)
        {
            FuelConsumptionPerDistance = fuelConsumptionPerDistance;
        }

        public void SetFuelConsumptionTakeoffEffort(int fuelConsumptionTakeoffEffort)
        {
            FuelConsumptionTakeoffEffort = fuelConsumptionTakeoffEffort;
        }

        public void Rename(string flightName)
        {
            Name = flightName;
        }
    }
}

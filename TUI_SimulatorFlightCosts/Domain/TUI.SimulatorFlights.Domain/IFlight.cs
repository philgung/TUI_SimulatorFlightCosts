namespace TUI.Domain.SimulatorFlights
{
    public interface IFlight
    {
        string Name { get;}

        int FuelConsumptionPerDistance { get; }
        int FuelConsumptionTakeoffEffort { get; }
        Airport DepartureAirport { get; }
        Airport DestinationAirport { get; }

        void RegisterDepartureAirport(string airportName, double latitude, double longitude);
        void RegisterDestinationAirport(string airportName, double latitude, double longitude);
        void Rename(string flightName);
        double CalculateDistance();
        double CalculateFuelConsumption();
        void SetFuelConsumptionPerDistance(int fuelConsumptionPerDistance);
        void SetFuelConsumptionTakeoffEffort(int fuelConsumptionTakeoffEffort);
    }
}
namespace TUI.Domain.SimulatorFlights
{
    public interface IFlight
    {
        string Name { get;}
        void RegisterDepartureAirport(string airportName, double latitude, double longitude);
        void RegisterDestinationAirport(string airportName, double latitude, double longitude);
        void Rename(string flightName);
        double CalculateDistance();
        double CalculateFuelConsumption();
        void SetFuelConsumptionPerDistancePerFlightTime(int fuelConsumptionPerDistancePerFlightTime);
        void SetFuelConsumptionTakeoffEffort(int fuelConsumptionTakeoffEffort);
    }
}
namespace TUI.Domain.SimulatorFlights
{
    public interface IFlight
    {
        string Name { get;}
        void RegisterDepartureAirport(string airportName, decimal latitude, decimal longitude);
        void RegisterDestinationAirport(string airportName, decimal latitude, decimal longitude);
        void Rename(string flightName);
        double CalculateDistance();
        double CalculateFuelConsumption();
        void SetFuelConsumptionPerDistancePerFlightTime(int fuelConsumptionPerDistancePerFlightTime);
        void SetFuelConsumptionTakeoffEffort(int fuelConsumptionTakeoffEffort);
    }
}
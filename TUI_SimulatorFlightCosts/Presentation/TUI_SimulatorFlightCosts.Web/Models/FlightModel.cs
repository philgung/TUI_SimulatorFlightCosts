namespace TUI_SimulatorFlightCosts.Web.Models
{
    public class FlightModel
    {
        public string Name { get; set; }
        public int FuelConsumptionPerDistance { get; set; }
        public int FuelConsumptionTakeoffEffort { get; set; }
        public string DepartureAirportName { get; set; }
        public double DepartureAiportLatitude { get; set; }
        public double DepartureAirportLongitude { get; set; }
        public string DestinationAirportName { get; set; }
        public double DestinationAirportLatitude { get; set; }
        public double DestinationAirportLongitude { get; set; }
    }
}

using TUI.Domain.SimulatorFlights;
using TUI_SimulatorFlightCosts.Web.Models;

namespace TUI_SimulatorFlightCosts.Web.Adapters
{
    public static class FlightModelAdapter
    {
        public static IFlight ToFlight(this FlightModel flightModel)
        {
            var flight = new Flight(flightModel.Name);
            flight.SetFuelConsumptionPerDistance(flightModel.FuelConsumptionPerDistance);
            flight.SetFuelConsumptionTakeoffEffort(flightModel.FuelConsumptionTakeoffEffort);
            flight.RegisterDepartureAirport(flightModel.DepartureAirportName, flightModel.DepartureAiportLatitude, flightModel.DepartureAirportLongitude);
            flight.RegisterDestinationAirport(flightModel.DestinationAirportName, flightModel.DestinationAirportLatitude, flightModel.DestinationAirportLongitude);
            return flight;
        }

        public static FlightModel ToFlightModel(this IFlight flight)
        {
            return new FlightModel
            {
                Name = flight.Name,
                FuelConsumptionPerDistance = flight.FuelConsumptionPerDistance,
                FuelConsumptionTakeoffEffort = flight.FuelConsumptionTakeoffEffort,
                DepartureAirportName = flight.DepartureAirport.AirportName,
                DepartureAiportLatitude = flight.DepartureAirport.GetLatitude(),
                DepartureAirportLongitude = flight.DepartureAirport.GetLongitude(),
                DestinationAirportName = flight.DestinationAirport.AirportName,
                DestinationAirportLatitude = flight.DestinationAirport.GetLatitude(),
                DestinationAirportLongitude = flight.DestinationAirport.GetLongitude()
            };
        }
    }
}

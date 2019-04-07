using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Infrastructure.DTO;

namespace TUI.SimulatorFlights.Infrastructure
{
    public static class FlightAdapter
    {
        public static IFlight ToFlight(this FlightDTO flightDTO)
        {
            var flight = new Flight(flightDTO.flight_name);
            flight.SetFuelConsumptionPerDistance(flightDTO.fuel_consumption_per_distance);
            flight.SetFuelConsumptionTakeoffEffort(flightDTO.fuel_consumption_takeoff_effort);
            flight.RegisterDepartureAirport(flightDTO.departure_airport_name, flightDTO.departure_airport_latitude, flightDTO.departure_airport_longitude);
            flight.RegisterDestinationAirport(flightDTO.destination_airport_name, flightDTO.destination_airport_latitude, flightDTO.destination_airport_longitude);
            return flight;
            
        }
    }
}

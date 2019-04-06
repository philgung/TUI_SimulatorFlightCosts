using System;
using System.Collections.Generic;
using System.Text;

namespace TUI.SimulatorFlights.Infrastructure.DTO
{
    public class FlightDTO
    {
        public string flight_name { get; set; }
        public int fuel_consumption_per_distance { get; set; }
        public int fuel_consumption_takeoff_effort { get; set; }
        public string departure_airport_name { get; set; }
        public double departure_airport_latitude { get; set; }
        public double departure_airport_longitude { get; set; }
        public string destination_airport_name { get; set; }
        public double destination_airport_latitude { get; set; }
        public double destination_airport_longitude { get; set; }
    }
}

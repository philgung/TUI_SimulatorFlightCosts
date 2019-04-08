using System.ComponentModel.DataAnnotations;

namespace TUI_SimulatorFlightCosts.Web.Models
{
    public class FlightModel
    {
        [Display(Name="Flight Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Fuel consumption per distance")]
        public int FuelConsumptionPerDistance { get; set; }
        [Display(Name = "Fuel consumption at takeoff effort")]
        public int FuelConsumptionTakeoffEffort { get; set; }
        [Display(Name = "Departure airport name")]
        public string DepartureAirportName { get; set; }
        [Display(Name = "Departure airport latitude")]
        public double DepartureAiportLatitude { get; set; }
        [Display(Name = "Departure airport longitude")]
        public double DepartureAirportLongitude { get; set; }
        [Display(Name = "Destination airport name")]
        public string DestinationAirportName { get; set; }
        [Display(Name = "Destination airport latitude")]
        public double DestinationAirportLatitude { get; set; }
        [Display(Name = "Destination airport longitude")]
        public double DestinationAirportLongitude { get; set; }
    }
}

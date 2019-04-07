using System.Collections.Generic;
using TUI.Domain.SimulatorFlights;

namespace UI_SimulatorFlightCosts.Web.Models
{
    public class HomeModel
    {
        public HomeModel()
        {
        }

        public ICollection<IFlight> Flights { get; set; }
    }
}
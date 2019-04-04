using System;
using System.Collections.Generic;
using System.Text;

namespace TUI.Domain.SimulatorFlights
{
    class Airport
    {
        private string airportName;
        private GPSPosition gPSPosition;

        public Airport(string airportName, GPSPosition gPSPosition)
        {
            this.airportName = airportName;
            this.gPSPosition = gPSPosition;
        }
    }
}

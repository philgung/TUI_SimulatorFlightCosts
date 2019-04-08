using System;
using System.Collections.Generic;
using System.Text;

namespace TUI.SimulatorFlights.Domain
{
    public enum CalculType
    {
        CalculateDistance,
        CalculateFuelConsumption
    }
    public class Report
    {
        public string FlightName { get; set; }
        public CalculType CalculType { get; set; }
        public double Result { get; set; }
        public DateTime CalculDate { get; set; }
    }
}

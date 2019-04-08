using System;
using TUI.SimulatorFlights.Domain;
using TUI.SimulatorFlights.Infrastructure.DTO;

namespace TUI.SimulatorFlights.Infrastructure
{
    public static class ReportAdapter
    {
        public static Report ToReport(this ReportDTO reportDTO)
        {
            return new Report
            {
                FlightName = reportDTO.FlightName,
                CalculType = Enum.Parse<CalculType>(reportDTO.CalculType),
                Result = reportDTO.Result,
                CalculDate = DateTime.Parse(reportDTO.CalculDate)
            };
        }
    }
}

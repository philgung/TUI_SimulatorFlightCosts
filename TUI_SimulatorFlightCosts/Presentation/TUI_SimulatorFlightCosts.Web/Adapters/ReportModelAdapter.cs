using TUI.SimulatorFlights.Domain;
using TUI_SimulatorFlightCosts.Web.Models;

namespace TUI_SimulatorFlightCosts.Web.Adapters
{
    public static class ReportModelAdapter
    {
        public static ReportModel ToReportModel(this Report report)
        {
            return new ReportModel
            {
                FlightName = report.FlightName,
                CalculType = report.CalculType == CalculType.CalculateDistance ? "Distance Traveled" : "Consumption Fuel",
                CalculDate = report.CalculDate.ToShortDateString(),
                Result = report.CalculType == CalculType.CalculateDistance ? $"{report.Result.ToString("0.00000")} km" : $"{report.Result.ToString("0.00000")} L"
            };
        }
    }
}

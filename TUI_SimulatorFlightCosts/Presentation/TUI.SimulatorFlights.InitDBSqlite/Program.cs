using System;
using TUI.SimulatorFlights.Infrastructure;

namespace TUI.SimulatorFlights.InitDBSqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new SQLLitePersistenceService();
            Console.WriteLine("SQLite : Initialize table");
            service.InitializeTables();
            Console.WriteLine("SQLite : Tables were created.");
        }
    }
}

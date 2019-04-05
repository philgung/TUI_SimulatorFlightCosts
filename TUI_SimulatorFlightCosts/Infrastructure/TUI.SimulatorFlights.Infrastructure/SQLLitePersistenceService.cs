using System;
using System.Data.SQLite;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Domain;

namespace TUI.SimulatorFlights.Infrastructure
{
    public class SQLLitePersistenceService : IPersistenceService
    {
        private string _connectionString = "Data Source=TUI.SimulatorFlights.sqlite";
        public SQLLitePersistenceService()
        {
            SQLiteConnection.CreateFile("TUI.SimulatorFlights.sqlite");
            using (var connection = new SQLiteConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "CREATE TABLE flight (id INT AUTOINCREMENT, name VARCHAR(255))";
                command.ExecuteNonQuery();

            }
        }
        public IFlight GetFlight(string flightName)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "";
                command.ExecuteNonQuery();
                
            }
            
            throw new NotImplementedException();
        }

        public void SaveFlight(IFlight flight)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "INSERT INTO flight (id, name) VALUES (0, '', '')";
                command.ExecuteNonQuery();

            }

            throw new NotImplementedException();
        }
    }
}

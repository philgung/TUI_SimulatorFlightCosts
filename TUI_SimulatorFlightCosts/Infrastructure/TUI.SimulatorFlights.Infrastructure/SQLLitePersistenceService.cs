using System;
using System.Data.SQLite;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Domain;

namespace TUI.SimulatorFlights.Infrastructure
{
    public class SQLLitePersistenceService : IPersistenceService
    {
        private string _connectionString = "Data Source=TUI.SimulatorFlights.sqlite";
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
                command.CommandText = "INSERT INTO flight (name) VALUES ('', '')";
                command.ExecuteNonQuery();
            }

            throw new NotImplementedException();
        }

        public void InitializeTables()
        {
            SQLiteConnection.CreateFile("TUI.SimulatorFlights.sqlite");
            using (var connection = new SQLiteConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = 
                    "CREATE TABLE flight (id INT AUTOINCREMENT, " +
                    "flight_name VARCHAR(255), " +
                    "fuel_consumption_per_distance INT," +
                    "fuel_consumption_takeoff_effort INT," +
                    "departure_airport_name VARCHAR(255)," +
                    "departure_airport_latitude double," +
                    "departure_airport_longitude double," +
                    "destination_airport_name VARCHAR(255)," +
                    "departure_airport_latitude double," +
                    "departure_airport_longitude double)"
                    ;
                command.ExecuteNonQuery();
            }
        }
    }
}

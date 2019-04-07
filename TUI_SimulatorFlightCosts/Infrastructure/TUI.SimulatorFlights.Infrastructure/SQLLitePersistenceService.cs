using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using TUI.Domain.SimulatorFlights;
using TUI.SimulatorFlights.Domain;
using TUI.SimulatorFlights.Infrastructure.DTO;

namespace TUI.SimulatorFlights.Infrastructure
{
    public class SQLLitePersistenceService : IPersistenceService
    {
        private string _connectionString = @"Data Source=..\..\..\..\Sqlite\TUI.SimulatorFlights.sqlite;Version=3;";

        public IFlight GetFlight(string flightName)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                var flightDTO = connection.Query<FlightDTO>($"select * from flight where flight_name='{flightName}'").FirstOrDefault();
                return flightDTO.ToFlight();
            }
        }

        public void SaveFlight(IFlight flight)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "INSERT INTO flight (flight_name,fuel_consumption_per_distance,fuel_consumption_takeoff_effort," +
                    "departure_airport_name, departure_airport_latitude, departure_airport_longitude," +
                    "destination_airport_name, destination_airport_latitude, destination_airport_longitude" +
                   $") VALUES ('{flight.Name}', {flight.FuelConsumptionPerDistance}, {flight.FuelConsumptionTakeoffEffort},'departure_airport',{flight.DepartureAirport.GPSPosition.Latitude}, {flight.DepartureAirport.GPSPosition.Longitude}, 'destination_airport', {flight.DestinationAirport.GPSPosition.Latitude}, {flight.DestinationAirport.GPSPosition.Longitude})" +
                   $"ON CONFLICT(flight_name) DO UPDATE SET fuel_consumption_per_distance = {flight.FuelConsumptionPerDistance},fuel_consumption_takeoff_effort={flight.FuelConsumptionTakeoffEffort}," +
                    $"departure_airport_latitude={flight.DepartureAirport.GPSPosition.Latitude}, departure_airport_longitude={flight.DepartureAirport.GPSPosition.Longitude}," +
                    $"destination_airport_latitude={flight.DepartureAirport.GPSPosition.Latitude}, destination_airport_longitude={flight.DestinationAirport.GPSPosition.Longitude};";
                command.ExecuteNonQuery();
            }
        }

        public void InitializeTables()
        {
            SQLiteConnection.CreateFile("TUI.SimulatorFlights.sqlite");
            using (var connection = new SQLiteConnection(@"Data Source=TUI.SimulatorFlights.sqlite;Version=3;"))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = 
                    "CREATE TABLE flight (flight_name VARCHAR(255) PRIMARY KEY, " +
                    "fuel_consumption_per_distance INT," +
                    "fuel_consumption_takeoff_effort INT," +
                    "departure_airport_name VARCHAR(255)," +
                    "departure_airport_latitude double," +
                    "departure_airport_longitude double," +
                    "destination_airport_name VARCHAR(255)," +
                    "destination_airport_latitude double," +
                    "destination_airport_longitude double)"
                    ;
                command.ExecuteNonQuery();
            }
        }

        public ICollection<IFlight> GetFlights()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                var flightDTOs = connection.Query<FlightDTO>($"select * from flight");
                return flightDTOs.Select(x => x.ToFlight()).ToList();
            }
        }
    }
}

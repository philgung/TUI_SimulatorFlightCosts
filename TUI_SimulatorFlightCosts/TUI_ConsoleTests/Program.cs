using GeoCoordinatePortable;
using System;

namespace TUI_ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            var londonAirportGPS = new GeoCoordinate(51.5048, 0.052745500000014545);
            var charlesDeGaulesAeroportGPS = new GeoCoordinate(49.007, 2.559790000000021);

            Console.WriteLine($"Distance aéroport : {londonAirportGPS.GetDistanceTo(charlesDeGaulesAeroportGPS) / 1000} km");
            Console.ReadKey();
        }
    }
}

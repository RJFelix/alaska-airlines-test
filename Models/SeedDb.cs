using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CsvHelper;

namespace alaska_airlines_test.Models
{
  public static class SeedDb
  {
    public static void Seed(IServiceProvider serviceProvider)
    {
      using (var context = new FlightDbContext(serviceProvider.GetRequiredService<DbContextOptions<FlightDbContext>>()))
      {
        // if(context.Flight.Any() && context.Airport.Any())
        // {
        //   return;
        // }
        if(!context.Airport.Any()) {
          string airportDataFilename = "./Models/Data/airports.csv";
          using (StreamReader reader = File.OpenText(airportDataFilename))
          {
            var airportsCsv = new CsvReader(reader);
            airportsCsv.Configuration.RegisterClassMap<AirportMap>();
            var airports = airportsCsv.GetRecords<Airport>();
            foreach(var airport in airports)
            {
              context.Airport.Add(airport);
            }
            context.SaveChanges();
          }
        }
        if(!context.Flight.Any()) {
          string flightDataFilename = "./Models/Data/flights.csv";
          using (StreamReader reader = File.OpenText(flightDataFilename))
          {
            var flightsCsv = new CsvReader(reader);
            flightsCsv.Configuration.RegisterClassMap<FlightMap>();
            var flights = flightsCsv.GetRecords<Flight>();
            foreach(var flight in flights)
            {
              context.Flight.Add(flight);
            }
            context.SaveChanges();
          }
        }
      }
    }
  }
}
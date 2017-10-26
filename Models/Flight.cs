using System;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace alaska_airlines_test.Models
{
  public class Flight
  {
    public int ID { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public int FlightNumber { get; set; }
    public string Departs { get; set; }
    public string Arrives { get; set; }
    public int MainCabinPrice { get; set; }
    public int FirstClassPrice { get; set; }
  }
  public sealed class FlightMap : ClassMap<Flight>
  {
    public FlightMap()
    {
      AutoMap();
      Map(m => m.ID).Ignore();
    }
  }
}
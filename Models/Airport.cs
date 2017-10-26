using System;
using CsvHelper.Configuration;

namespace alaska_airlines_test.Models
{
  public class Airport
  {
    public int ID { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
  }

  public sealed class AirportMap : ClassMap<Airport>
  {
    public AirportMap()
    {
      AutoMap();
      Map(m => m.ID).Ignore();
    }
  }
}
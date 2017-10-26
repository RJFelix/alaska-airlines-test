using System;
using System.ComponentModel.DataAnnotations;
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

    [Display(Name = "Flight Number")]
    public int FlightNumber { get; set; }
    [DataType(DataType.Time)]
    public DateTime Departs { get; set; }
    [DataType(DataType.Time)]
    public DateTime Arrives { get; set; }
    [Display(Name = "Main Cabin Price")]
    [DataType(DataType.Currency)]
    public int MainCabinPrice { get; set; }
    [Display(Name = "First Class Price")]
    [DataType(DataType.Currency)]
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
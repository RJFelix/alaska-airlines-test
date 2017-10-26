using System;

namespace alaska_airlines_test.Models
{
  public class Flight
  {
    public int ID { get; set; }
    public int From { get; set; }
    public int To { get; set; }
    public int FlightNumber { get; set; }
    public TimeSpan FlightTime { get; set; }
    public int MainCabinPrice { get; set; }
    public int FirstClassPrice { get; set; }
  }
}
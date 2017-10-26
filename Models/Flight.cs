using System;

namespace alaska_airlines_test.Models
{
  public class Flight
  {
    public string From { get; set; }
    public string To { get; set; }
    public int FlightNumber { get; set; }
    public TimeSpan FlightTime { get; set; }
    public int MainCabinPrice { get; set; }
    public int FirstClassPrice { get; set; }
  }
}
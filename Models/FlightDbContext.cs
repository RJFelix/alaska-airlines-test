using Microsoft.EntityFrameworkCore;

namespace alaska_airlines_test.Models
{
  public class FlightDbContext : DbContext
  {
    public FlightDbContext (DbContextOptions<FlightDbContext> options)
      : base(options)
      {

      }
    
    public DbSet<alaska_airlines_test.Models.Airport> Airport { get; set; }
    public DbSet<alaska_airlines_test.Models.Flight> Flight { get; set; }
  }
}
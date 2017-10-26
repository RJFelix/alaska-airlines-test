using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using alaska_airlines_test.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace alaska_airlines_test.Controllers
{
  public class FlightsController : Controller
  {
    private readonly FlightDbContext _context;
    public FlightsController(FlightDbContext context)
    {
      _context = context;
    }
    // GET: /flights

    public async Task<IActionResult> Index()
    {
      var flights = _context.Flight.AsNoTracking();
      return View(await flights.ToListAsync());
    }

    public IActionResult Search(string orig, string dest)
    {
      ViewData["origin"] = orig;
      ViewData["destination"] = dest;
      return View();
    }
  }
}
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace alaska_airlines_test.Controllers
{
  public class FlightsController : Controller
  {
    // GET: /flights

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Search(string orig, string dest)
    {
      ViewData["origin"] = orig;
      ViewData["destination"] = dest;
      return View();
    }
  }
}
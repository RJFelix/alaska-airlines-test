using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace alaska_airlines_test
{
  public class FlightsController : Controller
  {
    // GET: /flights

    public IActionResult Index()
    {
      return View();
    }

    public string Search(string orig, string dest)
    {
      return HtmlEncoder.Default.Encode($"results for flights from {orig} to {dest}...");
    }
  }
}
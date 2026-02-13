using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DiscountAmount = 0;
            ViewBag.Total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuote p)
        {
            if (!ModelState.IsValid)
            {
                // reset values shown when model is invalid
                ViewBag.DiscountAmount = 0;
                ViewBag.Total = 0;
                return View(p);
            }

            ViewBag.DiscountAmount = p.DiscountAmount;
            ViewBag.Total = p.Total;
            return View(p);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

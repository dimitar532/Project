using F1VacationSite.Models;
using F1VacationSite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace F1VacationSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITripService tripService;

        public HomeController(ITripService tripService)
        {
            this.tripService = tripService;
        }

        public async Task<IActionResult> Index()
        {
            var featuredTrips = await tripService.GetFeaturedTripsAsync(3);

            return View(featuredTrips);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

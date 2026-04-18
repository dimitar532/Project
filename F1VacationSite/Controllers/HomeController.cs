using System.Diagnostics;
using F1VacationSite.Data;
using F1VacationSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace F1VacationSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly VacationDbContext dbContext;

        public HomeController(VacationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var featuredTrips = await dbContext.Trips
                .Include(t => t.Race)
                .Include(t => t.Hotel)
                .OrderBy(t => t.Price)
                .Take(3)
                .AsNoTracking()
                .ToListAsync();

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

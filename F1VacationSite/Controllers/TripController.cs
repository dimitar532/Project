using F1VacationSite.Data;
using F1VacationSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace F1VacationSite.Controllers
{
    public class TripController : Controller
    {
        private readonly VacationDbContext dbContext;
        public TripController(VacationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Trip> trips = dbContext
                .Trips
                .Include(t => t.Races)
                .Include(t => t.Hotels)
                .ToList();

            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
         public IActionResult Create()
        {
            return View();
        }
         public IActionResult Edit(int id)
        {
            return View();
        }
         public IActionResult Delete(int id)
        {
            return View();
        }
    }
}

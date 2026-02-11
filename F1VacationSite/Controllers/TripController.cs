using F1VacationSite.Data;
using F1VacationSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace F1VacationSite.Controllers
{
    public class TripsController : Controller
    {
        private readonly VacationDbContext dbContext;
        public TripsController(VacationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var trips = await dbContext
                .Trips
                .Include(t => t.Race)
                .Include(t => t.Hotel)
                .AsNoTracking()
                .ToListAsync();

            return View(trips);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await PopulateSelectTripsAsync();
            return View(new Trip());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Trip trip)
        {
            if (!ModelState.IsValid)
            {
                await PopulateSelectTripsAsync();
                return View(trip);
            }

            dbContext.Trips.Add(trip);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id) => View();

        public IActionResult Edit(int id) => View();

        public IActionResult Delete(int id) => View();

        private async Task PopulateSelectTripsAsync()
        {
            var races = await dbContext.Races
                .AsNoTracking()
                .OrderBy(r => r.Name)
                .ToListAsync();

            var hotels = await dbContext.Hotels
                .AsNoTracking()
                .OrderBy(h => h.Name)
                .ToListAsync();

            ViewData["Races"] = new SelectList(races, "Id", "Name");
            ViewData["Hotels"] = new SelectList(hotels, "Id", "Name");
        }
    }
}


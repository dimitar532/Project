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

        public async Task<IActionResult> Details(int id)
        {
            var trip = await dbContext
                .Trips
                .Include(t => t.Race)
                .Include(t => t.Hotel)
                .FirstOrDefaultAsync(t => t.Id == id);

            if(trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var trip = await dbContext.Trips.FindAsync(id);

            if (trip == null)
                return NotFound();

            await PopulateSelectTripsAsync();
            return View(trip);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var trip = await dbContext.Trips.FindAsync(id);
            if (trip == null)
            {
                return NotFound();
            }

            dbContext.Trips.Remove(trip);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
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


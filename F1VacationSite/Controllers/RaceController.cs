using Microsoft.AspNetCore.Mvc;

namespace F1VacationSite.Controllers
{
    using F1VacationSite.Data;
    using Microsoft.EntityFrameworkCore;

    public class RaceController : Controller
    {
        private readonly VacationDbContext dbContext;
        public RaceController(VacationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var races = await dbContext
                .Races
                .Include(r => r.Trips)
                .ThenInclude(t => t.Hotel)
                .ToListAsync();

            return View(races);
        }

        public async Task<IActionResult> Details(int id)
        {
            var races = await dbContext
                .Races
                .Include(r => r.Trips)
                .ThenInclude(t => t.Hotel)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (races == null)
            {
                return NotFound();
            }

            return View(races);
        }
    }
}

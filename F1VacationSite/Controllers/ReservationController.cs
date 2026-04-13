using F1VacationSite.Data;
using F1VacationSite.Data.Models;
using F1VacationSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace F1VacationSite.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly VacationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public ReservationController(VacationDbContext dbContext,
            UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = userManager
                .GetUserId(User);

            var reservations = await dbContext.Reservations
                .Include(r => r.Trip)
                .ThenInclude(t => t!.Race)
                .Include(r => r.Trip)
                .ThenInclude(t => t!.Hotel)
                .Where(r => r.UserId == userId)
                .AsNoTracking()
                .ToListAsync();

            return View(reservations);
        }

        [HttpGet]
        public async Task<IActionResult> Create(int tripId)
        {
            var trip = await dbContext.Trips
                .Include(t => t.Race)
                .Include(t => t.Hotel)
                .FirstOrDefaultAsync(t => t.Id == tripId);

            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        [HttpPost]
        public async Task<IActionResult> Create(int tripId, string? specialRequest)
        {
            var userId = userManager
                .GetUserId(User);

            var trip = await dbContext.Trips
                .FindAsync(tripId);

            if (trip == null)
            {
                return NotFound();
            }

            var reservation = new Reservation
            {
                TripId = tripId,
                UserId = userId!,
                ReservationDate = DateTime.UtcNow,
                SpecialRequest = specialRequest
            };

            dbContext.Reservations.Add(reservation);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Cancel(int reservationId)
        {
            var userId = userManager
                .GetUserId(User);

            var reservation = await dbContext.Reservations
                .FirstOrDefaultAsync(r => r.Id == reservationId && r.UserId == userId);

            if (reservation == null)
            {
                return NotFound();
            }

            dbContext.Reservations.Remove(reservation);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

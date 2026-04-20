using F1VacationSite.Data.Models;
using F1VacationSite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace F1VacationSite.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly IReservationService reservationService;
        private readonly UserManager<ApplicationUser> userManager;

        public ReservationController(IReservationService reservationService,
            UserManager<ApplicationUser> userManager)
        {
            this.reservationService = reservationService;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = userManager
                .GetUserId(User);
            var reservations = await reservationService.GetUserReservationsAsync(userId!);

            return View(reservations);
        }

        [HttpGet]
        public async Task<IActionResult> Create(int tripId)
        {
            var trip = await reservationService.GetTripForReservationAsync(tripId);

            if (trip == null || trip.Race == null || trip.Hotel == null)
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

            await reservationService.CreateAsync(tripId, userId, specialRequest);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Cancel(int reservationId)
        {
            var userId = userManager
                .GetUserId(User);

            await reservationService.CancelAsync(reservationId, userId!);
            return RedirectToAction(nameof(Index));
        }
    }
}

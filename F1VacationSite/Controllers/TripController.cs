using F1VacationSite.Models;
using F1VacationSite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace F1VacationSite.Controllers
{
    public class TripsController : Controller
    {
        private readonly ITripService tripService;
        public TripsController(ITripService tripService)
        {
            this.tripService = tripService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var trips = await tripService.GetAllTripsAsync();

            return View(trips);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await PopulateSelectTripsAsync();
            return View(new Trip());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var trip = await tripService.GetTripByIdAsync(id);

            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var trip = await tripService.GetTripByIdAsync(id);

            if (trip == null)
                return NotFound();

            await PopulateSelectTripsAsync();
            return View(trip);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        { 
            var trip = await tripService.GetTripByIdAsync(id);
            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(Trip trip)
        {
            if (!ModelState.IsValid)
            {
                await PopulateSelectTripsAsync();
                return View(trip);
            }

            await tripService.CreateTripAsync(trip);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Trip trip)
        {
             if(id != trip.Id)
            {
                return NotFound();
            }

             if(!ModelState.IsValid)
            {
                await PopulateSelectTripsAsync();
                return View(trip);
            }

            await tripService.UpdateTripAsync(trip);
            return RedirectToAction(nameof(Index));
        }



        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await tripService.DeleteTripAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateSelectTripsAsync()
        {
            var races = (await tripService.GetAllRacesAsync()).ToList();

            races.Insert(0, new Race { Id = 0, Name = "-- Select Race --" });

            var hotels = (await tripService.GetAllHotelsAsync()).ToList();

            hotels.Insert(0, new Hotel { Id = 0, Name = "-- Select Hotel --" });

            ViewData["Races"] = new SelectList(races, "Id", "Name");
            ViewData["Hotels"] = new SelectList(hotels, "Id", "Name");
        }
    }
}


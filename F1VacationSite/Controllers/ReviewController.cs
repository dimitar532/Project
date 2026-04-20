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
    public class ReviewController : Controller
    {
        private readonly VacationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public ReviewController(VacationDbContext dbContext,
            UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Create(int tripId, int rating, string ?comment)
        {
            var userId = userManager
                .GetUserId(User);

            var existing = await dbContext.Reviews
                .Where(r => r.TripId == tripId && r.UserId == userId)
                .FirstOrDefaultAsync();


            if (existing == null)
            {
                var review = new Review
                {
                    TripId = tripId,
                    UserId = userId,
                    Rating = rating,
                    Comment = comment,
                    CreatedOn = DateTime.UtcNow
                };

                dbContext.Reviews.Add(review);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("Details", "Trips", new { id = tripId });
        }
    }
}

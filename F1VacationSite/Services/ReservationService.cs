using F1VacationSite.Data;
using F1VacationSite.Models;
using Microsoft.EntityFrameworkCore;

namespace F1VacationSite.Services
{
    public class ReservationService : IReservationService
    {
        private readonly VacationDbContext dbContext;

        public ReservationService(VacationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(int tripId, string userId, string? specialRequest)
        {
            var reservation = new Reservation
            {
                TripId = tripId,
                UserId = userId,
                ReservationDate = DateTime.UtcNow,
                SpecialRequest = specialRequest
            }; 
            
            dbContext.Reservations.Add(reservation);
            await dbContext.SaveChangesAsync();
        }

        public async Task CancelAsync(int reservationId, string userId)
        {
            var reservation = await dbContext.Reservations
                .FirstOrDefaultAsync(r => r.Id == reservationId && r.UserId == userId);

            if (reservation != null)
            {
                dbContext.Reservations.Remove(reservation);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<Trip?> GetTripForReservationAsync(int tripId)
        {
            return await dbContext.Trips
                .Include(t => t.Race)
                .Include(t => t.Hotel)
                .FirstOrDefaultAsync(t => t.Id == tripId);
        }

        public async Task<IEnumerable<Reservation>> GetUserReservationsAsync(string userId)
        {
            return await dbContext.Reservations
                .Include(r => r.Trip)
                .ThenInclude(t => t!.Race)
                .Include(r => r.Trip)
                .ThenInclude(t => t!.Hotel)
                .Where(r => r.UserId == userId)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}

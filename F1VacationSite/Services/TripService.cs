using F1VacationSite.Data;
using F1VacationSite.Models;
using Microsoft.EntityFrameworkCore;

namespace F1VacationSite.Services
{
    public class TripService : ITripService
    {
        private readonly VacationDbContext dbContext;

        public TripService(VacationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateTripAsync(Trip trip)
        {
            dbContext.Trips.Add(trip);
            await dbContext.SaveChangesAsync();
        }

        public async  Task DeleteTripAsync(int id)
        {
            var trip = await dbContext.Trips.FindAsync(id);

            if(trip != null)
            {
                dbContext.Trips.Remove(trip);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Hotel>> GetAllHotelsAsync()
        {
            return await dbContext
                .Hotels
                .AsNoTracking()
                .OrderBy(h => h.Name)
                .ToListAsync();
        }

        public async Task<IEnumerable<Race>> GetAllRacesAsync()
        {
            return await dbContext
                .Races
                .AsNoTracking()
                .OrderBy(r => r.StartDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Trip>> GetAllTripsAsync()
        {
            return await dbContext
                .Trips
                .Include(t => t.Race)
                .Include(t => t.Hotel) 
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Trip?> GetTripByIdAsync(int id)
        {
            return await dbContext
                .Trips
                .Include(t => t.Race)
                .Include(t => t.Hotel)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Trip>> GetTripsByRaceIdAsync(int raceId)
        {
            return await dbContext
                .Trips
                .Include(t => t.Race)
                .Include(t => t.Hotel)
                .OrderBy(t => t.Price)
                .Take(raceId)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task UpdateTripAsync(Trip trip)
        {
            dbContext.Trips.Update(trip);
            await dbContext.SaveChangesAsync();
        }
    }
}

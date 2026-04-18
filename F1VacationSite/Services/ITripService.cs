using F1VacationSite.Models;

namespace F1VacationSite.Services
{
    public interface ITripService
    {
        Task<IEnumerable<Trip>> GetAllTripsAsync();
        Task<Trip?> GetTripByIdAsync(int id);
        Task<IEnumerable<Trip>> GetFeaturedTripsAsync(int count);
        Task<IEnumerable<Trip>> GetTripsByRaceIdAsync(int raceId);
        Task CreateTripAsync(Trip trip);
        Task UpdateTripAsync(Trip trip);
        Task DeleteTripAsync(int id);
        Task<IEnumerable<Race>> GetAllRacesAsync();
        Task<IEnumerable<Hotel>> GetAllHotelsAsync();
    }
}

using F1VacationSite.Models;

namespace F1VacationSite.Services
{
    public interface IReservationService
    {
        Task<IEnumerable<Reservation>> GetUserReservationsAsync(string userId);
        Task<Trip?> GetTripForReservationAsync(int tripId);
        Task CreateAsync(int tripId, string userId, string? specialRequest);
        Task CancelAsync(int reservationId, string userId);
    }
}

using F1VacationSite.Models;
using Microsoft.AspNetCore.Identity;

namespace F1VacationSite.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    } 
}

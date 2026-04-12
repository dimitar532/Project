using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using F1VacationSite.Data.Models;

namespace F1VacationSite.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Trip))]
        public int TripId { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public DateTime ReservationDate { get; set; }

        [StringLength(500)]
        public string? SpecialRequest { get; set; }

        public virtual Trip? Trip { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser? User { get; set; }
    }
}

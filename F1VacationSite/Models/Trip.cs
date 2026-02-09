using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1VacationSite.Models
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Race))]
        public string RaceId { get; set; }

        [Required]
        public string HotelId { get; set; }

        [Required]
        [Range(100, 10000)]
        public double Price { get; set; }

        [Required]
        [Range(1, 5)]
        public int Nights { get; set; }
    }
}

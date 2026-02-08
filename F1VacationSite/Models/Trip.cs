using System.ComponentModel.DataAnnotations;

namespace F1VacationSite.Models
{
    public class Trip
    {
        
        public int Id { get; set; }

        [Required]
        public string RaceId { get; set; }

        [Required]
        public string HotelId { get; set; }

        [Required]
        [Range(100, 10000)]
        public decimal Price { get; set; }

        [Required]
        [Range(1, 5)]
        public int Nights { get; set; }
    }
}

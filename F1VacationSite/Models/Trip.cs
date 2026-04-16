using F1VacationSite.Constants;
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
        public int RaceId { get; set; }

        [Required]
        [ForeignKey(nameof(Hotel))]
        public int HotelId { get; set; }

        [Required]
        [Range(TripConstants.PriceMin, TripConstants.PriceMax)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        [Range(TripConstants.NightsMin, TripConstants.NightsMax)]
        public int Nights { get; set; }

        public virtual Race? Race { get; set; } = null!;
        public virtual Hotel? Hotel { get; set; } = null!;

        public string? ImageUrl { get; set; }
    }
}

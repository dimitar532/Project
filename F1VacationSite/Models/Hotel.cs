using F1VacationSite.Constants;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace F1VacationSite.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(HotelConstants.NameMaxLength, MinimumLength = HotelConstants.NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(HotelConstants.CityMaxLength)]
        public string City { get; set; } = null!;

        [Required]
        [Range(HotelConstants.StarsMin, HotelConstants.StarsMax)]
        public int Stars { get; set; }

        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}

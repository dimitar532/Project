using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace F1VacationSite.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string City { get; set; } = null!;

        [Required]
        [Range(1, 5)]
        public int Stars { get; set; }

        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}

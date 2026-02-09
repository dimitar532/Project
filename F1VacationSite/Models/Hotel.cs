using System.ComponentModel.DataAnnotations;

namespace F1VacationSite.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Range(1, 5)]
        public int Stars { get; set; }

        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}

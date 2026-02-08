using System.ComponentModel.DataAnnotations;

namespace F1VacationSite.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Range(1, 5)]
        public decimal Stars { get; set; }

        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}

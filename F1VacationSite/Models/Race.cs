using System.ComponentModel.DataAnnotations;

namespace F1VacationSite.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Circuit { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace F1VacationSite.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(100)]
        public string? Circuit { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}

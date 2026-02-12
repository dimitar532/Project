using System;
using F1VacationSite.Models;
using Microsoft.EntityFrameworkCore;

namespace F1VacationSite.Data
{
    public class VacationDbContext : DbContext
    {
        public VacationDbContext(DbContextOptions<VacationDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; } = null!;
        public DbSet<Race> Races { get; set; } = null!;
        public DbSet<Hotel> Hotels { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(VacationDbContext).Assembly);

            modelBuilder.Entity<Race>().HasData(
                new Race
                {
                    Id = 1,
                    Name = "Australian Grand Prix",
                    Circuit = "Albert Park",
                    Country = "Australia",
                    StartDate = new DateTime(2026, 3, 20),
                    EndDate = new DateTime(2026, 3, 22)
                },
                new Race
                {
                    Id = 2,
                    Name = "Monaco Grand Prix",
                    Circuit = "Monte Carlo",
                    Country = "Monaco",
                    StartDate = new DateTime(2026, 5, 23),
                    EndDate = new DateTime(2026, 5, 25)
                },
                new Race
                {
                    Id = 3,
                    Name = "British Grand Prix",
                    Circuit = "Silverstone",
                    Country = "United Kingdom",
                    StartDate = new DateTime(2026, 7, 10),
                    EndDate = new DateTime(2026, 7, 12)
                },
                new Race
                {
                    Id = 4,
                    Name = "Italian Grand Prix",
                    Circuit = "Monza",
                    Country = "Italy",
                    StartDate = new DateTime(2026, 9, 5),
                    EndDate = new DateTime(2026, 9, 7)
                },
                new Race
                {
                    Id = 5,
                    Name = "Belgian Grand Prix",
                    Circuit = "Spa-Francorchamps",
                    Country = "Belgium",
                    StartDate = new DateTime(2026, 8, 28),
                    EndDate = new DateTime(2026, 8, 30)
                },
                new Race
                {
                    Id = 6,
                    Name = "United States Grand Prix",
                    Circuit = "Circuit of The Americas",
                    Country = "United States",
                    StartDate = new DateTime(2026, 10, 23),
                    EndDate = new DateTime(2026, 10, 25)
                },
                new Race
                {
                    Id = 7,
                    Name = "Japanese Grand Prix",
                    Circuit = "Suzuka",
                    Country = "Japan",
                    StartDate = new DateTime(2026, 10, 9),
                    EndDate = new DateTime(2026, 10, 11)
                },
                new Race
                {
                    Id = 8,
                    Name = "Canadian Grand Prix",
                    Circuit = "Circuit Gilles Villeneuve",
                    Country = "Canada",
                    StartDate = new DateTime(2026, 6, 12),
                    EndDate = new DateTime(2026, 6, 14)
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Albert Park Hotel",
                    City = "Melbourne",
                    Stars = 4
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Monte Carlo Palace",
                    City = "Monte Carlo",
                    Stars = 5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Silverstone Inn",
                    City = "Towcester",
                    Stars = 3
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Hotel Monza",
                    City = "Monza",
                    Stars = 4
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Spa Resort",
                    City = "Stavelot",
                    Stars = 4
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Austin Grand Hotel",
                    City = "Austin",
                    Stars = 4
                },
                new Hotel
                {
                    Id = 7,
                    Name = "Suzuka Hotel & Suites",
                    City = "Suzuka",
                    Stars = 4
                },
                new Hotel
                {
                    Id = 8,
                    Name = "Gilles Village Hotel",
                    City = "Montreal",
                    Stars = 3
                }
            );
        }
    }
}

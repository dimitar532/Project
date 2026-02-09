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
        public DbSet<Race> Rasec { get; set; } = null!;
        public DbSet<Hotel> Hotels { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(VacationDbContext).Assembly);
        }
    }
}

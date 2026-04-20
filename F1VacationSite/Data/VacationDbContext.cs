using F1VacationSite.Data.Models;
using F1VacationSite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace F1VacationSite.Data
{
    public class VacationDbContext : IdentityDbContext<ApplicationUser>
    {
        public VacationDbContext(DbContextOptions<VacationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; } = null!;
        public DbSet<Race> Races { get; set; } = null!;
        public DbSet<Hotel> Hotels { get; set; } = null!;

        public DbSet<Review> Reviews { get; set; } = null!;

        public DbSet<Reservation> Reservations { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(VacationDbContext).Assembly);

            modelBuilder.Entity<Race>().HasData(
                new Race { Id = 1, Name = "Bahrain Grand Prix", Circuit = "Bahrain International Circuit", Country = "Bahrain", StartDate = new DateTime(2026, 3, 1), EndDate = new DateTime(2026, 3, 3) },
                new Race { Id = 2, Name = "Saudi Arabian Grand Prix", Circuit = "Jeddah Corniche Circuit", Country = "Saudi Arabia", StartDate = new DateTime(2026, 3, 8), EndDate = new DateTime(2026, 3, 10) },
                new Race { Id = 3, Name = "Australian Grand Prix", Circuit = "Albert Park", Country = "Australia", StartDate = new DateTime(2026, 3, 22), EndDate = new DateTime(2026, 3, 24) },
                new Race { Id = 4, Name = "Azerbaijan Grand Prix", Circuit = "Baku City Circuit", Country = "Azerbaijan", StartDate = new DateTime(2026, 4, 5), EndDate = new DateTime(2026, 4, 7) },
                new Race { Id = 5, Name = "Miami Grand Prix", Circuit = "Miami International Autodrome", Country = "United States", StartDate = new DateTime(2026, 5, 3), EndDate = new DateTime(2026, 5, 5) },
                new Race { Id = 6, Name = "Emilia Romagna Grand Prix", Circuit = "Imola", Country = "Italy", StartDate = new DateTime(2026, 5, 17), EndDate = new DateTime(2026, 5, 19) },
                new Race { Id = 7, Name = "Monaco Grand Prix", Circuit = "Monte Carlo", Country = "Monaco", StartDate = new DateTime(2026, 5, 23), EndDate = new DateTime(2026, 5, 25) },
                new Race { Id = 8, Name = "Spanish Grand Prix", Circuit = "Circuit de Barcelona-Catalunya", Country = "Spain", StartDate = new DateTime(2026, 6, 7), EndDate = new DateTime(2026, 6, 9) },
                new Race { Id = 9, Name = "Canadian Grand Prix", Circuit = "Circuit Gilles Villeneuve", Country = "Canada", StartDate = new DateTime(2026, 6, 14), EndDate = new DateTime(2026, 6, 16) },
                new Race { Id = 10, Name = "Austrian Grand Prix", Circuit = "Red Bull Ring", Country = "Austria", StartDate = new DateTime(2026, 6, 21), EndDate = new DateTime(2026, 6, 23) },
                new Race { Id = 11, Name = "British Grand Prix", Circuit = "Silverstone", Country = "United Kingdom", StartDate = new DateTime(2026, 7, 5), EndDate = new DateTime(2026, 7, 7) },
                new Race { Id = 12, Name = "Hungarian Grand Prix", Circuit = "Hungaroring", Country = "Hungary", StartDate = new DateTime(2026, 7, 19), EndDate = new DateTime(2026, 7, 21) },
                new Race { Id = 13, Name = "Belgian Grand Prix", Circuit = "Spa-Francorchamps", Country = "Belgium", StartDate = new DateTime(2026, 8, 30), EndDate = new DateTime(2026, 9, 1) },
                new Race { Id = 14, Name = "Dutch Grand Prix", Circuit = "Zandvoort", Country = "Netherlands", StartDate = new DateTime(2026, 9, 6), EndDate = new DateTime(2026, 9, 8) },
                new Race { Id = 15, Name = "Italian Grand Prix", Circuit = "Monza", Country = "Italy", StartDate = new DateTime(2026, 9, 13), EndDate = new DateTime(2026, 9, 15) },
                new Race { Id = 16, Name = "Singapore Grand Prix", Circuit = "Marina Bay Street Circuit", Country = "Singapore", StartDate = new DateTime(2026, 9, 20), EndDate = new DateTime(2026, 9, 22) },
                new Race { Id = 17, Name = "Japanese Grand Prix", Circuit = "Suzuka", Country = "Japan", StartDate = new DateTime(2026, 10, 4), EndDate = new DateTime(2026, 10, 6) },
                new Race { Id = 18, Name = "United States Grand Prix", Circuit = "Circuit of The Americas", Country = "United States", StartDate = new DateTime(2026, 10, 18), EndDate = new DateTime(2026, 10, 20) },
                new Race { Id = 19, Name = "Mexico City Grand Prix", Circuit = "Autódromo Hermanos Rodríguez", Country = "Mexico", StartDate = new DateTime(2026, 10, 25), EndDate = new DateTime(2026, 10, 27) },
                new Race { Id = 20, Name = "Brazilian Grand Prix", Circuit = "Interlagos", Country = "Brazil", StartDate = new DateTime(2026, 11, 1), EndDate = new DateTime(2026, 11, 3) },
                new Race { Id = 21, Name = "Las Vegas Grand Prix", Circuit = "Las Vegas Street Circuit", Country = "United States", StartDate = new DateTime(2026, 11, 21), EndDate = new DateTime(2026, 11, 23) },
                new Race { Id = 22, Name = "Abu Dhabi Grand Prix", Circuit = "Yas Marina Circuit", Country = "United Arab Emirates", StartDate = new DateTime(2026, 11, 28), EndDate = new DateTime(2026, 11, 30) }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Crown Towers Melbourne", City = "Melbourne", Stars = 5 },
                new Hotel { Id = 2, Name = "The Ritz-Carlton Shanghai", City = "Shanghai", Stars = 5 },
                new Hotel { Id = 3, Name = "Suzuka Circuit Hotel", City = "Suzuka", Stars = 4 },
                new Hotel { Id = 4, Name = "1 Hotel South Beach", City = "Miami", Stars = 5 },
                new Hotel { Id = 5, Name = "Fairmont The Queen Elizabeth", City = "Montreal", Stars = 4 },
                new Hotel { Id = 6, Name = "Hotel de Paris Monte-Carlo", City = "Monte Carlo", Stars = 5 },
                new Hotel { Id = 7, Name = "Hotel Arts Barcelona", City = "Barcelona", Stars = 5 },
                new Hotel { Id = 8, Name = "Falkensteiner Hotel Schladming", City = "Spielberg", Stars = 4 },
                new Hotel { Id = 9, Name = "Whittlebury Hall Hotel", City = "Towcester", Stars = 4 },
                new Hotel { Id = 10, Name = "Radisson Blu Palace Hotel Spa", City = "Spa", Stars = 4 },
                new Hotel { Id = 11, Name = "Kempinski Hotel Corvinus", City = "Budapest", Stars = 5 },
                new Hotel { Id = 12, Name = "NH Zandvoort", City = "Zandvoort", Stars = 4 },
                new Hotel { Id = 13, Name = "Hotel de la Ville Monza", City = "Monza", Stars = 5 },
                new Hotel { Id = 14, Name = "Gran Melia Palacio de los Duques", City = "Madrid", Stars = 5 },
                new Hotel { Id = 15, Name = "Four Seasons Hotel Baku", City = "Baku", Stars = 5 },
                new Hotel { Id = 16, Name = "Marina Bay Sands", City = "Singapore", Stars = 5 },
                new Hotel { Id = 17, Name = "JW Marriott Austin", City = "Austin", Stars = 4 },
                new Hotel { Id = 18, Name = "Four Seasons Mexico City", City = "Mexico City", Stars = 5 },
                new Hotel { Id = 19, Name = "Hotel Unique Sao Paulo", City = "Sao Paulo", Stars = 5 },
                new Hotel { Id = 20, Name = "The Venetian Las Vegas", City = "Las Vegas", Stars = 5 },
                new Hotel { Id = 21, Name = "The Ned Doha", City = "Doha", Stars = 5 },
                new Hotel { Id = 22, Name = "Emirates Palace Abu Dhabi", City = "Abu Dhabi", Stars = 5 }
            );

            modelBuilder.Entity<Trip>().HasData(
                new Trip { Id = 1, RaceId = 3,  HotelId = 1,  Price = 3200m, Nights = 5, Description = "Пакетът включва престой в сърцето на Мелбърн с директен изглед към Albert Park. Идеален за феновете, търсещи комфорт и близост до пистата." },
                new Trip { Id = 2, RaceId = 7,  HotelId = 6,  Price = 4800m, Nights = 5, Description = "Петзвездно изживяване в легендарното Monte Carlo. Хотелът се намира на метри от пистата — усети магията на Monaco GP от първа ръка." },
                new Trip { Id = 3, RaceId = 5,  HotelId = 4,  Price = 3500m, Nights = 4, Description = "Miami GP с престой в един от най-стилните хотели на South Beach. Съчетай Формула 1 с плажния живот на Маями." },
                new Trip { Id = 4, RaceId = 16, HotelId = 16, Price = 3800m, Nights = 4, Description = "Singapore GP е единственото нощно състезание в календара. Marina Bay Sands предлага невероятна гледка към градските светлини и пистата." },
                new Trip { Id = 5, RaceId = 11, HotelId = 9,  Price = 2700m, Nights = 5, Description = "British GP в Silverstone е едно от най-емблематичните събития в спорта. Whittlebury Hall е само минути от пистата сред английската провинция." },
                new Trip { Id = 6, RaceId = 15, HotelId = 13, Price = 2500m, Nights = 4, Description = "Italian GP в Monza — домът на тифозите. Почувствай страстта на италианските фенове сред историческия парк." },
                new Trip { Id = 7, RaceId = 21, HotelId = 20, Price = 4200m, Nights = 4, Description = "Las Vegas GP е най-екстравагантното събитие в календара. The Venetian предлага луксозно изживяване в центъра на Strip-а." },
                new Trip { Id = 8, RaceId = 4,  HotelId = 15, Price = 2900m, Nights = 4, Description = "Azerbaijan GP на улиците на Баку е едно от най-непредсказуемите състезания. Four Seasons е само на крачка от пистата." },
                new Trip { Id = 9, RaceId = 12, HotelId = 11, Price = 2300m, Nights = 4, Description = "Hungarian GP в Будапеща съчетава страхотно състезание с богата култура. Kempinski е в самия център на столицата." },
                new Trip { Id = 10, RaceId = 22, HotelId = 22, Price = 3600m, Nights = 5, Description = "Финалното състезание на сезона в Abu Dhabi е незабравимо. Emirates Palace е един от най-луксозните хотели в света." },
                new Trip { Id = 11, RaceId = 8,  HotelId = 7,  Price = 2100m, Nights = 4, Description = "Spanish GP в Барселона е класика от Формула 1 календара. Hotel Arts предлага панорамна гледка към Средиземно море." },
                new Trip { Id = 12, RaceId = 17, HotelId = 3,  Price = 2800m, Nights = 5, Description = "Japanese GP в Suzuka е любимото на истинските фенове. Suzuka Circuit Hotel е буквално в рамките на пистата." },
                new Trip { Id = 13, RaceId = 13, HotelId = 10, Price = 2000m, Nights = 4, Description = "Belgian GP в Spa-Francorchamps е едно от най-красивите и предизвикателни трасета в света. Radisson Blu е в сърцето на Spa." },
                new Trip { Id = 14, RaceId = 9,  HotelId = 5,  Price = 2600m, Nights = 5, Description = "Canadian GP в Монреал съчетава вълнуващо състезание с космополитния чар на града. Fairmont Queen Elizabeth е иконата на Монреал." }
            );
        }
    }
}

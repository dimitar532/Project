using F1VacationSite.Data;
using F1VacationSite.Models;
using F1VacationSite.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace F1VacationSite.Tests
{
    public class TripServiceTests
    {
        private VacationDbContext CreateInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<VacationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new VacationDbContext(options);
        }

        private List<Trip> GetSampleTrips()
        {
            var race = new Race { Id = 1, Name = "Monaco Grand Prix", Circuit = "Monte Carlo", Country = "Monaco", StartDate = new DateTime(2026, 5, 23), EndDate = new DateTime(2026, 5, 25) };
            var hotel = new Hotel { Id = 1, Name = "Hotel de Paris", City = "Monaco", Stars = 5 };

            return new List<Trip>
            {
                new Trip { Id = 1, RaceId = 1 , HotelId = 1, Price = 4800m, Nights = 5,  Race = race, Hotel = hotel },
                new Trip { Id = 2, RaceId = 1, HotelId = 1, Price = 2100m, Nights = 3, Race = race, Hotel = hotel },
                new Trip { Id = 3, RaceId = 1, HotelId = 1, Price = 3200m, Nights = 4, Race = race, Hotel = hotel }
            };
        }

        [Fact]
        public async Task GetAllTripsAsync_ReturnsAllTrips()
        {

            var context = CreateInMemoryContext();
            var trips = GetSampleTrips();

            context.Trips.AddRange(trips);

            await context.SaveChangesAsync();

            var tripService = new TripService(context);
            var result = await tripService.GetAllTripsAsync();

            Assert.Equal(3, result.Count());
        }

        [Fact]
        public async Task GetTripsByIdAsync_ExistingId_ReturnsTrip()
        {
            var context = CreateInMemoryContext();
            context.Trips.AddRange(GetSampleTrips());

            await context.SaveChangesAsync();

            var service = new TripService(context);
            var result = await service.GetTripByIdAsync(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public async Task GetTripsByIdAsync_NonExistingId_ReturnsNull()
        {
            var context = CreateInMemoryContext();
            var service = new TripService(context);

            var result = await service.GetTripByIdAsync(999);

            Assert.Null(result);
        }

        [Fact]
        public async Task GetFeaturedTripAsync_RetturnsCorrectCount()
        {
            var context = CreateInMemoryContext();
            context.Trips.AddRange(GetSampleTrips());

            await context.SaveChangesAsync();

            var service = new TripService(context);
            var result = await service.GetFeaturedTripsAsync(2);

            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetFeaturedTripsAsync_ReturnsCheapestFirst()
        {
            var context = CreateInMemoryContext();
            context.Trips.AddRange(GetSampleTrips());

            await context.SaveChangesAsync();

            var service = new TripService(context);
            var result = (await service.GetFeaturedTripsAsync(3)).ToList();

            Assert.Equal(2100m, result[0].Price);
        }

        [Fact]
        public async Task CreateTripAsync_AddsTrip()
        {
            var context = CreateInMemoryContext();
            var service = new TripService(context);

            var newTrip = new Trip { Id = 10, RaceId = 1, HotelId = 1, Price = 1500m, Nights = 3 };

            await service.CreateTripAsync(newTrip);

            Assert.Equal(1, context.Trips.Count());
        }

        [Fact]
        public async Task UpdateTripAsync_UpdatesPrice()
        {
            var context = CreateInMemoryContext();
            var trip = GetSampleTrips().First();
            context.Trips.Add(trip);
            await context.SaveChangesAsync();

            var service = new TripService(context);
            trip.Price = 2000m;
            await service.UpdateTripAsync(trip);

            var updatedTrip = await context.Trips.FindAsync(trip.Id);
            Assert.Equal(2000m, updatedTrip!.Price);
        }
        [Fact]
        public async Task DeleteTripAsync_RemovesTrip()
        {
            var context = CreateInMemoryContext();
            context.Trips.AddRange(GetSampleTrips());

            await context.SaveChangesAsync();

            var service = new TripService(context);
            await service.DeleteTripAsync(1);

            Assert.Equal(2, context.Trips.Count());
        }

        [Fact]
        public async Task DeleteTripAsync_NonExistingId_DoesNotThrow()
        {
            var context = CreateInMemoryContext();
            var service = new TripService(context);

            var exception = await Record.ExceptionAsync(() => service.DeleteTripAsync(999));

            Assert.Null(exception);
        }

        [Fact]
        public async Task GetTripsByRaceIdAsync_ReturnsCorrectTrips()
        {
            var context = CreateInMemoryContext();
            var race1 = new Race { Id = 1, Name = "Monaco GP", Circuit = "Monte Carlo", Country = "Monaco", StartDate = new DateTime(2026, 5, 23), EndDate = new DateTime(2026, 5, 25) };
            var race2 = new Race { Id = 2, Name = "British GP", Circuit = "Silverstone", Country = "United Kingom", StartDate = new DateTime(2026, 7, 5), EndDate = new DateTime(2026, 7, 7) };
            var hotel = new Hotel { Id = 1, Name = "Hotel de Paris", City = "Monte Carlo", Stars = 5 };
            context.Races.AddRange(race1, race2);
            context.Hotels.Add(hotel);
            context.Trips.AddRange(
                new Trip { Id = 1, RaceId = 1, HotelId = 1, Price = 1000m, Nights = 3 },
                new Trip { Id = 2, RaceId = 2, HotelId = 1, Price = 2000m, Nights = 4 },
                new Trip { Id = 3, RaceId = 1, HotelId = 1, Price = 3000m, Nights = 5 }
                );

            await context.SaveChangesAsync();

            var service = new TripService(context);
            var result = await service.GetTripsByRaceIdAsync(1);

            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetAllRacesAsync_ReturnsAllRaces()
        {
            var context = CreateInMemoryContext();
            context.Races.AddRange(
                new Race { Id = 1, Name = "Monaco GP", Circuit = "Monte Carlo", Country = "Monaco", StartDate = new DateTime(2026, 5, 23), EndDate = new DateTime(2026, 5, 25) },
                new Race { Id = 2, Name = "British GP", Circuit = "Silverstone", Country = "UK", StartDate = new DateTime(2026, 7, 5), EndDate = new DateTime(2026, 7, 7) }
                );

            await context.SaveChangesAsync();

            var service = new TripService(context);
            var result = await service.GetAllRacesAsync();

            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetAllHotelsAsync_ReturnsAllHotels()
        {
            var context = CreateInMemoryContext();
            context.Hotels.AddRange(
                new Hotel { Id = 1, Name = "Hotel de Paris", City = "Monaco", Stars = 5 },
                new Hotel { Id = 2, Name = "The Ritz London", City = "London", Stars = 5 }
                );

            await context.SaveChangesAsync();

            var service = new TripService(context);
            var result = await service.GetAllHotelsAsync();

            Assert.Equal(2, result.Count());
        }
    }
}

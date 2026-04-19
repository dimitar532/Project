using F1VacationSite.Data;
using F1VacationSite.Models;
using F1VacationSite.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace F1VacationSite.Tests
{
    public class ReservationServiceTests
    {
        private VacationDbContext CreateInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<VacationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new VacationDbContext(options);
        }

        private void SeedData(VacationDbContext context)
        {
            var race = new Race { Id = 1, Name = "Monaco GP", Circuit = "Monte Carlo", Country = "Monaco", StartDate = new DateTime(2026, 5, 23), EndDate = new DateTime(2026, 5, 25) };
            var hotel = new Hotel { Id = 1, Name = "Hotel de Paris", City = "Monte Carlo", Stars = 5 };
            var trip = new Trip { Id = 1, RaceId = 1, HotelId = 1, Price = 4800m, Nights = 5 };

            context.Races.Add(race);
            context.Hotels.Add(hotel);
            context.Trips.Add(trip);
            context.SaveChanges();
        }

        [Fact]
        public async Task GetUserReservationsAsync_ReturnsReservationsForUser()
        {
            var context = CreateInMemoryContext();
            SeedData(context);

            context.Reservations.AddRange(
                new Reservation { Id = 1, TripId = 1, UserId = "user1", ReservationDate = DateTime.UtcNow },
                new Reservation { Id = 2, TripId = 1, UserId = "user2", ReservationDate = DateTime.UtcNow },
                new Reservation { Id = 3, TripId = 1, UserId = "user1", ReservationDate = DateTime.UtcNow }
            );

            await context.SaveChangesAsync();

            var service = new ReservationService(context);
            var result = await service.GetUserReservationsAsync("user1");

            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetUserReservationsAsync_UnknownUser_ReturnsEmpty()
        {
            var context = CreateInMemoryContext();
            SeedData(context);

            var service = new ReservationService(context);
            var result = await service.GetUserReservationsAsync("unknown");

            Assert.Empty(result);
        }

        [Fact]
        public async Task GetTripForReservationAsync_ExistingTrip_ReturnsTrip()
        {
            var context = CreateInMemoryContext();
            SeedData(context);

            var service = new ReservationService(context);
            var result = await service.GetTripForReservationAsync(1);

            Assert.NotNull(result);
            Assert.Equal(1, result!.Id);
        }

        [Fact]
        public async Task GetTripForReservationAsync_NonExistingTrip_ReturnsNull()
        {
            var context = CreateInMemoryContext();
            var service = new ReservationService(context);
            var result = await service.GetTripForReservationAsync(999);

            Assert.Null(result);
        }

        [Fact]
        public async Task CreateAsync_AddsReservation()
        {
            var context = CreateInMemoryContext();
            SeedData(context);

            var service = new ReservationService(context);
            await service.CreateAsync(1, "user1", "No special requests");

            Assert.Equal(1, await context.Reservations.CountAsync());
        }

        [Fact]
        public async Task CreateAsync_SetsCorrectUserId()
        {
            var context = CreateInMemoryContext();
            SeedData(context);

            var service = new ReservationService(context);
            await service.CreateAsync(1, "user1", null);

            var reservation = await context.Reservations.FirstAsync();

            Assert.Equal("user1", reservation.UserId);
        }

        [Fact]
        public async Task CancelAsync_RemovesReservation()
        {
            var context = CreateInMemoryContext();
            SeedData(context);

            context.Reservations.Add(new Reservation { Id = 1, TripId = 1, UserId = "user1", ReservationDate = DateTime.UtcNow });
            await context.SaveChangesAsync();

            var service = new ReservationService(context);
            await service.CancelAsync(1, "user1");

            Assert.Equal(0, context.Reservations.Count());
        }

        [Fact]
        public async Task CancelAsync_WrongUser_DoesNotRemove()
        {
            var context = CreateInMemoryContext();
            SeedData(context);

            context.Reservations.Add(new Reservation { Id = 1, TripId = 1, UserId = "user1", ReservationDate = DateTime.UtcNow });
            await context.SaveChangesAsync();

            var service = new ReservationService(context);
            await service.CancelAsync(1, "user2");

            Assert.Equal(1, context.Reservations.Count());
        }
    }
}

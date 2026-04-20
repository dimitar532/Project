# F1 Vacations 🏎️

ASP.NET Core MVC web application for booking Formula 1 vacation packages across all 22 races of the 2026 season.

## Admin Credentials

- **Email:** admin@f1vacations.com  
- **Password:** Admin123!

## Features

- Browse all 22 F1 Grand Prix vacation packages for the 2026 season
- Filter packages by region, number of nights and maximum price
- Detailed trip pages with hotel information and descriptions
- User reviews with star ratings for each trip
- User registration and login with ASP.NET Core Identity
- Make and cancel reservations
- Admin panel for managing trips
- Custom 404 and 500 error pages
- Partial views and sections used throughout

## Technologies

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core with SQL Server (Code First)
- ASP.NET Core Identity (User and Admin roles)
- Bootstrap 5
- JavaScript (client-side filtering and sorting)
- xUnit with InMemory Database for unit tests

## Architecture

The project follows a clean service layer pattern:

- **Controllers** — handle HTTP requests and return views
- **Services** — contain all business logic (`ITripService`, `IReservationService`)
- **Models** — database entities: Trip, Race, Hotel, Reservation, Review, ApplicationUser
- **ViewModels** — LoginViewModel, RegisterViewModel, ErrorViewModel
- **Constants** — validation constants for all entities
- **Areas** — Admin area for administration functionality

## Database Seeding

The database is automatically seeded on first run with:
- 22 Formula 1 races (complete 2026 season calendar)
- 44 hotels across all race locations (3 to 5 star options)
- 14 curated vacation packages with descriptions
- Admin user account

## Roles

- **User** — can browse trips, view details, leave reviews and make or cancel reservations
- **Admin** — full access to create, edit and delete trips; access to admin panel

## Unit Tests

20 unit tests covering the service layer:

- `TripServiceTests` — 12 tests covering GetAllTrips, GetById, GetFeatured, GetByRaceId, Create, Update, Delete
- `ReservationServiceTests` — 8 tests covering GetUserReservations, GetTripForReservation, Create, Cancel

All 20 tests pass using xUnit with InMemory database.

## Setup

1. Clone the repository
2. Update the connection string in `appsettings.json` under `DevSqlServer`
3. Run migrations: `dotnet ef database update`
4. Run the application — admin account is created automatically on first run

## Security

- CSRF protection with AntiForgeryToken on all forms
- Authorization with `[Authorize]` and role-based access `[Authorize(Roles = "Admin")]`
- Input validation both client-side and server-side
- Passwords hashed by ASP.NET Core Identity

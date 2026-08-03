using Microsoft.EntityFrameworkCore;
using OtelUygulamasi.Models;

namespace OtelUygulamasi.Data;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();
        context.Database.ExecuteSqlRaw(@"CREATE TABLE IF NOT EXISTS Users (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            UserName TEXT NOT NULL,
            Email TEXT NOT NULL,
            PasswordHash TEXT NOT NULL,
            Role TEXT NOT NULL
        );");
        if (!context.HotelRooms.Any())
        {
            var sampleRooms = new[]
            {
                new HotelRoom { Name = "Kral Dairesi (King Suite)", Occupancy = 2, RegularRate = 6800, ImageUrl = "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=800" },
                new HotelRoom { Name = "Panoramik Deniz Manzaralı", Occupancy = 3, RegularRate = 5200, ImageUrl = "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=800" },
                new HotelRoom { Name = "Aile Deluxe Oda", Occupancy = 4, RegularRate = 4300, ImageUrl = "https://images.unsplash.com/photo-1590490360182-c33d57733427?w=800" },
                new HotelRoom { Name = "Executive Çift Kişilik", Occupancy = 2, RegularRate = 3600, ImageUrl = "https://images.unsplash.com/photo-1542314831-068cd1dbfeeb?w=800" },
                new HotelRoom { Name = "Stüdyo Ekonomik Oda", Occupancy = 2, RegularRate = 2100, ImageUrl = "https://images.unsplash.com/photo-1505693416388-ac5ce068fe85?w=800" },
                new HotelRoom { Name = "Aile Süiti", Occupancy = 5, RegularRate = 5900, ImageUrl = "https://images.unsplash.com/photo-1560448204-e02f11c3d0e2?w=800" },
                new HotelRoom { Name = "Şehir Manzaralı Deluxe", Occupancy = 3, RegularRate = 4700, ImageUrl = "https://images.unsplash.com/photo-1494526585095-c41746248156?w=800" },
                new HotelRoom { Name = "Balayı Özel Süit", Occupancy = 2, RegularRate = 7200, ImageUrl = "https://images.unsplash.com/photo-1505693416388-ac5ce068fe85?w=800" },
                new HotelRoom { Name = "Premium Şehir Suiti", Occupancy = 4, RegularRate = 6400, ImageUrl = "https://images.unsplash.com/photo-1505693416388-ac5ce068fe85?w=800" },
                new HotelRoom { Name = "Garden Family Room", Occupancy = 4, RegularRate = 3500, ImageUrl = "https://images.unsplash.com/photo-1560448204-e02f11c3d0e2?w=800" }
            };

            context.HotelRooms.AddRange(sampleRooms);
        }

        if (!context.Users.Any())
        {
            var admin = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@otel.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("ritranks"),
                Role = "Admin"
            };
            context.Users.Add(admin);
        }

        // Ensure Bookings table has GuestsJson column (added after initial schema)
        try
        {
            context.Database.ExecuteSqlRaw("ALTER TABLE Bookings ADD COLUMN GuestsJson TEXT;");
        }
        catch
        {
            // ignore if column exists or operation not supported
        }

        context.SaveChanges();
    }
}

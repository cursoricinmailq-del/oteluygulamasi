using OtelUygulamasi.Models;

namespace OtelUygulamasi.Data;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        if (context.HotelRooms.Any())
            return; // Veritabanı doluysa işlem yapma

        var sampleRooms = new[]
        {
            new HotelRoom { Name = "Kral Dairesi (King Suite)", Occupancy = 2, RegularRate = 4500, ImageUrl = "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=600" },
            new HotelRoom { Name = "Panoramik Deniz Manzaralı", Occupancy = 3, RegularRate = 3200, ImageUrl = "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=600" },
            new HotelRoom { Name = "Aile Deluxe Oda", Occupancy = 4, RegularRate = 2800, ImageUrl = "https://images.unsplash.com/photo-1590490360182-c33d57733427?w=600" }
        };

        context.HotelRooms.AddRange(sampleRooms);
        context.SaveChanges();
    }
}
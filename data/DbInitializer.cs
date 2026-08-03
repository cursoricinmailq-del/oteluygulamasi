using Microsoft.EntityFrameworkCore;
using OtelUygulamasi.Models;

namespace OtelUygulamasi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<HotelRoom> HotelRooms { get; set; }
    public DbSet<RoomBooking> Bookings { get; set; } // Yeni Eklendi
}
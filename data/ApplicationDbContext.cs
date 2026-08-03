using Microsoft.EntityFrameworkCore;
using OtelUygulamasi.Models;

namespace OtelUygulamasi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<HotelRoom> HotelRooms { get; set; } = null!;
    public DbSet<RoomBooking> Bookings { get; set; } = null!;
    public DbSet<OtelUygulamasi.Models.ContactMessage> ContactMessages { get; set; } = null!;
}

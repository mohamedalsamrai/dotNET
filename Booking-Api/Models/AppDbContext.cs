using Microsoft.EntityFrameworkCore;

namespace Booking_Api.Models;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<HotelBooking> Bookings { get; set; }
}
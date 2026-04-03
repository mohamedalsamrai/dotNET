using Microsoft.EntityFrameworkCore;

namespace day_3.Models;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Item> Items { get; set; }
}
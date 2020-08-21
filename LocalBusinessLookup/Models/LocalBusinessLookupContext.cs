using Microsoft.EntityFrameworkCore;

namespace LocalBusinessLookup.Models
{
  public class LocalBusinessLookupContext : DbContext
  {
    public LocalBusinessLookupContext(DbContextOptions<LocalBusinessLookupContext> options)
      : base(options)
      {
      }

    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Shop> Shops { get; set; }
  }
}
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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Restaurant>()
          .HasData(
              new Restaurant { RestaurantId = 1, Name = "Newbergundian Bistro", Cuisine = "American(Traditional)", PhoneNumber = "971-832-8687", Address = "203 Villa Rd", City = "Newberg", State = "OR" },
              new Restaurant { RestaurantId = 2, Name = "Bangkok Noi Thai", Cuisine = "Thai, Food Tucks", PhoneNumber = "503-726-6067", Address = "910 E 1st St", City = "Newberg", State = "OR" },
              new Restaurant { RestaurantId = 3, Name = "Coffee Cottage", Cuisine = "Coffee & Tea, Bakeries", PhoneNumber = "503-538-5126", Address = "808 E Hancock St", City = "Newberg", State = "OR"  },
              new Restaurant { RestaurantId = 4, Name = "From Russia With Love", Cuisine = "Russian, Coffee & Tea", PhoneNumber = "971-832-8579", Address = "3777 Portland Rd", City = "Newberg", State = "OR"  },
              new Restaurant { RestaurantId = 5, Name = "Red Hills Market", Cuisine = "Sandwiches, Pizza", PhoneNumber = "971-832-8414", Address = "155 SW 7th St", City = "Dundee", State = "OR"  }
          );
        builder.Entity<Shop>()
          .HasData(
            new Shop{ ShopId = 1, Name = "Pulp & Circumstance", Category = "Cards & Stationery", PhoneNumber = "971-264-0563", Address = "117 S College St", City = "Newberg", State = "OR"},
            new Shop{ ShopId = 2, Name = "Nikki Jane's Boutique", Category = "Women's clothing", PhoneNumber = "503-538-2620", Address = "602 E 1st St", City = "Newberg", State = "OR"},
            new Shop{ ShopId = 3, Name = "Sleighbells Farm & Gift Shop", Category = "Gift Shops, Holiday Decorations", PhoneNumber = "503-625-6052", Address = "23855 SW 195th Pl", City = "Sherwood", State = "OR"},
            new Shop{ ShopId = 4, Name = "Unger's Trading Post", Category = "Antiques", PhoneNumber = "503-625-7834", Address = "22275 SW Pacific Hwy", City = "Sherwood", State = "OR"},
            new Shop{ ShopId = 5, Name = "Joy's Uptown Style", Category = "Women's Clothing", PhoneNumber = "503-223-3400", Address = "110 SW 7th St", City = "Dundee", State = "OR"}
          );
    }
  }
}
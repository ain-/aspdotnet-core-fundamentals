using Microsoft.EntityFrameworkCore;
using OdeToFood.Entities;

namespace OdeToFood.Entitities
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

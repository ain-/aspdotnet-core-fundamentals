using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Entities;
using System.Linq;

namespace OdeToFood.Entitities
{
    public class OdeToFoodDbContext : IdentityDbContext<User>
    {
        public OdeToFoodDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

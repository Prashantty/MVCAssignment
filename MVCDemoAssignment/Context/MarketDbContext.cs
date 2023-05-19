using Microsoft.EntityFrameworkCore;
using MVCDemoAssignment.Models;

namespace MVCDemoAssignment.Context
{
    public class MarketDbContext : DbContext
    {

        public MarketDbContext()
        {
            
        }

        public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options)
        {
            
        }

        public DbSet<Inventory> Inventory { get; set; } 

        public DbSet<Supplier> Suppliers { get; set; }  
    }
}

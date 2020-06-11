using DataAccessLayer.Models;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new CustomInitialiser());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}

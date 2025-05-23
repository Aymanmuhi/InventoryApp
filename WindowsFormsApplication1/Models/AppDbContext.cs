using System.Data.Entity;

namespace InventoryApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=DefaultConnection") { }

        public DbSet<Category> Categories { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;
using InventoryApp.Models;

namespace InventoryApp.Services
{
    public class ProductsService
    {
        private AppDbContext _context = new AppDbContext();
        public List<Product> GetAll() => _context.Products.ToList();
        public void Add(Product Product) { _context.Products.Add(Product); _context.SaveChanges(); }
    }
}

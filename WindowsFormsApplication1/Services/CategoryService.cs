using System.Collections.Generic;
using System.Linq;
using InventoryApp.Models;

namespace InventoryApp.Services
{
    public class CategoryService
    {
        private AppDbContext _context = new AppDbContext();

        public List<Category> GetAll() => _context.Categories.ToList();
        public void Add(Category category) { _context.Categories.Add(category); _context.SaveChanges(); }
        public void Update(Category category)
        {
            var existing = _context.Categories.Find(category.Id);
            if (existing == null) return;
            existing.Name = category.Name;
            existing.Desc = category.Desc;
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }
    }
}

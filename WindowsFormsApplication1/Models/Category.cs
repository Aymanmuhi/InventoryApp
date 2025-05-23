using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Desc { get; set; }
    }
}

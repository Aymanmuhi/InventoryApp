using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models
{
    public class Product
    {
        [Key]
        public int id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }

    }
}

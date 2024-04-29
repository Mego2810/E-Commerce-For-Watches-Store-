using E_Commerce_For_Watches_Store.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_For_Watches_Store.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public string ImageURL { get; set; }
        public ProductColor ProductColor { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public  Category Category { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace E_Commerce_For_Watches_Store.Models
{
    public class Category
    {
        public Category()
        {
            Products= new HashSet<Product>(); 

        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }



        public ICollection<Product> Products { get; set; }
    }
}

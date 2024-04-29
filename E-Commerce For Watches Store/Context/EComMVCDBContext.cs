using E_Commerce_For_Watches_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_For_Watches_Store.Context
{
    public class EComMVCDBContext:DbContext
    {

        public EComMVCDBContext(DbContextOptions<EComMVCDBContext> options) : base(options) {
        
        
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

using E_Commerce_For_Watches_Store.Context;
using E_Commerce_For_Watches_Store.Models;

namespace E_Commerce_For_Watches_Store.Data
{
    public class AppDbInital
    {

        public static void Seed(IApplicationBuilder app)
        {
            using( var appser=app.ApplicationServices.CreateScope())
            {
                var context = appser.ServiceProvider.GetService<EComMVCDBContext>();
                context.Database.EnsureCreated();
                

                //Catagory
                if(!context.Categories.Any()) {

                    var categories = new List<Category>() {

                        new Category
                        {
                            Name="C1",
                            Description="D1"
                        },
                          new Category
                        {
                            Name="C2",
                            Description="D2"
                        },
                          new Category
                        {
                            Name="C3",
                            Description="D3"
                        }


                    };
                    context.Categories.AddRange(categories);
                    context.SaveChanges();
                    
                }


                //Product 
                if (!context.Products.Any())
                {

                    var products = new List<Product>() {

                        new Product
                        {
                           Name="P1",Description="PD1",Price=1050,ImageURL="https//www.",ProductColor=ProductColor.Red,CategoryId=1
                        },
                        new Product
                        {
                           Name="P2",Description="PD2",Price=2050,ImageURL="https//wwww.",ProductColor=ProductColor.Yellow,CategoryId=2
                        },
                            new Product
                        {
                           Name="P3",Description="PD3",Price=3050,ImageURL="https//wwwww.",ProductColor=ProductColor.Blue,CategoryId=3
                        }

                    };
                    context.Products.AddRange(products);
                    context.SaveChanges();

                }

            }
        }
    }
}

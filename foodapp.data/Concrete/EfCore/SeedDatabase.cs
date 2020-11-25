using System.Linq;
using foodapp.entity;
using Microsoft.EntityFrameworkCore;

namespace foodapp.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new FoodContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Categories.Count()==0)
                {
                    if (context.Categories.Count()==0)
                    {
                        context.Categories.AddRange(Category);
                    }
                    if (context.Products.Count()==0)
                    {
                        context.Products.AddRange(Products);
                    }
                }
                context.SaveChanges();
            }
        }
        private static Category[] Category={
            new Category(){Name="Bazlama",ImageUrl="bazlama400gr.jpg"},
            new Category(){Name="Gözlemeler",ImageUrl="gozleme.jpg"},
            new Category(){Name="Çörekler",ImageUrl="koycoregi.jpg"},
            new Category(){Name="Hamurişleri",ImageUrl="eriste.jpg"}
        };
        private static Product[] Products={
            new Product(){Name="Bazlama",CategoryId=1,Price=3.5,IsApproved=true,ImageUrl="1.jpg"},
            new Product(){Name="Gözleme(Sade)",CategoryId=2,Price=3,IsApproved=true,ImageUrl="2.jpg"},
            new Product(){Name="Gözleme(Peynirli)",CategoryId=2,Price=3.5,IsApproved=true,ImageUrl="3.jpg"}
        };
    }
}
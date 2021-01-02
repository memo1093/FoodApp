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
                        context.Categories.AddRange(Category);
                    }
                    if (context.Products.Count()==0)
                    {
                        context.Products.AddRange(Products);
                    }
                    if(context.ProductCategories.Count()==0)
                    {
                        context.ProductCategories.AddRange(ProductCategories);
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
            new Product(){Name="Bazlama",CategoryId=1,Price=3.5m,IsApproved=true,ImageUrl="1.jpg"},
            new Product(){Name="Gözleme(Sade)",CategoryId=2,Price=3,IsApproved=true,ImageUrl="2.jpg"},
            new Product(){Name="Gözleme(Peynirli)",CategoryId=2,Price=3.5m,IsApproved=true,ImageUrl="3.jpg"},
            new Product(){Name="Gözleme(Patatesli)",CategoryId=2,Price=3.5m,IsApproved=true,ImageUrl="4.jpg"},
            new Product(){Name="Gözleme(Ispanaklı)",CategoryId=2,Price=3.5m,IsApproved=true,ImageUrl="5.jpg"},
            new Product(){Name="Gözleme(Kıymalı)",CategoryId=2,Price=3.5m,IsApproved=true,ImageUrl="6.jpg"},
            new Product(){Name="Gözleme(Patlıcanlı)",CategoryId=2,Price=3.5m,IsApproved=true,ImageUrl="7.jpg"},
            new Product(){Name="Sütlü Çörek",CategoryId=3,Price=3.5m,IsApproved=true,ImageUrl="8.jpg"},
            new Product(){Name="Cevizli Kömeç",CategoryId=3,Price=3.5m,IsApproved=true,ImageUrl="9.jpg"},
            new Product(){Name="Erişte(500gr)",CategoryId=4,Price=3.5m,IsApproved=true,ImageUrl="10.jpg"}
        };
        private static ProductCategory[] ProductCategories={
            new ProductCategory(){ProductId=1,CategoryId=1},
            new ProductCategory(){ProductId=2,CategoryId=2},
            new ProductCategory(){ProductId=3,CategoryId=2},
            new ProductCategory(){ProductId=4,CategoryId=2},
            new ProductCategory(){ProductId=5,CategoryId=2},
            new ProductCategory(){ProductId=6,CategoryId=2},
            new ProductCategory(){ProductId=7,CategoryId=2},
            new ProductCategory(){ProductId=8,CategoryId=3},
            new ProductCategory(){ProductId=9,CategoryId=3},
            new ProductCategory(){ProductId=10,CategoryId=4}

        };
    }
}
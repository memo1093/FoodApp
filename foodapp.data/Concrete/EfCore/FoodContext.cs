using foodapp.entity;
using Microsoft.EntityFrameworkCore;

namespace foodapp.data.Concrete.EfCore
{
    public class FoodContext:DbContext
    {
        private string _connectionString = @"server=localhost;port=3306;user=root;password=Mysql-1234;database=FoodDb";
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductCategory>()
                        .HasKey(c=>new{c.CategoryId,c.ProductId});
            
        }
    }
}
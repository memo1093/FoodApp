using foodapp.entity;
using Microsoft.EntityFrameworkCore;



namespace foodapp.data.Concrete.EfCore
{
    
    public class FoodContext:DbContext
    {
        private string _connectionString = @"server=localhost;port=3306;user=root;password=Mysql-1234;database=FoodDb";
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

       
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseMySql(_connectionString);
            
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductCategory>().HasKey(i=>new{i.CategoryId,i.ProductId});

            builder.Entity<ProductCategory>().HasOne(p=>p.Product)
                                            .WithMany(p=>p.ProductCategories)
                                            .HasForeignKey(p=>p.ProductId);

            builder.Entity<ProductCategory>().HasOne(c=>c.Category)
                                            .WithMany(c=>c.ProductCategories)
                                            .HasForeignKey(c=>c.CategoryId)
                                            .IsRequired()
                                            .OnDelete(DeleteBehavior.Cascade);
            
             
        }
    }
}
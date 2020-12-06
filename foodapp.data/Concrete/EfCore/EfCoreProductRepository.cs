using System.Collections.Generic;
using System.Linq;
using foodapp.data.Abstract;
using foodapp.entity;
using Microsoft.EntityFrameworkCore;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, FoodContext>, IProductRepository
    {
        public Product GetByIdWithCategories(int id)
        {
            using (var context = new FoodContext())
            {
                return context.Products.Where(p=>p.ProductId==id)
                                        .Include(p=>p.ProductCategories)
                                        .ThenInclude(pc=>pc.Category)
                                        .FirstOrDefault();
            }
        }

        public List<Product> GetProductsByCategory(string name)
        {
            using (var context = new FoodContext())
            {
                var products = context.Products.AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products.Include(i=>i.ProductCategories)
                                        .ThenInclude(i=>i.Category)
                                        .Where(i=>i.ProductCategories.Any(a=>a.Category.Name.ToLower()==name.ToLower()));
                                        
                                        
                }
                return products.ToList();
            }
        }

        
        public void Update(Product entity, int[] categoryIds)
        {
            using (var context = new FoodContext())
            {
                var product = context.Products.Include(i=>i.ProductCategories).FirstOrDefault(i=>i.ProductId==entity.ProductId);

                if (product!=null)
                {
                    product.Name =entity.Name;
                    product.Price =entity.Price;
                    product.ImageUrl = entity.ImageUrl;

                    product.ProductCategories = categoryIds.Select(catid=>new ProductCategory(){
                        ProductId=entity.ProductId,
                        CategoryId=catid
                    }).ToList();
                }
                context.SaveChanges();
            }
        }

        
    }
}
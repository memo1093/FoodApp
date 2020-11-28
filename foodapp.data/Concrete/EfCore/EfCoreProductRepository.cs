using System.Collections.Generic;
using System.Linq;
using foodapp.data.Abstract;
using foodapp.entity;
using Microsoft.EntityFrameworkCore;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, FoodContext>, IProductRepository
    {
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
    }
}
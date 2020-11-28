using System.Collections.Generic;
using System.Linq;
using foodapp.data.Abstract;
using foodapp.entity;
using Microsoft.EntityFrameworkCore;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, FoodContext>, ICategoryRepository
    {
        public List<Category> GetCategoryByProductName(string name)
        {
            using (var context = new FoodContext())
            {
                var categories = context.Categories.AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    categories = categories.Include(i=>i.ProductCategories)
                                                .ThenInclude(i=>i.Product)
                                                .Where(i=>i.ProductCategories.Any(a=>a.Product.Name.ToLower()==name.ToLower()));

                }
                return categories.ToList();
            }
        }
    }
}
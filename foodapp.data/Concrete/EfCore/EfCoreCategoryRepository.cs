using System.Collections.Generic;
using System.Linq;
using foodapp.data.Abstract;
using foodapp.entity;
using Microsoft.EntityFrameworkCore;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, FoodContext>, ICategoryRepository
    {
        public Category GetByIdWithProducts(int id)
        {
            using (var context = new FoodContext())
            {
                var category = context.Categories;

                return category.Where(i=>i.CategoryId==id)
                                .Include(i=>i.ProductCategories)
                                .ThenInclude(i=>i.Product)
                                .FirstOrDefault();
            }
        }

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
        public override void Delete(Category entity)
        {
            using (var context = new FoodContext())
            {
                var category = context.Categories.Single(i=>i.CategoryId==entity.CategoryId);
                var products = context.Products.Where(i=>EF.Property<int>(i,"CategoryId")==entity.CategoryId).ToList();
                context.RemoveRange(products);
                context.Remove(category);
                context.SaveChanges();
            }
        }

        
    }
}
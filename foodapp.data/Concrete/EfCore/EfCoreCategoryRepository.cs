using System.Collections.Generic;
using foodapp.data.Abstract;
using foodapp.entity;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : ICategoryRepository
    {
        private FoodContext db = new FoodContext();
        public void Create(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using foodapp.data.Abstract;
using foodapp.entity;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : IProductRepository
    {
        private FoodContext db = new FoodContext();
        public void Create(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
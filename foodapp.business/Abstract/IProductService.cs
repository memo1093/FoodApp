using System.Collections.Generic;
using foodapp.entity;

namespace foodapp.business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();

        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        List<Product> GetProductsByCategory(string name);
        
        
    }
}
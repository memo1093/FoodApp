using System.Collections.Generic;
using foodapp.entity;

namespace foodapp.business.Abstract
{
    public interface IProductService:IValidator<Product>
    {
        Product GetById(int id);
        List<Product> GetAll();
        bool Create(Product entity);
        bool Update(Product entity);
        bool Update(Product entity, int[] categoryIds);
        bool Delete(Product entity);

        List<Product> GetProductsByCategory(string name);
        Product GetByIdWithCategories(int id);
        
    }
}
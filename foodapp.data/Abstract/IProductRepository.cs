using System.Collections.Generic;
using foodapp.entity;

namespace foodapp.data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetProductsByCategory(string name);
        Product GetByIdWithCategories(int id);

        void Update(Product entity, int[] categoryIds);
        
    }
}
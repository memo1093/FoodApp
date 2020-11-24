using System.Collections.Generic;
using foodapp.data.Abstract;
using foodapp.entity;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product,FoodContext>,IProductRepository
    {
        
    }
}
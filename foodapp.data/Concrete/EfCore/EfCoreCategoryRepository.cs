using System.Collections.Generic;
using foodapp.data.Abstract;
using foodapp.entity;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category,FoodContext>,ICategoryRepository
    {
        
    }
}
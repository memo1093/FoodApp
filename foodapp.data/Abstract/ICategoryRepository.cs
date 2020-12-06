using System.Collections.Generic;
using foodapp.entity;

namespace foodapp.data.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        List<Category> GetCategoryByProductName(string name);

        Category GetByIdWithProducts(int id);
    }
}
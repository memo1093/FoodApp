using System.Collections.Generic;
using foodapp.entity;

namespace foodapp.business.Abstract
{
    public interface ICategoryService:IValidator<Category>
    {
        Category GetById(int id);
        List<Category> GetAll();
        List<Category> GetCategoryByProductName(string name);
        Category GetByIdWithProducts(int id);
        bool Delete(Category entity);

        bool Update(Category entity);
        bool Create(Category entity);


        
    }
}
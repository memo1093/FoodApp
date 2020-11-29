using System.Collections.Generic;
using foodapp.entity;

namespace foodapp.business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll();
        List<Category> GetCategoryByProductName(string name);
        Category GetByIdWithProducts(int id);
        void Delete(Category entity);

        void Update(Category entity);
        void Create(Category entity);


        
    }
}
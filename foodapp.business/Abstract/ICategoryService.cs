using System.Collections.Generic;
using foodapp.entity;

namespace foodapp.business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll();
        List<Category> GetCategoryByProductName(string name);
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);


        
    }
}
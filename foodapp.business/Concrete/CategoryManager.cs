using System.Collections.Generic;
using foodapp.business.Abstract;
using foodapp.data.Abstract;
using foodapp.entity;

namespace foodapp.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Create(Category entity)
        {
            _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public List<Category> GetCategoryByProductName(string name)
        {
            return _categoryRepository.GetCategoryByProductName(name);
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }
        
    }
}
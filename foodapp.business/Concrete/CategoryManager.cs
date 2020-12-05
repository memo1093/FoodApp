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

        

        public bool Create(Category entity)
        {
            if (Validation(entity))
            {
                _categoryRepository.Create(entity);
                return true;
            }
            return false;
        }

        public bool Delete(Category entity)
        {
            if (Validation(entity))
            {
                _categoryRepository.Delete(entity);
                return true;
            }
            return false;
            
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetByIdWithProducts(int id)
        {
            return _categoryRepository.GetByIdWithProducts(id);
        }

        public List<Category> GetCategoryByProductName(string name)
        {
            return _categoryRepository.GetCategoryByProductName(name);
        }
        public bool Update(Category entity)
        {
            if (Validation(entity))
            {
                _categoryRepository.Update(entity);
                return true;
            }
            return false;
            
        }
        public string ErrorMessage { get; set ; }
        public bool Validation(Category entity)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "Kategori adı mutlaka girilmelidir.";
                return false;
            }
            if (entity.Name.Length<4 && entity.Name.Length>20)
            {
                ErrorMessage += "Kategori adı 4-20 karakter arası olmalıdır";
                return false;
            }
           
            return isValid;
        }
        

    }
}
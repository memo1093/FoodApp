using System.Collections.Generic;
using foodapp.business.Abstract;
using foodapp.data.Abstract;
using foodapp.entity;

namespace foodapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

                

        public bool Create(Product entity)
        {
            if (Validation(entity))
            {
                _productRepository.Create(entity);
                return true;
            }
            return false;
            
        }

        public bool Delete(Product entity)
        {
            if (entity.ProductId==0)
            {
                return false;
            }
            _productRepository.Delete(entity);
            return true;
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product GetByIdWithCategories(int id)
        {
            return _productRepository.GetByIdWithCategories(id);
        }

        public List<Product> GetProductsByCategory(string name)
        {
            return _productRepository.GetProductsByCategory(name);
        }


        public bool Update(Product entity)
        {
            if (Validation(entity))
            {
                _productRepository.Update(entity);
                return true;
            }
            return false;
        }
        public bool Update(Product entity, int[] categoryIds)
        {
            if (Validation(entity))
            {
                if (categoryIds.Length==0)
                {
                    ErrorMessage+="Kategori seçilmelidir.";
                    
                    return false;
                }
                
                _productRepository.Update(entity, categoryIds);
                return true;
            }
            return false;
        }

        public string ErrorMessage { get; set ; }

        public bool Validation(Product entity)
        {
            
            if (entity.CategoryId==0)
            {
                ErrorMessage +="Ürün için bir kategori seçmelisiniz. \n";
                return false;
            }

            if (string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage +="Ürün ismi girmelisiniz. \n";
                return false;
            }
            if (entity.Name.Length<4 || entity.Name.Length>30)
            {
               ErrorMessage +="Ürün adı 4-30 karakter arası olmalıdır. \n";
                return false; 
            }
            if (string.IsNullOrEmpty($"{entity.Price}"))
            {
                ErrorMessage +="Ürün fiyatı girilmelidir. \n";
                return false; 
            }
            if (entity.Price<0)
            {
                ErrorMessage +="Ürün fiyatı negatif olamaz. \n";
                return false;
            }
            if (entity.Price <0.25)
            {
                ErrorMessage +="Ürün fiyatı minimum 0.25 olabilir.  \n";
                return false;
            }
            if (string.IsNullOrEmpty(entity.ImageUrl))
            {
                ErrorMessage += "Ürün resmi girilmelidir. \n";
                return false;
            }
            
            return true;
        }

       
    }  

}
using System.Collections.Generic;
using foodapp.business.Abstract;
using foodapp.data.Abstract;
using foodapp.data.Concrete.EfCore;
using foodapp.entity;

namespace foodapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository=productRepository;
        }  
        public void Create(Product entity)
        {
            
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
           return _productRepository.GetById(id);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}
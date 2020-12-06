using foodapp.business.Abstract;
using foodapp.entity;
using foodapp.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace foodapp.webui.Controllers
{
    public class ShopController:Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public ShopController(IProductService productService,ICategoryService categoryService)
        {
            this._productService=productService;
            this._categoryService=categoryService;
        }
         public IActionResult List()
        {
            var ProductCategoryListViewModel = new ProductCategoryListViewModel(){
                Products = _productService.GetAll(),
                
                
            };
            return View(ProductCategoryListViewModel);
        }
        public IActionResult Details(int? id)
        {
            if (id==null)
            {
               return NotFound();
            }
            Product product = _productService.GetById((int)id);
            if (product==null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
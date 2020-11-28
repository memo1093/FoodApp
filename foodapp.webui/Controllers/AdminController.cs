using foodapp.business.Abstract;
using foodapp.entity;
using foodapp.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace foodapp.webui.Controllers
{
    public class AdminController:Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public AdminController(IProductService productService,ICategoryService categoryService)
        {
            this._productService=productService;
            this._categoryService=categoryService;
        }
        public IActionResult ProductList()
        {
            return View(new ProductViewModel(){
                Products = _productService.GetAll(),
                Categories =  _categoryService.GetAll(),
            });
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(ProductModel model)
        {
            var entity= new Product(){
                Name = model.Name,
                Price = model.Price,
                ImageUrl = model.ImageUrl
            };
            _productService.Create(entity);
            return RedirectToAction("ProductList");
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using foodapp.webui.Models;
using foodapp.business.Abstract;

namespace foodapp.webui.Controllers
{
    public class HomeController : Controller
    {
        
        private IProductService _productService;
        private ICategoryService _categoryService;



        public HomeController(IProductService productService,ICategoryService categoryService)
        {
            this._productService=productService;
            this._categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var ProductCategoryListViewModel = new ProductCategoryListViewModel(){
                Products = _productService.GetAll(),
                Categories = _categoryService.GetAll()
                
            };
            return View(ProductCategoryListViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using foodapp.webui.Models;
using foodapp.data.Abstract;
using foodapp.webui.ViewModel;
using foodapp.data.Concrete.EfCore;
using foodapp.business.Abstract;

namespace foodapp.webui.Controllers
{
    public class HomeController : Controller
    {
        
        private IProductService _productService;
        private ICategoryRepository _categoryRepository;



        public HomeController(IProductService productService,ICategoryRepository categoryRepository)
        {
            this._productService=productService;
            this._categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel(){
                Products = _productService.GetAll(),
                Categories = _categoryRepository.GetAll()
                
            };
            return View(productViewModel);
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

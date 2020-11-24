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

namespace foodapp.webui.Controllers
{
    public class HomeController : Controller
    {
        
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;



        public HomeController(IProductRepository productRepository,ICategoryRepository categoryRepository)
        {
            this._productRepository=productRepository;
            this._categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel(){
                Products = _productRepository.GetAll(),
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

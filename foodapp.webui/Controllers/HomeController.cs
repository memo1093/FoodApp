using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using foodapp.webui.Models;
using foodapp.data.Abstract;

namespace foodapp.webui.Controllers
{
    public class HomeController : Controller
    {
        
        private IProductRepository _productRepository;



        public HomeController(IProductRepository productRepository)
        {
            this._productRepository=productRepository;
        }

        

        public IActionResult Index()
        {
            return View();
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

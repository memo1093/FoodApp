using System.Linq;
using foodapp.business.Abstract;
using foodapp.entity;
using foodapp.webui.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace foodapp.webui.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            this._productService = productService;
            this._categoryService = categoryService;
        }
        public IActionResult ProductList()
        {
            return View(new ProductViewModel()
            {
                Products = _productService.GetAll(),
                Categories = _categoryService.GetAll(),
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
            var entity = new Product()
            {
                Name = model.Name,
                Price = model.Price,
                ImageUrl = model.ImageUrl
            };
            _productService.Create(entity);
            var msg = new AlertMessage()
            {
                Message = $"{entity.Name} isimli ürün başarıyla eklendi.",
                AlertType = "alert-success"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
            return RedirectToAction("ProductList");

        }

        [HttpGet]
        public IActionResult EditProduct(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var entity = _productService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new ProductModel()
            {
                ProductId = entity.ProductId,
                Name = entity.Name,
                Price = entity.Price,
                ImageUrl = entity.ImageUrl
            };

            ViewBag.Categories=_categoryService.GetAll();

            return View(model);

        }
        [HttpPost]
        public IActionResult EditProduct(ProductModel model)
        {
            var entity = _productService.GetById(model.ProductId);
            if (entity == null)
            {
                return NotFound();
            }
            entity.ProductId = model.ProductId;
            entity.Name = model.Name;
            entity.Price = model.ProductId;
            entity.ImageUrl = model.ImageUrl;

            _productService.Update(entity);
            var msg = new AlertMessage()
            {
                Message = $"{entity.Name} isimli ürün başarıyla güncellendi.",
                AlertType = "alert-success"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
            return RedirectToAction("ProductList");
        }

        [HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            var entity = _productService.GetById(productId);
            if (entity != null)
            {
                _productService.Delete(entity);
            }
            var msg = new AlertMessage()
            {
                Message = $"{entity.Name} isimli ürün silindi.",
                AlertType = "alert-danger"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
            return RedirectToAction("ProductList");
        }
        [HttpPost]
        public IActionResult Approve(int productId)
        {
            var entity = _productService.GetById(productId);
            bool approveAction=false;

            if (entity != null)
            {
                if (entity.IsApproved)
                {
                    
                    entity.IsApproved = approveAction;
                    _productService.Update(entity);
                    var msg = new AlertMessage()
                    {
                        Message = $"{entity.Name} isimli ürünün onayı kaldırıldı.",
                        AlertType = "alert-danger"
                    };
                    TempData["message"] = JsonConvert.SerializeObject(msg);
                }else
                {
                    approveAction = true;
                    entity.IsApproved = approveAction;
                    _productService.Update(entity);
                    var msg = new AlertMessage()
                    {
                        Message = $"{entity.Name} isimli ürün başarıyla onaylandı.",
                        AlertType = "alert-warning"
                    };
                    TempData["message"] = JsonConvert.SerializeObject(msg);
                }
                

            }

            return RedirectToAction("ProductList");
        }

        public IActionResult CategoryList()
        {

            return View(new ProductViewModel{
                Categories=_categoryService.GetAll(),
                Products = _productService.GetAll()
            });
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CategoryModel category)
        {
            
            var entity = new Category(){
                Name=category.Name,
                ImageUrl=category.ImageUrl
            };
            _categoryService.Create(entity);

             var msg = new AlertMessage()
            {
                Message = $"{entity.Name} Kategori tipi başarıyla eklendi",
                AlertType = "alert-success"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);

            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public IActionResult EditCategory(int? id)
        {
            if (id==null)
            {
                NotFound();
            }
            var category= _categoryService.GetByIdWithProducts((int)id);
            if (category==null)
            {
                NotFound();
            }
            var model = new CategoryModel(){
                CategoryId=category.CategoryId,
                Name=category.Name,
                ImageUrl=category.ImageUrl,
                Products = category.ProductCategories.Select(p=>p.Product).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditCategory(CategoryModel model)
        {
            var entity = _categoryService.GetById(model.CategoryId);
            if (entity==null)
            {
                NotFound(entity.Name);
            }
            entity.CategoryId=model.CategoryId;
            entity.Name=model.Name;
            entity.ImageUrl=model.ImageUrl;

            _categoryService.Update(entity);
            
             var msg = new AlertMessage()
            {
                Message = $"{entity.Name} Kategori tipi başarıyla güncellendi",
                AlertType = "alert-success"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);

            return RedirectToAction("CategoryList");
        }

        [HttpPost]
        public IActionResult DeleteCategory(int categoryId)
        {
            var category = _categoryService.GetById(categoryId);
            
            if (category == null)
            {
                NotFound(category);
            }

            _categoryService.Delete(category);

             var msg = new AlertMessage()
            {
                Message = $"{category.Name} Kategori tipi ve içerdiği ürünler silindi",
                AlertType = "alert-danger"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);

            

            return RedirectToAction("CategoryList");
        }


        
        
    }
}
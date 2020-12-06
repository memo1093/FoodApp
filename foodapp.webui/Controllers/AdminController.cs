using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using foodapp.business.Abstract;
using foodapp.entity;
using foodapp.webui.Models;
using Microsoft.AspNetCore.Http;
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
            return View(new ProductCategoryListViewModel()
            {
                Products = _productService.GetAll(),
                Categories = _categoryService.GetAll(),
            });
        }



        [HttpGet]
        public IActionResult CreateProduct()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductModel model, IFormFile file,int categoryId)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var extension = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{DateTime.Now.Ticks}{extension}");

                    model.ImageUrl = randomName;


                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Products", randomName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                var entity = new Product()
                {
                    Name = model.Name,
                    Price = model.Price,
                    ImageUrl = model.ImageUrl,
                    CategoryId = categoryId

                };


                if (_productService.Create(entity))
                {
                    CreateMessage($"{entity.Name} adlı ürün başarıyla eklendi", "alert-success");
                    return RedirectToAction("ProductList");
                };
                CreateMessage(_productService.ErrorMessage);
            }
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);


        }

        [HttpGet]
        public IActionResult EditProduct(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var entity = _productService.GetByIdWithCategories((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new ProductModel()
            {
                ProductId = entity.ProductId,
                Name = entity.Name,
                Price = entity.Price,
                ImageUrl = entity.ImageUrl,
                SelectedCategories = entity.ProductCategories.Select(i => i.Category).ToList()
            };

            ViewBag.Categories = _categoryService.GetAll();

            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductModel model, int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = _productService.GetById(model.ProductId);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.ProductId = model.ProductId;
                entity.Name = model.Name;
                entity.Price = model.Price;

                if (file != null)
                {

                    var extension = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{DateTime.Now.Ticks}{extension}");
                    entity.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Products", randomName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                if (categoryIds.Length<0)
                {
                    CreateMessage($"Ürün kategorisi seçmelisiniz.");
                    return View(model);
                }
                

                if (_productService.Update(entity, categoryIds))
                {
                    CreateMessage($"{entity.Name} isimli ürün başarıyla güncellendi.", "alert-success");
                    return RedirectToAction("ProductList");
                }
                CreateMessage(_productService.ErrorMessage);
            }

            ViewBag.Categories = _categoryService.GetAll();
            return View(model);

        }



        [HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            var entity = _productService.GetById(productId);
            if (entity == null)
            {
                CreateMessage($"{entity.Name} adında ürün yok.");
            }
            if (entity != null)
            {
                if (_productService.Delete(entity))
                {


                    CreateMessage($"{entity.Name} isimli ürün silindi.");
                    if (entity.ImageUrl != null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", "Products", entity.ImageUrl);
                        FileInfo file = new FileInfo(path);
                        file.Delete();
                    }
                };

            }


            return RedirectToAction("ProductList");
        }
        [HttpPost]
        public IActionResult Approve(int productId)
        {
            var entity = _productService.GetById(productId);
            bool approveAction = false;

            if (entity != null)
            {
                if (entity.IsApproved)
                {

                    entity.IsApproved = approveAction;
                    _productService.Update(entity);
                    CreateMessage($"{entity.Name} isimli ürünün onayı kaldırıldı.");
                }
                else
                {
                    approveAction = true;
                    entity.IsApproved = approveAction;
                    _productService.Update(entity);
                    CreateMessage($"{entity.Name} isimli ürün başarıyla onaylandı.", "alert-warning");
                }


            }

            return RedirectToAction("ProductList");
        }

        public IActionResult CategoryList()
        {

            return View(new ProductCategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                Products = _productService.GetAll()
            });
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category()
                {
                    Name = model.Name,
                    ImageUrl = model.ImageUrl
                };
                if (_categoryService.Create(entity))
                {

                }


                var msg = new AlertMessage()
                {
                    Message = $"{entity.Name} Kategori tipi başarıyla eklendi",
                    AlertType = "alert-success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);

                return RedirectToAction("CategoryList");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _categoryService.GetByIdWithProducts((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new CategoryModel()
            {
                CategoryId = entity.CategoryId,
                Name = entity.Name,
                ImageUrl = entity.ImageUrl,
                ProductsInThisCategory = entity.ProductCategories.Select(p => p.Product).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditCategory(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = _categoryService.GetById(model.CategoryId);
                if (entity == null)
                {
                    return NotFound(entity.Name);
                }

                entity.Name = model.Name;
                entity.ImageUrl = model.ImageUrl;

                _categoryService.Update(entity);

                var msg = new AlertMessage()
                {
                    Message = $"{entity.Name} Kategori tipi başarıyla güncellendi",
                    AlertType = "alert-success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);

                return RedirectToAction("CategoryList");
            }

            return View(model);

        }

        [HttpPost]
        public IActionResult DeleteCategory(int categoryId)
        {
            var category = _categoryService.GetById(categoryId);

            if (category == null)
            {
                return NotFound(category);
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

        private void CreateMessage(string message, string alertType = "alert-danger")
        {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alertType
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
        }





    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using foodapp.business.Abstract;
using foodapp.entity;
using foodapp.webui.Extensions;
using foodapp.webui.Identity;
using foodapp.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace foodapp.webui.Controllers
{
    
    
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        public AdminController(IProductService productService, ICategoryService categoryService,
                                RoleManager<IdentityRole> roleManager,UserManager<User> userManager)
        {
            this._productService = productService;
            this._categoryService = categoryService;
            this._roleManager = roleManager;
            this._userManager = userManager;
        }
        [Authorize(Roles="master")]
        public IActionResult RolesList()
        {
            return View(_roleManager.Roles);
        }
        [Authorize(Roles="master")]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                if (result.Succeeded)
                {
                    TempData.Put("message", new AlertMessage
                    {
                        Title = $"{model.Name} rolü başarıyla eklendi.",
                        Message = $"{model.Name} rolü başarıyla eklendi.",
                        AlertType = "alert-success"
                    });
                    return RedirectToAction("RolesList");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("",$"Hata : {error}");
                    }
                }
                 
                return View(model);
            }
            TempData.Put("message", new AlertMessage
                    {
                        Title = $"{model.Name} rolü eklenemedi.",
                        Message = $"{model.Name} rolü eklenemedi.",
                        AlertType = "alert-secondary"
                    });
            return View(model);
            
        }
        [Authorize(Roles="master")]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            var members = new List<User>();
            var nonMembers = new List<User>();
            var userList =  _userManager.Users.ToList();
            
            foreach (var user in userList)
            {

                var list = await _userManager.IsInRoleAsync(user,role.Name)
                                                            ?members:nonMembers;

                list.Add(user);
                
            }
            var model = new RoleDetails()
            {
                Role=role,
                Members=members,
                NonMembers=nonMembers
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditRole(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[]{})
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user!=null)
                    {
                        var result = await _userManager.AddToRoleAsync(user,model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("",error.Description);
                            }
                            return View(model);
                        }
                        
                    }
                }
                foreach (var userId in model.IdsToDelete ?? new string[]{})
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user!=null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user,model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("",error.Description);
                            }
                            return View(model);
                        }
                        
                    }
                }

                
            }
            return RedirectToAction("RolesList");
        }

        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }
       
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user!=null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);

                return View(new UserDetailModel(){
                    UserId=user.Id,
                    UserName=user.UserName,
                    FirstName=user.FirstName,
                    LastName = user.LastName,
                    Email=user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    
                });
            }
            return Redirect("~/admin/user/list");
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(UserDetailModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user!=null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.EmailConfirmed = model.EmailConfirmed;
                    user.Email=model.Email;

                    var result= await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        TempData.Put("message", new AlertMessage{
                            Title ="Kullanıcı Güncelleme",
                            Message= "Kullanıcı Güncelleme işlemi başarılı",
                            AlertType = "alert-success"
                        });   
                        return RedirectToAction("UserList");
                    }
                }
                
            }
            return View(model);
            
        }



        public IActionResult ProductList()
        {
            return View(new ProductCategoryListViewModel()
            {
                Products = _productService.GetAll(),
                Categories = _categoryService.GetAll(),
            });
        }

        


        [Authorize(Roles="admin")]
        [HttpGet]
        public IActionResult CreateProduct()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductModel model, IFormFile file)
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
                    CategoryId = model.CategoryId

                };


                if (_productService.Create(entity))
                {
                    TempData.Put("message", new AlertMessage
                    {
                        Title = $"{entity.Name} adlı ürün başarıyla eklendi",
                        Message = $"{entity.Name} adlı ürün başarıyla eklendi",
                        AlertType = "alert-success"
                    });
                    return RedirectToAction("ProductList");
                };
                TempData.Put("message", new AlertMessage
                {
                    Title = _productService.ErrorMessage,
                    Message = _productService.ErrorMessage,

                });
            }
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);


        }
        [Authorize(Roles="admin")]
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
        [Authorize(Roles="admin")]
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
                if (categoryIds.Length < 0)
                {
                    TempData.Put("message", new AlertMessage
                    {
                        Title = "Ürün kategorisi seçmelisiniz.",
                        Message = "Ürün kategorisi seçmelisiniz.",

                    });

                    return View(model);
                }


                if (_productService.Update(entity, categoryIds))
                {
                    TempData.Put("message", new AlertMessage
                    {
                        Title = $"{entity.Name} isimli ürün başarıyla güncellendi.",
                        Message = $"{entity.Name} isimli ürün başarıyla güncellendi.",
                        AlertType = "alert-success"

                    });
                    return RedirectToAction("ProductList");
                }
                TempData.Put("message", new AlertMessage
                {
                    Title = _productService.ErrorMessage,
                    Message = _productService.ErrorMessage,

                });
            }

            ViewBag.Categories = _categoryService.GetAll();
            return View(model);

        }


        [Authorize(Roles="admin")]
        [HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            var entity = _productService.GetById(productId);
            if (entity == null)
            {
                TempData.Put("message", new AlertMessage
                {
                    Title = $"{entity.Name} adında ürün yok.",
                    Message = $"{entity.Name} adında ürün yok.",

                });
            }
            if (entity != null)
            {
                if (_productService.Delete(entity))
                {
                    TempData.Put("message", new AlertMessage
                    {
                        Title = $"{entity.Name} isimli ürün silindi.",
                        Message = $"{entity.Name} isimli ürün silindi."

                    });


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
        [Authorize(Roles="admin")]
        [HttpPost]
        public IActionResult Approve(int productId)
        {
            var entity = _productService.GetById(productId);
            bool approveAction = false;

            if (entity != null && entity.CategoryId!=null)
            {
                if (entity.IsApproved)
                {

                    entity.IsApproved = approveAction;
                    _productService.Update(entity);
                    TempData.Put("message", new AlertMessage
                    {
                        Title = $"{entity.Name} isimli ürünün onayı kaldırıldı.",
                        Message = $"{entity.Name} isimli ürünün onayı kaldırıldı.",
                        AlertType = "alert-warning"
                    });
                }
                else
                {
                    approveAction = true;
                    entity.IsApproved = approveAction;
                    _productService.Update(entity);
                    TempData.Put("message", new AlertMessage
                    {
                        Title = $"{entity.Name} isimli ürün başarıyla onaylandı.",
                        Message = $"{entity.Name} isimli ürün başarıyla onaylandı.",
                        AlertType = "alert-warning"
                    });
                }
                return RedirectToAction("ProductList");

            }
            TempData.Put("message", new AlertMessage
                    {
                        Title = $"{entity.Name} isimli ürün onay sorunu.",
                        Message = $"{entity.Name} isimli ürün onayı başarısız oldu! Ürün kayıtlı olmayabilir ya da ait olduğu bir kategorisi yok.",
                        AlertType = "alert-danger"
                    });

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
        [Authorize(Roles="admin")]

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

                TempData.Put("message", new AlertMessage
                {
                    Title = $"{entity.Name} Kategori tipi başarıyla eklendi",
                    Message = $"{entity.Name} Kategori tipi başarıyla eklendi",
                    AlertType = "alert-success"
                });


                return RedirectToAction("CategoryList");
            }
            return View(model);
        }

        [Authorize(Roles="admin")]

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


                TempData.Put("message", new AlertMessage
                {
                    Title = $"{entity.Name} Kategori tipi başarıyla güncellendi",
                    Message = $"{entity.Name} Kategori tipi başarıyla güncellendi",
                    AlertType = "alert-success"
                });

                return RedirectToAction("CategoryList");
            }

            return View(model);

        }

        [Authorize(Roles="admin")]

        [HttpPost]
        public IActionResult DeleteCategory(int categoryId)
        {
            var category = _categoryService.GetById(categoryId);

            if (category == null)
            {
                return NotFound(category);
            }

            _categoryService.Delete(category);
            TempData.Put("message", new AlertMessage
            {
                Title = $"{category.Name} Kategori tipi ve içerdiği ürünler silindi",
                Message = $"{category.Name} Kategori tipi ve içerdiği ürünler silindi",

            });
            return RedirectToAction("CategoryList");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }






    }
}
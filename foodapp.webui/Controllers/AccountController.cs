using System;
using System.Threading.Tasks;
using foodapp.business.Abstract;
using foodapp.webui.EmailService;
using foodapp.webui.Extensions;
using foodapp.webui.Identity;
using foodapp.webui.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace foodapp.webui.Controllers
{


    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        private ICartService _icartService;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender,ICartService icartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _icartService=icartService;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                TempData.Put("message", new AlertMessage
                    {
                        Title = "",
                        Message = "Zaten giriş yaptınız.",
                        AlertType = "alert-warning"
                    });
                return RedirectToAction("Index","Home");
            }
            return View(new LoginModel() { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu kullanıcı mevcut değil");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, true);
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Lütfen email hesabınıza gelen link ile mail hesabınızı onaylayınız.");
                return View();
            }

            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }

            ModelState.AddModelError("", "Girilen Kullanıcı adı veya parola bilgisi yanlış");
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                TempData.Put("message", new AlertMessage
                    {
                        Title = "",
                        Message = $"Zaten aktif bir hesabınız mevcut.",
                        AlertType = "alert-warning"
                    });
                    return RedirectToAction("Index","Home");
                
            }
            
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);

            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user,"customer");
                //generate token
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    _userId = user.Id,
                    _token = token
                });
                Console.WriteLine(url);

                //email
                await _emailSender.SendEmailAsync(model.Email, "Hesap Onay Kodu", $"Hesabınızı onaylamak için <a href='https://localhost:5001{url}' >linke</a> tıklayınız.");



                TempData.Put("message", new AlertMessage
                    {
                        Title = "Aktivasyon",
                        Message = $"{model.Email} adresine onay maili gönderilecektir. Hesap onaylandığı an giriş yapabilirsiniz.",
                        AlertType = "alert-success"
                    });
                return RedirectToAction("Login", "Account");
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu. Lütfen daha sonra tekrar deneyiniz");
            return View(model);
        }
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            if (User.Identity.IsAuthenticated)
            {
                TempData.Put("message", new AlertMessage
                    {
                        Title = "",
                        Message = "Zaten giriş yaptınız.",
                        AlertType = "alert-warning"
                    });
                    return RedirectToAction("Index","Home");
                
            }
            return View();
        } 
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("email", "Email bulunamadı");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                ModelState.AddModelError("user", "Kullanıcı bulunamadı");
                return View();
            }
            //generate token
            var _token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = _token
            });

            //send email
            //email
            await _emailSender.SendEmailAsync(email, "Şifre Sıfırlama Kodu", $"Parolanızı yenilemek için <a href='https://localhost:5001{url}' >linke</a> tıklayınız.");

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult ResetPassword(string userId, string token)
        {
            if (User.Identity.IsAuthenticated)
            {
                TempData.Put("message", new AlertMessage
                    {
                        Title = "",
                        Message = "Zaten giriş yaptınız.",
                        AlertType = "alert-warning"
                    });
                    return RedirectToAction("Index","Home");
                
            }
            if (userId == null || token == null)
            {
                TempData.Put("message", new AlertMessage
                    {
                        Title = "Yanlış link",
                        Message = $"Yanlış link bilgisi. Lütfen linkin bizim tarafımızca gönderildiğinden emin olun",
                        AlertType = "alert-warning"
                    });
                
                return RedirectToAction("ForgotPassword", "Account");
            }

            var model = new ResetPasswordModel { Token = token };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                TempData.Put("message", new AlertMessage
                    {
                        Title = "Hata",
                        Message = $"Bu kullanıcı kayıtlı değil",
                        AlertType = "alert-success"
                    });
                
                return RedirectToAction("Login", "Account");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData.Put("message", new AlertMessage
                    {
                        Title = "",
                        Message = $"Mevcut hesap bulunmamaktadır.",
                        AlertType = "alert-warning"
                    });
                    return RedirectToAction("Index","Home");
                
            }
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }
        public async Task<IActionResult> ConfirmEmail(string _userId, string _token)
        {
            if (_userId == null || _token == null)
            {
                TempData.Put("message", new AlertMessage
                    {
                        Title = "Aktivasyon",
                        Message = "Geçersiz Kullanıcı",
                        AlertType = "alert-danger"
                    });
                
            }
            var user = await _userManager.FindByIdAsync(_userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, _token);
                if (result.Succeeded)
                {
                    _icartService.InitializeCart(user.Id);
                    TempData.Put("message", new AlertMessage
                    {
                        Title = "Hesap Onaylandı",
                        Message = " Hesabınız başarıyla onaylandı. Şimdi giriş yapabilirsiniz.",
                        AlertType = "alert-success"
                    });
                }

            }
            
            
            return View();
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
using System;
using System.Linq;
using foodapp.business.Abstract;
using foodapp.webui.Identity;
using foodapp.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace foodapp.webui.Controllers
{
    [Authorize]
    public class CartController:Controller
    {
        private ICartService _cartService;
        private UserManager<User> _userManager;

        public CartController(ICartService cartService, UserManager<User> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var cart = _cartService.GetByUserId(_userManager.GetUserId(User));
            return View(new CartModel(){
                CartId = cart.Id,
                CartItems =cart.CartItems.Select(i=> new CartItemModel(){
                    CartItemId=i.Id,
                    ProductId=i.ProductId,
                    Name=i.Product.Name,
                    Price=i.Product.Price,
                    ImageUrl=i.Product.ImageUrl,
                    Quantity = i.Quantity
                }).ToList()
            });
        }
        [HttpPost]
        public IActionResult AddtoCart(int productId,int quantity)
        {
            _cartService.AddToCart(_userManager.GetUserId(User),productId,quantity);
            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        public IActionResult DeleteFromCart(int productId)
        {
            var userId= _userManager.GetUserId(User);
            
            _cartService.DeleteFromCart(productId,userId);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteAllFromCart(int[] productIds)
        {
            var userId= _userManager.GetUserId(User);
            foreach (var productId in productIds)
            {
                _cartService.DeleteFromCart(productId,userId);
            
            }
            return RedirectToAction("Index");
            
        }
    }
}
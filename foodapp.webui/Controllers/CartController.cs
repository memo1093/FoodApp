using System;
using System.Collections.Generic;
using System.Linq;
using foodapp.business.Abstract;
using foodapp.entity;
using foodapp.webui.Extensions;
using foodapp.webui.Identity;
using foodapp.webui.Models;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace foodapp.webui.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private ICartService _cartService;
        private UserManager<User> _userManager;
        private IOrderService _orderService;
        private IProductService _productService;

        public CartController(ICartService cartService, UserManager<User> userManager, IOrderService orderService,IProductService productService)
        {
            _cartService = cartService;
            _userManager = userManager;
            _orderService = orderService;
            _productService= productService;
        }

        public IActionResult Index()
        {
            var cart = _cartService.GetByUserId(_userManager.GetUserId(User));
            return View(new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.Name,
                    Price = i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity,
                    
                    
                }).ToList(),
                CargoPrice=7.000
            });
        }
        [HttpPost]
        public IActionResult AddtoCart(int productId, int quantity)
        {
            _cartService.AddToCart(_userManager.GetUserId(User), productId, quantity);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult DeleteFromCart(int productId)
        {
            var userId = _userManager.GetUserId(User);

            _cartService.DeleteFromCart(productId, userId);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteAllFromCart(int[] productIds)
        {
            var userId = _userManager.GetUserId(User);
            foreach (var productId in productIds)
            {
                _cartService.DeleteFromCart(productId, userId);

            }
            return RedirectToAction("Index");

        }
        public IActionResult Checkout()
        {
            var cart = _cartService.GetByUserId(_userManager.GetUserId(User));
            if (cart==null || cart.CartItems.Count()==0)
            {
                TempData.Put("message", new AlertMessage()
                    {
                        Title = "",
                        Message = "Yanlış işlem yaptınız.",
                        AlertType = "alert-warning"
                    });
                return RedirectToAction("Index","Cart");
            }
            var orderModel = new OrderModel();
            orderModel.CartModel = new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.Name,
                    Price = i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity,

                }).ToList(),
                CargoPrice=7.000

            };

            return View(orderModel);

        }


        private Payment PaymentProcess(OrderModel model)
        {
            Options options = new Options();
            options.ApiKey = "sandbox-rQch8hnDtHwbsrS1PeYhcKRLpbNPRFvr";
            options.SecretKey = "sandbox-A78oE89WVYT8bfOzCuiiLGDIN3fB4oC2";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";

            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = new Random().Next(100000000, 999999999).ToString();
            request.Price = model.CartModel.CartTotal().ToString("0.00",System.Globalization.CultureInfo.InvariantCulture);
            request.PaidPrice = model.CartModel.CartTotal().ToString("0.00",System.Globalization.CultureInfo.InvariantCulture);
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = new Random().Next(100000000, 999999999).ToString();
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = model.CardName;
            paymentCard.CardNumber = model.CardNumber;
            paymentCard.ExpireMonth = model.ExpirationMonth;
            paymentCard.ExpireYear = model.ExpirationYear;
            paymentCard.Cvc = model.Cvc;
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            // paymentCard.CardNumber = "5528790000000008";
            // paymentCard.ExpireMonth = "12";
            // paymentCard.ExpireYear = "2030";
            // paymentCard.Cvc = "123";

            Buyer buyer = new Buyer();
            buyer.Id = new Random().Next(111111111, 999999999).ToString(); 
            buyer.Name = model.FirstName;
            buyer.Surname = model.LastName;
            buyer.GsmNumber ="+90"+ model.Phone;
            buyer.Email = model.Email;
            buyer.IdentityNumber ="Tc Kimlik No İstenmiyor.";
            // buyer.LastLoginDate = "2015-10-05 12:43:35";
            // buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = model.Address;
            buyer.Ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            buyer.City = model.City;
            buyer.Country = "Türkiye";
            buyer.ZipCode = model.ZipCode;
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = model.FirstName +" "+ model.LastName;
            shippingAddress.City = model.City;
            shippingAddress.Country = "Türkiye";
            shippingAddress.Description = model.Address;
            shippingAddress.ZipCode = model.ZipCode;
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = model.FirstName +" "+ model.LastName;
            billingAddress.City = model.City;
            billingAddress.Country = "Türkiye";
            billingAddress.Description = model.Address;
            billingAddress.ZipCode = model.ZipCode;
            request.BillingAddress = billingAddress;



            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem basketItem;
            foreach (var item in model.CartModel.CartItems)
            {
                basketItem = new BasketItem();
                basketItem.Id = item.CartItemId.ToString();
                basketItem.Name = item.Name;
                var price = item.Price.Value*item.Quantity;
                if (basketItems.Count==model.CartModel.CartItems.Count)
                {
                    price= price+model.CartModel.CargoPrice;
                }
                basketItem.Price = price.ToString("0.00",System.Globalization.CultureInfo.InvariantCulture);
                basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                basketItem.Category1=_productService.GetByIdWithCategories(item.ProductId).ProductCategories.Where(i=>i.ProductId==item.ProductId).Select(i=>i.Category.Name)
                .FirstOrDefault().ToString();
                basketItems.Add(basketItem);
                
                Console.WriteLine(basketItem.Category1);
                

            }
            
            request.BasketItems = basketItems;
            return Payment.Create(request, options);
        }
        [HttpPost]
        public IActionResult Checkout(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var cart = _cartService.GetByUserId(userId);


                model.CartModel = new CartModel()
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Select(i => new CartItemModel()
                    {
                        CartItemId = i.Id,
                        ProductId = i.ProductId,
                        Name = i.Product.Name,
                        Price = i.Product.Price,
                        ImageUrl = i.Product.ImageUrl,
                        Quantity = i.Quantity

                    }).ToList(),
                    CargoPrice = cart.CargoPrice
                };

                var payment = PaymentProcess(model);

                if (payment.Status == "success")
                {
                    SaveOrder(model, payment, userId);
                    ClearCart(model.CartModel.CartId);
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Sipariş",
                        Message = "Siparişiniz Alınmıştır.",
                        AlertType = "alert-success"
                    });

                    return View("Success");
                }
                else
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Ödeme İşlemi",
                        Message = $"{payment.ErrorMessage}",
                        AlertType = "alert-danger"
                    });
                }


            }



            return View(model);
        }

        private void ClearCart(int cartId)
        {
             _cartService.ClearCart(cartId);
            
        }

        private void SaveOrder(OrderModel model, Payment payment, string userId)
        {
            var order = new Order();
            order.OrderNumber = new Random().Next(111111111, 999999999).ToString();
            order.OrderState = EnumOrderState.waiting;
            order.PaymentType = EnumPaymentType.BankCard;
            order.PaymentId = payment.PaymentId;
            order.ConversationId = payment.ConversationId;
            order.OrderDate = DateTime.Now;
            order.FirstName = model.FirstName;
            order.LastName = model.LastName;
            order.UserId = userId;
            order.Address = model.Address;
            order.Phone = model.Phone;
            order.Email = model.Email;

            order.OrderItems = new List<entity.OrderItem>();
            foreach (var item in model.CartModel.CartItems)
            {
                var orderItem = new entity.OrderItem()
                {
                    Price = (double)item.Price,
                    Quantity = item.Quantity,
                    ProductId = item.ProductId,
                };
                order.OrderItems.Add(orderItem);
            }
            _orderService.Create(order);
        }

        public IActionResult Success()
        {

            return View();
        }

        
        

    }
}
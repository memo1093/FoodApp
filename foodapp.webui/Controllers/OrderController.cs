using System;
using System.Collections.Generic;
using System.Linq;
using foodapp.business.Abstract;
using foodapp.webui.Identity;
using foodapp.webui.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace foodapp.webui.Controllers
{
    
    public class OrderController:Controller
    {
        private IOrderService _orderService;
        private UserManager<User> _userManager;

        public OrderController(IOrderService orderService, UserManager<User> userManager)
        {
            _orderService = orderService;
            _userManager = userManager;
        }

        public IActionResult GetOrders()
        {
            var userId = _userManager.GetUserId(User);
            var orders = _orderService.GetOrders(userId);
           

            var orderListModel = new List<OrderListModel>();
            OrderListModel orderModel;
            foreach (var order in orders)
            {
                orderModel = new OrderListModel();

                orderModel.OrderId=order.OrderId;
                orderModel.OrderNumber=order.OrderNumber;
                orderModel.OrderState=order.OrderState;
                orderModel.OrderDate=order.OrderDate;
                orderModel.FirstName=order.FirstName;
                orderModel.LastName=order.LastName;
                orderModel.Address=order.Address;
                orderModel.Phone=order.Phone;
                orderModel.Email=order.Email;
                orderModel.PaymentType=order.PaymentType;

                orderModel.OrderItems=order.OrderItems.Select(i=>new OrderItemModel(){
                    OrderItemId=i.OrderId,
                    ProductName=i.Product.Name,
                    Price=i.Price,
                    Quantity=i.Quantity,
                    ImageUrl=i.Product.ImageUrl
                    
                }).ToList();

                orderListModel.Add(orderModel);
                
            }


            return View("Orders",orderListModel.OrderByDescending(i=>i.OrderDate).ToList());
        }
    }
}
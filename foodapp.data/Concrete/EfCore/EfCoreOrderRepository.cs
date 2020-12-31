using System.Collections.Generic;
using System.Linq;
using foodapp.data.Abstract;
using foodapp.entity;
using Microsoft.EntityFrameworkCore;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order, FoodContext>, IOrderRepository
    {
        public List<Order> GetAllOrders()
        {
            using (var context = new FoodContext())
            {
                var orders = context.Orders.Include(i=>i.OrderItems).ThenInclude(i=>i.Product).AsQueryable();

                    
                
                return orders.ToList();
            }
            
        }

        public List<Order> GetOrder(string userId)
        {
            using (var context = new FoodContext())
            {
                var orders = context.Orders.Include(i=>i.OrderItems).ThenInclude(i=>i.Product).AsQueryable();

                if (!string.IsNullOrEmpty(userId))
                {
                    orders= orders.Where(i=>i.UserId==userId);
                }
                return orders.ToList();
            }
        }
    }
}
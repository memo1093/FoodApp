using System.Collections.Generic;
using foodapp.entity;

namespace foodapp.data.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetOrder(string userId);
        List<Order> GetAllOrders();
    }
}
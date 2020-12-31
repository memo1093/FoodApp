using System.Collections.Generic;
using foodapp.entity;

namespace foodapp.business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);
        List<Order> GetAllOrders();
        
    }
}
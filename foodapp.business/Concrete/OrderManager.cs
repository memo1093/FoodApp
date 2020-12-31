using System.Collections.Generic;
using foodapp.business.Abstract;
using foodapp.data.Abstract;
using foodapp.entity;

namespace foodapp.business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Create(Order entity)
        {
            _orderRepository.Create(entity);
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public List<Order> GetOrders(string userId)
        {
            return _orderRepository.GetOrder(userId);
        }
    }
}
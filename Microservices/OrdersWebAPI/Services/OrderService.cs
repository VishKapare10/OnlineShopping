using System.Collections.Generic;
using OrdersWebAPI.Models;
using OrdersWebAPI.Repositories;

namespace OrdersWebAPI.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _repo;
        public OrderService()
        {
             IOrderRepository repository=new OrderRepository();
             this._repo = repository;
        }

        public List<Order> GetOrders()
        {
            if (_repo != null)
            {   
                return _repo.GetOrders();
            }
            return null;
        }
        Order IOrderService.GetOrderById(int id)
        {
          return _repo.GetOrderById(id);
        }

        bool IOrderService.Insert(Order order)
        {
            return _repo.Insert(order); 
        }

        bool IOrderService.Update(Order order)
        {
            return _repo.Update(order); 
        }

        bool IOrderService.Delete(int id)
        {
           return _repo.Delete(id);
        }
    }
}
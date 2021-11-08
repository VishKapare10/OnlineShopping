using System;
using System.Collections.Generic;
using OrdersWebAPI.Models;

namespace OrdersWebAPI.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order GetOrderById(int id);
        bool Insert(Order order);
        bool Update(Order order);
        bool Delete(int id);
    }
}
using System;
using System.Collections.Generic;
using OrdersWebAPI.Models;

namespace OrdersWebAPI.Services
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        Order GetOrderById(int id);
        bool Insert(Order order);
        bool Update(Order order);
        bool Delete(int id);
    }
}
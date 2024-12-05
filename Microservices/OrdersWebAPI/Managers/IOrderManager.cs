
using System.Collections.Generic;
using OrdersWebAPI.Models;

namespace OrdersWebAPI.Repositories
{
    public interface IOrdersManager{
        List<Order> GetAll();
        Order GetById(int id);
        bool Insert(Order order);
        bool Update(Order order);
        bool Delete(int id);
    }
}
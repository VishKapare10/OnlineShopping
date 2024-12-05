using System.Collections.Generic;
using System;
using System.Linq;
using OrdersWebAPI.Models;
using OrdersWebAPI.Contexts;

namespace OrdersWebAPI.Repositories
{
    public class OrderManager : IOrdersManager
    {
        public bool Delete(int id)
        {
            using(var context = new CollectionContext())
            {
                context.Orders.Remove(context.Orders.Find(id));
                context.SaveChanges();
            }
            return true;
        }

        public List<Order> GetAll()
        {
            using (var context = new CollectionContext())
            {
             var orders = from order in context.Orders select order;
             return orders.ToList<Order>();
            }
        }

        public Order GetById(int id)
        {
            using (var context = new CollectionContext())
            {
             var order = context.Orders.Find(id);
             return order;
            }
        }

        public bool Insert(Order order)
        {
            using(var context = new CollectionContext())
            {
                context.Orders.Add(order);
                context.SaveChanges(); 
            }
            return true;
        }

        public bool Update(Order order)
        {
            using(var context = new CollectionContext())
            {
                var theOrder = context.Orders.Find(order.Id);
                theOrder.Id=order.Id;
                theOrder.CustomerId=order.CustomerId;
                theOrder.TotalAmount=order.TotalAmount;
                theOrder.Status=order.Status;
                theOrder.OrderDate=order.OrderDate;
                context.SaveChanges();
            }
            return true;
        }
    }
}
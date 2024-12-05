using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OrdersWebAPI.Models;

namespace OrdersWebAPI.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        
        IOrdersManager _ordManager;
        

        public OrderRepository(){
            _ordManager=new OrderManager();
        }

        public List<Order> GetOrders()
        {
                return _ordManager.GetAll();
        }
    
        public Order GetOrderById(int id)
        {
             return _ordManager.GetById(id);
            
        }
        public bool Insert(Order order){

             return  _ordManager.Insert(order);
        }

        public bool Update(Order order){
             return _ordManager.Update(order);
        }
        
        public bool Delete(int id){
            return  _ordManager.Delete(id);           
        }
    }
}
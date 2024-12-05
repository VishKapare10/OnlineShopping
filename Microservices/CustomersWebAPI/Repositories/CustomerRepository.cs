using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CustomerWebAPI.Models;

namespace CustomerWebAPI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        
        ICustomerManager _cusManager;
        

        public CustomerRepository(){
            _cusManager=new CustomerManager();
        }
        public List<Customer> GetCustomers()
        {
                return _cusManager.GetAll();
        }
    
        public Customer GetCustomerById(int id)
        {
             return _cusManager.GetById(id);
            
        }
        public bool Insert(Customer customer){
        return  _cusManager.Insert(customer);
        }
        public bool Update(Customer customer){
           
            return _cusManager.Update(customer);
        }
        
        public bool Delete(int id){
            

            return  _cusManager.Delete(id);
            
        }
    }
}
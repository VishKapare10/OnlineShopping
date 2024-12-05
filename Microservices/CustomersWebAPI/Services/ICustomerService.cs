using System;
using System.Collections.Generic;
using CustomerWebAPI.Models;

namespace CustomerWebAPI.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(int id);
    }
}
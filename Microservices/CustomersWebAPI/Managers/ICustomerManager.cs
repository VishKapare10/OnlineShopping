
using System.Collections.Generic;
using CustomerWebAPI.Models;

namespace CustomerWebAPI.Repositories
{
    public interface ICustomerManager{
        List<Customer> GetAll();
        Customer GetById(int id);
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(int id);
    }
}
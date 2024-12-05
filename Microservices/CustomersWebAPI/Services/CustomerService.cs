using System.Collections.Generic;
using CustomerWebAPI.Models;
using CustomerWebAPI.Repositories;

namespace CustomerWebAPI.Services
{
    public class CustomerService :ICustomerService
    {
        private ICustomerRepository _repo;
        public CustomerService()
        {
             ICustomerRepository repository=new CustomerRepository();
             this._repo = repository;
        }

        public List<Customer> GetCustomers()
        {
            if (_repo != null)
            {   
                return _repo.GetCustomers();
            }
            return null;
        }
        Customer ICustomerService.GetCustomerById(int id)
        {
          return    _repo.GetCustomerById(id);
        }

        bool ICustomerService.Insert(Customer customer)
        {
            return _repo.Insert(customer); 
        }

        bool ICustomerService.Update(Customer customer)
        {
            return _repo.Update(customer); 
        }

        bool ICustomerService.Delete(int id)
        {
           return _repo.Delete(id);
        }
    }
}
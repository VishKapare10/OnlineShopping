using System.Collections.Generic;
using CustomerWebAPI.Entities;


namespace CustomerWebAPI.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
    }
}
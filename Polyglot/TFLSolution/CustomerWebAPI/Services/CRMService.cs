using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using CustomerWebAPI.Entities;
using CustomerWebAPI.Helpers;

namespace CustomerWebAPI.Services
{ 
    public class CustomerService : ICustomerService
    {
         
    
        private List<Customer> _customers = new List<Customer>
        { 
            new Customer { Id = 1, Name = "Microsoft",  ContactPerson = "Bill Gates",   WebSite = "http://www.microsoft.com", Password = "bill"},
            new Customer { Id = 2, Name = "Oracle", ContactPerson = "Steve Smith", WebSite = "http://www.oracle.com", Password = "alan"} ,
            new Customer { Id = 3, Name = "IBM", ContactPerson = "Alan Border", WebSite = "http://www.ibm.com", Password = "steve"},
            new Customer { Id = 4, Name = "Infosys", ContactPerson = "Nandan Nilkeni", WebSite = "http://www.infosys.com", Password = "nandan"},
            new Customer { Id = 5, Name = "Wipro", ContactPerson = "Azim Premji", WebSite = "http://www.wipro.com", Password = "azim"},
        };

        public IEnumerable<Customer> GetAll()
        {
            return _customers.WithoutPasswords();
        }

        public Customer GetById(int id) 
        {
            var customer = _customers.FirstOrDefault(x => x.Id == id);
            return customer.WithoutPassword();
        }
    }
}
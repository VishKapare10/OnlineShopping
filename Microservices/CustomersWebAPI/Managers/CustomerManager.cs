using System.Collections.Generic;
using System;
using System.Linq;
using CustomerWebAPI.Models;
using CustomerWebAPI.Contexts;

namespace CustomerWebAPI.Repositories
{
    public class CustomerManager : ICustomerManager
    {
        public bool Delete(int id)
        {
            using(var context = new CollectionContext())
            {
                context.Customers.Remove(context.Customers.Find(id));
                context.SaveChanges();
            }
            return true;
        }

        public List<Customer> GetAll()
        {
            using (var context = new CollectionContext())
            {
             var customers = from prod in context.Customers select prod;
             return customers.ToList<Customer>();
            }
        }

        public Customer GetById(int id)
        {
            using (var context = new CollectionContext())
            {
             var customer = context.Customers.Find(id);
             return customer;
            }
        }

        public bool Insert(Customer customer)
        {
            using(var context = new CollectionContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges(); 
            }
            return true;
        }

        public bool Update(Customer customer)
        {
            using(var context = new CollectionContext())
            {
                var theCustomer = context.Customers.Find(customer.Id);
                theCustomer.Name =customer.Name;
                theCustomer.Location=customer.Location;
                theCustomer.Age=customer.Age;
                theCustomer.ContactNumber=customer.ContactNumber;
                theCustomer.Email=customer.Email;
                context.SaveChanges();
            }
            return true;
        }
    }
}
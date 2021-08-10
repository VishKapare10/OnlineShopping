using System;
using System.Data;
using System.Collections.Generic;

namespace CRM
{
     public  static class CustomerManager
    {
         public static List<Customer> GetAll() 
        {
            List<Customer> customers = new List<Customer>();
             customers=CustomerDBManager.GetAll();
            return customers;
        }

        public static Customer GetById(int customerId)
        {
            Customer theCustomer=null;
           theCustomer=CustomerDBManager.GetById(customerId);
            return theCustomer;
        }
        public static bool Delete(int customerId)
        {
            bool status = false;
            CustomerDBManager.Delete(customerId);
            return status;
        }   
        public static bool Update(Customer customer)
        {
            bool status = false;
             CustomerDBManager.Update(customer);
            return status;
        }
        public static bool Insert(Customer customer)
        {
            bool status = false;
            CustomerDBManager.Insert(customer);
            return status;
        }
  }
}
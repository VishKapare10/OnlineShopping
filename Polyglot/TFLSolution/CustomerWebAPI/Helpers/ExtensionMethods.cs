using System.Collections.Generic;
using System.Linq;
using CustomerWebAPI.Entities;

namespace CustomerWebAPI.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<Customer> WithoutPasswords(this IEnumerable<Customer> customers) 
        {
            if (customers == null) return null;
            return customers.Select(x => x.WithoutPassword());
        }

        public static Customer WithoutPassword(this Customer customer) 
        {
            if (customer == null) return null;
            customer.Password = null;
            return customer;
        }
    }
}
using System;
using System.Collections.Generic;

namespace DisconnectedDataAccessTest
{
    class Program
    {
        //Unit Test
        static void Main(string[] args)
        {
            //bool status=CustomerDBManager.Delete(110);
           
            Customer newCust=new Customer();
            newCust.Id=500;
            newCust.Name="Vishwambhar Kapare";
            newCust.Location="Pune";
            newCust.Age=25;
            newCust.ContactNumber="7188123421";
            newCust.Email="vish10kapare@gmail.com";

            bool status=CustomerDBManager.Insert(newCust);
            //bool status = CustomerDBManager.Insert(new Customer{Id=210,Name="Shubham Shirke",Location="Pune",Age=25,ContactNumber="7720037983",Email="vish10kapare@gmail.com"});

            /*Customer cust=new Customer();
            cust.Id=111;
            cust.Name="Shubham Shinde";
            cust.Location="Pune";
            cust.Age=25;
            cust.ContactNumber="7088123421";
            cust.Email="shubhamshinde@gmail.com";

            bool status=CustomerDBManager.Update(cust); */
            List<Customer> allCustomers=CustomerDBManager.GetAll();
            foreach(Customer customer in allCustomers){
                Console.WriteLine(customer.Id+" "+customer.Name+" "+customer.Location);
            }
        }
    }
}

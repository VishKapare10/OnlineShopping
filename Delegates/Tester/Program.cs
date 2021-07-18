using System;
using Catalog;
using CRM;
using OrderProcessing;
using Membership;
using Banking;
using PaymentProcessing;


namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {

            // data types: 
            //      Inbuilt types :int, double, char, bool, long, short
            
            //      User defined Types:
            //                          Class:
            //                                  to create object we use class
            //                          interface:
            //                                  to hide implementation of class
            //
            //                          enumeration, structure, , ,
            //                          delegate, event
            /*int count=50;
            double   Predicate=34.5;
            char     ch  = 'R';
            bool    status=true;*/

            Product p1=new Product();
            p1.Id=34;
            p1.Title="BMW";
            p1.Description="Powerful Car";
            p1.UnitPrice=3000000;
            p1.Quantity=1200;

            Console.WriteLine("Product id: "+ p1.Id);
            Console.WriteLine("Product Title: "+p1.Title);
            Console.WriteLine( "Product Description: "+p1.Description);
            Console.WriteLine("Product Unit Price: "+ p1.UnitPrice);
            Console.WriteLine("Product Quantity: "+ p1.Quantity);        


            Customer customer=new Customer(32,"Ganesh Shinde", 
                                            "ganesh.shinde@gmail.com",
                                            "9881265483");

            Order theOrder=new Order();
            theOrder.Id=65;
            theOrder.OrderDate=DateTime.Now;
            theOrder.Status="Initiated";
            theOrder.TotalAmount=45000;
            Console.WriteLine(theOrder.Status);

            User newUser=User.Register();   // static method call
        
            Console.WriteLine("New User Created Successfully");
            Console.WriteLine("New User Details :");
            Console.WriteLine( "User Login:" + newUser.LoginName);
            Console.WriteLine( "User Password:" + newUser.Password);

            newUser.SendEmailNotification(); // non static method call

            Account acct1=Account.Create(56000);
            Account acct2=Account.Create(46000);

            double acct1Balance=acct1.Balance;
            Console.WriteLine("Balance 1 ="+ acct1Balance);

            double acct2Balance=acct2.Balance;
            Console.WriteLine("Balance 2 ="+ acct2Balance);

            Product product=new Product();         
                                     // yes
            //       remote controller- loosely Coupled----TV

            IAccontDetails details=new SavingAccountDetails();    // yes
            IAccontDetails details2=new SalaryAccountDetails();
            IAccontDetails details3=new RecurringAccountDetails();
            IAccontDetails details4=new CurrentAccountDetails();

            // Polymorphism
            // define interface
            // create derived classes from inteface inheritance
            

            details.CreateAccount(); // SavingAcccountDetails 
            details2.CreateAccount();// SalaryAccountDetails
            details3.CreateAccount();// RecurringAccount
            details4.CreateAccount(); //CurrentAccount

            details4.ShowAccountDetails();




            IAccontDetails iDetails=new SavingAccountDetails();
            //IAccontDetails iDetails2=new IAccontDetails();
             
            Account acct3=iDetails.CreateAccount();
            double acct3Balance=acct3.Balance;
            iDetails.ShowAccountDetails();

            Console.WriteLine("Balance 3 ="+ acct3Balance);

           /*CreditCardPayment x = new CreditCardPayment(2.12, "George bush","11/27", "************1234");
		    CashPayment p = new CashPayment(20.03);
            CreditCardPayment y = new CreditCardPayment(11.22, "Trump Henry","22/11","987654321");
		    CashPayment q = new CashPayment(55.12);

            x.paymentDetails();
            p.paymentDetails();
            y.paymentDetails();
            q.paymentDetails();
	       */
           //Console.WriteLine("Hello World!");
        }
    }
}

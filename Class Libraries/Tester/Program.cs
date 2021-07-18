﻿using System;
using Catalog;
using CRM;
using OrderProcessing;
using Membership;
using Banking;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {

            Product p1=new Product();
            p1.Id=34;
            p1.Title="Mercedes";
            p1.Description="Powerful Car";
            p1.UnitPrice=3000000;
            p1.Quantity=1200;

            Console.WriteLine( p1.Id);
            Console.WriteLine( p1.Title);
            Console.WriteLine( p1.Description);
            Console.WriteLine( p1.UnitPrice);
            Console.WriteLine( p1.Quantity);        


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

            IAccontDetails iDetails=new SavingAccount();
            //IAccontDetails iDetails2=new IAccontDetails();
             
            Account acct3=iDetails.CreateAccount();
            double acct3Balance=acct3.Balance;
            iDetails.ShowAccountDetails();

           Console.WriteLine("Balance 3 ="+ acct3Balance);
          
        }
    }
}

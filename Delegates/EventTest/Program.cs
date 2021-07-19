using System;
using Banking;
using CentralGovtAdministration;

namespace EventTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Handler handler=new Handler();
            //NDAGovtHandler handler=new NDAGovtHandler();
            UPAGovtHandler handler=new UPAGovtHandler();
            Account acct1 = new Account(10000);
            //at runtime register event handlers with events associated with Account
            //Subscribing callback functions to event of account
            acct1.overBalance+=new Operation(handler.PayIncomeTax);
            acct1.overBalance+=new Operation(handler.PayServiceTax);
            //acct1.underBalance+= new Operation(handler.BlockAccount);

            acct1.Balance=56000;
            Console.WriteLine("Before first deposit");
            acct1.Deposit(200000);
            Console.WriteLine("After first deposit");

            acct1.overBalance+=new Operation(handler.PayProfessionalTax);
            acct1.Deposit(12000);

            Console.WriteLine("For another account instance...");
            Console.WriteLine("NDA");
            NDAGovtHandler ndaHandler = new NDAGovtHandler(); 
            Account acct2 = new Account(37000);
            acct2.overBalance+=new Operation(ndaHandler.PayServiceTax);
            acct2.Deposit(230000);

        }
    }
}

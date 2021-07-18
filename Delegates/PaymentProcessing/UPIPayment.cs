using System;


// Child Class
// Derived Class
// Sub Class

namespace PaymentProcessing{
    public class UPIPayment : Payment
    {

        public UPIPayment(double val) 
        {   
            this.cash=val;
        }

        public override  void PaymentDetails()
        {
            Console.WriteLine("The payment of cash:  $" + this.cash);
        }
    }

}
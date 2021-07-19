using System;

namespace Banking
{

    // used as blueprint for creating number of instances
    
    public delegate void Operation();
    //Publisher Class
    public class Account
    {
        //Auto Property
        public double Balance{get;set;}
        public Account(double amount){
            this.Balance=amount;
        }

        public event Operation underBalance;
        public event Operation overBalance;

        // don't repeat your self:

        public  void Monitor(){
            if( this.Balance < 5000){
                // static linking of behaviour
                // applying Dynamic linking
                // Handler.BlockAccount();
                //raise an event
                underBalance();
            }
            else if(this.Balance>=250000){
                // static linking of behaviour
                // appylying Dynamic Linking
                //  Handler.PayIncomeTax();
                //raise an event
                overBalance();
            }
        }
        public void Deposit(double amount){
            this.Balance+=amount;
            Monitor();
          
        }

        public void Withdraw(double amount){
            this.Balance-=amount;
            Monitor();
        }

        public static Account Create(double initialAmount){
            Account account=new Account(initialAmount);
            return account;
        }
        
    }
}

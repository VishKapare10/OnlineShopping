using System;

namespace Banking
{

    // used as blueprint for creating number of instances
    
    public class Account
    {
        //Auto Property
        public double Balance{get;set;}
        public Account(double amount){
            this.Balance=amount;
        }

        // don't repeat your self:

        public  void Monitor(){
            if( this.Balance < 5000){
                // static linking of behaviour
                // applying Dynamic linking
               // Handler.BlockAccount();
            }
            else if(this.Balance>=250000){
                // static linking of behaviour
                // appylying Dynamic Linking

              //  Handler.PayIncomeTax();
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

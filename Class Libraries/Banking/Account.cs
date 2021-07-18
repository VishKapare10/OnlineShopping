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
        public void Deposit(double amount){
            this.Balance+=amount;
        }
        public void Withdraw(double amount){
            this.Balance-=amount;
        }
        public static Account Create(double initialAmount){
            Account account=new Account(initialAmount);
            return account;
        }

    }
}

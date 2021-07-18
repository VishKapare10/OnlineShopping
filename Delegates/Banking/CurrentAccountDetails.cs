using System;
namespace Banking{
    public class CurrentAccountDetails:IAccontDetails{

        void IAccontDetails.ShowAccountDetails(){
            Console.WriteLine("Current :Show Account Details");
      }

        Account IAccontDetails.CreateAccount(){  

            Console.WriteLine("Creating Current Account instance");
            // Create Current Account 
            return Account.Create(20000);
        }

        
    }
}
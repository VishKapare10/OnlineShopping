using System;


namespace Banking{

   public class SavingAccount:IAccontDetails{

      void IAccontDetails.ShowAccountDetails(){
                Console.WriteLine("Show Account Details");
      }

        Account IAccontDetails.CreateAccount(){   
            return Account.Create(15000);
        }

    }
}
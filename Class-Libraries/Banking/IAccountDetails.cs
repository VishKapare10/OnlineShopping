using System;
namespace Banking{

    // used for defining contract, Policy, Agreement
    // end point
    // can not  be used to create instnace
    // intefaces are implemented by classes
    // 
    public interface IAccontDetails
    {
        void ShowAccountDetails();
        Account CreateAccount();
    }
}
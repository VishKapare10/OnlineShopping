using System;
namespace CentralGovtAdministration

{
    public class UPAGovtHandler{

        public void PayIncomeTax(){
             Console.WriteLine( "Income tax has been deducted 5%");
        }

        public void PayServiceTax(){
             Console.WriteLine( "Service tax has been deducted 8%");
        }
       
        public void PayProfessionalTax(){
             Console.WriteLine( "Professional tax has been deducted 35%");
        }
    }
}
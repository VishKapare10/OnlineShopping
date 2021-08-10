using System;

namespace CRM
{
    public class Customer
    {

        // Data + behaviour
        public int Id{get;set;}
        public string Name{get;set;}
        public string Location {get;set;}
        public int Age{get;set;}
        public string ContactNumber{get;set;}
        public string Email{get;set;}

        public Customer() {
            this.Id=1;
            this.Name="Ravi Tambade";
            this.ContactNumber="9881735801";
            this.Email="ravi.tambade@transflower.in";
            this.Location="Pune";
            this.Age=40;
        }

        public Customer(int id, string name, string contact, string email, string location, int age){
            this.Id=id;
            this.Name=name;
            this.ContactNumber=contact;
            this.Email=email;
            this.Location=location;
            this.Age=age;
        }

        ~Customer(){
            // for auto Cleanup 
            
        }
    }
}

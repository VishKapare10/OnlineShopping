using System;

namespace Membership
{
    public class User
    {
        public int Id{get; set;}
        public string LoginName{get;set;}
        public string Password{get;set;}
        public static User Register(){

            User newUser=new User();
            newUser.LoginName="vishk";
            newUser.Password="vish@9999#";
            return newUser;
        }


        // Non static method
        // member function
        public string SendEmailNotification()
        {
        
            // after processing logic
            return "Email is sent to Users official Email Id";

        }



    }
}



/* C++----- Object Orientation
            Major Pillars
                // Abstraction,
                // Encapsulation
                // Inheritance
            Minor Pillars
                 Modularity  ( Package---- namespace)
   */
using System;   // pre-Defined namespace  from .NET core SDK
                // SDK :  Software Development Kit
                //      tools, libraries, 
                //      docs:
                // Tool Kit:
                //
                /*namespace
								Collection of Types
								  1.Primitive Types
									int, float, double, boolean, char
								  2.User Defined Types
										Classes
											member variables
											member functions
											static functions
										Interfaces
										Delegates
										Events
										Structure
										Enumeration

                */
// User defined namespace
namespace Test
{

    // Abstraction:
    // Identify essential characteristics of people by using class Person
    // Concrete class

    class  Person{
        // member variables
        public string firstName;
        public string lastName;
        public int age;

        // member functions
        // default constructor
        public Person(){
                firstName="Ravi";
                lastName="Tambade";
                age=46;
        }

        // Parameterized contstructor
        public Person(string fname, string lname, int ag){
            this.firstName=fname;
            this.lastName=lname;
            this.age=ag;
        }

        // static functions


    }

//Ultility Class  , Helper class


 // Abstraction: another abstration
  class Handler
  {

      // Software: for processing data
      //           retrive data 
      //           process data

      // CRUD Operations
      // C : Create 
      // R : Read
      // U : Update
      // D : Delete

      public static void ProcessGetRequest(){
        Console.WriteLine("Processing Get Request logic");
      }

     public static void ProcessPOSTRequest(){
        Console.WriteLine("Processing Get POST logic");
      }

       public static void ProcessUpdateRequest(){ 
      }


      public void ProcessDeleteRequest(){

      }

  }


    // one Abstraction

    class Program
    {

        static void Display(){
            Console.WriteLine("Processing Display logic");
        }

        static void Show(){
            Console.WriteLine("Processing Show logic");
        }

        // Entry Point function
        static void Main(string[] args)
        {
            int count=45;
            count=count+1;
         
            string name="Vishwambhar Kapare";          

         
            Console.WriteLine("My Name =" + name);
            Show();  // invoking external logic

            Display();
            // Utility
            Handler.ProcessGetRequest();
            Handler.ProcessPOSTRequest();

            //instances
            // deal with data
            // deal with information
            // deal with knowledge
            // deal with intelligence
            Person person1=new Person("Sachin", "Tendulkar",48);

            Person person2=new Person("Virendra", "Sehvag",49);
        

            Console.WriteLine(person1.firstName + "  " + person1.lastName);
            Console.WriteLine(person2.firstName + "  " + person2.lastName);
        }
    }
}

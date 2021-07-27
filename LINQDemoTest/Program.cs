using System;

namespace LINQDemoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Program theProgram = new Program();
            Console.WriteLine("Demo for reflection");
            Type theType1 = theProgram.GetType(); //reflection
            Console.WriteLine("Type of theProgram variable:"+theType1.Name);

            var instance = new {Id=34,
                                firstName="Vishwambhar",
                                lastName="Kapare",
                                emailAddress="vish10kapare@gmail.com",
                                contactNumber="7720037983",
                                Location=new{
                                    LandMark="Near Karvande Hospital",
                                    City="Newasa",
                                    State="Maharashtra",
                                    Country="India"
                                }
                                };

            Type theType2 = instance.GetType();
            Console.WriteLine("Type of the theType2 is:"+theType2.Name);

            Console.WriteLine("Demo for annonymous data type");
            Console.WriteLine(instance.firstName+" "+instance.lastName);
            Console.WriteLine(instance.Location.Country);
            Console.WriteLine(instance.Location.State);
            Console.WriteLine(instance.Location.City);
            Console.WriteLine(instance.Location.LandMark);
        }
    }
}

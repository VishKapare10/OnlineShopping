using System;

namespace ExtensionMethodTest
{
    //Block inheritance for your class
    public sealed class MathsHelper{

        public int Addition(int num1, int num2){
            return num1+num2;
        }
        public int Substraction(int num1, int num2){
            return num1-num2;
        }

    }
    public class Person{

        public string GetFullName(){
            return "Vishwambhar Kapare";
        }
    }
    public static class UtilityManager{

        public static int Multiplication(this MathsHelper m,int num1, int num2){
                    return num1*num2;
                }
        public static int Division(this MathsHelper m,int num1, int num2){
                    return num1/num2;
                }
        public static string GetCitizenshipDetails(this Person p){
            return "Indian";

        }
        public static string GetStarPrefix(this string name){
            return "****"+name;
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathsHelper mathsHelper=new MathsHelper();
            int num1=100;
            int num2=10;
            Console.WriteLine("Addition: "+mathsHelper.Addition(num1,num2));
            Console.WriteLine("Substraction: "+mathsHelper.Substraction(num1,num2));
            Console.WriteLine("Multiplication: "+mathsHelper.Multiplication(num1,num2));
            Console.WriteLine("Division: "+mathsHelper.Division(num1,num2));


            Person thePerson= new Person();
            Console.WriteLine("Person Name: "+thePerson.GetFullName()); //Instance Method
            Console.WriteLine("Person Citizenship: "+thePerson.GetCitizenshipDetails()); //Extension Method

            string state="Maharashtra";
            Console.WriteLine("State with prefix: "+state.GetStarPrefix());
        }
    }
}

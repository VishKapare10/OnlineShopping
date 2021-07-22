using System;
using System.Linq;
using System.Collections.Generic;

namespace AnalyticsTest
{
    public class Person{
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int Age {get;set;}
    }
    class Program
    {
        static void FindAllNumbersDividedby2(){
            List<int>list=new List<int>(){1,2,3,4,5,6};
            List<int>evenNumbers=list.FindAll(x=>(x%2)==0);

            foreach(var num in evenNumbers){
                Console.Write("{0} ",num);
            }
            Console.WriteLine();
        }

        static void ShowAllNames(){
            List<Person>participants= new List<Person>(){
                new Person{ FirstName ="Vishwambhar",LastName="Kapare",Age=25},
                new Person{ FirstName ="Abhay",LastName="Kapare",Age=25},
                new Person{ FirstName ="Pratik",LastName="Takawale",Age=28},
                new Person{ FirstName ="Kiran",LastName="Muluk",Age=26},
                new Person{ FirstName ="Akash",LastName="Chavan",Age=25},

            };
            var peopleResult=participants.Select(x=> new {
                Age=x.Age,
                FirstName=x.FirstName,
                LastNameCharacter=x.LastName[0]
                });

            foreach(var person in peopleResult){
                Console.WriteLine(person);
            }
        }
        
        static void GetReport(){
            string[] students = new string[]{
                "Abhay","Vishwambhar","Shubham","Akshata","Neha","Nikita","Suyash","Sankalp",
                "Shrushti","Diksha","Siddhi"
            };
            /*var filterNameByChar=students.Where(n=>n.Contains('i'));
            var NamesOrderBy=filterNameByChar.OrderBy(n=>n.Length);
            var InUpperCase=NamesOrderBy.Select(n=>n.ToUpper());
            */
            var InUpperCase=students.Where(n=>n.Contains('i')).OrderBy(n=>n.Length).Select(n=>n.ToUpper());
            Console.WriteLine("\nStudents names containing i Increasing order in Upper case");
            foreach(var item in InUpperCase){
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            FindAllNumbersDividedby2();
            ShowAllNames();
            GetReport();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
//using MySqlConnector;

namespace AnalyticsTest
{
    public class Person{
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int Age {get;set;}
    }
    public class Product
    {
        public  int Likes{get;set;}
        public int Id{get;set;}
        public string Title {get;set;}
        public string Description{get;set;}
        public string ImageUrl { get; set;}

        public string Category { get; set;} 
        public double UnitPrice{ get; set;}
        public int Quantity{get;set;}

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
        public static void TakeThree(){
            int[] numbers={23,56,77,89,99,90};
            var first3numbers=numbers.Take(3);
            foreach(var n in first3numbers){
                Console.WriteLine(n);
            }
        }

        public static void Skip(){
            int[] numbers={34,56,77,78,98,90,99,12,10,9};
            var allButFirst4numbers=numbers.Skip(4);
            Console.WriteLine("All but first 4 numbers");
            foreach(var n in allButFirst4numbers){
                Console.WriteLine(n);
            }

        }

        public static IEnumerable<String>GetFruitsOrderBy(){
            string[] fruits={"cherry","mango","apple","banana","blueberry"};
            //LINQ
            var sortedFruits=from fruit in fruits orderby fruit descending select fruit;
            return sortedFruits;
            
        }

        public static void SimpleUnion(){
            int[] numA={0,2,4,6,7,8,9,10};
            int[] numB={1,3,5,6,16,17,19};

            var uniqueNumbers=numA.Union(numB);
            Console.WriteLine("Unique numbers from both the arrays:");
            foreach(var n in uniqueNumbers){
                Console.WriteLine(n);
            }

        }
        public static void SimpleIntersect(){
            int[] numA={0,2,4,6,7,8,9,10};
            int[] numB={1,3,5,6,7,8,16,17,19};

            var commonNumbers=numA.Intersect(numB);
            Console.WriteLine("Common numbers from both the arrays:");
            foreach(var n in commonNumbers){
                Console.WriteLine(n);
            }

        }

        public static void SimpleExcept(){
            int[] numA={0,2,4,6,7,8,9,10};
            int[] numB={1,3,5,6,7,8,16,17,19};
            IEnumerable<int> aOnlyNumbers=numA.Except(numB);
            Console.WriteLine("Numbers in first array but not in second array:");
            foreach(var n in aOnlyNumbers){
                Console.WriteLine(n);
            }
             
        }

        public static void ToSimpleList(){
            string[] words={"cherry","apple","blueberry"};
            var sortedWords= from w in words orderby w select w;
            var wordList=sortedWords.ToList();
            Console.WriteLine("The sorted word list");
            foreach(var w in wordList){
                Console.WriteLine(w);
            }
        }

        public static IEnumerable<Product> ToDictionary(){
            var scoreRecords= new[]{
                new {Name="Ankur",Score = 89},
                new {Name="Vishwambhar",Score = 91},
                new {Name="Rutuja",Score = 90},
                new {Name="Tukaram",Score = 80},
                new {Name="Neha",Score = 82},
            };
            var scoreRecordsDict=scoreRecords.ToDictionary(sr => sr.Name);
            return scoreRecordsDict as IEnumerable<Product>;

        }

        public static IEnumerable<Product> GetAllProducts(){
            List<Product> allProducts=new List<Product>();
            allProducts.Add(new Product{Id= 101,Title="Gerbera",Quantity=20000,Description="Beautiful Flower",Category="Flower",UnitPrice=30,Likes=11000,ImageUrl="images/Gerbera.jpg"});
            allProducts.Add(new Product{Id= 102,Title="Tulip",Quantity=20500,Description="Kashmiri Flower",Category="Flower",UnitPrice=150,Likes=75000,ImageUrl="images/Tulip.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Rose",Quantity=20050,Description="Wedding Flower",Category="Flower",UnitPrice=50,Likes=45600,ImageUrl="images/Rose.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Jasmine",Quantity=23000,Description="Beautiful Flower",Category="Flower",UnitPrice=55,Likes=35000,ImageUrl="images/Jasmine.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Lily",Quantity=0,Description="Beautiful Flower",Category="Flower",UnitPrice=100,Likes=45000,ImageUrl="images/Lily.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Croton",Quantity=25000,Description="Indoor Plant",Category="Plant",UnitPrice=60,Likes=19000,ImageUrl="images/Croton.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Coconut",Quantity=24000,Description="Best tree",Category="Tree",UnitPrice=80,Likes=18000,ImageUrl="images/Coconut.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Mango",Quantity=21000,Description="Best fruit",Category="Fruit",UnitPrice=90,Likes=16000,ImageUrl="images/Mango.jpg"});

            return allProducts;
        }
         public static IEnumerable<Product> GetAllProductsFromMySqlDatabase(){
            List<Product> allProducts=new List<Product>();
            //Data Access Logic
            //Querying against mySQL Database.
            /*3. understand Data Object Model for database connectivity
			Connection :	establish connection with database
				   :    connection string

			Command	   : command string, command type
			CommandBuilder :
			DataReader : read data like cursor
				    forward only recordset
			Adpater:    helping to fetch data in offline mode
			DataSet:    collection of Data Tables
			DataTable:  collection of Rows
			DataRow :   actual record */
            //ADO .NET object model
            /*
            1. Define connection string
            2.Create instance of Connection class
            3.Create instance of Command class
            4.Open connection
            5. Execute Command
            6. Get result set and iterate result set using foreach loop
            7.Create Collection of products by fetching data from result set
            8.Close connection
            */
            string connectionString = @"server=127.0.0.1;Uid=root;database=tap;Pwd=Know@9999#";
            MySqlConnection connection=new MySqlConnection(connectionString);
            
            return allProducts;
        }

           public static IEnumerable<Product> GetAllProductsFromMongoDBDatabase(){
            List<Product> allProducts=new List<Product>();
            //Data Access Logic
            //Querying against mySQL Database.
            return allProducts;
        }

        public static IEnumerable<Product> GetAllProductsFromOracleDatabase(){
                    List<Product> allProducts=new List<Product>();
                    //Data Access Logic
                    //Querying against mySQL Database.
                    return allProducts;
                }

        public static IEnumerable<Product> GetAllProductsFromJSONFile(){
            List<Product> allProducts=new List<Product>();
            //Data Access Logic using JSON Serilization
            //Querying against mySQL Database.
            return allProducts;
        }

        public static IEnumerable<Product> GetAllProductsFromMongoDB(){
            List<Product> allProducts=new List<Product>();
            //Data Access Logic using some MongoDB Connector. 
            //Querying against MongoDB Database.
            return allProducts;
        }
        
        public static IEnumerable<Product> GetAllProductsOrderBy(){
            //IEnumerable<Product> products= GetAllProducts();
            IEnumerable<Product> products= GetAllProductsFromMongoDB();
            var sortedProducts=from product in products orderby product.Quantity select product;
            return sortedProducts;
        }   
        
        public  static IEnumerable<Product> GetSoldOutProducts(){
                IEnumerable<Product> products= GetAllProducts();
                var soldOutProducts=from prod in products where  prod.Quantity == 0 select prod;
                return soldOutProducts; 
        }

        public  static IEnumerable<Product> GetProductsInStockLessThan(int amount){
                IEnumerable<Product> products= GetAllProducts();
                var expensiveInStockProducts=from prod in products 
                                             where  prod.Quantity > 0 & prod.UnitPrice> amount
                                             select prod;
                return expensiveInStockProducts; 
        }

        public static dynamic GetProductDetails(){
                IEnumerable<Product> products= GetAllProducts();
                var productInfos= from prod in products
                                  select new { prod.Title, prod.Description, prod.UnitPrice,prod.Quantity};
                return productInfos;
        }

        public  static IEnumerable<Product> GetProductsDistinct(){
                IEnumerable<Product> products= GetAllProducts();
                var uniqueItems=(from prod in products 
                                             select prod.Title).Distinct();
                                            
                return uniqueItems as IEnumerable<Product>; 
        }

        public  static IEnumerable<Product> GetProductsCount(){
                IEnumerable<Product> products= GetAllProducts();
                var categoryCounts=from prod in products 
                                 group prod by prod.Category into prodGroup
                                 select new { Category = prodGroup.Key, GetProductsCount=prodGroup.Count()};
                                            
                return categoryCounts as IEnumerable<Product>; 
        }
        static void Main(string[] args)
        {
            FindAllNumbersDividedby2();
            ShowAllNames();
            GetReport();
            TakeThree();
            Skip();
            IEnumerable<string> fruits=GetFruitsOrderBy();
            foreach(string fruit in fruits){
                Console.WriteLine(fruit);
            }
            SimpleUnion();
            SimpleIntersect();
            SimpleExcept();
            Console.WriteLine("Sold out products");
            IEnumerable<Product> soldOutProducts=GetSoldOutProducts();
            foreach(Product theProduct in soldOutProducts){
                Console.WriteLine(theProduct.Title+" "+theProduct.UnitPrice+" "+theProduct.Quantity);
            }
        }
    }
}

using System;
//MongoDB.Driver  
using MongoDB.Bson;  
using MongoDB.Driver; 

namespace StudentsMongodbCRUDTest
{   
    public class Customer  
    {  
        public ObjectId Id { get; set; }  
        public string FirstName { get; set; }  
        public string LastName { get; set; }  
        public string City { get; set; }  
        public string Age { get; set; }  
    }  
    public class Program
    {
        protected static IMongoClient client;  
        protected static IMongoDatabase database;  

        //Data Entry Screen
        //Form  :CUI form
        // Input screen ------- UI---Presentation Layer
        public static Customer GetCustomer()  
        {  
            Console.WriteLine("Please enter customer first name : ");  
            string firstName = Console.ReadLine();  
  
            Console.WriteLine("Please enter customer last name : ");  
            string lastName = Console.ReadLine();  
  
            Console.WriteLine("Please enter customer age : ");  
            string age = Console.ReadLine();  
  
            Console.WriteLine("Please enter city name : ");  
            string city = Console.ReadLine();  
  
            Customer customer = new Customer()  
            {  
                FirstName = firstName,  
                LastName = lastName,  
                Age = age,  
                City = city
            };  
              return customer;  
        }  
        
        public static void CRUDwithMongoDb()  
        {  
            client = new MongoClient();  
            database = client.GetDatabase("ECommerceApplication");  
            var collection = database.GetCollection<Customer>("Customers");  
  
            Console.WriteLine("Press select your option from the following\n1 - Insert\n2 - UpdateOne Document\n3 - Delete\n4 - Read All\n");  
            string userSelection = Console.ReadLine();  
  
            switch (userSelection)  
            {  
                case "1":   
                    //Insert  
                    collection.InsertOne(GetCustomer());  
                    break;  
  
                case "2":   
                    //Update  
                    var obj1 = GetCustomer();  
  
                    collection.FindOneAndUpdate<Customer>  
                        (   Builders<Customer>.Filter.Eq("FirstName", obj1.FirstName),  
                            Builders<Customer>.Update.Set("LastName", obj1.LastName).Set("City", obj1.City).Set("Age", obj1.Age));  
                    break;  
  
                case "3":   
                    //Find and Delete  
                    Console.WriteLine("Please Enter the first name to delete the record(so called document) : ");  
                    var deletefirstName = Console.ReadLine();  
                    collection.DeleteOne(s => s.FirstName == deletefirstName);  
                    break;  
  
                case "4":   
                    //Read all existing document  
                    var all = collection.Find(new BsonDocument());  
                    Console.WriteLine();  
  
                    foreach (var i in all.ToEnumerable())  
                    {  
                        Console.WriteLine(i.Id + "  " + i.FirstName + "\t" + i.LastName + "\t" + i.Age + "\t" + i.City);  
                    }  
                    break;  
  
                default:  
                    Console.WriteLine("Please choose a correct option");  
                    break;  
            }  
  
            //To continue with Program  
            Console.WriteLine("\n--------------------------------------------------------------\nPress Y for continue...\n");  
            string userChoice = Console.ReadLine();  
  
            if (userChoice == "Y" || userChoice == "y")  
            {  
                CRUDwithMongoDb();  
            }  
        }  

        static void Main(string[] args)
        {
            CRUDwithMongoDb();
        }
    }
}
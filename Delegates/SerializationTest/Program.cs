using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SerializationTest
{
    [Serializable]
     public class Product{
        public  int Likes{get;set;}
        public int Id{get;set;}
        public string Title {get;set;}
        public string Description{get;set;}
        public string ImageUrl { get; set;}
        public double UnitPrice{ get; set;}
        public int Quantity{get;set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product theProduct=new Product();
            theProduct.Id= 101;
            theProduct.Title="Gerbera";
            theProduct.Likes=10000;
            theProduct.Quantity=20000;
            theProduct.Description="Beautiful Flower";
            theProduct.UnitPrice=50;
            theProduct.ImageUrl="images/Gerbera.jpg";

            Product theProduct1=new Product();
            theProduct1.Id= 102;
            theProduct1.Title="Tulip";
            theProduct1.Likes=15000;
            theProduct1.Quantity=20000;
            theProduct1.Description="Kashmiri Flower";
            theProduct1.UnitPrice=30;
            theProduct1.ImageUrl="images/Tulip.jpg";

            List<Product>products= new List<Product>();
            /*products.Add(theProduct);
            products.Add(theProduct1);*/

            products.Add(new Product{Id= 101,Title="Gerbera",Quantity=20000,Description="Beautiful Flower",UnitPrice=50,Likes=11000,ImageUrl="images/Gerbera.jpg"});
            products.Add(new Product{Id= 102,Title="Tulip",Quantity=20500,Description="Kashmiri Flower",UnitPrice=50,Likes=75000,ImageUrl="images/Tulip.jpg"});
            products.Add(new Product{Id= 101,Title="Rose",Quantity=20050,Description="Wedding Flower",UnitPrice=50,Likes=45600,ImageUrl="images/Rose.jpg"});
            products.Add(new Product{Id= 101,Title="Jasmine",Quantity=23000,Description="Beautiful Flower",UnitPrice=50,Likes=35000,ImageUrl="images/Jasmine.jpg"});
            products.Add(new Product{Id= 101,Title="Lily",Quantity=20040,Description="Beautiful Flower",UnitPrice=50,Likes=45000,ImageUrl="images/Lily.jpg"});
            products.Add(new Product{Id= 101,Title="Croton",Quantity=25000,Description="Indoor Plant",UnitPrice=50,Likes=19000,ImageUrl="images/Croton.jpg"});
            products.Add(new Product{Id= 101,Title="Coconut",Quantity=24000,Description="Best tree",UnitPrice=50,Likes=18000,ImageUrl="images/Coconut.jpg"});
            products.Add(new Product{Id= 101,Title="Mango",Quantity=21000,Description="Best fruit",UnitPrice=50,Likes=16000,ImageUrl="images/Mango.jpg"});

            //Presentation Logic
            foreach (Product product in products){
                //Data binding
                Console.WriteLine($"Product : {product.Title} : {product.Description} : {product.Likes}");
            }

            //Serialization
            try{
                Stream stream=new FileStream("Products.bin",FileMode.Create,FileAccess.Write,FileShare.None);
                BinaryFormatter formatter=new BinaryFormatter();
                formatter.Serialize(stream,products);
                stream.Close();
            }   
            catch(Exception exp){
                Console.WriteLine(exp);
            }
            finally{

            }


            Console.WriteLine("Deserialization...");
            //Deserialization
            try{
              
                BinaryFormatter formatter=new BinaryFormatter();
                Stream dstream = new FileStream("Products.bin",FileMode.Open,FileAccess.Read,FileShare.Read);

                List<Product> productsFromFile=( List<Product>)formatter.Deserialize(dstream);
                foreach (Product product in productsFromFile){
                    //Data binding
                    Console.WriteLine($"Product : {product.Title} : {product.Description} : {product.Likes}");
                }
                dstream.Close();
            }   
            catch(Exception exp){
                Console.WriteLine(exp);
            }
            finally{

            }


            //Serialization using Json File
            try{    //dynamic data type variable
                    var options = new JsonSerializerOptions{IncludeFields=true};
                    var productsJson= JsonSerializer.Serialize<List<Product>>(products,options);
                    string fileName="products.json";
                    File.WriteAllText(fileName,productsJson);
                                
                    //Deserialization from Json file
                    string jsonString = File.ReadAllText(fileName);
                    List<Product>jsonProducts=JsonSerializer.Deserialize<List<Product>>(jsonString);
                    Console.WriteLine("Deserializing Data From Json File");
                    foreach (Product product in jsonProducts){
                        Console.WriteLine($"Product : {product.Title} : {product.Description}");
                    }
            }
            catch(Exception ex){
                Console.WriteLine(ex);
            }
            finally{

            }          
        }
    }
}

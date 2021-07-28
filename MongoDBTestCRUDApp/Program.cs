using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace MongoDBTestCRUDApp
{
    public class Product{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id{get;set;}
        public int productID{get;set;}
        public string title {get; set;}
        public string description {get; set;}
        public string category {get; set;}
        public string picture {get; set;}
        public int price {get; set;}
        public int quantity {get; set;}
        public string paymentTerm {get; set;}
        public string delivery {get; set;}

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product>  list=new List<Product>();
            var _mongoClient =new MongoClient("mongodb://localhost:27017");
            var db= _mongoClient.GetDatabase("ECommerceApplication");
            var collection=db.GetCollection<Product>("Flowers");
            collection.Find(_=>true).ToList().ForEach(
                product=>{
                    Console.WriteLine(product.title);
                    Console.WriteLine(product.description);
                    Console.WriteLine(product.price);
                    Console.WriteLine(product.quantity);
                    Console.WriteLine(product.picture);
                }
            );          
        }
    }
}

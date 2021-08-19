using System;
using  Core.Models;
namespace DemoApp.Models
{
    [Serializable] 
    public class Item
    {
        public Product theProduct{get;set;}
        public int Quantity{get;set;}
        public Item(){    }
    }
}
using Core.Models;
using Core.Repositories.Interfaces;
 

using System.Collections.Generic;

namespace Core.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAll()
        {
            Core.ORM.IDBManager dbm=new Core.ORM.DBManager();
            List<Product> items=new List<Product>();          
            List<Core.ORM.Product> allProducts=dbm.GetAll();
            foreach( Core.ORM.Product theProduct in allProducts){
                items.Add(new Product{
                    ID=theProduct.Id,
                    Name=theProduct.Title,
                    Quantity=theProduct.Quantity,
                    SalePrice=theProduct.UnitPrice
                });
            }
            return items;
        }
        public Product GetById(int id)
        {
            List<Product> allFlowers=GetAll();
            var found = allFlowers.Find(x => x.ID == id);
            Product theFlower=found as Product;
            return theFlower;
        }
        public List<Product> GetAllSold()
        {
            Core.ORM.IDBManager dbm=new Core.ORM.DBManager();
            List<Product> items=new List<Product>();          
            List<Core.ORM.Product> allProducts=dbm.GetAll();
            foreach( Core.ORM.Product theProduct in allProducts){
                items.Add(new Product{
                    ID=theProduct.Id,
                    Name=theProduct.Title,
                    Quantity=theProduct.Quantity,
                    SalePrice=theProduct.UnitPrice
                });
            }
            return items;
        }
    }
}

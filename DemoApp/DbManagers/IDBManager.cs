
using System.Collections.Generic;

namespace Core.ORM
{
    public interface IDBManager{
        List<Product> GetAll();
        Product GetById(int id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
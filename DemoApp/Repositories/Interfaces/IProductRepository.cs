using Core.Models;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetAllSold();
    }
}

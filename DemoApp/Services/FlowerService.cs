using Core.Models;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using System.Collections.Generic;

namespace Core.Services
{
    public class ProductService : IProductService 
    {
        private readonly IProductRepository _flowerRepo;
        public ProductService(IProductRepository flowerRepo)
        {
            _flowerRepo = flowerRepo;
        }
        public List<Product> GetAll() => _flowerRepo.GetAll();
        public Product GetById(int id)=>_flowerRepo.GetById(id);
        public List<Product> GetAllSold() => _flowerRepo.GetAllSold();
    }
}
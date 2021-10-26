using Core.Models;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using System.Linq;

namespace Core.Services
{
    public class FinancialsService : IFinancialsService
    {
        private readonly IFruitRepository _fruitRepo;
        private readonly IProductRepository _productRepo;

        public FinancialsService(IFruitRepository fruitRepo,
                                 IProductRepository productRepo)
        {
            _fruitRepo = fruitRepo;
            _productRepo = productRepo;
        }

        public decimal GetTotalSold()
        {
            var productSold = _productRepo.GetAllSold().Sum(x => x.Profit);
            var fruitsSold = _fruitRepo.GetAllSold().Sum(x => x.Profit);

            return productSold + fruitsSold;
        }

        public FinancialStats GetStats()
        {
            FinancialStats stats = new FinancialStats();
            var flowerSold = _productRepo.GetAllSold();
            var fruitsSold = _fruitRepo.GetAllSold();

            //Calculate Average Stats
            stats.AverageFruitProfit = fruitsSold.Sum(x => x.Profit) / fruitsSold.Sum(x => x.Quantity);
            stats.AverageFlowerProfit = flowerSold.Sum(x => x.Profit) / flowerSold.Sum(x => x.Quantity);

            return stats;
        }
    }
}

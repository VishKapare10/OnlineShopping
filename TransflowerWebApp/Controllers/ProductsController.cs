using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerWebApp.Models;

namespace TransflowerWebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ProductsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List <string> products=new List<string>();
            products.Add("Lotus");
            products.Add("Carnation");
            products.Add("Jasmine");
            products.Add("Marigold");
            products.Add("Gerbera");
            products.Add("Tulip");
            products.Add("Lily");
            ViewData["allProducts"]=products;
            return View();

            /*List<Product>allProducts=Catalog.ProductManager.GetAllProducts();
            this.ViewData["products"]=allProducts;*/
        }

        public IActionResult Details()
        {
            /*Product product=  Catalog.ProductManager.Get(id);
            ViewData["details"]=product;*/
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

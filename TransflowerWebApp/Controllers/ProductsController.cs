using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerWebApp.Models;
using Catalog;

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
            /*List <string> products=new List<string>();
            products.Add("Lotus");
            products.Add("Carnation");
            products.Add("Jasmine");
            products.Add("Marigold");
            products.Add("Gerbera");
            products.Add("Tulip");
            products.Add("Lily");
            ViewData["allProducts"]=products;
            return View();*/

            List<Product> allProducts=Catalog.ProductManager.GetAllProducts();
            this.ViewData["products"]=allProducts;
            return View();
        }

        public IActionResult Details(int id)
        {
            Product Product=  Catalog.ProductManager.Get(id);
            this.ViewData["product"]=Product;
            return View();
        }

        public IActionResult AddToCart(int id)
        {
            return View();
        }

        //GET Request for insert
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(int id,string title, string description,int quantity, double unitprice, string imageUrl)
        {
            Product product=new Product(){
                Id=id,
                Title=title,
                Description=description,
                Quantity=quantity,
                UnitPrice=unitprice,
                ImageUrl=imageUrl
            };
            ProductManager.Insert(product);
            return View();  
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Product product = ProductManager.Get(id);
            return View(product);  
        }

        [HttpPost]
        public IActionResult Update(Product modifiedProduct)   /// best practice to send or receive data is using model binding
        {
           ProductManager.Update(modifiedProduct);// send data to BLL----DAL----database
           return RedirectToAction("index","products"); 
        }
        
        public IActionResult Delete(int id)
        {
            ProductManager.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

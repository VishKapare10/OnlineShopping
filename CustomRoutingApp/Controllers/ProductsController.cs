using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using  CustomRoutingApp.Models;
using Catalog;

namespace CustomRoutingApp.Controllers
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
           
            return View();
        }

        public IActionResult Details(int id)
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

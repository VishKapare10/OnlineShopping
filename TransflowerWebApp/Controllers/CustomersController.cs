using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerWebApp.Models;
using CRM;

namespace TransflowerWebApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          
            List<Customer> allCustomers=CRM.CustomerManager.GetAll();
            this.ViewData["customers"]=allCustomers;
            return View();
        }

        public IActionResult Details(int id)
        {
            Customer customer=  CRM.CustomerManager.GetById(id);
            this.ViewData["customer"]=customer;
            return View();
        }

        public IActionResult Insert(Customer customer)
        {
            bool status=CRM.CustomerManager.Insert(customer);
            return View();
        }

        public IActionResult Update(Customer customer)
        {   
            bool status=CRM.CustomerManager.Update(customer);
            return View();
        }

        
        public IActionResult Delete(int id)
        {
            CRM.CustomerManager.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

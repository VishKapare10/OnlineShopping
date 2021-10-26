using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BIApp.Models;

namespace BIApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs(){

            //Using  ViewData
            string name = "Transflower Learning Pvt. Ltd.";
            ViewData["company"] = name;

            return View();
        }

        public  IActionResult ContactUs(){
             //Using ViewBag
            string url = "www.transflower.in";
            var product= new Product { ID=23, Title="Rose"};
            ViewBag.product=product;
            ViewBag.website=url;
            ViewBag.school="Transflower school";
            ViewBag.age=35;
            return View();
        }

        public IActionResult Services(){
             //Using TempData
            string service="Transforming Digital India";
            TempData["vision"]=service;
            return View();
        }

        public IActionResult SalesView(){
            SalesRepository list = new SalesRepository();
            ViewBag.Message = "Transflower Sales!";
            return View(list);
        }

        public IActionResult Students(){
            List<string> data=new List<string>();
            data.Add("Ajinkya");
            data.Add("Rohit");
            data.Add("Swarali");
            data.Add("Ankur");
            data.Add("Neha");
            data.Add("Rutuja");
            var result=data.ToArray();
            return new JsonResult(result);
        } 

        public IActionResult List(){

            SalesRepository repository=new SalesRepository();
            return new JsonResult(repository.products);
    
        }
        public IActionResult Privacy()
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

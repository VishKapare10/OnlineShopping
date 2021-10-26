using Microsoft.AspNetCore.Mvc;
using DemoApp.Models;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Core.Services.Interfaces;
using DemoApp.Helpers;

namespace DemoApp.Controllers
{
   public class ShoppingCartController : Controller
    {  
        private readonly IProductService _productService;
        
        public ShoppingCartController(IProductService productService ){        
            _productService=productService; 
        }
        public IActionResult Index(){  
            Cart theCart= SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            return View(theCart);
        }

        [HttpGet]
        public IActionResult  Add(int id){  
            Product theProduct=_productService.GetById(id);
            Item theItem=new Item();
            theItem.theProduct=theProduct;
            theItem.Quantity=0;
            return View(theItem);
        }  

        [HttpPost]
        public IActionResult Add(Item newItem){  
            Cart theCart= SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            theCart.Items.Add(newItem);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", theCart);
            return RedirectToAction("Index","shoppingcart");
        }  
        public IActionResult  Remove(int  id){  
            Cart theCart= SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");  
            var found = theCart.Items.Find(x => x.theProduct.ID == id);
            if(found != null) theCart.Items.Remove(found);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", theCart);        
            return RedirectToAction("Index","ShoppingCart");
        }          
    }
}
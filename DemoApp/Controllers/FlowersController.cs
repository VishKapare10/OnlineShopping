using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;
public class FlowersController : Controller
    {
         private readonly IProductService _productService;
         public FlowersController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var itemsSold = _productService.GetAll();
            return View(itemsSold);
        }
    }
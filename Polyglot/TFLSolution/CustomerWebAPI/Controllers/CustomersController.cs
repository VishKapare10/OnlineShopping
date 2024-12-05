using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CustomerWebAPI.Services;
using CustomerWebAPI.Entities;
using System;

namespace CustomerWebAPI.Controllers
{  
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
    
        [HttpGet]
        public IActionResult GetAll()
        {
            var customers =  _customerService.GetAll();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           var user =  _customerService.GetById(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }
    }
}
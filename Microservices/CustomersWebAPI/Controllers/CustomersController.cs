using System;
using Microsoft.AspNetCore.Mvc;
using CustomerWebAPI.Models;
using CustomerWebAPI.Services;

namespace CustomerWebAPI.Controllers
{
    [ApiController]
    public class CustomersController : ControllerBase{

        //Each action method is mapped to HTTP Request type
        private ICustomerService _svc;
        public CustomersController (ICustomerService svc)
        {
            this._svc = svc;
        }

        //action method
        [HttpGet]
        [Route("api/customers")]
        public IActionResult GetCustomers(){
            //invoke service method to resturn products
            // send received data as message to outside world
            try{
                    var message=_svc.GetCustomers();
                    if(message==null){
                        return NotFound();
                    }
                return Ok(message);
            }
            catch(Exception){
                return BadRequest();
            }
        }
   
        [HttpPost]
        [Route("api/customers")]
        public IActionResult Insert([FromBody] Customer customer){
            try{

                bool status= _svc.Insert(customer);
                if(status == false){
                    return BadRequest();
                }
                else{
                    return Ok();
                }
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                return BadRequest();
            }
        }
 
        [HttpGet("api/customers/{id}")]
        public IActionResult GetById(int id){
             try{

                    var  message= _svc.GetCustomerById(id);
                    if(message == null){
                        return BadRequest();
                     }
                    else{
                        return Ok(message);
                    }
            }
            catch(Exception ){
                return BadRequest();
            }
        }

         // GET: api/customers/5
        [HttpDelete("api/customers/{id}")]
        public IActionResult Delete(int id){
             try{
                    bool status= _svc.Delete(id);
                    if(status == false){
                        return BadRequest();
                     }
                    else{
                        return Ok();
                    }
            }
            catch(Exception ){
                return BadRequest();
            }
        }

        [HttpPut("api/customers")]
        public IActionResult Update(Customer customer){
            try{
                bool status= _svc.Update(customer);
                if(status == false){
                    return BadRequest();
                }
                else{
                    return Ok();
                }
            }
            catch(Exception ){
                return BadRequest();
            }
        }
       }
}
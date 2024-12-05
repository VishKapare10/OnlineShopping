using System;
using Microsoft.AspNetCore.Mvc;
using OrdersWebAPI.Models;
using OrdersWebAPI.Services;

namespace OrdersWebAPI.Controllers
{
    [ApiController]
    public class OrdersController : ControllerBase{

        //Each action method is mapped to HTTP Request type
        private IOrderService _svc;
        public OrdersController (IOrderService svc)
        {
            this._svc = svc;
        }

        //action method
        [HttpGet]
        [Route("api/orders")]
        public IActionResult GetOrders(){
            //invoke service method to resturn products
            // send received data as message to outside world
            try{
                    var message=_svc.GetOrders();
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
        [Route("api/orders")]
        public IActionResult Insert([FromBody] Order order){
            try{

                bool status= _svc.Insert(order);
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
 
        [HttpGet("api/orders/{id}")]
        public IActionResult GetById(int id){
             try{

                    var  message= _svc.GetOrderById(id);
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

         // GET: api/orders/5
        [HttpDelete("api/orders/{id}")]
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

        [HttpPut("api/orders")]
        public IActionResult Update(Order order){
            try{
                bool status= _svc.Update(order);
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
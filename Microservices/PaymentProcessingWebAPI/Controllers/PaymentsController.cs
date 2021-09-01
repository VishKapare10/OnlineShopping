using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;
using Core.Models;
using System;

namespace PaymentProcessingDemo
{
    public class PaymentsController : Controller
    {
         private IPaymentService _svc;
        public PaymentsController(IPaymentService svc)
        {
            this._svc = svc;
        }

         //action method
        [HttpGet]
        [Route("api/payments")]
        public IActionResult GetPayments()
        {
            try{
                    var message=_svc.GetPayments();
                    if(message==null){
                        return NotFound();
                    }
                return Ok(message);
            }
            catch(Exception){
                return BadRequest();
            }
        }
        
        [HttpGet("api/payments/{id}")]
        public ActionResult GetById(int id)
        {
             try{

                    var  message= _svc.GetPaymentById(id);
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
      
        
        [HttpPost]
        [Route("api/payments")]
        public IActionResult Insert([FromBody] Payment payment){
            try{

                bool status= _svc.Insert(payment);
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

        [HttpPut("api/payments")]
        public IActionResult Update(Payment payment){
            try{
                bool status= _svc.Update(payment);
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

        // GET: api/payments/5
        [HttpDelete("api/payments/{id}")]
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
    }
}
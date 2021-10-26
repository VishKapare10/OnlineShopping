using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using UserWebAPI.Services;
using UserWebAPI.Entities;
using System;

namespace UserWebAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
          private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
    
        [HttpGet]
        public IActionResult GetAll()
        {
            var users =  _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           var user =  _userService.GetById(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }
    }
}
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using UserWebAPI.Entities;
using UserWebAPI.Helpers;

namespace UserWebAPI.Services
{ 
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        { 
            new User { Id = 1, FirstName = "Swarali", LastName = "L", Username = "swarali", Password = "swarali"},
            new User { Id = 2, FirstName = "Ganesh", LastName = "S", Username = "ganesh", Password = "ganesh"} ,
            new User { Id = 3, FirstName = "Rutuja", LastName = "T", Username = "rutuja", Password = "rutuja"},
            new User { Id = 4, FirstName = "Vishwambhar", LastName = "K", Username = "vishwambhar", Password = "vishwambhar"},
            new User { Id = 5, FirstName = "Rohit", LastName = "W", Username = "rohit", Password = "rohit"},
        };


        public IEnumerable<User> GetAll()
        {
            return _users.WithoutPasswords();
        }

        public User GetById(int id) 
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return user.WithoutPassword();
        }
    }
}
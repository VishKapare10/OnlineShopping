using System.Collections.Generic;
using UserWebAPI.Entities;


namespace UserWebAPI.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
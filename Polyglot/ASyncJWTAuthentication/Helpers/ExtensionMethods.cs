using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public static class ExtensionMethods
    {
        public async static Task<IEnumerable<User>> WithoutPasswords(this IEnumerable<User> users) 
        {
            if (users == null) return null;
            var result =users.Select( x => x.WithoutPassword());
            return await  Task.FromResult(result.ToList());
        }

        public static User WithoutPassword(this User user) 
        {
            if (user == null) return null;
            user.Password = "";
            return    user;
        }
    }
}
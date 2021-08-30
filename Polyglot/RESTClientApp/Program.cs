using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RESTClientApp
{
    public class Repository
    {
            [JsonPropertyName("name")]
            public string Name { get; set; }
    }

   
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
    

    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            await FetchUsersFromRESTAPI();
        }

       

         private static async Task FetchUsersFromRESTAPI()
        {
            List<User> reservationList = new List<User>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:4000/users/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<User>>(apiResponse);
                    foreach (var repo in reservationList)
                        Console.WriteLine(repo.Username + " ," + repo.LastName +" ,"+repo.Role );
                }
            }
        }
    }
}

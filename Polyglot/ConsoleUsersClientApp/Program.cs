using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace ConsoleUsersClientApp
{
    
    class Program
    {
         private static readonly HttpClient client = new HttpClient();
        

        static async  Task Main(string[] args)
        {

           await FetchUsersFromRESTAPI();
           Console.WriteLine("Hello World!");
        }


        public static async  Task  FetchUsersFromRESTAPI(){
        
        //consume REST API 
        List<User> reservationList = new List<User>();
        //access data from rest api using asynchronous
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

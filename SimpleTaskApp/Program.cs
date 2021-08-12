using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleTaskApp
{
    class Program
    {
        
        //non blocking call
        public static async Task StoreData(){
            
            await Task.Run(() => {
                    Console.WriteLine("Job 1...Storing  in JSON File");
                });
        }

        public static async Task GetRemoteData(){
            
            await Task.Run(() => {
              
                    Console.WriteLine("Job 2...Getting remote data");
            });
        }

        static void Main(string[] args)
        {
            //Primary thread
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("Main function thread ="+theThread.ManagedThreadId);  

            StoreData();
            GetRemoteData();
           
           
        }
    }
}

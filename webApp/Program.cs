using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;

namespace webApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("main ="+theThread.ManagedThreadId); 
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    Thread theThread = Thread.CurrentThread;
                    Console.WriteLine("HostBuilder ="+theThread.ManagedThreadId); 
                    webBuilder.UseStartup<Startup>();
                });
    }
}

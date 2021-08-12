using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading;

namespace webApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                     Thread theThread = Thread.CurrentThread;
                    Console.WriteLine("default ="+theThread.ManagedThreadId);  
                    await context.Response.WriteAsync("Hello World!");
                });

                endpoints.MapGet("/aboutus", async context =>
                {
                    Thread theThread = Thread.CurrentThread;
                    Console.WriteLine("/aboutus ="+theThread.ManagedThreadId);  
                    await context.Response.WriteAsync("Welcome to Transflower!");
                });

                endpoints.MapGet("/contact", async context =>
                {
                    Thread theThread = Thread.CurrentThread;
                    Console.WriteLine("/contact ="+theThread.ManagedThreadId);  
                    await context.Response.WriteAsync("Contact No. 7720037983");
                });
            });
        }
    }
}

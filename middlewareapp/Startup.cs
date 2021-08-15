using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
 
namespace middlwareapp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            
          /*app.Run(async context =>{

              await context.Response.WriteAsync("Hello World");
          });*/

         
            /* app.Use(async (context, next) =>
            {
                //intercept the request
                //based on path send different response

                if (context.Request.Path == "/hello")
                {
                    await context.Response.WriteAsync("Hello World!");
                }
                else if (context.Request.Path == "/welcome")
                {
                    await context.Response.WriteAsync("Welcome to Transflowr!");
                }
                await next();
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Second Middleware Response.... ");
                await next();
            });
            
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Third Middleware Response......");
                await next();
            });            


            app.Run(async context =>
            {
                await context.Response.WriteAsync("End of Middleware Pipeline.");
            }); */


           /*  app.UseFirstMiddleware();  
            app.UseSecondMiddleware();
            app.UseLastMiddleware();
            app.UseWelcomePage();   //inbuilt middleware
            app.UseStaticFiles();   ///inbuilt middleware
            */
        
        }
    }
}

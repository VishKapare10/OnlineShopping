using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmptyWebApp
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

            //Configuring http request endpoint
            app.UseEndpoints(endpoints =>
            {
                //Mapping url with http callback handlers
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("<h1>Hello World!</h1>");
                });

                endpoints.MapGet("/aboutus", async context =>
                {
                    await context.Response.WriteAsync("<h1>Transflower Learning Pvt. Ltd.</h1>");
                });

                endpoints.MapGet("/products", async context =>
                {
                    await context.Response.WriteAsync("<ol><li>Rose</li><li>Lotus</li><li>Gerbera</li></ol>");
                });
                endpoints.MapGet("/orders", async context =>
                {
                    await context.Response.WriteAsync("<h1>Order Summary</h1>");
                });
                endpoints.MapGet("/shoppingcart", async context =>
                {
                    await context.Response.WriteAsync("<h1>My Shopping Cart</h1>");
                });
                endpoints.MapGet("/login", async context =>
                {
                    await context.Response.WriteAsync("<h1>Validate User</h1>");
                });
            });
        }
    }
}

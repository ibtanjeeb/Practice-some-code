using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace Console_to_webapp
{
    public class Startup
    {
        public void ConfigurationService(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.Use(async(context, next) =>

            {
           
                await context.Response.WriteAsync("Hello this my 1st MiddleWare");
                await next();
                await context.Response.WriteAsync("\nHello this my 1st response ");
            }
            );

            app.Use(async (context, next) =>

            {

                await context.Response.WriteAsync("\nHello this my 2nd MiddleWare");
                await next();
                await context.Response.WriteAsync("\nHello this my 2nt response ");
            }
            );
            app.Use(async (context, next) =>

            {

                await context.Response.WriteAsync("\nHello this my 3rd Middleware");
               
            }
           );



            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //     {
            //        await context.Response.WriteAsync("Hello, This is Tanjeeb");
            //     });
            //});

        }
    }
}

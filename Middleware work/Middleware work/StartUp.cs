using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Middleware_work
{
    class StartUp
    {


        public  void ConfigureService(IServiceCollection ser)
        {

        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env )
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseEndpoints(endpoint =>
               {

                   endpoint.MapGet("/", async context =>
                    {
                        await context.Response.WriteAsync("Hello world ");
                    }
                   );
               });

        }
    }
}

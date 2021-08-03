using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Console_to_webapp
{
    public class Startup
    {
        public void ConfigurationService(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                 {
                    await context.Response.WriteAsync("Hello, This is Tanjeeb");
                 });
            });

        }
    }
}

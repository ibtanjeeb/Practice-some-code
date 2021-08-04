using System;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;

namespace Middleware_work
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args)=>
        
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webbuilder =>
            {
                webbuilder.UseStartup<StartUp>();
            }
            );

        
    }
}

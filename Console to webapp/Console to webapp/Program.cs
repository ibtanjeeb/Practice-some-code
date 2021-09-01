using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System;


namespace Console_to_webapp
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] arg)=>
       
            Host.CreateDefaultBuilder(arg).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();

            });
       
    }
}

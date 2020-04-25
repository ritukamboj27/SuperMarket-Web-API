using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Supermarket.API.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore;

namespace Supermarket.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            // var host = BuildWebHost(args);

            // using(var scope = host.Services.CreateScope())
            // using(var context = scope.ServiceProvider.GetService<AppDbContext>())
            // {
            //     context.Database.EnsureCreated();
            // }
            // host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
    }
}

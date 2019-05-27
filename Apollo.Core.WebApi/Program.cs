using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Com.Ctrip.Framework.Apollo;

namespace Apollo.Core.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
              .ConfigureAppConfiguration((hostingContext, builder) =>
              {
                  builder
                  .AddApollo(builder.Build().GetSection("apollo"))
                  .AddDefault() 
                  .AddNamespace("application");
              })
              .UseStartup<Startup>();
    }
}

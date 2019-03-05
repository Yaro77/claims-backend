using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Claims.Persistence;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Claims.Backend
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var webHost = CreateWebHostBuilder(args).Build();

      InitializeDatabase(webHost.Services);

      webHost.Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();

    private static void InitializeDatabase(IServiceProvider serviceProvider)
    {
      using (var scope = serviceProvider.CreateScope())
      {
        var services = scope.ServiceProvider;
        using (var context = services.GetRequiredService<ClaimsDbContext>())
        {
          DbInitializer.Initialize(context);
        }
      }
    }
  }
}

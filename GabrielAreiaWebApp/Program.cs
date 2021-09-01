using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace GabrielAreiaWebApp
{
    public class Program
    {
        public static string Language { get; set; } = "pt";

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

using IMC.Common.Interfaces;
using IMC.TaxJar.Client;
using IMC.TaxJar.Settings;
using IMC.TaxJar.Services;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using IMC.Worker;

namespace IMCSalesTaxService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var configuration = hostContext.Configuration;
                    services.Configure<TaxJarSettings>(configuration.GetSection("TaxJarSettings"));
                    services.AddTransient<HttpClient>();
                    services.AddTransient<TaxJarClient>();
                    services.AddTransient<TaxService>();

                    //SWAP TAX CALCULATER HERE
                    services.AddTransient<ITaxCalculaterService, TaxJarCalculaterService>();

                    services.AddHostedService<Worker>();
                });
    }
}

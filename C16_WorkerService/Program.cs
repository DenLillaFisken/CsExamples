using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace C16_WorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Log.Logger = new LoggerConfiguration()
           .MinimumLevel.Debug()
           .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
           .Enrich.FromLogContext()
           .WriteTo.File(@"c:\workerservice\log\LogFile.txt")
           .CreateLogger();



            try
            {
                Log.Information("Starting workerservice...");
                CreateHostBuilder(args).Build().Run();
                return;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, $"workerservice stopped unexpectedly. Error {ex.Message}");
                return;
            }
            finally
            {
                Log.CloseAndFlush();
            }


            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                 .UseSerilog() //middleware (separat tjänst)
                 .UseWindowsService()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                });

    }
}

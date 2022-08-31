using ImageIngest.Functions.Interfaces;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(ImageIngest.Functions.Startup))]

namespace ImageIngest.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();
            //builder.Services.AddScoped<ITracker, Tracker>();

            // builder.Services.AddSingleton<IMyService>((s) => {
            //     return new MyService();
            // });

            // builder.Services.AddSingleton<ILoggerProvider, MyLoggerProvider>();
        }
    }
}
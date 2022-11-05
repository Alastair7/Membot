
// See https://aka.ms/new-console-template for more information
using Membot.Esp.Bot.Common.TokenManager;
using Membot.Esp.Bot.Model.Bot.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Membot.Esp.Bot.BotService;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try 
{
    // LOAD ENV VARIABLES
    DotNetEnv.Env.TraversePath().Load();
    IOptions<BotAuthConfigurationModel> botOptions = services.GetRequiredService<IOptions<BotAuthConfigurationModel>>();

    // RUN BOT
    services.GetRequiredService<Bot>().Run();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// CONFIGURE SERVICES
static IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args).ConfigureServices((_, services) =>
    {
        _.Configuration = CreateConfigurationBuilder().Build();
        services.Configure<BotAuthConfigurationModel>(_.Configuration.GetSection("BotConfig"));

        // Add Services Here
        services.AddSingleton<Bot>();
        services.AddScoped<ITokenManager, TokenManager>();
        services.AddTransient<ILogger>(s => s.GetRequiredService<ILogger<Program>>());
    });
}

static ConfigurationBuilder CreateConfigurationBuilder()
{
   return (ConfigurationBuilder)new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
         .AddJsonFile($"appsettings.json").AddJsonFile("autofac.json");
}
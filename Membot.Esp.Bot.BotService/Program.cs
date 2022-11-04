
// See https://aka.ms/new-console-template for more information
using Membot.Esp.Bot.Common.TokenManager;
using Membot.Esp.Bot.Logic.Test;
using Membot.Esp.Bot.Model.Bot.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Hosting;
using Membot.Esp.Bot.BotService;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try 
{
    DotNetEnv.Env.TraversePath().Load();
    IOptions<BotAuthConfigurationModel> botOptions = services.GetRequiredService<IOptions<BotAuthConfigurationModel>>();

    services.GetRequiredService<Bot>().Run(args, botOptions);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

static IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args).ConfigureServices((_, services) =>
    {
        _.Configuration = CreateConfigurationBuilder().Build();
        // Add Services Here
        services.Configure<BotAuthConfigurationModel>(_.Configuration.GetSection("BotConfig"));

        services.AddSingleton<Bot>();
        services.AddTransient<ILogger>(s => s.GetRequiredService<ILogger<Program>>());
    });
}

static ConfigurationBuilder CreateConfigurationBuilder()
{
   return (ConfigurationBuilder)new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
         .AddJsonFile($"appsettings.json");
}
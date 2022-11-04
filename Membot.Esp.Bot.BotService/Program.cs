
// See https://aka.ms/new-console-template for more information
using Membot.Esp.Bot.Common.TokenManager;
using Membot.Esp.Bot.Logic.Test;
using Membot.Esp.Bot.Model.Bot.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;


    static void ConfigureServices(IServiceCollection services)
    {
        services.AddLogging(builder =>
        {
            builder.AddConsole();
            builder.AddDebug();
        });

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables().Build();

        services.Configure<IConfiguration>(configuration);
    }

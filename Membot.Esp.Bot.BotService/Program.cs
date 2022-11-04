
// See https://aka.ms/new-console-template for more information
using Membot.Esp.Bot.Common.TokenManager;
using Membot.Esp.Bot.Logic.Test;
using Membot.Esp.Bot.Model.Bot.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Hosting;
using Membot.Esp.Bot.BotService;

using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try 
{
    services.GetRequiredService<Bot>().Run(args);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

static IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args).ConfigureServices((_, services) =>
    {
        // Add Services Here
    });
}
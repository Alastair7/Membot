using Membot.Esp.Bot.Common.TokenManager;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Membot.Esp.Bot.BotService;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using Serilog;

try 
{
    // Load environment variables from .env
    DotNetEnv.Env.TraversePath().Load();

    var builder = new ConfigurationBuilder();
    BuildConfig(builder);

    // Config Serilog Logger
    Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(builder.Build())
        .Enrich.FromLogContext()
        .WriteTo.Console()
        .CreateLogger();

    Log.Logger.Information("Application Starting");
    // Create Host Builder
    var host = Host.CreateDefaultBuilder()
        .ConfigureServices((context, services) =>
        {
            services.AddSingleton<IBot, Bot>();
            services.AddTransient<ITokenManager, TokenManager>();

            services.Configure<BotAuthConfig>(context.Configuration.GetSection("BotConfig"));
        })
        .UseSerilog()
        .Build();

    var bot = ActivatorUtilities.CreateInstance<Bot>(host.Services);

    Log.Logger.Information("Running Bot");
    bot.Run();
    Log.Logger.Information("Bot is Running...");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// CONFIGURE SERVICES
static void BuildConfig(IConfigurationBuilder builder)
{
    builder.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
        .AddEnvironmentVariables();
}
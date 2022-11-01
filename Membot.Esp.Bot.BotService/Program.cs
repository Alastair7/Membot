
// See https://aka.ms/new-console-template for more information
using Membot.Esp.Bot.Common.TokenManager;
using Membot.Esp.Bot.Logic.Test;
using Membot.Esp.Bot.Model.Bot.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Membot.Esp.Bot.BotService
{
    public class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World !");

            var devEnvironmentVariable = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
            var isDevelopment = string.IsNullOrEmpty(devEnvironmentVariable) || devEnvironmentVariable.ToLower() == "development";
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(AppContext.BaseDirectory))
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            if (isDevelopment)
            {
                builder.AddUserSecrets<BotAuthConfigurationModel>();
            }
            Configuration = builder.Build();

            var services = new ServiceCollection().Configure<BotAuthConfigurationModel>(Configuration.GetSection(nameof(BotAuthConfigurationModel)))
                .AddOptions().BuildServiceProvider();

            services.GetService<ITokenManager>();
        }
    }
}
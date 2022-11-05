using Membot.Esp.Bot.Common.TokenManager;
using Microsoft.Extensions.Logging;

namespace Membot.Esp.Bot.BotService
{
    public class Bot
    {
        private readonly ILogger logger;
        private readonly ITokenManager tokenManager;

        public Bot (ILogger logger, ITokenManager tokenManager)
        {
            this.logger = logger;
            this.tokenManager = tokenManager;
        }

        public void Run()
        {
            logger.Log(LogLevel.Information, "Test");
            Console.WriteLine(tokenManager.GetBotToken());

            // Run BOT (Use Timer or something like that)
            // Get ENV Variables
            // Get APIs Data
            // Send API
        }

    }
}

using Membot.Esp.Bot.Common.TokenManager;
using Microsoft.Extensions.Logging;

namespace Membot.Esp.Bot.BotService
{
    public class Bot : IBot
    {
        private readonly ILogger<Bot> logger;
        private readonly ITokenManager tokenManager;

        public Bot (ILogger<Bot> logger, ITokenManager tokenManager)
        {
            this.logger = logger;
            this.tokenManager = tokenManager;
        }

        public void Run()
        {
            logger.LogInformation("Test Token: {token}", tokenManager.GetBotToken());
            // Run BOT (Use Timer or something like that)
            // Get ENV Variables
            // Get APIs Data
            // Send API
        }

    }
}

using Membot.Esp.Bot.Common.TokenManager;
using Membot.Esp.Bot.Model.Bot.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

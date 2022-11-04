using Microsoft.Extensions.Logging;
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

        public Bot (ILogger logger)
        {
            this.logger = logger;
        }

        public void Run(string[] args)
        {
            // Run BOT (Use Timer or something like that)
            // Get ENV Variables
            // Get APIs Data
            // Send API
        }

    }
}

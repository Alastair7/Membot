using Membot.Esp.Bot.Model.Bot.Models;
using Microsoft.Extensions.Options;

namespace Membot.Esp.Bot.Common.TokenManager
{
    public class TokenManager : ITokenManager
    {
        private readonly IOptions<BotAuthConfigurationModel> botConfig;

        public TokenManager(IOptions<BotAuthConfigurationModel> botConfig)
        {
            this.botConfig = botConfig;
        }

        public string GetBotKey()
        {
            return Environment.GetEnvironmentVariable(botConfig.Value.Key);
        }

        public string GetBotKeySecret()
        {
            return Environment.GetEnvironmentVariable(botConfig.Value.KeySecret);
        }

        public string GetBotToken()
        {
            return Environment.GetEnvironmentVariable(botConfig.Value.Token);
        }
    }
}

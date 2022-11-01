using Membot.Esp.Bot.Model.Bot.Models;
using Microsoft.Extensions.Options;

namespace Membot.Esp.Bot.Common.TokenManager
{
    public class TokenManager : ITokenManager
    {
        private readonly BotAuthConfigurationModel botConfiguration;

        public TokenManager(IOptions<BotAuthConfigurationModel> botConfiguration)
        {
            this.botConfiguration = botConfiguration.Value;
        }

        public string GetBotKey()
        {
            return botConfiguration.Key;
        }

        public string GetBotKeySecret()
        {
            return botConfiguration.KeySecret;
        }

        public string GetBotToken()
        {
            return botConfiguration.Token;
        }
    }
}

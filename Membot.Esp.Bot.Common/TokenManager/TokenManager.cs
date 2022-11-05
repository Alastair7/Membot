using Microsoft.Extensions.Options;

namespace Membot.Esp.Bot.Common.TokenManager
{
    public class TokenManager : ITokenManager
    {
        private readonly IOptions<BotAuthConfig> botConfig;

        public TokenManager(IOptions<BotAuthConfig> botConfig)
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

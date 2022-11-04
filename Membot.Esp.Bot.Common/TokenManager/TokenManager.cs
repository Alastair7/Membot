using Membot.Esp.Bot.Model.Bot.Models;
using Microsoft.Extensions.Options;

namespace Membot.Esp.Bot.Common.TokenManager
{
    public class TokenManager : ITokenManager
    {

        public string GetBotKey()
        {
            return Environment.GetEnvironmentVariable("Key");
        }

        public string GetBotKeySecret()
        {
            return Environment.GetEnvironmentVariable("KeySecret");
        }

        public string GetBotToken()
        {
            return Environment.GetEnvironmentVariable("Token");
        }
    }
}

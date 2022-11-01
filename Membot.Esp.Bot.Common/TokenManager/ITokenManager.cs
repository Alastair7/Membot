namespace Membot.Esp.Bot.Common.TokenManager
{
    public interface ITokenManager
    {
        string GetBotToken();
        string GetBotKey();
        string GetBotKeySecret();
    }
}

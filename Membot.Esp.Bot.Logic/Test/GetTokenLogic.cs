using Membot.Esp.Bot.Common.TokenManager;

namespace Membot.Esp.Bot.Logic.Test
{
    public class GetTokenLogic : IGetTokenLogic
    {
        private readonly ITokenManager tokenManager;

        public GetTokenLogic(ITokenManager tokenManager)
        {
            this.tokenManager = tokenManager;
        }

        string IGetTokenLogic.GetTokenLogic()
        {
            return tokenManager.GetBotToken();
        }
    }
}

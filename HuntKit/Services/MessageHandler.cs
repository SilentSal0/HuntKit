using Telegram.Bot.Types;
using Telegram.Bot;

namespace HuntKit.Services
{
    public static class MessageHandler
    {
        public static async Task HandleMessageAsync(ITelegramBotClient client, Update update, CancellationToken cancellationToken)
        {
            if (update.Message is not { } message) return;
            if (message.Text is not { } messageText) return;


        }
    }
}


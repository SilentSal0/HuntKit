using Telegram.Bot.Types;
using Telegram.Bot;

namespace HuntKit.Services
{
    public static class CallbackQueryHandler
    {
        public static async Task HandleCallbackQueryAsync(ITelegramBotClient client, Update update, CancellationToken cancellationToken)
        {
            if (update.CallbackQuery is not { } callbackQuery) return;
            if (callbackQuery.Id is not { } callbackQueryId) return;


        }
    }
}


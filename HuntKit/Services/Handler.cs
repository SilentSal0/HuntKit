using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace HuntKit.Services
{
    public static class Handler
    {
        public static async Task HandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken cancellationToken)
        {
            switch (update.Type)
            {
                case UpdateType.Message:
                    await MessageHandler.HandleMessageAsync(client, update, cancellationToken);
                    break;

                case UpdateType.CallbackQuery:
                    await CallbackQueryHandler.HandleCallbackQueryAsync(client, update, cancellationToken);
                    break;

                default:
                    break;
            }
        }


    }
}


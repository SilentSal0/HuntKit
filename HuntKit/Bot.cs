using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using HuntKit.Json;

namespace HuntKit
{
    public static class Bot
    {
        public static TelegramBotClient Client { get; private set; }

        static Bot()
        {
            var filePath = @"Config/config.json";
            var config = JsonReader.ReadJsonAsync<ConfigStructure>(filePath).Result;
            Client = new TelegramBotClient(config.Token ?? throw new InvalidDataException("Token is null."));
        }

        public static async Task RunAsync(CancellationToken cancellationToken)
        {
            await InitializeCommandsAsync();
            Client.StartReceiving(UpdateHandler, ErrorHandlder, new ReceiverOptions(), cancellationToken);

            var me = await Client.GetMe(cancellationToken);           
            Console.WriteLine($"Bot {me.Username} woke up.");
        }

        private static async Task InitializeCommandsAsync()
        {
            var commands = new List<BotCommand>
            {
                new() { Command = "start", Description = "start work" }
            };

            await Client.SetMyCommands(commands);
        }

        private static async Task UpdateHandler(ITelegramBotClient client, Update update, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        private static async Task ErrorHandlder(ITelegramBotClient client, Exception exception, HandleErrorSource source, CancellationToken token)
        {
            throw new NotImplementedException();
        }


    }
}


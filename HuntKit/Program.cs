using HuntKit;

class Program
{
    static async Task Main()
    {
        try
        {
            WriteBanner();
            await ConfigureConsole();

            using var cts = new CancellationTokenSource();
            await Bot.RunAsync(cts.Token);

            Console.ReadKey();
            Console.ResetColor();
            cts.Cancel();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    static async Task ConfigureConsole()
    {
        Console.Title = "HuntKit";
        Console.ForegroundColor = ConsoleColor.Yellow;
        await Task.Delay(1000);
        Console.WriteLine("Bot is waking up...");
    }

    static void WriteBanner()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\t\t" + @" ___  ___   ___  ___   ________    _________   ___  __     ___   _________   ");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\t\t" + @"|\  \|\  \ |\  \|\  \ |\   ___  \ |\___   ___\|\  \|\  \  |\  \ |\___   ___\ ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\t\t" + @"\ \  \\\  \\ \  \\\  \\ \  \\ \  \\|___ \  \_|\ \  \/  /|_\ \  \\|___ \  \_| ");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\t\t" + @" \ \   __  \\ \  \\\  \\ \  \\ \  \    \ \  \  \ \   ___  \\ \  \    \ \  \  ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t" + @"  \ \  \ \  \\ \  \\\  \\ \  \\ \  \    \ \  \  \ \  \\ \  \\ \  \    \ \  \ ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\t\t" + @"   \ \__\ \__\\ \_______\\ \__\\ \__\    \ \__\  \ \__\\ \__\\ \__\    \ \__\");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t\t" + @"    \|__|\|__| \|_______| \|__| \|__|     \|__|   \|__| \|__| \|__|     \|__|" + "\n");
        Console.ResetColor();
    }


}


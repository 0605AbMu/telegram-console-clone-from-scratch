using TelegramClient.Auth.UI.Interface;

namespace TelegramClient.Auth.UI;

public class LoginUI : ILoginView
{
    public void LogView()
    {
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("\n\t\t\t ***** Welcome to login\n");
        
    }
}
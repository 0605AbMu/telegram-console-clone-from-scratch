// See https://aka.ms/new-console-template for more information

using TelegramClient.Auth.UI;

internal class Program
{
    private static LoginUI _loginUi = new LoginUI();
    public static void Main()
    {
        Console.WriteLine("Hello Auth");
        _loginUi.LogView();
        
    }
}
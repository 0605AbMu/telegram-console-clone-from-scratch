// See https://aka.ms/new-console-template for more information

using TelegramClient.Auth.UI;

internal class Program
{
    private ChangePasswordUI _changePasswordUi = new ChangePasswordUI();
    static LoginUI loginUI = new LoginUI();
    public static void Main()
    {
        //loginUI.LogView();
        Console.WriteLine("Hellow");
    }
}
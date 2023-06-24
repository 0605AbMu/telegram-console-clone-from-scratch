// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using TelegramClient.Auth.UI;

internal class Program
{
    private ChangePasswordUI _changePasswordUi = new ChangePasswordUI();
    static LoginUI loginUI = new LoginUI();
    public static void Main()
    {
        Console.WriteLine("Hellow");
        Layout layout = new Layout(new System.Drawing.Point(60, 30) , new System.Drawing.Point(120, 60));
        layout.Ramka();
        layout.Write("salomlar hhhhhhhhhhhhhhhhhhaaa");
    }
}
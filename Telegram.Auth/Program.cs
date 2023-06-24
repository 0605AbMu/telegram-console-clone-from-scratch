// See https://aka.ms/new-console-template for more information

using System.Drawing;
using ConsoleApp1;
using TelegramClient.Auth.UI;

internal class Program
{
    static LoginUI loginUI = new LoginUI();
    public static void Main()
    {
        Point toppoint = new Point(60, 30);
        Point botompoint = new Point(120, 60);
        Layout layout = new Layout(new Point(60, 30), new Point(120, 60));
        layout.Ramka();
        layout.Write("Registraion");
        
    }
}
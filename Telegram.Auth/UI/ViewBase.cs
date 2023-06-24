using System.Drawing;
using ConsoleApp1;
using TelegramClient.Auth.Domain;

namespace TelegramClient.Auth.UI;

public class ViewBase
{
    LoginUI loginUi;
    RegistraionUI registraionUi;


    public ViewBase()
    {
        loginUi = new LoginUI();
        registraionUi = new RegistraionUI();

    }

    public User Homeview()
    {
        tuda:
        Point toppoint = new Point(60, 30);
        Point botompoint = new Point(120, 60);
        Layout layout = new Layout(toppoint, botompoint);
        layout.Ramka();
        layout.Write("1.Registraion");
        layout.Write("2.Login");

        var key = Console.ReadKey();
        if (key.Key == ConsoleKey.D2)
        {
            return loginUi.LoginView();
        }
        else if (key.Key == ConsoleKey.D1)
        {
            registraionUi.Registraion();
            Console.Clear();
            layout = new Layout(new Point(60, 30), new Point(120, 60));
            layout.Ramka();
            layout.Write("Press any key to login");
            Console.ReadKey();
            goto tuda;
        }
        else
        {
            layout.Write("Wrong answer :Press key");
            Console.ReadKey();
            goto tuda;
        }

        throw new Exception("Error");


    }
}
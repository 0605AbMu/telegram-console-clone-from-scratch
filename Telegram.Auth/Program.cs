
using ConsoleApp1;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;
using TelegramClient.Auth.UI;

internal class Program
{
   
   
    public static void Main()
    {
        Console.WriteLine("Hellow");

        Layout layout = new Layout(new System.Drawing.Point(60, 30) , new System.Drawing.Point(120, 60));
        layout.Ramka();
        layout.Write("salomlar hhhhhhhhhhhhhhhhhhaaa");

        IUserService userService = new UserService();
        AuthService authService = new AuthService(userService);
        RegistraionUI registraionUi = new RegistraionUI(authService);
        registraionUi.Registraion();
  
    }
}
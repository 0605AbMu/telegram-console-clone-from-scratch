// See https://aka.ms/new-console-template for more information

using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;
using TelegramClient.Auth.UI;

internal class Program
{
   
    static LoginUI loginUI = new LoginUI();
    public static void Main()
    {
        Console.WriteLine("Hellow");
        IUserService userService = new UserService();
        AuthService authService = new AuthService(userService);
        RegistraionUI registraionUi = new RegistraionUI(authService);
        registraionUi.Registraion();
        
    }
}
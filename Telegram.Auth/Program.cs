// See https://aka.ms/new-console-template for more information

<<<<<<< HEAD
using ConsoleApp1;
=======
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;
>>>>>>> 855e9e3d7f40f1b98330e2013de10039410552e0
using TelegramClient.Auth.UI;

internal class Program
{
    private ChangePasswordUI _changePasswordUi = new ChangePasswordUI();
    static LoginUI loginUI = new LoginUI();
    public static void Main()
    {
        Console.WriteLine("Hellow");
<<<<<<< HEAD
        Layout layout = new Layout(new System.Drawing.Point(60, 30) , new System.Drawing.Point(120, 60));
        layout.Ramka();
        layout.Write("salomlar hhhhhhhhhhhhhhhhhhaaa");
=======
        IUserService userService = new UserService();
        AuthService authService = new AuthService(userService);
        RegistraionUI registraionUi = new RegistraionUI(authService);
        registraionUi.Registraion();
        
>>>>>>> 855e9e3d7f40f1b98330e2013de10039410552e0
    }
}
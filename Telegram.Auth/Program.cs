
<<<<<<< HEAD
<<<<<<< HEAD
using ConsoleApp1;
=======
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;
>>>>>>> 855e9e3d7f40f1b98330e2013de10039410552e0
=======
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;
>>>>>>> 0d58f611a99ff54a5e9f0b62cf6403d9a6a4be04
using TelegramClient.Auth.UI;

internal class Program
{
   
   
    public static void Main()
    {
        Console.WriteLine("Hellow");
<<<<<<< HEAD
<<<<<<< HEAD
        Layout layout = new Layout(new System.Drawing.Point(60, 30) , new System.Drawing.Point(120, 60));
        layout.Ramka();
        layout.Write("salomlar hhhhhhhhhhhhhhhhhhaaa");
=======
=======
>>>>>>> 0d58f611a99ff54a5e9f0b62cf6403d9a6a4be04
        IUserService userService = new UserService();
        AuthService authService = new AuthService(userService);
        RegistraionUI registraionUi = new RegistraionUI(authService);
        registraionUi.Registraion();
        
<<<<<<< HEAD
>>>>>>> 855e9e3d7f40f1b98330e2013de10039410552e0
=======
>>>>>>> 0d58f611a99ff54a5e9f0b62cf6403d9a6a4be04
    }
}
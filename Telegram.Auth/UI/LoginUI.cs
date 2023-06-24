
using System.Drawing;
using ConsoleApp1;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Domain;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class LoginUI:ViewBase
{
    private readonly Context _context;
    private AuthService _authService;
    private Layout _layout;
  
    private IUserService _userService1;
<<<<<<< HEAD
    public LoginUI(Context context, AuthService authService)
    {
        _context = context;

        _authService = authService;
=======
    public LoginUI(Context context,Point TopPoint,Point bottomPoint)
    {
        _context = context;
        new Layout(TopPoint, bottomPoint);
        _authService = new AuthService(_userService1);
>>>>>>> c4476fdc81d664a752c657b454d526365898d15e
    }  


    public override void Home()
    {
        this.LoginView();
        base.Home();
    }


    // public string LogView()
    // {
    //     _layout.Ramka();
    //     _layout.Write("Enter your a phone number");
    //     var phoneNumber = _layout.Read();
    //     var phoneNumberLenght = phoneNumber.Length;
    //     if (phoneNumberLenght == "+998901231212".Length || phoneNumberLenght == 12 || phoneNumberLenght == 9)
    //     {
    //         return phoneNumber;
    //     }
    //
    //     return null;
    // }


    public void LoginView()
    {_layout.Ramka();
        _layout.Write("Phone Number");
        string phone = _layout.Read();
        
        _layout.Write("Password");
        string password = _layout.Read();
       var user = this._authService.Login(phone, password);
       _context.User = user;

    }
    
    
    
}
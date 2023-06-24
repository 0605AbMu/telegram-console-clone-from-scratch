
using System.Drawing;
using ConsoleApp1;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Domain;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class LoginUI:ViewBase
{
    private AuthService _authService;
  
    private IUserService _userService1;
    public LoginUI()
    {
        _authService = new AuthService(_userService1);
       
    }  
    private Layout _layout = new Layout(new Point(60,30), new Point(120,60));

    public string LogView()
    {
        _layout.Ramka();
        _layout.Write("Enter your a phone number");
        var phoneNumber = _layout.Read();
        var phoneNumberLenght = phoneNumber.Length;
        if (phoneNumberLenght == "+998901231212".Length || phoneNumberLenght == 12 || phoneNumberLenght == 9)
        {
            return phoneNumber;
        }

        return null;
    }


    public User LoginView()
    {
        _layout.Write("Phone Number");
        string phone = _layout.Read();
        
        _layout.Write("Password");
        string password = _layout.Read();
       var user = this._authService.Login(phone, password);

       return user;
    }
    
    
    
}
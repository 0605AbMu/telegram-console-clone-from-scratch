using System.Drawing;
using ConsoleApp1;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class LoginUI : ViewBase
{
    private readonly Context _context;
    private readonly AuthService _authService;
    private Layout _layout;
    private IUserService _userService1;

    public LoginUI(Context context, Layout layout, AuthService authService)
    {
        this._context = context;
        this._layout = layout;
        this._authService = authService;
    }


    public override void Home()
    {
        _layout.RowCount = 0;
        LoginView();
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
    {
        _layout.Ramka();
        _layout.Write("Phone Number");
        var phone = _layout.Read();

        _layout.Write("Password");
        var password = _layout.Read();
        var user = _authService.Login(phone, password);
        _context.User = user;
    }
}
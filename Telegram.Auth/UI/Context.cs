using System.Drawing;
using ConsoleApp1;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Domain;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class Context
{
    private readonly AuthService _authService;
    private readonly UserService _userService;

    private readonly LoginUI _loginUi;
    private readonly RegistraionUI _registraionUi;
    private ViewBase _viewBase;
    private readonly Layout _layout;


    public Context(Point topPoint, Point bottomPoint)
    {
        this._userService = new UserService();
        this._authService = new AuthService(this._userService);

        this._layout = new Layout(topPoint, bottomPoint);
            
        this._loginUi = new LoginUI(this, _layout, this._authService);
        this._registraionUi = new RegistraionUI(topPoint, bottomPoint);
        
        Activeview = _loginUi;
    }

    public ViewBase Activeview { get; set; }
    public User? User { get; set; }

    public void Start()
    {
        Activeview.Home();
    }

    public void ShowRegistration()
    {
        Activeview = _registraionUi;
    }

    public void ShowLogin()
    {
        Activeview = _loginUi;
    }
}
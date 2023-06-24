using System.Runtime.CompilerServices;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Domain;
using TelegramClient.Auth.Service;


namespace TelegramClient.Auth.UI;

public class Context
{
    private IUserService _iuserService;
    private AuthService _authService;
    private UserService _userService;
    private ViewBase _loginUi;
    private ViewBase _registraionUi;
    private ViewBase _viewBase;
    public ViewBase Activeview { get; set; }
    public User User { get; set; }

    public Context()
    {
        _viewBase = new ViewBase();
        this._authService = new AuthService(_userService);
        this._userService = new UserService();
        this._userService = new UserService();
        this._loginUi = new ViewBase();

    }

    public  void Start()
    {
       User= _viewBase.Homeview();

    }

    public void ShowRegistration() => this.Activeview = this._registraionUi;
    public void ShowLogin() => this.Activeview = this._loginUi;
}
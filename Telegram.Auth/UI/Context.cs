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
    private LoginUI _loginUi;
    private RegistraionUI _registraionUi;
    public User User { get; set; }

    public Context()
    {
        this._authService = new AuthService(_userService);
        this._userService = new UserService();
        this._userService = new UserService();
        this._loginUi = new LoginUI();

    }

    public  void Start()
    {
        
        _registraionUi.Registraion();
    }
}
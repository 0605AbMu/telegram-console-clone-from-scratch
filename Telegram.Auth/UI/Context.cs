using System.Drawing;
using System.Runtime.CompilerServices;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Domain;
using TelegramClient.Auth.Service;


namespace TelegramClient.Auth.UI;

public class Context
{
 
    private LoginUI _loginUi;
    private RegistraionUI _registraionUi;
    private ViewBase _viewBase;
    private readonly UserService userService;
    private readonly AuthService authService;
    public ViewBase Activeview { get; set; }
    public User User { get; set; }

    public Context(Point topPoint,Point bottomPoint )
    {
<<<<<<< HEAD
        userService = new UserService();
        authService = new AuthService(userService);
        _loginUi = new LoginUI(this, authService);
        _registraionUi = new RegistraionUI(authService);
=======
        _loginUi = new LoginUI(this,topPoint,bottomPoint);
        _registraionUi = new RegistraionUI(topPoint,bottomPoint);
>>>>>>> c4476fdc81d664a752c657b454d526365898d15e
        Activeview = _loginUi;
    }

    public  void Start()
    {
        Activeview.Home();

    }

    public void ShowRegistration() => this.Activeview = this._registraionUi;
    public void ShowLogin() => this.Activeview = this._loginUi;
}
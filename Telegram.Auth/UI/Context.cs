using System.Drawing;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Domain;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class Context
{
    private readonly AuthService authService;
    private readonly UserService userService;

    private readonly LoginUI _loginUi;
    private readonly RegistraionUI _registraionUi;
    private ViewBase _viewBase;

    public Context(Point topPoint, Point bottomPoint)
    {
        userService = new UserService();
        authService = new AuthService(userService);
        _loginUi = new LoginUI(this, topPoint, bottomPoint);
        _registraionUi = new RegistraionUI(topPoint, bottomPoint);
        Activeview = _loginUi;
    }

    public ViewBase Activeview { get; set; }
    public User User { get; set; }

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
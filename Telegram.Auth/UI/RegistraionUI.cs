using System.Drawing;
using ConsoleApp1;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class RegistraionUI : ViewBase
{
    private readonly Layout _layout;
    private readonly AuthService _authService;

    public RegistraionUI(Point topPoint, Point bottomPoint)
    {
        _authService = new AuthService(new UserService());
        _layout = new Layout(topPoint, bottomPoint);
    }

    public override void Home()
    {
        Registraion();
        base.Home();
    }

    public Guid Registraion()
    {
        _layout.Ramka();

        _layout.Write("User Name");
        var name = _layout.Read();

        _layout.Write("User Phone Number");
        var phone = _layout.Read();

        _layout.Write("User Password");
        var password = _layout.Read();

        var clientId = Guid.NewGuid();

        _authService.Registration(name, password, phone, clientId);
        return clientId;
    }
}
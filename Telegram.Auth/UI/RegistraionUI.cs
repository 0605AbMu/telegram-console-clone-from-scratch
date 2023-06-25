using System.Drawing;
using ConsoleApp1;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class RegistraionUI:ViewBase
{
    private AuthService _authService;
    private readonly Layout _layout;

    public RegistraionUI(Point topPoint,Point bottomPoint)
    {
        this._authService = new AuthService(new UserService());
        _layout = new Layout(topPoint, bottomPoint);
    }

    public override void Home()
    {
        this.Registraion();
        base.Home();
    }

    public Guid Registraion()
    {
        _layout.Ramka();
        
       _layout.Write("User Name");
       string name = _layout.Read();
       
       _layout.Write("User Phone Number");
       string phone = _layout.Read();
     
       _layout.Write("User Password");
       string password = _layout.Read();

       var clientId = Guid.NewGuid();
       
       this._authService.Registration(name , password , phone, clientId);
       return clientId;
    }
    
         
}
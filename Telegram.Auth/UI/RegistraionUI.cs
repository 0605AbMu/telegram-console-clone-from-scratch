using System.Drawing;
using ConsoleApp1;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class RegistraionUI
{
    private AuthService _authService;
    public RegistraionUI()
    {
        this._authService = new AuthService(new UserService());
    }

    public void Registraion()
    {
        Layout _layout = new Layout( new Point(60,30 ), new Point(120 ,60 ));
        _layout.Ramka();

       
       _layout.Write("User Name");
       string name = _layout.Read();
       
       _layout.Write("User Phone Number");
       string phone = _layout.Read();
     
       _layout.Write("User Password");
       string password = _layout.Read();
     
       
       this._authService.Registration(name , password , phone);

    }
    
         
}
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
    public ViewBase Activeview { get; set; }
    public User User { get; set; }

    public Context()
    {
        _viewBase = new ViewBase();
        this._loginUi = new LoginUI();

    }

    public  void Start()
    {
       User= _viewBase.Homeview();

    }

    public void ShowRegistration() => this.Activeview = this._registraionUi;
    public void ShowLogin() => this.Activeview = this._loginUi;
}
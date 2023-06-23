using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class Context
{
    private IUserService _userService;
    public AuthService AuthService;
    public RegistraionUI RegistraionUi;
    public ChangePasswordUI ChangePasswordUi;
    public LoginUI LoginUi;

    public Context()
    {
        LoginUi = new LoginUI();
        ChangePasswordUi = new ChangePasswordUI();
        RegistraionUi = new RegistraionUI();
        AuthService = new AuthService(_userService );
        
    }
}
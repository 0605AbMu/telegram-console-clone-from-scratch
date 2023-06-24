using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class Context
{
    private IUserService _userService;
    public AuthService AuthService;
    public ChangePasswordUI ChangePasswordUi;
    public LoginUI LoginUi;

    public Context()
    {
        LoginUi = new LoginUI();
        ChangePasswordUi = new ChangePasswordUI();
        AuthService = new AuthService(_userService );
        
    }

    
}
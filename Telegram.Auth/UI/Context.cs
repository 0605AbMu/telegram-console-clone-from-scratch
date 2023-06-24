using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;


namespace TelegramClient.Auth.UI;

public class Context
{
    private IUserService _iuserService;
    private AuthService _authService;
    private UserService _userService;
    private LoginUI _loginUi;
    private ChangePasswordUI _changePasswordUi;
    private RegistraionUI _registraionUi;

    public Context()
    {
        this._authService = new AuthService(_userService);
        this._userService = new UserService();
        this._userService = new UserService();
        this._loginUi = new LoginUI();
        this._changePasswordUi = new ChangePasswordUI();
    }
}
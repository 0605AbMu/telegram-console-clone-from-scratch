using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Service;

namespace TelegramClient.Auth.UI;

public class Context
{
    public AuthService AuthService;
    private IUserService I_userService = new UserService();
    public Context()
    {
        AuthService = new AuthService(I_userService);
    }
}
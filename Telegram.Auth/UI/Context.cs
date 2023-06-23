using TelegramClient.Auth.Auth;

namespace TelegramClient.Auth.UI;

public class Context
{
    public UserService _userService;
    

    public Context()
    {
        _userService = new UserService();
    }
}